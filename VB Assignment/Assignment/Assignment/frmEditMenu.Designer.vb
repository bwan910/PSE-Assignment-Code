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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxItemType = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuAdd, Me.mnuDelete, Me.mnuUpdate, Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1196, 48)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBack.ForeColor = System.Drawing.Color.White
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(48, 44)
        Me.mnuBack.Text = "<"
        '
        'mnuAdd
        '
        Me.mnuAdd.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAdd.ForeColor = System.Drawing.Color.White
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(80, 44)
        Me.mnuAdd.Text = "Add"
        '
        'mnuDelete
        '
        Me.mnuDelete.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDelete.ForeColor = System.Drawing.Color.White
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(99, 44)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUpdate.ForeColor = System.Drawing.Color.White
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(113, 44)
        Me.mnuUpdate.Text = "Update"
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuLogOut.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLogOut.ForeColor = System.Drawing.Color.White
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(122, 44)
        Me.mnuLogOut.Text = "Log Out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 94)
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
        Me.Label2.Location = New System.Drawing.Point(70, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price :"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(125, 365)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(124, 54)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(183, 92)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(160, 32)
        Me.txtID.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(183, 148)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 32)
        Me.txtName.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(183, 207)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(160, 32)
        Me.txtPrice.TabIndex = 7
        '
        'dgvMenu
        '
        Me.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(536, 77)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.RowHeadersWidth = 62
        Me.dgvMenu.RowTemplate.Height = 28
        Me.dgvMenu.Size = New System.Drawing.Size(606, 366)
        Me.dgvMenu.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 280)
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
        Me.cboxItemType.Location = New System.Drawing.Point(222, 280)
        Me.cboxItemType.Name = "cboxItemType"
        Me.cboxItemType.Size = New System.Drawing.Size(121, 37)
        Me.cboxItemType.TabIndex = 10
        '
        'frmEditMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1196, 513)
        Me.Controls.Add(Me.cboxItemType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvMenu)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnEdit)
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
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cboxItemType As ComboBox
End Class
