<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label_TitleVoucher = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label_TitleVoucher
        ' 
        Label_TitleVoucher.AutoSize = True
        Label_TitleVoucher.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_TitleVoucher.ForeColor = Color.FromArgb(CByte(108), CByte(78), CByte(49))
        Label_TitleVoucher.Location = New Point(97, 38)
        Label_TitleVoucher.Name = "Label_TitleVoucher"
        Label_TitleVoucher.Size = New Size(183, 52)
        Label_TitleVoucher.TabIndex = 0
        Label_TitleVoucher.Text = "Voucher Code:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(44, 84)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(287, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(181, 131)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 36)
        Button1.TabIndex = 2
        Button1.Text = "Apply Voucher"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(44, 131)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 36)
        Button2.TabIndex = 3
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(381, 209)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label_TitleVoucher)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_TitleVoucher As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
