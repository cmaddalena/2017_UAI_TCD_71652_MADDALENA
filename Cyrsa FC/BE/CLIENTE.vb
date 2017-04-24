Public Class CLIENTE
    Inherits PERSONA

    Private _Usuario As String
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Private _Clave As String
    Public Property Clave() As String
        Get
            Return _Clave
        End Get
        Set(ByVal value As String)
            _Clave = value
        End Set
    End Property

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

    Dim cuota As New CUOTAS


End Class
