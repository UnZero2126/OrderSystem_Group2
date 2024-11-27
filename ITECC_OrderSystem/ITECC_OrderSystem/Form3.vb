Public Class Form3
    Public Sub UpdateLabel(itemList As String, Optional subtotalValue As Decimal = 0D)
        Label_ListofOrder.Text = itemList
        Subtotal.Text = Format(subtotalValue, "C2")
    End Sub


    Private Sub Label_ListofOrder_Click(sender As Object, e As EventArgs) Handles Label_ListofOrder.Click

    End Sub

    Private Sub bttn_frm3BtOrder_Click(sender As Object, e As EventArgs) Handles bttn_frm3BtOrder.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class