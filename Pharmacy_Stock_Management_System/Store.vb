Imports MySql.Data.MySqlClient
Public Class Store

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `store`(`Serial_No`,`Batch_No`, `Drug/Item_Name`, `Category`, `Brand_Name`, `Manufacturer`, `Local_Agent`, `Expire_Date`, `Quantity`, `Unit_Price`, `Storage_Location_ID`, `Available`) VALUES (@srno,@bthno,@drgname,@category,@brdname,@manufct,@loclagnt,@expdate,@quantity,@price,@slid,@available)", connection)

        insert_command.Parameters.Add("@srno", MySqlDbType.Int64).Value = TBserialno.Text
        insert_command.Parameters.Add("@bthno", MySqlDbType.Int64).Value = TBbatchno.Text
        insert_command.Parameters.Add("@drgname", MySqlDbType.VarChar).Value = CMBdrugname.Text
        insert_command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CMBcatg.Text
        insert_command.Parameters.Add("@brdname", MySqlDbType.VarChar).Value = CMBbname.Text
        insert_command.Parameters.Add("@manufct", MySqlDbType.VarChar).Value = CMBmanufact.Text
        insert_command.Parameters.Add("@loclagnt", MySqlDbType.VarChar).Value = CMBlocagent.Text
        insert_command.Parameters.Add("@expdate", MySqlDbType.Date).Value = DateTimePicker1.Value
        insert_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = CMBquentity.Text
        insert_command.Parameters.Add("@price", MySqlDbType.Decimal).Value = TBprice.Text
        insert_command.Parameters.Add("@slid", MySqlDbType.Int64).Value = TBlocationid.Text
        insert_command.Parameters.Add("@available", MySqlDbType.Int64).Value = TBpurchased.Text

        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted", "Correct", MessageBoxButtons.OK)

            TBserialno.Text = ""
            TBbatchno.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBlocationid.Text = ""
            TBpurchased.Text = ""


        Else
            MessageBox.Show("Data Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBserialno.Text = ""
            TBbatchno.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBlocationid.Text = ""
            TBpurchased.Text = ""


        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM store", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

        connection.Close()

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim search_command As New MySqlCommand("SELECT `Serial_No`, `Batch_No`, `Drug/Item_Name`, `Category`, `Brand_Name`, `Manufacturer`, `Local_Agent`, `Expire_Date`, `Quantity`, `Unit_Price`, `Storage_Location_ID`, `Available` FROM `store` WHERE `Serial No`=@srno", connection)

        search_command.Parameters.Add("@srno", MySqlDbType.Int64).Value = TBserialno.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                TBserialno.Text = table(0)(1)
                TBbatchno.Text = table(0)(2)
                CMBdrugname.Text = table(0)(3)
                CMBcatg.Text = table(0)(4)
                CMBbname.Text = table(0)(5)
                CMBmanufact.Text = table(0)(6)
                CMBlocagent.Text = table(0)(7)
                DateTimePicker1.Value = table(0)(8)
                CMBquentity.Text = table(0)(9)
                TBprice.Text = table(0)(10)
                TBlocationid.Text = table(0)(11)
                TBpurchased.Text = table(0)(12)

            Else

                TBserialno.Text = ""
                TBbatchno.Text = ""
                CMBdrugname.Text = ""
                CMBcatg.Text = ""
                CMBbname.Text = ""
                CMBmanufact.Text = ""
                CMBlocagent.Text = ""
                DateTimePicker1.Value = Now()
                CMBquentity.Text = ""
                TBprice.Text = ""
                TBlocationid.Text = ""
                TBpurchased.Text = ""

                MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        If TBpurchased.Text <= 30 Then
            MessageBox.Show("Please pay attention! The stock quantity of this drug is limited.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        If DateTimePicker1.Value > DateValue(Now) Then
            MessageBox.Show("Please pay attention! This drug is out of date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim update_command As New MySqlCommand("UPDATE `store` SET `Serial_No`=@srno,`Batch_No`=@bthno,`Drug/Item_Name`=@drgname,`Category`=@category,`Brand_Name`=@brdname,`Manufacturer`=@manufct,`Local_Agent`=@loclagnt,`Expire_Date`=@expdate,`Quantity`=@quantity,`Unit_Price`=@price,`Storage_Location_ID`=@slid,`Amount_of_available_in_Store`=@amount WHERE `Serial No`=@srno", connection)

        update_command.Parameters.Add("@srno", MySqlDbType.Int64).Value = TBserialno.Text
        update_command.Parameters.Add("@bthno", MySqlDbType.Int64).Value = TBbatchno.Text
        update_command.Parameters.Add("@drgname", MySqlDbType.VarChar).Value = CMBdrugname.Text
        update_command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CMBcatg.Text
        update_command.Parameters.Add("@brdname", MySqlDbType.VarChar).Value = CMBbname.Text
        update_command.Parameters.Add("@manufct", MySqlDbType.VarChar).Value = CMBmanufact.Text
        update_command.Parameters.Add("@loclagnt", MySqlDbType.VarChar).Value = CMBlocagent.Text
        update_command.Parameters.Add("@expdate", MySqlDbType.Date).Value = DateTimePicker1.Value
        update_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = CMBquentity.Text
        update_command.Parameters.Add("@price", MySqlDbType.Decimal).Value = TBprice.Text
        update_command.Parameters.Add("@slid", MySqlDbType.Int64).Value = TBlocationid.Text
        update_command.Parameters.Add("@amount", MySqlDbType.Int64).Value = TBpurchased.Text


        If execCommand(update_command) Then
            MessageBox.Show("Data Updated", "Correct", MessageBoxButtons.OK)

            TBserialno.Text = ""
            TBbatchno.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBlocationid.Text = ""
            TBpurchased.Text = ""

        Else
            MessageBox.Show("Data Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBserialno.Text = ""
            TBbatchno.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBlocationid.Text = ""
            TBpurchased.Text = ""

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM store", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim delete_command As New MySqlCommand("DELETE FROM `store` WHERE `Serial_No`=@srno", connection)

        delete_command.Parameters.Add("@srno", MySqlDbType.Int64).Value = TBbatchno.Text

        If execCommand(delete_command) Then
            MessageBox.Show("Data Deleted", "Correct", MessageBoxButtons.OK)

        Else
            MessageBox.Show("Data Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM store", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub


End Class


