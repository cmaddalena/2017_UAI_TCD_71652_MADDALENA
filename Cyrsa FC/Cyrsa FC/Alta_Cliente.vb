Public Class Alta_Cliente
    Private Sub MENUPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUPRINCIPALToolStripMenuItem.Click
        CyrsaFC_Menu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliente As New BE.CLIENTE
        Dim cuota As New BE.CUOTAS
        Dim gestor As New BLL.Gestor_Cliente

        cliente.DNI = TextBox1.Text
        cliente.Nombre = TextBox2.Text
        cliente.Apellido = TextBox3.Text
        cliente.Mail = TextBox4.Text
        cliente.FechaNac = TextBox5.Text
        cuota.MONTO = TextBox6.Text


        gestor.registar(cliente, cuota)


    End Sub
End Class