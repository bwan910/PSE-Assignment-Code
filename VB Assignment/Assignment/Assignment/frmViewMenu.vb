Imports System.Data.SqlClient
Imports System.Data

Public Class frmViewMenu
    Private Sub MnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEditMenu.Show()
        Me.Close()
    End Sub

    Private Sub FrmViewMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFood()
        LoadDrink()
    End Sub
    Sub LoadFood()

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
        dgvFood.DataSource = FoodTable
        dgvFood.Columns(0).HeaderText = "FoodID"
        dgvFood.Columns(1).HeaderText = "Food Name"
        dgvFood.Columns(2).HeaderText = "Food Price"
        sqlCnn.Close()
    End Sub

    Sub LoadDrink()

        Dim strConnectionString As String
        Dim sqlCnn As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim MyCmdBld As New SqlCommandBuilder
        Dim ds As New DataSet
        Dim DrinkTable As New DataTable

        'strConnectionString = "Data Source=LAPTOP-287EO590\HI;Initial Catalog=PikachuCafe;Integrated Security=True"
        strConnectionString = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        sqlCnn = New SqlConnection(strConnectionString)

        sqlCnn.Open()
        adapter = New SqlDataAdapter("SELECT * FROM Menu", sqlCnn)
        MyCmdBld = New SqlCommandBuilder(adapter)
        DrinkTable = New DataTable
        adapter.Fill(DrinkTable)
        dgvDrink.DataSource = DrinkTable
        dgvDrink.Columns(0).HeaderText = "DrinkID"
        dgvDrink.Columns(1).HeaderText = "Drink Name"
        dgvDrink.Columns(2).HeaderText = "Drink Price"
        sqlCnn.Close()
    End Sub

    Private Sub DgvFood_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFood.CellContentClick
        LoadFood()
    End Sub

    Private Sub DgvDrink_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDrink.CellContentClick
        LoadDrink()
    End Sub
End Class