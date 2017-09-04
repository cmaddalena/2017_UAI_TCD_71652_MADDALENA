Public Class Log

    Private _FECHA As Date
    Public Property FECHA() As Date
        Get
            Return _FECHA
        End Get
        Set(ByVal value As Date)
            _FECHA = value
        End Set
    End Property

    Private _TIPO As Integer
    Public Property TIPO() As Integer
        Get
            Return _TIPO
        End Get
        Set(ByVal value As Integer)
            _TIPO = value
        End Set
    End Property


    Private _DESCRIPCION As String
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal value As String)
            _DESCRIPCION = value
        End Set
    End Property



End Class
