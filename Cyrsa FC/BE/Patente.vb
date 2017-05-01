Imports BE

Public Class Patente
    Inherits PatenteAbstracta

    Private _formulario As String
    Public Property Formulario() As String
        Get
            Return _formulario
        End Get
        Set(ByVal value As String)
            _formulario = value
        End Set
    End Property


    Public Overrides Sub MostrarEnTreeview(ByRef padres As System.Windows.Forms.TreeNodeCollection)
        Dim node As System.Windows.Forms.TreeNode = padres.Add(Me.Nombre)
        node.Tag = Me
    End Sub

    Public Overrides Function Clone() As PatenteAbstracta
        Dim pat As New Patente
        pat.Nombre = Me.Nombre
        Return pat
    End Function

    Dim lista As New List(Of BE.PatenteAbstracta)
    Public Overrides Function list() As List(Of PatenteAbstracta)
        Return lista
    End Function

    Public Overrides Sub Execute()
        'Crea y muestra el formulario
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre & " - " & Me.Formulario
    End Function

End Class
