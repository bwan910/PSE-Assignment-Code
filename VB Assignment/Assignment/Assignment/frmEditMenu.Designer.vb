<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxItemType = New System.Windows.Forms.ComboBox()
        Me.txtID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuAdd, Me.mnuDelete, Me.mnuUpdate, Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1123, 46)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBack.ForeColor = System.Drawing.Color.White
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(48, 42)
        Me.mnuBack.Text = "<"
        '
        'mnuAdd
        '
        Me.mnuAdd.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAdd.ForeColor = System.Drawing.Color.White
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(80, 42)
        Me.mnuAdd.Text = "Add"
        '
        'mnuDelete
        '
        Me.mnuDelete.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDelete.ForeColor = System.Drawing.Color.White
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(99, 42)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUpdate.ForeColor = System.Drawing.Color.White
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(113, 42)
        Me.mnuUpdate.Text = "Update"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price :"
        '
        'dgvMenu
        '
        Me.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(441, 102)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.RowHeadersWidth = 62
        Me.dgvMenu.RowTemplate.Height = 28
        Me.dgvMenu.Size = New System.Drawing.Size(659, 450)
        Me.dgvMenu.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Item Type:"
        '
        'cboxItemType
        '
        Me.cboxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxItemType.FormattingEnabled = True
        Me.cboxItemType.Items.AddRange(New Object() {"Food ", "Beverage"})
        Me.cboxItemType.Location = New System.Drawing.Point(181, 305)
        Me.cboxItemType.Name = "cboxItemType"
        Me.cboxItemType.Size = New System.Drawing.Size(205, 37)
        Me.cboxItemType.TabIndex = 10
        '
        'txtID
        '
        Me.txtID.BorderColor = System.Drawing.Color.Black
        Me.txtID.BorderRadius = 13
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DefaultText = ""
        Me.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.DisabledState.Parent = Me.txtID
        Me.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.FocusedState.Parent = Me.txtID
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.HoverState.Parent = Me.txtID
        Me.txtID.Location = New System.Drawing.Point(186, 91)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PlaceholderText = ""
        Me.txtID.SelectedText = ""
        Me.txtID.ShadowDecoration.Parent = Me.txtID
        Me.txtID.Size = New System.Drawing.Size(200, 36)
        Me.txtID.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.BorderColor = System.Drawing.Color.Black
        Me.txtName.BorderRadius = 13
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.Location = New System.Drawing.Point(186, 157)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(200, 36)
        Me.txtName.TabIndex = 12
        '
        'txtPrice
        '
        Me.txtPrice.BorderColor = System.Drawing.Color.Black
        Me.txtPrice.BorderRadius = 13
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.Parent = Me.txtPrice
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.FocusedState.Parent = Me.txtPrice
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.HoverState.Parent = Me.txtPrice
        Me.txtPrice.Location = New System.Drawing.Point(186, 229)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(200, 36)
        Me.txtPrice.TabIndex = 13
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnEdit.BorderRadius = 20
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.LightGray
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(77, 418)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(201, 64)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Update"
        '
        'frmEditMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1123, 644)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cboxItemType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvMenu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEditMenu"
        Me.Text = "Menu Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cboxItemType As ComboBox
    Friend WithEvents txtID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
End Class
