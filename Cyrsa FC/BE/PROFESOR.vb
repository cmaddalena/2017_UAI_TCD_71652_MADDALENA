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

    Private _FECHA_INGRESO As DateTime
    Public Property FECHA_INGRESO() As DateTime
        Get
            Return _FECHA_INGRESO
        End Get
        Set(ByVal value As DateTime)
            _FECHA_INGRESO = value
        End Set
    End Property





    Private _Clases As List(Of CLASE)
    Public Property CLASES As List(Of CLASE)
        Get
            Return _Clases
        End Get
        Set(value As List(Of CLASE))

        End Set
    End Property



End Class
