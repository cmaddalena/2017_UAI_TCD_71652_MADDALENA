<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPatentes
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
        Me.components = New System.ComponentModel.Container()
        Me.treePatentes = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarGruposDePatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarElementoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Familia = New System.Windows.Forms.Label()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'treePatentes
        '
        Me.tableLayoutPanel1.SetColumnSpan(Me.treePatentes, 2)
        Me.treePatentes.ContextMenuStrip = Me.ContextMenuStrip
        Me.treePatentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treePatentes.Location = New System.Drawing.Point(2, 51)
        Me.treePatentes.Margin = New System.Windows.Forms.Padding(2)
        Me.treePatentes.Name = "treePatentes"
        Me.treePatentes.Size = New System.Drawing.Size(420, 147)
        Me.treePatentes.TabIndex = 4
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarGruposDePatenteToolStripMenuItem, Me.AgregarPatenteToolStripMenuItem, Me.EliminarElementoToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(227, 70)
        '
        'AgregarGruposDePatenteToolStripMenuItem
        '
        Me.AgregarGruposDePatenteToolStripMenuItem.Name = "AgregarGruposDePatenteToolStripMenuItem"
        Me.AgregarGruposDePatenteToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AgregarGruposDePatenteToolStripMenuItem.Text = "Agregar Grupos De Patente..."
        '
        'AgregarPatenteToolStripMenuItem
        '
        Me.AgregarPatenteToolStripMenuItem.Name = "AgregarPatenteToolStripMenuItem"
        Me.AgregarPatenteToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AgregarPatenteToolStripMenuItem.Text = "Agregar Patente..."
        '
        'EliminarElementoToolStripMenuItem
        '
        Me.EliminarElementoToolStripMenuItem.Name = "EliminarElementoToolStripMenuItem"
        Me.EliminarElementoToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.EliminarElementoToolStripMenuItem.Text = "Eliminar Elemento..."
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.treePatentes, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 2)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(424, 249)
        Me.tableLayoutPanel1.TabIndex = 2
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tableLayoutPanel1.SetColumnSpan(Me.panel1, 2)
        Me.panel1.Controls.Add(Me.Familia)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(2, 2)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(420, 45)
        Me.panel1.TabIndex = 2
        '
        'Familia
        '
        Me.Familia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Familia.Location = New System.Drawing.Point(0, 0)
        Me.Familia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Familia.Name = "Familia"
        Me.Familia.Size = New System.Drawing.Size(420, 45)
        Me.Familia.TabIndex = 0
        Me.Familia.Text = "PATENTES - CYRSAFC"
        Me.Familia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(2, 202)
        Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(420, 45)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelar.Location = New System.Drawing.Point(212, 2)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(206, 41)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAceptar.Location = New System.Drawing.Point(2, 2)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(206, 41)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FormularioPatentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 249)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormularioPatentes"
        Me.Text = "FormularioPatentes"
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents treePatentes As System.Windows.Forms.TreeView
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents Familia As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarGruposDePatenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarPatenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarElementoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
