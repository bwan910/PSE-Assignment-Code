Imports System.Data
Imports System.Data.SqlClient

Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmChart
    Private Sub frmChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim strConn As String = "Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True"

        'Dim conn As New SqlConnection(strConn)

        'Dim sqlProducts As String = "SELECT * FROM FoodOrder order by FoodID, Quantity"
        'Dim da As New SqlDataAdapter(sqlProducts, conn)
        'Dim ds As New DataSet()
        'da.Fill(ds, "FoodOrder")

        'Dim ChartArea1 As ChartArea = New ChartArea()
        'Dim Legend1 As Legend = New Legend()
        'Dim Series1 As Series = New Series()
        'Dim Chart1 = New Chart()
        'Me.Controls.Add(Chart1)

        'ChartArea1.Name = "ChartArea1"
        'Chart1.ChartAreas.Add(ChartArea1)
        'Legend1.Name = "Legend1"
        'Chart1.Legends.Add(Legend1)
        'Chart1.Location = New System.Drawing.Point(13, 13)
        'Chart1.Name = "Chart1"
        'Series1.ChartArea = "ChartArea1"
        'Series1.Legend = "Legend1"
        'Series1.Name = "Quantity"
        'Chart1.Series.Add(Series1)
        'Chart1.Size = New System.Drawing.Size(800, 500)
        'Chart1.TabIndex = 0
        'Chart1.Text = "Chart1"

        'Chart1.Series("Quantity").XValueMember = "FoodID"
        'Chart1.Series("Quantity").YValueMembers = "Quantity"

        'Chart1.DataSource = ds.Tables("FoodOrder")


        Dim cnn3 As New SqlConnection
        Dim cmd3 As New SqlCommand

        cnn3.ConnectionString = ("Data Source=BRANDON\SQLEXPRESS;Initial Catalog=OrderSystem;Integrated Security=True")
        cmd3.Connection = cnn3

        Dim tblFields As String = "SELECT Top 8 FoodID, Quantity FROM FoodOrder"
        Dim oData As New SqlDataAdapter(tblFields, cnn3)
        Dim ds As New DataSet
        Dim oCmd As New SqlCommand(tblFields, cnn3)


        cnn3.Open()
        oData.Fill(ds, "tblTagInfo")
        cnn3.Close()

        Chart1.DataSource = ds.Tables("tblTagInfo")
        Dim Series1 As Series = Chart1.Series("Series1")
        Series1.Name = "Food"
        Chart1.Series(Series1.Name).XValueMember = "Quantity"
        Chart1.Series(Series1.Name).YValueMembers = "FoodID"

        Chart1.Size = New System.Drawing.Size(780, 350)

    End Sub
End Class