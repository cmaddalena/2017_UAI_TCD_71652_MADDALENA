Public Class EQUIPO

    Private _NOMBREEQUIPO As String
    Public Property NOMBREEQUIPO() As String
        Get
            Return _NOMBREEQUIPO
        End Get
        Set(ByVal value As String)
            _NOMBREEQUIPO = value
        End Set
    End Property


    Private _JUGADORES As New List(Of BE.CLIENTE)
    Public Property JUGADORES() As List(Of BE.CLIENTE)
        Get
            Return _JUGADORES
        End Get
        Set(ByVal value As List(Of BE.CLIENTE))
            _JUGADORES = value
        End Set
    End Property

    Private _PUNTAJE As Integer
    Public Property PUNTAJE() As Integer
        Get
            Return _PUNTAJE
        End Get
        Set(ByVal value As Integer)
            _PUNTAJE = value
        End Set
    End Property


    Private _GOLES As Integer
    Public Property goles() As Integer
        Get
            Return _GOLES
        End Get
        Set(ByVal value As Integer)
            _GOLES = value
        End Set
    End Property





End Class
