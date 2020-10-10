Public Class frmAdmin
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmEditMenu.Show()
        Me.Close()
    End Sub

    Private Sub BtnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        frmEditEmployee.Show()
        Me.Close()
    End Sub



    Private Sub MnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub



    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        frmChart.Show()
    End Sub

    Private Sub BtnMember_Click(sender As Object, e As EventArgs) Handles BtnMember.Click
        frmEditCustomer.Show()
        Me.Close()
    End Sub
End Class