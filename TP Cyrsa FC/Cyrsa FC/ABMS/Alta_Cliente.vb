Public Class Alta_Cliente
    Implements BE.IObservador


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
            Dim FA As String

            FA = gestor.registarcliente(cliente, cuota, USUARIO)

            'MessageBox.Show(FA)
            Module1.Log.DESCRIPCION = "Se ha dado de alta el cliente " & cliente.Nombre
            Module1.Log.TIPO = 2
            Module1.gestorlog.Guardar_Log(Module1.Log)



        Else

            MessageBox.Show(Module1.TRADUCIR_MSJ(5))

        End If


        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next

    End Sub

    Private Sub Alta_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        actualizaridioma()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()

    End Sub

    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        Module1.cambiar_lenguaje(BE.Lenguaje_form.getinstance.NOMBRE, Me)
    End Sub
End Class