Imports MySql.Data.MySqlClient
Public Class MYDBcon
    Dim conn As New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=s_t_d")

    Public Function getconnection() As MySqlConnection

        Return conn

    End Function

    Sub OpenConnection()

        If conn.State = ConnectionState.Closed Then
            conn.Close()

        End If
    End Sub

End Class
