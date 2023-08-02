Imports MySql.Data.MySqlClient
Public Class Customer

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `customer`(`Customer_ID`, `Customer_Name`, `Age`, `Gender`, `Order_ID`, `Drug/Item_Name`, `Category`, `Brand_Name`, `Quantity`, `Unit_Price`, `Amount_of_Purchase`, `Total`, `Date_of_Purchase`) VALUES (@id,@name,@age,@gender,@odrid,@drugname,@category,@brdname,@quantity,@price,@purchase,@total,@date)", connection)

        insert_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBcusid.Text
        insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TBcusname.Text
        insert_command.Parameters.Add("@age", MySqlDbType.Int64).Value = TBage.Text
        insert_command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = CMBgender.Text
        insert_command.Parameters.Add("@odrid", MySqlDbType.Int64).Value = TBorderid.Text
        insert_command.Parameters.Add("@drugname", MySqlDbType.VarChar).Value = CMBdrugname.Text
        insert_command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CMBcategory.Text
        insert_command.Parameters.Add("@brdname", MySqlDbType.VarChar).Value = CMBbname.Text
        insert_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = CMBquantity.Text
        insert_command.Parameters.Add("@price", MySqlDbType.Double).Value = TBprice.Text
        insert_command.Parameters.Add("@purchase", MySqlDbType.Int64).Value = TBamount.Text
        insert_command.Parameters.Add("@total", MySqlDbType.Double).Value = TBtotal.Text
        insert_command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTimePicker1.Value

        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted")

            TBcusid.Text = ""
            TBcusname.Text = ""
            TBage.Text = ""
            CMBgender.Text = ""
            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcategory.Text = ""
            CMBbname.Text = ""
            CMBquantity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker1.Value = Now()

        Else
            MessageBox.Show("Data Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBcusid.Text = ""
            TBcusname.Text = ""
            TBage.Text = ""
            CMBgender.Text = ""
            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcategory.Text = ""
            CMBbname.Text = ""
            CMBquantity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker1.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM customer", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

        connection.Close()


    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim search_command As New MySqlCommand("SELECT `Customer_ID`, `Customer_Name`, `Age`, `Gender`, `Order_ID`, `Drug/Item_Name`, `Category`, `Brand_Name`, `Quantity`, `Unit_Price`, `Amount_of_Purchase`, `Total`, `Date_of_Purchase` FROM `customer` WHERE `Customer_ID`=@id", connection)

        search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBcusid.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                TBcusname.Text = table(0)(1)
                TBage.Text = table(0)(2)
                CMBgender.Text = table(0)(3)
                TBorderid.Text = table(0)(4)
                CMBdrugname.Text = table(0)(5)
                CMBcategory.Text = table(0)(6)
                CMBbname.Text = table(0)(7)
                CMBquantity.Text = table(0)(8)
                TBprice.Text = table(0)(9)
                TBamount.Text = table(0)(10)
                TBtotal.Text = table(0)(11)
                DateTimePicker1.Value = table(0)(12)

            Else

                TBcusname.Text = ""
                TBage.Text = ""
                CMBgender.Text = ""
                TBorderid.Text = ""
                CMBdrugname.Text = ""
                CMBcategory.Text = ""
                CMBbname.Text = ""
                CMBquantity.Text = ""
                TBprice.Text = ""
                TBamount.Text = ""
                TBtotal.Text = ""
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
    End Function

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        Dim update_command As New MySqlCommand("UPDATE `customer` SET `Customer_ID`=@id,`Customer_Name`=@name,`Age`=@age,`Gender`=@gender,`Order_ID`=@odrid,`Drug/Item_Name`=@drugname,`Category`=@category,`Brand_Name`=@brdname,`Quantity`=@quantity,`Unit_Price`=@price,`Amount_of_Purchase`=@purchase,`Total`=@total,`Date_of_Purchase`=@date WHERE `Customer_ID`=@id", connection)

        update_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBcusid.Text
        update_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TBcusname.Text
        update_command.Parameters.Add("@age", MySqlDbType.Int64).Value = TBage.Text
        update_command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = CMBgender.Text
        update_command.Parameters.Add("@odrid", MySqlDbType.Int64).Value = TBorderid.Text
        update_command.Parameters.Add("@drugname", MySqlDbType.VarChar).Value = CMBdrugname.Text
        update_command.Parameters.Add("@category", MySqlDbType.VarChar).Value = CMBcategory.Text
        update_command.Parameters.Add("@brdname", MySqlDbType.VarChar).Value = CMBbname.Text
        update_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = CMBquantity.Text
        update_command.Parameters.Add("@price", MySqlDbType.Decimal).Value = TBprice.Text
        update_command.Parameters.Add("@purchase", MySqlDbType.Int64).Value = TBamount.Text
        update_command.Parameters.Add("@total", MySqlDbType.Double).Value = TBtotal.Text
        update_command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTimePicker1.Value

        If execCommand(update_command) Then
            MessageBox.Show("Data Updated")

            TBcusid.Text = ""
            TBcusname.Text = ""
            TBage.Text = ""
            CMBgender.Text = ""
            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcategory.Text = ""
            CMBbname.Text = ""
            CMBquantity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker1.Value = Now()

        Else
            MessageBox.Show("Data Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBcusid.Text = ""
            TBcusname.Text = ""
            TBage.Text = ""
            CMBgender.Text = ""
            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcategory.Text = ""
            CMBbname.Text = ""
            CMBquantity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker1.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM customer", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim delete_command As New MySqlCommand("DELETE FROM `customer` WHERE `Customer_ID`=@id", connection)

        delete_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBcusid.Text

        If execCommand(delete_command) Then
            MessageBox.Show("Data Deleted")

            TBcusid.Text = ""
            TBcusname.Text = ""
            TBage.Text = ""
            CMBgender.Text = ""
            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcategory.Text = ""
            CMBbname.Text = ""
            CMBquantity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker1.Value = Now()

        Else
            MessageBox.Show("Data Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBcusid.Text = ""
            TBcusname.Text = ""
            TBage.Text = ""
            CMBgender.Text = ""
            TBorderid.Text = ""
            CMBdrugname.Text = ""
            CMBcategory.Text = ""
            CMBbname.Text = ""
            CMBquantity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""
            DateTimePicker1.Value = Now()

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM customer", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub





    Private Sub TBamount_TextChanged(sender As Object, e As EventArgs) Handles TBamount.TextChanged

        TBtotal.Text = Val(TBprice.Text) * Val(TBamount.Text)

    End Sub
End Class