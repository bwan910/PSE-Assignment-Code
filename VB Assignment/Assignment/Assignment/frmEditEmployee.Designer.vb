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
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtEmpPhone = New System.Windows.Forms.TextBox()
        Me.txtEmpPassword = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Location = New System.Drawing.Point(470, 64)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.RowHeadersWidth = 62
        Me.dgvEmployee.RowTemplate.Height = 28
        Me.dgvEmployee.Size = New System.Drawing.Size(421, 423)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(916, 46)
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
        Me.Label2.Location = New System.Drawing.Point(45, 159)
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
        Me.Label4.Location = New System.Drawing.Point(44, 303)
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
        Me.Label5.Location = New System.Drawing.Point(42, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Phone :"
        '
        'txtEmpName
        '
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(147, 159)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(224, 32)
        Me.txtEmpName.TabIndex = 8
        '
        'txtEmpPhone
        '
        Me.txtEmpPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpPhone.Location = New System.Drawing.Point(147, 233)
        Me.txtEmpPhone.Name = "txtEmpPhone"
        Me.txtEmpPhone.Size = New System.Drawing.Size(224, 32)
        Me.txtEmpPhone.TabIndex = 10
        '
        'txtEmpPassword
        '
        Me.txtEmpPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpPassword.Location = New System.Drawing.Point(184, 300)
        Me.txtEmpPassword.Name = "txtEmpPassword"
        Me.txtEmpPassword.Size = New System.Drawing.Size(224, 32)
        Me.txtEmpPassword.TabIndex = 11
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(221, 415)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(111, 47)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID :"
        '
        'txtEmpID
        '
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(108, 97)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(224, 32)
        Me.txtEmpID.TabIndex = 7
        '
        'frmEditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 517)
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
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents txtEmpPhone As TextBox
    Friend WithEvents txtEmpPassword As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmpID As TextBox
End Class
