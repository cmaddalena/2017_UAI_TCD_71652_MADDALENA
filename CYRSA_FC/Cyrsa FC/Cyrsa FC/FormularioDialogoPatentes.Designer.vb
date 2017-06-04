<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioDialogoPatentes
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
        Me.cmbFormularios = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lnombrepatente = New System.Windows.Forms.Label()
        Me.lnombreformulario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbFormularios
        '
        Me.cmbFormularios.FormattingEnabled = True
        Me.cmbFormularios.Location = New System.Drawing.Point(140, 73)
        Me.cmbFormularios.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFormularios.Name = "cmbFormularios"
        Me.cmbFormularios.Size = New System.Drawing.Size(359, 21)
        Me.cmbFormularios.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button_background
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(211, 109)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(140, 34)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(359, 20)
        Me.txtNombre.TabIndex = 2
        '
        'lnombrepatente
        '
        Me.lnombrepatente.AutoSize = True
        Me.lnombrepatente.BackColor = System.Drawing.Color.Transparent
        Me.lnombrepatente.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnombrepatente.Location = New System.Drawing.Point(7, 34)
        Me.lnombrepatente.Name = "lnombrepatente"
        Me.lnombrepatente.Size = New System.Drawing.Size(128, 17)
        Me.lnombrepatente.TabIndex = 3
        Me.lnombrepatente.Text = "NOMBRE_PATENTE"
        '
        'lnombreformulario
        '
        Me.lnombreformulario.AutoSize = True
        Me.lnombreformulario.BackColor = System.Drawing.Color.Transparent
        Me.lnombreformulario.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnombreformulario.Location = New System.Drawing.Point(7, 77)
        Me.lnombreformulario.Name = "lnombreformulario"
        Me.lnombreformulario.Size = New System.Drawing.Size(94, 17)
        Me.lnombreformulario.TabIndex = 4
        Me.lnombreformulario.Text = "FORMULARIO"
        '
        'FormularioDialogoPatentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.cancha
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(510, 149)
        Me.Controls.Add(Me.lnombreformulario)
        Me.Controls.Add(Me.lnombrepatente)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbFormularios)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormularioDialogoPatentes"
        Me.Text = "FormularioDialogoPatentes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbFormularios As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lnombrepatente As System.Windows.Forms.Label
    Friend WithEvents lnombreformulario As System.Windows.Forms.Label
End Class
