Imports System.Data.SqlClient
Imports System.Data
Public Class frmViewCustomer
    Private Sub MnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEditCustomer.Show()
        Me.Close()

    End Sub

    Sub LoadCustomer()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim MyCmdBld As New SqlCommandBuilder
        Dim ds As New DataSet
        Dim CustomerTable As New DataTable

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        adapter = New SqlDataAdapter("SELECT * FROM Member", sqlCnn)
        MyCmdBld = New SqlCommandBuilder(adapter)
        CustomerTable = New DataTable
        adapter.Fill(CustomerTable)
        dgvCustomer.DataSource = CustomerTable
        dgvCustomer.Columns(0).HeaderText = "Member ID"
        dgvCustomer.Columns(1).HeaderText = "Member Name"
        dgvCustomer.Columns(2).HeaderText = "Member Phone"

        sqlCnn.Close()
    End Sub

    Private Sub FrmViewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
    End Sub
End Class