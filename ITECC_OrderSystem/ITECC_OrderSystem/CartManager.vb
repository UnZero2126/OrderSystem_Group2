Public Module CartManager
    Public CartItems As New Dictionary(Of String, Integer)
    Public Subtotal As Decimal = 0D

    ' Add item to cart
    Public Sub AddToCart(item As String, quantity As Integer, price As Decimal)
        If CartItems.ContainsKey(item) Then
            CartItems(item) += quantity
        Else
            CartItems(item) = quantity
        End If
        Subtotal += price * quantity
    End Sub

    ' Remove item from cart
    Public Sub RemoveFromCart(item As String, quantity As Integer, price As Decimal)
        If CartItems.ContainsKey(item) Then
            Dim remainingQty = CartItems(item) - quantity
            If remainingQty <= 0 Then
                CartItems.Remove(item)
            Else
                CartItems(item) = remainingQty
            End If
            Subtotal -= price * quantity
        End If
    End Sub

    ' Format cart items for display
    Public Function GetFormattedCart() As String
        Dim formattedList As New List(Of String)
        For Each kvp In CartItems
            If kvp.Value > 1 Then
                formattedList.Add($"{kvp.Key} x{kvp.Value}")
            Else
                formattedList.Add(kvp.Key)
            End If
        Next
        Return String.Join(Environment.NewLine, formattedList)
    End Function
End Module
