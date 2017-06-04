<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAJA_MODIFICACION_ALUMNOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpbdocentesfechacontrato = New System.Windows.Forms.DateTimePicker()
        Me.txtbdocentessueldo = New System.Windows.Forms.TextBox()
        Me.lblbdocentessueldo = New System.Windows.Forms.Label()
        Me.txtbdocentesnombre = New System.Windows.Forms.TextBox()
        Me.lblbdocentesdni = New System.Windows.Forms.Label()
        Me.lblbdocentesnombre = New System.Windows.Forms.Label()
        Me.lblbdocentesapellido = New System.Windows.Forms.Label()
        Me.lblbdocentesmail = New System.Windows.Forms.Label()
        Me.txtbdocentesmail = New System.Windows.Forms.TextBox()
        Me.lblbdocentesfechacontrato = New System.Windows.Forms.Label()
        Me.txtbdocentesapellido = New System.Windows.Forms.TextBox()
        Me.txtbdocentesdni = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtpbdocentesfechanac = New System.Windows.Forms.DateTimePicker()
        Me.lblbdocentesfechanac = New System.Windows.Forms.Label()
        Me.txtbdocentespass = New System.Windows.Forms.TextBox()
        Me.lblbdocentespassword = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(298, 303)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbdocentespass)
        Me.GroupBox1.Controls.Add(Me.lblbdocentespassword)
        Me.GroupBox1.Controls.Add(Me.dtpbdocentesfechanac)
        Me.GroupBox1.Controls.Add(Me.lblbdocentesfechanac)
        Me.GroupBox1.Controls.Add(Me.dtpbdocentesfechacontrato)
        Me.GroupBox1.Controls.Add(Me.txtbdocentessueldo)
        Me.GroupBox1.Controls.Add(Me.lblbdocentessueldo)
        Me.GroupBox1.Controls.Add(Me.txtbdocentesnombre)
        Me.GroupBox1.Controls.Add(Me.lblbdocentesdni)
        Me.GroupBox1.Controls.Add(Me.lblbdocentesnombre)
        Me.GroupBox1.Controls.Add(Me.lblbdocentesapellido)
        Me.GroupBox1.Controls.Add(Me.lblbdocentesmail)
        Me.GroupBox1.Controls.Add(Me.txtbdocentesmail)
        Me.GroupBox1.Controls.Add(Me.lblbdocentesfechacontrato)
        Me.GroupBox1.Controls.Add(Me.txtbdocentesapellido)
        Me.GroupBox1.Controls.Add(Me.txtbdocentesdni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(345, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 376)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETALLE_ALUMNO"
        '
        'dtpbdocentesfechacontrato
        '
        Me.dtpbdocentesfechacontrato.Location = New System.Drawing.Point(182, 245)
        Me.dtpbdocentesfechacontrato.Name = "dtpbdocentesfechacontrato"
        Me.dtpbdocentesfechacontrato.Size = New System.Drawing.Size(200, 26)
        Me.dtpbdocentesfechacontrato.TabIndex = 13
        '
        'txtbdocentessueldo
        '
        Me.txtbdocentessueldo.Location = New System.Drawing.Point(182, 289)
        Me.txtbdocentessueldo.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentessueldo.Name = "txtbdocentessueldo"
        Me.txtbdocentessueldo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbdocentessueldo.Size = New System.Drawing.Size(137, 26)
        Me.txtbdocentessueldo.TabIndex = 12
        '
        'lblbdocentessueldo
        '
        Me.lblbdocentessueldo.AutoSize = True
        Me.lblbdocentessueldo.Location = New System.Drawing.Point(19, 293)
        Me.lblbdocentessueldo.Name = "lblbdocentessueldo"
        Me.lblbdocentessueldo.Size = New System.Drawing.Size(76, 20)
        Me.lblbdocentessueldo.TabIndex = 11
        Me.lblbdocentessueldo.Text = "SUELDO"
        '
        'txtbdocentesnombre
        '
        Me.txtbdocentesnombre.Location = New System.Drawing.Point(182, 60)
        Me.txtbdocentesnombre.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentesnombre.Name = "txtbdocentesnombre"
        Me.txtbdocentesnombre.Size = New System.Drawing.Size(137, 26)
        Me.txtbdocentesnombre.TabIndex = 7
        '
        'lblbdocentesdni
        '
        Me.lblbdocentesdni.AutoSize = True
        Me.lblbdocentesdni.Location = New System.Drawing.Point(19, 18)
        Me.lblbdocentesdni.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbdocentesdni.Name = "lblbdocentesdni"
        Me.lblbdocentesdni.Size = New System.Drawing.Size(37, 20)
        Me.lblbdocentesdni.TabIndex = 1
        Me.lblbdocentesdni.Text = "DNI"
        '
        'lblbdocentesnombre
        '
        Me.lblbdocentesnombre.AutoSize = True
        Me.lblbdocentesnombre.Location = New System.Drawing.Point(19, 65)
        Me.lblbdocentesnombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbdocentesnombre.Name = "lblbdocentesnombre"
        Me.lblbdocentesnombre.Size = New System.Drawing.Size(79, 20)
        Me.lblbdocentesnombre.TabIndex = 2
        Me.lblbdocentesnombre.Text = "NOMBRE"
        '
        'lblbdocentesapellido
        '
        Me.lblbdocentesapellido.AutoSize = True
        Me.lblbdocentesapellido.Location = New System.Drawing.Point(19, 116)
        Me.lblbdocentesapellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbdocentesapellido.Name = "lblbdocentesapellido"
        Me.lblbdocentesapellido.Size = New System.Drawing.Size(88, 20)
        Me.lblbdocentesapellido.TabIndex = 3
        Me.lblbdocentesapellido.Text = "APELLIDO"
        '
        'lblbdocentesmail
        '
        Me.lblbdocentesmail.AutoSize = True
        Me.lblbdocentesmail.Location = New System.Drawing.Point(19, 162)
        Me.lblbdocentesmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbdocentesmail.Name = "lblbdocentesmail"
        Me.lblbdocentesmail.Size = New System.Drawing.Size(47, 20)
        Me.lblbdocentesmail.TabIndex = 4
        Me.lblbdocentesmail.Text = "MAIL"
        '
        'txtbdocentesmail
        '
        Me.txtbdocentesmail.Location = New System.Drawing.Point(182, 158)
        Me.txtbdocentesmail.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentesmail.Name = "txtbdocentesmail"
        Me.txtbdocentesmail.Size = New System.Drawing.Size(137, 26)
        Me.txtbdocentesmail.TabIndex = 9
        '
        'lblbdocentesfechacontrato
        '
        Me.lblbdocentesfechacontrato.AutoSize = True
        Me.lblbdocentesfechacontrato.Location = New System.Drawing.Point(19, 246)
        Me.lblbdocentesfechacontrato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbdocentesfechacontrato.Name = "lblbdocentesfechacontrato"
        Me.lblbdocentesfechacontrato.Size = New System.Drawing.Size(160, 20)
        Me.lblbdocentesfechacontrato.TabIndex = 5
        Me.lblbdocentesfechacontrato.Text = "FECHA_CONTRATO"
        '
        'txtbdocentesapellido
        '
        Me.txtbdocentesapellido.Location = New System.Drawing.Point(182, 106)
        Me.txtbdocentesapellido.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentesapellido.Name = "txtbdocentesapellido"
        Me.txtbdocentesapellido.Size = New System.Drawing.Size(137, 26)
        Me.txtbdocentesapellido.TabIndex = 8
        '
        'txtbdocentesdni
        '
        Me.txtbdocentesdni.Location = New System.Drawing.Point(182, 18)
        Me.txtbdocentesdni.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentesdni.Name = "txtbdocentesdni"
        Me.txtbdocentesdni.Size = New System.Drawing.Size(137, 26)
        Me.txtbdocentesdni.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 48)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "MODIFICAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(210, 462)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 48)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "ELIMINAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtpbdocentesfechanac
        '
        Me.dtpbdocentesfechanac.Location = New System.Drawing.Point(182, 200)
        Me.dtpbdocentesfechanac.Name = "dtpbdocentesfechanac"
        Me.dtpbdocentesfechanac.Size = New System.Drawing.Size(200, 26)
        Me.dtpbdocentesfechanac.TabIndex = 15
        '
        'lblbdocentesfechanac
        '
        Me.lblbdocentesfechanac.AutoSize = True
        Me.lblbdocentesfechanac.Location = New System.Drawing.Point(19, 203)
        Me.lblbdocentesfechanac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbdocentesfechanac.Name = "lblbdocentesfechanac"
        Me.lblbdocentesfechanac.Size = New System.Drawing.Size(106, 20)
        Me.lblbdocentesfechanac.TabIndex = 14
        Me.lblbdocentesfechanac.Text = "FECHA_NAC"
        '
        'txtbdocentespass
        '
        Me.txtbdocentespass.Location = New System.Drawing.Point(182, 335)
        Me.txtbdocentespass.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentespass.Name = "txtbdocentespass"
        Me.txtbdocentespass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbdocentespass.Size = New System.Drawing.Size(137, 26)
        Me.txtbdocentespass.TabIndex = 17
        '
        'lblbdocentespassword
        '
        Me.lblbdocentespassword.AutoSize = True
        Me.lblbdocentespassword.Location = New System.Drawing.Point(19, 341)
        Me.lblbdocentespassword.Name = "lblbdocentespassword"
        Me.lblbdocentespassword.Size = New System.Drawing.Size(103, 20)
        Me.lblbdocentespassword.TabIndex = 16
        Me.lblbdocentespassword.Text = "PASSWORD"
        '
        'BAJA_MODIFICACION_ALUMNOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 548)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "BAJA_MODIFICACION_ALUMNOS"
        Me.Text = "BAJA_MODIFICACION_ALUMNOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbdocentessueldo As System.Windows.Forms.TextBox
    Friend WithEvents lblbdocentessueldo As System.Windows.Forms.Label
    Friend WithEvents txtbdocentesnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblbdocentesdni As System.Windows.Forms.Label
    Friend WithEvents lblbdocentesnombre As System.Windows.Forms.Label
    Friend WithEvents lblbdocentesapellido As System.Windows.Forms.Label
    Friend WithEvents lblbdocentesmail As System.Windows.Forms.Label
    Friend WithEvents txtbdocentesmail As System.Windows.Forms.TextBox
    Friend WithEvents lblbdocentesfechacontrato As System.Windows.Forms.Label
    Friend WithEvents txtbdocentesapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtbdocentesdni As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpbdocentesfechacontrato As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtbdocentespass As System.Windows.Forms.TextBox
    Friend WithEvents lblbdocentespassword As System.Windows.Forms.Label
    Friend WithEvents dtpbdocentesfechanac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblbdocentesfechanac As System.Windows.Forms.Label
End Class
