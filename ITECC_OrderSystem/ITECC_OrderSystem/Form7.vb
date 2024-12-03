Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing
Imports System.Net
Imports System.Net.Mail

Public Class Form7

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub bttn_Retrieve_Click(sender As Object, e As EventArgs) Handles bttn_Retrieve.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=ordering_system2"

        Try
            conn.Open()

            Dim Query As String = "SELECT Password FROM signup WHERE Username = @Username AND Email = @Email"

            COMMAND = New MySqlCommand(Query, conn)
            COMMAND.Parameters.AddWithValue("@Username", TB_Username.Text)
            COMMAND.Parameters.AddWithValue("@Email", TB_Email.Text)

            READER = COMMAND.ExecuteReader()

            If READER.HasRows Then
                READER.Read()
                Dim retrievedPassword As String = READER("Password").ToString()

                SendPasswordByEmail(TB_Email.Text, retrievedPassword)

            Else
                MessageBox.Show("No user found with the provided username and email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            READER.Close()
            conn.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub SendPasswordByEmail(emailAddress As String, password As String)
        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New NetworkCredential("jannrailey852@gmail.com", "lbqc hvng plhc gnce")
            smtpClient.EnableSsl = True

            ' Creating email message
            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress("jannrailey852l@gmail.com")
            mailMessage.To.Add(emailAddress)
            mailMessage.Subject = "Your Password Recovery"
            mailMessage.Body = "Hello, your password is: " & password

            ' Sending email
            smtpClient.Send(mailMessage)
            MessageBox.Show("Password has been sent successfully!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.ToString(), "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bttn_close_Click(sender As Object, e As EventArgs) Handles bttn_close.Click
        Form5.Show()
        Me.Hide()

    End Sub
End Class