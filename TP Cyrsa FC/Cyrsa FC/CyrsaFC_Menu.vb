Public Class CyrsaFC_Menu


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim f As New Loguin
        f.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Height = 80
        PictureBox2.Width = 90
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Me.Close()

    End Sub


    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Height = 80
        PictureBox1.Width = 90

    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Height = 80
        PictureBox3.Width = 90
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Height = 80
        PictureBox2.Width = 90
    End Sub

    Private Sub CyrsaFC_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CyrsaFC_Menu_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        PictureBox2.Height = 88
        PictureBox2.Width = 98
        PictureBox1.Height = 88
        PictureBox1.Width = 98
        PictureBox3.Height = 88
        PictureBox3.Width = 98

    End Sub
End Class