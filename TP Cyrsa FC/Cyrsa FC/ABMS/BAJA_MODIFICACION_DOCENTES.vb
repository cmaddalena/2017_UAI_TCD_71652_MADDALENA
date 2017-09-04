Public Class BAJA_MODIFICACION_PERSONAL
    Implements BE.IObservador

    Dim gestor As New BLL.Gestor_persona


    Private Sub BAJA_MODIFICACION_DOCENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizaridioma()
        ListBox1.DataSource = gestor.listar_docente


    End Sub


    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        Module1.cambiar_lenguaje(BE.Lenguaje_form.getinstance.NOMBRE, Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliente As New BE.PROFESOR
        Dim user As New BE.Usuario

        cliente.DNI = TextBox1.Text
        cliente.Nombre = TextBox2.Text
        cliente.Apellido = TextBox3.Text
        cliente.Mail = TextBox4.Text
        cliente.FechaNac = DateTimePicker1.Value
        user.CLAVE = TextBox7.Text
        cliente.SUELDO = TextBox5.Text
        gestor.update_docente(cliente, user)



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim docente As New BE.PROFESOR
        Dim user As New BE.Usuario

        docente = DirectCast(Me.ListBox1.SelectedItem, BE.PROFESOR)

        TextBox1.Text = docente.DNI
        TextBox2.Text = docente.Nombre
        TextBox3.Text = docente.Apellido
        TextBox4.Text = docente.Mail
        DateTimePicker1.Value = docente.FechaNac
        TextBox5.Text = docente.SUELDO

        ' user.CLAVE = TextBox7.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cliente As New BE.PROFESOR
        Dim user As New BE.Usuario

        cliente.DNI = TextBox1.Text
        cliente.Nombre = TextBox2.Text
        cliente.Apellido = TextBox3.Text
        cliente.Mail = TextBox4.Text
        cliente.FechaNac = DateTimePicker1.Value
        user.CLAVE = TextBox7.Text

        gestor.eliminar_docente(cliente, user)

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""


        ListBox1.DataSource = gestor.listar_docente



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub
End Class