Imports MySql.Data.MySqlClient

Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub ChangePassword_Click(sender As Object, e As EventArgs) Handles ChangePassword.Click
        Dim conn As MySqlConnection = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=ordering_system2")
        Try
            conn.Open()
            ' Verify the username and current password
            Dim checkQuery As String = "SELECT * FROM ordering_system2.signup WHERE Username=@Username AND Password=@CurrentPassword"
            Dim checkCommand As MySqlCommand = New MySqlCommand(checkQuery, conn)
            checkCommand.Parameters.AddWithValue("@Username", Username.Text)
            checkCommand.Parameters.AddWithValue("@CurrentPassword", CurrentPassword.Text)

            Dim reader As MySqlDataReader = checkCommand.ExecuteReader()

            If reader.HasRows Then
                reader.Close()
                ' Update the password
                Dim updateQuery As String = "UPDATE ordering_system2.signup SET Password=@NewPassword WHERE Username=@Username"
                Dim updateCommand As MySqlCommand = New MySqlCommand(updateQuery, conn)
                updateCommand.Parameters.AddWithValue("@Username", Username.Text)
                updateCommand.Parameters.AddWithValue("@NewPassword", NewPassword.Text)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid username or current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim conn As MySqlConnection
        Dim COMMAND As MySqlCommand

        conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=ordering_system2")

        Try
            conn.Open()

            ' Verify the username and password
            Dim checkQuery As String = "SELECT * FROM ordering_system2.signup WHERE Username=@Username AND Password=@Password"
            COMMAND = New MySqlCommand(checkQuery, conn)
            COMMAND.Parameters.AddWithValue("@Username", Username.Text)
            COMMAND.Parameters.AddWithValue("@Password", CurrentPassword.Text)

            Dim reader As MySqlDataReader = COMMAND.ExecuteReader()

            If reader.HasRows Then
                reader.Close()

                ' Delete the user from the database
                Dim deleteQuery As String = "DELETE FROM ordering_system2.signup WHERE Username=@Username AND Password=@Password"
                Dim deleteCommand As MySqlCommand = New MySqlCommand(deleteQuery, conn)
                deleteCommand.Parameters.AddWithValue("@Username", Username.Text)
                deleteCommand.Parameters.AddWithValue("@Password", CurrentPassword.Text)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to delete account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

End Class
