<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewCustomer))
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(44, 91)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersWidth = 62
        Me.dgvCustomer.RowTemplate.Height = 28
        Me.dgvCustomer.Size = New System.Drawing.Size(706, 315)
        Me.dgvCustomer.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 46)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBack.ForeColor = System.Drawing.Color.White
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(44, 42)
        Me.mnuBack.Text = "<"
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuLogOut.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLogOut.ForeColor = System.Drawing.Color.White
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(118, 42)
        Me.mnuLogOut.Text = "Log Out"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.Font = New System.Drawing.Font("STCaiyun", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.Location = New System.Drawing.Point(302, 430)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(196, 48)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit Database"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'frmViewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmViewCustomer"
        Me.Text = "Customer Editor"
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents btnEdit As Button
    Friend WithEvents mnuLogOut As ToolStripMenuItem
End Class
