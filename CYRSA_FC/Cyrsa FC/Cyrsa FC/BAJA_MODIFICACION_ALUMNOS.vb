Public Class BAJA_MODIFICACION_ALUMNOS
    Dim gestor As New BLL.Gestor_persona
    Private Sub BAJA_MODIFICACION_ALUMNOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ListBox1.DataSource = gestor.listar_cliente


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliente As New BE.CLIENTE
        Dim user As New BE.Usuario
    
        cliente.DNI = txtbdocentesdni.Text
        cliente.Nombre = txtbdocentesnombre.Text
        cliente.Apellido = txtbdocentesapellido.Text
        cliente.Mail = txtbdocentesmail.Text
        cliente.FechaNac = dtpbdocentesfechacontrato.Value
        user.CLAVE = txtbdocentessueldo.Text

        gestor.update_persona(cliente, user)



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim cliente As New BE.CLIENTE
        Dim user As New BE.Usuario

        cliente = DirectCast(ListBox1.SelectedItem, BE.CLIENTE)

        txtbdocentesdni.Text = cliente.DNI
        txtbdocentesnombre.Text = cliente.Nombre
        txtbdocentesapellido.Text = cliente.Apellido
        txtbdocentesmail.Text = cliente.Mail
        dtpbdocentesfechacontrato.Value = cliente.FechaNac
        ' user.CLAVE = TextBox7.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cliente As New BE.CLIENTE
        Dim user As New BE.Usuario

        cliente.DNI = txtbdocentesdni.Text
        cliente.Nombre = txtbdocentesnombre.Text
        cliente.Apellido = txtbdocentesapellido.Text
        cliente.Mail = txtbdocentesmail.Text
        cliente.FechaNac = dtpbdocentesfechacontrato.Value
        user.CLAVE = txtbdocentessueldo.Text

        gestor.eliminar_persona(cliente, user)

        txtbdocentesdni.Text = ""
        txtbdocentesnombre.Text = ""
        txtbdocentesapellido.Text = ""
        txtbdocentesmail.Text = ""


        ListBox1.DataSource = gestor.listar_cliente



    End Sub
End Class