﻿Public Class FormularioUsuarios
    Dim gestor As New BLL.Gestor_Usuario
    Dim gestorgrupos As New BLL.Gestor_GrupoPatentes
    Dim familias As New List(Of BE.Grupo_Pantentes)
    Dim mifamilia As New BE.Grupo_Pantentes
    Dim gpat As New BLL.Gestor_Patente
    Dim nombrefamilia As String
    Dim SELECCIONADA As Boolean



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.familias = BE.Modelo.GetInstance.Familias
        '  Me.familias.MostrarEnTreeview(Me.treePatentes.Nodes)

        'familias = (DirectCast(comboBox1.SelectedItem, BE.Grupo_Pantentes))
    End Sub


    Private Sub LoadPermisoRecursivo(fa As BE.Grupo_Pantentes, tr As TreeNode)
        For Each f In fa.list
            If f.Seleccionada = True Then
                Dim trn As New TreeNode
                trn.Text = f.Nombre
                trn.Tag = f
                tr.Nodes.Add(trn)
                If f.list.Count = 1 Then

                    LoadPermisoRecursivo(f, tr)
                ElseIf f.list.Count > 1 Then

                    LoadPermisoRecursivo(f, trn)


                End If

            End If


            ' Dim pat As New List(Of BE.PatenteAbstracta)
            'pat = DirectCast(f, BE.PatenteAbstracta).list


            'If pat.Count > 0 Then
            'LoadPermisoRecursivo(f, tr)
            'End If
        Next
    End Sub


    Private Sub hijos()


    End Sub

    Private Sub FormularioUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.conectar()
        'comboBox1.DataSource = BE.Modelo.GetInstance.Familias
        comboBox1.DataSource = gestorgrupos.Listar_grupos_distintos

        nombrefamilia = comboBox1.SelectedItem.ToString


        ComboBox2.DataSource = gestor.listar_usuarios
    End Sub

    Private Sub Familia_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim patentes As New List(Of BE.Patente)
        Dim gp As New BE.Grupo_Pantentes
        gp = DirectCast(ComboBox1.SelectedItem, BE.Grupo_Pantentes)


        patentes = gestorgrupos.Listar_patentesdelgrupo(gp.Nombre)


        Dim tr As TreeNode
        tr = New TreeNode
        tr.Text = gp.Nombre

        Me.treepatentes.Nodes.Add(tr)


        For Each p In patentes

            Dim trn As New TreeNode
            trn.Text = p.Nombre & "-" & p.Formulario
            trn.Tag = p
            tr.Nodes.Add(trn)
            '  If gp.list.Count = 1 Then

            ' LoadPermisoRecursivo(f, tr)
            'ElseIf f.list.Count > 1 Then

            'LoadPermisoRecursivo(f, trn)


            'End If

            '   End If
            'Me.treePatentes.Nodes.IndexOf(tr)

        Next

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub




    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim nodo As TreeNode = Nothing

        For Each f In Me.familias
            If f.Nombre = nombrefamilia Then
                If f.Seleccionada = True Then
                    nodo = New TreeNode
                    nodo.Text = f.Nombre
                    nodo.Tag = f
                    treepatentes.Nodes.Add(nodo)



                    If f.list.Count > 0 Then
                        LoadPermisoRecursivo(f, nodo)
                    End If

                End If

            End If

        Next

        Dim u As New BE.Usuario
        Dim fa As New BE.Grupo_Pantentes
        u = DirectCast(ComboBox2.SelectedItem, BE.Usuario)
        fa = DirectCast(ComboBox1.SelectedItem, BE.Grupo_Pantentes)

        gestorgrupos.asignar_permisos(u, fa)

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnvolvemenu.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub
End Class