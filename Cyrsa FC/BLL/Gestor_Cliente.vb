Public Class Gestor_Cliente
    Dim mp As New DAL.MP_CLIENTE_ESCUELA

    Public Function registar(unusuario As BE.CLIENTE, cuota As BE.CUOTAS, USER As BE.Usuario) As String
        Dim registro As New DAL.MP_CLIENTE_ESCUELA
        Dim fa As Integer = registro.crearusuario(unusuario, cuota, USER)
        If fa = 1 Then
            Return "REGISTRADO"

        Else
            Return "ERROR DE REGISTRO VERIFIQUE LOS DATOS CARGADOS"

        End If

    End Function


End Class
