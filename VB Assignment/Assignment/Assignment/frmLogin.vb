Imports System.Data.SqlClient

Public Class frmLogin
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
            frmDailySpecial.Show()
            Me.Close()
        End If

        If message = True Then
            MessageBox.Show("Not an Employee!")
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class