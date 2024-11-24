<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Label_ForgotPWTitle = New Label()
        TB_Email = New TextBox()
        Label_Email = New Label()
        TB_Username = New TextBox()
        Label_Username = New Label()
        bttn_Retrieve = New Button()
        bttn_close = New Button()
        SuspendLayout()
        ' 
        ' Label_ForgotPWTitle
        ' 
        Label_ForgotPWTitle.AutoSize = True
        Label_ForgotPWTitle.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_ForgotPWTitle.Location = New Point(143, 47)
        Label_ForgotPWTitle.Name = "Label_ForgotPWTitle"
        Label_ForgotPWTitle.Size = New Size(222, 52)
        Label_ForgotPWTitle.TabIndex = 2
        Label_ForgotPWTitle.Text = "Retrieve Password"
        ' 
        ' TB_Email
        ' 
        TB_Email.Location = New Point(202, 144)
        TB_Email.Name = "TB_Email"
        TB_Email.Size = New Size(230, 27)
        TB_Email.TabIndex = 15
        ' 
        ' Label_Email
        ' 
        Label_Email.AutoSize = True
        Label_Email.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Email.Location = New Point(69, 138)
        Label_Email.Name = "Label_Email"
        Label_Email.Size = New Size(83, 45)
        Label_Email.TabIndex = 14
        Label_Email.Text = "Email:"
        ' 
        ' TB_Username
        ' 
        TB_Username.Location = New Point(202, 105)
        TB_Username.Name = "TB_Username"
        TB_Username.Size = New Size(230, 27)
        TB_Username.TabIndex = 17
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.Location = New Point(69, 99)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(123, 45)
        Label_Username.TabIndex = 16
        Label_Username.Text = "Username:"
        ' 
        ' bttn_Retrieve
        ' 
        bttn_Retrieve.FlatStyle = FlatStyle.Popup
        bttn_Retrieve.Font = New Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bttn_Retrieve.Location = New Point(290, 195)
        bttn_Retrieve.Name = "bttn_Retrieve"
        bttn_Retrieve.Size = New Size(142, 37)
        bttn_Retrieve.TabIndex = 19
        bttn_Retrieve.Text = "Retrieve"
        bttn_Retrieve.UseVisualStyleBackColor = True
        ' 
        ' bttn_close
        ' 
        bttn_close.FlatStyle = FlatStyle.Popup
        bttn_close.Font = New Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bttn_close.Location = New Point(69, 195)
        bttn_close.Name = "bttn_close"
        bttn_close.Size = New Size(142, 37)
        bttn_close.TabIndex = 20
        bttn_close.Text = "Close"
        bttn_close.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(504, 292)
        Controls.Add(bttn_close)
        Controls.Add(bttn_Retrieve)
        Controls.Add(TB_Username)
        Controls.Add(Label_Username)
        Controls.Add(TB_Email)
        Controls.Add(Label_Email)
        Controls.Add(Label_ForgotPWTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Retrieve Password"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_ForgotPWTitle As Label
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents TB_Username As TextBox
    Friend WithEvents Label_Username As Label
    Friend WithEvents bttn_Retrieve As Button
    Friend WithEvents bttn_close As Button
End Class
