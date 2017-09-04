Public Class Alta_Equipo
    Implements BE.IObservador
    Dim gestorcliente As New BLL.Gestor_persona
    Dim equipo As New BE.EQUIPO


    Private Sub Alta_Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.conectar()
        actualizaridioma()
        lstlistajugadores.DataSource = gestorcliente.listar_cliente




    End Sub


    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        Module1.cambiar_lenguaje(BE.Lenguaje_form.getinstance.NOMBRE, Me)
    End Sub



    'Private Sub Alta_Equipo_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
    '    Label1.DoDragDrop(lstlistajugadores.SelectedItem.ToString, DragDropEffects.All)


    'End Sub

    Private Sub lstlistajugadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstlistajugadores.SelectedIndexChanged
        If equipo.JUGADORES.Count = 0 Then
            Label7.Text = lstlistajugadores.SelectedItem.ToString

        ElseIf equipo.JUGADORES.Count = 1 Then
            Label8.Text = lstlistajugadores.SelectedItem.ToString
        ElseIf equipo.JUGADORES.Count = 2 Then
            Label9.Text = lstlistajugadores.SelectedItem.ToString
        ElseIf equipo.JUGADORES.Count = 3 Then
            Label10.Text = lstlistajugadores.SelectedItem.ToString
        ElseIf equipo.JUGADORES.Count = 4 Then
            Label11.Text = lstlistajugadores.SelectedItem.ToString


        End If


        equipo.JUGADORES.Add(lstlistajugadores.SelectedItem)
    End Sub

    Private Sub gbjugadores_Enter(sender As Object, e As EventArgs) Handles gbjugadores.Enter

    End Sub

    Private Sub btninsertarequipo_Click(sender As Object, e As EventArgs) Handles btninsertarequipo.Click

        equipo.NOMBREEQUIPO = txtnombreequipo.Text

        If equipo.JUGADORES.Count = 5 Then

            Dim g As New BLL.Gestor_equipo
            g.crearequipo(equipo)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Me.Dispose()
        GC.Collect()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()
    End Sub
End Class