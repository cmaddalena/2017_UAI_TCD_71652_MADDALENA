Public Class Gestor_Usuario
    Dim mp As New DAL.MP_USUARIOS

    Public Function listar_usuarios() As List(Of BE.Usuario)
        Dim usuarios As New List(Of BE.Usuario)

        usuarios = mp.Listar_Usuarios

        Return usuarios
    End Function

End Class
