Imports System.Reflection

Public Class FormularioDialogoPatentes
    Implements BE.IObservador


    Public Sub actualizaridioma() Implements BE.IObservador.actualizaridioma
        Module1.cambiar_lenguaje(BE.Lenguaje_form.getinstance.NOMBRE, Me)
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim Asm As Assembly = Reflection.Assembly.GetExecutingAssembly()

        For Each t As Type In Asm.GetTypes()
            If t.IsSubclassOf(GetType(Form)) Then
                Me.cmbFormularios.Items.Add(t.FullName)
            End If

        Next
    End Sub

    Public Function Nombre() As String
        Return Me.txtNombre.Text
    End Function

    Public Function Formulario() As String
        Return Me.cmbFormularios.Text
    End Function

    Private Sub FormularioDialogoPatentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizaridioma()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class