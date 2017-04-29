<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPrincipal))
        Me.btnDefinirPatentes = New System.Windows.Forms.Button()
        Me.btnDefinirFamilias = New System.Windows.Forms.Button()
        Me.btnDefinirUsuarios = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnIniciarSesionComoUsuario = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.grpVistaUsuarios = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuGeneradoDinamicamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpVistaUsuarios.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDefinirPatentes
        '
        Me.btnDefinirPatentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefinirPatentes.Location = New System.Drawing.Point(383, 2)
        Me.btnDefinirPatentes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDefinirPatentes.Name = "btnDefinirPatentes"
        Me.btnDefinirPatentes.Size = New System.Drawing.Size(126, 56)
        Me.btnDefinirPatentes.TabIndex = 0
        Me.btnDefinirPatentes.Text = "Definir Patentes"
        Me.btnDefinirPatentes.UseVisualStyleBackColor = True
        '
        'btnDefinirFamilias
        '
        Me.btnDefinirFamilias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefinirFamilias.Location = New System.Drawing.Point(256, 2)
        Me.btnDefinirFamilias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDefinirFamilias.Name = "btnDefinirFamilias"
        Me.btnDefinirFamilias.Size = New System.Drawing.Size(123, 56)
        Me.btnDefinirFamilias.TabIndex = 1
        Me.btnDefinirFamilias.Text = "Definir Familias"
        Me.btnDefinirFamilias.UseVisualStyleBackColor = True
        '
        'btnDefinirUsuarios
        '
        Me.btnDefinirUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefinirUsuarios.Location = New System.Drawing.Point(129, 2)
        Me.btnDefinirUsuarios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDefinirUsuarios.Name = "btnDefinirUsuarios"
        Me.btnDefinirUsuarios.Size = New System.Drawing.Size(123, 56)
        Me.btnDefinirUsuarios.TabIndex = 2
        Me.btnDefinirUsuarios.Text = "Definir Usuarios"
        Me.btnDefinirUsuarios.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 226)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(515, 77)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel Administrador"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDefinirPatentes, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDefinirUsuarios, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDefinirFamilias, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIniciarSesionComoUsuario, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(511, 60)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btnIniciarSesionComoUsuario
        '
        Me.btnIniciarSesionComoUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIniciarSesionComoUsuario.Location = New System.Drawing.Point(2, 2)
        Me.btnIniciarSesionComoUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIniciarSesionComoUsuario.Name = "btnIniciarSesionComoUsuario"
        Me.btnIniciarSesionComoUsuario.Size = New System.Drawing.Size(123, 56)
        Me.btnIniciarSesionComoUsuario.TabIndex = 3
        Me.btnIniciarSesionComoUsuario.Text = "Iniciar Sesion Como Usuario"
        Me.btnIniciarSesionComoUsuario.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(511, 185)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 92)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aqui se generan dinamicamente los botones al iniciar sesion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(257, 2)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.TableLayoutPanel2.SetRowSpan(Me.RichTextBox1, 2)
        Me.RichTextBox1.Size = New System.Drawing.Size(252, 181)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'grpVistaUsuarios
        '
        Me.grpVistaUsuarios.Controls.Add(Me.TableLayoutPanel2)
        Me.grpVistaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpVistaUsuarios.Location = New System.Drawing.Point(0, 24)
        Me.grpVistaUsuarios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpVistaUsuarios.Name = "grpVistaUsuarios"
        Me.grpVistaUsuarios.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpVistaUsuarios.Size = New System.Drawing.Size(515, 202)
        Me.grpVistaUsuarios.TabIndex = 5
        Me.grpVistaUsuarios.TabStop = False
        Me.grpVistaUsuarios.Text = "Vista De Usuarios"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuGeneradoDinamicamenteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuGeneradoDinamicamenteToolStripMenuItem
        '
        Me.MenuGeneradoDinamicamenteToolStripMenuItem.Name = "MenuGeneradoDinamicamenteToolStripMenuItem"
        Me.MenuGeneradoDinamicamenteToolStripMenuItem.Size = New System.Drawing.Size(191, 20)
        Me.MenuGeneradoDinamicamenteToolStripMenuItem.Text = "Menu Generado Dinamicamente"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 303)
        Me.Controls.Add(Me.grpVistaUsuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormularioPrincipal"
        Me.Text = "Ejemplo Usuario Familia Patente"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.grpVistaUsuarios.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDefinirPatentes As System.Windows.Forms.Button
    Friend WithEvents btnDefinirFamilias As System.Windows.Forms.Button
    Friend WithEvents btnDefinirUsuarios As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnIniciarSesionComoUsuario As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpVistaUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuGeneradoDinamicamenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class
