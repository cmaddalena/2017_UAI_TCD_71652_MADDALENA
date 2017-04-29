Public Class Form_Confirmacion

    Private Sub Form_Confirmacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        ComboBox1.Items.Add("SI")
        ComboBox1.Items.Add("NO")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub


    Public Function Formulario() As String
        Dim rpta As String

        rpta = ComboBox1.SelectedItem

        Return rpta
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class