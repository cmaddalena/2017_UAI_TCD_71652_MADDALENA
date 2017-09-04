
Public Class MENU_USER
    Implements BE.IObservador
    Dim gestorusr As New BLL.Gestor_Usuario
    Dim idioma As String
    Dim idiomaseleccionado As String

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        '' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'If BE.Grupo_Pantentes.GetInstance.patentes.Count > 0 Then
        '    For Each p In BE.Grupo_Pantentes.GetInstance.patentes
        '        BE.Grupo_Pantentes.GetInstance.patentes.Remove(p)
        '    Next
        'End If

    End Sub

    Public Sub traer_patentes()


        Dim patentes As New List(Of BE.Patente)

        Try
            patentes = gestorusr.listar_patentes_usuario(Module1.usrsession)

            If patentes.Count = 0 Then

                ' MessageBox.Show("Usted no posee acceso ó perfil para ingresar al sistema - Comuniquese con su adiministrador")

                MessageBox.Show(Module1.TRADUCIR_MSJ(3))
            Else
                '  ListBox1.DataSource = patentes
                '  Dim frm As New MENU_USER
                '  frm.inicio(patentes)



                If BE.Grupo_Pantentes.GetInstance.patentes.Count > 0 Then

                    '    Dim patt As New BE.Patente
                    '   Dim patis = (From p In patentes Where BE.Grupo_Pantentes.GetInstance.patentes.Equals(False) Select p)

                    'BE.Grupo_Pantentes.GetInstance.Agregar_rol(patt)

                Else
                    For Each p In patentes

                        BE.Grupo_Pantentes.GetInstance.Agregar_rol(p)

                    Next


                End If
            End If
        Catch

        End Try


    End Sub


    Private Sub MENU_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        traer_patentes()

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

            comboidiomas.Items.Add(l)


            'idioma = l.NOMBRE
            'IDIOMASToolStripMenuItem.DropDown.Items.Add(idioma)

            'If l.NOMBRE = "ESPAÑOL" Then
            '    AddHandler IDIOMASToolStripMenuItem.DropDownItems.Item(c2).Click, AddressOf mostrar_idioma

            'ElseIf l.NOMBRE = "ENGLISH" Then
            '    AddHandler IDIOMASToolStripMenuItem.DropDownItems.Item(c2).Click, AddressOf mostrar_idioma2
            'End If
            'c2 = c2 + 1

        Next

        '    MessageBox.Show(Module1.TRADUCIR_MSJ(2))



    End Sub



    'les paso al sujeto concreto lenguaje_form el tipo de idioma para que lo pase al sujeto
    Public Sub mostrar_idioma(idioma As String)
        ' MessageBox.Show("Español")
        idiomaseleccionado = idioma
        actualizaridioma()
    End Sub


    'Public Sub mostrar_idioma2()
    '    ' MessageBox.Show("English")
    '    idiomaseleccionado = "ENGLISH"
    '    actualizaridioma()
    'End Sub


    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        'estoy seteando a la clase Lenguaje a traves de lenguaje_form, el nombre de idioma
        BE.Lenguaje_form.getinstance.NOMBRE = idiomaseleccionado

        Dim leng As New BE.Lenguaje_form
        MessageBox.Show(Module1.TRADUCIR_MSJ(9) & leng.Language.NOMBRE)

        Dim gestor_usuario As New BLL.Gestor_Usuario
        gestor_usuario.actualizar_idioma_usr(Module1.usrsession, leng.Language)


    End Sub



    Private Sub IDIOMASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDIOMASToolStripMenuItem.Click

    End Sub

    Private Sub comboidiomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboidiomas.SelectedIndexChanged
        mostrar_idioma(comboidiomas.SelectedItem.ToString)

    End Sub
End Class