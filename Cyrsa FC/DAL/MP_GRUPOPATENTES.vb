Imports System.Data.SqlClient

Public Class MP_GRUPOPATENTES
    Dim acceso As New DAL.ACCESO


    Public Function listar_gruposdistintos() As List(Of BE.Grupo_Pantentes)

        Dim grupos As New List(Of BE.Grupo_Pantentes)
        Dim dt As New DataTable


        dt = acceso.leer("listar_grupos_distintos", Nothing)

        For Each r In dt.Rows
            Dim grupo As New BE.Grupo_Pantentes

            'grupo.Nombre = r("ID_CLIENTE")
            'user.CLAVE = r("CLAVE")
            grupo.Nombre = r("DESCRIPCION")

            grupos.Add(grupo)

        Next

        Return grupos

    End Function



    Public Function asignar_permisos(u As BE.Usuario, f As BE.Grupo_Pantentes) As Integer
        Dim parametros(1) As SqlParameter

        parametros(0) = acceso.crearparametro("@id_usuario", u.DNI)
        parametros(1) = acceso.crearparametro("@familia", f.Nombre)
        Return acceso.ESCRIBIR("Asignar_familia", parametros)

    End Function


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
