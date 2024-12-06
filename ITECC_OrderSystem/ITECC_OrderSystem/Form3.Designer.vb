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
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.ListBox1_ListofOrder = New System.Windows.Forms.ListBox()
        Me.deleteOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_TopRight = New System.Windows.Forms.Panel()
        Me.bttn_account = New System.Windows.Forms.Button()
        Me.Panel_BottomRight = New System.Windows.Forms.Panel()
        Me.bttn_frm3BtOrder = New System.Windows.Forms.Button()
        Me.Panel_MiddleRight = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.Label()
        Me.Label_TotalTitle = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.discount = New System.Windows.Forms.Label()
        Me.Label_DiscountTitle = New System.Windows.Forms.Label()
        Me.standardDelivery = New System.Windows.Forms.Label()
        Me.Label_SDeliveryTitle = New System.Windows.Forms.Label()
        Me.Subtotal = New System.Windows.Forms.Label()
        Me.Label_SubtotalTitle = New System.Windows.Forms.Label()
        Me.Panel_Left.SuspendLayout()
        Me.Panel_TopRight.SuspendLayout()
        Me.Panel_BottomRight.SuspendLayout()
        Me.Panel_MiddleRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Left
        '
        Me.Panel_Left.AutoScroll = True
        Me.Panel_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Panel_Left.Controls.Add(Me.ListBox1_ListofOrder)
        Me.Panel_Left.Controls.Add(Me.deleteOrder)
        Me.Panel_Left.Controls.Add(Me.Label1)
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(666, 539)
        Me.Panel_Left.TabIndex = 0
        '
        'ListBox1_ListofOrder
        '
        Me.ListBox1_ListofOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ListBox1_ListofOrder.FormattingEnabled = True
        Me.ListBox1_ListofOrder.ItemHeight = 20
        Me.ListBox1_ListofOrder.Location = New System.Drawing.Point(55, 133)
        Me.ListBox1_ListofOrder.Name = "ListBox1_ListofOrder"
        Me.ListBox1_ListofOrder.Size = New System.Drawing.Size(443, 344)
        Me.ListBox1_ListofOrder.TabIndex = 7
        '
        'deleteOrder
        '
        Me.deleteOrder.Location = New System.Drawing.Point(531, 448)
        Me.deleteOrder.Name = "deleteOrder"
        Me.deleteOrder.Size = New System.Drawing.Size(94, 29)
        Me.deleteOrder.TabIndex = 6
        Me.deleteOrder.Text = "Delete"
        Me.deleteOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(153, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 104)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Cart!"
        '
        'Panel_TopRight
        '
        Me.Panel_TopRight.Controls.Add(Me.bttn_account)
        Me.Panel_TopRight.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TopRight.Location = New System.Drawing.Point(666, 0)
        Me.Panel_TopRight.Name = "Panel_TopRight"
        Me.Panel_TopRight.Size = New System.Drawing.Size(361, 48)
        Me.Panel_TopRight.TabIndex = 1
        '
        'bttn_account
        '
        Me.bttn_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bttn_account.Dock = System.Windows.Forms.DockStyle.Right
        Me.bttn_account.FlatAppearance.BorderSize = 0
        Me.bttn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn_account.ForeColor = System.Drawing.Color.Cornsilk
        Me.bttn_account.Image = Global.ITECC_OrderSystem.My.Resources.Resources.icons8_account_20
        Me.bttn_account.Location = New System.Drawing.Point(318, 0)
        Me.bttn_account.Name = "bttn_account"
        Me.bttn_account.Size = New System.Drawing.Size(43, 48)
        Me.bttn_account.TabIndex = 2
        Me.bttn_account.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttn_account.UseVisualStyleBackColor = True
        '
        'Panel_BottomRight
        '
        Me.Panel_BottomRight.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel_BottomRight.Controls.Add(Me.bttn_frm3BtOrder)
        Me.Panel_BottomRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_BottomRight.Location = New System.Drawing.Point(666, 48)
        Me.Panel_BottomRight.Name = "Panel_BottomRight"
        Me.Panel_BottomRight.Size = New System.Drawing.Size(361, 491)
        Me.Panel_BottomRight.TabIndex = 2
        '
        'bttn_frm3BtOrder
        '
        Me.bttn_frm3BtOrder.FlatAppearance.BorderSize = 0
        Me.bttn_frm3BtOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn_frm3BtOrder.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bttn_frm3BtOrder.Location = New System.Drawing.Point(77, 436)
        Me.bttn_frm3BtOrder.Name = "bttn_frm3BtOrder"
        Me.bttn_frm3BtOrder.Size = New System.Drawing.Size(223, 43)
        Me.bttn_frm3BtOrder.TabIndex = 2
        Me.bttn_frm3BtOrder.Text = "Back to Order"
        Me.bttn_frm3BtOrder.UseVisualStyleBackColor = True
        '
        'Panel_MiddleRight
        '
        Me.Panel_MiddleRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel_MiddleRight.Controls.Add(Me.Button1)
        Me.Panel_MiddleRight.Controls.Add(Me.Total)
        Me.Panel_MiddleRight.Controls.Add(Me.Label_TotalTitle)
        Me.Panel_MiddleRight.Controls.Add(Me.Button2)
        Me.Panel_MiddleRight.Controls.Add(Me.discount)
        Me.Panel_MiddleRight.Controls.Add(Me.Label_DiscountTitle)
        Me.Panel_MiddleRight.Controls.Add(Me.standardDelivery)
        Me.Panel_MiddleRight.Controls.Add(Me.Label_SDeliveryTitle)
        Me.Panel_MiddleRight.Controls.Add(Me.Subtotal)
        Me.Panel_MiddleRight.Controls.Add(Me.Label_SubtotalTitle)
        Me.Panel_MiddleRight.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_MiddleRight.Location = New System.Drawing.Point(666, 48)
        Me.Panel_MiddleRight.Name = "Panel_MiddleRight"
        Me.Panel_MiddleRight.Size = New System.Drawing.Size(361, 419)
        Me.Panel_MiddleRight.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(17, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Change Delivery Address"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Total.ForeColor = System.Drawing.Color.BurlyWood
        Me.Total.Location = New System.Drawing.Point(252, 265)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(25, 34)
        Me.Total.TabIndex = 8
        Me.Total.Text = "0"
        '
        'Label_TotalTitle
        '
        Me.Label_TotalTitle.AutoSize = True
        Me.Label_TotalTitle.Font = New System.Drawing.Font("Javanese Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_TotalTitle.ForeColor = System.Drawing.Color.BurlyWood
        Me.Label_TotalTitle.Location = New System.Drawing.Point(17, 255)
        Me.Label_TotalTitle.Name = "Label_TotalTitle"
        Me.Label_TotalTitle.Size = New System.Drawing.Size(78, 52)
        Me.Label_TotalTitle.TabIndex = 7
        Me.Label_TotalTitle.Text = "Total"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Gray
        Me.Button2.Location = New System.Drawing.Point(17, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Apply Voucher"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'discount
        '
        Me.discount.AutoSize = True
        Me.discount.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.discount.ForeColor = System.Drawing.Color.BurlyWood
        Me.discount.Location = New System.Drawing.Point(252, 157)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(25, 34)
        Me.discount.TabIndex = 5
        Me.discount.Text = "0"
        '
        'Label_DiscountTitle
        '
        Me.Label_DiscountTitle.AutoSize = True
        Me.Label_DiscountTitle.Font = New System.Drawing.Font("Javanese Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_DiscountTitle.ForeColor = System.Drawing.Color.BurlyWood
        Me.Label_DiscountTitle.Location = New System.Drawing.Point(17, 151)
        Me.Label_DiscountTitle.Name = "Label_DiscountTitle"
        Me.Label_DiscountTitle.Size = New System.Drawing.Size(120, 52)
        Me.Label_DiscountTitle.TabIndex = 4
        Me.Label_DiscountTitle.Text = "Discount"
        '
        'standardDelivery
        '
        Me.standardDelivery.AutoSize = True
        Me.standardDelivery.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.standardDelivery.ForeColor = System.Drawing.Color.BurlyWood
        Me.standardDelivery.Location = New System.Drawing.Point(252, 85)
        Me.standardDelivery.Name = "standardDelivery"
        Me.standardDelivery.Size = New System.Drawing.Size(25, 34)
        Me.standardDelivery.TabIndex = 3
        Me.standardDelivery.Text = "0"
        '
        'Label_SDeliveryTitle
        '
        Me.Label_SDeliveryTitle.AutoSize = True
        Me.Label_SDeliveryTitle.Font = New System.Drawing.Font("Javanese Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_SDeliveryTitle.ForeColor = System.Drawing.Color.BurlyWood
        Me.Label_SDeliveryTitle.Location = New System.Drawing.Point(17, 78)
        Me.Label_SDeliveryTitle.Name = "Label_SDeliveryTitle"
        Me.Label_SDeliveryTitle.Size = New System.Drawing.Size(220, 52)
        Me.Label_SDeliveryTitle.TabIndex = 2
        Me.Label_SDeliveryTitle.Text = "Standard Delivery"
        '
        'Subtotal
        '
        Me.Subtotal.AutoSize = True
        Me.Subtotal.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Subtotal.ForeColor = System.Drawing.Color.BurlyWood
        Me.Subtotal.Location = New System.Drawing.Point(252, 37)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(25, 34)
        Me.Subtotal.TabIndex = 1
        Me.Subtotal.Text = "0"
        '
        'Label_SubtotalTitle
        '
        Me.Label_SubtotalTitle.AutoSize = True
        Me.Label_SubtotalTitle.Font = New System.Drawing.Font("Javanese Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_SubtotalTitle.ForeColor = System.Drawing.Color.BurlyWood
        Me.Label_SubtotalTitle.Location = New System.Drawing.Point(17, 33)
        Me.Label_SubtotalTitle.Name = "Label_SubtotalTitle"
        Me.Label_SubtotalTitle.Size = New System.Drawing.Size(115, 52)
        Me.Label_SubtotalTitle.TabIndex = 0
        Me.Label_SubtotalTitle.Text = "Subtotal"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(1027, 539)
        Me.Controls.Add(Me.Panel_MiddleRight)
        Me.Controls.Add(Me.Panel_BottomRight)
        Me.Controls.Add(Me.Panel_TopRight)
        Me.Controls.Add(Me.Panel_Left)
        Me.Name = "Form3"
        Me.Text = "Cart"
        Me.Panel_Left.ResumeLayout(False)
        Me.Panel_TopRight.ResumeLayout(False)
        Me.Panel_BottomRight.ResumeLayout(False)
        Me.Panel_MiddleRight.ResumeLayout(False)
        Me.Panel_MiddleRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Left As Panel
    Friend WithEvents Panel_TopRight As Panel
    Friend WithEvents Panel_BottomRight As Panel
    Friend WithEvents Panel_MiddleRight As Panel
    Friend WithEvents bttn_account As Button
    Friend WithEvents Label1 As Label
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
    Friend WithEvents deleteOrder As Button
    Friend WithEvents ListBox1_ListofOrder As ListBox
    Friend WithEvents Button1 As Button
End Class
