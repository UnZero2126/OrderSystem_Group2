Imports MySql.Data.MySqlClient

Public Class Form8
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub ChangeAddress_Click(sender As Object, e As EventArgs) Handles ChangeAddress.Click
        If Not SharedData.LoggedIn Then
            MessageBox.Show("You must be logged in to change your address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate input
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter a valid address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=ordering_system2")

        Try
            conn.Open()
            Dim query As String = "UPDATE ordering_system2.signup SET Address = @newAddress WHERE Username = @username"

            Using COMMAND As New MySqlCommand(query, conn)
                COMMAND.Parameters.AddWithValue("@newAddress", TextBox1.Text)
                COMMAND.Parameters.AddWithValue("@username", SharedData.username)

                Dim rowsAffected As Integer = COMMAND.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Address changed successfully.")
                    SharedData.UserAddress = TextBox1.Text
                    Form3.ApplyDeliveryCharge(TextBox1.Text) ' update the current address in the ui and total calculation
                Else
                    MessageBox.Show("No record updated. Please check your username.")
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
