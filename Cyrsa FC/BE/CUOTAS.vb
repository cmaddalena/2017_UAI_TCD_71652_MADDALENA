Public Class CUOTAS
    Private _MES As String
    Public Property MES() As String
        Get
            Return _MES
        End Get
        Set(ByVal value As String)
            _MES = value
        End Set
    End Property

    Private _MONTO As Single
    Public Property MONTO() As Single
        Get
            Return _MONTO
        End Get
        Set(ByVal value As Single)
            _MONTO = value
        End Set
    End Property


    Private _INTERES As Single
    Public Property INTERES() As Single
        Get
            Return _INTERES
        End Get
        Set(ByVal value As Single)
            _INTERES = value
        End Set
    End Property
End Class
