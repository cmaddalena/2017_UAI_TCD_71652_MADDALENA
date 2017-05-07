Public Class CyrsaFC_Menu
    Private Sub ALTASOCIOToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Alta_Cliente.Show()

    End Sub

    Private Sub CyrsaFC_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GESTIONESCUELAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GESTIONESCUELAToolStripMenuItem.Click
        Dim f As New Loguin
        f.Show()


    End Sub
End Class