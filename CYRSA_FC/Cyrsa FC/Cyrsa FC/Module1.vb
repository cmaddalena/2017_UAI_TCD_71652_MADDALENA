Imports System.Data.SqlClient
Imports System.Configuration


Module Module1


    Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("string_conexion").ToString)

    Sub conectar()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' MessageBox.Show("USTED SE ESTA CONECTANDO CON EL SIGUIENTE STRING DE CONEXION: " & ConfigurationManager.ConnectionStrings("string_conexion").ToString)

        BE.Conexion.GetInstance.str = (ConfigurationManager.ConnectionStrings("string_conexion").ToString)
    End Sub




    Public Function ValidarText(text As TextBox) As Boolean
        If Not String.IsNullOrWhiteSpace(text.Text) Then
            Return True
        End If
        Return False
    End Function


    Public Function ValidarInt(text As TextBox) As Boolean
        If Not String.IsNullOrWhiteSpace(text.Text) And IsNumeric(text.Text) Then
            Return True
        End If
        Return False
    End Function


    Public Function Validarfecha(text As DateTimePicker) As Boolean
        If Not String.IsNullOrWhiteSpace(text.Value) And IsDate(text.Value) Then
            Return True
        End If
        Return False
    End Function




End Module
