Imports MySql.Data.MySqlClient

Public Class Form
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub SalesPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; userid=root; password='';database=test"
        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING CONNECTION TO MYSQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            create("INSERT INTO productstb(product_id,name,description,category_id,size,color,cost_price,retail_price,stock_quantity) VALUES ('" & product_id.Text & "','" & name.Text & "','" & description.Text & "','" & category_id.Text & "','" & size.Text & "','" & color.Text & "','" & cost_price.Text & "','" & retail_price.Text & "','" & stock_quantity.Text & "')")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles reload.Click
        Try
            'reload("SELECT * FROM productstb")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles formname.TextChanged

    End Sub
End Class