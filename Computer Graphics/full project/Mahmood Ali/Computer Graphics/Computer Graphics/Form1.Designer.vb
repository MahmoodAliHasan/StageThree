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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAlgorthemSelected = New System.Windows.Forms.Label()
        Me.lblCurrentLocation = New System.Windows.Forms.Label()
        Me.Line_ContextMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.LineDirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifferentDigalLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BresenhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Line_ContentMenuStrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.DirectLineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifferentDigitalLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BresenhamLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeWork_ContextMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.HouseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiamondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exam_ContextMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.QuizToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Circle_ContexMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.BresenhamCircleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Polygon_ContextMenu = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.PolarPolygonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomPolygonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Circle_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Elllipse_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pic_Drawn = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Line_ContextMenu.SuspendLayout()
        Me.Line_ContentMenuStrip.SuspendLayout()
        Me.HomeWork_ContextMenu.SuspendLayout()
        Me.Exam_ContextMenu.SuspendLayout()
        Me.Circle_ContexMenu.SuspendLayout()
        Me.Polygon_ContextMenu.SuspendLayout()
        Me.MainMenuStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Drawn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblAlgorthemSelected)
        Me.Panel1.Controls.Add(Me.lblCurrentLocation)
        Me.Panel1.Location = New System.Drawing.Point(0, 554)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 46)
        Me.Panel1.TabIndex = 3
        '
        'lblAlgorthemSelected
        '
        Me.lblAlgorthemSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlgorthemSelected.AutoSize = True
        Me.lblAlgorthemSelected.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblAlgorthemSelected.ForeColor = System.Drawing.Color.White
        Me.lblAlgorthemSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAlgorthemSelected.Location = New System.Drawing.Point(169, 16)
        Me.lblAlgorthemSelected.Name = "lblAlgorthemSelected"
        Me.lblAlgorthemSelected.Size = New System.Drawing.Size(230, 15)
        Me.lblAlgorthemSelected.TabIndex = 1
        Me.lblAlgorthemSelected.Text = "Algorthem Selected : lajfld  jfldsjf djdlfjs"
        Me.lblAlgorthemSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentLocation
        '
        Me.lblCurrentLocation.AutoSize = True
        Me.lblCurrentLocation.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblCurrentLocation.ForeColor = System.Drawing.Color.White
        Me.lblCurrentLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCurrentLocation.Location = New System.Drawing.Point(43, 17)
        Me.lblCurrentLocation.Name = "lblCurrentLocation"
        Me.lblCurrentLocation.Size = New System.Drawing.Size(43, 15)
        Me.lblCurrentLocation.TabIndex = 0
        Me.lblCurrentLocation.Text = "0 ,0 px"
        '
        'Line_ContextMenu
        '
        Me.Line_ContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Line_ContextMenu.Depth = 0
        Me.Line_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineDirectToolStripMenuItem, Me.DifferentDigalLineToolStripMenuItem, Me.BresenhamToolStripMenuItem})
        Me.Line_ContextMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.Line_ContextMenu.Name = "MaterialContextMenuStrip1"
        Me.Line_ContextMenu.Size = New System.Drawing.Size(177, 70)
        '
        'LineDirectToolStripMenuItem
        '
        Me.LineDirectToolStripMenuItem.Name = "LineDirectToolStripMenuItem"
        Me.LineDirectToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LineDirectToolStripMenuItem.Text = "Direct"
        '
        'DifferentDigalLineToolStripMenuItem
        '
        Me.DifferentDigalLineToolStripMenuItem.Name = "DifferentDigalLineToolStripMenuItem"
        Me.DifferentDigalLineToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DifferentDigalLineToolStripMenuItem.Text = "Different DigtalLine"
        '
        'BresenhamToolStripMenuItem
        '
        Me.BresenhamToolStripMenuItem.Name = "BresenhamToolStripMenuItem"
        Me.BresenhamToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.BresenhamToolStripMenuItem.Text = "Bresenham "
        '
        'Line_ContentMenuStrip
        '
        Me.Line_ContentMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Line_ContentMenuStrip.Depth = 0
        Me.Line_ContentMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectLineToolStripMenuItem1, Me.DifferentDigitalLineToolStripMenuItem, Me.BresenhamLineToolStripMenuItem})
        Me.Line_ContentMenuStrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.Line_ContentMenuStrip.Name = "Linw_ContentMenuStrip"
        Me.Line_ContentMenuStrip.OwnerItem = Me.ToolStripMenuItem10
        Me.Line_ContentMenuStrip.Size = New System.Drawing.Size(183, 70)
        '
        'DirectLineToolStripMenuItem1
        '
        Me.DirectLineToolStripMenuItem1.Name = "DirectLineToolStripMenuItem1"
        Me.DirectLineToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.DirectLineToolStripMenuItem1.Text = "Direct Line"
        '
        'DifferentDigitalLineToolStripMenuItem
        '
        Me.DifferentDigitalLineToolStripMenuItem.Name = "DifferentDigitalLineToolStripMenuItem"
        Me.DifferentDigitalLineToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DifferentDigitalLineToolStripMenuItem.Text = "Different Digital Line"
        '
        'BresenhamLineToolStripMenuItem
        '
        Me.BresenhamLineToolStripMenuItem.Name = "BresenhamLineToolStripMenuItem"
        Me.BresenhamLineToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BresenhamLineToolStripMenuItem.Text = "Bresenham Line"
        '
        'HomeWork_ContextMenu
        '
        Me.HomeWork_ContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HomeWork_ContextMenu.Depth = 0
        Me.HomeWork_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HouseToolStripMenuItem1, Me.DiamondToolStripMenuItem, Me.FanToolStripMenuItem, Me.TreeToolStripMenuItem1, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.HomeWork_ContextMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.HomeWork_ContextMenu.Name = "HomeWork_ContextMenu"
        Me.HomeWork_ContextMenu.OwnerItem = Me.ToolStripMenuItem8
        Me.HomeWork_ContextMenu.Size = New System.Drawing.Size(124, 136)
        '
        'HouseToolStripMenuItem1
        '
        Me.HouseToolStripMenuItem1.Name = "HouseToolStripMenuItem1"
        Me.HouseToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.HouseToolStripMenuItem1.Text = "House"
        '
        'DiamondToolStripMenuItem
        '
        Me.DiamondToolStripMenuItem.Name = "DiamondToolStripMenuItem"
        Me.DiamondToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.DiamondToolStripMenuItem.Text = "Diamond"
        '
        'FanToolStripMenuItem
        '
        Me.FanToolStripMenuItem.Name = "FanToolStripMenuItem"
        Me.FanToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.FanToolStripMenuItem.Text = "Fan"
        '
        'TreeToolStripMenuItem1
        '
        Me.TreeToolStripMenuItem1.Name = "TreeToolStripMenuItem1"
        Me.TreeToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.TreeToolStripMenuItem1.Text = "Tree"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem1.Text = "Frog"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem2.Text = "Smile"
        '
        'Exam_ContextMenu
        '
        Me.Exam_ContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Exam_ContextMenu.Depth = 0
        Me.Exam_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuizToolStripMenuItem1, Me.ExamToolStripMenuItem})
        Me.Exam_ContextMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.Exam_ContextMenu.Name = "Exam_ContextMenu"
        Me.Exam_ContextMenu.OwnerItem = Me.ToolStripMenuItem6
        Me.Exam_ContextMenu.Size = New System.Drawing.Size(153, 70)
        '
        'QuizToolStripMenuItem1
        '
        Me.QuizToolStripMenuItem1.Name = "QuizToolStripMenuItem1"
        Me.QuizToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.QuizToolStripMenuItem1.Text = "Quiz"
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExamToolStripMenuItem.Text = "Exam"
        '
        'Circle_ContexMenu
        '
        Me.Circle_ContexMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Circle_ContexMenu.Depth = 0
        Me.Circle_ContexMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BresenhamCircleToolStripMenuItem})
        Me.Circle_ContexMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.Circle_ContexMenu.Name = "Circle_ContexMenu"
        Me.Circle_ContexMenu.Size = New System.Drawing.Size(167, 26)
        '
        'BresenhamCircleToolStripMenuItem
        '
        Me.BresenhamCircleToolStripMenuItem.Name = "BresenhamCircleToolStripMenuItem"
        Me.BresenhamCircleToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.BresenhamCircleToolStripMenuItem.Text = "Bresenham Circle"
        '
        'Polygon_ContextMenu
        '
        Me.Polygon_ContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Polygon_ContextMenu.Depth = 0
        Me.Polygon_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PolarPolygonToolStripMenuItem, Me.CustomPolygonToolStripMenuItem})
        Me.Polygon_ContextMenu.MouseState = MaterialSkin.MouseState.HOVER
        Me.Polygon_ContextMenu.Name = "Polygon_ContextMenu"
        Me.Polygon_ContextMenu.OwnerItem = Me.ToolStripMenuItem7
        Me.Polygon_ContextMenu.Size = New System.Drawing.Size(164, 48)
        '
        'PolarPolygonToolStripMenuItem
        '
        Me.PolarPolygonToolStripMenuItem.Name = "PolarPolygonToolStripMenuItem"
        Me.PolarPolygonToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PolarPolygonToolStripMenuItem.Text = "Polar Polygon"
        '
        'CustomPolygonToolStripMenuItem
        '
        Me.CustomPolygonToolStripMenuItem.Name = "CustomPolygonToolStripMenuItem"
        Me.CustomPolygonToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CustomPolygonToolStripMenuItem.Text = "Custom Polygon"
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainMenuStrip.AutoSize = False
        Me.MainMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.MainMenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10, Me.Circle_ToolStripMenuItem, Me.Elllipse_ToolStripMenuItem, Me.ToolStripMenuItem8, Me.ToolStripMenuItem7, Me.ToolStripMenuItem6, Me.ToolStripMenuItem5, Me.ToolStripMenuItem4})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 23)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(1000, 44)
        Me.MainMenuStrip.TabIndex = 0
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.DropDown = Me.Line_ContentMenuStrip
        Me.ToolStripMenuItem10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem10.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem10.Image = Global.Computer_Graphics.My.Resources.Resources.Zipline_48px1
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(64, 40)
        Me.ToolStripMenuItem10.Text = "Line"
        '
        'Circle_ToolStripMenuItem
        '
        Me.Circle_ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Circle_ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.Circle_ToolStripMenuItem.Image = Global.Computer_Graphics.My.Resources.Resources.Circle_Thin_48px
        Me.Circle_ToolStripMenuItem.Name = "Circle_ToolStripMenuItem"
        Me.Circle_ToolStripMenuItem.Size = New System.Drawing.Size(75, 40)
        Me.Circle_ToolStripMenuItem.Text = "Circle"
        '
        'Elllipse_ToolStripMenuItem
        '
        Me.Elllipse_ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Elllipse_ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.Elllipse_ToolStripMenuItem.Image = Global.Computer_Graphics.My.Resources.Resources.Ellipse_Stroked_48px
        Me.Elllipse_ToolStripMenuItem.Name = "Elllipse_ToolStripMenuItem"
        Me.Elllipse_ToolStripMenuItem.Size = New System.Drawing.Size(79, 40)
        Me.Elllipse_ToolStripMenuItem.Text = "Ellipse"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDown = Me.HomeWork_ContextMenu
        Me.ToolStripMenuItem8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem8.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem8.Image = Global.Computer_Graphics.My.Resources.Resources.Home_48px
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(115, 40)
        Me.ToolStripMenuItem8.Text = "HomeWork"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDown = Me.Polygon_ContextMenu
        Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem7.Image = Global.Computer_Graphics.My.Resources.Resources.Pentagon_48px
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(93, 40)
        Me.ToolStripMenuItem7.Text = "Polygon"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDown = Me.Exam_ContextMenu
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem6.Image = Global.Computer_Graphics.My.Resources.Resources.Inspection_48px
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(73, 40)
        Me.ToolStripMenuItem6.Text = "Exam"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Image = Global.Computer_Graphics.My.Resources.Resources.Broom_48px1
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(72, 40)
        Me.ToolStripMenuItem5.Text = "Clear"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Image = Global.Computer_Graphics.My.Resources.Resources.Shutdown_48px
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(73, 40)
        Me.ToolStripMenuItem4.Text = "Close"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Computer_Graphics.My.Resources.Resources.Checklist_48px1
        Me.PictureBox2.Location = New System.Drawing.Point(138, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Pic_Drawn
        '
        Me.Pic_Drawn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_Drawn.BackColor = System.Drawing.Color.GhostWhite
        Me.Pic_Drawn.ContextMenuStrip = Me.Line_ContentMenuStrip
        Me.Pic_Drawn.Location = New System.Drawing.Point(0, 70)
        Me.Pic_Drawn.Name = "Pic_Drawn"
        Me.Pic_Drawn.Size = New System.Drawing.Size(1000, 487)
        Me.Pic_Drawn.TabIndex = 1
        Me.Pic_Drawn.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pic_Drawn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Graphics"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Line_ContextMenu.ResumeLayout(False)
        Me.Line_ContentMenuStrip.ResumeLayout(False)
        Me.HomeWork_ContextMenu.ResumeLayout(False)
        Me.Exam_ContextMenu.ResumeLayout(False)
        Me.Circle_ContexMenu.ResumeLayout(False)
        Me.Polygon_ContextMenu.ResumeLayout(False)
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Drawn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pic_Drawn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCurrentLocation As Label
    Friend WithEvents lblAlgorthemSelected As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Line_ContextMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents LineDirectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DifferentDigalLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BresenhamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Line_ContentMenuStrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents LineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CirculeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExampleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectLineToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DifferentDigitalLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BresenhamLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EllipseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Circle_ContexMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents BresenhamCircleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeWork_ContextMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents HouseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DiamondToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents QuizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Polygon_ContextMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents PolarPolygonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomPolygonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Exam_ContextMenu As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents QuizToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents Circle_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents Elllipse_ToolStripMenuItem As ToolStripMenuItem
End Class
