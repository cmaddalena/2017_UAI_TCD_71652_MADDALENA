Imports System.Data.SqlClient

Public Class MP_CLIENTE_ESCUELA

#Region "LEER CLIENTES"
    Public Function Listar_clientes() As List(Of BE.CLIENTE)
        Dim usuarios As New List(Of BE.CLIENTE)




        Dim dt As DataTable = Conexion.GetData("select * from CLIENTE_ESCUELA ")


        If dt.Rows.Count > 0 Then

            For Each dr As DataRow In dt.Rows
                Dim grupo As New BE.CLIENTE

                ' grupo.ID = dr.Item(0)
                grupo.DNI = dr.Item(0)
                grupo.Nombre = dr.Item(1)
                grupo.Apellido = dr.Item(2)
                grupo.FechaNac = dr.Item(3)
                grupo.Mail = dr.Item(4)
                grupo.ESTADOPAGO = dr.Item(5)

                usuarios.Add(grupo)

            Next

        End If
        Return usuarios

    End Function

#End Region


#Region "ACTUALIZAR DATOS CLIENTE"

    Public Function updateCliente(c As BE.CLIENTE, u As BE.Usuario) As Integer

        Dim i As Integer = Conexion.updatedata("Update CLIENTE_ESCUELA set NOMBRE='" & c.Nombre & "'" & ", APELLIDO='" & c.Apellido & "', FECHA_NAC='" & c.FechaNac & "'," & "MAIL='" & c.Mail & "', ESTADO='" & c.ESTADOPAGO & "' Where DNI=" & c.DNI)


        Return i

    End Function



#End Region

#Region "ELIMINAR CLIENTE"
    Public Function eliminarCliente(c As BE.CLIENTE, u As BE.Usuario) As Integer

        Dim i As Integer = Conexion.updatedata("UPDATE CLIENTE_ESCUELA SET ESTADO='INACTIVO' Where DNI='" & c.DNI & "'")
        '  Dim e As Integer = Conexion.updatedata("DELETE FROM USUARIOS  Where ID_CLIENTE='" & c.DNI & "'")

        Return i
        '  Return e
    End Function

#End Region


End Class
