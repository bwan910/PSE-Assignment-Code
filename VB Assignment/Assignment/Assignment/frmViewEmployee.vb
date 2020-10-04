Imports System.Data.SqlClient
Imports System.Data
Public Class frmViewEmployee
    Private Sub MnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEditEmployee.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellContentClick
        LoadEmployee()
    End Sub

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
        'dgvEmployee.Columns(2).HeaderText = "Employee Age"
        dgvEmployee.Columns(2).HeaderText = "Employee Phone"
        dgvEmployee.Columns(3).HeaderText = "Employee Password"

        sqlCnn.Close()
    End Sub

    Private Sub FrmViewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployee()
    End Sub
End Class