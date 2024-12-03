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
        Me.Label_ForgotPWTitle = New System.Windows.Forms.Label()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.Label_Email = New System.Windows.Forms.Label()
        Me.TB_Username = New System.Windows.Forms.TextBox()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.bttn_Retrieve = New System.Windows.Forms.Button()
        Me.bttn_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_ForgotPWTitle
        '
        Me.Label_ForgotPWTitle.AutoSize = True
        Me.Label_ForgotPWTitle.Font = New System.Drawing.Font("Javanese Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_ForgotPWTitle.Location = New System.Drawing.Point(143, 47)
        Me.Label_ForgotPWTitle.Name = "Label_ForgotPWTitle"
        Me.Label_ForgotPWTitle.Size = New System.Drawing.Size(222, 52)
        Me.Label_ForgotPWTitle.TabIndex = 2
        Me.Label_ForgotPWTitle.Text = "Retrieve Password"
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(202, 144)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(230, 27)
        Me.TB_Email.TabIndex = 15
        '
        'Label_Email
        '
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_Email.Location = New System.Drawing.Point(69, 138)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(83, 45)
        Me.Label_Email.TabIndex = 14
        Me.Label_Email.Text = "Email:"
        '
        'TB_Username
        '
        Me.TB_Username.Location = New System.Drawing.Point(202, 105)
        Me.TB_Username.Name = "TB_Username"
        Me.TB_Username.Size = New System.Drawing.Size(230, 27)
        Me.TB_Username.TabIndex = 17
        '
        'Label_Username
        '
        Me.Label_Username.AutoSize = True
        Me.Label_Username.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_Username.Location = New System.Drawing.Point(69, 99)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(123, 45)
        Me.Label_Username.TabIndex = 16
        Me.Label_Username.Text = "Username:"
        '
        'bttn_Retrieve
        '
        Me.bttn_Retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttn_Retrieve.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttn_Retrieve.Location = New System.Drawing.Point(290, 195)
        Me.bttn_Retrieve.Name = "bttn_Retrieve"
        Me.bttn_Retrieve.Size = New System.Drawing.Size(142, 37)
        Me.bttn_Retrieve.TabIndex = 19
        Me.bttn_Retrieve.Text = "Retrieve"
        Me.bttn_Retrieve.UseVisualStyleBackColor = True
        '
        'bttn_close
        '
        Me.bttn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttn_close.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttn_close.Location = New System.Drawing.Point(69, 195)
        Me.bttn_close.Name = "bttn_close"
        Me.bttn_close.Size = New System.Drawing.Size(142, 37)
        Me.bttn_close.TabIndex = 20
        Me.bttn_close.Text = "Close"
        Me.bttn_close.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(504, 292)
        Me.Controls.Add(Me.bttn_close)
        Me.Controls.Add(Me.bttn_Retrieve)
        Me.Controls.Add(Me.TB_Username)
        Me.Controls.Add(Me.Label_Username)
        Me.Controls.Add(Me.TB_Email)
        Me.Controls.Add(Me.Label_Email)
        Me.Controls.Add(Me.Label_ForgotPWTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retrieve Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_ForgotPWTitle As Label
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents TB_Username As TextBox
    Friend WithEvents Label_Username As Label
    Friend WithEvents bttn_Retrieve As Button
    Friend WithEvents bttn_close As Button
End Class
