Imports System.Data.SqlClient
Public Class MP_USUARIOS


    Dim acceso As New ACCESO


    Public Function Listar_Usuarios() As List(Of BE.Usuario)
        Dim usuarios As New List(Of BE.Usuario)
        Dim dt As New DataTable


        dt = acceso.leer("Listar_Usuarios", Nothing)

        For Each r In dt.Rows
            Dim user As New BE.Usuario

            user.DNI = r("ID_CLIENTE")
            'user.CLAVE = r("CLAVE")
            user.Nombre = r("USUARIO")

            usuarios.Add(user)

        Next

        Return usuarios

    End Function

End Class
