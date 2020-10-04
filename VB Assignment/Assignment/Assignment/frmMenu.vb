Imports System.Data.SqlClient
Imports System.Data

Public Class frmMenu

    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub MnuDailySpecial_Click(sender As Object, e As EventArgs) Handles mnuDailySpecial.Click
        frmDailySpecial.Show()
        Me.Close()
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
            strSql = "INSERT INTO FoodOrder([OrderID],[FoodID],[Quantity],[totalFood]) VALUES('100','3','" & CInt(nudCake.Value) & "','" & CInt(nudCake.Value * 3) & "')"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudJuice.Value > 0) Then
            strSql = "INSERT INTO DrinkOrder([OrderID],[DrinkID],[Quantity],[totalDrink]) VALUES('100','3','" & CInt(nudJuice.Value) & "','" & CInt(nudJuice.Value * 2) & "')"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudLatte.Value > 0) Then
            strSql = "INSERT INTO DrinkOrder([OrderID],[DrinkID],[Quantity],[totalDrink]) VALUES('100','2','" & CInt(nudLatte.Value) & "','" & CInt(nudLatte.Value * 3) & "')"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudLemonade.Value > 0) Then
            strSql = "INSERT INTO DrinkOrder([OrderID],[DrinkID],[Quantity],[totalDrink]) VALUES('100','1','" & CInt(nudLemonade.Value) & "','" & CInt(nudLemonade.Value * 2) & "')"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudPizza.Value > 0) Then
            strSql = "INSERT INTO FoodOrder([OrderID],[FoodID],[Quantity],[totalFood]) VALUES('100','1','" & CInt(nudPizza.Value) & "','" & CInt(nudPizza.Value * 5) & "')"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        If (nudRamen.Value > 0) Then
            strSql = "INSERT INTO FoodOrder([OrderID],[FoodID],[Quantity],[totalFood]) VALUES('100','2','" & CInt(nudRamen.Value) & "','" & CInt(nudRamen.Value * 6) & "')"
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
        End If

        frmViewTotal.Show()
        Me.Close()

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class