Imports MySql.Data.MySqlClient

Public Class Form5

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub bttn_Login_Click(sender As Object, e As EventArgs) Handles bttn_Login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=ordering_system2"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM ordering_system2.signup WHERE Username='" & TB_Username.Text & "' AND Password='" & TB_Password.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer = 0
            Dim userAddress As String = ""
            Dim username As String = ""

            While READER.Read()
                count += 1
                If READER.HasRows Then
                    userAddress = READER("Address").ToString() ' Fetch the address and username of the logged-in user
                    username = READER("Username").ToString()
                End If
            End While

            If count = 1 Then
                SharedData.LoggedIn = True
                SharedData.UserAddress = userAddress ' Store the address in SharedData
                SharedData.username = username
                Form1.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username and password are not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub bttn_signup_Click(sender As Object, e As EventArgs) Handles bttn_signup.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub bttn_forgotPW_Click(sender As Object, e As EventArgs) Handles bttn_forgotPW.Click
        Form7.Show()
        Me.Hide()

    End Sub
    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim diolag As DialogResult
        DialogResult = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If DialogResult = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class