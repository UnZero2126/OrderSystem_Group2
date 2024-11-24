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
        Label_LogInTitle = New Label()
        PB_Logo = New PictureBox()
        Label_username = New Label()
        TB_Username = New TextBox()
        TB_Password = New TextBox()
        Label_password = New Label()
        bttn_Login = New Button()
        bttn_signup = New Button()
        bttn_forgotPW = New Button()
        CType(PB_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_LogInTitle
        ' 
        Label_LogInTitle.AutoSize = True
        Label_LogInTitle.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_LogInTitle.Location = New Point(406, 66)
        Label_LogInTitle.Name = "Label_LogInTitle"
        Label_LogInTitle.Size = New Size(92, 52)
        Label_LogInTitle.TabIndex = 0
        Label_LogInTitle.Text = "Log In"
        ' 
        ' PB_Logo
        ' 
        PB_Logo.BackgroundImage = My.Resources.Resources.icons8_ramen_99
        PB_Logo.BackgroundImageLayout = ImageLayout.Zoom
        PB_Logo.Location = New Point(37, 63)
        PB_Logo.Name = "PB_Logo"
        PB_Logo.Size = New Size(239, 237)
        PB_Logo.TabIndex = 1
        PB_Logo.TabStop = False
        ' 
        ' Label_username
        ' 
        Label_username.AutoSize = True
        Label_username.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_username.Location = New Point(306, 118)
        Label_username.Name = "Label_username"
        Label_username.Size = New Size(123, 45)
        Label_username.TabIndex = 2
        Label_username.Text = "Username:"
        ' 
        ' TB_Username
        ' 
        TB_Username.Location = New Point(435, 124)
        TB_Username.Name = "TB_Username"
        TB_Username.Size = New Size(159, 27)
        TB_Username.TabIndex = 3
        ' 
        ' TB_Password
        ' 
        TB_Password.Location = New Point(435, 171)
        TB_Password.Name = "TB_Password"
        TB_Password.Size = New Size(159, 27)
        TB_Password.TabIndex = 5
        TB_Password.UseSystemPasswordChar = True
        ' 
        ' Label_password
        ' 
        Label_password.AutoSize = True
        Label_password.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_password.Location = New Point(306, 165)
        Label_password.Name = "Label_password"
        Label_password.Size = New Size(116, 45)
        Label_password.TabIndex = 4
        Label_password.Text = "Password:"
        ' 
        ' bttn_Login
        ' 
        bttn_Login.FlatStyle = FlatStyle.Popup
        bttn_Login.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        bttn_Login.Location = New Point(473, 259)
        bttn_Login.Name = "bttn_Login"
        bttn_Login.Size = New Size(121, 35)
        bttn_Login.TabIndex = 6
        bttn_Login.Text = "Log In"
        bttn_Login.UseVisualStyleBackColor = True
        ' 
        ' bttn_signup
        ' 
        bttn_signup.FlatStyle = FlatStyle.Popup
        bttn_signup.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        bttn_signup.Location = New Point(308, 259)
        bttn_signup.Name = "bttn_signup"
        bttn_signup.Size = New Size(121, 35)
        bttn_signup.TabIndex = 7
        bttn_signup.Text = "Sign Up"
        bttn_signup.UseVisualStyleBackColor = True
        ' 
        ' bttn_forgotPW
        ' 
        bttn_forgotPW.FlatAppearance.BorderSize = 0
        bttn_forgotPW.FlatStyle = FlatStyle.Flat
        bttn_forgotPW.Font = New Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bttn_forgotPW.Location = New Point(365, 207)
        bttn_forgotPW.Name = "bttn_forgotPW"
        bttn_forgotPW.Size = New Size(171, 33)
        bttn_forgotPW.TabIndex = 8
        bttn_forgotPW.Text = "Forgot Password?"
        bttn_forgotPW.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(647, 353)
        Controls.Add(bttn_forgotPW)
        Controls.Add(bttn_signup)
        Controls.Add(bttn_Login)
        Controls.Add(TB_Password)
        Controls.Add(Label_password)
        Controls.Add(TB_Username)
        Controls.Add(Label_username)
        Controls.Add(PB_Logo)
        Controls.Add(Label_LogInTitle)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PB_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
