Imports MySql.Data.MySqlClient

Public Class Form3
    Private discountPercent As Decimal = 0D ' Storage for applied discount baka di na need to di ko pa suree HAHAAAHHHAHA
    Private deliveryCharge As Decimal = 0D
    Private Sub bttn_frm3BtOrder_Click(sender As Object, e As EventArgs) Handles bttn_frm3BtOrder.Click
        Form1.Show()
        Me.Close()
    End Sub

    Public Sub UpdateLabel(itemList As String, Optional subtotalValue As Decimal = 0D)
        ListBox1_ListofOrder.Items.Clear()
        Dim items = itemList.Split(Environment.NewLine)
        For Each item As String In items
            If Not String.IsNullOrWhiteSpace(item) Then
                ListBox1_ListofOrder.Items.Add(item)
            End If
        Next

        Subtotal.Text = Format(subtotalValue, "C2")

        ApplyDeliveryCharge(SharedData.UserAddress)

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

    Public Sub ApplyDeliveryCharge(address As String)
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

        ' Loop through all items in SharedData.AppliedItems
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
        Subtotal.Text = Format(SharedData.AppliedSubtotal, "C2")

        If SharedData.AppliedDiscountPercent > 0D Then
            ApplyDiscount(SharedData.AppliedDiscountPercent)
        End If

        ListBox1_ListofOrder.Items.Clear()
        ListBox1_ListofOrder.Items.AddRange(FormatItemList().ToArray())

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

    Private Sub deleteOrder_Click(sender As Object, e As EventArgs) Handles deleteOrder.Click
        If ListBox1_ListofOrder.SelectedItem IsNot Nothing Then
            ' Get the selected item (e.g., "item A x2" or "item A")
            Dim selectedItem As String = ListBox1_ListofOrder.SelectedItem.ToString()

            ' Extract the base item name (e.g., "item A") by splitting the selected item
            Dim itemName As String = selectedItem
            If selectedItem.Contains(" x") Then
                Dim splitItem = selectedItem.Split(New String() {" x"}, StringSplitOptions.None)
                itemName = splitItem(0) ' Get the name before the " x"
            End If

            ' Check if the item exists in the AppliedItems dictionary
            If SharedData.AppliedItems.ContainsKey(itemName) Then
                Dim currentQuantity As Integer = SharedData.AppliedItems(itemName)

                Dim itemPrice As Decimal = GetItemPrice(itemName)

                Dim priceToSubtract As Decimal = 0D
                If currentQuantity > 1 Then
                    SharedData.AppliedItems(itemName) -= 1
                    priceToSubtract = itemPrice
                Else
                    SharedData.AppliedItems.Remove(itemName)
                    priceToSubtract = itemPrice
                End If

                If LastProcessedItems.ContainsKey(itemName) Then
                    LastProcessedItems(itemName) -= 1
                    If LastProcessedItems(itemName) <= 0 Then
                        LastProcessedItems.Remove(itemName)
                    End If
                End If

                SharedData.AppliedSubtotal -= priceToSubtract

                ' subtotal does not go below zero
                If SharedData.AppliedSubtotal < 0 Then SharedData.AppliedSubtotal = 0

                ' Update the ListBox and recalculate totals
                UpdateLabel(String.Join(Environment.NewLine, FormatItemList()), SharedData.AppliedSubtotal)
            Else
                MessageBox.Show("The selected item is not in the order list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select an order to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Function GetItemPrice(item As String) As Decimal
        Dim price As Decimal = 0D
        Dim conn As New MySqlConnection("server=127.0.0.1;userid=root;password=;database=ordering_system2;SslMode=None")
        Dim cmd As MySqlCommand

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            cmd = New MySqlCommand("SELECT COALESCE(price, 0) FROM (
                                SELECT price FROM addons WHERE Name = @Name
                                UNION
                                SELECT price FROM drinks WHERE Name = @Name
                                UNION
                                SELECT price FROM desserts WHERE Name = @Name
                                UNION
                                SELECT price FROM maincourse WHERE Name = @Name
                                UNION
                                SELECT price FROM appetizer WHERE Name = @Name
                                UNION
                                SELECT price FROM makeyourownramen WHERE name = @Name
                            ) AS PriceResult LIMIT 1", conn)
            cmd.Parameters.AddWithValue("@Name", item)

            ' get price here
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                price = Convert.ToDecimal(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching item price: " & ex.Message)
        Finally
            conn?.Close()
        End Try
        Return price
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub CheckOut_Click(sender As Object, e As EventArgs) Handles CheckOut.Click
        Dim receipt As New System.Text.StringBuilder()

        receipt.AppendLine("--------- RECEIPT ---------")
        receipt.AppendLine($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}")
        receipt.AppendLine("Customer: " & SharedData.username)
        receipt.AppendLine()
        receipt.AppendLine("Items Ordered:")
        receipt.AppendLine("--------------------------")

        ' Add items from the ListBox
        If ListBox1_ListofOrder.Items.Count > 0 Then
            For Each item As String In ListBox1_ListofOrder.Items
                receipt.AppendLine(item)
            Next
        Else
            MessageBox.Show("No items to checkout.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Add subtotal, delivery charge, discount, and total
        receipt.AppendLine("--------------------------")
        receipt.AppendLine($"Subtotal: {Subtotal.Text}")
        receipt.AppendLine($"Delivery Charge: {standardDelivery.Text}")
        receipt.AppendLine($"Discount: {discount.Text}")
        receipt.AppendLine($"Total: {Total.Text}")
        receipt.AppendLine("--------------------------")
        receipt.AppendLine("Thank you for your order!")

        ' Display receipt in a message box
        MessageBox.Show(receipt.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' clear the order after checkout
        SharedData.AppliedItems.Clear()
        SharedData.AppliedSubtotal = 0D
        SharedData.AppliedDiscountPercent = 0D
        SharedData.DiscountPercent = 0D
        SharedData.VoucherApplied = False
        ListBox1_ListofOrder.Items.Clear()
        Subtotal.Text = "₱ 0.00"
        discount.Text = "₱ 0.00"
        Total.Text = "₱ 0.00"
    End Sub

End Class