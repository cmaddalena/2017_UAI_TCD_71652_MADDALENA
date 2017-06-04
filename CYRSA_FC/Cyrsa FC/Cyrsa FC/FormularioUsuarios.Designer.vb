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
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNombreFamilia = New System.Windows.Forms.Label()
        Me.lblTituloPatentes = New System.Windows.Forms.Label()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.treepatentes = New System.Windows.Forms.TreeView()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.cancha
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.lblNombreFamilia, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.lblTituloPatentes, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.comboBox1, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.ComboBox2, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.treepatentes, 0, 3)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 4
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(674, 267)
        Me.tableLayoutPanel1.TabIndex = 2
        '
        'lblNombreFamilia
        '
        Me.lblNombreFamilia.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreFamilia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombreFamilia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNombreFamilia.Location = New System.Drawing.Point(2, 0)
        Me.lblNombreFamilia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreFamilia.Name = "lblNombreFamilia"
        Me.lblNombreFamilia.Size = New System.Drawing.Size(283, 31)
        Me.lblNombreFamilia.TabIndex = 0
        Me.lblNombreFamilia.Text = "Nombre :"
        Me.lblNombreFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTituloPatentes
        '
        Me.lblTituloPatentes.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloPatentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTituloPatentes.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblTituloPatentes.Location = New System.Drawing.Point(2, 31)
        Me.lblTituloPatentes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloPatentes.Name = "lblTituloPatentes"
        Me.lblTituloPatentes.Size = New System.Drawing.Size(283, 38)
        Me.lblTituloPatentes.TabIndex = 1
        Me.lblTituloPatentes.Text = "Familia :"
        Me.lblTituloPatentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel1.SetColumnSpan(Me.tableLayoutPanel2, 2)
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.btnCancelar, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnAceptar, 0, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(2, 71)
        Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(667, 38)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button_background
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(335, 2)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCancelar.Size = New System.Drawing.Size(330, 34)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button_background
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(2, 2)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(329, 34)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(289, 33)
        Me.comboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.comboBox1.Size = New System.Drawing.Size(380, 25)
        Me.comboBox1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(290, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox2.Size = New System.Drawing.Size(377, 25)
        Me.ComboBox2.TabIndex = 7
        '
        'treepatentes
        '
        Me.treepatentes.Location = New System.Drawing.Point(3, 114)
        Me.treepatentes.Name = "treepatentes"
        Me.treepatentes.Size = New System.Drawing.Size(272, 141)
        Me.treepatentes.TabIndex = 8
        '
        'FormularioUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 267)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormularioUsuarios"
        Me.Text = "FormularioUsuarios"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblTituloPatentes As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents lblNombreFamilia As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents treepatentes As System.Windows.Forms.TreeView

End Class
