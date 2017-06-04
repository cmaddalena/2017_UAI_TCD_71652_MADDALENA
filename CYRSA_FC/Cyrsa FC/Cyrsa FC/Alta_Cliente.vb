Public Class Alta_Cliente


    Private Sub MENUPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CyrsaFC_Menu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliente As New BE.CLIENTE
        Dim cuota As New BE.CUOTAS
        Dim gestor As New BLL.Gestor_Usuario
        Dim USUARIO As New BE.Usuario
        Dim crypto As New BE.CryptoManager

        If Module1.ValidarInt(TextBox1) And Module1.ValidarText(TextBox2) And Module1.ValidarText(TextBox3) And Module1.ValidarText(TextBox4) And Module1.ValidarText(TextBox7) And Module1.Validarfecha(DateTimePicker1) Then

            cliente.DNI = TextBox1.Text
            cliente.Nombre = TextBox2.Text
            cliente.Apellido = TextBox3.Text
            cliente.Mail = TextBox4.Text
            cliente.FechaNac = DateTimePicker1.Value
            cuota.MONTO = TextBox6.Text

            USUARIO.CLAVE = crypto.Encrypt(TextBox7.Text)

            ' USUARIO.Nombre = cliente.Nombre And "." And cliente.Apellido


            gestor.registarcliente(cliente, cuota, USUARIO)


        Else

            MessageBox.Show("REVISE POR FAVOR LOS DATOS CARGADOS")

        End If



    End Sub

    Private Sub Alta_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()

    End Sub

    

End Class