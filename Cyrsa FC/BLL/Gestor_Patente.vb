Public Class Gestor_Patente
    Dim mp As New DAL.MP_PATENTE


    Public Function registar_patente(p As BE.Patente) As String
        Dim registro As New DAL.MP_PATENTE
        Dim fa As Integer = registro.Insertar_Patente(p)
        If fa = 1 Then
            Return "REGISTRADO"

        Else
            Return "ERROR DE REGISTRO VERIFIQUE LOS DATOS CARGADOS"

        End If

    End Function

    Public Function listar_patentes_usuario(u As BE.Usuario) As List(Of BE.Patente)

        Dim patentes As List(Of BE.Patente)

        patentes = mp.login(u)

        Return patentes
    End Function


End Class
