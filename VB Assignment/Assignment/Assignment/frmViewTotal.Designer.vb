<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewTotal
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewTotal))
        Me.dgvFoodOrder = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMemberPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvFoodOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFoodOrder
        '
        Me.dgvFoodOrder.AllowUserToAddRows = False
        Me.dgvFoodOrder.AllowUserToDeleteRows = False
        Me.dgvFoodOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFoodOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFoodOrder.Location = New System.Drawing.Point(34, 141)
        Me.dgvFoodOrder.Name = "dgvFoodOrder"
        Me.dgvFoodOrder.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFoodOrder.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFoodOrder.RowHeadersWidth = 62
        Me.dgvFoodOrder.RowTemplate.Height = 28
        Me.dgvFoodOrder.ShowCellToolTips = False
        Me.dgvFoodOrder.ShowEditingIcon = False
        Me.dgvFoodOrder.Size = New System.Drawing.Size(749, 312)
        Me.dgvFoodOrder.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 522)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total : "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(842, 40)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBack.ForeColor = System.Drawing.Color.White
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(48, 36)
        Me.mnuBack.Text = "<"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Items"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Member Phone: "
        '
        'txtMemberPhone
        '
        Me.txtMemberPhone.BorderColor = System.Drawing.Color.Black
        Me.txtMemberPhone.BorderRadius = 13
        Me.txtMemberPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMemberPhone.DefaultText = ""
        Me.txtMemberPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMemberPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMemberPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemberPhone.DisabledState.Parent = Me.txtMemberPhone
        Me.txtMemberPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMemberPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemberPhone.FocusedState.Parent = Me.txtMemberPhone
        Me.txtMemberPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMemberPhone.ForeColor = System.Drawing.Color.Black
        Me.txtMemberPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMemberPhone.HoverState.Parent = Me.txtMemberPhone
        Me.txtMemberPhone.Location = New System.Drawing.Point(229, 58)
        Me.txtMemberPhone.Name = "txtMemberPhone"
        Me.txtMemberPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemberPhone.PlaceholderText = ""
        Me.txtMemberPhone.SelectedText = ""
        Me.txtMemberPhone.ShadowDecoration.Parent = Me.txtMemberPhone
        Me.txtMemberPhone.Size = New System.Drawing.Size(233, 36)
        Me.txtMemberPhone.TabIndex = 17
        '
        'txtTotal
        '
        Me.txtTotal.BorderColor = System.Drawing.Color.Black
        Me.txtTotal.BorderRadius = 13
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.DisabledState.Parent = Me.txtTotal
        Me.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.FocusedState.Parent = Me.txtTotal
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.HoverState.Parent = Me.txtTotal
        Me.txtTotal.Location = New System.Drawing.Point(246, 522)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.PlaceholderText = ""
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.ShadowDecoration.Parent = Me.txtTotal
        Me.txtTotal.Size = New System.Drawing.Size(233, 36)
        Me.txtTotal.TabIndex = 18
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnConfirm.BorderRadius = 20
        Me.btnConfirm.CheckedState.Parent = Me.btnConfirm
        Me.btnConfirm.CustomImages.Parent = Me.btnConfirm
        Me.btnConfirm.FillColor = System.Drawing.Color.LightGray
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.Black
        Me.btnConfirm.HoverState.Parent = Me.btnConfirm
        Me.btnConfirm.Location = New System.Drawing.Point(518, 513)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.ShadowDecoration.Parent = Me.btnConfirm
        Me.btnConfirm.Size = New System.Drawing.Size(201, 64)
        Me.btnConfirm.TabIndex = 20
        Me.btnConfirm.Text = "Comfirm"
        '
        'frmViewTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(842, 663)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtMemberPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvFoodOrder)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewTotal"
        Me.Text = "Total"
        CType(Me.dgvFoodOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvFoodOrder As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMemberPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
End Class
