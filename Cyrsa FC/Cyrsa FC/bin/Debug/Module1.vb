Imports System.Data.SqlClient
Imports System.Configuration


Module Module1


    Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("string_conexion").ToString)

    Sub conectar()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        MessageBox.Show("USTED SE ESTA CONECTANDO CON EL SIGUIENTE STRING DE CONEXION: " & ConfigurationManager.ConnectionStrings("string_conexion").ToString)

        BE.Conexion.GetInstance.str = (ConfigurationManager.ConnectionStrings("string_conexion").ToString)
    End Sub

End Module
