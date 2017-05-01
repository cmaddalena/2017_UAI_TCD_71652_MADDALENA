Public Class Loguin
    Dim gestor As New BLL.Gestor_Patente
    Dim crypto As New BE.CryptoManager

    Private Sub FormularioDialogoElegirUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
    End Sub

    Private Sub Familia_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New BE.Usuario
        Dim patentes As New List(Of BE.Patente)
        If ValidarText(LoginUser) = True And ValidarText(LoginPassword) = True Then
            user.Nombre = LoginUser.Text
            user.CLAVE = crypto.Encrypt(LoginPassword.Text)

            patentes = gestor.listar_patentes_usuario(user)

            If patentes.Count = 0 Then

                MessageBox.Show("Usted no posee acceso ó perfil para ingresar al sistema - Comuniquese con su adiministrador")

            Else
                ListBox1.DataSource = patentes
                Dim frm As New MENU_USER
                frm.inicio(patentes)


            End If

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




End Class