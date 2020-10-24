<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditEmployee))
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmpName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmpPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmpPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Location = New System.Drawing.Point(472, 102)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.RowHeadersWidth = 62
        Me.dgvEmployee.RowTemplate.Height = 28
        Me.dgvEmployee.Size = New System.Drawing.Size(600, 423)
        Me.dgvEmployee.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuAdd, Me.mnuDelete, Me.mnuUpdate, Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1123, 46)
        Me.MenuStrip1.TabIndex = 1
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Phone :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID :"
        '
        'txtEmpID
        '
        Me.txtEmpID.BorderColor = System.Drawing.Color.Black
        Me.txtEmpID.BorderRadius = 13
        Me.txtEmpID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpID.DefaultText = ""
        Me.txtEmpID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmpID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmpID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpID.DisabledState.Parent = Me.txtEmpID
        Me.txtEmpID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpID.FocusedState.Parent = Me.txtEmpID
        Me.txtEmpID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpID.ForeColor = System.Drawing.Color.Black
        Me.txtEmpID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpID.HoverState.Parent = Me.txtEmpID
        Me.txtEmpID.Location = New System.Drawing.Point(171, 115)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpID.PlaceholderText = ""
        Me.txtEmpID.SelectedText = ""
        Me.txtEmpID.ShadowDecoration.Parent = Me.txtEmpID
        Me.txtEmpID.Size = New System.Drawing.Size(233, 36)
        Me.txtEmpID.TabIndex = 14
        '
        'txtEmpName
        '
        Me.txtEmpName.BorderColor = System.Drawing.Color.Black
        Me.txtEmpName.BorderRadius = 13
        Me.txtEmpName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpName.DefaultText = ""
        Me.txtEmpName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmpName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmpName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpName.DisabledState.Parent = Me.txtEmpName
        Me.txtEmpName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpName.FocusedState.Parent = Me.txtEmpName
        Me.txtEmpName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpName.ForeColor = System.Drawing.Color.Black
        Me.txtEmpName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpName.HoverState.Parent = Me.txtEmpName
        Me.txtEmpName.Location = New System.Drawing.Point(171, 189)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpName.PlaceholderText = ""
        Me.txtEmpName.SelectedText = ""
        Me.txtEmpName.ShadowDecoration.Parent = Me.txtEmpName
        Me.txtEmpName.Size = New System.Drawing.Size(233, 36)
        Me.txtEmpName.TabIndex = 15
        '
        'txtEmpPhone
        '
        Me.txtEmpPhone.BorderColor = System.Drawing.Color.Black
        Me.txtEmpPhone.BorderRadius = 13
        Me.txtEmpPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpPhone.DefaultText = ""
        Me.txtEmpPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmpPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmpPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpPhone.DisabledState.Parent = Me.txtEmpPhone
        Me.txtEmpPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpPhone.FocusedState.Parent = Me.txtEmpPhone
        Me.txtEmpPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpPhone.ForeColor = System.Drawing.Color.Black
        Me.txtEmpPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpPhone.HoverState.Parent = Me.txtEmpPhone
        Me.txtEmpPhone.Location = New System.Drawing.Point(171, 261)
        Me.txtEmpPhone.Name = "txtEmpPhone"
        Me.txtEmpPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpPhone.PlaceholderText = ""
        Me.txtEmpPhone.SelectedText = ""
        Me.txtEmpPhone.ShadowDecoration.Parent = Me.txtEmpPhone
        Me.txtEmpPhone.Size = New System.Drawing.Size(233, 36)
        Me.txtEmpPhone.TabIndex = 16
        '
        'txtEmpPassword
        '
        Me.txtEmpPassword.BorderColor = System.Drawing.Color.Black
        Me.txtEmpPassword.BorderRadius = 13
        Me.txtEmpPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpPassword.DefaultText = ""
        Me.txtEmpPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmpPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmpPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpPassword.DisabledState.Parent = Me.txtEmpPassword
        Me.txtEmpPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpPassword.FocusedState.Parent = Me.txtEmpPassword
        Me.txtEmpPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpPassword.ForeColor = System.Drawing.Color.Black
        Me.txtEmpPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpPassword.HoverState.Parent = Me.txtEmpPassword
        Me.txtEmpPassword.Location = New System.Drawing.Point(171, 340)
        Me.txtEmpPassword.Name = "txtEmpPassword"
        Me.txtEmpPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpPassword.PlaceholderText = ""
        Me.txtEmpPassword.SelectedText = ""
        Me.txtEmpPassword.ShadowDecoration.Parent = Me.txtEmpPassword
        Me.txtEmpPassword.Size = New System.Drawing.Size(233, 36)
        Me.txtEmpPassword.TabIndex = 17
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
        Me.btnEdit.Location = New System.Drawing.Point(116, 444)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(201, 64)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Update"
        '
        'frmEditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1123, 644)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtEmpPassword)
        Me.Controls.Add(Me.txtEmpPhone)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvEmployee)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmEditEmployee"
        Me.Text = "Employee Editor"
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmpID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmpName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmpPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmpPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
End Class
