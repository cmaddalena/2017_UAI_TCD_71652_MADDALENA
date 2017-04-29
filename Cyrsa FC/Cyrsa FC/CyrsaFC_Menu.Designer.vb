<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CyrsaFC_Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GESTIONESCUELAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALTASOCIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GESTIONESCUELAToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ARCHIVOToolStripMenuItem.Text = "ARCHIVO"
        '
        'GESTIONESCUELAToolStripMenuItem
        '
        Me.GESTIONESCUELAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALTASOCIOToolStripMenuItem})
        Me.GESTIONESCUELAToolStripMenuItem.Name = "GESTIONESCUELAToolStripMenuItem"
        Me.GESTIONESCUELAToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.GESTIONESCUELAToolStripMenuItem.Text = "GESTION_ESCUELA"
        '
        'ALTASOCIOToolStripMenuItem
        '
        Me.ALTASOCIOToolStripMenuItem.Name = "ALTASOCIOToolStripMenuItem"
        Me.ALTASOCIOToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ALTASOCIOToolStripMenuItem.Text = "ALTA_SOCIO"
        '
        'CyrsaFC_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.pelota
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(633, 375)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CyrsaFC_Menu"
        Me.Text = "CyrsaFC_Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GESTIONESCUELAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALTASOCIOToolStripMenuItem As ToolStripMenuItem
End Class
