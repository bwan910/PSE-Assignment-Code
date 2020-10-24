<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChart
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cboxOption = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Silver
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(100, 176)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(463, 264)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Food Chart"
        Title1.Name = "Food Chart"
        Title1.Text = "Food Chart"
        Title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow
        Me.Chart1.Titles.Add(Title1)
        '
        'cboxOption
        '
        Me.cboxOption.BackColor = System.Drawing.Color.Transparent
        Me.cboxOption.BorderRadius = 20
        Me.cboxOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboxOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxOption.FillColor = System.Drawing.Color.LightGray
        Me.cboxOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboxOption.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboxOption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboxOption.FocusedState.Parent = Me.cboxOption
        Me.cboxOption.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboxOption.ForeColor = System.Drawing.Color.Black
        Me.cboxOption.HoverState.Parent = Me.cboxOption
        Me.cboxOption.ItemHeight = 30
        Me.cboxOption.Items.AddRange(New Object() {"Food", "Beverage"})
        Me.cboxOption.ItemsAppearance.Parent = Me.cboxOption
        Me.cboxOption.Location = New System.Drawing.Point(281, 69)
        Me.cboxOption.Name = "cboxOption"
        Me.cboxOption.ShadowDecoration.Parent = Me.cboxOption
        Me.cboxOption.Size = New System.Drawing.Size(170, 36)
        Me.cboxOption.TabIndex = 2
        Me.cboxOption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(778, 564)
        Me.Controls.Add(Me.cboxOption)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "frmChart"
        Me.Text = "Charts"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents cboxOption As Guna.UI2.WinForms.Guna2ComboBox
End Class
