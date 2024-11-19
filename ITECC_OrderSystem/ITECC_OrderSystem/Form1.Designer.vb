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
        bttn_appetizers = New Button()
        Panel1 = New Panel()
        bttn_mainCourse = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' bttn_appetizers
        ' 
        bttn_appetizers.Location = New Point(75, 19)
        bttn_appetizers.Name = "bttn_appetizers"
        bttn_appetizers.Size = New Size(112, 29)
        bttn_appetizers.TabIndex = 0
        bttn_appetizers.Text = "Appetizers"
        bttn_appetizers.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(bttn_mainCourse)
        Panel1.Controls.Add(bttn_appetizers)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 463)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1027, 76)
        Panel1.TabIndex = 1
        ' 
        ' bttn_mainCourse
        ' 
        bttn_mainCourse.Location = New Point(193, 19)
        bttn_mainCourse.Name = "bttn_mainCourse"
        bttn_mainCourse.Size = New Size(112, 29)
        bttn_mainCourse.TabIndex = 1
        bttn_mainCourse.Text = "Main Course"
        bttn_mainCourse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stardew Valley Stonks", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(330, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 43)
        Label1.TabIndex = 2
        Label1.Text = "Ordering System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
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

    Friend WithEvents bttn_appetizers As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttn_mainCourse As Button
    Friend WithEvents Label1 As Label
End Class
