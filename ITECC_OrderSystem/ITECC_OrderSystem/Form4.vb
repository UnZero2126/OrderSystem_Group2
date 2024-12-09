Imports MySql.Data.MySqlClient

Public Class Form4
    Public Property SharedConnection As MySqlConnection

    Public Sub New()
        InitializeComponent()
        SharedConnection = New MySqlConnection("server=127.0.0.1;userid=root;password=;database=ordering_system2;SslMode=None")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim voucherCode As String = TextBox1.Text.Trim()
        Dim discountPercent As Decimal = 0D

        If String.IsNullOrEmpty(voucherCode) Then
            MessageBox.Show("Please enter a voucher code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If SharedConnection Is Nothing Then
                MessageBox.Show("Database connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If SharedConnection.State = ConnectionState.Closed Then SharedConnection.Open()

            ' retrieve discount percentage
            Dim query As String = "SELECT discountValue FROM voucher WHERE name = @voucherCode LIMIT 1"
            Using cmd As New MySqlCommand(query, SharedConnection)
                cmd.Parameters.AddWithValue("@voucherCode", voucherCode)

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    discountPercent = Convert.ToDecimal(result)
                    MessageBox.Show($"Voucher applied! Discount: {discountPercent}% off", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Update global discount in SharedData
                    SharedData.AppliedDiscountPercent = discountPercent
                Else
                    MessageBox.Show("Invalid voucher code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error validating voucher: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If SharedConnection IsNot Nothing AndAlso SharedConnection.State = ConnectionState.Open Then
                SharedConnection.Close()
            End If
        End Try

        Form3.ApplyDiscount(SharedData.AppliedDiscountPercent)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Close()
    End Sub
End Class