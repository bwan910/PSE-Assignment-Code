Imports System.Data.SqlClient
Imports System.Data

Public Class frmViewTotal
    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"


        sqlCnn = New SqlConnection(strConnectionString)
        strSql = "UPDATE FoodOrder SET CustomerID = '" & txtCustomerID.Text & "' WHERE OrderID = 100; UPDATE DrinkOrder SET CustomerID = '" & txtCustomerID.Text & "' WHERE OrderID = 100"
        sqlCnn.Open()
        sqlCmd = New SqlCommand(strSql, sqlCnn)
        sqlCmd.ExecuteNonQuery()
        sqlCmd.Dispose()
        sqlCnn.Close()

        CheckMember()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuBack.Click

        frmMenu.Show()
        Me.Close()

    End Sub

    Private Sub FrmViewTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadFoodOrder()
        LoadDrinkOrder()
        CalculateTotal()

    End Sub


    Private Sub LoadFoodOrder()

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim MyCmdBld As New SqlCommandBuilder
        Dim ds As New DataSet
        Dim FoodOrderTable As New DataTable

        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"


        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        adapter = New SqlDataAdapter("SELECT FoodOrder.FoodID,Food.FoodName,FoodOrder.Quantity,FoodOrder.totalFood
FROM FoodOrder
JOIN Food ON FoodOrder.FoodID = Food.FoodID
WHERE OrderID = 100", sqlCnn)
        MyCmdBld = New SqlCommandBuilder(adapter)
        FoodOrderTable = New DataTable
        adapter.Fill(FoodOrderTable)
        dgvFoodOrder.DataSource = FoodOrderTable
        dgvFoodOrder.Columns(0).HeaderText = "FoodID"
        dgvFoodOrder.Columns(1).HeaderText = "Name"
        dgvFoodOrder.Columns(2).HeaderText = "Quantity"
        dgvFoodOrder.Columns(3).HeaderText = "Total Price"
        sqlCnn.Close()

    End Sub

    Private Sub LoadDrinkOrder()

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim MyCmdBld As New SqlCommandBuilder
        Dim ds As New DataSet
        Dim DrinkOrderTable As New DataTable

        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"


        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        adapter = New SqlDataAdapter("SELECT DrinkOrder.DrinkID,Drink.DrinkName,DrinkOrder.Quantity,DrinkOrder.totalDrink
FROM DrinkOrder
JOIN Drink ON DrinkOrder.DrinkID = Drink.DrinkID
WHERE OrderID = 100", sqlCnn)
        MyCmdBld = New SqlCommandBuilder(adapter)
        DrinkOrderTable = New DataTable
        adapter.Fill(DrinkOrderTable)
        dgvDrinkOrder.DataSource = DrinkOrderTable
        dgvDrinkOrder.Columns(0).HeaderText = "DrinkID"
        dgvDrinkOrder.Columns(1).HeaderText = "Name"
        dgvDrinkOrder.Columns(2).HeaderText = "Quantity"
        dgvDrinkOrder.Columns(3).HeaderText = "Total Price"
        sqlCnn.Close()

    End Sub

    Private Sub CalculateTotal()
        Dim totalFood As Integer = 0
        Dim totalDrink As Integer = 0
        Dim total As Integer = 0

        For i As Integer = 0 To dgvFoodOrder.Rows.Count() - 1 Step +1
            totalFood = totalFood + dgvFoodOrder.Rows(i).Cells(3).Value
        Next

        For i As Integer = 0 To dgvDrinkOrder.Rows.Count() - 1 Step +1
            totalDrink = totalDrink + dgvDrinkOrder.Rows(i).Cells(3).Value
        Next

        total = totalDrink + totalFood
        txtTotal.Text = total.ToString("C")

    End Sub

    Private Sub CheckMember()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"


        sqlCnn = New SqlConnection(strConnectionString)

        Dim sqlCmd As New SqlCommand("SELECT MemberID FROM Customer WHERE CustomerID = @CustomerID", sqlCnn)
        sqlCmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = txtCustomerID.Text


        Dim adapter As New SqlDataAdapter(sqlCmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)


        If dt.Rows(0).IsNull(0) = False Then
            frmMemberReceipt.Show()
            Me.Close()
        Else
            frmReceipt.Show()
            Me.Close()
        End If


    End Sub

End Class