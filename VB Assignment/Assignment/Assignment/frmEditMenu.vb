Imports System.Data.SqlClient
Imports System.Data


Public Class frmEditMenu
    Dim edit As Integer

    ' For Back button 
    Private Sub MnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    ' For Logout Button 
    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    ' For Menu add button
    Private Sub MnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        edit = 1
        btnEdit.Visible = True
        btnEdit.Text = "Add"
        txtID.Enabled = False
        txtName.Enabled = True
        txtPrice.Enabled = True
    End Sub

    ' For Menu delete button
    Private Sub MnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        edit = 2
        btnEdit.Visible = True
        btnEdit.Text = "Delete"
        txtID.Enabled = True
        txtName.Enabled = False
        txtPrice.Enabled = False
    End Sub

    ' For Menu Update button 
    Private Sub MnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        edit = 3
        btnEdit.Visible = True
        btnEdit.Text = "Update"
        txtID.Enabled = True
        txtName.Enabled = True
        txtPrice.Enabled = True
    End Sub

    ' For Edit Button. This button shares the Add, Delete Update function
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If edit = 1 Then
            LoadItems()
            AddItems()
            txtID.Clear()
            txtName.Clear()
            txtPrice.Clear()
            LoadItems()

        ElseIf edit = 2 Then
            LoadItems()
            DeleteItems()
            txtID.Clear()
            txtName.Clear()
            txtPrice.Clear()
            LoadItems()

        ElseIf edit = 3 Then
            LoadItems()
            UpdateItems()
            txtID.Clear()
            txtName.Clear()
            txtPrice.Clear()
            LoadItems()


        End If
    End Sub

    ' Add Items to DB function
    Sub AddItems()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        strSql = "Insert into Menu([item_name],[item_price],[item_type]) values('" & txtName.Text & "','" & txtPrice.Text & "', '" & cboxItemType.SelectedItem & "')"

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




    ' Delete items from DB function
    Sub DeleteItems()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        strSql = "Delete from Menu where item_id = '" & txtID.Text & "'"

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



    ' Update item in DB function 
    Sub UpdateItems()
        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        strSql = "Update Menu Set item_name = '" & txtName.Text & "', item_price = '" & txtPrice.Text & "', item_type = '" & cboxItemType.SelectedItem & "' Where item_id = '" & txtID.Text & "' "

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



    ' Load DB items
    Sub LoadItems()

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim MyCmdBld As New SqlCommandBuilder
        Dim ds As New DataSet
        Dim FoodTable As New DataTable

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        adapter = New SqlDataAdapter("SELECT * FROM Menu", sqlCnn)
        MyCmdBld = New SqlCommandBuilder(adapter)
        FoodTable = New DataTable
        adapter.Fill(FoodTable)
        dgvMenu.DataSource = FoodTable
        dgvMenu.Columns(0).HeaderText = "Item ID"
        dgvMenu.Columns(1).HeaderText = "Item Name"
        dgvMenu.Columns(2).HeaderText = "Item Price"
        dgvMenu.Columns(3).HeaderText = "Item Type"
        sqlCnn.Close()
    End Sub



    Private Sub DgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick
        LoadItems()
    End Sub


End Class