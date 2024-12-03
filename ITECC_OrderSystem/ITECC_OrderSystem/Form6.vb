Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form6

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=ordering_system2"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "insert into ordering_system2.signup (FirstName,LastName,PhoneNumber,Address,Email,Username,Password) 
            values('" & TB_FirstName.Text & "','" & TB_LastName.Text & "','" & TB_PhoneNo.Text & "','" & TB_Address.Text & "', 
            '" & TB_Email.Text & "', '" & TB_Username.Text & "', '" & TB_Password.Text & "')"

            COMMAND = New MySqlCommand(Query, conn)
            COMMAND = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader
            MessageBox.Show("Data Saved")
            Form5.Show()
            Me.Hide()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub bttn_GoLogIn_Click(sender As Object, e As EventArgs) Handles bttn_GoLogIn.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim diolag As DialogResult
        DialogResult = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If DialogResult = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class