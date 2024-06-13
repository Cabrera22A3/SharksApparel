Imports Org.BouncyCastle.Pqc.Crypto.Saber

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProductsBtn_Click(sender As Object, e As EventArgs) Handles ProductsBtn.Click
        switchPanel(ProductsPage)
    End Sub

    Sub switchPanel(panel As System.Windows.Forms.Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub SuppliersBtn_Click(sender As Object, e As EventArgs) Handles SuppliersBtn.Click
        switchPanel(SuppliersPage)
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        switchPanel(HomePage)
    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As EventArgs) Handles SalesBtn.Click
        switchPanel(SalesPageDisplay)
    End Sub

    Private Sub AboutUsBtn_Click(sender As Object, e As EventArgs) Handles AboutUsBtn.Click
        switchPanel(AboutUsPage)
    End Sub
End Class