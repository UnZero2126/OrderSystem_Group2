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
        Me.Label_SignUpTitle = New System.Windows.Forms.Label()
        Me.PB_Logo = New System.Windows.Forms.PictureBox()
        Me.TB_FirstName = New System.Windows.Forms.TextBox()
        Me.Label_firstName = New System.Windows.Forms.Label()
        Me.TB_LastName = New System.Windows.Forms.TextBox()
        Me.Label_lastName = New System.Windows.Forms.Label()
        Me.TB_PhoneNo = New System.Windows.Forms.TextBox()
        Me.Label_PhoneNo = New System.Windows.Forms.Label()
        Me.TB_Address = New System.Windows.Forms.TextBox()
        Me.Label_Address = New System.Windows.Forms.Label()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.Label_Email = New System.Windows.Forms.Label()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.TB_Username = New System.Windows.Forms.TextBox()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.bttn_GoLogIn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label_GoLogin = New System.Windows.Forms.Label()
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_SignUpTitle
        '
        Me.Label_SignUpTitle.AutoSize = True
        Me.Label_SignUpTitle.Font = New System.Drawing.Font("Javanese Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_SignUpTitle.Location = New System.Drawing.Point(303, 19)
        Me.Label_SignUpTitle.Name = "Label_SignUpTitle"
        Me.Label_SignUpTitle.Size = New System.Drawing.Size(225, 52)
        Me.Label_SignUpTitle.TabIndex = 1
        Me.Label_SignUpTitle.Text = "Create an Account"
        '
        'PB_Logo
        '
        Me.PB_Logo.BackgroundImage = Global.ITECC_OrderSystem.My.Resources.Resources.IMG_2774
        Me.PB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_Logo.Location = New System.Drawing.Point(36, 39)
        Me.PB_Logo.Name = "PB_Logo"
        Me.PB_Logo.Size = New System.Drawing.Size(173, 237)
        Me.PB_Logo.TabIndex = 2
        Me.PB_Logo.TabStop = False
        '
        'TB_FirstName
        '
        Me.TB_FirstName.Location = New System.Drawing.Point(372, 87)
        Me.TB_FirstName.Name = "TB_FirstName"
        Me.TB_FirstName.Size = New System.Drawing.Size(230, 27)
        Me.TB_FirstName.TabIndex = 5
        '
        'Label_firstName
        '
        Me.Label_firstName.AutoSize = True
        Me.Label_firstName.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_firstName.Location = New System.Drawing.Point(239, 81)
        Me.Label_firstName.Name = "Label_firstName"
        Me.Label_firstName.Size = New System.Drawing.Size(134, 45)
        Me.Label_firstName.TabIndex = 4
        Me.Label_firstName.Text = "First Name:"
        '
        'TB_LastName
        '
        Me.TB_LastName.Location = New System.Drawing.Point(372, 129)
        Me.TB_LastName.Name = "TB_LastName"
        Me.TB_LastName.Size = New System.Drawing.Size(230, 27)
        Me.TB_LastName.TabIndex = 7
        '
        'Label_lastName
        '
        Me.Label_lastName.AutoSize = True
        Me.Label_lastName.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_lastName.Location = New System.Drawing.Point(239, 123)
        Me.Label_lastName.Name = "Label_lastName"
        Me.Label_lastName.Size = New System.Drawing.Size(129, 45)
        Me.Label_lastName.TabIndex = 6
        Me.Label_lastName.Text = "Last Name:"
        '
        'TB_PhoneNo
        '
        Me.TB_PhoneNo.Location = New System.Drawing.Point(372, 176)
        Me.TB_PhoneNo.Name = "TB_PhoneNo"
        Me.TB_PhoneNo.Size = New System.Drawing.Size(230, 27)
        Me.TB_PhoneNo.TabIndex = 9
        '
        'Label_PhoneNo
        '
        Me.Label_PhoneNo.AutoSize = True
        Me.Label_PhoneNo.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_PhoneNo.Location = New System.Drawing.Point(239, 170)
        Me.Label_PhoneNo.Name = "Label_PhoneNo"
        Me.Label_PhoneNo.Size = New System.Drawing.Size(126, 45)
        Me.Label_PhoneNo.TabIndex = 8
        Me.Label_PhoneNo.Text = "Phone No.:"
        '
        'TB_Address
        '
        Me.TB_Address.Location = New System.Drawing.Point(372, 221)
        Me.TB_Address.Name = "TB_Address"
        Me.TB_Address.Size = New System.Drawing.Size(230, 27)
        Me.TB_Address.TabIndex = 11
        '
        'Label_Address
        '
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_Address.Location = New System.Drawing.Point(239, 215)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(104, 45)
        Me.Label_Address.TabIndex = 10
        Me.Label_Address.Text = "Address:"
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(372, 269)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(230, 27)
        Me.TB_Email.TabIndex = 13
        '
        'Label_Email
        '
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_Email.Location = New System.Drawing.Point(239, 263)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(83, 45)
        Me.Label_Email.TabIndex = 12
        Me.Label_Email.Text = "Email:"
        '
        'TB_Password
        '
        Me.TB_Password.Location = New System.Drawing.Point(372, 360)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.Size = New System.Drawing.Size(230, 27)
        Me.TB_Password.TabIndex = 17
        Me.TB_Password.UseSystemPasswordChar = True
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_Password.Location = New System.Drawing.Point(239, 354)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(116, 45)
        Me.Label_Password.TabIndex = 16
        Me.Label_Password.Text = "Password:"
        '
        'TB_Username
        '
        Me.TB_Username.Location = New System.Drawing.Point(372, 312)
        Me.TB_Username.Name = "TB_Username"
        Me.TB_Username.Size = New System.Drawing.Size(230, 27)
        Me.TB_Username.TabIndex = 15
        '
        'Label_Username
        '
        Me.Label_Username.AutoSize = True
        Me.Label_Username.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_Username.Location = New System.Drawing.Point(239, 306)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(123, 45)
        Me.Label_Username.TabIndex = 14
        Me.Label_Username.Text = "Username:"
        '
        'bttn_GoLogIn
        '
        Me.bttn_GoLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttn_GoLogIn.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttn_GoLogIn.Location = New System.Drawing.Point(36, 306)
        Me.bttn_GoLogIn.Name = "bttn_GoLogIn"
        Me.bttn_GoLogIn.Size = New System.Drawing.Size(173, 37)
        Me.bttn_GoLogIn.TabIndex = 18
        Me.bttn_GoLogIn.Text = "Log In"
        Me.bttn_GoLogIn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(36, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 39)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Create Account"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label_GoLogin
        '
        Me.Label_GoLogin.AutoSize = True
        Me.Label_GoLogin.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_GoLogin.Location = New System.Drawing.Point(24, 281)
        Me.Label_GoLogin.Name = "Label_GoLogin"
        Me.Label_GoLogin.Size = New System.Drawing.Size(201, 34)
        Me.Label_GoLogin.TabIndex = 20
        Me.Label_GoLogin.Text = "Already have an account?"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(646, 422)
        Me.Controls.Add(Me.Label_GoLogin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bttn_GoLogIn)
        Me.Controls.Add(Me.TB_Password)
        Me.Controls.Add(Me.Label_Password)
        Me.Controls.Add(Me.TB_Username)
        Me.Controls.Add(Me.Label_Username)
        Me.Controls.Add(Me.TB_Email)
        Me.Controls.Add(Me.Label_Email)
        Me.Controls.Add(Me.TB_Address)
        Me.Controls.Add(Me.Label_Address)
        Me.Controls.Add(Me.TB_PhoneNo)
        Me.Controls.Add(Me.Label_PhoneNo)
        Me.Controls.Add(Me.TB_LastName)
        Me.Controls.Add(Me.Label_lastName)
        Me.Controls.Add(Me.TB_FirstName)
        Me.Controls.Add(Me.Label_firstName)
        Me.Controls.Add(Me.PB_Logo)
        Me.Controls.Add(Me.Label_SignUpTitle)
        Me.Name = "Form6"
        Me.RightToLeftLayout = True
        Me.Text = "Sign up"
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
