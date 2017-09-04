
Public Class Modelo

    Private Shared _instance As Modelo
    Public Shared Function GetInstance() As Modelo

        If _instance Is Nothing Then
            _instance = New Modelo
        End If

        Return _instance
    End Function

    Private _familias As New List(Of Grupo_Pantentes)
    Public Property Familias() As List(Of Grupo_Pantentes)
        Get
            Return _familias
        End Get
        Set(ByVal value As List(Of Grupo_Pantentes))
            _familias = value
        End Set
    End Property

    Private _usuarios As New List(Of Usuario)
    Public Property Usuarios() As List(Of Usuario)
        Get
            Return _usuarios
        End Get
        Set(ByVal value As List(Of Usuario))
            _usuarios = value
        End Set
    End Property


    Private _patenteRaiz As PatenteAbstracta
    Public Property PatenteRaiz() As PatenteAbstracta
        Get
            Return _patenteRaiz
        End Get
        Set(ByVal value As PatenteAbstracta)
            _patenteRaiz = value
        End Set
    End Property

    Public Sub New()
        Dim raiz As New BE.Grupo_Pantentes()
        raiz.Nombre = "Patentes CyrsaFC"
        Me._patenteRaiz = raiz
    End Sub
End Class

