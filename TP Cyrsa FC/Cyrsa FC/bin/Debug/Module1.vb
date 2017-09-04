Imports System.Data.SqlClient
Imports System.Configuration


Module Module1
    Dim gestor As New BLL.Gestor_Patente
    Dim gestorusr As New BLL.Gestor_Usuario
    Public Log As New BE.Log
    Public gestorlog As New BLL.LogManager

    Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("string_conexion").ToString)

    Sub conectar()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' MessageBox.Show("USTED SE ESTA CONECTANDO CON EL SIGUIENTE STRING DE CONEXION: " & ConfigurationManager.ConnectionStrings("string_conexion").ToString)

        BE.Conexion.GetInstance.str = (ConfigurationManager.ConnectionStrings("string_conexion").ToString)
    End Sub


    Public Function TRADUCIR_MSJ(I As Integer) As String
        Dim GESTOR As New BLL.Gestor_Lenguajes
        Dim MSJ As New BE.Lenguaje_Mensajero
        MSJ.ID = I
        MSJ.Language.ID = BE.Lenguaje.getinstance.ID
        Dim STR As String
        STR = (GESTOR.TRADUCIR_MSJ(MSJ))
        Return STR

    End Function


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

    Public Sub cambiar_lenguaje(idioma As String, formulario As Form)
        Dim gestor As New BLL.Gestor_Lenguajes
        Dim traducciones As New List(Of BE.Lenguaje_form)

        traducciones = gestor.cambiarlenguajeForm(idioma, formulario.Name)


        For Each cntrl In formulario.Controls

            ' Dim lenguajecontrol As New BE.Lenguaje_form

            'lenguajecontrol = traducciones.Where(Function(lng) lng.control = cntrl.Name)

            For Each t In traducciones


                If t.control = cntrl.Name Then
                    Dim it As Control
                    If TypeOf cntrl Is Label Then
                        it = DirectCast(cntrl, Label)


                    ElseIf TypeOf cntrl Is Button Then
                        it = DirectCast(cntrl, Button)


                    ElseIf TypeOf cntrl Is GroupBox Then
                        it = DirectCast(cntrl, GroupBox)
                    End If


                    it.Text = t.texto.ToString
                End If




            Next
        Next



    End Sub


    Dim gestorlenguajes As New BLL.Gestor_Lenguajes
    Public Function listar_lenguajes() As List(Of BE.Lenguaje)
        Dim lengs As New List(Of BE.Lenguaje)

        lengs = gestorlenguajes.devolver_lenguajes
        Return lengs
    End Function

    Private _usrsession As BE.Usuario
    Public Property usrsession() As BE.Usuario
        Get
            Return _usrsession
        End Get
        Set(ByVal value As BE.Usuario)
            _usrsession = value
        End Set
    End Property



End Module
