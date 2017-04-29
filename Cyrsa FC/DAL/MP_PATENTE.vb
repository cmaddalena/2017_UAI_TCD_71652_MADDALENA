Imports System.Data.SqlClient
Public Class MP_PATENTE
    Dim acceso As New ACCESO


    Public Function Insertar_Patente(patente As BE.Patente) As Integer
        Dim parametros(1) As SqlParameter
        parametros(0) = acceso.crearparametro("@form", patente.Formulario)
        parametros(1) = acceso.crearparametro("@desc", patente.Nombre)


        Return acceso.ESCRIBIR("alta_patente", parametros)
    End Function



End Class
