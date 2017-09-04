

Imports System.Data.SqlClient

Public Class Conexion
    Shared vConnectionString As String = System.Configuration.ConfigurationManager.ConnectionStrings("string_conexion").ConnectionString
    Shared vConexion As New SqlConnection(vConnectionString)
    Shared vComando As New SqlCommand()



    Public Shared Function GetData(pSelectCommand As String) As DataTable
        Dim DTable As New DataTable
        vComando.CommandText = pSelectCommand
        vComando.Connection = vConexion
        Dim DAdapter As New SqlDataAdapter(vComando)
        Dim CBuilder As New SqlCommandBuilder(DAdapter)

        ' DAdapter.InsertCommand = CBuilder.GetInsertCommand
        ' DAdapter.DeleteCommand = CBuilder.GetDeleteCommand
        '  DAdapter.UpdateCommand = CBuilder.GetUpdateCommand


        DAdapter.Fill(DTable)
        Return DTable
    End Function


    Public Shared Function updatedata(pSelectCommand As String) As Integer
        Dim i As New Integer
        vConexion.Open()
        Dim command As New SqlCommand(pSelectCommand)
        command.Connection = vConexion

        i = command.ExecuteNonQuery

        vConexion.Close()


        Return i
    End Function


End Class