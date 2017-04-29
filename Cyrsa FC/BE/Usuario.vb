Public Class Usuario

    Private _DNI As Integer
    Public Property DNI() As Integer
        Get
            Return _DNI
        End Get
        Set(ByVal value As Integer)
            _DNI = value
        End Set
    End Property


    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _CLAVE As String
    Public Property CLAVE() As String
        Get
            Return _CLAVE
        End Get
        Set(ByVal value As String)
            _CLAVE = value
        End Set
    End Property

    Private _familia As Grupo_Pantentes
    Public Property Familia() As Grupo_Pantentes
        Get
            Return _familia
        End Get
        Set(ByVal value As Grupo_Pantentes)
            _familia = value
        End Set
    End Property

    Public Property PERSONA As PERSONA
        Get
            Return Nothing
        End Get
        Set(value As PERSONA)
        End Set
    End Property

    Public Property Grupo_Pantentes As Grupo_Pantentes
        Get
            Return Nothing
        End Get
        Set(value As Grupo_Pantentes)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nombre & " -" & DNI
    End Function

End Class
