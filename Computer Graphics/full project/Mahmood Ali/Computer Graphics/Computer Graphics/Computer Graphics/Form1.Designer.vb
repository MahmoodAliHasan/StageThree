<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    ' Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrasLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CirculeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BresenhamCirculeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExampleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiomonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Question1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Question2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pic_Drawn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCurrentLocation = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Pic_Drawn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineToolStripMenuItem, Me.CirculeToolStripMenuItem, Me.ExampleToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExamToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 61)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(803, 41)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectLineToolStripMenuItem, Me.DDAToolStripMenuItem, Me.BrasLineToolStripMenuItem})
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(41, 37)
        Me.LineToolStripMenuItem.Text = "Line"
        '
        'DirectLineToolStripMenuItem
        '
        Me.DirectLineToolStripMenuItem.Name = "DirectLineToolStripMenuItem"
        Me.DirectLineToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DirectLineToolStripMenuItem.Text = "Direct Line"
        '
        'DDAToolStripMenuItem
        '
        Me.DDAToolStripMenuItem.Name = "DDAToolStripMenuItem"
        Me.DDAToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DDAToolStripMenuItem.Text = "DDA"
        '
        'BrasLineToolStripMenuItem
        '
        Me.BrasLineToolStripMenuItem.Name = "BrasLineToolStripMenuItem"
        Me.BrasLineToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BrasLineToolStripMenuItem.Text = "Bras Line"
        '
        'CirculeToolStripMenuItem
        '
        Me.CirculeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BresenhamCirculeToolStripMenuItem})
        Me.CirculeToolStripMenuItem.Name = "CirculeToolStripMenuItem"
        Me.CirculeToolStripMenuItem.Size = New System.Drawing.Size(56, 37)
        Me.CirculeToolStripMenuItem.Text = "Circule"
        '
        'BresenhamCirculeToolStripMenuItem
        '
        Me.BresenhamCirculeToolStripMenuItem.Name = "BresenhamCirculeToolStripMenuItem"
        Me.BresenhamCirculeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.BresenhamCirculeToolStripMenuItem.Text = "Bresenham Circule"
        '
        'ExampleToolStripMenuItem
        '
        Me.ExampleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HouseToolStripMenuItem, Me.DiomonsToolStripMenuItem})
        Me.ExampleToolStripMenuItem.Name = "ExampleToolStripMenuItem"
        Me.ExampleToolStripMenuItem.Size = New System.Drawing.Size(63, 37)
        Me.ExampleToolStripMenuItem.Text = "Example"
        '
        'HouseToolStripMenuItem
        '
        Me.HouseToolStripMenuItem.Name = "HouseToolStripMenuItem"
        Me.HouseToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.HouseToolStripMenuItem.Text = "House"
        '
        'DiomonsToolStripMenuItem
        '
        Me.DiomonsToolStripMenuItem.Name = "DiomonsToolStripMenuItem"
        Me.DiomonsToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DiomonsToolStripMenuItem.Text = "Diamonds"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(46, 37)
        Me.CloseToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 37)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Question1ToolStripMenuItem, Me.Question2ToolStripMenuItem})
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(47, 37)
        Me.ExamToolStripMenuItem.Text = "Exam"
        '
        'Question1ToolStripMenuItem
        '
        Me.Question1ToolStripMenuItem.Name = "Question1ToolStripMenuItem"
        Me.Question1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Question1ToolStripMenuItem.Text = "Question 1"
        '
        'Question2ToolStripMenuItem
        '
        Me.Question2ToolStripMenuItem.Name = "Question2ToolStripMenuItem"
        Me.Question2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Question2ToolStripMenuItem.Text = "Question 2"
        '
        'Pic_Drawn
        '
        Me.Pic_Drawn.BackColor = System.Drawing.Color.Black
        Me.Pic_Drawn.Location = New System.Drawing.Point(0, 99)
        Me.Pic_Drawn.Name = "Pic_Drawn"
        Me.Pic_Drawn.Size = New System.Drawing.Size(803, 349)
        Me.Pic_Drawn.TabIndex = 1
        Me.Pic_Drawn.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCurrentLocation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 445)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 28)
        Me.Panel1.TabIndex = 3
        '
        'lblCurrentLocation
        '
        Me.lblCurrentLocation.AutoSize = True
        Me.lblCurrentLocation.Location = New System.Drawing.Point(12, 6)
        Me.lblCurrentLocation.Name = "lblCurrentLocation"
        Me.lblCurrentLocation.Size = New System.Drawing.Size(38, 13)
        Me.lblCurrentLocation.TabIndex = 0
        Me.lblCurrentLocation.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pic_Drawn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Pic_Drawn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents CirculeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BresenhamCirculeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCurrentLocation As Label
    Friend WithEvents ExamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Question1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Question2ToolStripMenuItem As ToolStripMenuItem
End Class
