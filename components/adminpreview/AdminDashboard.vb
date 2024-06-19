Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MySQL connection string
        Dim connectionString As String = "server=127.0.0.1;port=3306;username=root;password=;database=test"

        ' Get today's date
        Dim today As Date = Date.Today
        Dim todayString As String = today.ToString("yyyy-MM-dd")

        ' Create a new connection
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' SQL query to retrieve daily sales
                Dim query As String = $"SELECT date, salesamount FROM dailysalestb WHERE date = '{todayString}'"

                ' Create a DataTable to hold the query results
                Dim dataTable As New DataTable()

                ' Create a new MySQLDataAdapter
                Using adapter As New MySqlDataAdapter(query, connection)
                    ' Fill the DataTable with the query results
                    adapter.Fill(dataTable)
                End Using

                ' Bind the DataTable to the DataGridView
                DataGridView1.DataSource = dataTable

                ' Configure the Chart
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