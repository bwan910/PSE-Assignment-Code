<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditCustomer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCustomerID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCustomerPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuAdd, Me.mnuDelete, Me.mnuUpdate, Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1123, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.BackColor = System.Drawing.Color.Black
        Me.mnuBack.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBack.ForeColor = System.Drawing.Color.White
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(45, 35)
        Me.mnuBack.Text = "<"
        '
        'mnuAdd
        '
        Me.mnuAdd.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAdd.ForeColor = System.Drawing.Color.White
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(72, 35)
        Me.mnuAdd.Text = "Add"
        '
        'mnuDelete
        '
        Me.mnuDelete.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDelete.ForeColor = System.Drawing.Color.White
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(98, 35)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUpdate.ForeColor = System.Drawing.Color.White
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(105, 35)
        Me.mnuUpdate.Text = "Update"
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
        'dgvCustomer
        '
        Me.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(475, 108)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersWidth = 62
        Me.dgvCustomer.RowTemplate.Height = 28
        Me.dgvCustomer.Size = New System.Drawing.Size(596, 451)
        Me.dgvCustomer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Phone :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MemberID :"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderColor = System.Drawing.Color.Black
        Me.txtCustomerName.BorderRadius = 13
        Me.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerName.DefaultText = ""
        Me.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerName.DisabledState.Parent = Me.txtCustomerName
        Me.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerName.FocusedState.Parent = Me.txtCustomerName
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomerName.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerName.HoverState.Parent = Me.txtCustomerName
        Me.txtCustomerName.Location = New System.Drawing.Point(168, 197)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomerName.PlaceholderText = ""
        Me.txtCustomerName.SelectedText = ""
        Me.txtCustomerName.ShadowDecoration.Parent = Me.txtCustomerName
        Me.txtCustomerName.Size = New System.Drawing.Size(233, 36)
        Me.txtCustomerName.TabIndex = 15
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BorderColor = System.Drawing.Color.Black
        Me.txtCustomerID.BorderRadius = 13
        Me.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerID.DefaultText = ""
        Me.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerID.DisabledState.Parent = Me.txtCustomerID
        Me.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerID.FocusedState.Parent = Me.txtCustomerID
        Me.txtCustomerID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomerID.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerID.HoverState.Parent = Me.txtCustomerID
        Me.txtCustomerID.Location = New System.Drawing.Point(168, 122)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomerID.PlaceholderText = ""
        Me.txtCustomerID.SelectedText = ""
        Me.txtCustomerID.ShadowDecoration.Parent = Me.txtCustomerID
        Me.txtCustomerID.Size = New System.Drawing.Size(233, 36)
        Me.txtCustomerID.TabIndex = 16
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.BorderColor = System.Drawing.Color.Black
        Me.txtCustomerPhone.BorderRadius = 13
        Me.txtCustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerPhone.DefaultText = ""
        Me.txtCustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerPhone.DisabledState.Parent = Me.txtCustomerPhone
        Me.txtCustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerPhone.FocusedState.Parent = Me.txtCustomerPhone
        Me.txtCustomerPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomerPhone.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerPhone.HoverState.Parent = Me.txtCustomerPhone
        Me.txtCustomerPhone.Location = New System.Drawing.Point(168, 282)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomerPhone.PlaceholderText = ""
        Me.txtCustomerPhone.SelectedText = ""
        Me.txtCustomerPhone.ShadowDecoration.Parent = Me.txtCustomerPhone
        Me.txtCustomerPhone.Size = New System.Drawing.Size(233, 36)
        Me.txtCustomerPhone.TabIndex = 17
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
        Me.btnEdit.Location = New System.Drawing.Point(119, 437)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(201, 64)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.Text = "Update"
        '
        'frmEditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1123, 644)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtCustomerPhone)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmEditCustomer"
        Me.Text = "Customer Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCustomerID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCustomerPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
End Class
