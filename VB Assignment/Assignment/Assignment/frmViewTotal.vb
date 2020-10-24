Imports System.Data.SqlClient
Imports System.Data

Public Class frmViewTotal

    Dim memberid As Integer
    Dim ordernum As Integer
    Private Sub Loadmember()
        'Reference: https://www.daniweb.com/programming/software-development/threads/388157/passing-value-from-database-to-a-variable#post1671970

        Dim sqlCnn As SqlConnection
        Dim strCnn As String = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"
        sqlCnn = New SqlConnection(strCnn)
        sqlCnn.Open()
        Dim ds As SqlDataReader
        'The query is to take the Max a.k.a the latest ordernum and put it in a "table" with the column name "Latest"
        Dim comm As New SqlCommand("SELECT member_id AS MEMBERID From Member Where member_phone = '" & txtMemberPhone.Text & "'", sqlCnn)

        '' If ur using Sp then Commandtype= CommandType.StoredProcedure if it is Text then comm.CommandType=CommandType.Text
        comm.CommandType = CommandType.Text

        ds = comm.ExecuteReader
        If ds.HasRows Then
            While ds.Read
                'This will pass the item in the "Latest" column into the variable latestOrder
                memberid = ds.Item("MEMBERID")

            End While
        Else
            memberid = 0
        End If

        sqlCnn.Close()
    End Sub

    ' To update memberid in the ordering table
    Private Sub UpdateMemberID()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        strSql = "Update Ordering Set member_id = '" & memberid & "' Where order_num = '" & ordernum & "' "

        sqlCnn = New SqlConnection(strConnectionString)

        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        Catch ex As Exception
            'MessageBox.Show("Cannot open connection !")
        End Try
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuBack.Click

        frmMenu.Show()
        Me.Close()

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


    Private Sub FrmViewTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderNum()
        LoadItems()
        CalculateTotal()

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
WHERE order_num = '" & ordernum & "' ", sqlCnn)
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


    Private Sub CalculateTotal()
        Dim totalFood As Integer = 0
        Dim totalDrink As Integer = 0
        Dim total As Integer = 0

        For i As Integer = 0 To dgvFoodOrder.Rows.Count() - 1 Step +1
            totalFood = totalFood + dgvFoodOrder.Rows(i).Cells(3).Value
        Next

        total = totalDrink + totalFood
        txtTotal.Text = total.ToString("C")

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Loadmember()

        'Dim strConnectionString As String
        'Dim sqlCnn As SqlConnection
        'Dim sqlCmd As SqlCommand
        'Dim adapter As New SqlDataAdapter
        'Dim ds As New DataSet
        'Dim strSql As String

        'strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"


        'sqlCnn = New SqlConnection(strConnectionString)
        'strSql = "UPDATE Ordering SET member_id = '" & memberid & "' WHERE order_num = '" & ordernum & "';"
        'sqlCnn.Open()
        'sqlCmd = New SqlCommand(strSql, sqlCnn)
        'sqlCmd.ExecuteNonQuery()
        'sqlCmd.Dispose()
        'sqlCnn.Close()

        If memberid = 0 Then
            frmReceipt.Show()
            Me.Close()
        Else
            UpdateMemberID()
            frmMemberReceipt.Show()
            Me.Close()
        End If
    End Sub


End Class