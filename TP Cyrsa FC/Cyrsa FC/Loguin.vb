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

        ' Dim patentes As New List(Of BE.Patente)
        If ValidarText(LoginUser) = True Or ValidarText(LoginPassword) = True Then
            user.Nombre = LoginUser.Text
            user.CLAVE = crypto.Encrypt(LoginPassword.Text)
            Module1.usrsession = user
            actualizaridioma()

            Module1.Log.DESCRIPCION = "Se ha logueado el usuario " & user.Nombre
            Module1.Log.TIPO = 2
            Module1.gestorlog.Guardar_Log(Module1.Log)


            MENU_USER.Show()
            Me.Hide()
        Else


                    MessageBox.Show(Module1.TRADUCIR_MSJ(4))

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
        Dim id As Integer
        Try
            nombre_lenguaje_usr = gestorusr.leer_idioma_usr(Module1.usrsession).NOMBRE
            id = gestorusr.leer_idioma_usr(Module1.usrsession).ID
            ' BE.Lenguaje_form.getinstance.NOMBRE = nombre_lenguaje_usr
            ' BE.Lenguaje_form.getinstance.ID = id
            BE.Lenguaje.getinstance.NOMBRE = nombre_lenguaje_usr
            BE.Lenguaje.getinstance.ID = id

        Catch ex As Exception

        End Try
    End Sub
End Class