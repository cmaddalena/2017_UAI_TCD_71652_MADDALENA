Public Class Gestor_Usuario
    Dim mp As New DAL.MP_USUARIOS


    Public Function listar_usuarios() As List(Of BE.Usuario)
        Dim usuarios As New List(Of BE.Usuario)

        usuarios = mp.Listar_Usuarios

        Return usuarios
    End Function

    Public Function listar_patentes_usuario(u As BE.Usuario) As List(Of BE.Patente)

        Dim patentes As List(Of BE.Patente)

        patentes = mp.login(u)

        Return patentes
    End Function



    Public Function registrardocente(unusuario As BE.PROFESOR, USER As BE.Usuario) As String
        Dim registro As New DAL.MP_USUARIOS
        Dim fa As Integer = registro.creardocente(unusuario, USER)
        If fa > 0 Then
            Return "REGISTRADO"

        Else
            Return "ERROR DE REGISTRO VERIFIQUE LOS DATOS CARGADOS"

        End If

    End Function

    Public Function registarcliente(unusuario As BE.CLIENTE, cuota As BE.CUOTAS, USER As BE.Usuario) As String
        Dim registro As New DAL.MP_USUARIOS
        Dim fa As Integer = registro.crearusuario(unusuario, cuota, USER)
        If fa > 0 Then
            Return "REGISTRADO"

        Else
            Return "ERROR DE REGISTRO VERIFIQUE LOS DATOS CARGADOS"

        End If

    End Function


    Public Sub actualizar_idioma_usr(u As BE.Usuario, i As BE.Lenguaje)
        mp.update_lang_usr(u, i)

    End Sub

    Public Function leer_idioma_usr(u As BE.Usuario) As BE.Lenguaje
        Dim l As New BE.Lenguaje
        l = mp.leer_lang_usr(u)


        Return l
    End Function

End Class
