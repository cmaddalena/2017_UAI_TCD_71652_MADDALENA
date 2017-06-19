
Public Class MENU_USER
    Implements BE.IObservador

    Dim idioma As String
    Dim idiomaseleccionado As String




    Private Sub MENU_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim c As Integer
        Dim c2 As Integer

        For Each i In BE.Grupo_Pantentes.GetInstance.patentes
            Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly

            Dim f As Form = CType(asm.CreateInstance(DirectCast(i, BE.Patente).Formulario), Form)

            AToolStripMenuItem.DropDown.Items.Add(i.Nombre)
            AddHandler AToolStripMenuItem.DropDownItems.Item(c).Click, AddressOf f.Show
            AddHandler AToolStripMenuItem.DropDownItems.Item(c).Click, AddressOf Me.Close

            c = c + 1

        Next

        For Each l In Module1.listar_lenguajes


            idioma = l.NOMBRE
            IDIOMASToolStripMenuItem.DropDown.Items.Add(idioma)

            If l.NOMBRE = "ESPAÑOL" Then
                AddHandler IDIOMASToolStripMenuItem.DropDownItems.Item(c2).Click, AddressOf mostrar_idioma

            ElseIf l.NOMBRE = "ENGLISH" Then
                AddHandler IDIOMASToolStripMenuItem.DropDownItems.Item(c2).Click, AddressOf mostrar_idioma2
            End If
            c2 = c2 + 1

        Next
    End Sub



    'les paso al sujeto concreto lenguaje_form el tipo de idioma para que lo pase al sujeto
    Public Sub mostrar_idioma()
        ' MessageBox.Show("Español")
        idiomaseleccionado = "ESPAÑOL"
        actualizaridioma()
    End Sub


    Public Sub mostrar_idioma2()
        ' MessageBox.Show("English")
        idiomaseleccionado = "ENGLISH"
        actualizaridioma()
    End Sub


    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        'estoy seteando a la clase Lenguaje a traves de lenguaje_form, el nombre de idioma
        BE.Lenguaje_form.getinstance.NOMBRE = idiomaseleccionado

        Dim leng As New BE.Lenguaje_form
        MessageBox.Show("A Partir de ahora su lenguaje en CyrsaFC será: " & leng.Language.NOMBRE)

        Dim gestor_usuario As New BLL.Gestor_Usuario
        gestor_usuario.actualizar_idioma_usr(Module1.usrsession, leng.Language)


    End Sub

    Private Sub IDIOMASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDIOMASToolStripMenuItem.Click

    End Sub
End Class