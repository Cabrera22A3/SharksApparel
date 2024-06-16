Imports System.Diagnostics.Eventing
Imports System.DirectoryServices.ActiveDirectory
Imports MySql.Data.MySqlClient

Public Class LogIn
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim READERrole As MySqlDataReader
    Dim COMMANDrole As MySqlCommand
    Dim connLogin As New MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=test")
    Dim i As Integer
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Hide()
        'try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connLogin.Open()
            Dim query As String
            Dim queryRole As String
            query = "SELECT * FROM usertb WHERE username='" & TextBox1.Text & "' and password ='" & TextBox2.Text & "'"
            queryRole = "SELECT userrole FROM usertb WHERE username='" & TextBox1.Text & "' and password ='" & TextBox2.Text & "'"

            COMMAND = New MySqlCommand(query, connLogin)
            READER = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            READER.Close()
            If count = 1 Then
                Dim commandRole As New MySqlCommand(queryRole, connLogin)
                commandRole.Parameters.AddWithValue("@username", TextBox1.Text)
                commandRole.Parameters.AddWithValue("@password", TextBox2.Text)
                Dim readerRole As MySqlDataReader = commandRole.ExecuteReader()
                If readerRole.Read() Then
                    Dim userRole As String = readerRole("userrole").ToString()
                    If userRole = "admin" Then
                        Me.Hide()
                        AdminHome.Show()
                    Else
                        Me.Hide()
                        Home.Show()
                    End If
                End If
                READERrole.Close()
            ElseIf count < 1 Then
                MessageBox.Show("Username and/or Password is incorrect!", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            connLogin.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connLogin.Close()
        End Try
    End Sub
End Class