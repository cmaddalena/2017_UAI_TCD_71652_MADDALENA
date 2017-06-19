Public Class MP_LENGUAJE
    Dim acceso As New ACCESO

    Public Function Listar_Lenguajes() As List(Of BE.Lenguaje)
        Dim lenguajes As New List(Of BE.Lenguaje)
        Dim dt As New DataTable


        dt = acceso.leer("traer_idiomas", Nothing)

        For Each r In dt.Rows
            Dim lenguaje As New BE.Lenguaje

            lenguaje.ID = r("id_idioma")
            lenguaje.NOMBRE = r("nombre_idioma")

            lenguajes.Add(lenguaje)

        Next

        Return lenguajes

    End Function

    Public Function traertraduccion(idioma As String, formulario As String) As List(Of BE.Lenguaje_form)

        Dim lenguajesdelform As New List(Of BE.Lenguaje_form)
        Dim dt As New DataTable


        dt = Conexion.GetData("select * from LANG_INTERFACE where id_form='" & formulario & "' and id_idioma= (select id_idioma from Lenguaje where nombre_idioma='" & idioma & "')")

        For Each r In dt.Rows
            Dim lenguaje As New BE.Lenguaje_form

            lenguaje.ID = r("id_idioma")
            lenguaje.form = r("id_form")
            lenguaje.control = r("id_control")
            lenguaje.texto = r("texto")

            lenguajesdelform.Add(lenguaje)

        Next

        Return lenguajesdelform


    End Function

End Class
