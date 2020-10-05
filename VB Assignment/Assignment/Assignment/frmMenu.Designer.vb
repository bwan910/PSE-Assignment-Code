<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuDailySpecial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCart = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpbFood = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.nudCake = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imgCake = New System.Windows.Forms.PictureBox()
        Me.lblFoodName3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nudRamen = New System.Windows.Forms.NumericUpDown()
        Me.imgRamen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFoodName2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudPizza = New System.Windows.Forms.NumericUpDown()
        Me.imgPizza = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFoodName1 = New System.Windows.Forms.Label()
        Me.gpbDrink = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.nudJuice = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.imgJuice = New System.Windows.Forms.PictureBox()
        Me.lblDrinkName3 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.nudLatte = New System.Windows.Forms.NumericUpDown()
        Me.imgLatte = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDrinkName2 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.nudLemonade = New System.Windows.Forms.NumericUpDown()
        Me.imgLemonade = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDrinkName1 = New System.Windows.Forms.Label()
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.lblEmpId = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gpbFood.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudCake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudRamen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRamen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDrink.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudJuice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgJuice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nudLatte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLatte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.nudLemonade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLemonade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDailySpecial, Me.mnuMenu, Me.mnuLogOut, Me.mnuCart})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 46)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuDailySpecial
        '
        Me.mnuDailySpecial.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDailySpecial.ForeColor = System.Drawing.Color.White
        Me.mnuDailySpecial.Name = "mnuDailySpecial"
        Me.mnuDailySpecial.Size = New System.Drawing.Size(172, 42)
        Me.mnuDailySpecial.Text = "Daily Special"
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
        'gpbFood
        '
        Me.gpbFood.BackColor = System.Drawing.Color.Black
        Me.gpbFood.Controls.Add(Me.GroupBox3)
        Me.gpbFood.Controls.Add(Me.GroupBox2)
        Me.gpbFood.Controls.Add(Me.GroupBox1)
        Me.gpbFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbFood.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gpbFood.Location = New System.Drawing.Point(32, 61)
        Me.gpbFood.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbFood.Name = "gpbFood"
        Me.gpbFood.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbFood.Size = New System.Drawing.Size(390, 563)
        Me.gpbFood.TabIndex = 1
        Me.gpbFood.TabStop = False
        Me.gpbFood.Text = "Food"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.nudCake)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.imgCake)
        Me.GroupBox3.Controls.Add(Me.lblFoodName3)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(19, 379)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 139)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'nudCake
        '
        Me.nudCake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCake.Location = New System.Drawing.Point(269, 88)
        Me.nudCake.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCake.Name = "nudCake"
        Me.nudCake.Size = New System.Drawing.Size(51, 28)
        Me.nudCake.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Quantity"
        '
        'imgCake
        '
        Me.imgCake.BackgroundImage = CType(resources.GetObject("imgCake.BackgroundImage"), System.Drawing.Image)
        Me.imgCake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCake.Location = New System.Drawing.Point(6, 19)
        Me.imgCake.Name = "imgCake"
        Me.imgCake.Size = New System.Drawing.Size(153, 114)
        Me.imgCake.TabIndex = 7
        Me.imgCake.TabStop = False
        '
        'lblFoodName3
        '
        Me.lblFoodName3.AutoSize = True
        Me.lblFoodName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName3.Location = New System.Drawing.Point(184, 46)
        Me.lblFoodName3.Name = "lblFoodName3"
        Me.lblFoodName3.Size = New System.Drawing.Size(134, 26)
        Me.lblFoodName3.TabIndex = 1
        Me.lblFoodName3.Text = "Cake - RM 3"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.nudRamen)
        Me.GroupBox2.Controls.Add(Me.imgRamen)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblFoodName2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(19, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 139)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'nudRamen
        '
        Me.nudRamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRamen.Location = New System.Drawing.Point(269, 88)
        Me.nudRamen.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudRamen.Name = "nudRamen"
        Me.nudRamen.Size = New System.Drawing.Size(51, 28)
        Me.nudRamen.TabIndex = 8
        '
        'imgRamen
        '
        Me.imgRamen.BackgroundImage = CType(resources.GetObject("imgRamen.BackgroundImage"), System.Drawing.Image)
        Me.imgRamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgRamen.Location = New System.Drawing.Point(6, 12)
        Me.imgRamen.Name = "imgRamen"
        Me.imgRamen.Size = New System.Drawing.Size(153, 121)
        Me.imgRamen.TabIndex = 7
        Me.imgRamen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Quantity"
        '
        'lblFoodName2
        '
        Me.lblFoodName2.AutoSize = True
        Me.lblFoodName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName2.Location = New System.Drawing.Point(175, 44)
        Me.lblFoodName2.Name = "lblFoodName2"
        Me.lblFoodName2.Size = New System.Drawing.Size(154, 26)
        Me.lblFoodName2.TabIndex = 1
        Me.lblFoodName2.Text = "Ramen - RM 6"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.nudPizza)
        Me.GroupBox1.Controls.Add(Me.imgPizza)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblFoodName1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(19, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'nudPizza
        '
        Me.nudPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPizza.Location = New System.Drawing.Point(269, 94)
        Me.nudPizza.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudPizza.Name = "nudPizza"
        Me.nudPizza.Size = New System.Drawing.Size(51, 28)
        Me.nudPizza.TabIndex = 6
        '
        'imgPizza
        '
        Me.imgPizza.BackgroundImage = CType(resources.GetObject("imgPizza.BackgroundImage"), System.Drawing.Image)
        Me.imgPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgPizza.Location = New System.Drawing.Point(6, 19)
        Me.imgPizza.Name = "imgPizza"
        Me.imgPizza.Size = New System.Drawing.Size(153, 114)
        Me.imgPizza.TabIndex = 6
        Me.imgPizza.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantity"
        '
        'lblFoodName1
        '
        Me.lblFoodName1.AutoSize = True
        Me.lblFoodName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName1.Location = New System.Drawing.Point(184, 44)
        Me.lblFoodName1.Name = "lblFoodName1"
        Me.lblFoodName1.Size = New System.Drawing.Size(137, 26)
        Me.lblFoodName1.TabIndex = 1
        Me.lblFoodName1.Text = "Pizza - RM 5"
        '
        'gpbDrink
        '
        Me.gpbDrink.BackColor = System.Drawing.Color.Black
        Me.gpbDrink.Controls.Add(Me.GroupBox5)
        Me.gpbDrink.Controls.Add(Me.GroupBox6)
        Me.gpbDrink.Controls.Add(Me.GroupBox7)
        Me.gpbDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbDrink.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gpbDrink.Location = New System.Drawing.Point(492, 61)
        Me.gpbDrink.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbDrink.Name = "gpbDrink"
        Me.gpbDrink.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbDrink.Size = New System.Drawing.Size(399, 563)
        Me.gpbDrink.TabIndex = 4
        Me.gpbDrink.TabStop = False
        Me.gpbDrink.Text = "Drink"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.nudJuice)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.imgJuice)
        Me.GroupBox5.Controls.Add(Me.lblDrinkName3)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox5.Location = New System.Drawing.Point(19, 379)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(361, 139)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'nudJuice
        '
        Me.nudJuice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudJuice.Location = New System.Drawing.Point(276, 88)
        Me.nudJuice.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudJuice.Name = "nudJuice"
        Me.nudJuice.Size = New System.Drawing.Size(51, 28)
        Me.nudJuice.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'imgJuice
        '
        Me.imgJuice.BackgroundImage = CType(resources.GetObject("imgJuice.BackgroundImage"), System.Drawing.Image)
        Me.imgJuice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgJuice.Location = New System.Drawing.Point(6, 19)
        Me.imgJuice.Name = "imgJuice"
        Me.imgJuice.Size = New System.Drawing.Size(153, 114)
        Me.imgJuice.TabIndex = 7
        Me.imgJuice.TabStop = False
        '
        'lblDrinkName3
        '
        Me.lblDrinkName3.AutoSize = True
        Me.lblDrinkName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkName3.Location = New System.Drawing.Point(191, 46)
        Me.lblDrinkName3.Name = "lblDrinkName3"
        Me.lblDrinkName3.Size = New System.Drawing.Size(134, 26)
        Me.lblDrinkName3.TabIndex = 1
        Me.lblDrinkName3.Text = "Juice - RM 2"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.nudLatte)
        Me.GroupBox6.Controls.Add(Me.imgLatte)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.lblDrinkName2)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox6.Location = New System.Drawing.Point(19, 209)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(361, 139)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'nudLatte
        '
        Me.nudLatte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLatte.Location = New System.Drawing.Point(276, 87)
        Me.nudLatte.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLatte.Name = "nudLatte"
        Me.nudLatte.Size = New System.Drawing.Size(51, 28)
        Me.nudLatte.TabIndex = 11
        '
        'imgLatte
        '
        Me.imgLatte.BackgroundImage = CType(resources.GetObject("imgLatte.BackgroundImage"), System.Drawing.Image)
        Me.imgLatte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLatte.Location = New System.Drawing.Point(6, 19)
        Me.imgLatte.Name = "imgLatte"
        Me.imgLatte.Size = New System.Drawing.Size(153, 114)
        Me.imgLatte.TabIndex = 7
        Me.imgLatte.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Quantity"
        '
        'lblDrinkName2
        '
        Me.lblDrinkName2.AutoSize = True
        Me.lblDrinkName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkName2.Location = New System.Drawing.Point(191, 44)
        Me.lblDrinkName2.Name = "lblDrinkName2"
        Me.lblDrinkName2.Size = New System.Drawing.Size(131, 26)
        Me.lblDrinkName2.TabIndex = 1
        Me.lblDrinkName2.Text = "Latte - RM 3"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.nudLemonade)
        Me.GroupBox7.Controls.Add(Me.imgLemonade)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.lblDrinkName1)
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox7.Location = New System.Drawing.Point(19, 47)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(361, 139)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'nudLemonade
        '
        Me.nudLemonade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLemonade.Location = New System.Drawing.Point(276, 94)
        Me.nudLemonade.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLemonade.Name = "nudLemonade"
        Me.nudLemonade.Size = New System.Drawing.Size(51, 28)
        Me.nudLemonade.TabIndex = 11
        '
        'imgLemonade
        '
        Me.imgLemonade.BackgroundImage = CType(resources.GetObject("imgLemonade.BackgroundImage"), System.Drawing.Image)
        Me.imgLemonade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLemonade.Location = New System.Drawing.Point(6, 19)
        Me.imgLemonade.Name = "imgLemonade"
        Me.imgLemonade.Size = New System.Drawing.Size(153, 114)
        Me.imgLemonade.TabIndex = 7
        Me.imgLemonade.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity"
        '
        'lblDrinkName1
        '
        Me.lblDrinkName1.AutoSize = True
        Me.lblDrinkName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkName1.Location = New System.Drawing.Point(163, 46)
        Me.lblDrinkName1.Name = "lblDrinkName1"
        Me.lblDrinkName1.Size = New System.Drawing.Size(186, 26)
        Me.lblDrinkName1.TabIndex = 1
        Me.lblDrinkName1.Text = "Lemonade - RM 2"
        '
        'lblOrderNum
        '
        Me.lblOrderNum.AutoSize = True
        Me.lblOrderNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNum.Location = New System.Drawing.Point(444, 355)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(26, 29)
        Me.lblOrderNum.TabIndex = 5
        Me.lblOrderNum.Text = "1"
        '
        'lblEmpId
        '
        Me.lblEmpId.AutoSize = True
        Me.lblEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpId.Location = New System.Drawing.Point(444, 440)
        Me.lblEmpId.Name = "lblEmpId"
        Me.lblEmpId.Size = New System.Drawing.Size(26, 29)
        Me.lblEmpId.TabIndex = 6
        Me.lblEmpId.Text = "1"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(914, 780)
        Me.Controls.Add(Me.lblEmpId)
        Me.Controls.Add(Me.lblOrderNum)
        Me.Controls.Add(Me.gpbDrink)
        Me.Controls.Add(Me.gpbFood)
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
        Me.gpbFood.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudCake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudRamen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRamen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudPizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDrink.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudJuice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgJuice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nudLatte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLatte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.nudLemonade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLemonade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuDailySpecial As ToolStripMenuItem
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents gpbFood As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblFoodName3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFoodName2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFoodName1 As Label
    Friend WithEvents gpbDrink As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblDrinkName3 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblDrinkName2 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblDrinkName1 As Label
    Friend WithEvents imgCake As PictureBox
    Friend WithEvents imgRamen As PictureBox
    Friend WithEvents imgPizza As PictureBox
    Friend WithEvents imgJuice As PictureBox
    Friend WithEvents imgLatte As PictureBox
    Friend WithEvents imgLemonade As PictureBox
    Friend WithEvents nudPizza As NumericUpDown
    Friend WithEvents nudCake As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents nudRamen As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudJuice As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudLatte As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudLemonade As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents mnuCart As ToolStripMenuItem
    Friend WithEvents lblOrderNum As Label
    Friend WithEvents lblEmpId As Label
End Class
