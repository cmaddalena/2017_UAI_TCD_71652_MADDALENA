
Imports System.Data.SqlClient

Public Class MP_PROFESOR
    Dim acceso As New ACCESO
    Dim fecha As DateTime = DateTime.Now






#Region "LEER PROFESORES"
    Public Function Listar_profesores() As List(Of BE.PROFESOR)
        Dim usuarios As New List(Of BE.PROFESOR)




        Dim dt As DataTable = Conexion.GetData("select * from PROFESORES ")


        If dt.Rows.Count > 0 Then

            For Each dr As DataRow In dt.Rows
                Dim grupo As New BE.PROFESOR

                ' grupo.ID = dr.Item(0)
                grupo.DNI = dr.Item(0)
                grupo.Nombre = dr.Item(1)
                grupo.Apellido = dr.Item(2)
                grupo.FECHA_INGRESO = dr.Item(3)
                grupo.SUELDO = dr.Item(4)
                grupo.Mail = dr.Item(7)
                '  grupo.CLASES.Item.add(dr.Item(5))
                grupo.FechaNac = dr.Item(6)


                usuarios.Add(grupo)

            Next

        End If
        Return usuarios

    End Function

#End Region


#Region "ACTUALIZAR DATOS DOCENTE"

    Public Function updatedocente(c As BE.PROFESOR, u As BE.Usuario) As Integer

        Dim i As Integer = Conexion.updatedata("Update PROFESORES set NOMBRE='" & c.Nombre & "'" & ", APELLIDO='" & c.Apellido & "', FECHA_NAC='" & c.FechaNac & "'," & "MAIL='" & c.Mail & "', SUELDO='" & c.SUELDO & "' , FECHA_CONTRATACION='" & c.FECHA_INGRESO & "' Where ID_DOCENTE=" & c.DNI)


        Return i

    End Function



#End Region

#Region "ELIMINAR DOCENTE"
    Public Function eliminardocente(c As BE.PROFESOR, u As BE.Usuario) As Integer

        Dim i As Integer = Conexion.updatedata("DELETE FROM PROFESORES  Where ID_DOCENTE='" & c.DNI & "'")
        Dim e As Integer = Conexion.updatedata("DELETE FROM USUARIOS  Where ID_CLIENTE='" & c.DNI & "'")

        Return i
        Return e
    End Function

#End Region





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
