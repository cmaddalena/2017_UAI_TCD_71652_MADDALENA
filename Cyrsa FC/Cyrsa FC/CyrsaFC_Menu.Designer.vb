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
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AYUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LEEMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem, Me.AYUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(950, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GESTIONESCUELAToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ARCHIVOToolStripMenuItem.Text = "ARCHIVO"
        '
        'GESTIONESCUELAToolStripMenuItem
        '
        Me.GESTIONESCUELAToolStripMenuItem.Name = "GESTIONESCUELAToolStripMenuItem"
        Me.GESTIONESCUELAToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GESTIONESCUELAToolStripMenuItem.Text = "LOGIN"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'AYUDAToolStripMenuItem
        '
        Me.AYUDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LEEMEToolStripMenuItem})
        Me.AYUDAToolStripMenuItem.Name = "AYUDAToolStripMenuItem"
        Me.AYUDAToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AYUDAToolStripMenuItem.Text = "AYUDA"
        '
        'LEEMEToolStripMenuItem
        '
        Me.LEEMEToolStripMenuItem.Name = "LEEMEToolStripMenuItem"
        Me.LEEMEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LEEMEToolStripMenuItem.Text = "LEEME"
        '
        'CyrsaFC_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cyrsa_FC.My.Resources.Resources.pelota
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 577)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AYUDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LEEMEToolStripMenuItem As ToolStripMenuItem
End Class
