Imports MySql.Data.MySqlClient
Public Class Account

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Dim Settings As New MySqlCommand
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click

        Dim insert_command As New MySqlCommand("INSERT INTO `account`(`Username`, `Password`,  `Question`, `Answer`) VALUES (@name,@password,@quest,@answer)", connection)


        insert_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TBusername.Text
        insert_command.Parameters.Add("@password", MySqlDbType.Int64).Value = TBpassword.Text
        insert_command.Parameters.Add("@quest", MySqlDbType.VarChar).Value = TBquestion.Text
        insert_command.Parameters.Add("@answer", MySqlDbType.VarChar).Value = TBanswer.Text


        connection.Open()

        If insert_command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Data Inserted", "Correct", MessageBoxButtons.OK)

            TBusername.Text = ""
            TBpassword.Text = ""
            TBquestion.Text = ""
            TBanswer.Text = ""


        Else

            MessageBox.Show("Data Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TBusername.Text = ""
            TBpassword.Text = ""
            TBquestion.Text = ""
            TBanswer.Text = ""

        End If

        connection.Close()



    End Sub

    Function execCommand(ByVal cmd As MySqlCommand) As Boolean





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


End Class