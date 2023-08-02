Imports MySql.Data.MySqlClient
Public Class Search_Store_by_Date

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `store` WHERE `Expire_Date` BETWEEN @d1 AND @d2", connection)

        command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
        command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value

        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub
End Class