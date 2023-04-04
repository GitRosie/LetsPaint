<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

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
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.trkbrContrast = New System.Windows.Forms.TrackBar()
        Me.lblContrast = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.trkbrRedLvl = New System.Windows.Forms.TrackBar()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.trkbrGreenLvl = New System.Windows.Forms.TrackBar()
        Me.trkbrBlueLvl = New System.Windows.Forms.TrackBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegativeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.PixelDataGrouo = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSbtnBrush = New System.Windows.Forms.ToolStripButton()
        Me.TSbtnEraser = New System.Windows.Forms.ToolStripButton()
        Me.TSbtnAddText = New System.Windows.Forms.ToolStripButton()
        Me.pbCanvas = New System.Windows.Forms.PictureBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        CType(Me.trkbrContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbrRedLvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbrGreenLvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbrBlueLvl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.PixelDataGrouo.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.ForeColor = System.Drawing.Color.DarkRed
        Me.lblR.Location = New System.Drawing.Point(-3, 42)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(25, 17)
        Me.lblR.TabIndex = 4
        Me.lblR.Text = "R="
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG.ForeColor = System.Drawing.Color.Green
        Me.lblG.Location = New System.Drawing.Point(-3, 59)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(26, 17)
        Me.lblG.TabIndex = 5
        Me.lblG.Text = "G="
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblB.Location = New System.Drawing.Point(-3, 76)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(24, 17)
        Me.lblB.TabIndex = 6
        Me.lblB.Text = "B="
        '
        'trkbrContrast
        '
        Me.trkbrContrast.Location = New System.Drawing.Point(39, 43)
        Me.trkbrContrast.Maximum = 255
        Me.trkbrContrast.Minimum = -255
        Me.trkbrContrast.Name = "trkbrContrast"
        Me.trkbrContrast.Size = New System.Drawing.Size(114, 45)
        Me.trkbrContrast.TabIndex = 11
        '
        'lblContrast
        '
        Me.lblContrast.AutoSize = True
        Me.lblContrast.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrast.Location = New System.Drawing.Point(45, 27)
        Me.lblContrast.Name = "lblContrast"
        Me.lblContrast.Size = New System.Drawing.Size(60, 17)
        Me.lblContrast.TabIndex = 12
        Me.lblContrast.Text = "Contrast:"
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRed.Location = New System.Drawing.Point(45, 97)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(73, 17)
        Me.lblRed.TabIndex = 13
        Me.lblRed.Text = "Red Levels:"
        '
        'trkbrRedLvl
        '
        Me.trkbrRedLvl.Location = New System.Drawing.Point(39, 116)
        Me.trkbrRedLvl.Maximum = 255
        Me.trkbrRedLvl.Minimum = -255
        Me.trkbrRedLvl.Name = "trkbrRedLvl"
        Me.trkbrRedLvl.Size = New System.Drawing.Size(114, 45)
        Me.trkbrRedLvl.TabIndex = 14
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreen.Location = New System.Drawing.Point(45, 174)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(85, 17)
        Me.lblGreen.TabIndex = 15
        Me.lblGreen.Text = "Green Levels:"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(45, 243)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(71, 17)
        Me.lblBlue.TabIndex = 16
        Me.lblBlue.Text = "Blue Levels"
        '
        'trkbrGreenLvl
        '
        Me.trkbrGreenLvl.Location = New System.Drawing.Point(39, 189)
        Me.trkbrGreenLvl.Maximum = 255
        Me.trkbrGreenLvl.Minimum = -255
        Me.trkbrGreenLvl.Name = "trkbrGreenLvl"
        Me.trkbrGreenLvl.Size = New System.Drawing.Size(114, 45)
        Me.trkbrGreenLvl.TabIndex = 17
        '
        'trkbrBlueLvl
        '
        Me.trkbrBlueLvl.Location = New System.Drawing.Point(39, 262)
        Me.trkbrBlueLvl.Maximum = 255
        Me.trkbrBlueLvl.Minimum = -255
        Me.trkbrBlueLvl.Name = "trkbrBlueLvl"
        Me.trkbrBlueLvl.Size = New System.Drawing.Size(114, 45)
        Me.trkbrBlueLvl.TabIndex = 18
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1047, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+n"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+o"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+s"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As..."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NegativeToolStripMenuItem, Me.GreyToolStripMenuItem, Me.BlurToolStripMenuItem, Me.EdgeToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'NegativeToolStripMenuItem
        '
        Me.NegativeToolStripMenuItem.Name = "NegativeToolStripMenuItem"
        Me.NegativeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NegativeToolStripMenuItem.Text = "Negative"
        '
        'GreyToolStripMenuItem
        '
        Me.GreyToolStripMenuItem.Name = "GreyToolStripMenuItem"
        Me.GreyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GreyToolStripMenuItem.Text = "Greyscale"
        '
        'BlurToolStripMenuItem
        '
        Me.BlurToolStripMenuItem.Name = "BlurToolStripMenuItem"
        Me.BlurToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlurToolStripMenuItem.Text = "Blur"
        '
        'EdgeToolStripMenuItem
        '
        Me.EdgeToolStripMenuItem.Name = "EdgeToolStripMenuItem"
        Me.EdgeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EdgeToolStripMenuItem.Text = "Edge"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.Color.Black
        Me.lblX.Location = New System.Drawing.Point(-3, 16)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(25, 17)
        Me.lblX.TabIndex = 22
        Me.lblX.Text = "X="
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.ForeColor = System.Drawing.Color.Black
        Me.lblY.Location = New System.Drawing.Point(57, 16)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(24, 17)
        Me.lblY.TabIndex = 23
        Me.lblY.Text = "Y="
        '
        'PixelDataGrouo
        '
        Me.PixelDataGrouo.Controls.Add(Me.lblX)
        Me.PixelDataGrouo.Controls.Add(Me.lblY)
        Me.PixelDataGrouo.Controls.Add(Me.lblR)
        Me.PixelDataGrouo.Controls.Add(Me.lblG)
        Me.PixelDataGrouo.Controls.Add(Me.lblB)
        Me.PixelDataGrouo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PixelDataGrouo.Location = New System.Drawing.Point(38, 491)
        Me.PixelDataGrouo.Name = "PixelDataGrouo"
        Me.PixelDataGrouo.Size = New System.Drawing.Size(115, 99)
        Me.PixelDataGrouo.TabIndex = 24
        Me.PixelDataGrouo.TabStop = False
        Me.PixelDataGrouo.Text = "Pixel Info"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(32, 537)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 27)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(32, 562)
        Me.ToolStripContainer1.TabIndex = 26
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSbtnBrush, Me.TSbtnEraser, Me.TSbtnAddText})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(24, 537)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSbtnBrush
        '
        Me.TSbtnBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnBrush.Image = Global.pcopy.My.Resources.Resources.Brush
        Me.TSbtnBrush.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnBrush.Name = "TSbtnBrush"
        Me.TSbtnBrush.Size = New System.Drawing.Size(21, 20)
        Me.TSbtnBrush.Text = "PaintBrush"
        Me.TSbtnBrush.ToolTipText = "Brush"
        '
        'TSbtnEraser
        '
        Me.TSbtnEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnEraser.Image = Global.pcopy.My.Resources.Resources.Eraser
        Me.TSbtnEraser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnEraser.Name = "TSbtnEraser"
        Me.TSbtnEraser.Size = New System.Drawing.Size(21, 20)
        Me.TSbtnEraser.Text = "Eraser"
        '
        'TSbtnAddText
        '
        Me.TSbtnAddText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnAddText.Image = Global.pcopy.My.Resources.Resources.text
        Me.TSbtnAddText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnAddText.Name = "TSbtnAddText"
        Me.TSbtnAddText.Size = New System.Drawing.Size(21, 20)
        Me.TSbtnAddText.Text = "Add Text"
        '
        'pbCanvas
        '
        Me.pbCanvas.BackColor = System.Drawing.Color.White
        Me.pbCanvas.Location = New System.Drawing.Point(159, 27)
        Me.pbCanvas.Name = "pbCanvas"
        Me.pbCanvas.Size = New System.Drawing.Size(884, 563)
        Me.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbCanvas.TabIndex = 25
        Me.pbCanvas.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 592)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.pbCanvas)
        Me.Controls.Add(Me.PixelDataGrouo)
        Me.Controls.Add(Me.trkbrBlueLvl)
        Me.Controls.Add(Me.trkbrGreenLvl)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.trkbrRedLvl)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.lblContrast)
        Me.Controls.Add(Me.trkbrContrast)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1063, 631)
        Me.Name = "Main"
        Me.Text = "Lets Paint!"
        CType(Me.trkbrContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbrRedLvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbrGreenLvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbrBlueLvl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PixelDataGrouo.ResumeLayout(False)
        Me.PixelDataGrouo.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblR As Label
    Friend WithEvents lblG As Label
    Friend WithEvents lblB As Label
    Friend WithEvents trkbrContrast As TrackBar
    Friend WithEvents lblContrast As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents trkbrRedLvl As TrackBar
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents trkbrGreenLvl As TrackBar
    Friend WithEvents trkbrBlueLvl As TrackBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegativeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents PixelDataGrouo As GroupBox
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pbCanvas As PictureBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSbtnBrush As ToolStripButton
    Friend WithEvents TSbtnEraser As ToolStripButton
    Friend WithEvents TSbtnAddText As ToolStripButton
    Friend WithEvents FontDialog1 As FontDialog
End Class
