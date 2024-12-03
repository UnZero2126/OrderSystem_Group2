<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label_LogInTitle = New System.Windows.Forms.Label()
        Me.PB_Logo = New System.Windows.Forms.PictureBox()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.TB_Username = New System.Windows.Forms.TextBox()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.Label_password = New System.Windows.Forms.Label()
        Me.bttn_Login = New System.Windows.Forms.Button()
        Me.bttn_signup = New System.Windows.Forms.Button()
        Me.bttn_forgotPW = New System.Windows.Forms.Button()
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_LogInTitle
        '
        Me.Label_LogInTitle.AutoSize = True
        Me.Label_LogInTitle.Font = New System.Drawing.Font("Javanese Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_LogInTitle.Location = New System.Drawing.Point(406, 66)
        Me.Label_LogInTitle.Name = "Label_LogInTitle"
        Me.Label_LogInTitle.Size = New System.Drawing.Size(92, 52)
        Me.Label_LogInTitle.TabIndex = 0
        Me.Label_LogInTitle.Text = "Log In"
        '
        'PB_Logo
        '
        Me.PB_Logo.BackgroundImage = Global.ITECC_OrderSystem.My.Resources.Resources.icons8_ramen_99
        Me.PB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_Logo.Location = New System.Drawing.Point(37, 63)
        Me.PB_Logo.Name = "PB_Logo"
        Me.PB_Logo.Size = New System.Drawing.Size(239, 237)
        Me.PB_Logo.TabIndex = 1
        Me.PB_Logo.TabStop = False
        '
        'Label_username
        '
        Me.Label_username.AutoSize = True
        Me.Label_username.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_username.Location = New System.Drawing.Point(306, 118)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(123, 45)
        Me.Label_username.TabIndex = 2
        Me.Label_username.Text = "Username:"
        '
        'TB_Username
        '
        Me.TB_Username.Location = New System.Drawing.Point(435, 124)
        Me.TB_Username.Name = "TB_Username"
        Me.TB_Username.Size = New System.Drawing.Size(159, 27)
        Me.TB_Username.TabIndex = 3
        '
        'TB_Password
        '
        Me.TB_Password.Location = New System.Drawing.Point(435, 171)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_Password.Size = New System.Drawing.Size(159, 27)
        Me.TB_Password.TabIndex = 5
        Me.TB_Password.UseSystemPasswordChar = True
        '
        'Label_password
        '
        Me.Label_password.AutoSize = True
        Me.Label_password.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_password.Location = New System.Drawing.Point(306, 165)
        Me.Label_password.Name = "Label_password"
        Me.Label_password.Size = New System.Drawing.Size(116, 45)
        Me.Label_password.TabIndex = 4
        Me.Label_password.Text = "Password:"
        '
        'bttn_Login
        '
        Me.bttn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttn_Login.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bttn_Login.Location = New System.Drawing.Point(473, 259)
        Me.bttn_Login.Name = "bttn_Login"
        Me.bttn_Login.Size = New System.Drawing.Size(121, 35)
        Me.bttn_Login.TabIndex = 6
        Me.bttn_Login.Text = "Log In"
        Me.bttn_Login.UseVisualStyleBackColor = True
        '
        'bttn_signup
        '
        Me.bttn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttn_signup.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bttn_signup.Location = New System.Drawing.Point(308, 259)
        Me.bttn_signup.Name = "bttn_signup"
        Me.bttn_signup.Size = New System.Drawing.Size(121, 35)
        Me.bttn_signup.TabIndex = 7
        Me.bttn_signup.Text = "Sign Up"
        Me.bttn_signup.UseVisualStyleBackColor = True
        '
        'bttn_forgotPW
        '
        Me.bttn_forgotPW.FlatAppearance.BorderSize = 0
        Me.bttn_forgotPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn_forgotPW.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttn_forgotPW.Location = New System.Drawing.Point(365, 207)
        Me.bttn_forgotPW.Name = "bttn_forgotPW"
        Me.bttn_forgotPW.Size = New System.Drawing.Size(171, 33)
        Me.bttn_forgotPW.TabIndex = 8
        Me.bttn_forgotPW.Text = "Forgot Password?"
        Me.bttn_forgotPW.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(647, 353)
        Me.Controls.Add(Me.bttn_forgotPW)
        Me.Controls.Add(Me.bttn_signup)
        Me.Controls.Add(Me.bttn_Login)
        Me.Controls.Add(Me.TB_Password)
        Me.Controls.Add(Me.Label_password)
        Me.Controls.Add(Me.TB_Username)
        Me.Controls.Add(Me.Label_username)
        Me.Controls.Add(Me.PB_Logo)
        Me.Controls.Add(Me.Label_LogInTitle)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_LogInTitle As Label
    Friend WithEvents PB_Logo As PictureBox
    Friend WithEvents Label_username As Label
    Friend WithEvents TB_Username As TextBox
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents Label_password As Label
    Friend WithEvents bttn_Login As Button
    Friend WithEvents bttn_signup As Button
    Friend WithEvents bttn_forgotPW As Button
End Class
