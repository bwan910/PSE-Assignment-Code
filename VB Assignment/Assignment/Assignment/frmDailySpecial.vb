Public Class frmDailySpecial
    Dim num As Integer

    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub MnuMenu_Click(sender As Object, e As EventArgs) Handles mnuMenu.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub FrmDailySpecial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ramen As String = "C:\Users\bwan9\OneDrive\Desktop\Weiwei\VB Assignment\ramens.jpg"
        Dim cake As String = "C:\Users\bwan9\OneDrive\Desktop\Weiwei\VB Assignment\cake.jpg"
        Dim pizza As String = "C:\Users\bwan9\OneDrive\Desktop\Weiwei\VB Assignment\pizza.jpg"
        Dim latte As String = "C:\Users\bwan9\OneDrive\Desktop\Weiwei\VB Assignment\latte.jpg"
        Dim lemonade As String = "C:\Users\bwan9\OneDrive\Desktop\Weiwei\VB Assignment\lemonade.jpg"
        Dim juice As String = "C:\Users\bwan9\OneDrive\Desktop\Weiwei\VB Assignment\juice.jpg"


        Randomize()
        RanNumber()

        imgDrink.BackgroundImageLayout = ImageLayout.Stretch
        imgFood.BackgroundImageLayout = ImageLayout.Stretch

        If num < 6 And num > 0 Then
            imgFood.BackgroundImage = Image.FromFile(pizza)
            lblDSFood.Text = "Pizza"
            imgDrink.BackgroundImage = Image.FromFile(lemonade)
            lblDSDrink.Text = "Lemonade"
        ElseIf num > 4 And num < 10 Then
            imgFood.BackgroundImage = Image.FromFile(cake)
            lblDSFood.Text = "Cake"
            imgDrink.BackgroundImage = Image.FromFile(latte)
            lblDSDrink.Text = "Latte"
        ElseIf num > 9 And num < 16 Then
            imgFood.BackgroundImage = Image.FromFile(ramen)
            lblDSFood.Text = "Ramen"
            imgDrink.BackgroundImage = Image.FromFile(lemonade)
            lblDSDrink.Text = "Lemonade"
        ElseIf num > 14 And num < 20 Then
            imgFood.BackgroundImage = Image.FromFile(cake)
            lblDSFood.Text = "Cake"
            imgDrink.BackgroundImage = Image.FromFile(latte)
            lblDSDrink.Text = "Latte"
        ElseIf num > 19 And num < 26 Then
            imgFood.BackgroundImage = Image.FromFile(ramen)
            lblDSFood.Text = "Ramen"
            imgDrink.BackgroundImage = Image.FromFile(juice)
            lblDSDrink.Text = "Juice"
        ElseIf num > 24 And num <= 30 Then
            imgFood.BackgroundImage = Image.FromFile(pizza)
            lblDSFood.Text = "Pizza"
            imgDrink.BackgroundImage = Image.FromFile(juice)
            lblDSDrink.Text = "Juice"
        End If

    End Sub

    Private Sub RanNumber()
        num = Math.Ceiling(Rnd() * 30)
    End Sub
End Class
