Imports System.Data.SqlClient
Imports System.Configuration


Module Module1


    Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("string_conexion").ToString)

    Sub conectar()
        con.Open()
        MessageBox.Show(ConfigurationManager.ConnectionStrings("string_conexion").ToString)

        BE.Conexion.GetInstance.str = (ConfigurationManager.ConnectionStrings("string_conexion").ToString)
    End Sub

End Module
