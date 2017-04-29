Public MustInherit Class PatenteAbstracta

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _seleccionada As Boolean
    Public Property Seleccionada() As Boolean
        Get
            Return _seleccionada
        End Get
        Set(ByVal value As Boolean)
            _seleccionada = value
        End Set
    End Property



    Public MustOverride Function list() As List(Of PatenteAbstracta)



    Public MustOverride Sub MostrarEnTreeview(ByRef padres As System.Windows.Forms.TreeNodeCollection)
    Public MustOverride Function Clone() As PatenteAbstracta
    Public MustOverride Sub Execute()
End Class
