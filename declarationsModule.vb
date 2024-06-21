Imports MySql.Data.MySqlClient

Module declarationsModule
    Public conn As New MySqlConnection("server=127.0.0.1;port=3306;username=root;password=;database=test")
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand
End Module
