Imports System.Data.SqlClient
Public Class MP_PATENTE
    Dim acceso As New ACCESO


    Public Function Insertar_Patente(patente As BE.Patente) As Integer
        Dim parametros(1) As SqlParameter
        parametros(0) = acceso.crearparametro("@form", patente.Formulario)
        parametros(1) = acceso.crearparametro("@desc", patente.Nombre)


        Return acceso.ESCRIBIR("alta_patente", parametros)
    End Function

    Public Function listar_patentesdelgrupo(g As String) As List(Of BE.Patente)
        Dim patentes As New List(Of BE.Patente)

        Dim dt As New DataTable

        Dim p(0) As SqlParameter
        p(0) = acceso.crearparametro("@nombre_grupo", g)


        dt = acceso.leer("listar_patentesdegrupo", p)

        For Each r In dt.Rows
            Dim pat As New BE.Patente

            pat.Nombre = r("NOMBRE_PAT")
            pat.Formulario = r("FORMULARIO")

            patentes.Add(pat)

        Next

        Return patentes


    End Function


    Public Function login(u As BE.Usuario) As List(Of BE.Patente)
        Dim grupopatentes As New List(Of BE.Patente)
        Dim gp As BE.Patente
        Dim dt As New DataTable
        Dim parametros(1) As SqlParameter

        parametros(0) = acceso.crearparametro("@usuario", u.Nombre)
        parametros(1) = acceso.crearparametro("@clave", u.CLAVE)
        dt = acceso.leer("DEVOLVER_FORMS", parametros)

        For Each r In dt.Rows
            gp = New BE.Patente
            gp.Nombre = r("NOMBRE_PAT")
            'user.CLAVE = r("CLAVE")
            gp.Formulario = r("FORMULARIO")

            grupopatentes.Add(gp)


        Next
        Return grupopatentes
    End Function


End Class
