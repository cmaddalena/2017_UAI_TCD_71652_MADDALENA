Public Class Gestor_Lenguajes
    Dim mp As New DAL.MP_LENGUAJE

    Public Function devolver_lenguajes() As List(Of BE.Lenguaje)
        Dim lengs As New List(Of BE.Lenguaje)

        lengs = mp.Listar_Lenguajes
        Return lengs


    End Function



    Public Function cambiarlenguajeForm(idioma As String, formulario As String) As List(Of BE.Lenguaje_form)
        Dim traducciones As New List(Of BE.Lenguaje_form)

        traducciones = mp.traertraduccion(idioma, formulario)

        Return traducciones
    End Function

End Class
