Public Class GrupoPatentes
    Inherits PatenteAbstracta

    Private _patentes As New List(Of PatenteAbstracta)
    Public Property Patentes() As List(Of PatenteAbstracta)
        Get
            Return _patentes
        End Get
        Set(ByVal value As List(Of PatenteAbstracta))
            _patentes = value
        End Set
    End Property


    Public Overrides Sub MostrarEnTreeview(ByRef padres As System.Windows.Forms.TreeNodeCollection)
        Dim node As System.Windows.Forms.TreeNode = padres.Add(Me.Nombre)
        node.Tag = Me

        For Each patente As PatenteAbstracta In _patentes
            patente.MostrarEnTreeview(node.Nodes)
        Next
    End Sub

    Public Overrides Function Clone() As PatenteAbstracta
        Dim pat As New GrupoPatentes
        pat.Nombre = Me.Nombre

        For Each patente As PatenteAbstracta In _patentes
            pat.Patentes.Add(patente.Clone())
        Next

        Return pat
    End Function

    Public Overrides Sub Execute()
        'No hace nada
    End Sub
End Class
