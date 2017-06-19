
Imports System.Data.SqlClient
Public Class MP_EQUIPO

    Public Function insertarequipo(equipo As BE.EQUIPO) As Integer
        Dim e As Integer
        Dim i As Integer = Conexion.updatedata("INSERT INTO EQUIPO VALUES ('" & equipo.NOMBREEQUIPO & "',null,null,null,null)")


        For Each j In equipo.JUGADORES
            e = Conexion.updatedata("Update CLIENTE_ESCUELA set  ID_EQUIPO= (select ID_EQUIPO from equipo where NOMBRE_EQUIPO= '" & equipo.NOMBREEQUIPO & "') Where DNI='" & j.DNI & "'")

        Next

        Return i
        Return e
    End Function

End Class
