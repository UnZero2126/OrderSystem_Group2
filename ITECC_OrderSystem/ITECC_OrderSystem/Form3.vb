Imports MySql.Data.MySqlClient

Public Class Form3
    Private discountPercent As Decimal = 0D ' Storage for applied discount baka di na need to di ko pa suree HAHAAAHHHAHA
    Private deliveryCharge As Decimal = 0D
    Private Sub bttn_frm3BtOrder_Click(sender As Object, e As EventArgs) Handles bttn_frm3BtOrder.Click
        Form1.Show()
        Me.Close()
    End Sub

    Public Sub UpdateLabel(itemList As String, Optional subtotalValue As Decimal = 0D)
        ' Clear the ListBox and add the items line by line
        ListBox1_ListofOrder.Items.Clear()
        Dim items = itemList.Split(Environment.NewLine)
        For Each item As String In items
            If Not String.IsNullOrWhiteSpace(item) Then
                ListBox1_ListofOrder.Items.Add(item)
            End If
        Next

        ' Update subtotal label
        Subtotal.Text = Format(subtotalValue, "C2") ' Update subtotal

        ' Retrieve the logged-in user's address and apply the delivery charge
        ApplyDeliveryCharge(SharedData.UserAddress)

        ' Update discount and total after updating subtotal
        UpdateTotal()
    End Sub

    Private Sub UpdateTotal()
        Dim subtotalValue As Decimal
        If Decimal.TryParse(Subtotal.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.CurrentCulture, subtotalValue) Then
            Dim discountAmount As Decimal = subtotalValue * (SharedData.AppliedDiscountPercent / 100)
            Dim totalValue As Decimal = subtotalValue - discountAmount + deliveryCharge ' Add the delivery charge to the total
            If totalValue < 0 Then totalValue = 0

            discount.Text = Format(discountAmount, "C2")
            Total.Text = Format(totalValue, "C2")
        Else
            MessageBox.Show("Error parsing subtotal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ApplyDeliveryCharge(address As String)
        If address.ToLower().Contains("tanauan") Then
            deliveryCharge = 25
            standardDelivery.Text = "₱ 25"
        Else
            deliveryCharge = 35
            standardDelivery.Text = "₱ 35"
        End If
    End Sub

    ' Update stored discount percentage in SharedData
    Public Sub ApplyDiscount(value As Decimal)
        SharedData.AppliedDiscountPercent = value
        UpdateTotal()
    End Sub

    Private Function FormatItemList() As List(Of String)
        Dim formattedList As New List(Of String)

        ' Loop through all the items in SharedData.AppliedItems
        For Each kvp As KeyValuePair(Of String, Integer) In SharedData.AppliedItems
            ' If an item is ordered more than once add it (i.e x(n) )
            If kvp.Value > 1 Then
                formattedList.Add($"{kvp.Key} x{kvp.Value}")
            Else
                formattedList.Add(kvp.Key)
            End If
        Next

        Return formattedList
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the subtotal is correctly fetched from SharedData
        Subtotal.Text = Format(SharedData.AppliedSubtotal, "C2")  ' This should already work if AppliedSubtotal is set properly in SharedData

        ' If there's a discount, apply it
        If SharedData.AppliedDiscountPercent > 0D Then
            ApplyDiscount(SharedData.AppliedDiscountPercent)
        End If

        ' Update the ListBox with formatted items
        ListBox1_ListofOrder.Items.Clear()
        ListBox1_ListofOrder.Items.AddRange(FormatItemList().ToArray())

        ' Ensure the total is updated after setting the subtotal
        UpdateTotal()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form4 As New Form4()
        form4.SharedConnection = Form1.conn
        form4.Show()
        Me.Hide()
    End Sub

    Private Sub bttn_account_Click(sender As Object, e As EventArgs) Handles bttn_account.Click
        Form5.Show()
        Me.Hide()

    End Sub
End Class