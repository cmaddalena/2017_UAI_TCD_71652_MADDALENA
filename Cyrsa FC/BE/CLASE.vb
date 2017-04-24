Public Class CLASE
    Private _CATEGORIA As String
    Public Property CATEGORIA() As String
        Get
            Return _CATEGORIA
        End Get
        Set(ByVal value As String)
            _CATEGORIA = value
        End Set
    End Property


    Dim PROFESOR As New PROFESOR

    Dim TURNOS As New List(Of TURNO)



End Class
