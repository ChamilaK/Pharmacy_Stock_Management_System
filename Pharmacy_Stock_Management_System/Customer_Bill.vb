Imports MySql.Data.MySqlClient
Public Class Customer_Bill

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `customer_bill`(`Date_of_Purchase`, `Custemer_id`, `Drug/Item_Name`, `Quantity`, `Unit_Price`, `Amount_of_Purchase`, `Total_Price`) VALUES (@prchdate,@cusid,@drgname,@quantity,@price,@amount,@total)", connection)

        insert_command.Parameters.Add("@prchdate", MySqlDbType.Date).Value = DateTimePicker1.Value
        insert_command.Parameters.Add("@cusid", MySqlDbType.Int64).Value = TBcusid.Text
        insert_command.Parameters.Add("@drgname", MySqlDbType.VarChar).Value = TBitemname.Text
        insert_command.Parameters.Add("@quantity", MySqlDbType.Text).Value = TBquentity.Text
        insert_command.Parameters.Add("@price", MySqlDbType.Decimal).Value = TBprice.Text
        insert_command.Parameters.Add("@amount", MySqlDbType.Int64).Value = TBamount.Text
        insert_command.Parameters.Add("@total", MySqlDbType.Int64).Value = TBtotal.Text

        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted", "Correct", MessageBoxButtons.OK)

            DateTimePicker1.Value = Now()
            TBcusid.Text = ""
            TBitemname.Text = ""
            TBquentity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""

        Else
            MessageBox.Show("Data Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            DateTimePicker1.Value = Now()
            TBcusid.Text = ""
            TBitemname.Text = ""
            TBquentity.Text = ""
            TBprice.Text = ""
            TBamount.Text = ""
            TBtotal.Text = ""

        End If

        connection.Close()

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim search_command As New MySqlCommand("SELECT `Customer_ID`, `Drug/Item_Name`, `Quantity`, `Unit_Price`, `Amount_of_Purchase`, `Total`, `Date_of_Purchase` FROM `customer` WHERE `Customer_ID`=@id", connection)

        search_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBcusid.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                TBitemname.Text = table(0)(1)
                TBquentity.Text = table(0)(2)
                TBprice.Text = table(0)(3)
                TBamount.Text = table(0)(4)
                TBtotal.Text = table(0)(5)
                DateTimePicker1.Value = table(0)(6)

            Else

                TBitemname.Text = ""
                TBquentity.Text = ""
                TBprice.Text = ""
                TBamount.Text = ""
                TBtotal.Text = ""
                DateTimePicker1.Value = Now()

                MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

        Catch ex As Exception
            MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



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









    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TBamount.TextChanged

        Try
            TBtotal.Text = (Decimal.Parse(TBprice.Text) * Decimal.Parse(TBamount.Text)).ToString()

        Catch ex As Exception

        End Try

    End Sub


End Class