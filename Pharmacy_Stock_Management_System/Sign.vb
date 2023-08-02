Imports MySql.Data.MySqlClient
Public Class Sign

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click

        Dim search_command As New MySqlCommand("SELECT `Username`, `Password`,  `Question`, `Answer` FROM `account` WHERE `Username`=@name", connection)

        search_command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TBusername.Text

        Dim adapter As New MySqlDataAdapter(search_command)

        Dim table As New DataTable()



        adapter.Fill(table)

        'var Username = db Username

        If table.Rows.Count = 1 Then

            For Each row As DataRow In table.Rows
                Dim Username As String
                Username = row("Username")

                If Username = "Admin" Then
                    TBquestion.Text = row("Question")



                Else Username = "Pharmacist"
                    TBquestion.Text = row("Question")

                End If

                'For Each cell As String In row. ItemArray

                'MessageBox.Show(Username)
                'Next

            Next

        Else

            MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'msgBox("Loggin Error")

        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim search_command As New MySqlCommand("SELECT `Username`, `Password`, `Question`, `Answer` FROM `account` WHERE `Answer`=@answer", connection)

        search_command.Parameters.Add("@answer", MySqlDbType.VarChar).Value = TBanswer.Text

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter(search_command)

        adapter.Fill(table)


        'var Answer = db Answer

        If table.Rows.Count = 1 Then

            For Each row As DataRow In table.Rows
                Dim Answer As String
                Answer = row("Answer")

                If Answer = row("Answer") Then
                    MessageBox.Show("Your answer is correct.Now get your Password.")
                    TBpassword.Text = row("Password")

                Else Answer = row("Answer")
                    MessageBox.Show("Your answer is correct.Now get your Password.")
                    TBpassword.Text = row("Password")

                End If

                'For Each cell As String In row. ItemArray

                'MessageBox.Show()
                'Next

            Next

        Else

            MessageBox.Show("Your answer is invalid.Please check your answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'msgBox("Loggin Error")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TBusername.Text = ""
        TBquestion.Text = ""
        TBanswer.Text = ""
        TBpassword.Text = ""

    End Sub
End Class