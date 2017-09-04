Public Class Bitacora

    Private Sub Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bll As New BLL.LogManager

        DataGridView1.DataSource = bll.Buscar_Log(DateTimePicker1.Value, ComboBox1.SelectedItem)

    End Sub
End Class