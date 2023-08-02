Imports MySql.Data.MySqlClient
Public Class Main_Pharmacy

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub ButtonInsert_Click_1(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `main_pharmacy`(`Registration_Number`, `Pharmacy_Name`, `Address`, `Telephone_No`, `E-mail`, `Fax`) VALUES (@regno,@name,@address,@tel,@mail,@fax)", connection)

        insert_command.Parameters.Add("@regno", MySqlDbType.Int64).Value = TBregid.Text
        insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TBpharmaname.Text
        insert_command.Parameters.Add("@address", MySqlDbType.VarChar).Value = TBaddress.Text
        insert_command.Parameters.Add("@tel", MySqlDbType.Int64).Value = TBtel.Text
        insert_command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = TBemail.Text
        insert_command.Parameters.Add("@fax", MySqlDbType.Int64).Value = TBfax.Text

        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted", "Correct", MessageBoxButtons.OK)

            TBregid.Text = ""
            TBpharmaname.Text = ""
            TBaddress.Text = ""
            TBtel.Text = ""
            TBemail.Text = ""
            TBfax.Text = ""

        Else
            MessageBox.Show("Data Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBregid.Text = ""
            TBpharmaname.Text = ""
            TBaddress.Text = ""
            TBtel.Text = ""
            TBemail.Text = ""
            TBfax.Text = ""

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM main_pharmacy", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

        connection.Close()

    End Sub

    Private Sub ButtonSearch_Click_1(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim search_command As New MySqlCommand("SELECT `Registration_Number`, `Pharmacy_Name`, `Address`, `Telephone_No`, `E-mail`, `Fax` FROM `main_pharmacy` WHERE `Registration_Number`=@regno", connection)

        search_command.Parameters.Add("@regno", MySqlDbType.Int64).Value = TBregid.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()

        Try

            adapter.Fill(table)


            If table.Rows.Count > 0 Then

                TBpharmaname.Text = table(0)(1)
                TBaddress.Text = table(0)(2)
                TBtel.Text = table(0)(3)
                TBemail.Text = table(0)(4)
                TBfax.Text = table(0)(5)

            Else

                TBpharmaname.Text = ""
                TBaddress.Text = ""
                TBtel.Text = ""
                TBemail.Text = ""
                TBfax.Text = ""

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

    Private Sub ButtonUpdate_Click_1(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        Dim update_command As New MySqlCommand("UPDATE `main_pharmacy` SET `Registration_Number`=@regno,`Pharmacy_Name`=@name,`Address`=@address,`Telephone_No`=@tel,`E-mail`=@mail,`Fax`=@fax WHERE `Registration_Number`=@regno", connection)

        update_command.Parameters.Add("@regno", MySqlDbType.Int64).Value = TBregid.Text
        update_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TBpharmaname.Text
        update_command.Parameters.Add("@address", MySqlDbType.VarChar).Value = TBaddress.Text
        update_command.Parameters.Add("@tel", MySqlDbType.Int64).Value = TBtel.Text
        update_command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = TBemail.Text
        update_command.Parameters.Add("@fax", MySqlDbType.Int64).Value = TBfax.Text

        If execCommand(update_command) Then
            MessageBox.Show("Data Updated", "Correct", MessageBoxButtons.OK)

            TBregid.Text = ""
            TBpharmaname.Text = ""
            TBaddress.Text = ""
            TBtel.Text = ""
            TBemail.Text = ""
            TBfax.Text = ""

        Else
            MessageBox.Show("Data Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM main_pharmacy", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub ButtonDelete_Click_1(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim delete_command As New MySqlCommand("DELETE FROM `main_pharmacy` WHERE `Registration_Number`=@regno", connection)

        delete_command.Parameters.Add("regno", MySqlDbType.Int64).Value = TBregid.Text

        If execCommand(delete_command) Then
            MessageBox.Show("Data Deleted", "Correct", MessageBoxButtons.OK)

            TBregid.Text = ""
            TBpharmaname.Text = ""
            TBaddress.Text = ""
            TBtel.Text = ""
            TBemail.Text = ""
            TBfax.Text = ""

        Else
            MessageBox.Show("Data Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Dim adapter As New MySqlDataAdapter("SELECT * FROM main_pharmacy", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
End Class