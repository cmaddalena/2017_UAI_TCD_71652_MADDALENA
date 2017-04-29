Imports System.Data.SqlClient

Public Class MP_GRUPOPATENTES
    Dim acceso As New DAL.ACCESO


    Public Function Insertar_Grupopatentes(gp As BE.Grupo_Pantentes) As Integer

        Dim gps As New List(Of BE.PatenteAbstracta)

        gps = gp.list


        For Each p In gps
            Dim parametros(2) As SqlParameter
            ' If p.Seleccionada = True Then


            parametros(0) = acceso.crearparametro("@descgp", gp.Nombre)
            parametros(1) = acceso.crearparametro("@nombrepat", (DirectCast(p, BE.Patente).Nombre))
            parametros(2) = acceso.crearparametro("@FORM", (DirectCast(p, BE.Patente).Formulario))
            acceso.ESCRIBIR("Alta_GrupoPatentes", parametros)

            If gps.Count = 0 Then
                Return acceso.ESCRIBIR("Alta_GrupoPatentes", parametros)
            End If

            'End If
        Next

    End Function




End Class
