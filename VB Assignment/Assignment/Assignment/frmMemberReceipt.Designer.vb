﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMemberReceipt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemberReceipt))
        Me.dgvDrinkOrder = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblServiceTax = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOrderId = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.dgvFoodOrder = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.dgvDrinkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgvFoodOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDrinkOrder
        '
        Me.dgvDrinkOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDrinkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDrinkOrder.Location = New System.Drawing.Point(69, 237)
        Me.dgvDrinkOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDrinkOrder.Name = "dgvDrinkOrder"
        Me.dgvDrinkOrder.RowHeadersWidth = 62
        Me.dgvDrinkOrder.RowTemplate.Height = 28
        Me.dgvDrinkOrder.Size = New System.Drawing.Size(402, 146)
        Me.dgvDrinkOrder.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 399)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "                   Total : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 559)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Time : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 469)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "    Discount (20%) : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 434)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Service Tax (10%) : "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.Location = New System.Drawing.Point(417, 399)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotal.Size = New System.Drawing.Size(36, 30)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "18"
        '
        'lblServiceTax
        '
        Me.lblServiceTax.AutoSize = True
        Me.lblServiceTax.BackColor = System.Drawing.Color.Transparent
        Me.lblServiceTax.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceTax.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblServiceTax.Location = New System.Drawing.Point(417, 434)
        Me.lblServiceTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServiceTax.Name = "lblServiceTax"
        Me.lblServiceTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblServiceTax.Size = New System.Drawing.Size(26, 30)
        Me.lblServiceTax.TabIndex = 8
        Me.lblServiceTax.Text = "5"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDiscount.Location = New System.Drawing.Point(417, 469)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDiscount.Size = New System.Drawing.Size(26, 30)
        Me.lblDiscount.TabIndex = 9
        Me.lblDiscount.Text = "2"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.Location = New System.Drawing.Point(74, 559)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(70, 30)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "Time "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(190, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 30)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Order ID :"
        '
        'lblOrderId
        '
        Me.lblOrderId.AutoSize = True
        Me.lblOrderId.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderId.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOrderId.Location = New System.Drawing.Point(321, 9)
        Me.lblOrderId.Name = "lblOrderId"
        Me.lblOrderId.Size = New System.Drawing.Size(49, 30)
        Me.lblOrderId.TabIndex = 14
        Me.lblOrderId.Text = "100"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuPrint})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(121, 34)
        '
        'cmnuPrint
        '
        Me.cmnuPrint.Name = "cmnuPrint"
        Me.cmnuPrint.Size = New System.Drawing.Size(120, 30)
        Me.cmnuPrint.Text = "Print"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'dgvFoodOrder
        '
        Me.dgvFoodOrder.AllowUserToAddRows = False
        Me.dgvFoodOrder.AllowUserToDeleteRows = False
        Me.dgvFoodOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFoodOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFoodOrder.Location = New System.Drawing.Point(69, 49)
        Me.dgvFoodOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFoodOrder.Name = "dgvFoodOrder"
        Me.dgvFoodOrder.ReadOnly = True
        Me.dgvFoodOrder.RowHeadersWidth = 62
        Me.dgvFoodOrder.RowTemplate.Height = 28
        Me.dgvFoodOrder.ShowCellToolTips = False
        Me.dgvFoodOrder.ShowEditingIcon = False
        Me.dgvFoodOrder.Size = New System.Drawing.Size(402, 146)
        Me.dgvFoodOrder.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-42, 520)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(852, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAmount.Location = New System.Drawing.Point(387, 520)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAmount.Size = New System.Drawing.Size(76, 30)
        Me.lblAmount.TabIndex = 17
        Me.lblAmount.Text = "RM 21"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmMemberReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(533, 610)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvFoodOrder)
        Me.Controls.Add(Me.lblOrderId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblServiceTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDrinkOrder)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMemberReceipt"
        Me.Text = "Receipt"
        CType(Me.dgvDrinkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgvFoodOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDrinkOrder As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblServiceTax As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOrderId As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents cmnuPrint As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents dgvFoodOrder As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
