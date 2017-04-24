'importo librerias

Imports System.Data.SqlClient
Imports System.Data


Friend Class ACCESO
    Private conexion As SqlConnection
    Private transact As SqlTransaction

    Private Sub abrir()
        conexion = New SqlConnection("Data Source=.\CYRSA_SA;Initial Catalog=CYRSA_FC;Integrated Security=SSPI")
        conexion.Open()
    End Sub

    Private Sub cerrar()
        conexion.Close()
        conexion = Nothing
        GC.Collect()
    End Sub

    Public Function leer(nombresp As String, Optional parametros() As SqlParameter = Nothing) As DataTable
        Dim tabla As New DataTable
        'Dim command As New SqlCommand
        abrir()

        Dim adaptador As New SqlDataAdapter
        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.CommandText = nombresp
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        adaptador.SelectCommand.Connection = conexion

        If parametros IsNot Nothing Then
            adaptador.SelectCommand.Parameters.AddRange(parametros)

        End If



        If transact IsNot Nothing Then
            adaptador.SelectCommand.Transaction = transact


        End If
        adaptador.Fill(tabla)

        cerrar()

        Return tabla
    End Function


    Public Function ESCRIBIR(nombresp As String, parametros() As SqlParameter) As Integer
        'la funcion escribir sera integer porque devolveremos el numero de filas afectadas

        Dim cmd As New SqlCommand
        abrir()
        cmd.Connection = conexion
        'instancio una variable con los datos de conexion
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = nombresp
        cmd.Parameters.AddRange(parametros)

        transact = conexion.BeginTransaction
        'inicio transaccion contra la bbdd
        cmd.Transaction = transact
        'el comando del tipo Transaction va a ser mi transaction

        Dim filas_Afectadas As Integer

        Try
            filas_Afectadas = cmd.ExecuteNonQuery
            'el numero de filas afectadas va a ser el numero de filas que ejecuto el comando CMD

            transact.Commit()
            'confirmo fin de la transaccion

            Return filas_Afectadas


        Catch
            'si hubo algun error mientras ejecutaba la transaccion

            filas_Afectadas = -1
            transact.Rollback()

            Return filas_Afectadas

        Finally
            cerrar()

        End Try


    End Function
    Public Function crearparametro(nombre As String, valor As String) As SqlParameter
        Dim p As New SqlParameter(nombre, valor)
        p.DbType = DbType.String
        Return p
    End Function


    Public Function crearparametro(nombre As String, valor As Integer) As SqlParameter
        Dim p As New SqlParameter(nombre, valor)
        'despues especificare el nombre del campo con este valor en el mapper
        p.DbType = DbType.Int32
        Return p
    End Function

    Public Function crearparametro(nombre As String, valor As Date) As SqlParameter
        Dim p As New SqlParameter(nombre, valor)
        'despues especificare el nombre del campo con este valor en el mapper
        p.DbType = DbType.Date
        Return p
    End Function


    Public Function crearparametro(nombre As String, valor As Single) As SqlParameter
        Dim p As New SqlParameter(nombre, valor)
        'despues especificare el nombre del campo con este valor en el mapper
        p.DbType = DbType.Single
        Return p
    End Function



End Class





