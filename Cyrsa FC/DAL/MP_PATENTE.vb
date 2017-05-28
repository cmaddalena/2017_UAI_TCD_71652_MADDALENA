Imports System.Data.SqlClient
Public Class MP_PATENTE
    Dim acceso As New ACCESO

#Region "Insertar_patente"

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


    'Public Function login(u As BE.Usuario) As List(Of BE.Patente)
    '    Dim grupopatentes As New List(Of BE.Patente)
    '    Dim gp As BE.Patente
    '    Dim dt As New DataTable
    '    Dim parametros(1) As SqlParameter

    '    parametros(0) = acceso.crearparametro("@usuario", u.Nombre)
    '    parametros(1) = acceso.crearparametro("@clave", u.CLAVE)
    '    dt = acceso.leer("DEVOLVER_FORMS", parametros)

    '    For Each r In dt.Rows
    '        gp = New BE.Patente
    '        gp.Nombre = r("NOMBRE_PAT")
    '        'user.CLAVE = r("CLAVE")
    '        gp.Formulario = r("FORMULARIO")

    '        grupopatentes.Add(gp)


    '    Next
    '    Return grupopatentes
    'End Function
#End Region


#Region "LeerPatentes"
    Public Function Listar() As List(Of BE.PatenteAbstracta)
        Dim familia As New List(Of BE.PatenteAbstracta)
        ' Dim praiz As New List(Of BE.GRUPOPATENTE)
        ' Dim grupete As New BE.GRUPOPATENTE
        '  grupete.NOMBRE = "PERFILES SISTEMA"



        Dim dt As DataTable = Conexion.GetData("select distinct DESCRIPCION from GRUPO_PATENTES ")

        ' Dim dt1 As DataTable = Conexion.GetData("Select * from USUARIO where NOMBRE=" & user.NOMBRE)
        'Dim idfamilia As Integer



        If dt.Rows.Count > 0 Then

            For Each dr As DataRow In dt.Rows
                Dim grupo As New BE.Grupo_Pantentes

                ' grupo.ID = dr.Item(0)
                grupo.Nombre = dr.Item(0)

                familia.Add(grupo)
                'praiz.add(familia)
                ' AgregarGrupoaGrupo(grupo)
                AgregarPatenteaGrupo(grupo)
                ' AgregarPatenteaFamilia(grupo)
            Next

        End If
        Return familia

    End Function




    Private Sub AgregarPatenteaGrupo(pPadre As BE.Grupo_Pantentes)
        Try
            Dim DT As DataTable = Conexion.GetData("SELECT * FROM GRUPO_PATENTES WHERE DESCRIPCION = '" & pPadre.Nombre & "'")
            If DT.Rows.Count > 0 Then
                For Each DR As DataRow In DT.Rows
                    Dim PATENTE As New BE.Patente

                    PATENTE.ID = DR.Item(2)
                    PATENTE.Nombre = DR.Item(4)
                    PATENTE.Formulario = DR.Item(3)
                    ' PATENTE.IDMIFAMILIA = DR.Item(3)

                    ' If Not IsDBNull(DR.Item(4)) Then
                    'PATENTE.IDGRUPOPATENTE = DR.Item(4)
                    'End If

                    pPadre.Agregar_rol(PATENTE)




                Next
            End If


        Catch ex As Exception

        End Try
    End Sub



    'Private Sub AgregarGrupoaGrupo(pPadre As BE.GRUPOPATENTE)
    '    Try
    '        Dim DT As DataTable = Conexion.GetData("select * from GRUPO_PATENTES WHERE ID_GRUPOPADRE = " & pPadre.ID)
    '        If DT.Rows.Count > 0 Then
    '            For Each DR As DataRow In DT.Rows


    '                Dim GRUPOPAT As New BE.GRUPOPATENTE

    '                GRUPOPAT.ID = DR.Item(0)
    '                GRUPOPAT.NOMBRE = DR.Item(1)
    '                GRUPOPAT.IDFAMILIA = DR.Item(2)

    '                If Not IsDBNull(DR.Item(3)) Then
    '                    GRUPOPAT.IDGRUPOPADRE = DR.Item(3)
    '                End If


    '                pPadre.Agregar_rol(GRUPOPAT)
    '                '  AgregarGrupoaFamilia(GRUPOPAT)
    '                AgregarPatenteaGrupo(GRUPOPAT)

    '                AgregarGrupoaGrupo(GRUPOPAT)

    '            Next
    '        End If


    '    Catch ex As Exception

    '    End Try
    'End Sub

#End Region

End Class
