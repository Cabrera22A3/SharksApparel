Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class ProductApprovalPage
    Dim connAcceptedNewProduct As New MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=test")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Private Sub ProductApprovalPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_loadAddedUser()
    End Sub

    Public Sub DGV_loadAddedUser()
        DataGridView1.Rows.Clear()
        Try
            connAcceptedNewProduct.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM productreqtb", connAcceptedNewProduct)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("productreq_id"),
                                       dr.Item("product_id"),
                                       dr.Item("datecreated"),
                                       dr.Item("request"),
                                       dr.Item("status"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connAcceptedNewProduct.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DGV_loadAddedUser()
    End Sub

    'search bar po
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        DataGridView1.Rows.Clear()
        Try
            connAcceptedNewProduct.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM productreqtb WHERE productreq_id like '%" & TextBox2.Text & "%' OR product_id like '%" & TextBox2.Text & "%' OR datecreated like '%" & TextBox2.Text & "%' OR status like '%" & TextBox2.Text & "%'", connAcceptedNewProduct)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("productreq_id"),
                                       dr.Item("product_id"),
                                       dr.Item("datecreated"),
                                       dr.Item("request"),
                                       dr.Item("status"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connAcceptedNewProduct.Close()
        End Try
    End Sub

    Sub EditAcceptedNewProduct()
        Try
            If String.IsNullOrWhiteSpace(TextBox1.Text) Then
                MessageBox.Show("All fields are required.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            connAcceptedNewProduct.Open()
            Dim cmd As New MySqlCommand(
                "UPDATE `productreqtb` SET `product_id`=@product_id,`status`=@status WHERE `product_id`=@product_id", connAcceptedNewProduct
            )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@product_id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@status", If(CheckBox1.Checked, 1, 0))

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Save Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connAcceptedNewProduct.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditAcceptedNewProduct
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deleteAcceptedNewProduct()
    End Sub

    Public Sub deleteAcceptedNewProduct()
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("All fields are required.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MsgBox("Are you sure to Delete this Product Request?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                connAcceptedNewProduct.Open()
                Dim cmd As New MySqlCommand(
                    "DELETE FROM `productreqtb` WHERE `product_id`=@product_id", connAcceptedNewProduct
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
                connAcceptedNewProduct.Close()
            End Try
            DGV_loadAddedUser()
        Else
            Return
        End If
    End Sub
End Class