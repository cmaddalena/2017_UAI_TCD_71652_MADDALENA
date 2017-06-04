﻿Public Class FormularioPrincipal

    Private Sub btnDefinirPatentes_Click(sender As Object, e As EventArgs) Handles btnDefinirPatentes.Click
        Dim frm As New FormularioPatentes
        frm.ShowDialog()
    End Sub

    Private Sub btnDefinirFamilias_Click(sender As Object, e As EventArgs)
        Dim frm As New FormularioFamilia
        frm.ShowDialog()
    End Sub

    Private Sub btnDefinirUsuarios_Click(sender As Object, e As EventArgs) Handles btnDefinirUsuarios.Click
        Dim frm As New FormularioUsuarios
        frm.ShowDialog()
    End Sub

    Private Sub btnIniciarSesionComoUsuario_Click(sender As Object, e As EventArgs) Handles btnIniciarSesionComoUsuario.Click
        Loguin.Show()

    End Sub

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.conectar()

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
End Class