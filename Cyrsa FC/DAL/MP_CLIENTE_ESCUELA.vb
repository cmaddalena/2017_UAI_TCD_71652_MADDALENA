Imports System.Data.SqlClient

Public Class MP_CLIENTE_ESCUELA
    Dim acceso As New ACCESO
    Dim fecha As DateTime = DateTime.Now





    Public Function crearusuario(CLIENTE As BE.CLIENTE, CUOTA As BE.CUOTAS) As Integer
        Dim parametros(6) As SqlParameter
        parametros(0) = acceso.crearparametro("@dni", CLIENTE.DNI)
        parametros(1) = acceso.crearparametro("@nombre", CLIENTE.Nombre)
        parametros(2) = acceso.crearparametro("@apellido", CLIENTE.Apellido)
        parametros(3) = acceso.crearparametro("@fecha_nac", CLIENTE.FechaNac)
        parametros(4) = acceso.crearparametro("@mail", CLIENTE.Mail)
        parametros(5) = acceso.crearparametro("@fecha", fecha)
        parametros(6) = acceso.crearparametro("@monto", CUOTA.MONTO)


        Return acceso.ESCRIBIR("Alta_cliente", parametros)
    End Function



End Class
