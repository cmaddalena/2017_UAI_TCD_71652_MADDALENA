<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioUsuarios
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.treepatentes = New System.Windows.Forms.TreeView()
        Me.btnvolvemenu = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.NombrePerfil = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(218, 50)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox2.Size = New System.Drawing.Size(413, 21)
        Me.ComboBox2.TabIndex = 27
        '
        'treepatentes
        '
        Me.treepatentes.Location = New System.Drawing.Point(652, 23)
        Me.treepatentes.Name = "treepatentes"
        Me.treepatentes.Size = New System.Drawing.Size(308, 141)
        Me.treepatentes.TabIndex = 28
        '
        'btnvolvemenu
        '
        Me.btnvolvemenu.BackColor = System.Drawing.Color.Transparent
        Me.btnvolvemenu.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button
        Me.btnvolvemenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvolvemenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvolvemenu.FlatAppearance.BorderSize = 0
        Me.btnvolvemenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolvemenu.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolvemenu.Location = New System.Drawing.Point(218, 113)
        Me.btnvolvemenu.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnvolvemenu.Name = "btnvolvemenu"
        Me.btnvolvemenu.Size = New System.Drawing.Size(195, 51)
        Me.btnvolvemenu.TabIndex = 29
        Me.btnvolvemenu.Text = "Volver_Menu"
        Me.btnvolvemenu.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(218, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(413, 21)
        Me.ComboBox1.TabIndex = 30
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(436, 113)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(195, 51)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "Asociar_Perfil"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'NombrePerfil
        '
        Me.NombrePerfil.AutoSize = True
        Me.NombrePerfil.BackColor = System.Drawing.Color.Transparent
        Me.NombrePerfil.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombrePerfil.ForeColor = System.Drawing.SystemColors.Control
        Me.NombrePerfil.Location = New System.Drawing.Point(42, 26)
        Me.NombrePerfil.Name = "NombrePerfil"
        Me.NombrePerfil.Size = New System.Drawing.Size(75, 18)
        Me.NombrePerfil.TabIndex = 32
        Me.NombrePerfil.Text = "Perfiles"
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Usuario.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.ForeColor = System.Drawing.SystemColors.Control
        Me.Usuario.Location = New System.Drawing.Point(42, 58)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(81, 18)
        Me.Usuario.TabIndex = 33
        Me.Usuario.Text = "Usuarios"
        '
        'FormularioUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.images__1_
        Me.ClientSize = New System.Drawing.Size(1011, 182)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.NombrePerfil)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.treepatentes)
        Me.Controls.Add(Me.btnvolvemenu)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormularioUsuarios"
        Me.Text = "FormularioUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents treepatentes As System.Windows.Forms.TreeView
    Friend WithEvents btnvolvemenu As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents NombrePerfil As System.Windows.Forms.Label
    Friend WithEvents Usuario As System.Windows.Forms.Label

End Class
