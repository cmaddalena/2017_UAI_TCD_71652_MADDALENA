Imports System.Reflection
Imports System.Text.RegularExpressions

Public Class ABMLenguaje
    Dim formlimpio As String
    Dim gestor As New BLL.Gestor_Lenguajes

    Dim Asm As Assembly = Reflection.Assembly.GetExecutingAssembly()

    Private Sub ABMLenguaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarforms()
        recargarlenguajes()
    End Sub

    Sub cargarforms()
        Dim lista As New List(Of String)

        For Each t As Type In Asm.GetTypes()
            If t.IsSubclassOf(GetType(Form)) Then
                lista.Add(t.FullName)
            End If

        Next
        ListBox2.DataSource = lista

    End Sub


    Public Sub recargarlenguajes()
        ComboBox1.DataSource = Nothing
        ComboBox1.DataSource = gestor.devolver_lenguajes
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Alta_Idioma_Click(sender As Object, e As EventArgs) Handles Alta_Idioma.Click
        Dim leng As New BE.Lenguaje
        leng.NOMBRE = txtnombrelenguaje.Text
        gestor.insertar_lenguaje(leng)

        recargarlenguajes()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        MessageBox.Show(ListBox2.SelectedItem)

        Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly

        Dim f As Form = CType(asm.CreateInstance(DirectCast(ListBox2.SelectedItem, String).ToString), Form)
        '  Dim f As Form = CType(asm.CreateInstance(DirectCast(i, BE.Patente).Formulario), Form)

        For Each Control As Control In f.Controls
            If TypeOf Control Is Label Or TypeOf Control Is Button Then
                ListBox1.Items.Add(Control.Name)
                ListBox3.Items.Add(Control.Text)
            End If

        Next

     
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formcompleto As String = ListBox2.SelectedItem.ToString

        Dim formulario As Array
        formulario = formcompleto.Split(New Char(), ".")


        formlimpio = formulario(1).ToString

        MessageBox.Show(formlimpio)
        gestor.Insertar_form_traduccion((DirectCast(ComboBox1.SelectedItem, BE.Lenguaje).ID), formlimpio, ListBox1.SelectedItem, TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New MENU_USER
        frm.Show()
        Me.Close()

    End Sub
End Class