Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    Public Shared sqlConn As MySqlConnection
    Private Shared connectionString As String = "server=localhost;database=supermarket;userid=root;password=root"
    Public Shared Function connect() As MySqlConnection
        sqlConn = New MySqlConnection(connectionString)
        Return sqlConn
    End Function

    Public Shared Sub disconnect()
        sqlConn.Close()
    End Sub

End Class
