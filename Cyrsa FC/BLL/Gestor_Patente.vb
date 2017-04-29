Public Class Gestor_Patente

    Public Function registar_patente(p As BE.Patente) As String
        Dim registro As New DAL.MP_PATENTE
        Dim fa As Integer = registro.Insertar_Patente(p)
        If fa = 1 Then
            Return "REGISTRADO"

        Else
            Return "ERROR DE REGISTRO VERIFIQUE LOS DATOS CARGADOS"

        End If

    End Function



End Class
