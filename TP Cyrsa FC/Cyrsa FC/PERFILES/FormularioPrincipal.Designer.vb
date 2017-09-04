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
        Me.btnIniciarSesionComoUsuario = New System.Windows.Forms.Button()
        Me.btnDefinirUsuarios = New System.Windows.Forms.Button()
        Me.btnDefinirPatentes = New System.Windows.Forms.Button()
        Me.btnvolvemenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIniciarSesionComoUsuario
        '
        Me.btnIniciarSesionComoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnIniciarSesionComoUsuario.BackgroundImage = CType(resources.GetObject("btnIniciarSesionComoUsuario.BackgroundImage"), System.Drawing.Image)
        Me.btnIniciarSesionComoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIniciarSesionComoUsuario.FlatAppearance.BorderSize = 0
        Me.btnIniciarSesionComoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarSesionComoUsuario.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesionComoUsuario.Location = New System.Drawing.Point(26, 18)
        Me.btnIniciarSesionComoUsuario.Name = "btnIniciarSesionComoUsuario"
        Me.btnIniciarSesionComoUsuario.Size = New System.Drawing.Size(156, 53)
        Me.btnIniciarSesionComoUsuario.TabIndex = 0
        Me.btnIniciarSesionComoUsuario.Text = "INICIAR SESION"
        Me.btnIniciarSesionComoUsuario.UseVisualStyleBackColor = False
        '
        'btnDefinirUsuarios
        '
        Me.btnDefinirUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnDefinirUsuarios.BackgroundImage = CType(resources.GetObject("btnDefinirUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.btnDefinirUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDefinirUsuarios.FlatAppearance.BorderSize = 0
        Me.btnDefinirUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefinirUsuarios.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefinirUsuarios.Location = New System.Drawing.Point(232, 19)
        Me.btnDefinirUsuarios.Name = "btnDefinirUsuarios"
        Me.btnDefinirUsuarios.Size = New System.Drawing.Size(156, 51)
        Me.btnDefinirUsuarios.TabIndex = 1
        Me.btnDefinirUsuarios.Text = "DEFINIR USUARIOS"
        Me.btnDefinirUsuarios.UseVisualStyleBackColor = False
        '
        'btnDefinirPatentes
        '
        Me.btnDefinirPatentes.BackColor = System.Drawing.Color.Transparent
        Me.btnDefinirPatentes.BackgroundImage = CType(resources.GetObject("btnDefinirPatentes.BackgroundImage"), System.Drawing.Image)
        Me.btnDefinirPatentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDefinirPatentes.FlatAppearance.BorderSize = 0
        Me.btnDefinirPatentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefinirPatentes.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefinirPatentes.Location = New System.Drawing.Point(439, 19)
        Me.btnDefinirPatentes.Name = "btnDefinirPatentes"
        Me.btnDefinirPatentes.Size = New System.Drawing.Size(156, 51)
        Me.btnDefinirPatentes.TabIndex = 2
        Me.btnDefinirPatentes.Text = "Definir Patentes"
        Me.btnDefinirPatentes.UseVisualStyleBackColor = False
        '
        'btnvolvemenu
        '
        Me.btnvolvemenu.BackColor = System.Drawing.Color.Transparent
        Me.btnvolvemenu.BackgroundImage = CType(resources.GetObject("btnvolvemenu.BackgroundImage"), System.Drawing.Image)
        Me.btnvolvemenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvolvemenu.FlatAppearance.BorderSize = 0
        Me.btnvolvemenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvolvemenu.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolvemenu.Location = New System.Drawing.Point(633, 19)
        Me.btnvolvemenu.Name = "btnvolvemenu"
        Me.btnvolvemenu.Size = New System.Drawing.Size(156, 51)
        Me.btnvolvemenu.TabIndex = 3
        Me.btnvolvemenu.Text = "Volver Menu"
        Me.btnvolvemenu.UseVisualStyleBackColor = False
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 104)
        Me.Controls.Add(Me.btnvolvemenu)
        Me.Controls.Add(Me.btnDefinirPatentes)
        Me.Controls.Add(Me.btnDefinirUsuarios)
        Me.Controls.Add(Me.btnIniciarSesionComoUsuario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormularioPrincipal"
        Me.Text = "Panel Seguridad Perfiles - Cyrsa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIniciarSesionComoUsuario As System.Windows.Forms.Button
    Friend WithEvents btnDefinirUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnDefinirPatentes As System.Windows.Forms.Button
    Friend WithEvents btnvolvemenu As System.Windows.Forms.Button

End Class
