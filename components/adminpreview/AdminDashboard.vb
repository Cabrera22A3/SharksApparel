Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=127.0.0.1;port=3306;username=root;password=;database=test"

        Dim today As Date = Date.Today
        Dim todayString As String = today.ToString("yyyy-MM-dd")

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = $"SELECT date, salesamount FROM dailysalestb WHERE date = '{todayString}'"

                Dim dataTable As New DataTable()

                Using adapter As New MySqlDataAdapter(query, connection)
                    adapter.Fill(dataTable)
                End Using

                DataGridView1.DataSource = dataTable

                Chart1.DataSource = dataTable
                Chart1.Series.Clear()
                Dim series As New Series("Daily Sales")
                series.XValueMember = "date"
                series.YValueMembers = "salesamount"
                series.ChartType = SeriesChartType.Bar
                Chart1.Series.Add(series)
                Chart1.DataBind()

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class