Public Class Gestor_equipo

    Dim mp As New DAL.MP_EQUIPO

    Public Function crearequipo(equipo As BE.EQUIPO) As Integer

        Dim i As Integer

        i = mp.insertarequipo(equipo)

        Return i

    End Function

End Class
