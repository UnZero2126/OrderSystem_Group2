﻿Imports MySql.Data.MySqlClient

Public Class Form3
    Private discountPercent As Decimal = 0D ' Storage for applied discount

    Private Sub bttn_frm3BtOrder_Click(sender As Object, e As EventArgs) Handles bttn_frm3BtOrder.Click
        Form1.Show()
        Me.Close()
    End Sub

    Public Sub UpdateLabel(itemList As String, Optional subtotalValue As Decimal = 0D)
        ' Clear existing items in the ListBox before updating
        ListBox1_ListofOrder.Items.Clear()

        ' Split the item list by line and add them to the ListBox
        Dim items As String() = itemList.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        For Each item As String In items
            ListBox1_ListofOrder.Items.Add(item)
        Next

        ' Update the subtotal label
        Subtotal.Text = Format(subtotalValue, "C2") ' Update the subtotal

        ' Update the discount and total after updating subtotal
        UpdateTotal()
    End Sub

    Private Sub UpdateTotal()
        Dim subtotalValue As Decimal
        If Decimal.TryParse(Subtotal.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.CurrentCulture, subtotalValue) Then
            Dim discountAmount As Decimal = subtotalValue * (SharedData.AppliedDiscountPercent / 100)
            Dim totalValue As Decimal = subtotalValue - discountAmount
            If totalValue < 0 Then totalValue = 0

            discount.Text = Format(discountAmount, "C2")
            Total.Text = Format(totalValue, "C2")
        Else
            MessageBox.Show("Error parsing subtotal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub ApplyDiscount(value As Decimal)
        ' Update the stored discount percentage in SharedData
        SharedData.AppliedDiscountPercent = value
        UpdateTotal()
    End Sub

    Private Function FormatItemList() As String
        Dim formattedList As New List(Of String)

        ' Loop through all the items in SharedData.AppliedItems
        For Each kvp As KeyValuePair(Of String, Integer) In SharedData.AppliedItems
            ' If an item is ordered more than once, append the quantity
            If kvp.Value > 1 Then
                formattedList.Add($"{kvp.Key} x{kvp.Value}")
            Else
                formattedList.Add(kvp.Key)
            End If
        Next

        ' Join the items with a newline to display them in the Label
        Return String.Join(Environment.NewLine, formattedList)
    End Function

    ' Apply the saved discount value when the form loads
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the saved discount from SharedData and apply it
        If SharedData.AppliedDiscountPercent > 0D Then
            ApplyDiscount(SharedData.AppliedDiscountPercent)
        End If

        ' Use the shared data for the item list and subtotal
        UpdateLabel(FormatItemList(), SharedData.AppliedSubtotal)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form4 As New Form4()
        form4.SharedConnection = Form1.conn ' Pass the connection from Form1
        form4.Show()
        Me.Hide()
    End Sub

End Class