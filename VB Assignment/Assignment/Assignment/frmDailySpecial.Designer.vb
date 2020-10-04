<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailySpecial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailySpecial))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuDailySpecial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgFood = New System.Windows.Forms.PictureBox()
        Me.imgDrink = New System.Windows.Forms.PictureBox()
        Me.lblDSFood = New System.Windows.Forms.Label()
        Me.lblDSDrink = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDailySpecial, Me.mnuMenu, Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 46)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuDailySpecial
        '
        Me.mnuDailySpecial.BackColor = System.Drawing.Color.Transparent
        Me.mnuDailySpecial.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDailySpecial.ForeColor = System.Drawing.Color.White
        Me.mnuDailySpecial.Name = "mnuDailySpecial"
        Me.mnuDailySpecial.Size = New System.Drawing.Size(172, 42)
        Me.mnuDailySpecial.Text = "Daily Special"
        '
        'mnuMenu
        '
        Me.mnuMenu.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMenu.ForeColor = System.Drawing.Color.White
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(93, 42)
        Me.mnuMenu.Text = "Menu"
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuLogOut.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLogOut.ForeColor = System.Drawing.Color.White
        Me.mnuLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnuLogOut.Size = New System.Drawing.Size(116, 42)
        Me.mnuLogOut.Text = "Log out"
        '
        'imgFood
        '
        Me.imgFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgFood.Location = New System.Drawing.Point(21, 63)
        Me.imgFood.Name = "imgFood"
        Me.imgFood.Size = New System.Drawing.Size(227, 209)
        Me.imgFood.TabIndex = 4
        Me.imgFood.TabStop = False
        '
        'imgDrink
        '
        Me.imgDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgDrink.Location = New System.Drawing.Point(651, 63)
        Me.imgDrink.Name = "imgDrink"
        Me.imgDrink.Size = New System.Drawing.Size(223, 209)
        Me.imgDrink.TabIndex = 5
        Me.imgDrink.TabStop = False
        '
        'lblDSFood
        '
        Me.lblDSFood.AutoSize = True
        Me.lblDSFood.BackColor = System.Drawing.Color.Transparent
        Me.lblDSFood.Font = New System.Drawing.Font("Segoe Script", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSFood.Location = New System.Drawing.Point(93, 286)
        Me.lblDSFood.Name = "lblDSFood"
        Me.lblDSFood.Size = New System.Drawing.Size(71, 37)
        Me.lblDSFood.TabIndex = 6
        Me.lblDSFood.Text = "Food"
        '
        'lblDSDrink
        '
        Me.lblDSDrink.AutoSize = True
        Me.lblDSDrink.BackColor = System.Drawing.Color.Transparent
        Me.lblDSDrink.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSDrink.Location = New System.Drawing.Point(728, 289)
        Me.lblDSDrink.Name = "lblDSDrink"
        Me.lblDSDrink.Size = New System.Drawing.Size(71, 29)
        Me.lblDSDrink.TabIndex = 7
        Me.lblDSDrink.Text = "Drink"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(296, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 201)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmDailySpecial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 435)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDSDrink)
        Me.Controls.Add(Me.lblDSFood)
        Me.Controls.Add(Me.imgDrink)
        Me.Controls.Add(Me.imgFood)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDailySpecial"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Daily Special"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuDailySpecial As ToolStripMenuItem
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents imgFood As PictureBox
    Friend WithEvents imgDrink As PictureBox
    Friend WithEvents lblDSFood As Label
    Friend WithEvents lblDSDrink As Label
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
