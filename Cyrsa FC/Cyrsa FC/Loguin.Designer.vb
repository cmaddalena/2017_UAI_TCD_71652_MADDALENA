<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loguin
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
        Me.LoginUser = New System.Windows.Forms.TextBox()
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LPassword = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LoginUser
        '
        Me.LoginUser.Location = New System.Drawing.Point(103, 26)
        Me.LoginUser.Name = "LoginUser"
        Me.LoginUser.Size = New System.Drawing.Size(244, 20)
        Me.LoginUser.TabIndex = 0
        '
        'LoginPassword
        '
        Me.LoginPassword.Location = New System.Drawing.Point(103, 66)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.Size = New System.Drawing.Size(244, 20)
        Me.LoginPassword.TabIndex = 1
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(27, 26)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LUsuario.TabIndex = 2
        Me.LUsuario.Text = "Usuario"
        '
        'LPassword
        '
        Me.LPassword.AutoSize = True
        Me.LPassword.Location = New System.Drawing.Point(27, 69)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(34, 13)
        Me.LPassword.TabIndex = 3
        Me.LPassword.Text = "Clave"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Loguear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(385, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(289, 134)
        Me.ListBox1.TabIndex = 5
        '
        'Loguin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 168)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LPassword)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.LoginPassword)
        Me.Controls.Add(Me.LoginUser)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Loguin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginUser As System.Windows.Forms.TextBox
    Friend WithEvents LoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents LUsuario As System.Windows.Forms.Label
    Friend WithEvents LPassword As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
