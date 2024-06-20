Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports System.Drawing.Configuration
Imports System.IO

Public Class SalesPageDisplay
    Dim conn As New MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=test")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Private Sub SalesPageDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM productstb", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("product_id"),
                                       dr.Item("name"),
                                       dr.Item("description"),
                                       dr.Item("category_id"),
                                       dr.Item("size"),
                                       dr.Item("color"),
                                       dr.Item("cost_price"),
                                       dr.Item("retail_price"),
                                       dr.Item("stock_quantity"),
                                       dr.Item("photo"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        save()
        DGV_load()
    End Sub

    Public Sub save()
        Dim query As String
        Dim queryRole As String
        query = "SELECT * FROM productreqtb WHERE product_id='" & TextBox1.Text & "'"
        queryRole = "SELECT product_id FROM productreqtb WHERE product_id='" & TextBox1.Text & "'"
        COMMAND = New MySqlCommand(query, conn)
        READER = COMMAND.ExecuteReader
        Dim count As Integer
        count = 0
        While READER.Read
            count = count + 1
        End While
        READER.Close()
        If count = 1 Then
            Dim commandRole As New MySqlCommand(queryRole, conn)
            commandRole.Parameters.AddWithValue("@product_id", TextBox1.Text)
            Dim readerRole As MySqlDataReader = commandRole.ExecuteReader()
            If readerRole.Read() Then
                Dim userRole As String = readerRole("product_id").ToString()
                If userRole = TextBox1.Text Then
                    readerRole.Close()
                    MessageBox.Show("Ask ADMIN to delete product request of this Product ID in Product Approval.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            readerRole.Close()
        End If
        conn.Close()

        Try
            conn.Open()
            If PictureBox1.Image Is Nothing Then
                MessageBox.Show("Image must be inserted again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim ms As New MemoryStream
            Dim imga As Image = PictureBox1.Image
            Dim bmpImage As New Bitmap(imga)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer
            Dim cmd As New MySqlCommand(
                "INSERT INTO `productstb`(`product_id`, `name`, `description`, `category_id`, `size`, `color`, `cost_price`, `retail_price`, `stock_quantity`, `photo`) 
                VALUES (@product_id,@name,@description,@category_id,@size,@color,@cost_price,@retail_price,@stock_quantity,@photo)", conn
            )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@product_id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@description", TextBox3.Text)
            cmd.Parameters.AddWithValue("@category_id", TextBox4.Text)
            cmd.Parameters.AddWithValue("@size", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@color", TextBox5.Text)
            cmd.Parameters.AddWithValue("@cost_price", CDec(TextBox6.Text))
            cmd.Parameters.AddWithValue("@retail_price", CDec(TextBox7.Text))
            cmd.Parameters.AddWithValue("@stock_quantity", TextBox8.Text)
            cmd.Parameters.Add("@photo", MySqlDbType.LongBlob).Value = ms.ToArray()

            'conn.Open()

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Save Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        PictureBox1.Image = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBox6.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells(7).Value
        TextBox8.Text = DataGridView1.CurrentRow.Cells(8).Value
        PictureBox1.Image = DataGridView1.CurrentRow.Cells(9).Value

        TextBox1.ReadOnly = True
        Button5.Enabled = False
    End Sub

    Sub Edit()
        Try
            If PictureBox1.Image Is Nothing Then
                MessageBox.Show("Image must be inserted again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim cmd As New MySqlCommand(
                "UPDATE `productstb` SET `name`=@name,`description`=@description,`category_id`=@category_id,`size`=@size,`color`=@color,`cost_price`=@cost_price,`retail_price`=@retail_price,`stock_quantity`=@stock_quantity,`photo`=@photo WHERE `product_id`=@product_id", conn
            )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@product_id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@description", TextBox3.Text)
            cmd.Parameters.AddWithValue("@category_id", TextBox4.Text)
            cmd.Parameters.AddWithValue("@size", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@color", TextBox5.Text)
            cmd.Parameters.AddWithValue("@cost_price", CDec(TextBox6.Text))
            cmd.Parameters.AddWithValue("@retail_price", CDec(TextBox7.Text))
            cmd.Parameters.AddWithValue("@stock_quantity", TextBox8.Text)
            cmd.Parameters.Add("@photo", MySqlDbType.Blob).Value = ms.ToArray()

            'conn.Open()

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Update Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Update Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        DGV_load()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Edit()
    End Sub

    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader

    Public Sub delete()
        If MsgBox("Are you sure to Delete this Product?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Dim query As String
            Dim queryRole As String
            query = "SELECT * FROM productreqtb WHERE product_id='" & TextBox1.Text & "'"
            queryRole = "SELECT product_id FROM productreqtb WHERE product_id='" & TextBox1.Text & "'"
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            READER.Close()
            If count = 1 Then
                Dim commandRole As New MySqlCommand(queryRole, conn)
                commandRole.Parameters.AddWithValue("@product_id", TextBox1.Text)
                Dim readerRole As MySqlDataReader = commandRole.ExecuteReader()
                If readerRole.Read() Then
                    Dim userRole As String = readerRole("product_id").ToString()
                    If userRole = TextBox1.Text Then
                        readerRole.Close()
                        MessageBox.Show("Ask ADMIN to delete product request of this Product ID in Product Approval.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
                readerRole.Close()
            End If
            conn.Close()

            Try
                conn.Open()
                Dim cmd As New MySqlCommand(
                    "DELETE FROM `productstb` WHERE `product_id`=@product_id", conn
                )
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@product_id", TextBox1.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("DELETE Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DELETE Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            DGV_load()
        Else
            Return
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        delete()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clear()
    End Sub

    'search bar
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM productstb WHERE product_id like '%" & TextBox9.Text & "%' OR name like '%" & TextBox9.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("product_id"),
                                       dr.Item("name"),
                                       dr.Item("description"),
                                       dr.Item("category_id"),
                                       dr.Item("size"),
                                       dr.Item("color"),
                                       dr.Item("cost_price"),
                                       dr.Item("retail_price"),
                                       dr.Item("stock_quantity"),
                                       dr.Item("photo"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub
End Class