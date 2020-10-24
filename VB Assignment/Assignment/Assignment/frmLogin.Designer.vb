<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnEnter = New Guna.UI2.WinForms.Guna2Button()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Transparent
        Me.btnEnter.BorderRadius = 20
        Me.btnEnter.CheckedState.Parent = Me.btnEnter
        Me.btnEnter.CustomImages.Parent = Me.btnEnter
        Me.btnEnter.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.Black
        Me.btnEnter.HoverState.Parent = Me.btnEnter
        Me.btnEnter.Location = New System.Drawing.Point(478, 411)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.ShadowDecoration.Parent = Me.btnEnter
        Me.btnEnter.Size = New System.Drawing.Size(202, 53)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "Login"
        '
        'txtName
        '
        Me.txtName.BorderColor = System.Drawing.Color.Transparent
        Me.txtName.BorderThickness = 0
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.LemonChiffon
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FillColor = System.Drawing.Color.Transparent
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.IconLeft = CType(resources.GetObject("txtName.IconLeft"), System.Drawing.Image)
        Me.txtName.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtName.Location = New System.Drawing.Point(467, 191)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtName.PlaceholderText = "Username"
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(235, 39)
        Me.txtName.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderThickness = 0
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.Transparent
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.IconLeft = CType(resources.GetObject("txtPassword.IconLeft"), System.Drawing.Image)
        Me.txtPassword.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtPassword.Location = New System.Drawing.Point(467, 289)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(212, 39)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(467, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 61)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cafe 123"
        '
        'cboxPassword
        '
        Me.cboxPassword.AutoSize = True
        Me.cboxPassword.BackColor = System.Drawing.Color.Transparent
        Me.cboxPassword.Location = New System.Drawing.Point(686, 298)
        Me.cboxPassword.Name = "cboxPassword"
        Me.cboxPassword.Size = New System.Drawing.Size(22, 21)
        Me.cboxPassword.TabIndex = 10
        Me.cboxPassword.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 564)
        Me.Controls.Add(Me.cboxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnEnter)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "  Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboxPassword As CheckBox
End Class
