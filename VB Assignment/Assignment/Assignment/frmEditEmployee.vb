Imports System.Data.SqlClient
Imports System.Data

Public Class frmEditEmployee
    Dim edit ' Variable for add, update and delete button index

    ' For back button 
    Private Sub MnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        frmViewEmployee.Show()
        Me.Close()
    End Sub

    ' For log out button 
    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    ' For add button 
    Private Sub MnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        LoadEmployee()
        edit = 1
        btnEdit.Visible = True
        btnEdit.Text = "Add"
        txtEmpID.Enabled = False
        txtEmpName.Enabled = True
        txtEmpPassword.Enabled = True
        txtEmpPhone.Enabled = True
    End Sub

    ' For delete button 
    Private Sub MnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        LoadEmployee()
        edit = 2
        btnEdit.Visible = True
        btnEdit.Text = "Delete"
        txtEmpID.Enabled = True
        txtEmpName.Enabled = False
        txtEmpPassword.Enabled = False
        txtEmpPhone.Enabled = False
    End Sub

    ' For update button 
    Private Sub MnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        LoadEmployee()
        edit = 3
        btnEdit.Visible = True
        btnEdit.Text = "Update"
        txtEmpID.Enabled = True
        txtEmpName.Enabled = True
        txtEmpPassword.Enabled = True
        txtEmpPhone.Enabled = True
    End Sub

    ' For add employee to db function 
    Sub AddEmployee()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        strSql = "Insert into Employee([emp_name],[emp_phone],[emp_password]) values('" & txtEmpName.Text & "', '" & txtEmpPhone.Text & "', '" & txtEmpPassword.Text & "')"

        sqlCnn = New SqlConnection(strConnectionString)
        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
            MessageBox.Show("Record is sucessfully added !")
        Catch ex As Exception
            MessageBox.Show("Cannot open connection !")
        End Try
    End Sub

    ' For delete employee in db function 
    Sub DeleteEmployee()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        strSql = "Delete from Employee where emp_id = '" & txtEmpID.Text & "'"

        sqlCnn = New SqlConnection(strConnectionString)

        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
            MessageBox.Show("Record is sucessfully updated !")
        Catch ex As Exception
            MessageBox.Show("Cannot open connection !")
        End Try
    End Sub

    ' For update employee from db function 
    Sub UpdateEmployee()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        strSql = "Update Employee Set emp_name = '" & txtEmpName.Text & "', emp_phone = '" & txtEmpPhone.Text & "', emp_password = '" & txtEmpPassword.Text & "' WHERE emp_id = '" & txtEmpID.Text & "'"

        sqlCnn = New SqlConnection(strConnectionString)

        Try
            sqlCnn.Open()
            sqlCmd = New SqlCommand(strSql, sqlCnn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlCnn.Close()
            MessageBox.Show("Record is sucessfully updated !")
        Catch ex As Exception
            MessageBox.Show("Cannot open connection !")
        End Try
    End Sub

    ' For display employee from DB
    Sub LoadEmployee()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim MyCmdBld As New SqlCommandBuilder
        Dim ds As New DataSet
        Dim EmployeeTable As New DataTable

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        adapter = New SqlDataAdapter("SELECT * FROM Employee", sqlCnn)
        MyCmdBld = New SqlCommandBuilder(adapter)
        EmployeeTable = New DataTable
        adapter.Fill(EmployeeTable)
        dgvEmployee.DataSource = EmployeeTable
        dgvEmployee.Columns(0).HeaderText = "Employee ID"
        dgvEmployee.Columns(1).HeaderText = "Employee Name"
        dgvEmployee.Columns(2).HeaderText = "Employee Phone"
        dgvEmployee.Columns(3).HeaderText = "Employee Password"
        sqlCnn.Close()
    End Sub

    ' For Edit Button. This button shares the Add, Delete Update function
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If edit = 1 Then
            LoadEmployee()
            AddEmployee()
            txtEmpID.Clear()
            txtEmpName.Clear()
            txtEmpPassword.Clear()
            txtEmpPhone.Clear()
            LoadEmployee()

        ElseIf edit = 2 Then
            LoadEmployee()
            DeleteEmployee()
            txtEmpID.Clear()
            txtEmpName.Clear()
            txtEmpPassword.Clear()
            txtEmpPhone.Clear()
            LoadEmployee()

        ElseIf edit = 3 Then
            LoadEmployee()
            UpdateEmployee()
            txtEmpID.Clear()
            txtEmpName.Clear()
            txtEmpPassword.Clear()
            txtEmpPhone.Clear()
            LoadEmployee()

        End If
    End Sub

    Private Sub DgvEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellContentClick
        LoadEmployee()
    End Sub

    Private Sub frmEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class