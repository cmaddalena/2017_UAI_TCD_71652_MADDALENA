<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTA_PROFESOR
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
        Me.bregistrarprofesor = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lsueldoprofesor = New System.Windows.Forms.Label()
        Me.lpassprofesor = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ldniprofesor = New System.Windows.Forms.Label()
        Me.lnombreprofesor = New System.Windows.Forms.Label()
        Me.lapellidoprofesor = New System.Windows.Forms.Label()
        Me.lmailprofesor = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lfechanacprofesor = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bregistrarprofesor
        '
        Me.bregistrarprofesor.BackColor = System.Drawing.Color.Transparent
        Me.bregistrarprofesor.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button
        Me.bregistrarprofesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregistrarprofesor.FlatAppearance.BorderSize = 0
        Me.bregistrarprofesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bregistrarprofesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bregistrarprofesor.Location = New System.Drawing.Point(544, 54)
        Me.bregistrarprofesor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.bregistrarprofesor.Name = "bregistrarprofesor"
        Me.bregistrarprofesor.Size = New System.Drawing.Size(302, 65)
        Me.bregistrarprofesor.TabIndex = 16
        Me.bregistrarprofesor.Text = "REGISTRAR_PERSONAL"
        Me.bregistrarprofesor.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(547, 128)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(291, 66)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Volver_Menu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(284, 329)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 24)
        Me.DateTimePicker1.TabIndex = 32
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(285, 428)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(203, 24)
        Me.TextBox6.TabIndex = 34
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(285, 377)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox7.Size = New System.Drawing.Size(204, 24)
        Me.TextBox7.TabIndex = 31
        '
        'lsueldoprofesor
        '
        Me.lsueldoprofesor.AutoSize = True
        Me.lsueldoprofesor.BackColor = System.Drawing.Color.Transparent
        Me.lsueldoprofesor.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsueldoprofesor.Location = New System.Drawing.Point(39, 431)
        Me.lsueldoprofesor.Name = "lsueldoprofesor"
        Me.lsueldoprofesor.Size = New System.Drawing.Size(66, 18)
        Me.lsueldoprofesor.TabIndex = 33
        Me.lsueldoprofesor.Text = "Sueldo"
        '
        'lpassprofesor
        '
        Me.lpassprofesor.AutoSize = True
        Me.lpassprofesor.BackColor = System.Drawing.Color.Transparent
        Me.lpassprofesor.Location = New System.Drawing.Point(40, 385)
        Me.lpassprofesor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lpassprofesor.Name = "lpassprofesor"
        Me.lpassprofesor.Size = New System.Drawing.Size(46, 17)
        Me.lpassprofesor.TabIndex = 30
        Me.lpassprofesor.Text = "CLAVE"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(284, 130)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(204, 24)
        Me.TextBox2.TabIndex = 27
        '
        'ldniprofesor
        '
        Me.ldniprofesor.AutoSize = True
        Me.ldniprofesor.BackColor = System.Drawing.Color.Transparent
        Me.ldniprofesor.Location = New System.Drawing.Point(39, 75)
        Me.ldniprofesor.Name = "ldniprofesor"
        Me.ldniprofesor.Size = New System.Drawing.Size(92, 17)
        Me.ldniprofesor.TabIndex = 21
        Me.ldniprofesor.Text = "Documento"
        '
        'lnombreprofesor
        '
        Me.lnombreprofesor.AutoSize = True
        Me.lnombreprofesor.BackColor = System.Drawing.Color.Transparent
        Me.lnombreprofesor.Location = New System.Drawing.Point(39, 136)
        Me.lnombreprofesor.Name = "lnombreprofesor"
        Me.lnombreprofesor.Size = New System.Drawing.Size(63, 17)
        Me.lnombreprofesor.TabIndex = 22
        Me.lnombreprofesor.Text = "NOMBRE"
        '
        'lapellidoprofesor
        '
        Me.lapellidoprofesor.AutoSize = True
        Me.lapellidoprofesor.BackColor = System.Drawing.Color.Transparent
        Me.lapellidoprofesor.Location = New System.Drawing.Point(39, 203)
        Me.lapellidoprofesor.Name = "lapellidoprofesor"
        Me.lapellidoprofesor.Size = New System.Drawing.Size(71, 17)
        Me.lapellidoprofesor.TabIndex = 23
        Me.lapellidoprofesor.Text = "APELLIDO"
        '
        'lmailprofesor
        '
        Me.lmailprofesor.AutoSize = True
        Me.lmailprofesor.BackColor = System.Drawing.Color.Transparent
        Me.lmailprofesor.Location = New System.Drawing.Point(39, 272)
        Me.lmailprofesor.Name = "lmailprofesor"
        Me.lmailprofesor.Size = New System.Drawing.Size(39, 17)
        Me.lmailprofesor.TabIndex = 24
        Me.lmailprofesor.Text = "MAIL"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(284, 258)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(204, 24)
        Me.TextBox4.TabIndex = 29
        '
        'lfechanacprofesor
        '
        Me.lfechanacprofesor.AutoSize = True
        Me.lfechanacprofesor.BackColor = System.Drawing.Color.Transparent
        Me.lfechanacprofesor.Location = New System.Drawing.Point(40, 329)
        Me.lfechanacprofesor.Name = "lfechanacprofesor"
        Me.lfechanacprofesor.Size = New System.Drawing.Size(136, 17)
        Me.lfechanacprofesor.TabIndex = 25
        Me.lfechanacprofesor.Text = "Fecha_nacimiento"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(284, 190)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(204, 24)
        Me.TextBox3.TabIndex = 28
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(284, 75)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(204, 24)
        Me.TextBox1.TabIndex = 26
        '
        'ALTA_PROFESOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.cancha
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 741)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.lsueldoprofesor)
        Me.Controls.Add(Me.lpassprofesor)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ldniprofesor)
        Me.Controls.Add(Me.lnombreprofesor)
        Me.Controls.Add(Me.lapellidoprofesor)
        Me.Controls.Add(Me.lmailprofesor)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lfechanacprofesor)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bregistrarprofesor)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ALTA_PROFESOR"
        Me.Text = "Alta_Personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bregistrarprofesor As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents lsueldoprofesor As System.Windows.Forms.Label
    Friend WithEvents lpassprofesor As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ldniprofesor As System.Windows.Forms.Label
    Friend WithEvents lnombreprofesor As System.Windows.Forms.Label
    Friend WithEvents lapellidoprofesor As System.Windows.Forms.Label
    Friend WithEvents lmailprofesor As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lfechanacprofesor As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
