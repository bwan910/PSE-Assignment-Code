Imports System.Data.SqlClient
Imports System.Data
Public Class frmEditCustomer
    Dim edit
    Private Sub MnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click

        Me.Close()
    End Sub

    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub MnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        LoadCustomer()
        edit = 1
        btnEdit.Visible = True
        btnEdit.Text = "Add"
        txtCustomerID.Enabled = False
        txtCustomerName.Enabled = True
        txtCustomerPhone.Enabled = True
    End Sub

    Private Sub MnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        LoadCustomer()
        edit = 2
        btnEdit.Visible = True
        btnEdit.Text = "Delete"
        txtCustomerID.Enabled = True
        txtCustomerName.Enabled = False
        txtCustomerPhone.Enabled = False
    End Sub

    Private Sub MnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        LoadCustomer()
        edit = 3
        btnEdit.Visible = True
        btnEdit.Text = "Update"
        txtCustomerID.Enabled = True
        txtCustomerName.Enabled = True
        txtCustomerPhone.Enabled = True
    End Sub

    Sub AddCustomer()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        If txtCustomerName.Text.Length > 0 And txtCustomerName.Text.Length < 30 AndAlso
            txtCustomerPhone.Text.Length > 0 And txtCustomerPhone.Text.Length < 12 Then
            strSql = "Insert into Member([member_name],[member_phone]) values('" & txtCustomerName.Text & "','" & txtCustomerPhone.Text & "')"
        Else
            MessageBox.Show("Please be sure you fill in all data and ensure your text length is not too long")
        End If

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

    Sub DeleteCustomer()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        strSql = "Delete from Member where member_id = '" & txtCustomerID.Text & "'"

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

    Sub UpdateCustomer()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        If txtCustomerName.Text.Length > 0 And txtCustomerName.Text.Length < 30 AndAlso
            txtCustomerPhone.Text.Length > 0 And txtCustomerPhone.Text.Length < 12 Then
            strSql = "Update Member Set member_name = '" & txtCustomerName.Text & "', member_phone = '" & txtCustomerPhone.Text & "' Where member_id = '" & txtCustomerID.Text & "' "
        Else
            MessageBox.Show("Please be sure you fill in all data and ensure your text length is not too long")
        End If

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


    Private Sub FrmEditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomer()
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If edit = 1 Then
            LoadCustomer()
            AddCustomer()
            txtCustomerID.Clear()
            txtCustomerName.Clear()
            txtCustomerPhone.Clear()
            LoadCustomer()

        ElseIf edit = 2 Then
            LoadCustomer()
            DeleteCustomer()
            txtCustomerID.Clear()
            txtCustomerName.Clear()
            txtCustomerPhone.Clear()
            LoadCustomer()
        ElseIf edit = 3 Then
            LoadCustomer()
            UpdateCustomer()
            txtCustomerID.Clear()
            txtCustomerName.Clear()
            txtCustomerPhone.Clear()
            LoadCustomer()
        End If
    End Sub
End Class