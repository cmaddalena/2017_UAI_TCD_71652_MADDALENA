<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loguin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loguin))
        Me.LoginUser = New System.Windows.Forms.TextBox()
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LPassword = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginUser
        '
        Me.LoginUser.Location = New System.Drawing.Point(188, 40)
        Me.LoginUser.Margin = New System.Windows.Forms.Padding(5)
        Me.LoginUser.Name = "LoginUser"
        Me.LoginUser.Size = New System.Drawing.Size(444, 27)
        Me.LoginUser.TabIndex = 0
        '
        'LoginPassword
        '
        Me.LoginPassword.Location = New System.Drawing.Point(188, 102)
        Me.LoginPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPassword.Size = New System.Drawing.Size(444, 27)
        Me.LoginPassword.TabIndex = 1
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LUsuario.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.ForeColor = System.Drawing.Color.Black
        Me.LUsuario.Location = New System.Drawing.Point(351, 13)
        Me.LUsuario.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(79, 20)
        Me.LUsuario.TabIndex = 2
        Me.LUsuario.Text = "Usuario"
        '
        'LPassword
        '
        Me.LPassword.AutoSize = True
        Me.LPassword.BackColor = System.Drawing.Color.Transparent
        Me.LPassword.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPassword.ForeColor = System.Drawing.Color.Black
        Me.LPassword.Location = New System.Drawing.Point(357, 77)
        Me.LPassword.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(57, 20)
        Me.LPassword.TabIndex = 3
        Me.LPassword.Text = "Clave"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.button
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(276, 157)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Loguear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(665, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Loguin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(846, 200)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LPassword)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.LoginPassword)
        Me.Controls.Add(Me.LoginUser)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Loguin"
        Me.Text = "Login_CYRSA-FC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginUser As System.Windows.Forms.TextBox
    Friend WithEvents LoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents LUsuario As System.Windows.Forms.Label
    Friend WithEvents LPassword As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
