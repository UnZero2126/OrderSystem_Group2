Imports MySql.Data.MySqlClient

Public Class Form2
    Dim conn As MySqlConnection
    Dim orderSize As String
    Dim cmd As MySqlCommand
    Private clickedItems As New Dictionary(Of String, Integer)()
    Private Sub bttn_frm2BtOrder_Click(sender As Object, e As EventArgs) Handles bttn_frm2BtOrder.Click
        Form1.Show()
        Me.Close()
    End Sub
    ' Boolean flags to track required selections
    Private sizeSelected As Boolean = False
    Private brothSelected As Boolean = False
    Private noodlesSelected As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially disable the checkout button
        bttn_addtoCart.Enabled = False
    End Sub

    Private Sub UpdateCheckoutButtonState()
        ' Enable the button only if all required selections are made
        bttn_addtoCart.Enabled = sizeSelected AndAlso brothSelected AndAlso noodlesSelected
    End Sub

    ' Event handlers for size selection
    Private Sub RB_small_CheckedChanged(sender As Object, e As EventArgs) Handles RB_small.CheckedChanged
        If RB_small.Checked Then
            sizeSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_medium_CheckedChanged(sender As Object, e As EventArgs) Handles RB_medium.CheckedChanged
        If RB_medium.Checked Then
            sizeSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_large_CheckedChanged(sender As Object, e As EventArgs) Handles RB_large.CheckedChanged
        If RB_large.Checked Then
            sizeSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_ExtraLarge_CheckedChanged(sender As Object, e As EventArgs) Handles RB_ExtraLarge.CheckedChanged
        If RB_ExtraLarge.Checked Then
            sizeSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    ' Event handlers for broth selection
    Private Sub RB_ShoyuBroth_CheckedChanged(sender As Object, e As EventArgs) Handles RB_ShoyuBroth.CheckedChanged
        If RB_ShoyuBroth.Checked Then
            brothSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_MisoBroth_CheckedChanged(sender As Object, e As EventArgs) Handles RB_MisoBroth.CheckedChanged
        If RB_MisoBroth.Checked Then
            brothSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_ShioBroth_CheckedChanged(sender As Object, e As EventArgs) Handles RB_ShioBroth.CheckedChanged
        If RB_ShioBroth.Checked Then
            brothSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_CurryBroth_CheckedChanged(sender As Object, e As EventArgs) Handles RB_CurryBroth.CheckedChanged
        If RB_CurryBroth.Checked Then
            brothSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_TonkotsuBroth_CheckedChanged(sender As Object, e As EventArgs) Handles RB_TonkotsuBroth.CheckedChanged
        If RB_TonkotsuBroth.Checked Then
            brothSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_VegetableBroth_CheckedChanged(sender As Object, e As EventArgs) Handles RB_VegetableBroth.CheckedChanged
        If RB_VegetableBroth.Checked Then
            brothSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    ' Event handlers for noodle selection
    Private Sub RB_CRNoodles_CheckedChanged(sender As Object, e As EventArgs) Handles RB_CRNoodles.CheckedChanged
        If RB_CRNoodles.Checked Then
            noodlesSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_StraightNoodles_CheckedChanged(sender As Object, e As EventArgs) Handles RB_StraightNoodles.CheckedChanged
        If RB_StraightNoodles.Checked Then
            noodlesSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_UdonNoodles_CheckedChanged(sender As Object, e As EventArgs) Handles RB_UdonNoodles.CheckedChanged
        If RB_UdonNoodles.Checked Then
            noodlesSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub

    Private Sub RB_WavyNoodles_CheckedChanged(sender As Object, e As EventArgs) Handles RB_WavyNoodles.CheckedChanged
        If RB_WavyNoodles.Checked Then
            noodlesSelected = True
            UpdateCheckoutButtonState()
        End If
    End Sub
    Private Sub bttn_Size_Click(sender As Object, e As EventArgs) Handles bttn_Size.Click
        Panel_size.Height = bttn_Size.Height
        Panel_size.Top = bttn_Size.Top
        Panel_SizeMiddle.Visible = True
        Panel_BrothMiddle.Visible = False
        Panel_NoodlesMiddle.Visible = False
        Panel_ProteinsMiddle.Visible = False
        Panel_ToppingsMiddle.Visible = False
        Panel_ExtraFlavorMiddle.Visible = False
    End Sub

    Private Sub bttn_broth_Click(sender As Object, e As EventArgs) Handles bttn_broth.Click
        Panel_broth.Height = bttn_broth.Height
        Panel_broth.Top = bttn_broth.Top
        Panel_SizeMiddle.Visible = False
        Panel_BrothMiddle.Visible = True
        Panel_NoodlesMiddle.Visible = False
        Panel_ProteinsMiddle.Visible = False
        Panel_ToppingsMiddle.Visible = False
        Panel_ExtraFlavorMiddle.Visible = False
    End Sub

    Private Sub bttn_noodles_Click(sender As Object, e As EventArgs) Handles bttn_noodles.Click
        Panel_noodles.Height = bttn_noodles.Height
        Panel_noodles.Top = bttn_noodles.Top
        Panel_SizeMiddle.Visible = False
        Panel_BrothMiddle.Visible = False
        Panel_NoodlesMiddle.Visible = True
        Panel_ProteinsMiddle.Visible = False
        Panel_ToppingsMiddle.Visible = False
        Panel_ExtraFlavorMiddle.Visible = False
    End Sub

    Private Sub bttn_proteins_Click(sender As Object, e As EventArgs) Handles bttn_proteins.Click
        Panel_proteins.Height = bttn_proteins.Height
        Panel_proteins.Top = bttn_proteins.Top
        Panel_SizeMiddle.Visible = False
        Panel_BrothMiddle.Visible = False
        Panel_NoodlesMiddle.Visible = False
        Panel_ProteinsMiddle.Visible = True
        Panel_ToppingsMiddle.Visible = False
        Panel_ExtraFlavorMiddle.Visible = False
    End Sub

    Private Sub bttn_toppings_Click(sender As Object, e As EventArgs) Handles bttn_toppings.Click
        Panel_toppings.Height = bttn_toppings.Height
        Panel_toppings.Top = bttn_toppings.Top
        Panel_SizeMiddle.Visible = False
        Panel_BrothMiddle.Visible = False
        Panel_NoodlesMiddle.Visible = False
        Panel_ProteinsMiddle.Visible = False
        Panel_ToppingsMiddle.Visible = True
        Panel_ExtraFlavorMiddle.Visible = False
    End Sub

    Private Sub bttn_extraFlavor_Click(sender As Object, e As EventArgs) Handles bttn_extraFlavor.Click
        Panel_ExtraFlavor.Height = bttn_extraFlavor.Height
        Panel_ExtraFlavor.Top = bttn_extraFlavor.Top
        Panel_SizeMiddle.Visible = False
        Panel_BrothMiddle.Visible = False
        Panel_NoodlesMiddle.Visible = False
        Panel_ProteinsMiddle.Visible = False
        Panel_ToppingsMiddle.Visible = False
        Panel_ExtraFlavorMiddle.Visible = True
    End Sub

    Private Sub bttn_addtoRamen_Click(sender As Object, e As EventArgs) Handles bttn_addtoRamen.Click


        If RB_small.Checked Then
            Label5.Text = "Small"
        ElseIf RB_medium.Checked Then
            Label5.Text = "Medium"
        ElseIf RB_large.Checked Then
            Label5.Text = "Large"
        ElseIf RB_ExtraLarge.Checked Then
            Label5.Text = "Extra Large"
        End If

        If RB_ShoyuBroth.Checked Then
            Label7.Text = "Shoyu"
        ElseIf RB_MisoBroth.Checked Then
            Label7.Text = "Miso"
        ElseIf RB_ShioBroth.Checked Then
            Label7.Text = "Shio"
        ElseIf RB_CurryBroth.Checked Then
            Label7.Text = "Curry"
        ElseIf RB_TonkotsuBroth.Checked Then
            Label7.Text = "Tonkotsu"
        ElseIf RB_VegetableBroth.Checked Then
            Label7.Text = "Vegetable"
        End If

        If RB_CRNoodles.Checked Then
            Label9.Text = "Cold R"
        ElseIf RB_StraightNoodles.Checked Then
            Label9.Text = "Straight"
        ElseIf RB_UdonNoodles.Checked Then
            Label9.Text = "Udon"
        ElseIf RB_WavyNoodles.Checked Then
            Label9.Text = "Wavy"
        End If

        ' Protein selection
        Dim selectedProteinCount As Integer = 0
        Dim selectedProteinName As String = ""

        If CB_Beef.Checked Then
            selectedProteinCount += 1
            selectedProteinName = "Beef"
        End If
        If CB_GrilledChicken.Checked Then
            selectedProteinCount += 1
            selectedProteinName = "Grilled Chicken"
        End If
        If CB_GroundPork.Checked Then
            selectedProteinCount += 1
            selectedProteinName = "Ground Pork"
        End If
        If CB_Tofu.Checked Then
            selectedProteinCount += 1
            selectedProteinName = "Tofu"
        End If
        If CB_Egg.Checked Then
            selectedProteinCount += 1
            selectedProteinName = "Egg"
        End If
        If CB_Shrimp.Checked Then
            selectedProteinCount += 1
            selectedProteinName = "Shrimp"
        End If

        If selectedProteinCount = 1 Then
            Label3.Text = selectedProteinName
        Else
            Label3.Text = selectedProteinCount.ToString() & " Items"
        End If

        ' Toppings selection
        Dim selectedToppingsCount As Integer = 0
        Dim selectedToppingsName As String = ""

        If CB_Corn.Checked Then
            selectedToppingsCount += 1
            selectedToppingsName = "Corn"
        End If
        If CB_Nori.Checked Then
            selectedToppingsCount += 1
            selectedToppingsName = "Nori"
        End If
        If CB_Seaweed.Checked Then
            selectedToppingsCount += 1
            selectedToppingsName = "Seaweed"
        End If
        If CB_Mushrooms.Checked Then
            selectedToppingsCount += 1
            selectedToppingsName = "Mushrooms"
        End If
        If CB_Spinach.Checked Then
            selectedToppingsCount += 1
            selectedToppingsName = "Spinach"
        End If
        If CB_GreenOnions.Checked Then
            selectedToppingsCount += 1
            selectedToppingsName = "Green Onions"
        End If

        If selectedToppingsCount = 1 Then
            Label2.Text = selectedToppingsName
        Else
            Label2.Text = selectedToppingsCount.ToString() & " Items"
        End If

        ' Extra Flavors selection
        Dim selectedEFCount As Integer = 0
        Dim selectedEFName As String = ""

        If CB_ChiliOil.Checked Then
            selectedEFCount += 1
            selectedEFName = "Chili Oil"
        End If
        If CB_Garlic.Checked Then
            selectedEFCount += 1
            selectedEFName = "Garlic"
        End If
        If CB_SoySauce.Checked Then
            selectedEFCount += 1
            selectedEFName = "Soy Sauce"
        End If
        If CB_Vinegar.Checked Then
            selectedEFCount += 1
            selectedEFName = "Vinegar"
        End If
        If CB_BlackPepper.Checked Then
            selectedEFCount += 1
            selectedEFName = "Black Pepper"
        End If

        If selectedEFCount = 1 Then
            Label15.Text = selectedEFName
        Else
            Label15.Text = selectedEFCount.ToString() & " Items"
        End If
    End Sub

    Private Sub bttn_checkout_Click(sender As Object, e As EventArgs) Handles bttn_addtoCart.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=ordering_system2"

        If Not SharedData.LoggedIn Then
            MessageBox.Show("You must be logged in to add items to the cart.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalPrice As Decimal = 0D
        Dim selectedItems As New List(Of String)


        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            'di pa taposs to add whats beloww
            ' Add size, broth, noodles, proteins, toppings, and extra flavors
            If Label5.Text <> "" Then selectedItems.Add(Label5.Text)
            If Label7.Text <> "" Then selectedItems.Add(Label7.Text)
            If Label9.Text <> "" Then selectedItems.Add(Label9.Text)
            If CB_Beef.Checked Then selectedItems.Add("Beef")
            If CB_GrilledChicken.Checked Then selectedItems.Add("Grilled Chicken")
            If CB_GroundPork.Checked Then selectedItems.Add("Ground Pork")
            If CB_Tofu.Checked Then selectedItems.Add("Tofu")
            If CB_Egg.Checked Then selectedItems.Add("Egg")
            If CB_Shrimp.Checked Then selectedItems.Add("Shrimp")
            If CB_Corn.Checked Then selectedItems.Add("Corn")
            If CB_Nori.Checked Then selectedItems.Add("Nori")
            If CB_Seaweed.Checked Then selectedItems.Add("Seaweed")
            If CB_Mushrooms.Checked Then selectedItems.Add("Mushrooms")
            If CB_Spinach.Checked Then selectedItems.Add("Spinach")
            If CB_GreenOnions.Checked Then selectedItems.Add("Green Onions")
            If CB_ChiliOil.Checked Then selectedItems.Add("Chili Oil")
            If CB_Garlic.Checked Then selectedItems.Add("Garlic")
            If CB_SoySauce.Checked Then selectedItems.Add("Soy Sauce")
            If CB_Vinegar.Checked Then selectedItems.Add("Vinegar")
            If CB_BlackPepper.Checked Then selectedItems.Add("Black Pepper")

            ' get the prices and add
            For Each item As String In selectedItems
                cmd = New MySqlCommand("SELECT price FROM makeyourownramen WHERE Name = @Name", conn)
                cmd.Parameters.AddWithValue("@Name", item)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    totalPrice += Convert.ToDecimal(result)
                End If
            Next

            ' Update SharedData
            For Each item As String In selectedItems
                If SharedData.AppliedItems.ContainsKey(item) Then
                    SharedData.AppliedItems(item) += 1
                Else
                    SharedData.AppliedItems.Add(item, 1)
                End If
            Next
            SharedData.AppliedSubtotal += totalPrice

            ' Pass data to Form3
            Dim itemList As String = String.Join(Environment.NewLine, selectedItems)
            Dim form3 As New Form3()
            form3.UpdateLabel(itemList, SharedData.AppliedSubtotal)
            form3.Show()
            Me.close()

        Catch ex As Exception
            MessageBox.Show("Error fetching prices: " & ex.Message)
        Finally
            conn?.Close()
        End Try
    End Sub

    Private Sub bttn_cart_Click(sender As Object, e As EventArgs) Handles bttn_cart.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub bttn_account_Click(sender As Object, e As EventArgs) Handles bttn_account.Click
        Form5.Show()
        Me.Hide()

    End Sub
End Class