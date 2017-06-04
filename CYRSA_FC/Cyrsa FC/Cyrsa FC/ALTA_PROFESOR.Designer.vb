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
        Me.gbaltaprofesor = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
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
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lsueldoprofesor = New System.Windows.Forms.Label()
        Me.bregistrarprofesor = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENUPRINCIPALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbaltaprofesor.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbaltaprofesor
        '
        Me.gbaltaprofesor.BackColor = System.Drawing.Color.Transparent
        Me.gbaltaprofesor.Controls.Add(Me.DateTimePicker1)
        Me.gbaltaprofesor.Controls.Add(Me.TextBox6)
        Me.gbaltaprofesor.Controls.Add(Me.TextBox7)
        Me.gbaltaprofesor.Controls.Add(Me.lsueldoprofesor)
        Me.gbaltaprofesor.Controls.Add(Me.lpassprofesor)
        Me.gbaltaprofesor.Controls.Add(Me.TextBox2)
        Me.gbaltaprofesor.Controls.Add(Me.ldniprofesor)
        Me.gbaltaprofesor.Controls.Add(Me.lnombreprofesor)
        Me.gbaltaprofesor.Controls.Add(Me.lapellidoprofesor)
        Me.gbaltaprofesor.Controls.Add(Me.lmailprofesor)
        Me.gbaltaprofesor.Controls.Add(Me.TextBox4)
        Me.gbaltaprofesor.Controls.Add(Me.lfechanacprofesor)
        Me.gbaltaprofesor.Controls.Add(Me.TextBox3)
        Me.gbaltaprofesor.Controls.Add(Me.TextBox1)
        Me.gbaltaprofesor.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbaltaprofesor.Location = New System.Drawing.Point(15, 63)
        Me.gbaltaprofesor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbaltaprofesor.Name = "gbaltaprofesor"
        Me.gbaltaprofesor.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbaltaprofesor.Size = New System.Drawing.Size(651, 455)
        Me.gbaltaprofesor.TabIndex = 19
        Me.gbaltaprofesor.TabStop = False
        Me.gbaltaprofesor.Text = "DETALLE_PROFESOR"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(272, 296)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker1.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(273, 344)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox7.Size = New System.Drawing.Size(204, 26)
        Me.TextBox7.TabIndex = 12
        '
        'lpassprofesor
        '
        Me.lpassprofesor.AutoSize = True
        Me.lpassprofesor.Location = New System.Drawing.Point(28, 352)
        Me.lpassprofesor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lpassprofesor.Name = "lpassprofesor"
        Me.lpassprofesor.Size = New System.Drawing.Size(91, 18)
        Me.lpassprofesor.TabIndex = 11
        Me.lpassprofesor.Text = "PASSWORD"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(272, 97)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(204, 26)
        Me.TextBox2.TabIndex = 7
        '
        'ldniprofesor
        '
        Me.ldniprofesor.AutoSize = True
        Me.ldniprofesor.Location = New System.Drawing.Point(27, 42)
        Me.ldniprofesor.Name = "ldniprofesor"
        Me.ldniprofesor.Size = New System.Drawing.Size(34, 18)
        Me.ldniprofesor.TabIndex = 1
        Me.ldniprofesor.Text = "DNI"
        '
        'lnombreprofesor
        '
        Me.lnombreprofesor.AutoSize = True
        Me.lnombreprofesor.Location = New System.Drawing.Point(27, 103)
        Me.lnombreprofesor.Name = "lnombreprofesor"
        Me.lnombreprofesor.Size = New System.Drawing.Size(71, 18)
        Me.lnombreprofesor.TabIndex = 2
        Me.lnombreprofesor.Text = "NOMBRE"
        '
        'lapellidoprofesor
        '
        Me.lapellidoprofesor.AutoSize = True
        Me.lapellidoprofesor.Location = New System.Drawing.Point(27, 170)
        Me.lapellidoprofesor.Name = "lapellidoprofesor"
        Me.lapellidoprofesor.Size = New System.Drawing.Size(79, 18)
        Me.lapellidoprofesor.TabIndex = 3
        Me.lapellidoprofesor.Text = "APELLIDO"
        '
        'lmailprofesor
        '
        Me.lmailprofesor.AutoSize = True
        Me.lmailprofesor.Location = New System.Drawing.Point(27, 239)
        Me.lmailprofesor.Name = "lmailprofesor"
        Me.lmailprofesor.Size = New System.Drawing.Size(43, 18)
        Me.lmailprofesor.TabIndex = 4
        Me.lmailprofesor.Text = "MAIL"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(272, 225)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(204, 26)
        Me.TextBox4.TabIndex = 9
        '
        'lfechanacprofesor
        '
        Me.lfechanacprofesor.AutoSize = True
        Me.lfechanacprofesor.Location = New System.Drawing.Point(28, 296)
        Me.lfechanacprofesor.Name = "lfechanacprofesor"
        Me.lfechanacprofesor.Size = New System.Drawing.Size(91, 18)
        Me.lfechanacprofesor.TabIndex = 5
        Me.lfechanacprofesor.Text = "FECHA_NAC"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(272, 157)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(204, 26)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(272, 42)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(204, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(273, 395)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(203, 26)
        Me.TextBox6.TabIndex = 18
        '
        'lsueldoprofesor
        '
        Me.lsueldoprofesor.AutoSize = True
        Me.lsueldoprofesor.BackColor = System.Drawing.Color.Transparent
        Me.lsueldoprofesor.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsueldoprofesor.Location = New System.Drawing.Point(27, 398)
        Me.lsueldoprofesor.Name = "lsueldoprofesor"
        Me.lsueldoprofesor.Size = New System.Drawing.Size(66, 18)
        Me.lsueldoprofesor.TabIndex = 17
        Me.lsueldoprofesor.Text = "Sueldo"
        '
        'bregistrarprofesor
        '
        Me.bregistrarprofesor.BackColor = System.Drawing.Color.Transparent
        Me.bregistrarprofesor.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button
        Me.bregistrarprofesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bregistrarprofesor.FlatAppearance.BorderSize = 0
        Me.bregistrarprofesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bregistrarprofesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bregistrarprofesor.Location = New System.Drawing.Point(241, 592)
        Me.bregistrarprofesor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.bregistrarprofesor.Name = "bregistrarprofesor"
        Me.bregistrarprofesor.Size = New System.Drawing.Size(302, 65)
        Me.bregistrarprofesor.TabIndex = 16
        Me.bregistrarprofesor.Text = "REGISTRAR_USUARIO"
        Me.bregistrarprofesor.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(740, 27)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUPRINCIPALToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(70, 19)
        Me.ARCHIVOToolStripMenuItem.Text = "ARCHIVO"
        '
        'MENUPRINCIPALToolStripMenuItem
        '
        Me.MENUPRINCIPALToolStripMenuItem.Name = "MENUPRINCIPALToolStripMenuItem"
        Me.MENUPRINCIPALToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.MENUPRINCIPALToolStripMenuItem.Text = "MENU_PRINCIPAL"
        '
        'ALTA_PROFESOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.cancha
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 741)
        Me.Controls.Add(Me.gbaltaprofesor)
        Me.Controls.Add(Me.bregistrarprofesor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ALTA_PROFESOR"
        Me.Text = "ALTA_PROFESOR"
        Me.gbaltaprofesor.ResumeLayout(False)
        Me.gbaltaprofesor.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbaltaprofesor As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
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
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents lsueldoprofesor As System.Windows.Forms.Label
    Friend WithEvents bregistrarprofesor As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MENUPRINCIPALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
