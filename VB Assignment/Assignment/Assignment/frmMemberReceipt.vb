Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data

Public Class frmMemberReceipt
    Dim ordernum As Integer
    Private Sub CmnuPrint_Click(sender As Object, e As EventArgs) Handles cmnuPrint.Click

        Me.PrintForm1.Print()

    End Sub

    Sub LoadOrderNum()

        'Reference: https://www.daniweb.com/programming/software-development/threads/388157/passing-value-from-database-to-a-variable#post1671970

        Dim sqlCnn As SqlConnection
        Dim strCnn As String = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"
        sqlCnn = New SqlConnection(strCnn)
        sqlCnn.Open()
        Dim ds As SqlDataReader
        'The query is to take the Max a.k.a the latest ordernum and put it in a "table" with the column name "Latest"
        Dim comm As New SqlCommand("SELECT MAX(order_num) AS Latest From Ordering", sqlCnn)

        '' If ur using Sp then Commandtype= CommandType.StoredProcedure if it is Text then comm.CommandType=CommandType.Text
        comm.CommandType = CommandType.Text

        ds = comm.ExecuteReader
        If ds.HasRows Then
            While ds.Read
                'This will pass the item in the "Latest" column into the variable latestOrder
                ordernum = ds.Item("Latest")

            End While
        End If
        'After getting the latest orderNum, it will then add 1 into it for the new order that round
        'orderNum = (CInt(latestOrder) + 1)
        'This label is just temporary to display the orderNum
        'lblOrderNum.Text = orderNum
        ''Close your connections and commands.
        sqlCnn.Close()

    End Sub

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
WHERE order_num = '" & ordernum & "'", sqlCnn)
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



    Private Sub FrmMemberReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderNum()
        lblOrderId.Text = ordernum
        LoadItems()
        CalculateTotal()
        lblTime.Text = Now.ToLocalTime

    End Sub

    Private Sub CalculateTotal()
        Dim totalFood As Integer = 0
        Dim totalDrink As Integer = 0
        Dim total As Integer
        Dim serviceTax As Integer
        Dim discount As Integer
        Dim totalAmount As Integer

        For i As Integer = 0 To dgvFoodOrder.Rows.Count() - 1 Step +1
            totalFood = totalFood + dgvFoodOrder.Rows(i).Cells(3).Value
        Next



        total = totalDrink + totalFood
        lblTotal.Text = total.ToString

        serviceTax = total * 0.1
        lblServiceTax.Text = serviceTax.ToString

        discount = total * 0.2
        lblDiscount.Text = discount.ToString

        totalAmount = total + serviceTax - discount
        lblAmount.Text = totalAmount.ToString("C")

    End Sub

End Class