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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuAdd, Me.mnuDelete, Me.mnuUpdate, Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(835, 39)
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
        Me.dgvCustomer.Location = New System.Drawing.Point(434, 81)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersWidth = 62
        Me.dgvCustomer.RowTemplate.Height = 28
        Me.dgvCustomer.Size = New System.Drawing.Size(360, 413)
        Me.dgvCustomer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 208)
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
        Me.Label3.Location = New System.Drawing.Point(12, 148)
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
        Me.Label4.Location = New System.Drawing.Point(12, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MemberID :"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.Location = New System.Drawing.Point(114, 311)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(132, 54)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(175, 85)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(220, 32)
        Me.txtCustomerID.TabIndex = 7
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(114, 148)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(220, 32)
        Me.txtCustomerName.TabIndex = 8
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerPhone.Location = New System.Drawing.Point(118, 208)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(220, 32)
        Me.txtCustomerPhone.TabIndex = 9
        '
        'frmEditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 521)
        Me.Controls.Add(Me.txtCustomerPhone)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.btnEdit)
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
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerPhone As TextBox
End Class
