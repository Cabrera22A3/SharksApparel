Imports MySql.Data.MySqlClient
Imports System.Drawing.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Org.BouncyCastle.Pqc.Crypto.Saber
Imports System.Linq.Expressions
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Drawing

Public Class CashierDashboard

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Hide()
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel4.Hide()
    End Sub

    Private productButtons1 As New List(Of System.Windows.Forms.Button)()
    Sub ReLoadCashierDashboard()
        Dim connectionString As String = "server=127.0.0.1;port=3306;username=root;password=;database=test"

        Using connCashierDashboard As New MySqlConnection(connectionString)
            Try
                connCashierDashboard.Open()
                Dim query1 As String = "SELECT productstb.name, productstb.photo FROM productstb LEFT JOIN productreqtb ON productreqtb.product_id = productstb.product_id WHERE productreqtb.status = 1"
                Dim dataTable1 As New DataTable()
                Using adapter1 As New MySqlDataAdapter(query1, connCashierDashboard)
                    adapter1.Fill(dataTable1)
                End Using

                For Each row As DataRow In dataTable1.Rows
                    Dim newButton1 As New System.Windows.Forms.Button()
                    newButton1.Size = New Size(187, 187)

                    newButton1.Text = row("name").ToString()

                    Dim imageData As Byte() = CType(row("photo"), Byte())
                    Using ms As New IO.MemoryStream(imageData)
                        Dim buttonImage As Image = Image.FromStream(ms)
                        newButton1.BackgroundImage = buttonImage
                        newButton1.BackgroundImageLayout = ImageLayout.Zoom
                        newButton1.TextImageRelation = TextImageRelation.Overlay
                        newButton1.TextAlign = ContentAlignment.BottomCenter
                        newButton1.BackColor = SystemColors.ButtonHighlight
                        newButton1.Cursor = Cursors.Hand
                    End Using

                    FlowLayoutPanel1.Controls.Add(newButton1)
                    productButtons1.Add(newButton1)
                Next

            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FlowLayoutPanel1.Controls.Clear()
        productButtons1.Clear()
        ReLoadCashierDashboard()
    End Sub

    Private Sub CashierDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReLoadCashierDashboard()
    End Sub
End Class