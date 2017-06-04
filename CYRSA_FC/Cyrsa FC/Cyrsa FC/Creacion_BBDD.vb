Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Sql



Public Class Creacion_BBDD
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim servidores As SqlDataSourceEnumerator
        Dim tablaServidores As DataTable
        servidores = SqlDataSourceEnumerator.Instance
        tablaServidores = New DataTable()
        tablaServidores = servidores.GetDataSources()
        Dim rowServidor As DataRow
        For Each rowServidor In tablaServidores.Rows
            If String.IsNullOrEmpty(rowServidor("InstanceName").ToString()) Then
                cmbServidores.Items.Add(rowServidor("ServerName").ToString())
            Else
                cmbServidores.Items.Add(rowServidor("ServerName") & "\" & rowServidor("InstanceName"))
            End If
        Next
    End Sub


    Private Function CrearBase(server As String, rutascript As String) As Boolean
        Try
            Dim Arguments = "-S " & server & " -i " & Chr(34) & rutascript & Chr(34)
            System.Diagnostics.Process.Start("sqlcmd.exe", Arguments).WaitForExit()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnInstalar_Click(sender As Object, e As EventArgs) Handles btnInstalar.Click
        If Not String.IsNullOrWhiteSpace(cmbServidores.Text) AndAlso Not String.IsNullOrEmpty(TextBox1.Text) Then
            If (CrearBase(cmbServidores.Text, TextBox1.Text)) Then
                MessageBox.Show("Configuracion Exitosa", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CyrsaFC_Menu.Show()

                'Creacion_BBDD.Close()

            Else
                MessageBox.Show("Configuracion Fallida", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("seleccione una instancia y el script de base de datos", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Creacion de Base de Datos"
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.DefaultExt = "sql"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class