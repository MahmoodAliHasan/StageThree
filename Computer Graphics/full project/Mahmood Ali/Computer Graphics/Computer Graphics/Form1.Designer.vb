<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrasLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExampleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiomonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pic_Drawn = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Pic_Drawn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineToolStripMenuItem, Me.ExampleToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(803, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectLineToolStripMenuItem, Me.DDAToolStripMenuItem, Me.BrasLineToolStripMenuItem})
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.LineToolStripMenuItem.Text = "Line"
        '
        'DirectLineToolStripMenuItem
        '
        Me.DirectLineToolStripMenuItem.Name = "DirectLineToolStripMenuItem"
        Me.DirectLineToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DirectLineToolStripMenuItem.Text = "Direct Line"
        '
        'DDAToolStripMenuItem
        '
        Me.DDAToolStripMenuItem.Name = "DDAToolStripMenuItem"
        Me.DDAToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DDAToolStripMenuItem.Text = "DDA"
        '
        'BrasLineToolStripMenuItem
        '
        Me.BrasLineToolStripMenuItem.Name = "BrasLineToolStripMenuItem"
        Me.BrasLineToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BrasLineToolStripMenuItem.Text = "Bras Line"
        '
        'ExampleToolStripMenuItem
        '
        Me.ExampleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HouseToolStripMenuItem, Me.DiomonsToolStripMenuItem})
        Me.ExampleToolStripMenuItem.Name = "ExampleToolStripMenuItem"
        Me.ExampleToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ExampleToolStripMenuItem.Text = "Example"
        '
        'HouseToolStripMenuItem
        '
        Me.HouseToolStripMenuItem.Name = "HouseToolStripMenuItem"
        Me.HouseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HouseToolStripMenuItem.Text = "House"
        '
        'DiomonsToolStripMenuItem
        '
        Me.DiomonsToolStripMenuItem.Name = "DiomonsToolStripMenuItem"
        Me.DiomonsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DiomonsToolStripMenuItem.Text = "Diamonds"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.CloseToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Pic_Drawn
        '
        Me.Pic_Drawn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pic_Drawn.Location = New System.Drawing.Point(0, 27)
        Me.Pic_Drawn.Name = "Pic_Drawn"
        Me.Pic_Drawn.Size = New System.Drawing.Size(800, 400)
        Me.Pic_Drawn.TabIndex = 1
        Me.Pic_Drawn.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 431)
        Me.Controls.Add(Me.Pic_Drawn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Pic_Drawn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrasLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pic_Drawn As PictureBox
    Friend WithEvents ExampleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HouseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiomonsToolStripMenuItem As ToolStripMenuItem
End Class
