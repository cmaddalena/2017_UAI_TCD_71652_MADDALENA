Imports BE

Public Class Grupo_Pantentes
    Inherits PatenteAbstracta

    'Private _patentes As New List(Of PatenteAbstracta)
    'Public Property Patentes() As List(Of PatenteAbstracta)
    '    Get
    '        Return _patentes
    '    End Get
    '    Set(ByVal value As List(Of PatenteAbstracta))
    '        _patentes = value
    '    End Set
    'End Property

    Dim patentes As New List(Of BE.PatenteAbstracta)
    Public Overrides Function list() As List(Of BE.PatenteAbstracta)
        Return patentes
    End Function


    Public Overrides Sub MostrarEnTreeview(ByRef padres As System.Windows.Forms.TreeNodeCollection)
        Dim node As System.Windows.Forms.TreeNode = padres.Add(Me.Nombre)
        node.Tag = Me

        For Each patente As PatenteAbstracta In patentes
            patente.MostrarEnTreeview(node.Nodes)
        Next
    End Sub

    Public Overrides Function Clone() As PatenteAbstracta
        Dim pat As New BE.Grupo_Pantentes
        pat.Nombre = Me.Nombre

        For Each patente As PatenteAbstracta In patentes
            pat.patentes.Add(patente.Clone())
        Next

        Return pat
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Overrides Sub Execute()
        'No hace nada
        For Each p In patentes
            p.Execute()
            MsgBox(Me.Nombre)
        Next
    End Sub



    Public Overrides Function Agregar_rol(f As PatenteAbstracta) As Boolean
        Me.patentes.Add(f)

        Return True
    End Function
End Class
