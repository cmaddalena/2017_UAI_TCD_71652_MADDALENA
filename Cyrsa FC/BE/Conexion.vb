Public Class Conexion



    Private Shared _instance As Conexion
    Public Shared Function GetInstance() As Conexion

        If _instance Is Nothing Then
            _instance = New Conexion
        End If

        Return _instance
    End Function




    Shared Sub con(s As String)
        _instance.str = s


    End Sub


    Public str As String







End Class
