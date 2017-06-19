Public Class TORNEO

    Private _NOMBRE As String
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property


    Private _PARTIDOS As New List(Of BE.PARTIDO)
    Public Property PARTIDOS() As List(Of BE.PARTIDO)
        Get
            Return _PARTIDOS
        End Get
        Set(ByVal value As List(Of BE.PARTIDO))
            _PARTIDOS = value
        End Set
    End Property




End Class
