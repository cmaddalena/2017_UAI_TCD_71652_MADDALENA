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
        Me.btnDefinirUsuarios = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnIniciarSesionComoUsuario = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpVistaUsuarios = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpVistaUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDefinirPatentes
        '
        Me.btnDefinirPatentes.BackgroundImage = CType(resources.GetObject("btnDefinirPatentes.BackgroundImage"), System.Drawing.Image)
        Me.btnDefinirPatentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDefinirPatentes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDefinirPatentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefinirPatentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefinirPatentes.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefinirPatentes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDefinirPatentes.Location = New System.Drawing.Point(467, 3)
        Me.btnDefinirPatentes.Name = "btnDefinirPatentes"
        Me.btnDefinirPatentes.Size = New System.Drawing.Size(227, 42)
        Me.btnDefinirPatentes.TabIndex = 0
        Me.btnDefinirPatentes.Text = "Definir Perfiles"
        Me.btnDefinirPatentes.UseVisualStyleBackColor = True
        '
        'btnDefinirUsuarios
        '
        Me.btnDefinirUsuarios.BackgroundImage = CType(resources.GetObject("btnDefinirUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.btnDefinirUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDefinirUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDefinirUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDefinirUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefinirUsuarios.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefinirUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDefinirUsuarios.Location = New System.Drawing.Point(235, 3)
        Me.btnDefinirUsuarios.Name = "btnDefinirUsuarios"
        Me.btnDefinirUsuarios.Size = New System.Drawing.Size(226, 42)
        Me.btnDefinirUsuarios.TabIndex = 2
        Me.btnDefinirUsuarios.Text = "Asignar Familia a Usuario"
        Me.btnDefinirUsuarios.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 74)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel Administrador"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDefinirPatentes, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDefinirUsuarios, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIniciarSesionComoUsuario, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(697, 48)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btnIniciarSesionComoUsuario
        '
        Me.btnIniciarSesionComoUsuario.BackgroundImage = CType(resources.GetObject("btnIniciarSesionComoUsuario.BackgroundImage"), System.Drawing.Image)
        Me.btnIniciarSesionComoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIniciarSesionComoUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciarSesionComoUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIniciarSesionComoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarSesionComoUsuario.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesionComoUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIniciarSesionComoUsuario.Location = New System.Drawing.Point(3, 3)
        Me.btnIniciarSesionComoUsuario.Name = "btnIniciarSesionComoUsuario"
        Me.btnIniciarSesionComoUsuario.Size = New System.Drawing.Size(226, 42)
        Me.btnIniciarSesionComoUsuario.TabIndex = 3
        Me.btnIniciarSesionComoUsuario.Text = "Iniciar Sesion Como Usuario"
        Me.btnIniciarSesionComoUsuario.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 22)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(697, 0)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'grpVistaUsuarios
        '
        Me.grpVistaUsuarios.Controls.Add(Me.TableLayoutPanel2)
        Me.grpVistaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpVistaUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.grpVistaUsuarios.Name = "grpVistaUsuarios"
        Me.grpVistaUsuarios.Size = New System.Drawing.Size(703, 5)
        Me.grpVistaUsuarios.TabIndex = 5
        Me.grpVistaUsuarios.TabStop = False
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(703, 79)
        Me.Controls.Add(Me.grpVistaUsuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormularioPrincipal"
        Me.Text = "Panel Seguridad Perfiles - Cyrsa"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpVistaUsuarios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDefinirPatentes As System.Windows.Forms.Button
    Friend WithEvents btnDefinirUsuarios As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnIniciarSesionComoUsuario As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpVistaUsuarios As System.Windows.Forms.GroupBox

End Class
