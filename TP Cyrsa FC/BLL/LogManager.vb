Public Class LogManager
    Dim mp As New DAL.MP_LOG

    Public Function Guardar_Log(log As BE.Log) As Integer

        log.FECHA = DateTime.Now

        Dim i As Integer

        i = mp.insert_log(log)

        Return i
    End Function


    Public Function Buscar_Log(fecha As Date, Optional Tipo As String = Nothing) As List(Of BE.Log)
        Dim Logs As New List(Of BE.Log)
        Logs = mp.Buscar_Log(fecha, Tipo)

        Return Logs
    End Function

End Class
