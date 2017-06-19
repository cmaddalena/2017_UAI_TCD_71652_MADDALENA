Public Class Loguin
    Implements BE.IObservador

    Dim gestor As New BLL.Gestor_Patente
    Dim gestorusr As New BLL.Gestor_Usuario
    Dim crypto As New BE.CryptoManager

    Private Sub FormularioDialogoElegirUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conectar()

        Catch
            Dim frm As New Creacion_BBDD
            frm.Show()
        End Try

    End Sub

    Private Sub Familia_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New BE.Usuario
        Dim patentes As New List(Of BE.Patente)
        If ValidarText(LoginUser) = True And ValidarText(LoginPassword) = True Then
            user.Nombre = LoginUser.Text
            user.CLAVE = crypto.Encrypt(LoginPassword.Text)

            Try
                patentes = gestorusr.listar_patentes_usuario(user)

                If patentes.Count = 0 Then

                    MessageBox.Show("Usted no posee acceso ó perfil para ingresar al sistema - Comuniquese con su adiministrador")

                Else
                    '  ListBox1.DataSource = patentes
                    Dim frm As New MENU_USER
                    '  frm.inicio(patentes)


                    InitializeComponent()
                    For Each p In patentes
                        BE.Grupo_Pantentes.GetInstance.Agregar_rol(p)

                    Next


                    MENU_USER.Show()
                    Module1.usrsession = user
                    actualizaridioma()
                    Me.Hide()

                End If
            Catch

            End Try

        Else

            MessageBox.Show("Ingrese valores correctos en ambos campos")
        End If


    End Sub


    Private Function ValidarText(text As TextBox) As Boolean
        If Not String.IsNullOrWhiteSpace(text.Text) Then
            Return True
        End If
        Return False
    End Function


    Private Function ValidarInt(text As TextBox) As Boolean
        If Not String.IsNullOrWhiteSpace(text.Text) And IsNumeric(text.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Function ValidarFecha(text As TextBox) As Boolean
        If Not String.IsNullOrWhiteSpace(text.Text) And IsDate(text.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        Dim nombre_lenguaje_usr As String
        Try
            nombre_lenguaje_usr = gestorusr.leer_idioma_usr(Module1.usrsession).NOMBRE
            BE.Lenguaje_form.getinstance.NOMBRE = nombre_lenguaje_usr

        Catch ex As Exception

        End Try
    End Sub
End Class