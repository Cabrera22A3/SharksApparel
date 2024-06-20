Public Class CashierHome

    Sub switchPanel(panel As System.Windows.Forms.Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub HomeBtn_Click_1(sender As Object, e As EventArgs) Handles HomeBtn.Click
        switchPanel(CashierDashboard)
    End Sub

    Private Sub ProductsBtn_Click(sender As Object, e As EventArgs) Handles ProductsBtn.Click
        switchPanel(ProductsPage)
    End Sub

    Private Sub AboutUsBtn_Click(sender As Object, e As EventArgs) Handles AboutUsBtn.Click
        switchPanel(AboutUsPage)
    End Sub

    Private Sub CashierHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(CashierDashboard)
    End Sub
End Class