<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.Window
        Me.btnMenu.BackgroundImage = CType(resources.GetObject("btnMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMenu.Location = New System.Drawing.Point(56, 226)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(175, 261)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnEmployee
        '
        Me.btnEmployee.BackgroundImage = CType(resources.GetObject("btnEmployee.BackgroundImage"), System.Drawing.Image)
        Me.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmployee.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmployee.Location = New System.Drawing.Point(322, 226)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(167, 261)
        Me.btnEmployee.TabIndex = 1
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCustomer.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCustomer.Location = New System.Drawing.Point(576, 226)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(167, 261)
        Me.btnCustomer.TabIndex = 2
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 39)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuLogOut.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLogOut.ForeColor = System.Drawing.Color.White
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(115, 35)
        Me.mnuLogOut.Text = "Log Out"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(292, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 106)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(147, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 106)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(642, 96)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(101, 60)
        Me.btnChart.TabIndex = 6
        Me.btnChart.Text = "Chart"
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(795, 499)
        Me.Controls.Add(Me.btnChart)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnChart As Button
End Class
