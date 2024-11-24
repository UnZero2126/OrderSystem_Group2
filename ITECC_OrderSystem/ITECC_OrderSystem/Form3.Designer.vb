<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel_Left = New Panel()
        Label_ListofOrder = New Label()
        Label1 = New Label()
        Panel_TopRight = New Panel()
        bttn_account = New Button()
        Panel_BottomRight = New Panel()
        bttn_frm3BtOrder = New Button()
        Panel_MiddleRight = New Panel()
        Total = New Label()
        Label_TotalTitle = New Label()
        Button2 = New Button()
        discount = New Label()
        Label_DiscountTitle = New Label()
        standardDelivery = New Label()
        Label_SDeliveryTitle = New Label()
        Subtotal = New Label()
        Label_SubtotalTitle = New Label()
        Panel_Left.SuspendLayout()
        Panel_TopRight.SuspendLayout()
        Panel_BottomRight.SuspendLayout()
        Panel_MiddleRight.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Left
        ' 
        Panel_Left.BackColor = Color.FromArgb(CByte(203), CByte(226), CByte(181))
        Panel_Left.Controls.Add(Label_ListofOrder)
        Panel_Left.Controls.Add(Label1)
        Panel_Left.Dock = DockStyle.Left
        Panel_Left.Location = New Point(0, 0)
        Panel_Left.Name = "Panel_Left"
        Panel_Left.Size = New Size(666, 539)
        Panel_Left.TabIndex = 0
        ' 
        ' Label_ListofOrder
        ' 
        Label_ListofOrder.Font = New Font("Javanese Text", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_ListofOrder.ForeColor = Color.Black
        Label_ListofOrder.Location = New Point(72, 147)
        Label_ListofOrder.Name = "Label_ListofOrder"
        Label_ListofOrder.Size = New Size(97, 31)
        Label_ListofOrder.TabIndex = 1
        Label_ListofOrder.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Javanese Text", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(153, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(345, 104)
        Label1.TabIndex = 0
        Label1.Text = "Your Cart!"
        ' 
        ' Panel_TopRight
        ' 
        Panel_TopRight.Controls.Add(bttn_account)
        Panel_TopRight.Dock = DockStyle.Top
        Panel_TopRight.Location = New Point(666, 0)
        Panel_TopRight.Name = "Panel_TopRight"
        Panel_TopRight.Size = New Size(361, 48)
        Panel_TopRight.TabIndex = 1
        ' 
        ' bttn_account
        ' 
        bttn_account.BackgroundImageLayout = ImageLayout.Zoom
        bttn_account.Dock = DockStyle.Right
        bttn_account.FlatAppearance.BorderSize = 0
        bttn_account.FlatStyle = FlatStyle.Flat
        bttn_account.ForeColor = Color.Cornsilk
        bttn_account.Image = My.Resources.Resources.icons8_account_20
        bttn_account.Location = New Point(318, 0)
        bttn_account.Name = "bttn_account"
        bttn_account.Size = New Size(43, 48)
        bttn_account.TabIndex = 2
        bttn_account.TextAlign = ContentAlignment.MiddleRight
        bttn_account.UseVisualStyleBackColor = True
        ' 
        ' Panel_BottomRight
        ' 
        Panel_BottomRight.BackColor = Color.Cornsilk
        Panel_BottomRight.Controls.Add(bttn_frm3BtOrder)
        Panel_BottomRight.Dock = DockStyle.Fill
        Panel_BottomRight.Location = New Point(666, 48)
        Panel_BottomRight.Name = "Panel_BottomRight"
        Panel_BottomRight.Size = New Size(361, 491)
        Panel_BottomRight.TabIndex = 2
        ' 
        ' bttn_frm3BtOrder
        ' 
        bttn_frm3BtOrder.FlatAppearance.BorderSize = 0
        bttn_frm3BtOrder.FlatStyle = FlatStyle.Flat
        bttn_frm3BtOrder.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        bttn_frm3BtOrder.Location = New Point(77, 436)
        bttn_frm3BtOrder.Name = "bttn_frm3BtOrder"
        bttn_frm3BtOrder.Size = New Size(223, 43)
        bttn_frm3BtOrder.TabIndex = 2
        bttn_frm3BtOrder.Text = "Back to Order"
        bttn_frm3BtOrder.UseVisualStyleBackColor = True
        ' 
        ' Panel_MiddleRight
        ' 
        Panel_MiddleRight.BackColor = Color.FromArgb(CByte(108), CByte(78), CByte(49))
        Panel_MiddleRight.Controls.Add(Total)
        Panel_MiddleRight.Controls.Add(Label_TotalTitle)
        Panel_MiddleRight.Controls.Add(Button2)
        Panel_MiddleRight.Controls.Add(discount)
        Panel_MiddleRight.Controls.Add(Label_DiscountTitle)
        Panel_MiddleRight.Controls.Add(standardDelivery)
        Panel_MiddleRight.Controls.Add(Label_SDeliveryTitle)
        Panel_MiddleRight.Controls.Add(Subtotal)
        Panel_MiddleRight.Controls.Add(Label_SubtotalTitle)
        Panel_MiddleRight.Dock = DockStyle.Top
        Panel_MiddleRight.Location = New Point(666, 48)
        Panel_MiddleRight.Name = "Panel_MiddleRight"
        Panel_MiddleRight.Size = New Size(361, 419)
        Panel_MiddleRight.TabIndex = 3
        ' 
        ' Total
        ' 
        Total.AutoSize = True
        Total.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Total.ForeColor = Color.BurlyWood
        Total.Location = New Point(252, 240)
        Total.Name = "Total"
        Total.Size = New Size(25, 34)
        Total.TabIndex = 8
        Total.Text = "0"
        ' 
        ' Label_TotalTitle
        ' 
        Label_TotalTitle.AutoSize = True
        Label_TotalTitle.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_TotalTitle.ForeColor = Color.BurlyWood
        Label_TotalTitle.Location = New Point(17, 230)
        Label_TotalTitle.Name = "Label_TotalTitle"
        Label_TotalTitle.Size = New Size(78, 52)
        Label_TotalTitle.TabIndex = 7
        Label_TotalTitle.Text = "Total"
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Gray
        Button2.Location = New Point(17, 169)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 37)
        Button2.TabIndex = 6
        Button2.Text = "Apply Voucher"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' discount
        ' 
        discount.AutoSize = True
        discount.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        discount.ForeColor = Color.BurlyWood
        discount.Location = New Point(252, 136)
        discount.Name = "discount"
        discount.Size = New Size(25, 34)
        discount.TabIndex = 5
        discount.Text = "0"
        ' 
        ' Label_DiscountTitle
        ' 
        Label_DiscountTitle.AutoSize = True
        Label_DiscountTitle.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_DiscountTitle.ForeColor = Color.BurlyWood
        Label_DiscountTitle.Location = New Point(17, 130)
        Label_DiscountTitle.Name = "Label_DiscountTitle"
        Label_DiscountTitle.Size = New Size(120, 52)
        Label_DiscountTitle.TabIndex = 4
        Label_DiscountTitle.Text = "Discount"
        ' 
        ' standardDelivery
        ' 
        standardDelivery.AutoSize = True
        standardDelivery.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        standardDelivery.ForeColor = Color.BurlyWood
        standardDelivery.Location = New Point(252, 85)
        standardDelivery.Name = "standardDelivery"
        standardDelivery.Size = New Size(25, 34)
        standardDelivery.TabIndex = 3
        standardDelivery.Text = "0"
        ' 
        ' Label_SDeliveryTitle
        ' 
        Label_SDeliveryTitle.AutoSize = True
        Label_SDeliveryTitle.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_SDeliveryTitle.ForeColor = Color.BurlyWood
        Label_SDeliveryTitle.Location = New Point(17, 78)
        Label_SDeliveryTitle.Name = "Label_SDeliveryTitle"
        Label_SDeliveryTitle.Size = New Size(220, 52)
        Label_SDeliveryTitle.TabIndex = 2
        Label_SDeliveryTitle.Text = "Standard Delivery"
        ' 
        ' Subtotal
        ' 
        Subtotal.AutoSize = True
        Subtotal.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Subtotal.ForeColor = Color.BurlyWood
        Subtotal.Location = New Point(252, 37)
        Subtotal.Name = "Subtotal"
        Subtotal.Size = New Size(25, 34)
        Subtotal.TabIndex = 1
        Subtotal.Text = "0"
        ' 
        ' Label_SubtotalTitle
        ' 
        Label_SubtotalTitle.AutoSize = True
        Label_SubtotalTitle.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_SubtotalTitle.ForeColor = Color.BurlyWood
        Label_SubtotalTitle.Location = New Point(17, 33)
        Label_SubtotalTitle.Name = "Label_SubtotalTitle"
        Label_SubtotalTitle.Size = New Size(115, 52)
        Label_SubtotalTitle.TabIndex = 0
        Label_SubtotalTitle.Text = "Subtotal"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(1027, 539)
        Controls.Add(Panel_MiddleRight)
        Controls.Add(Panel_BottomRight)
        Controls.Add(Panel_TopRight)
        Controls.Add(Panel_Left)
        Name = "Form3"
        Text = "Cart"
        Panel_Left.ResumeLayout(False)
        Panel_TopRight.ResumeLayout(False)
        Panel_BottomRight.ResumeLayout(False)
        Panel_MiddleRight.ResumeLayout(False)
        Panel_MiddleRight.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Left As Panel
    Friend WithEvents Panel_TopRight As Panel
    Friend WithEvents Panel_BottomRight As Panel
    Friend WithEvents Panel_MiddleRight As Panel
    Friend WithEvents bttn_account As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_ListofOrder As Label
    Friend WithEvents bttn_frm3BtOrder As Button
    Friend WithEvents Label_SubtotalTitle As Label
    Friend WithEvents Label_SDeliveryTitle As Label
    Friend WithEvents Subtotal As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents discount As Label
    Friend WithEvents Label_DiscountTitle As Label
    Friend WithEvents standardDelivery As Label
    Friend WithEvents Total As Label
    Friend WithEvents Label_TotalTitle As Label
End Class
