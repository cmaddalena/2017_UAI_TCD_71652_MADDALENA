Public Class PROFESOR
    Inherits PERSONA
    Private _LEGAJO As Integer
    Public Property LEGAJO As Integer
        Get
            Return _LEGAJO
        End Get
        Set(ByVal value As Integer)
            _LEGAJO = value
        End Set
    End Property

    Private _SUELDO As String
    Public Property SUELDO() As String
        Get
            Return _SUELDO
        End Get
        Set(ByVal value As String)
            _SUELDO = value
        End Set
    End Property

End Class
