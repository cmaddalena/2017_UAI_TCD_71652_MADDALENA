
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
                MessageBox.Show(padre.Nombre)


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

    End Sub
End Class