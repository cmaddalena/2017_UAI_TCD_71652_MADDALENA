Public Class Gestor_Lenguajes
    Dim mp As New DAL.MP_LENGUAJE

    Public Function devolver_lenguajes() As List(Of BE.Lenguaje)
        Dim lengs As New List(Of BE.Lenguaje)

        lengs = mp.Listar_Lenguajes
        Return lengs


    End Function

    Public Function insertar_lenguaje(leng As BE.Lenguaje) As Integer
        Dim i As Integer
        i = mp.insertar_lenguaje(leng)
        Return i

    End Function


    Public Function Insertar_form_traduccion(idioma As Integer, formulario As String, control As String, texto As String) As Integer
        Dim i As Integer
        i = mp.Insertar_form_traduccion(idioma, formulario, control, texto)
        Return i
    End Function

    Public Function TRADUCIR_MSJ(MSJ As BE.Lenguaje_Mensajero) As String
        Dim TRADUCCION_MSJ As String

        TRADUCCION_MSJ = mp.traducirMensaje(MSJ)

        Return TRADUCCION_MSJ
    End Function


    Public Function cambiarlenguajeForm(idioma As String, formulario As String) As List(Of BE.Lenguaje_form)
        Dim traducciones As New List(Of BE.Lenguaje_form)

        traducciones = mp.traertraduccion(idioma, formulario)

        Return traducciones
    End Function

End Class
