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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxX1 = New System.Windows.Forms.TextBox()
        Me.TextBoxX2 = New System.Windows.Forms.TextBox()
        Me.TextBoxY1 = New System.Windows.Forms.TextBox()
        Me.TextBoxY2 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Labelx = New System.Windows.Forms.Label()
        Me.Labely = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BresenhumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamplesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeWorksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 213)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBoxX1
        '
        Me.TextBoxX1.Location = New System.Drawing.Point(12, 51)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxX1.TabIndex = 1
        '
        'TextBoxX2
        '
        Me.TextBoxX2.Location = New System.Drawing.Point(130, 51)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxX2.TabIndex = 2
        '
        'TextBoxY1
        '
        Me.TextBoxY1.Location = New System.Drawing.Point(12, 91)
        Me.TextBoxY1.Name = "TextBoxY1"
        Me.TextBoxY1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxY1.TabIndex = 3
        '
        'TextBoxY2
        '
        Me.TextBoxY2.Location = New System.Drawing.Point(130, 91)
        Me.TextBoxY2.Name = "TextBoxY2"
        Me.TextBoxY2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxY2.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "x1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "x2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "y1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "y2"
        '
        'Labelx
        '
        Me.Labelx.AutoSize = True
        Me.Labelx.Location = New System.Drawing.Point(278, 51)
        Me.Labelx.Name = "Labelx"
        Me.Labelx.Size = New System.Drawing.Size(38, 13)
        Me.Labelx.TabIndex = 13
        Me.Labelx.Text = "Label5"
        '
        'Labely
        '
        Me.Labely.AutoSize = True
        Me.Labely.Location = New System.Drawing.Point(281, 91)
        Me.Labely.Name = "Labely"
        Me.Labely.Size = New System.Drawing.Size(38, 13)
        Me.Labely.TabIndex = 14
        Me.Labely.Text = "Labely"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineToolStripMenuItem, Me.ExamplesToolStripMenuItem, Me.HomeWorksToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(425, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectToolStripMenuItem, Me.DDAToolStripMenuItem, Me.BresenhumToolStripMenuItem})
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.LineToolStripMenuItem.Text = "Line"
        '
        'DirectToolStripMenuItem
        '
        Me.DirectToolStripMenuItem.Name = "DirectToolStripMenuItem"
        Me.DirectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DirectToolStripMenuItem.Text = "Direct "
        '
        'DDAToolStripMenuItem
        '
        Me.DDAToolStripMenuItem.Name = "DDAToolStripMenuItem"
        Me.DDAToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DDAToolStripMenuItem.Text = "DDA"
        '
        'BresenhumToolStripMenuItem
        '
        Me.BresenhumToolStripMenuItem.Name = "BresenhumToolStripMenuItem"
        Me.BresenhumToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BresenhumToolStripMenuItem.Text = "Bresenhum"
        '
        'ExamplesToolStripMenuItem
        '
        Me.ExamplesToolStripMenuItem.Name = "ExamplesToolStripMenuItem"
        Me.ExamplesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ExamplesToolStripMenuItem.Text = "Examples"
        '
        'HomeWorksToolStripMenuItem
        '
        Me.HomeWorksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HouseToolStripMenuItem})
        Me.HomeWorksToolStripMenuItem.Name = "HomeWorksToolStripMenuItem"
        Me.HomeWorksToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.HomeWorksToolStripMenuItem.Text = "Home Works"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HouseToolStripMenuItem
        '
        Me.HouseToolStripMenuItem.Name = "HouseToolStripMenuItem"
        Me.HouseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HouseToolStripMenuItem.Text = "House"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(322, 34)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(90, 95)
        Me.ListBox1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 378)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Labely)
        Me.Controls.Add(Me.Labelx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxY2)
        Me.Controls.Add(Me.TextBoxY1)
        Me.Controls.Add(Me.TextBoxX2)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxX1 As TextBox
    Friend WithEvents TextBoxX2 As TextBox
    Friend WithEvents TextBoxY1 As TextBox
    Friend WithEvents TextBoxY2 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Labelx As Label
    Friend WithEvents Labely As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BresenhumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExamplesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeWorksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HouseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
End Class
