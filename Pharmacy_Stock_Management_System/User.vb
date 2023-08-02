Imports MySql.Data.MySqlClient
Public Class User

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `user`(`Full_Name`, `Gender`, `Date_of_Birth`, `Age`, `Username`, `Password`, `Address`, `Telephone_No`) VALUES (@flname, @gender, @brd, @age, @username, @password, @address, @telephone)", connection)



        insert_command.Parameters.Add("@flname", MySqlDbType.VarChar).Value = TBname.Text
        insert_command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = CMBgender.Text
        insert_command.Parameters.Add("@brd", MySqlDbType.Date).Value = DTPdob.Value
        insert_command.Parameters.Add("@age", MySqlDbType.Int64).Value = TBage.Text
        insert_command.Parameters.Add("@username", MySqlDbType.VarChar).Value = CMBusername.Text
        insert_command.Parameters.Add("@password", MySqlDbType.Int64).Value = TBpassword.Text
        insert_command.Parameters.Add("@address", MySqlDbType.VarChar).Value = TBaddress.Text
        insert_command.Parameters.Add("@telephone", MySqlDbType.Int64).Value = TBtel.Text
        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data Inserted", "Correct", MessageBoxButtons.OK)


            TBname.Text = ""
            CMBgender.Text = ""
            DTPdob.Text = Now()
            TBage.Text = ""
            CMBusername.Text = ""
            TBpassword.Text = ""
            TBaddress.Text = ""
            TBtel.Text = ""

        Else

            MessageBox.Show("Data Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            TBname.Text = ""
            CMBgender.Text = ""
            DTPdob.Text = Now()
            TBage.Text = ""
            CMBusername.Text = ""
            TBpassword.Text = ""
            TBaddress.Text = ""
            TBtel.Text = ""



        End If

        connection.Close()
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



End Class