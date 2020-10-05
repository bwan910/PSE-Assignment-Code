Imports System.Data.SqlClient
Imports System.Data

Public Class frmMenu

    'These variable is declared here because we need to use it throughout the form
    Dim latestOrder As String
    Public orderNum As Integer
    Public empid As Integer


    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub MnuDailySpecial_Click(sender As Object, e As EventArgs) Handles mnuDailySpecial.Click
        frmDailySpecial.Show()
        Me.Close()
    End Sub

    'This is the function to pull the query from our database
    Private Sub LoadOrderNum()

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
                latestOrder = ds.Item("Latest")

            End While
        End If
        'After getting the latest orderNum, it will then add 1 into it for the new order that round
        orderNum = (CInt(latestOrder) + 1)
        'This label is just temporary to display the orderNum
        lblOrderNum.Text = orderNum
        ''Close your connections and commands.
        sqlCnn.Close()

    End Sub

    Private Sub MnuCart_Click(sender As Object, e As EventArgs) Handles mnuCart.Click

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"


        sqlCnn = New SqlConnection(strConnectionString)

        If (nudCake.Value > 0) Then
            strSql = "INSERT INTO Ordering([order_num],[item_id],[quantity],[total_price],[emp_id]) VALUES('" & orderNum & "','1','" & CInt(nudCake.Value) & "','" & CInt(nudCake.Value * 3) & "', '" & empid & "')"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudJuice.Value > 0) Then
            'strSql = "INSERT INTO DrinkOrder([OrderID],[DrinkID],[Quantity],[totalDrink]) VALUES('100','3','" & CInt(nudJuice.Value) & "','" & CInt(nudJuice.Value * 2) & "')"
            strSql = "INSERT INTO Ordering([order_num],[item_id],[quantity],[total_price],[emp_id]) VALUES('" & orderNum & "','2','" & CInt(nudJuice.Value) & "', '" & CInt(nudJuice.Value * 2) & "','" & empid & "');"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudLatte.Value > 0) Then
            'strSql = "INSERT INTO DrinkOrder([OrderID],[DrinkID],[Quantity],[totalDrink]) VALUES('100','2','" & CInt(nudLatte.Value) & "','" & CInt(nudLatte.Value * 3) & "')"
            strSql = "INSERT INTO Ordering([order_num],[item_id],[quantity],[total_price],[emp_id]) VALUES('" & orderNum & "','3','" & CInt(nudLatte.Value) & "', '" & CInt(nudLatte.Value * 3) & "', '" & empid & "');"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudLemonade.Value > 0) Then
            'strSql = "INSERT INTO DrinkOrder([OrderID],[DrinkID],[Quantity],[totalDrink]) VALUES('100','1','" & CInt(nudLemonade.Value) & "','" & CInt(nudLemonade.Value * 2) & "')"
            strSql = "INSERT INTO Ordering([order_num],[item_id],[quantity],[total_price],[emp_id]) VALUES('" & orderNum & "','4','" & CInt(nudLemonade.Value) & "', '" & CInt(nudLemonade.Value * 2) & "', '" & empid & "');"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudPizza.Value > 0) Then
            strSql = "INSERT INTO Ordering([order_num],[item_id],[quantity],[total_price],[emp_id]) VALUES('" & orderNum & "','5','" & CInt(nudPizza.Value) & "','" & CInt(nudPizza.Value * 5) & "', '" & empid & "');"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudRamen.Value > 0) Then
            strSql = "INSERT INTO Ordering([order_num],[item_id],[quantity],[total_price],[emp_id]) VALUES('" & orderNum & "','6','" & CInt(nudRamen.Value) & "','" & CInt(nudRamen.Value * 6) & "', '" & empid & "');"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        'frmAdmin.Show()
        frmViewTotal.Show()
        Me.Close()

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call the LoadOrderNum() function for every time the form loads
        LoadOrderNum()
        lblEmpId.Text = empid

    End Sub
End Class