Public Class MENU_USER

    Sub inicio(p As List(Of BE.Patente))

        For Each i In p
            AToolStripMenuItem.DropDown.Items.Add(i.Nombre)
            ' AToolStripMenuItem. = i.Formulario
            'MenuUser.Items.Add(i.Nombre)

            ' MenuUser.Items.

            Me.Show()

            'aca debo agregar funcion para abrir formulario en ese item   MenuUser

        Next

    End Sub



    Private Sub MENU_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

    End Sub
End Class