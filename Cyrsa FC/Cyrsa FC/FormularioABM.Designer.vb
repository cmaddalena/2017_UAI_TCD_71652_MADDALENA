﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioABM
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.tableDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Familia = New System.Windows.Forms.Label()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.tableDatos.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModificar.Location = New System.Drawing.Point(161, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 48)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'tableDatos
        '
        Me.tableDatos.ColumnCount = 2
        Me.tableDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tableDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableDatos.Controls.Add(Me.panel1, 0, 0)
        Me.tableDatos.Controls.Add(Me.tableLayoutPanel2, 0, 2)
        Me.tableDatos.Controls.Add(Me.DataGridView1, 0, 1)
        Me.tableDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableDatos.Location = New System.Drawing.Point(0, 0)
        Me.tableDatos.Name = "tableDatos"
        Me.tableDatos.RowCount = 3
        Me.tableDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableDatos.Size = New System.Drawing.Size(640, 311)
        Me.tableDatos.TabIndex = 2
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tableDatos.SetColumnSpan(Me.panel1, 2)
        Me.panel1.Controls.Add(Me.Familia)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(634, 54)
        Me.panel1.TabIndex = 2
        '
        'Familia
        '
        Me.Familia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Familia.Location = New System.Drawing.Point(0, 0)
        Me.Familia.Name = "Familia"
        Me.Familia.Size = New System.Drawing.Size(634, 54)
        Me.Familia.TabIndex = 0
        Me.Familia.Text = "ABM <ENTIDAD>"
        Me.Familia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 4
        Me.tableDatos.SetColumnSpan(Me.tableLayoutPanel2, 2)
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.btnModificar, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnAgregar, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnEliminar, 2, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnVolver, 3, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 254)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(634, 54)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregar.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(152, 48)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableDatos.SetColumnSpan(Me.DataGridView1, 2)
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(634, 185)
        Me.DataGridView1.TabIndex = 6
        '
        'btnEliminar
        '
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEliminar.Location = New System.Drawing.Point(319, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 48)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVolver.Location = New System.Drawing.Point(477, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(154, 48)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FormularioABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 311)
        Me.Controls.Add(Me.tableDatos)
        Me.Name = "FormularioABM"
        Me.Text = "FormularioABM"
        Me.tableDatos.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnModificar As System.Windows.Forms.Button
    Private WithEvents tableDatos As System.Windows.Forms.TableLayoutPanel
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents Familia As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
