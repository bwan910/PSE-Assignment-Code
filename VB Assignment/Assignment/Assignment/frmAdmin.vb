Public Class frmAdmin
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmViewMenu.Show()
        Me.Close()
    End Sub

    Private Sub BtnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        frmViewEmployee.Show()
        Me.Close()
    End Sub

    Private Sub BtnMember_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmViewCustomer.Show()
        Me.Close()
    End Sub

    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        frmChart.Show()
    End Sub
End Class