Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class AddUserPage
    Dim connAddedUser As New MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=test")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub AddUserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_loadAddedUser()
    End Sub

    Public Sub DGV_loadAddedUser()
        DataGridView1.Rows.Clear()
        Try
            connAddedUser.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM usertb", connAddedUser)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("user_id"),
                                       dr.Item("username"),
                                       dr.Item("password"),
                                       dr.Item("userrole"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        saveAddedUser()
        DGV_loadAddedUser()
    End Sub

    Public Sub saveAddedUser()
        Try
            If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox3.Text) OrElse String.IsNullOrWhiteSpace(ComboBox1.Text) Then
                MessageBox.Show("All fields are required.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim cmd As New MySqlCommand(
                "INSERT INTO `usertb`(`username`,`password`,`userrole`) 
                VALUES (@username,@password,@userrole)", connAddedUser
            )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", TextBox1.Text)
            cmd.Parameters.AddWithValue("@password", TextBox3.Text)
            cmd.Parameters.AddWithValue("@userrole", ComboBox1.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Save Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connAddedUser.Close()
        End Try
    End Sub

    Public Sub clearAddedUser()
        TextBox1.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
    End Sub

    Public Sub deleteAddedUser()
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Type username beside 'Create Username:' then press delete button.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MsgBox("Are you sure to Delete this User?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                Dim cmd As New MySqlCommand(
                    "DELETE FROM `usertb` WHERE `username`=@username", connAddedUser
                )
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@username", TextBox1.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("DELETE Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DELETE Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connAddedUser.Close()
            End Try
            DGV_loadAddedUser()
        Else
            Return
        End If
    End Sub

    Sub EditAddedUser()
        Try
            If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox3.Text) OrElse String.IsNullOrWhiteSpace(ComboBox1.Text) Then
                MessageBox.Show("All fields are required.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim cmd As New MySqlCommand(
                "UPDATE `usertb` SET `username`=@username,`password`=@password,`userrole`=@userrole WHERE `username`=@username", connAddedUser
            )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", TextBox1.Text)
            cmd.Parameters.AddWithValue("@password", TextBox3.Text)
            cmd.Parameters.AddWithValue("@userrole", ComboBox1.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Edit Success!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Edit Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connAddedUser.Close()
        End Try
        DGV_loadAddedUser()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearAddedUser()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deleteAddedUser()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditAddedUser()
    End Sub
End Class