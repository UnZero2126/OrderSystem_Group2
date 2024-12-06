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

    Private Sub deleteOrder_Click(sender As Object, e As EventArgs) Handles deleteOrder.Click
        ' Check if an item is selected in the ListBox
        If ListBox1_ListofOrder.SelectedItem IsNot Nothing Then
            ' Get the selected item (e.g., "item A x2" or "item A")
            Dim selectedItem As String = ListBox1_ListofOrder.SelectedItem.ToString()

            ' Extract the base item name (e.g., "item A") by splitting the selected item
            Dim itemName As String = selectedItem
            If selectedItem.Contains(" x") Then
                ' Split by " x" to separate the item name and quantity
                Dim splitItem = selectedItem.Split(New String() {" x"}, StringSplitOptions.None)
                itemName = splitItem(0) ' Get the name before the " x"
            End If

            ' Check if the item exists in the AppliedItems dictionary
            If SharedData.AppliedItems.ContainsKey(itemName) Then
                ' Get the current quantity of the item
                Dim currentQuantity As Integer = SharedData.AppliedItems(itemName)

                ' Get the price of the item to subtract it from the subtotal
                Dim itemPrice As Decimal = GetItemPrice(itemName)

                ' Subtract the item's contribution from the subtotal
                Dim priceToSubtract As Decimal = 0D
                If currentQuantity > 1 Then
                    ' Decrease the quantity in AppliedItems and subtract the price of one occurrence
                    SharedData.AppliedItems(itemName) -= 1
                    priceToSubtract = itemPrice
                Else
                    ' Remove the item entirely and subtract its total price
                    SharedData.AppliedItems.Remove(itemName)
                    priceToSubtract = itemPrice
                End If

                ' Update the LastProcessedItems dictionary to reflect the deletion
                If LastProcessedItems.ContainsKey(itemName) Then
                    LastProcessedItems(itemName) -= 1
                    If LastProcessedItems(itemName) <= 0 Then
                        LastProcessedItems.Remove(itemName)
                    End If
                End If

                ' Subtract the calculated price from the subtotal
                SharedData.AppliedSubtotal -= priceToSubtract

                ' Ensure subtotal does not go below zero
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

            ' Check the connection state before opening
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' MySQL query to get price from different tables
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

            ' Execute the query and get the result
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                price = Convert.ToDecimal(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching item price: " & ex.Message)
        Finally
            conn?.Close()  ' Close the connection after execution
        End Try
        Return price
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class