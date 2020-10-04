<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvFood = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.dgvDrink = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuLogOut})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 46)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.BackColor = System.Drawing.Color.Transparent
        Me.mnuBack.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBack.ForeColor = System.Drawing.Color.White
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(41, 42)
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
        'dgvFood
        '
        Me.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFood.Location = New System.Drawing.Point(54, 105)
        Me.dgvFood.Name = "dgvFood"
        Me.dgvFood.RowHeadersWidth = 62
        Me.dgvFood.RowTemplate.Height = 28
        Me.dgvFood.Size = New System.Drawing.Size(318, 325)
        Me.dgvFood.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.Font = New System.Drawing.Font("STCaiyun", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.Location = New System.Drawing.Point(303, 453)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(183, 45)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit Database"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'dgvDrink
        '
        Me.dgvDrink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDrink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDrink.Location = New System.Drawing.Point(422, 105)
        Me.dgvDrink.Name = "dgvDrink"
        Me.dgvDrink.RowHeadersWidth = 62
        Me.dgvDrink.RowTemplate.Height = 28
        Me.dgvDrink.Size = New System.Drawing.Size(318, 325)
        Me.dgvDrink.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Food"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(546, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Drink"
        '
        'frmViewMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 522)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDrink)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvFood)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmViewMenu"
        Me.Text = "Menu Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents dgvFood As DataGridView
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents btnEdit As Button
    Friend WithEvents dgvDrink As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
