Public Class Gestor_GrupoPatentes


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
