Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing

Public Class Form1
    'UI 
    Private Const CollapsedWidth As Integer = 35
    Private Const ExpandedWidth As Integer = 178
    Private AnimationStep As Integer = 15
    Private clickedItems As New Dictionary(Of String, Integer)()

    'Database
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub CollapseAILogo_Click(sender As Object, e As EventArgs) Handles CollapseAILogo.Click
        TimerPanel_Collapse.Enabled = False
        TimerPanel_Extend.Enabled = False

        If AboutInfo.Width > CollapsedWidth Then
            TimerPanel_Collapse.Enabled = True
        Else
            TimerPanel_Extend.Enabled = True
        End If
    End Sub

    Private Sub TimerPanel_Collapse_Tick(sender As Object, e As EventArgs) Handles TimerPanel_Collapse.Tick
        If AboutInfo.Width > CollapsedWidth Then
            AboutInfo.Width -= AnimationStep
            If AboutInfo.Width < CollapsedWidth Then AboutInfo.Width = CollapsedWidth
        Else
            TimerPanel_Collapse.Enabled = False
        End If
    End Sub

    Private Sub TimerPanel_Extend_Tick(sender As Object, e As EventArgs) Handles TimerPanel_Extend.Tick
        If AboutInfo.Width < ExpandedWidth Then
            AboutInfo.Width += AnimationStep
            If AboutInfo.Width > ExpandedWidth Then AboutInfo.Width = ExpandedWidth
        Else
            TimerPanel_Extend.Enabled = False
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=127.0.0.1;userid=root;password=;database=ordering_system2;SslMode=None")
        Try
            conn.Open()

            ' Assign tags to predefined buttons (no additional buttons for these items)
            bttn_AOtofu.Tag = "Tofu"
            bttn_AOkimchi.Tag = "Kimchi"
            bttn_AOnori.Tag = "Nori"
            bttn_AOcorn.Tag = "Corn"
            bttn_AOsoftBoiledegg.Tag = "Soft Boiled Egg"

            LoadMenuItems() ' Load other dynamic addon items
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message)
        Finally
            conn?.Close()
        End Try
    End Sub

    Private Sub LoadMenuItems()
        Try
            cmd = New MySqlCommand("SELECT AOID, Name FROM addons", conn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim itemName As String = reader("Name").ToString()

                ' Skip predefined items
                If itemName = "Tofu" OrElse itemName = "Kimchi" OrElse itemName = "Nori" OrElse
                itemName = "Corn" OrElse itemName = "Soft Boiled Egg" Then
                    Continue While
                End If

                ' Create dynamic buttons for items not predefined
                Dim itemButton As New Button()
                itemButton.Text = itemName
                itemButton.Tag = itemName

                ' Add click event to handle item selection
                AddHandler itemButton.Click, AddressOf ItemButton_Click

                ' Add button to the panel
                Panel_AO.Controls.Add(itemButton)
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading addons: " & ex.Message)
        Finally
            reader?.Close()
            conn?.Close()  ' Close the connection eme
        End Try
    End Sub

    Private Sub ItemButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim item As String = button.Tag.ToString()
        AddItem(item)
    End Sub
    Private Sub bttn_appetizer_Click(sender As Object, e As EventArgs) Handles bttn_appetizer.Click
        Panel_appetizer.Height = bttn_appetizer.Height
        Panel_appetizer.Top = bttn_appetizer.Top
        Panel_A.Visible = True
        Panel_MC.Visible = False
        Panel_D.Visible = False
        Panel_DR.Visible = False
        Panel_AO.Visible = False
    End Sub

    Private Sub Panel_AO_Paint(sender As Object, e As PaintEventArgs) Handles Panel_AO.Paint
        Panel_addons.Height = bttn_addons.Height
        Panel_addons.Top = bttn_addons.Top
        Panel_A.Visible = False
        Panel_MC.Visible = False
        Panel_D.Visible = False
        Panel_DR.Visible = False
        Panel_AO.Visible = True
    End Sub

    Private Sub bttn_maincourse_Click(sender As Object, e As EventArgs) Handles bttn_maincourse.Click
        Panel_maincourse.Height = bttn_maincourse.Height
        Panel_maincourse.Top = bttn_maincourse.Top
        Panel_A.Visible = False
        Panel_MC.Visible = True
        Panel_D.Visible = False
        Panel_DR.Visible = False
        Panel_AO.Visible = False
    End Sub

    Private Sub bttn_dessert_Click(sender As Object, e As EventArgs) Handles bttn_dessert.Click
        Panel_dessert.Height = bttn_dessert.Height
        Panel_dessert.Top = bttn_dessert.Top
        Panel_A.Visible = False
        Panel_MC.Visible = False
        Panel_D.Visible = True
        Panel_DR.Visible = False
        Panel_AO.Visible = False
    End Sub

    Private Sub bttn_drinks_Click(sender As Object, e As EventArgs) Handles bttn_drinks.Click
        Panel_drinks.Height = bttn_drinks.Height
        Panel_drinks.Top = bttn_drinks.Top
        Panel_A.Visible = False
        Panel_MC.Visible = False
        Panel_D.Visible = False
        Panel_DR.Visible = True
        Panel_AO.Visible = False
    End Sub

    Private Sub bttn_promos_Click(sender As Object, e As EventArgs) Handles bttn_promos.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub bttn_MakeRamen_Click(sender As Object, e As EventArgs) Handles bttn_MakeRamen.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label_AOsoftBoiledegg_Click(sender As Object, e As EventArgs) Handles Label_AOsoftBoiledegg.Click

    End Sub

    Private Sub bttn_addons_Click(sender As Object, e As EventArgs) Handles bttn_addons.Click
        Panel_addons.Height = bttn_addons.Height
        Panel_addons.Top = bttn_addons.Top
        Panel_A.Visible = False
        Panel_MC.Visible = False
        Panel_D.Visible = False
        Panel_DR.Visible = False
        Panel_AO.Visible = True
    End Sub

    Private Sub AddonButton_Click(sender As Object, e As EventArgs) Handles bttn_AOtofu.Click, bttn_AOkimchi.Click, bttn_AOnori.Click, bttn_AOcorn.Click, bttn_AOsoftBoiledegg.Click
        Dim button As Button = DirectCast(sender, Button)
        Dim item As String = button.Tag.ToString()
        AddItem(item)
    End Sub
    Private Sub AddItem(item As String)
        If clickedItems.ContainsKey(item) Then
            clickedItems(item) += 1
        Else
            clickedItems.Add(item, 1)
        End If

        Dim itemPrice As Decimal = GetItemPrice(item)
        Dim subtotal As Decimal = CalculateSubtotal()

        If Form3 IsNot Nothing Then
            Form3.UpdateLabel(FormatItemList(), subtotal)
        End If
    End Sub

    Private Function GetItemPrice(item As String) As Decimal
        Dim price As Decimal = 0D
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            cmd = New MySqlCommand("SELECT COALESCE(price, 0) FROM addons WHERE Name = @Name", conn)
            cmd.Parameters.AddWithValue("@Name", item)
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

    Private Function CalculateSubtotal() As Decimal
        Dim subtotal As Decimal = 0D
        For Each kvp As KeyValuePair(Of String, Integer) In clickedItems
            Dim price As Decimal = GetItemPrice(kvp.Key)
            subtotal += price * kvp.Value
        Next
        Return subtotal
    End Function

    Private Function FormatItemList() As String
        Dim formattedList As New List(Of String)
        For Each kvp As KeyValuePair(Of String, Integer) In clickedItems
            If kvp.Value > 1 Then
                formattedList.Add($"{kvp.Key} x{kvp.Value}")
            Else
                formattedList.Add(kvp.Key)
            End If
        Next

        Return String.Join(Environment.NewLine, formattedList)
    End Function
    Private Sub bttn_cart_Click(sender As Object, e As EventArgs) Handles bttn_cart.Click
        Form3.UpdateLabel(FormatItemList(), CalculateSubtotal())
        Form3.Show()
        Me.Hide()
    End Sub

End Class
