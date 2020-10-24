<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnMenu.Location = New System.Drawing.Point(47, 349)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(175, 138)
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
        Me.btnEmployee.Location = New System.Drawing.Point(313, 349)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(167, 138)
        Me.btnEmployee.TabIndex = 1
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 39)
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
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(568, 349)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(167, 138)
        Me.btnChart.TabIndex = 6
        Me.btnChart.Text = "Chart"
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(778, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(778, 564)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnChart)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents btnChart As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
