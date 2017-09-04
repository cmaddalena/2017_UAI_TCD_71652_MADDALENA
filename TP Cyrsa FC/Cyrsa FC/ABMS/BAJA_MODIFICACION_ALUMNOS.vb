Public Class BAJA_MODIFICACION_ALUMNOS
    Implements BE.IObservador

    Dim gestor As New BLL.Gestor_persona
    Private Sub BAJA_MODIFICACION_ALUMNOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizaridioma()

        ListBox1.DataSource = gestor.listar_cliente


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliente As New BE.CLIENTE
        Dim user As New BE.Usuario
    
        cliente.DNI = txtbdocentesdni.Text
        cliente.Nombre = txtbdocentesnombre.Text
        cliente.Apellido = txtbdocentesapellido.Text
        cliente.Mail = txtbdocentesmail.Text
        cliente.FechaNac = dtpbdocentesfechanac.Value
        user.CLAVE = txtbdocentespass.Text

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
        dtpbdocentesfechanac.Value = cliente.FechaNac
        ' user.CLAVE = TextBox7.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cliente As New BE.CLIENTE
        Dim user As New BE.Usuario

        cliente.DNI = txtbdocentesdni.Text
        cliente.Nombre = txtbdocentesnombre.Text
        cliente.Apellido = txtbdocentesapellido.Text
        cliente.Mail = txtbdocentesmail.Text
        cliente.FechaNac = dtpbdocentesfechanac.Value
        user.CLAVE = txtbdocentespass.Text

        gestor.eliminar_persona(cliente, user)

        txtbdocentesdni.Text = ""
        txtbdocentesnombre.Text = ""
        txtbdocentesapellido.Text = ""
        txtbdocentesmail.Text = ""


        ListBox1.DataSource = gestor.listar_cliente



    End Sub



    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        Module1.cambiar_lenguaje(BE.Lenguaje_form.getinstance.NOMBRE, Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub
End Class