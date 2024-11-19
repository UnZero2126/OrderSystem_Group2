<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Button2 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(75, 7)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 29)
        Button1.TabIndex = 0
        Button1.Text = "Appetizers"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 491)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1027, 48)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stardew Valley Stonks", 24.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(337, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 43)
        Label1.TabIndex = 2
        Label1.Text = "Ordering System"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(193, 7)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 29)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(1027, 539)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
