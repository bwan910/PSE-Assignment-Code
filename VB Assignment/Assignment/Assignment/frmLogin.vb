Imports System.Data.SqlClient

Public Class frmLogin
    'Dim empid As Integer

    Private Sub empload()
        'Reference: https://www.daniweb.com/programming/software-development/threads/388157/passing-value-from-database-to-a-variable#post1671970

        Dim sqlCnn As SqlConnection
        Dim strCnn As String = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"
        sqlCnn = New SqlConnection(strCnn)
        sqlCnn.Open()
        Dim ds As SqlDataReader
        'The query is to take the Max a.k.a the latest ordernum and put it in a "table" with the column name "Latest"
        Dim comm As New SqlCommand("SELECT emp_id AS EMPID From Employee Where emp_name = '" & txtName.Text & "'", sqlCnn)

        '' If ur using Sp then Commandtype= CommandType.StoredProcedure if it is Text then comm.CommandType=CommandType.Text
        '' If ur using Sp then Commandtype= CommandType.StoredProcedure if it is Text then comm.CommandType=CommandType.Text
        comm.CommandType = CommandType.Text

        ds = comm.ExecuteReader
        If ds.HasRows Then
            While ds.Read
                'This will pass the item in the "Latest" column into the variable latestOrder
                frmMenu.empid = ds.Item("EMPID")

            End While
        End If

        sqlCnn.Close()
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection



        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Database=OrderSystem;Integrated Security=True"
        'strConnectionString = "Server=BRANDON\SQLEXPRESS;Database=OrderSystem;Integrated Security=True"

        sqlCnn = New SqlConnection(strConnectionString)

        Dim sqlCmd As New SqlCommand("SELECT * FROM Employee WHERE emp_name = @emp_name AND emp_password = @emp_password", sqlCnn)
        sqlCmd.Parameters.Add("@emp_name", SqlDbType.VarChar).Value = txtName.Text
        sqlCmd.Parameters.Add("@emp_password", SqlDbType.VarChar).Value = txtPassword.Text


        Dim adapter As New SqlDataAdapter(sqlCmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        Dim message As Boolean

        If txtName.Text = "admin" And txtPassword.Text = "123" Then
            frmAdmin.Show()
            Me.Close()
        ElseIf dt.Rows.Count() <= 0 Then
            message = True
        Else
            frmMenu.Show()
            empload()
            Me.Close()
        End If

        If message = True Then
            MessageBox.Show("Not an Employee!")
        End If


    End Sub

End Class