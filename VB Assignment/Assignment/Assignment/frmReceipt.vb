Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data

Public Class frmReceipt
    Private Sub CmnuPrint_Click(sender As Object, e As EventArgs) Handles cmnuPrint.Click

        Me.PrintForm1.Print()

    End Sub

    'Private Sub frmReceipt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    '    Dim strConnectionString As String
    '    Dim sqlCnn As SqlConnection
    '    Dim sqlCmd As SqlCommand
    '    Dim adapter As New SqlDataAdapter
    '    Dim ds As New DataSet
    '    Dim strSql As String

    '    strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"


    '    sqlCnn = New SqlConnection(strConnectionString)

    '    strSql = "DELETE FROM FoodOrder DELETE FROM DrinkOrder"
    '    sqlCnn.Open()
    '    sqlCmd = New SqlCommand(strSql, sqlCnn)
    '    sqlCmd.ExecuteNonQuery()
    '    sqlCmd.Dispose()
    '    sqlCnn.Close()

    'End Sub

    Private Sub LoadItems()

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim MyCmdBld As New SqlCommandBuilder
        Dim ds As New DataSet
        Dim FoodOrderTable As New DataTable

        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"


        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        adapter = New SqlDataAdapter("SELECT Menu.item_id,Menu.item_name,Ordering.quantity,Ordering.total_price
FROM Ordering 
JOIN Menu ON Ordering.item_id = Menu.item_id
WHERE order_num = '" & frmMenu.orderNum & "' ", sqlCnn)
        MyCmdBld = New SqlCommandBuilder(adapter)
        FoodOrderTable = New DataTable
        adapter.Fill(FoodOrderTable)
        dgvFoodOrder.DataSource = FoodOrderTable
        dgvFoodOrder.Columns(0).HeaderText = "Item ID"
        dgvFoodOrder.Columns(1).HeaderText = "Item Name"
        dgvFoodOrder.Columns(2).HeaderText = "Quantity"
        dgvFoodOrder.Columns(3).HeaderText = "Total Price"
        sqlCnn.Close()

    End Sub


    Private Sub FrmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadItems()
        CalculateTotal()
        lblTime.Text = Now.ToLocalTime

    End Sub

    Private Sub CalculateTotal()
        Dim totalFood As Integer = 0
        Dim totalDrink As Integer = 0
        Dim total As Integer
        Dim serviceTax As Integer
        Dim totalAmount As Integer

        For i As Integer = 0 To dgvFoodOrder.Rows.Count() - 1 Step +1
            totalFood = totalFood + dgvFoodOrder.Rows(i).Cells(3).Value
        Next



        total = totalDrink + totalFood
        lblTotal.Text = total.ToString

        serviceTax = total * 0.1
        lblServiceTax.Text = serviceTax.ToString

        totalAmount = total + serviceTax
        lblAmount.Text = totalAmount.ToString("C")

    End Sub


End Class