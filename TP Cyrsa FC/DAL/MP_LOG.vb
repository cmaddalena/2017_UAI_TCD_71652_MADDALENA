Public Class MP_LOG

    Public Function insert_log(log As BE.Log) As Integer
        Dim i As Integer = Conexion.updatedata("INSERT INTO LOGS VALUES ('" & log.FECHA & "','" & log.DESCRIPCION & "'," & log.TIPO & ")")
        Return i
    End Function

    Public Function Listar_TipoLogs() As DataTable
        Dim dt As New DataTable

        dt = Conexion.GetData("Select * from TIPO_LOG")

        Return dt

    End Function


    Public Function Buscar_Log(fecha As Date, Optional Tipo As String = Nothing) As List(Of BE.Log)
        Dim logs As New List(Of BE.Log)
        Dim dt As New DataTable

        If Tipo IsNot Nothing Then
            dt = Conexion.GetData("Select * from LOGS Where FECHA= '" & fecha & "' and Tipo='" & Tipo & "'")
        Else
            dt = Conexion.GetData("Select * from LOGS Where FECHA= '" & fecha & "'")
        End If

        For Each r In dt.Rows
            Dim log As New BE.Log

            log.DESCRIPCION = r("DESCRIPCION")
            log.FECHA = fecha
            log.TIPO = Tipo

            logs.Add(log)
        Next

        Return logs
    End Function



End Class
