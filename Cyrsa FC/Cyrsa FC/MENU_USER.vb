Public Class MENU_USER

    Sub inicio(p As List(Of BE.Patente))
        Dim c As Integer

        For Each i In p
            Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly

            Dim f As Form = CType(asm.CreateInstance(i.Formulario), Form)


            '   f.Name = i.Formulario

            AToolStripMenuItem.DropDown.Items.Add(i.Nombre)
            ' AToolStripMenuItem. = i.Formulario
            'MenuUser.Items.Add(i.Nombre)

            ' MenuUser.Items.

            'AddHandler AToolStripMenuItem.DropDownItemClicked, AddressOf f.Show
            AddHandler AToolStripMenuItem.DropDownItems.Item(c).Click, AddressOf f.Show

            c = c + 1


            Me.Show()

            'aca debo agregar funcion para abrir formulario en ese item   MenuUser

        Next

    End Sub


    '   Public Sub openform(p As BE.Patente)
    '    End Sub


    Private Sub MENU_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

    End Sub

    Private Sub AToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
End Class