Public Class AdminHome
    Private Sub ProductsBtn_Click(sender As Object, e As EventArgs) Handles ProductsBtn.Click
        switchPanel(ProductsPage)
    End Sub

    Sub switchPanel(panel As System.Windows.Forms.Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        switchPanel(AdminDashboard)
    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        switchPanel(SalesPageDisplay)
    End Sub

    Private Sub AboutUsBtn_Click(sender As Object, e As EventArgs) Handles AboutUsBtn.Click
        switchPanel(AboutUsPage)
    End Sub

    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(AdminDashboard)
    End Sub

    Private Sub ProductApprovalBtn_Click(sender As Object, e As EventArgs) Handles ProductApprovalBtn.Click
        switchPanel(ProductApprovalPage)
    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click
        switchPanel(AddUserPage)
    End Sub
End Class