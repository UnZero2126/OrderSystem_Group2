Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing

Public Class Form1
    'UI 
    Private Const CollapsedWidth As Integer = 35
    Private Const ExpandedWidth As Integer = 178
    Private AnimationStep As Integer = 15
    Private clickedItems As New Dictionary(Of String, Integer)()

    'Database
    Public conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim cmddr As MySqlCommand
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

            ' Assign tags to predefined buttons 
            bttn_AOtofu.Tag = "Tofu"
            bttn_AOkimchi.Tag = "Kimchi"
            bttn_AOnori.Tag = "Nori"
            bttn_AOcorn.Tag = "Corn"
            bttn_AOsoftBoiledegg.Tag = "Soft Boiled Egg"
            bttn_DRcocaCola.Tag = "Coca Cola"
            bttn_DRicedTea.Tag = "Iced Tea"
            bttn_DRmirinda.Tag = "Mirinda"
            bttn_DRpepsi.Tag = "Pepsi"
            bttn_DRsake.Tag = "Sake"
            bttn_DRsprite.Tag = "Sprite"
            bttn_DRwater.Tag = "Water"
            bttn_Dbingsu.Tag = "Bingsu"
            bttn_DiceCream.Tag = "Ice Cream"
            bttn_Dmochi.Tag = "Mochi"
            bttn_MCbeefRamen.Tag = "Beef Ramen"
            bttn_MCchashuRamen.Tag = "Chashu Ramen"
            bttn_MCcoldRamen.Tag = "Cold Ramen"
            bttn_MCcurryRamen.Tag = "Curry Ramen"
            bttn_MCmisoRamen.Tag = "Miso Ramen"
            bttn_MCshioRamen.Tag = "Shio Ramen"
            bttn_MCshoyuRamen.Tag = "Shoyu Ramen"
            bttn_MCtonkotsuRamen.Tag = "Tonkotsu Ramen"
            bttn_Aedamame.Tag = "Edamame"
            bttn_Agyoza.Tag = "Gyoza"
            bttn_Asalad.Tag = "Salad"
            bttn_Asiomai.Tag = "Siomai"
            bttn_Atakoyaki.Tag = "Takoyaki"
            bttn_Atempura.Tag = "Tempura"

            LoadMenuItems()
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message)
        Finally
            conn?.Close()
        End Try
    End Sub

    Private Sub LoadMenuItems()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT Name FROM addons WHERE Name NOT IN ('Tofu', 'Kimchi', 'Nori', 'Corn', 'Soft Boiled Egg')
                               UNION
                               SELECT Name FROM drinks WHERE Name NOT IN ('Coca Cola', 'Iced Tea', 'Mirinda', 'Pepsi', 'Sake', 'Sprite', 'Water')
                               UNION
                               SELECT Name FROM desserts WHERE Name NOT IN ('Bingsu', 'Ice Cream', 'Mochi')
                               UNION
                               SELECT Name FROM maincourse WHERE Name NOT IN ('Beef Ramen', 'Chashu Ramen', 'Cold Ramen', 'Curry Ramen', 'Miso Ramen',
                                'Shio Ramen', 'Shoyu Ramen', 'Tonkotsu Ramen')
                               UNION
                               SELECT Name FROM appetizer WHERE Name NOT IN ('Gyoza', 'Takoyaki', 'Edamame', 'Tempura', 'Siomai', 'Salad')"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim itemName As String = reader("Name").ToString()
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading menu items: " & ex.Message)
        Finally
            reader?.Close()
            conn?.Close()
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
        Dim form4 As New Form4()
        form4.SharedConnection = conn ' Pass the connection
        form4.Show()
        Me.Hide()
    End Sub

    Private Sub bttn_MakeRamen_Click(sender As Object, e As EventArgs) Handles bttn_MakeRamen.Click
        Form2.Show()
        Me.Hide()
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

    Private Sub AddonButton_Click(sender As Object, e As EventArgs) Handles bttn_AOtofu.Click, bttn_AOkimchi.Click,
        bttn_AOnori.Click, bttn_AOcorn.Click, bttn_AOsoftBoiledegg.Click,
        bttn_DRcocaCola.Click, bttn_DRicedTea.Click, bttn_DRmirinda.Click,
        bttn_DRpepsi.Click, bttn_DRsake.Click, bttn_DRsprite.Click, bttn_DRwater.Click,
        bttn_Dbingsu.Click, bttn_DiceCream.Click, bttn_Dmochi.Click, bttn_MCbeefRamen.Click,
        bttn_MCchashuRamen.Click, bttn_MCcoldRamen.Click, bttn_MCcurryRamen.Click,
        bttn_MCmisoRamen.Click, bttn_MCshioRamen.Click, bttn_MCshoyuRamen.Click,
        bttn_MCtonkotsuRamen.Click, bttn_Agyoza.Click, bttn_Atakoyaki.Click, bttn_Aedamame.Click,
        bttn_Atempura.Click, bttn_Asiomai.Click, bttn_Asalad.Click

        Dim button As Button = DirectCast(sender, Button)
        Dim item As String = button.Tag.ToString()
        AddItem(item)
    End Sub
    Private Sub AddItem(item As String)
        ' Add item to the global SharedData
        If SharedData.AppliedItems.ContainsKey(item) Then
            SharedData.AppliedItems(item) += 1
        Else
            SharedData.AppliedItems.Add(item, 1)
        End If

        ' Recalculate subtotal
        SharedData.AppliedSubtotal = CalculateSubtotal()

        ' Update Form3 with the latest values
        If Form3 IsNot Nothing AndAlso Form3.Visible Then
            Form3.UpdateLabel(FormatItemList(), SharedData.AppliedSubtotal)
        End If
    End Sub

    Private Function GetItemPrice(item As String) As Decimal
        Dim price As Decimal = 0D
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
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
                                ) AS PriceResult LIMIT 1", conn)
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
        For Each kvp As KeyValuePair(Of String, Integer) In SharedData.AppliedItems
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