Public Class FormularioPrincipal

    Private Sub btnDefinirPatentes_Click(sender As Object, e As EventArgs) Handles btnDefinirPatentes.Click
        Dim frm As New FormularioPatentes
        frm.ShowDialog()
    End Sub

    Private Sub btnDefinirFamilias_Click(sender As Object, e As EventArgs) Handles btnDefinirFamilias.Click
        Dim frm As New FormularioFamilia
        frm.ShowDialog()
    End Sub

    Private Sub btnDefinirUsuarios_Click(sender As Object, e As EventArgs) Handles btnDefinirUsuarios.Click
        Dim frm As New FormularioUsuarios
        frm.ShowDialog()
    End Sub

    Private Sub btnIniciarSesionComoUsuario_Click(sender As Object, e As EventArgs) Handles btnIniciarSesionComoUsuario.Click
        Dim frm As New FormularioDialogoElegirUsuario
        frm.ShowDialog()
    End Sub
End Class
