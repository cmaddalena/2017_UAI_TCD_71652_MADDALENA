Imports System.Data.SqlClient
Public Class MP_PATENTE
    Dim acceso As New ACCESO


    Public Function Insertar_Patente(patente As BE.Patente) As Integer
        Dim parametros(1) As SqlParameter
        parametros(0) = acceso.crearparametro("@form", patente.Formulario)
        parametros(1) = acceso.crearparametro("@desc", patente.Nombre)


        Return acceso.ESCRIBIR("alta_patente", parametros)
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
