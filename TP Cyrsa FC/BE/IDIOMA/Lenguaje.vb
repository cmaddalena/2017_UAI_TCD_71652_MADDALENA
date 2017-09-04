Public Class Lenguaje

    Private Shared _Instance As Lenguaje

    Sub New()
        If Me.NOMBRE Is Nothing Then
            Me.ID = 1
        End If

    End Sub


    Public Shared Function getinstance() As Lenguaje

        If _Instance Is Nothing Then
            _Instance = New Lenguaje
        End If

        Return _Instance
    End Function


    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Private _NOMBRE As String
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property

    Dim usuario As BE.Usuario

    Public Property IObservador As IObservador
        Get

        End Get
        Set(value As IObservador)

        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me.NOMBRE
    End Function
End Class
