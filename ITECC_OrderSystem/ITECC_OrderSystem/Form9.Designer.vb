<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.CurrentPassword = New System.Windows.Forms.TextBox()
        Me.ChangePassword = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(279, 106)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(241, 27)
        Me.Username.TabIndex = 1
        '
        'CurrentPassword
        '
        Me.CurrentPassword.Location = New System.Drawing.Point(280, 160)
        Me.CurrentPassword.Name = "CurrentPassword"
        Me.CurrentPassword.Size = New System.Drawing.Size(241, 27)
        Me.CurrentPassword.TabIndex = 2
        '
        'ChangePassword
        '
        Me.ChangePassword.Location = New System.Drawing.Point(280, 264)
        Me.ChangePassword.Name = "ChangePassword"
        Me.ChangePassword.Size = New System.Drawing.Size(94, 29)
        Me.ChangePassword.TabIndex = 3
        Me.ChangePassword.Text = "Change Password"
        Me.ChangePassword.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(426, 264)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(94, 29)
        Me.Delete.TabIndex = 4
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'NewPassword
        '
        Me.NewPassword.Location = New System.Drawing.Point(280, 212)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.Size = New System.Drawing.Size(241, 27)
        Me.NewPassword.TabIndex = 5
        '
        'Label_username
        '
        Me.Label_username.AutoSize = True
        Me.Label_username.Location = New System.Drawing.Point(163, 109)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(78, 20)
        Me.Label_username.TabIndex = 6
        Me.Label_username.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Current Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "New Password:"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_username)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.ChangePassword)
        Me.Controls.Add(Me.CurrentPassword)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Username As TextBox
    Friend WithEvents CurrentPassword As TextBox
    Friend WithEvents ChangePassword As Button
    Friend WithEvents Delete As Button
    Friend WithEvents NewPassword As TextBox
    Friend WithEvents Label_username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
