Imports MySql.Data.MySqlClient

Module CRUDDbConnection
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server= 127.0.0.1;username=root;password=;database=test")
    End Function
    Public strcon As MySqlConnection = strconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO SAVE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("SUCCESS TO SAVE DATA", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                '.CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO UPDATE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("SUCCESS TO UPDATE DATA", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO DELETE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("SUCCESS TO DELETE DATA", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

End Module
