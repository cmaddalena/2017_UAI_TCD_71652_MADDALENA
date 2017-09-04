Public Class FormularioFamilia

    Dim family As New BE.Grupo_Pantentes
    Dim MIFAMLIA As New BE.Grupo_Pantentes

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.family = BE.Modelo.GetInstance().PatenteRaiz.Clone()
        Me.family.MostrarEnTreeview(Me.treePatentes.Nodes)



    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        family.Nombre = Me.txtNombre.Text
        family.Seleccionada = True
        BE.Modelo.GetInstance.Familias.Add(family)
        'MIFAMLIA.Nombre = Me.txtNombre.Text
        'BE.Modelo_User.GetInstance.Familias.Add(MIFAMLIA)


        Me.Close()
    End Sub

    Private Sub treePatentes_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles treePatentes.AfterCheck
        e.Node.Tag.Seleccionada = e.Node.Checked
     '   family.Seleccionada = e.Node.Tag.SELECCIONADA


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnvolvermenu.Click
        Me.Close()
    End Sub

    Private Sub FormularioFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub
End Class