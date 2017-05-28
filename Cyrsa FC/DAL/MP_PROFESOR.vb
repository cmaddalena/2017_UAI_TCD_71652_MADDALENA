
Imports System.Data.SqlClient

Public Class MP_PROFESOR
    Dim acceso As New ACCESO
    Dim fecha As DateTime = DateTime.Now





    Public Function crearusuario(Profesor As BE.PROFESOR, USER As BE.Usuario) As Integer
        Dim pat As New BE.Patente
        Dim parametros(7) As SqlParameter
        Dim fechaactual As Date
        fechaactual = DateTime.Today.Date



        parametros(0) = acceso.crearparametro("@dni", Profesor.DNI)
        parametros(1) = acceso.crearparametro("@nombre", Profesor.Nombre)
        parametros(2) = acceso.crearparametro("@apellido", Profesor.Apellido)
        parametros(3) = acceso.crearparametro("@fecha_nac", Profesor.FechaNac)
        parametros(4) = acceso.crearparametro("@mail", Profesor.Mail)
        parametros(5) = acceso.crearparametro("@fechaingreso", fechaactual)
        parametros(6) = acceso.crearparametro("@sueldo", Profesor.SUELDO)
        parametros(7) = acceso.crearparametro("@pass", USER.CLAVE)



        Return acceso.ESCRIBIR("Alta_empleado", parametros)
    End Function
End Class
