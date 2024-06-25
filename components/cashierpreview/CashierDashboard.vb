Imports MySql.Data.MySqlClient
Imports System.Drawing.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Org.BouncyCastle.Pqc.Crypto.Saber
Imports System.Linq.Expressions
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Drawing
Imports System.Reflection

Public Class CashierDashboard

    Dim prodID As String
    Dim prodName As String
    Dim prodQuantity As Integer
    Dim prodRetPrice As Double
    Dim prodRetPriceequals As Double

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
        If String.IsNullOrWhiteSpace(TextBox6.Text) OrElse String.IsNullOrWhiteSpace(TextBox4.Text) OrElse String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("All fields are required.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not Integer.TryParse(TextBox6.Text, Nothing) Then
            ' Handle the case where TextBox6.Text is not a valid integer
        End If
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM productstb WHERE product_id = '" & TextBox5.Text & "'", conn)
            dr = cmd.ExecuteReader

            'cmd.Parameters.Add()

            While dr.Read
                prodID = dr("product_id")
                prodName = dr("name")
                prodRetPrice = dr("retail_price")
                prodRetPriceequals = prodRetPrice * Val(TextBox6.Text)

                totalProdRetPriceEquals += prodRetPriceequals

                ListBox1.Items.Add("( " & TextBox6.Text & "X )" & "  " & prodName & "    :   ₱" & prodRetPriceequals)
            End While

            ' Create a new Label to display the total
            TextBox7.Text = "Total: ₱" & totalProdRetPriceEquals.ToString("F2")
            TextBox7.ForeColor = Color.Black
            TextBox7.Location = New Point(525, 426) ' Set the location as needed

            TextBox2.Text = "Total: ₱" & totalProdRetPriceEquals.ToString("F2")
        Catch ex As Exception

        End Try
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

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

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text.Length = 6 Then
            Try
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM productstb WHERE product_id = '" & TextBox5.Text & "'", conn)
                dr = cmd.ExecuteReader

                While dr.Read
                    TextBox4.Text = dr("name")
                End While

            Catch ex As Exception

            End Try
        End If
    End Sub

    'Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
    'If e.KeyCode = Keys.Enter Then
    'Try
    'If conn.State = ConnectionState.Open Then
    'conn.Close()
    'End If
    'conn.Open()
    'Dim cmd As New MySqlCommand("SELECT * FROM productstb WHERE product_id = '" & TextBox5.Text & "'", conn)
    'dr = cmd.ExecuteReader
    'While dr.Read
    'TextBox4.Text = dr("name")
    'End While
    'Catch ex As Exception
    'End Try
    'End If
    'End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        Panel4.Hide()
    End Sub
End Class