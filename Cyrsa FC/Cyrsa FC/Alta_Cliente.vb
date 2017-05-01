Public Class Alta_Cliente


    Private Sub MENUPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUPRINCIPALToolStripMenuItem.Click
        CyrsaFC_Menu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliente As New BE.CLIENTE
        Dim cuota As New BE.CUOTAS
        Dim gestor As New BLL.Gestor_Cliente
        Dim USUARIO As New BE.Usuario
        Dim crypto As New BE.CryptoManager

        If ValidarInt(TextBox1) And ValidarText(TextBox2) And ValidarText(TextBox3) And ValidarText(TextBox4) And ValidarText(TextBox5) And ValidarText(TextBox7) Then

            cliente.DNI = TextBox1.Text
            cliente.Nombre = TextBox2.Text
            cliente.Apellido = TextBox3.Text
            cliente.Mail = TextBox4.Text
            cliente.FechaNac = TextBox5.Text
            cuota.MONTO = TextBox6.Text

            USUARIO.CLAVE = crypto.Encrypt(TextBox7.Text)

            ' USUARIO.Nombre = cliente.Nombre And "." And cliente.Apellido


            gestor.registar(cliente, cuota, USUARIO)


        Else

            MessageBox.Show("REVISE POR FAVOR LOS DATOS CARGADOS")

        End If



    End Sub

    Private Sub Alta_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()

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

    'Private Function ValidarSingle(text As TextBox) As Boolean
    '    If Not String.IsNullOrWhiteSpace(text.Text) And is(text.Text) Then
    '        Return True
    '    End If
    '    Return False
    'End Function

    Private Function ValidarFecha(text As TextBox) As Boolean
        If Not String.IsNullOrWhiteSpace(text.Text) And IsDate(text.Text) Then
            Return True
        End If
        Return False
    End Function



End Class