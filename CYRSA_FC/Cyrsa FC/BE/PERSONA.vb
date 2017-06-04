Public Class PERSONA
    Private _DNI As Integer
    Public Property DNI() As Integer
        Get
            Return _DNI
        End Get
        Set(ByVal value As Integer)
            _DNI = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _Apellido As String
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property


    Private _FechaNac As DateTime
    Public Property FechaNac As DateTime
        Get
            Return _FechaNac
        End Get
        Set(ByVal value As DateTime)
            _FechaNac = value
        End Set
    End Property

    Private _Mail As String
    Public Property Mail() As String
        Get
            Return _Mail
        End Get
        Set(ByVal value As String)
            _Mail = value
        End Set
    End Property

    Public Property Usuario As Usuario
        Get
            Return Nothing
        End Get
        Set(value As Usuario)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Nombre & "-" & Me.Apellido

    End Function

End Class
