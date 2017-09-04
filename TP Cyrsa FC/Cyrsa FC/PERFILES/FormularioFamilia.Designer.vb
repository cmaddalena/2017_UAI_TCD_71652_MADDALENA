<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioFamilia))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNombreFamilia = New System.Windows.Forms.Label()
        Me.lblTituloPatentes = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Familia = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.treePatentes = New System.Windows.Forms.TreeView()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnvolvermenu = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.lblNombreFamilia, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.lblTituloPatentes, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.txtNombre, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.treePatentes, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 3)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 4
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(654, 388)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'lblNombreFamilia
        '
        Me.lblNombreFamilia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombreFamilia.Location = New System.Drawing.Point(3, 64)
        Me.lblNombreFamilia.Name = "lblNombreFamilia"
        Me.lblNombreFamilia.Size = New System.Drawing.Size(98, 31)
        Me.lblNombreFamilia.TabIndex = 0
        Me.lblNombreFamilia.Text = "Nombre :"
        Me.lblNombreFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTituloPatentes
        '
        Me.lblTituloPatentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTituloPatentes.Location = New System.Drawing.Point(3, 95)
        Me.lblTituloPatentes.Name = "lblTituloPatentes"
        Me.lblTituloPatentes.Size = New System.Drawing.Size(98, 229)
        Me.lblTituloPatentes.TabIndex = 1
        Me.lblTituloPatentes.Text = "Patentes :"
        Me.lblTituloPatentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tableLayoutPanel1.SetColumnSpan(Me.panel1, 2)
        Me.panel1.Controls.Add(Me.Familia)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(648, 58)
        Me.panel1.TabIndex = 2
        '
        'Familia
        '
        Me.Familia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Familia.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Familia.Location = New System.Drawing.Point(0, 0)
        Me.Familia.Name = "Familia"
        Me.Familia.Size = New System.Drawing.Size(648, 58)
        Me.Familia.TabIndex = 0
        Me.Familia.Text = "Datos de la Familia"
        Me.Familia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Location = New System.Drawing.Point(107, 67)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(544, 24)
        Me.txtNombre.TabIndex = 3
        '
        'treePatentes
        '
        Me.treePatentes.CheckBoxes = True
        Me.treePatentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treePatentes.Location = New System.Drawing.Point(107, 98)
        Me.treePatentes.Name = "treePatentes"
        Me.treePatentes.Size = New System.Drawing.Size(544, 223)
        Me.treePatentes.TabIndex = 4
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 3
        Me.tableLayoutPanel1.SetColumnSpan(Me.tableLayoutPanel2, 2)
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel2.Controls.Add(Me.btncancelar, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnvolvermenu, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnAceptar, 0, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 327)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(648, 58)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImage = CType(resources.GetObject("btncancelar.BackgroundImage"), System.Drawing.Image)
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Location = New System.Drawing.Point(219, 3)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(210, 52)
        Me.btncancelar.TabIndex = 2
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnvolvermenu
        '
        Me.btnvolvermenu.BackgroundImage = CType(resources.GetObject("btnvolvermenu.BackgroundImage"), System.Drawing.Image)
        Me.btnvolvermenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvolvermenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvolvermenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnvolvermenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolvermenu.Location = New System.Drawing.Point(435, 3)
        Me.btnvolvermenu.Name = "btnvolvermenu"
        Me.btnvolvermenu.Size = New System.Drawing.Size(210, 52)
        Me.btnvolvermenu.TabIndex = 0
        Me.btnvolvermenu.Text = "Volver Menu"
        Me.btnvolvermenu.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(210, 52)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FormularioFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(654, 388)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormularioFamilia"
        Me.Text = "FormularioFamilia"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblNombreFamilia As System.Windows.Forms.Label
    Private WithEvents lblTituloPatentes As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents Familia As System.Windows.Forms.Label
    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents treePatentes As System.Windows.Forms.TreeView
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents btnvolvermenu As System.Windows.Forms.Button
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Private WithEvents btncancelar As System.Windows.Forms.Button
End Class
