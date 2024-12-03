Imports MySql.Data.MySqlClient

Public Class Form3
    Dim conn As MySqlConnection
    Private discountPercent As Decimal = 0D ' Storage for applied discount

    Private Sub bttn_frm3BtOrder_Click(sender As Object, e As EventArgs) Handles bttn_frm3BtOrder.Click
        Form1.Show()
        Me.Close()
    End Sub

    Public Sub UpdateLabel(itemList As String, Optional subtotalValue As Decimal = 0D)
        Label_ListofOrder.Text = itemList ' Display the list of selected items
        Subtotal.Text = Format(subtotalValue, "C2") ' Display the subtotal in currency format
        UpdateTotal() ' Recalculate totals if the label is updated
    End Sub

    Private Sub UpdateTotal() 'tryy munaaa version2 sa notepad
        Dim subtotalValue As Decimal
        If Decimal.TryParse(Subtotal.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.CurrentCulture, subtotalValue) Then
            Dim discountAmount As Decimal = subtotalValue * (discountPercent / 100)
            Dim totalValue As Decimal = subtotalValue - discountAmount
            If totalValue < 0 Then totalValue = 0

            discount.Text = Format(discountAmount, "C2")
            Total.Text = Format(totalValue, "C2")
        Else
            MessageBox.Show("Error parsing subtotal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Apply a discount and recalculate the total amount to display ayokoo na looordd waaaaaaaahhh
    Public Sub ApplyDiscount(value As Decimal)
        discountPercent = value ' Update the stored discount percentage
        UpdateTotal()
    End Sub

    ' Apply the saved discount value when the form loads
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the discount from SharedData
        If SharedData.AppliedDiscountPercent > 0D Then
            ApplyDiscount(SharedData.AppliedDiscountPercent)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form4 As New Form4()
        form4.SharedConnection = Form1.conn ' Pass the connection from Form1
        form4.Show()
        Me.Hide()
    End Sub

End Class
