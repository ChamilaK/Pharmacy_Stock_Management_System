Imports MySql.Data.MySqlClient
Public Class Form1

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub CheckBoxSP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSP.CheckedChanged

        If TextBoxPassword.UseSystemPasswordChar = True Then

            'show password

            TextBoxPassword.UseSystemPasswordChar = False

        Else

            'hide Password

            TextBoxPassword.UseSystemPasswordChar = True



        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Dim Command As New MySqlCommand("SELECT `User_ID`, `Full_Name`, `Gender`, `Date_of_Birth`, `Age`, `Username`, `Password`, `Address`, `Telephone_No` FROM `user` WHERE  `Username` = @Username AND`Password` = @Password", connection)

        Command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        Command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxPassword.Text

        Dim adapter As New MySqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)

        'var Username = db Username

        If table.Rows.Count = 1 Then

            For Each row As DataRow In table.Rows
                Dim Username As String
                Username = row("Username")

                If Username = "Admin" Then
                    Dim newForm As New Admin()
                    newForm.Show()

                Else
                    Dim newForm As New Pharmacist()
                    newForm.Show()

                End If




                'For Each cell As String In row. ItemArray

                'MessageBox.Show(Username)
                'Next

            Next

            TextBoxUsername.Text = ""
            TextBoxPassword.Text = ""

        Else

            MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'msgBox("Loggin Error")

            TextBoxUsername.Text = ""
            TextBoxPassword.Text = ""

        End If
    End Sub

    Private Sub LabelForget_Click(sender As Object, e As EventArgs) Handles LabelForget.Click

        Dim newForm As New Sign()
        newForm.Show()
    End Sub


End Class
