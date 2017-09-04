
Public Class Lenguaje_Mensajero
    Inherits Lenguaje
    Implements IObservador


    Sub New()
        actualizaridioma()
    End Sub


    'Private Shared _Instance As Lenguaje
    'Public Shared Function DevolverInstancia() As Lenguaje

    '    If _Instance Is Nothing Then
    '        Lenguaje.getinstance = _Instance
    '    End If

    '    Return _Instance
    'End Function

    Private _language As Lenguaje
    Public Property Language As Lenguaje
        Get
            Return _language
        End Get
        Set(value As Lenguaje)
            _language = value
        End Set
    End Property


    Private _texto As String
    Public Property texto() As String
        Get
            Return _texto
        End Get
        Set(ByVal value As String)
            _texto = value
        End Set
    End Property


    Public Sub actualizaridioma() Implements IObservador.actualizaridioma
        Me.Language = Lenguaje.getinstance

    End Sub
End Class
