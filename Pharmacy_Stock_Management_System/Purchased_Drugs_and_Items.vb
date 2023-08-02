Imports MySql.Data.MySqlClient
Public Class Purchased_Drugs_and_Items

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click


        Dim insert_command As New MySqlCommand("INSERT INTO `purchased_drugs_items`(`Purchased_ID`, `Drug/Item_Name`, `Category`, `Brand_Name`, `Manufacturer`, `Local_Agent`, `Batch_No`, `Expire_Date`, `Quantity`, `Unit_Price`, `Amount_of_Purchase`, `Total`,`Date_of_Purchase`) VALUES (@id,@name,@category,@brdname,@manufact,@loclagent,@bthno,@expdate,@quantity,@price,@purchase,@total,@prhdate)", connection)

        insert_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBpurid.Text
        insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = CMBdrugname.Text
        insert_command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CMBcatg.Text
        insert_command.Parameters.Add("@brdname", MySqlDbType.VarChar).Value = CMBbname.Text
        insert_command.Parameters.Add("@manufact", MySqlDbType.VarChar).Value = CMBmanufact.Text
        insert_command.Parameters.Add("@loclagent", MySqlDbType.VarChar).Value = CMBlocagent.Text
        insert_command.Parameters.Add("@bthno", MySqlDbType.Int64).Value = TBbatchno.Text
        insert_command.Parameters.Add("@expdate", MySqlDbType.Date).Value = DateTimePicker1.Value
        insert_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = CMBquentity.Text
        insert_command.Parameters.Add("@price", MySqlDbType.Double).Value = TBprice.Text
        insert_command.Parameters.Add("@purchase", MySqlDbType.Int64).Value = TBamount.Text
        insert_command.Parameters.Add("@total", MySqlDbType.Double).Value = TBtotal.Text
        insert_command.Parameters.Add("@prhdate", MySqlDbType.Date).Value = DateTimePicker2.Value


        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted", "Correct", MessageBoxButtons.OK)

            TBpurid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            TBbatchno.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker2.Value = Now()

        Else
            MessageBox.Show("Data Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBpurid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            TBbatchno.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker2.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM purchased_drugs_items", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

        connection.Close()

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim search_command As New MySqlCommand("SELECT `Purchased_ID`, `Drug/Item_Name`, `Category`, `Brand_Name`, `Manufacturer`, `Local_Agent`, `Batch_No`, `Expire_Date`, `Quantity`, `Unit_Price`, `Amount_of_Purchase`, `Total`, `Date_of_Purchase` FROM `purchased_drugs_items` WHERE `Purchased_ID`=@id", connection)

        search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBpurid.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                CMBdrugname.Text = table(0)(1)
                CMBcatg.Text = table(0)(2)
                CMBbname.Text = table(0)(3)
                CMBmanufact.Text = table(0)(4)
                CMBlocagent.Text = table(0)(5)
                TBbatchno.Text = table(0)(6)
                DateTimePicker1.Value = table(0)(7)
                CMBquentity.Text = table(0)(8)
                TBprice.Text = table(0)(9)
                TBamount.Text = table(0)(10)
                TBtotal.Text = table(0)(11)
                DateTimePicker2.Value = table(0)(12)

            Else

                CMBdrugname.Text = ""
                CMBcatg.Text = ""
                CMBbname.Text = ""
                CMBmanufact.Text = ""
                CMBlocagent.Text = ""
                TBbatchno.Text = ""
                DateTimePicker1.Value = Now()
                CMBquentity.Text = ""
                TBprice.Text = ""
                TBamount.Text = ""
                TBtotal.Text = ""
                DateTimePicker2.Value = Now()

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

        Dim update_command As New MySqlCommand("UPDATE `purchased_drugs_items` SET `Purchased_ID`=@id,`Drug/Item_Name`=@name,`Category`=@category,`Brand_Name`=@brdname,`Manufacturer`=@manufact,`Local_Agent`=@loclagent,`Batch_No`=@bthno,`Expire_Date`=@expdate,`Quantity`=@quantity,`Unit_Price`=@price,`Amount_of_Purchase`=@purchase,'Total'=@total,`Date_of_Purchase`=@prhdate WHERE `Purchased_ID`=@id", connection)

        update_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBpurid.Text
        update_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = CMBdrugname.Text
        update_command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CMBcatg.Text
        update_command.Parameters.Add("@brdname", MySqlDbType.VarChar).Value = CMBbname.Text
        update_command.Parameters.Add("@manufact", MySqlDbType.VarChar).Value = CMBmanufact.Text
        update_command.Parameters.Add("@loclagent", MySqlDbType.VarChar).Value = CMBlocagent.Text
        update_command.Parameters.Add("@bthno", MySqlDbType.Int64).Value = TBbatchno.Text
        update_command.Parameters.Add("@expdate", MySqlDbType.Date).Value = DateTimePicker1.Value
        update_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = CMBquentity.Text
        update_command.Parameters.Add("@price", MySqlDbType.Decimal).Value = TBprice.Text
        update_command.Parameters.Add("@purchase", MySqlDbType.Int64).Value = TBamount.Text
        update_command.Parameters.Add("@total", MySqlDbType.Double).Value = TBtotal.Text
        update_command.Parameters.Add("@prhdate", MySqlDbType.Date).Value = DateTimePicker2.Value


        If execCommand(update_command) Then
            MessageBox.Show("Data Updated", "Correct", MessageBoxButtons.OK)

            TBpurid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            TBbatchno.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker2.Value = Now()

        Else
            MessageBox.Show("Data Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBpurid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            TBbatchno.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker2.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM purchased_drugs_items", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim delete_command As New MySqlCommand("DELETE FROM `purchased_drugs_items`  WHERE `Purchased_ID`=@id", connection)

        delete_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBpurid.Text

        If execCommand(delete_command) Then
            MessageBox.Show("Data Deleted", "Correct", MessageBoxButtons.OK)

            TBpurid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            TBbatchno.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker2.Value = Now()

        Else
            MessageBox.Show("Data Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBpurid.Text = ""
            CMBdrugname.Text = ""
            CMBcatg.Text = ""
            CMBbname.Text = ""
            CMBmanufact.Text = ""
            CMBlocagent.Text = ""
            TBbatchno.Text = ""
            DateTimePicker1.Value = Now()
            CMBquentity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker2.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM purchased_drugs_items", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub TBamount_TextChanged(sender As Object, e As EventArgs) Handles TBamount.TextChanged

        TBtotal.Text = Val(TBprice.Text) * Val(TBamount.Text)

    End Sub
End Class