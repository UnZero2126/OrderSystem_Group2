<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Label_SignUpTitle = New Label()
        PB_Logo = New PictureBox()
        TB_FirstName = New TextBox()
        Label_firstName = New Label()
        TB_LastName = New TextBox()
        Label_lastName = New Label()
        TB_PhoneNo = New TextBox()
        Label_PhoneNo = New Label()
        TB_Address = New TextBox()
        Label_Address = New Label()
        TB_Email = New TextBox()
        Label_Email = New Label()
        TB_Password = New TextBox()
        Label_Password = New Label()
        TB_Username = New TextBox()
        Label_Username = New Label()
        bttn_GoLogIn = New Button()
        Button2 = New Button()
        Label_GoLogin = New Label()
        CType(PB_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_SignUpTitle
        ' 
        Label_SignUpTitle.AutoSize = True
        Label_SignUpTitle.Font = New Font("Javanese Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_SignUpTitle.Location = New Point(303, 19)
        Label_SignUpTitle.Name = "Label_SignUpTitle"
        Label_SignUpTitle.Size = New Size(225, 52)
        Label_SignUpTitle.TabIndex = 1
        Label_SignUpTitle.Text = "Create an Account"
        ' 
        ' PB_Logo
        ' 
        PB_Logo.BackgroundImage = My.Resources.Resources.IMG_2774
        PB_Logo.BackgroundImageLayout = ImageLayout.Zoom
        PB_Logo.Location = New Point(36, 39)
        PB_Logo.Name = "PB_Logo"
        PB_Logo.Size = New Size(173, 237)
        PB_Logo.TabIndex = 2
        PB_Logo.TabStop = False
        ' 
        ' TB_FirstName
        ' 
        TB_FirstName.Location = New Point(372, 87)
        TB_FirstName.Name = "TB_FirstName"
        TB_FirstName.Size = New Size(230, 27)
        TB_FirstName.TabIndex = 5
        ' 
        ' Label_firstName
        ' 
        Label_firstName.AutoSize = True
        Label_firstName.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_firstName.Location = New Point(239, 81)
        Label_firstName.Name = "Label_firstName"
        Label_firstName.Size = New Size(134, 45)
        Label_firstName.TabIndex = 4
        Label_firstName.Text = "First Name:"
        ' 
        ' TB_LastName
        ' 
        TB_LastName.Location = New Point(372, 129)
        TB_LastName.Name = "TB_LastName"
        TB_LastName.Size = New Size(230, 27)
        TB_LastName.TabIndex = 7
        ' 
        ' Label_lastName
        ' 
        Label_lastName.AutoSize = True
        Label_lastName.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_lastName.Location = New Point(239, 123)
        Label_lastName.Name = "Label_lastName"
        Label_lastName.Size = New Size(129, 45)
        Label_lastName.TabIndex = 6
        Label_lastName.Text = "Last Name:"
        ' 
        ' TB_PhoneNo
        ' 
        TB_PhoneNo.Location = New Point(372, 176)
        TB_PhoneNo.Name = "TB_PhoneNo"
        TB_PhoneNo.Size = New Size(230, 27)
        TB_PhoneNo.TabIndex = 9
        ' 
        ' Label_PhoneNo
        ' 
        Label_PhoneNo.AutoSize = True
        Label_PhoneNo.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_PhoneNo.Location = New Point(239, 170)
        Label_PhoneNo.Name = "Label_PhoneNo"
        Label_PhoneNo.Size = New Size(126, 45)
        Label_PhoneNo.TabIndex = 8
        Label_PhoneNo.Text = "Phone No.:"
        ' 
        ' TB_Address
        ' 
        TB_Address.Location = New Point(372, 221)
        TB_Address.Name = "TB_Address"
        TB_Address.Size = New Size(230, 27)
        TB_Address.TabIndex = 11
        ' 
        ' Label_Address
        ' 
        Label_Address.AutoSize = True
        Label_Address.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Address.Location = New Point(239, 215)
        Label_Address.Name = "Label_Address"
        Label_Address.Size = New Size(104, 45)
        Label_Address.TabIndex = 10
        Label_Address.Text = "Address:"
        ' 
        ' TB_Email
        ' 
        TB_Email.Location = New Point(372, 269)
        TB_Email.Name = "TB_Email"
        TB_Email.Size = New Size(230, 27)
        TB_Email.TabIndex = 13
        ' 
        ' Label_Email
        ' 
        Label_Email.AutoSize = True
        Label_Email.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Email.Location = New Point(239, 263)
        Label_Email.Name = "Label_Email"
        Label_Email.Size = New Size(83, 45)
        Label_Email.TabIndex = 12
        Label_Email.Text = "Email:"
        ' 
        ' TB_Password
        ' 
        TB_Password.Location = New Point(372, 360)
        TB_Password.Name = "TB_Password"
        TB_Password.Size = New Size(230, 27)
        TB_Password.TabIndex = 17
        TB_Password.UseSystemPasswordChar = True
        ' 
        ' Label_Password
        ' 
        Label_Password.AutoSize = True
        Label_Password.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Password.Location = New Point(239, 354)
        Label_Password.Name = "Label_Password"
        Label_Password.Size = New Size(116, 45)
        Label_Password.TabIndex = 16
        Label_Password.Text = "Password:"
        ' 
        ' TB_Username
        ' 
        TB_Username.Location = New Point(372, 312)
        TB_Username.Name = "TB_Username"
        TB_Username.Size = New Size(230, 27)
        TB_Username.TabIndex = 15
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.Location = New Point(239, 306)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(123, 45)
        Label_Username.TabIndex = 14
        Label_Username.Text = "Username:"
        ' 
        ' bttn_GoLogIn
        ' 
        bttn_GoLogIn.FlatStyle = FlatStyle.Popup
        bttn_GoLogIn.Font = New Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bttn_GoLogIn.Location = New Point(36, 306)
        bttn_GoLogIn.Name = "bttn_GoLogIn"
        bttn_GoLogIn.Size = New Size(173, 37)
        bttn_GoLogIn.TabIndex = 18
        bttn_GoLogIn.Text = "Log In"
        bttn_GoLogIn.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(36, 363)
        Button2.Name = "Button2"
        Button2.Size = New Size(173, 39)
        Button2.TabIndex = 19
        Button2.Text = "Create Account"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label_GoLogin
        ' 
        Label_GoLogin.AutoSize = True
        Label_GoLogin.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label_GoLogin.Location = New Point(24, 281)
        Label_GoLogin.Name = "Label_GoLogin"
        Label_GoLogin.Size = New Size(201, 34)
        Label_GoLogin.TabIndex = 20
        Label_GoLogin.Text = "Already have an account?"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Cornsilk
        ClientSize = New Size(646, 422)
        Controls.Add(Label_GoLogin)
        Controls.Add(Button2)
        Controls.Add(bttn_GoLogIn)
        Controls.Add(TB_Password)
        Controls.Add(Label_Password)
        Controls.Add(TB_Username)
        Controls.Add(Label_Username)
        Controls.Add(TB_Email)
        Controls.Add(Label_Email)
        Controls.Add(TB_Address)
        Controls.Add(Label_Address)
        Controls.Add(TB_PhoneNo)
        Controls.Add(Label_PhoneNo)
        Controls.Add(TB_LastName)
        Controls.Add(Label_lastName)
        Controls.Add(TB_FirstName)
        Controls.Add(Label_firstName)
        Controls.Add(PB_Logo)
        Controls.Add(Label_SignUpTitle)
        Name = "Form6"
        RightToLeftLayout = True
        Text = "Sign up"
        CType(PB_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_SignUpTitle As Label
    Friend WithEvents PB_Logo As PictureBox
    Friend WithEvents TB_FirstName As TextBox
    Friend WithEvents Label_firstName As Label
    Friend WithEvents TB_LastName As TextBox
    Friend WithEvents Label_lastName As Label
    Friend WithEvents TB_PhoneNo As TextBox
    Friend WithEvents Label_PhoneNo As Label
    Friend WithEvents TB_Address As TextBox
    Friend WithEvents Label_Address As Label
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents Label_Password As Label
    Friend WithEvents TB_Username As TextBox
    Friend WithEvents Label_Username As Label
    Friend WithEvents bttn_GoLogIn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label_GoLogin As Label
End Class
