Public Class Gestor_GrupoPatentes

    Dim mp As New DAL.MP_GRUPOPATENTES
    Dim mpat As New DAL.MP_PATENTE


    Public Function Listar_grupos_distintos() As List(Of BE.Grupo_Pantentes)
        Dim gpas As New List(Of BE.Grupo_Pantentes)

        gpas = mp.listar_gruposdistintos

        Return gpas
    End Function


    Public Function Listar_patentesdelgrupo(nombre_grupo As String) As List(Of BE.Patente)
        Dim pat As New List(Of BE.Patente)

        pat = mpat.listar_patentesdelgrupo(nombre_grupo)

        Return pat
    End Function



    Public Function asignar_permisos(u As BE.Usuario, f As BE.Grupo_Pantentes) As String
        Dim mp As New DAL.MP_GRUPOPATENTES
        Dim fa As Integer = mp.asignar_permisos(u, f)
        If fa = 1 Then
            Return "REGISTRADO"

        Else
            Return "ERROR DE REGISTRO VERIFIQUE LOS DATOS CARGADOS"

        End If

    End Function

    Public Function registar_gpatente(gp As BE.Grupo_Pantentes) As String

        Dim registro As New DAL.MP_GRUPOPATENTES
        Dim fa As Integer = registro.Insertar_Grupopatentes(gp)
        If fa = 1 Then
            Return "REGISTRADO"

        Else
            Return "ERROR DE REGISTRO VERIFIQUE LOS DATOS CARGADOS"

        End If

    End Function

End Class
