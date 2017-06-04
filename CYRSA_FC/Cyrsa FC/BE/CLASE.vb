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



    Dim TURNOS As New List(Of TURNO)

    Public Property PROFESOR As PROFESOR
        Get
            Return Nothing
        End Get
        Set(value As PROFESOR)
        End Set
    End Property

    Dim CLIENTES As New List(Of BE.CLIENTE)

    Public Property TURNO As TURNO
        Get
            Return Nothing
        End Get
        Set(value As TURNO)
        End Set
    End Property

End Class
