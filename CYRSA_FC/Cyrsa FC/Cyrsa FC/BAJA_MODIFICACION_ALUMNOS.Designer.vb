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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BAJA_MODIFICACION_ALUMNOS))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtbdocentespass = New System.Windows.Forms.TextBox()
        Me.lblalumnospassword = New System.Windows.Forms.Label()
        Me.dtpbdocentesfechanac = New System.Windows.Forms.DateTimePicker()
        Me.lblbalumnosfechanac = New System.Windows.Forms.Label()
        Me.txtbdocentesnombre = New System.Windows.Forms.TextBox()
        Me.lblbalumnosdni = New System.Windows.Forms.Label()
        Me.lblalumnosnombre = New System.Windows.Forms.Label()
        Me.lblalumnosapellido = New System.Windows.Forms.Label()
        Me.lblalumnosmail = New System.Windows.Forms.Label()
        Me.txtbdocentesmail = New System.Windows.Forms.TextBox()
        Me.txtbdocentesapellido = New System.Windows.Forms.TextBox()
        Me.txtbdocentesdni = New System.Windows.Forms.TextBox()
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 48)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "MODIFICAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(210, 462)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 48)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "ELIMINAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(399, 462)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(213, 53)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Volver_Menu"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtbdocentespass
        '
        Me.txtbdocentespass.Location = New System.Drawing.Point(602, 293)
        Me.txtbdocentespass.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentespass.Name = "txtbdocentespass"
        Me.txtbdocentespass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbdocentespass.Size = New System.Drawing.Size(137, 20)
        Me.txtbdocentespass.TabIndex = 33
        '
        'lblalumnospassword
        '
        Me.lblalumnospassword.AutoSize = True
        Me.lblalumnospassword.BackColor = System.Drawing.Color.Transparent
        Me.lblalumnospassword.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalumnospassword.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblalumnospassword.Location = New System.Drawing.Point(462, 291)
        Me.lblalumnospassword.Name = "lblalumnospassword"
        Me.lblalumnospassword.Size = New System.Drawing.Size(53, 18)
        Me.lblalumnospassword.TabIndex = 32
        Me.lblalumnospassword.Text = "Clave"
        '
        'dtpbdocentesfechanac
        '
        Me.dtpbdocentesfechanac.Location = New System.Drawing.Point(602, 249)
        Me.dtpbdocentesfechanac.Name = "dtpbdocentesfechanac"
        Me.dtpbdocentesfechanac.Size = New System.Drawing.Size(200, 20)
        Me.dtpbdocentesfechanac.TabIndex = 31
        '
        'lblbalumnosfechanac
        '
        Me.lblbalumnosfechanac.AutoSize = True
        Me.lblbalumnosfechanac.BackColor = System.Drawing.Color.Transparent
        Me.lblbalumnosfechanac.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalumnosfechanac.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblbalumnosfechanac.Location = New System.Drawing.Point(462, 242)
        Me.lblbalumnosfechanac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbalumnosfechanac.Name = "lblbalumnosfechanac"
        Me.lblbalumnosfechanac.Size = New System.Drawing.Size(91, 18)
        Me.lblbalumnosfechanac.TabIndex = 30
        Me.lblbalumnosfechanac.Text = "FECHA_NAC"
        '
        'txtbdocentesnombre
        '
        Me.txtbdocentesnombre.Location = New System.Drawing.Point(602, 109)
        Me.txtbdocentesnombre.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentesnombre.Name = "txtbdocentesnombre"
        Me.txtbdocentesnombre.Size = New System.Drawing.Size(137, 20)
        Me.txtbdocentesnombre.TabIndex = 27
        '
        'lblbalumnosdni
        '
        Me.lblbalumnosdni.AutoSize = True
        Me.lblbalumnosdni.BackColor = System.Drawing.Color.Transparent
        Me.lblbalumnosdni.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalumnosdni.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblbalumnosdni.Location = New System.Drawing.Point(462, 57)
        Me.lblbalumnosdni.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbalumnosdni.Name = "lblbalumnosdni"
        Me.lblbalumnosdni.Size = New System.Drawing.Size(34, 18)
        Me.lblbalumnosdni.TabIndex = 22
        Me.lblbalumnosdni.Text = "DNI"
        '
        'lblalumnosnombre
        '
        Me.lblalumnosnombre.AutoSize = True
        Me.lblalumnosnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblalumnosnombre.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalumnosnombre.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblalumnosnombre.Location = New System.Drawing.Point(462, 104)
        Me.lblalumnosnombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblalumnosnombre.Name = "lblalumnosnombre"
        Me.lblalumnosnombre.Size = New System.Drawing.Size(71, 18)
        Me.lblalumnosnombre.TabIndex = 23
        Me.lblalumnosnombre.Text = "NOMBRE"
        '
        'lblalumnosapellido
        '
        Me.lblalumnosapellido.AutoSize = True
        Me.lblalumnosapellido.BackColor = System.Drawing.Color.Transparent
        Me.lblalumnosapellido.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalumnosapellido.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblalumnosapellido.Location = New System.Drawing.Point(462, 155)
        Me.lblalumnosapellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblalumnosapellido.Name = "lblalumnosapellido"
        Me.lblalumnosapellido.Size = New System.Drawing.Size(79, 18)
        Me.lblalumnosapellido.TabIndex = 24
        Me.lblalumnosapellido.Text = "APELLIDO"
        '
        'lblalumnosmail
        '
        Me.lblalumnosmail.AutoSize = True
        Me.lblalumnosmail.BackColor = System.Drawing.Color.Transparent
        Me.lblalumnosmail.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalumnosmail.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblalumnosmail.Location = New System.Drawing.Point(462, 201)
        Me.lblalumnosmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblalumnosmail.Name = "lblalumnosmail"
        Me.lblalumnosmail.Size = New System.Drawing.Size(43, 18)
        Me.lblalumnosmail.TabIndex = 25
        Me.lblalumnosmail.Text = "MAIL"
        '
        'txtbdocentesmail
        '
        Me.txtbdocentesmail.Location = New System.Drawing.Point(602, 207)
        Me.txtbdocentesmail.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentesmail.Name = "txtbdocentesmail"
        Me.txtbdocentesmail.Size = New System.Drawing.Size(137, 20)
        Me.txtbdocentesmail.TabIndex = 29
        '
        'txtbdocentesapellido
        '
        Me.txtbdocentesapellido.Location = New System.Drawing.Point(602, 155)
        Me.txtbdocentesapellido.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentesapellido.Name = "txtbdocentesapellido"
        Me.txtbdocentesapellido.Size = New System.Drawing.Size(137, 20)
        Me.txtbdocentesapellido.TabIndex = 28
        '
        'txtbdocentesdni
        '
        Me.txtbdocentesdni.Location = New System.Drawing.Point(602, 67)
        Me.txtbdocentesdni.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtbdocentesdni.Name = "txtbdocentesdni"
        Me.txtbdocentesdni.Size = New System.Drawing.Size(137, 20)
        Me.txtbdocentesdni.TabIndex = 26
        '
        'BAJA_MODIFICACION_ALUMNOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.portadafutbol
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(826, 548)
        Me.Controls.Add(Me.txtbdocentespass)
        Me.Controls.Add(Me.lblalumnospassword)
        Me.Controls.Add(Me.dtpbdocentesfechanac)
        Me.Controls.Add(Me.lblbalumnosfechanac)
        Me.Controls.Add(Me.txtbdocentesnombre)
        Me.Controls.Add(Me.lblbalumnosdni)
        Me.Controls.Add(Me.lblalumnosnombre)
        Me.Controls.Add(Me.lblalumnosapellido)
        Me.Controls.Add(Me.lblalumnosmail)
        Me.Controls.Add(Me.txtbdocentesmail)
        Me.Controls.Add(Me.txtbdocentesapellido)
        Me.Controls.Add(Me.txtbdocentesdni)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "BAJA_MODIFICACION_ALUMNOS"
        Me.Text = "BAJA_MODIFICACION_ALUMNOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtbdocentespass As System.Windows.Forms.TextBox
    Friend WithEvents lblalumnospassword As System.Windows.Forms.Label
    Friend WithEvents dtpbdocentesfechanac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblbalumnosfechanac As System.Windows.Forms.Label
    Friend WithEvents txtbdocentesnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblbalumnosdni As System.Windows.Forms.Label
    Friend WithEvents lblalumnosnombre As System.Windows.Forms.Label
    Friend WithEvents lblalumnosapellido As System.Windows.Forms.Label
    Friend WithEvents lblalumnosmail As System.Windows.Forms.Label
    Friend WithEvents txtbdocentesmail As System.Windows.Forms.TextBox
    Friend WithEvents txtbdocentesapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtbdocentesdni As System.Windows.Forms.TextBox
End Class
