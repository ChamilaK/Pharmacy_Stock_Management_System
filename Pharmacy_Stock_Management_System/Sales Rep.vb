Imports MySql.Data.MySqlClient
Public Class Sales_Rep

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `sales_rep`(`Issued_Order_id`, `Rep_ID`, `Full_Name`, `Gender`,  `Date_of_issue`, `Telephone_No`) VALUES (@ordid, @id,@flname,@gender,@date,@tel)", connection)

        insert_command.Parameters.Add("@ordid", MySqlDbType.Int64).Value = TBorderid.Text
        insert_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBrepid.Text
        insert_command.Parameters.Add("@flname", MySqlDbType.VarChar).Value = TBname.Text
        insert_command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = CMBgender.Text
        insert_command.Parameters.Add("@date", MySqlDbType.Date).Value = DTPdate.Value
        insert_command.Parameters.Add("@tel", MySqlDbType.Int64).Value = TBtel.Text

        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted", "Correct", MessageBoxButtons.OK)

            TBorderid.Text = ""
            TBrepid.Text = ""
            TBname.Text = ""
            CMBgender.Text = ""
            DTPdate.Value = Now()
            TBtel.Text = ""

        Else
            MessageBox.Show("Data Not Inserted")

            TBorderid.Text = ""
            TBrepid.Text = ""
            TBname.Text = ""
            CMBgender.Text = ""
            DTPdate.Value = Now()
            TBtel.Text = ""

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM sales_rep", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

        connection.Close()

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim search_command As New MySqlCommand("SELECT `Issued_Order_id`, `Rep_id`, `Full_Name`, `Gender`, `Date_of_issue`, `Telephone_No` FROM `sales_rep` WHERE  `Issued_Order_ID`=@ordid", connection)

        search_command.Parameters.Add("@ordid", MySqlDbType.Int64).Value = TBorderid.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                TBrepid.Text = table(0)(1)
                TBname.Text = table(0)(2)
                CMBgender.Text = table(0)(3)
                DTPdate.Value = table(0)(4)
                TBtel.Text = table(0)(5)

            Else


                TBrepid.Text = ""
                TBname.Text = ""
                CMBgender.Text = ""
                DTPdate.Value = Now()
                TBtel.Text = ""

                MessageBox.Show("No Data Found")

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

        Dim update_command As New MySqlCommand("UPDATE `sales_rep` SET `Issued_Order_id`=@ordid,`Rep_id`=@id,`Full_Name`=@flname,`Gender`=@gender,`Date_of_issue`=@date,`Telephone_No`=@tel WHERE `Issued_Order_id`=@ordid", connection)

        update_command.Parameters.Add("@ordid", MySqlDbType.Int64).Value = TBorderid.Text
        update_command.Parameters.Add("@id", MySqlDbType.Int64).Value = TBrepid.Text
        update_command.Parameters.Add("@flname", MySqlDbType.VarChar).Value = TBname.Text
        update_command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = CMBgender.Text
        update_command.Parameters.Add("@date", MySqlDbType.Date).Value = DTPdate.Value
        update_command.Parameters.Add("@tel", MySqlDbType.Int64).Value = TBtel.Text


        If execCommand(update_command) Then
            MessageBox.Show("Data Updated", "Correct", MessageBoxButtons.OK)

            TBorderid.Text = ""
            TBrepid.Text = ""
            TBname.Text = ""
            CMBgender.Text = ""
            DTPdate.Value = Now()
            TBtel.Text = ""

        Else
            MessageBox.Show("Data Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBorderid.Text = ""
            TBrepid.Text = ""
            TBname.Text = ""
            CMBgender.Text = ""
            DTPdate.Value = Now()
            TBtel.Text = ""

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM sales_rep", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim delete_command As New MySqlCommand("DELETE FROM `sales_rep` WHERE `Issued_Order_ID`=@ordid", connection)

        delete_command.Parameters.Add("@ordid", MySqlDbType.Int64).Value = TBorderid.Text

        If execCommand(delete_command) Then
            MessageBox.Show("Data Deleted", "Correct", MessageBoxButtons.OK)

            TBorderid.Text = ""
            TBrepid.Text = ""
            TBname.Text = ""
            CMBgender.Text = ""
            DTPdate.Value = Now()
            TBtel.Text = ""

        Else
            MessageBox.Show("Data Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBorderid.Text = ""
            TBrepid.Text = ""
            TBname.Text = ""
            CMBgender.Text = ""
            DTPdate.Value = Now()
            TBtel.Text = ""


        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM sales_rep", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

End Class