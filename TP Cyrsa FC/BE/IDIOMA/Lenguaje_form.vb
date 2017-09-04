Public Class Lenguaje_form
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

    Private _control As String
    Public Property control() As String
        Get
            Return _control
        End Get
        Set(ByVal value As String)
            _control = value
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

    Private _form As String
    Public Property form() As String
        Get
            Return _form
        End Get
        Set(ByVal value As String)
            _form = value
        End Set
    End Property

    Public Sub actualizaridioma() Implements IObservador.actualizaridioma
        Me.Language = Lenguaje.getinstance

    End Sub
End Class
