<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCart = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudJuice = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDrinkName3 = New System.Windows.Forms.Label()
        Me.nudLatte = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDrinkName2 = New System.Windows.Forms.Label()
        Me.nudLemonade = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDrinkName1 = New System.Windows.Forms.Label()
        Me.lblFoodName1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudPizza = New System.Windows.Forms.NumericUpDown()
        Me.lblFoodName2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudRamen = New System.Windows.Forms.NumericUpDown()
        Me.lblFoodName3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudCake = New System.Windows.Forms.NumericUpDown()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nudJuice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLatte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLemonade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRamen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMember, Me.mnuMenu, Me.mnuLogOut, Me.mnuCart})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 46)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMember
        '
        Me.mnuMember.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMember.ForeColor = System.Drawing.Color.White
        Me.mnuMember.Name = "mnuMember"
        Me.mnuMember.Size = New System.Drawing.Size(122, 42)
        Me.mnuMember.Text = "Member"
        '
        'mnuMenu
        '
        Me.mnuMenu.BackColor = System.Drawing.Color.Transparent
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
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(122, 42)
        Me.mnuLogOut.Text = "Log Out"
        '
        'mnuCart
        '
        Me.mnuCart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuCart.BackColor = System.Drawing.Color.Transparent
        Me.mnuCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mnuCart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuCart.Image = CType(resources.GetObject("mnuCart.Image"), System.Drawing.Image)
        Me.mnuCart.Name = "mnuCart"
        Me.mnuCart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnuCart.Size = New System.Drawing.Size(40, 42)
        '
        'nudJuice
        '
        Me.nudJuice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudJuice.Location = New System.Drawing.Point(577, 505)
        Me.nudJuice.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudJuice.Name = "nudJuice"
        Me.nudJuice.Size = New System.Drawing.Size(51, 28)
        Me.nudJuice.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(493, 505)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'lblDrinkName3
        '
        Me.lblDrinkName3.AutoSize = True
        Me.lblDrinkName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkName3.Location = New System.Drawing.Point(487, 476)
        Me.lblDrinkName3.Name = "lblDrinkName3"
        Me.lblDrinkName3.Size = New System.Drawing.Size(134, 26)
        Me.lblDrinkName3.TabIndex = 1
        Me.lblDrinkName3.Text = "Juice - RM 2"
        '
        'nudLatte
        '
        Me.nudLatte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLatte.Location = New System.Drawing.Point(575, 377)
        Me.nudLatte.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLatte.Name = "nudLatte"
        Me.nudLatte.Size = New System.Drawing.Size(51, 28)
        Me.nudLatte.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(491, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Quantity"
        '
        'lblDrinkName2
        '
        Me.lblDrinkName2.AutoSize = True
        Me.lblDrinkName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkName2.Location = New System.Drawing.Point(490, 334)
        Me.lblDrinkName2.Name = "lblDrinkName2"
        Me.lblDrinkName2.Size = New System.Drawing.Size(180, 26)
        Me.lblDrinkName2.TabIndex = 1
        Me.lblDrinkName2.Text = "Latte -------- RM 3"
        '
        'nudLemonade
        '
        Me.nudLemonade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLemonade.Location = New System.Drawing.Point(577, 267)
        Me.nudLemonade.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLemonade.Name = "nudLemonade"
        Me.nudLemonade.Size = New System.Drawing.Size(51, 28)
        Me.nudLemonade.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(493, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity"
        '
        'lblDrinkName1
        '
        Me.lblDrinkName1.AutoSize = True
        Me.lblDrinkName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkName1.Location = New System.Drawing.Point(487, 227)
        Me.lblDrinkName1.Name = "lblDrinkName1"
        Me.lblDrinkName1.Size = New System.Drawing.Size(235, 26)
        Me.lblDrinkName1.TabIndex = 1
        Me.lblDrinkName1.Text = "Lemonade -------- RM 2"
        '
        'lblFoodName1
        '
        Me.lblFoodName1.AutoSize = True
        Me.lblFoodName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName1.Location = New System.Drawing.Point(61, 227)
        Me.lblFoodName1.Name = "lblFoodName1"
        Me.lblFoodName1.Size = New System.Drawing.Size(137, 26)
        Me.lblFoodName1.TabIndex = 1
        Me.lblFoodName1.Text = "Pizza - RM 5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantity"
        '
        'nudPizza
        '
        Me.nudPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPizza.Location = New System.Drawing.Point(146, 277)
        Me.nudPizza.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPizza.Name = "nudPizza"
        Me.nudPizza.Size = New System.Drawing.Size(51, 28)
        Me.nudPizza.TabIndex = 6
        '
        'lblFoodName2
        '
        Me.lblFoodName2.AutoSize = True
        Me.lblFoodName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName2.Location = New System.Drawing.Point(52, 349)
        Me.lblFoodName2.Name = "lblFoodName2"
        Me.lblFoodName2.Size = New System.Drawing.Size(154, 26)
        Me.lblFoodName2.TabIndex = 1
        Me.lblFoodName2.Text = "Ramen - RM 6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Quantity"
        '
        'nudRamen
        '
        Me.nudRamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRamen.Location = New System.Drawing.Point(146, 393)
        Me.nudRamen.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudRamen.Name = "nudRamen"
        Me.nudRamen.Size = New System.Drawing.Size(51, 28)
        Me.nudRamen.TabIndex = 8
        '
        'lblFoodName3
        '
        Me.lblFoodName3.AutoSize = True
        Me.lblFoodName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName3.Location = New System.Drawing.Point(70, 476)
        Me.lblFoodName3.Name = "lblFoodName3"
        Me.lblFoodName3.Size = New System.Drawing.Size(134, 26)
        Me.lblFoodName3.TabIndex = 1
        Me.lblFoodName3.Text = "Cake - RM 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 518)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Quantity"
        '
        'nudCake
        '
        Me.nudCake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCake.Location = New System.Drawing.Point(155, 518)
        Me.nudCake.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCake.Name = "nudCake"
        Me.nudCake.Size = New System.Drawing.Size(51, 28)
        Me.nudCake.TabIndex = 9
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(561, 156)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(48, 27)
        Me.Guna2HtmlLabel1.TabIndex = 13
        Me.Guna2HtmlLabel1.Text = "Drink"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(100, 156)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(48, 27)
        Me.Guna2HtmlLabel2.TabIndex = 14
        Me.Guna2HtmlLabel2.Text = "Food" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(312, 69)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(102, 48)
        Me.Guna2HtmlLabel3.TabIndex = 15
        Me.Guna2HtmlLabel3.Text = "Menu"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(261, 123)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(200, 10)
        Me.Guna2Separator1.TabIndex = 16
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(482, 189)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(200, 10)
        Me.Guna2Separator2.TabIndex = 17
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator3.FillThickness = 2
        Me.Guna2Separator3.Location = New System.Drawing.Point(31, 189)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(200, 10)
        Me.Guna2Separator3.TabIndex = 18
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 594)
        Me.Controls.Add(Me.Guna2Separator3)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.nudCake)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudRamen)
        Me.Controls.Add(Me.lblFoodName3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudPizza)
        Me.Controls.Add(Me.lblFoodName2)
        Me.Controls.Add(Me.nudJuice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFoodName1)
        Me.Controls.Add(Me.nudLatte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblDrinkName3)
        Me.Controls.Add(Me.nudLemonade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDrinkName2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDrinkName1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nudJuice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLatte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLemonade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRamen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents lblDrinkName3 As Label
    Friend WithEvents lblDrinkName2 As Label
    Friend WithEvents lblDrinkName1 As Label
    Friend WithEvents nudJuice As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudLatte As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudLemonade As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents mnuCart As ToolStripMenuItem
    Friend WithEvents mnuMember As ToolStripMenuItem
    Friend WithEvents lblFoodName1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudPizza As NumericUpDown
    Friend WithEvents lblFoodName2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudRamen As NumericUpDown
    Friend WithEvents lblFoodName3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudCake As NumericUpDown
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
End Class
