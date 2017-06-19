Public Class ALTA_PROFESOR
    Implements BE.IObservador

    Private Sub bregistrarprofesor_Click(sender As Object, e As EventArgs) Handles bregistrarprofesor.Click
        Dim gestordocente As New BLL.Gestor_Usuario

        Dim profesor As New BE.PROFESOR
        Dim usuario As New BE.Usuario


        profesor.DNI = TextBox1.Text
        profesor.Nombre = TextBox2.Text
        profesor.Apellido = TextBox3.Text
        profesor.Mail = TextBox4.Text
        profesor.FechaNac = DateTimePicker1.Value
        profesor.SUELDO = TextBox6.Text

        usuario.CLAVE = TextBox7.Text

        gestordocente.registrardocente(profesor, usuario)



    End Sub

    Private Sub ALTA_PROFESOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizaridioma()

    End Sub


    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        Module1.cambiar_lenguaje(BE.Lenguaje_form.getinstance.NOMBRE, Me)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub
End Class