<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_USER
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
        Me.MenuUser = New System.Windows.Forms.MenuStrip()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDIOMASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuUser
        '
        Me.MenuUser.BackColor = System.Drawing.Color.Transparent
        Me.MenuUser.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.IDIOMASToolStripMenuItem})
        Me.MenuUser.Location = New System.Drawing.Point(0, 0)
        Me.MenuUser.Name = "MenuUser"
        Me.MenuUser.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuUser.Size = New System.Drawing.Size(486, 25)
        Me.MenuUser.TabIndex = 0
        Me.MenuUser.Text = "MenuStrip1"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(115, 19)
        Me.AToolStripMenuItem.Text = "MENU_USUARIO"
        '
        'IDIOMASToolStripMenuItem
        '
        Me.IDIOMASToolStripMenuItem.Name = "IDIOMASToolStripMenuItem"
        Me.IDIOMASToolStripMenuItem.Size = New System.Drawing.Size(73, 19)
        Me.IDIOMASToolStripMenuItem.Text = "IDIOMAS"
        '
        'MENU_USER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.cancha
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(486, 147)
        Me.Controls.Add(Me.MenuUser)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuUser
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MENU_USER"
        Me.Text = "MENU_USER"
        Me.MenuUser.ResumeLayout(False)
        Me.MenuUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuUser As System.Windows.Forms.MenuStrip
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IDIOMASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
