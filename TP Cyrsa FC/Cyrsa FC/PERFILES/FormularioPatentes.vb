
Public Class FormularioPatentes

    Dim gestor_patente As New BLL.Gestor_Patente
    Dim gp As New BLL.Gestor_GrupoPatentes

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        BE.Modelo.GetInstance().PatenteRaiz.MostrarEnTreeview(Me.treePatentes.Nodes)
    End Sub

    Private Sub agregarPatenteToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AgregarPatenteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AgregarPatenteToolStripMenuItem.Click
        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

        If TypeOf nodo.Tag Is BE.Grupo_Pantentes Then



            Dim padre As BE.Grupo_Pantentes = nodo.Tag

            Dim frm As New FormularioDialogoPatentes
            frm.ShowDialog()
            'Le paso en el FormularioDialogoPatentes el nombre de la patente y e indico formulario de acceso.
            Dim nombre As String = frm.Nombre
            Dim formulario As String = frm.Formulario



            If (nombre.Length > 0) And (formulario.Length > 0) Then

                Dim nombre_padre As String

                Dim patente As New BE.Patente
                Dim nodoNuevo As New TreeNode


                nodoNuevo.Text = nombre
                patente.Nombre = nombre
                patente.Formulario = formulario
                nodoNuevo.Tag = patente

                nodo.Nodes.Add(nodoNuevo)
                'En el punto de abajo estoy agregando a una lista de p abstracta una patente comun
                padre.list.Add(patente)
                gestor_patente.registar_patente(patente)

                nombre_padre = nodoNuevo.Parent.Tag.ToString
                If padre.Nombre = nombre_padre Then
                    BE.Grupo_Pantentes.GetInstance.Agregar_rol(patente)

                End If
                

                Dim frmconfirmacion As New Form_Confirmacion
                frmconfirmacion.ShowDialog()
                Dim rpta As String = frmconfirmacion.Formulario

                If rpta = "SI" Then
                    gp.registar_gpatente(padre)
                End If


            End If
        End If
    End Sub

    Private Sub AgregarGruposDePatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarGruposDePatenteToolStripMenuItem.Click
        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

        If TypeOf nodo.Tag Is BE.Grupo_Pantentes Then

            Dim padre As BE.Grupo_Pantentes = nodo.Tag

            Dim nombre As String = InputBox("Ingrese el nombre")

            If nombre.Length > 0 Then

                Dim grupo As New BE.Grupo_Pantentes
                Dim nodoNuevo As New TreeNode

                nodoNuevo.Text = nombre
                grupo.Nombre = nombre
                nodoNuevo.Tag = grupo

                nodo.Nodes.Add(nodoNuevo)
                padre.list.Add(grupo)
                'MessageBox.Show(padre.Nombre)


            End If
        End If
    End Sub

    Private Sub EliminarElementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarElementoToolStripMenuItem.Click
        Dim nodo As TreeNode = Me.treePatentes.SelectedNode

        If TypeOf nodo.Tag Is BE.Grupo_Pantentes Then

            If Not nodo.Parent Is Nothing Then

                Dim padre As BE.Grupo_Pantentes = nodo.Parent.Tag()

                nodo.Remove()
                padre.list.Remove(nodo.Tag)
            End If
        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()

    End Sub

    Private Sub Familia_Click(sender As Object, e As EventArgs) Handles Familia.Click

    End Sub

    Private Sub FormularioPatentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.conectar()

        MostrarEnTreeView(treePatentes)




    End Sub





    Public Function MostrarEnTreeView(pTreeView As System.Windows.Forms.TreeView) As System.Windows.Forms.TreeView
        Try
            Dim vLista As New List(Of BE.PatenteAbstracta)
            Dim gestor As New BLL.Gestor_Patente
            vLista = gestor.listarpatentes
            For Each r In vLista

                Dim vNode As System.Windows.Forms.TreeNode = pTreeView.Nodes.Add(r.NOMBRE)
                vNode.Tag = r
                AgregarNodos(vNode, vNode.Tag)
            Next

        Catch ex As Exception

        End Try
        Return pTreeView
    End Function


    Private Sub AgregarNodos(pTreeNode As System.Windows.Forms.TreeNode, pContenedor As BE.Grupo_Pantentes)
        For Each vFiguraContenedor As BE.PatenteAbstracta In pContenedor.list
            Dim vTreeNode As New System.Windows.Forms.TreeNode
            vTreeNode.Text = vFiguraContenedor.Nombre
            vTreeNode.Tag = vFiguraContenedor
            If TypeOf vFiguraContenedor Is BE.Grupo_Pantentes Then
                Dim vContenedor As BE.Grupo_Pantentes = DirectCast(vFiguraContenedor, BE.Grupo_Pantentes)
                AgregarNodos(vTreeNode, vContenedor)
            End If
            pTreeNode.Nodes.Add(vTreeNode)
        Next
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnvolvermenu.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub

    Private Sub treePatentes_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treePatentes.AfterSelect

    End Sub
End Class