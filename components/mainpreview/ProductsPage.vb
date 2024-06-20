Imports System.Drawing.Text
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Org.BouncyCastle.Pqc.Crypto.Saber
Imports System.Linq.Expressions
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Drawing

Public Class ProductsPage
    Dim connAddedProductReq As New MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=test")
    Dim i As Integer

    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim READERrole As MySqlDataReader
    Dim COMMANDrole As MySqlCommand

    'decline btn 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    'add new btn
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Show()
    End Sub

    'accept btn
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) OrElse String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("All fields are required.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        connAddedProductReq.Open()
        Try
            Dim query As String
            Dim queryRole As String
            query = "SELECT * FROM productreqtb WHERE product_id='" & TextBox1.Text & "'"
            queryRole = "SELECT product_id FROM productreqtb WHERE product_id='" & TextBox1.Text & "'"

            COMMAND = New MySqlCommand(query, connAddedProductReq)
            READER = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            READER.Close()
            If count = 1 Then
                Dim commandRole As New MySqlCommand(queryRole, connAddedProductReq)
                commandRole.Parameters.AddWithValue("@product_id", TextBox1.Text)
                Dim readerRole As MySqlDataReader = commandRole.ExecuteReader()
                If readerRole.Read() Then
                    Dim userRole As String = readerRole("product_id").ToString()
                    If userRole = TextBox1.Text Then
                        readerRole.Close()
                        EditAddedProductReq()
                    Else
                        readerRole.Close()
                    End If
                End If
                readerRole.Close()
            ElseIf count < 1 Then
                saveAddedProductReq()
            End If
            connAddedProductReq.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connAddedProductReq.Close()
        End Try
    End Sub

    Public Sub saveAddedProductReq()
        Try
            Dim cmd As New MySqlCommand(
                "INSERT INTO `productreqtb`(`product_id`,`datecreated`,`request`) 
                VALUES (@product_id,@datecreated,@request)", connAddedProductReq
            )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@product_id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@datecreated", TextBox2.Text)
            cmd.Parameters.AddWithValue("@request", TextBox3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Save Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Panel1.Hide()
            Else
                MessageBox.Show("Save Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            connAddedProductReq.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connAddedProductReq.Close()
        End Try
    End Sub

    Sub EditAddedProductReq()
        Try
            Dim cmd As New MySqlCommand(
                "UPDATE `productreqtb` SET `product_id`=@product_id,`datecreated`=@datecreated,`request`=@request WHERE `product_id`=@product_id", connAddedProductReq
            )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@product_id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@datecreated", TextBox2.Text)
            cmd.Parameters.AddWithValue("@request", TextBox3.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Update Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Update Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connAddedProductReq.Close()
        End Try
    End Sub

    Private Sub ProductsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReLoadProductsPage()
    End Sub

    Private productButtons As New List(Of System.Windows.Forms.Button)()
    Sub ReLoadProductsPage()
        Dim connectionString As String = "server=127.0.0.1;port=3306;username=root;password=;database=test"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT productstb.name, productstb.photo FROM productstb LEFT JOIN productreqtb ON productreqtb.product_id = productstb.product_id WHERE productreqtb.status = 1"
                Dim dataTable As New DataTable()
                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.Fill(dataTable)
                End Using

                For Each row As DataRow In dataTable.Rows
                    Dim newButton As New System.Windows.Forms.Button()
                    newButton.Size = New Size(187, 187)

                    newButton.Text = row("name").ToString()

                    Dim imageData As Byte() = CType(row("photo"), Byte())
                    Using ms As New IO.MemoryStream(imageData)
                        Dim buttonImage As Image = Image.FromStream(ms)
                        newButton.BackgroundImage = buttonImage
                        newButton.BackgroundImageLayout = ImageLayout.Zoom
                        newButton.TextImageRelation = TextImageRelation.Overlay
                        newButton.TextAlign = ContentAlignment.BottomCenter
                        newButton.BackColor = SystemColors.ButtonHighlight
                        newButton.Cursor = Cursors.Hand
                    End Using

                    FlowLayoutPanel1.Controls.Add(newButton)
                    productButtons.Add(newButton)
                Next

            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FlowLayoutPanel1.Controls.Clear()
        productButtons.Clear()
        ReLoadProductsPage()
    End Sub
End Class