Public Class FormularioPrincipal
    Implements BE.IObservador


    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        Module1.cambiar_lenguaje(BE.Lenguaje_form.getinstance.NOMBRE, Me)
    End Sub

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.conectar()
        actualizaridioma()
    End Sub

    Private Sub btnIniciarSesionComoUsuario_Click(sender As Object, e As EventArgs)
      
    End Sub


    Private Sub btnIniciarSesionComoUsuario_Click_1(sender As Object, e As EventArgs) Handles btnIniciarSesionComoUsuario.Click
 

        Loguin.Show()

    End Sub

    Private Sub btnDefinirUsuarios_Click(sender As Object, e As EventArgs) Handles btnDefinirUsuarios.Click
        Dim frm As New FormularioUsuarios
        frm.ShowDialog()
    End Sub

    Private Sub btnDefinirPatentes_Click_1(sender As Object, e As EventArgs) Handles btnDefinirPatentes.Click
        Dim frm As New FormularioPatentes
        frm.ShowDialog()
    End Sub

    Private Sub btnvolvemenu_Click_1(sender As Object, e As EventArgs) Handles btnvolvemenu.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub
End Class
