Imports MySql.Data.MySqlClient
Public Class Order_List

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")


    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `order_list`(`Order_ID`, `Drug/Item_Name`, `Category`, `Brand_Name`, `Quantity`, `Unit_Price`, `Required_Quantity`, `Date_of_issue`) VALUES (@id,@name,@category,@brdname,@quantity,@price,@required,@date)", connection)

        insert_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBorderid.Text
        insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = CMBdrugname.Text
        insert_command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CMBcatg.Text
        insert_command.Parameters.Add("@brdname", MySqlDbType.VarChar).Value = CMBbname.Text
        insert_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = CMBquentity.Text
        insert_command.Parameters.Add("@price", MySqlDbType.Decimal).Value = TextBox5.Text
        insert_command.Parameters.Add("@required", MySqlDbType.Int64).Value = TBquentity.Text
        insert_command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTimePicker1.Value

        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted", "Correct", MessageBoxButtons.OK)

            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBquentity.Text = ""
            TextBox5.Text = ""
            TBquentity.Text = ""
            DateTimePicker1.Value = Now()


        Else
            MessageBox.Show("Data Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBquentity.Text = ""
            TextBox5.Text = ""
            TBquentity.Text = ""
            DateTimePicker1.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM order_list", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

        connection.Close()

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim search_command As New MySqlCommand("SELECT `Order_ID`, `Drug/Item_Name`, `Category`, `Brand_Name`, `Quantity`, `Unit_Price`, `Required_Quantity`, `Date_of_issue` FROM `order_list` WHERE `Order_ID`=@id", connection)

        search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBorderid.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                CMBdrugname.Text = table(0)(1)
                CMBcatg.Text = table(0)(2)
                CMBbname.Text = table(0)(3)
                CMBquentity.Text = table(0)(4)
                TextBox5.Text = table(0)(5)
                TBquentity.Text = table(0)(6)
                DateTimePicker1.Value = table(0)(7)

            Else

                CMBdrugname.Text = ""
                CMBcatg.Text = ""
                CMBbname.Text = ""
                CMBquentity.Text = ""
                TextBox5.Text = ""
                TBquentity.Text = ""
                DateTimePicker1.Value = Now()

                MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        adapter.Fill(table)
        DataGridView1.DataSource = table



    End Sub

    Function execCommand(ByVal cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then
            connection.Open()

        End If

        Try

            If cmd.ExecuteNonQuery() = 1 Then
                Return True

            Else
                Return False

            End If

        Catch ex As Exception
            MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

        If connection.State = ConnectionState.Open Then
            connection.Close()

        End If

    End Function

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        Dim update_command As New MySqlCommand("UPDATE `order_list` SET `Order_ID`=@id,`Drug/Item_Name`=@name,`Category`=@category,`Brand_Name`=@brdname,`Quantity`=@quantity,`Unit_Price`=@price,`Required_Quantity`=@required,`Date_of_issue`=@date WHERE `Order_ID`=@id", connection)

        update_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBorderid.Text
        update_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = CMBdrugname.Text
        update_command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CMBcatg.Text
        update_command.Parameters.Add("@brdname", MySqlDbType.VarChar).Value = CMBbname.Text
        update_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = CMBquentity.Text
        update_command.Parameters.Add("@price", MySqlDbType.Decimal).Value = TextBox5.Text
        update_command.Parameters.Add("@required", MySqlDbType.Int64).Value = TBquentity.Text
        update_command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTimePicker1.Value

        If execCommand(update_command) Then
            MessageBox.Show("Data Updated", "Correct", MessageBoxButtons.OK)

            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBquentity.Text = ""
            TextBox5.Text = ""
            TBquentity.Text = ""
            DateTimePicker1.Value = Now()

        Else
            MessageBox.Show("Data Not Updated")

            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBquentity.Text = ""
            TextBox5.Text = ""
            TBquentity.Text = ""
            DateTimePicker1.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM order_list", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim delete_command As New MySqlCommand("DELETE FROM `order_list` WHERE `Order_ID`=@id", connection)

        delete_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBorderid.Text

        If execCommand(delete_command) Then
            MessageBox.Show("Data Deleted", "Correct", MessageBoxButtons.OK)

            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBquentity.Text = ""
            TextBox5.Text = ""
            TBquentity.Text = ""
            DateTimePicker1.Value = Now()

        Else
            MessageBox.Show("Data Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBquentity.Text = ""
            TextBox5.Text = ""
            TBquentity.Text = ""
            DateTimePicker1.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM order_list", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
End Class