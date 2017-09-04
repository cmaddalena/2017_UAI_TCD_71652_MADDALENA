Public Class CLIENTE
    Inherits PERSONA

    Private _STATUS As String
    Public Property STATUS() As String
        Get
            Return _STATUS
        End Get
        Set(ByVal value As String)
            _STATUS = value
        End Set
    End Property

    Private _FECHAALTA As Date
    Public Property FECHAALTA() As Date
        Get
            Return _FECHAALTA
        End Get
        Set(ByVal value As Date)
            _FECHAALTA = value
        End Set
    End Property

    Private _ESTADOPAGO As String
    Public Property ESTADOPAGO() As String
        Get
            Return _ESTADOPAGO
        End Get
        Set(ByVal value As String)
            _ESTADOPAGO = value
        End Set
    End Property

    Dim CUOTAS As New List(Of CUOTAS)


    Public Property TURNO As TURNO
        Get
            Return Nothing
        End Get
        Set(value As TURNO)
        End Set
    End Property

    Private _AMONESTACION As Boolean
    Public Property AMONESTACION() As Boolean
        Get
            Return _AMONESTACION
        End Get
        Set(ByVal value As Boolean)
            _AMONESTACION = value
        End Set
    End Property


    Private _EXPULSION As Boolean
    Public Property EXPULSION() As Boolean
        Get
            Return _EXPULSION
        End Get
        Set(ByVal value As Boolean)
            _EXPULSION = value
        End Set
    End Property


End Class
