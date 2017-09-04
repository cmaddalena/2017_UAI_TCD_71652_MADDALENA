Public Class Gestor_persona
    Dim mp As New DAL.MP_CLIENTE_ESCUELA

    Dim mpprof As New DAL.MP_PROFESOR

#Region "CLIENTE"
    Public Function listar_cliente() As List(Of BE.CLIENTE)
        Dim clientes As New List(Of BE.CLIENTE)

        clientes = mp.Listar_clientes

        Return clientes

    End Function


    Public Function update_persona(c As BE.CLIENTE, u As BE.Usuario) As Integer

        Dim i As Integer = mp.updateCliente(c, u)
        Return i

    End Function


    Public Function eliminar_persona(c As BE.CLIENTE, u As BE.Usuario) As Integer

        Dim i As Integer = mp.eliminarCliente(c, u)
        Return i

    End Function

#End Region





#Region "DOCENTE"
    Public Function listar_docente() As List(Of BE.PROFESOR)
        Dim profesores As New List(Of BE.PROFESOR)
        profesores = mpprof.Listar_profesores

        Return profesores

    End Function


    Public Function update_docente(c As BE.PROFESOR, u As BE.Usuario) As Integer

        Dim i As Integer = mpprof.updatedocente(c, u)
        Return i

    End Function


    Public Function eliminar_docente(c As BE.PROFESOR, u As BE.Usuario) As Integer

        Dim i As Integer = mpprof.eliminardocente(c, u)
        Return i

    End Function



#End Region



End Class
