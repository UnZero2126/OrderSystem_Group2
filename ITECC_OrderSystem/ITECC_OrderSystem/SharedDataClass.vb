Public Class SharedDataClass
    Public Shared LoggedIn As Boolean = False
    Public Shared AppliedItems As New Dictionary(Of String, Integer)()
    Public Shared AppliedSubtotal As Decimal = 0D

    Public Shared Sub AddItem(item As String, quantity As Integer)
        If AppliedItems.ContainsKey(item) Then
            AppliedItems(item) += quantity
        Else
            AppliedItems(item) = quantity
        End If
        UpdateSubtotal()
    End Sub

    Public Shared Sub UpdateSubtotal()
        Dim subtotal As Decimal = 0D
        For Each kvp In AppliedItems
            subtotal += GetItemPrice(kvp.Key) * kvp.Value
        Next
        AppliedSubtotal = subtotal
    End Sub

    Private Shared Function GetItemPrice(item As String) As Decimal
        ' Add logic to fetch item prices from database
        Return 10 ' Example price
    End Function
End Class
