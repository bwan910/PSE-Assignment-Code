Imports System.Data.SqlClient
Imports System.Data


Public Class frmEditMenu
    Dim edit As Integer

    ' For Back button 
    Private Sub MnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        frmViewMenu.Show()
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

            'ElseIf edit = 4 Then
            '    DeleteDrink()
            '    LoadDrink()
            'ElseIf edit = 5 Then
            '    UpdateFood()
            '    LoadFood()
            'ElseIf edit = 6 Then
            '    UpdateDrink()
            '    LoadDrink()
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

    'Sub AddDrink()
    '    Dim strConnectionString As String
    '    Dim sqlCnn As SqlConnection
    '    Dim sqlCmd As SqlCommand
    '    Dim adapter As New SqlDataAdapter
    '    Dim ds As New DataSet
    '    Dim strSql As String

    '    'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
    '    strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

    '    strSql = "Insert into Drink([DrinkID],[DrinkName],[DrinkPrice]) values('" & txtID.Text & "','" & txtName.Text & "','" & txtPrice.Text & "')"

    '    sqlCnn = New SqlConnection(strConnectionString)
    '    Try
    '        sqlCnn.Open()
    '        sqlCmd = New SqlCommand(strSql, sqlCnn)
    '        sqlCmd.ExecuteNonQuery()
    '        sqlCmd.Dispose()
    '        sqlCnn.Close()
    '        MessageBox.Show("Record is sucessfully added !")
    '    Catch ex As Exception
    '        MessageBox.Show("Cannot open connection !")
    '    End Try
    'End Sub


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

    'Sub DeleteDrink()
    '    Dim strConnectionString As String
    '    Dim sqlCnn As SqlConnection
    '    Dim sqlCmd As SqlCommand
    '    Dim adapter As New SqlDataAdapter
    '    Dim ds As New DataSet
    '    Dim strSql As String

    '    'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
    '    strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

    '    strSql = "Delete from Drink where DrinkID = '" & txtID.Text & "'"

    '    sqlCnn = New SqlConnection(strConnectionString)

    '    Try
    '        sqlCnn.Open()
    '        sqlCmd = New SqlCommand(strSql, sqlCnn)
    '        sqlCmd.ExecuteNonQuery()
    '        sqlCmd.Dispose()
    '        sqlCnn.Close()
    '        MessageBox.Show("Record is sucessfully updated !")
    '    Catch ex As Exception
    '        MessageBox.Show("Cannot open connection !")
    '    End Try
    'End Sub

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

    'Sub UpdateDrink()
    '    Dim strConnectionString As String
    '    Dim sqlCnn As SqlConnection
    '    Dim sqlCmd As SqlCommand
    '    Dim adapter As New SqlDataAdapter
    '    Dim ds As New DataSet
    '    Dim strSql As String

    '    'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
    '    strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

    '    strSql = "Update Drink Set DrinkName = '" & txtName.Text & "', DrinkPrice = '" & txtPrice.Text & "', Where DrinkID = '" & txtID.Text & "' "

    '    sqlCnn = New SqlConnection(strConnectionString)

    '    Try
    '        sqlCnn.Open()
    '        sqlCmd = New SqlCommand(strSql, sqlCnn)
    '        sqlCmd.ExecuteNonQuery()
    '        sqlCmd.Dispose()
    '        sqlCnn.Close()
    '        MessageBox.Show("Record is sucessfully updated !")
    '    Catch ex As Exception
    '        MessageBox.Show("Cannot open connection !")
    '    End Try
    'End Sub

    'Private Sub MnuAddFood_Click(sender As Object, e As EventArgs)
    '    LoadItems()
    '    edit = 1
    'End Sub

    'Private Sub MnuAddDrink_Click(sender As Object, e As EventArgs) Handles mnuAddDrink.Click
    '    LoadDrink()
    '    edit = 2
    'End Sub

    'Private Sub MnuDeleteFood_Click(sender As Object, e As EventArgs)
    '    LoadItems()
    '    edit = 2
    'End Sub

    'Private Sub MnuDeleteDrink_Click(sender As Object, e As EventArgs) Handles mnuDeleteDrink.Click
    '    LoadDrink()
    '    edit = 4
    'End Sub

    'Private Sub MnuUpdateFood_Click(sender As Object, e As EventArgs)
    '    LoadItems()
    '    edit = 3
    'End Sub

    'Private Sub MnuUpdateDrink_Click(sender As Object, e As EventArgs) Handles mnuUpdateDrink.Click
    '    LoadDrink()
    '    edit = 6
    'End Sub

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

    'Sub LoadDrink()

    '    Dim strConnectionString As String
    '    Dim sqlCnn As SqlConnection
    '    Dim adapter As New SqlDataAdapter
    '    Dim MyCmdBld As New SqlCommandBuilder
    '    Dim ds As New DataSet
    '    Dim DrinkTable As New DataTable

    '    'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
    '    strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

    '    sqlCnn = New SqlConnection(strConnectionString)

    '    sqlCnn.Open()
    '    adapter = New SqlDataAdapter("SELECT * FROM Drink", sqlCnn)
    '    MyCmdBld = New SqlCommandBuilder(adapter)
    '    DrinkTable = New DataTable
    '    adapter.Fill(DrinkTable)
    '    dgvMenu.DataSource = DrinkTable
    '    dgvMenu.Columns(0).HeaderText = "DrinkID"
    '    dgvMenu.Columns(1).HeaderText = "Drink Name"
    '    dgvMenu.Columns(2).HeaderText = "Drink Price"
    '    sqlCnn.Close()
    'End Sub

    Private Sub DgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick
        LoadItems()
    End Sub

    Private Sub frmEditMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class