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



    Public Function login(u As BE.Usuario) As List(Of BE.Patente)
        Dim grupopatentes As New List(Of BE.Patente)
        Dim gp As BE.Patente
        Dim dt As New DataTable
        Dim parametros(1) As SqlParameter

        parametros(0) = acceso.crearparametro("@usuario", u.Nombre)
        parametros(1) = acceso.crearparametro("@clave", u.CLAVE)
        dt = acceso.leer("DEVOLVER_FORMS", parametros)

        For Each r In dt.Rows
            gp = New BE.Patente
            gp.Nombre = r("NOMBRE_PAT")
            'user.CLAVE = r("CLAVE")
            gp.Formulario = r("FORMULARIO")

            grupopatentes.Add(gp)


        Next
        Return grupopatentes
    End Function


    Dim fecha As DateTime = DateTime.Now


    Public Function creardocente(CLIENTE As BE.PROFESOR, USER As BE.Usuario) As Integer
        Dim pat As New BE.Patente
        Dim parametros(7) As SqlParameter
        Dim pass As New BE.CryptoManager
        Dim hash As String

        hash = pass.Encrypt(USER.CLAVE)


        parametros(0) = acceso.crearparametro("@dni", CLIENTE.DNI)
        parametros(1) = acceso.crearparametro("@nombre", CLIENTE.Nombre)
        parametros(2) = acceso.crearparametro("@apellido", CLIENTE.Apellido)
        parametros(3) = acceso.crearparametro("@fecha_nac", CLIENTE.FechaNac)
        parametros(4) = acceso.crearparametro("@mail", CLIENTE.Mail)
        parametros(5) = acceso.crearparametro("@fecha_contratacion", fecha)
        parametros(6) = acceso.crearparametro("@sueldo", CLIENTE.SUELDO)
        parametros(7) = acceso.crearparametro("@pass", hash)


        Return acceso.ESCRIBIR("alta_docente", parametros)
    End Function






    Public Function crearusuario(CLIENTE As BE.CLIENTE, CUOTA As BE.CUOTAS, USER As BE.Usuario) As Integer
        Dim pat As New BE.Patente
        Dim parametros(7) As SqlParameter
      


        parametros(0) = acceso.crearparametro("@dni", CLIENTE.DNI)
        parametros(1) = acceso.crearparametro("@nombre", CLIENTE.Nombre)
        parametros(2) = acceso.crearparametro("@apellido", CLIENTE.Apellido)
        parametros(3) = acceso.crearparametro("@fecha_nac", CLIENTE.FechaNac)
        parametros(4) = acceso.crearparametro("@mail", CLIENTE.Mail)
        parametros(5) = acceso.crearparametro("@fecha", fecha)
        parametros(6) = acceso.crearparametro("@monto", CUOTA.MONTO)
        parametros(7) = acceso.crearparametro("@pass", USER.CLAVE)



        Return acceso.ESCRIBIR("Alta_cliente", parametros)
    End Function


End Class
