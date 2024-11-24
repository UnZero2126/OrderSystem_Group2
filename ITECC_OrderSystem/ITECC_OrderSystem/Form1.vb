Public Class Form1
    Private Const CollapsedWidth As Integer = 35
    Private Const ExpandedWidth As Integer = 178
    Private AnimationStep As Integer = 15

    Private Sub CollapseAILogo_Click(sender As Object, e As EventArgs) Handles CollapseAILogo.Click
        TimerPanel_Collapse.Enabled = False
        TimerPanel_Extend.Enabled = False

        If AboutInfo.Width > CollapsedWidth Then
            TimerPanel_Collapse.Enabled = True
        Else
            TimerPanel_Extend.Enabled = True
        End If
    End Sub

    Private Sub TimerPanel_Collapse_Tick(sender As Object, e As EventArgs) Handles TimerPanel_Collapse.Tick
        If AboutInfo.Width > CollapsedWidth Then
            AboutInfo.Width -= AnimationStep
            If AboutInfo.Width < CollapsedWidth Then AboutInfo.Width = CollapsedWidth
        Else
            TimerPanel_Collapse.Enabled = False
        End If
    End Sub

    Private Sub TimerPanel_Extend_Tick(sender As Object, e As EventArgs) Handles TimerPanel_Extend.Tick
        If AboutInfo.Width < ExpandedWidth Then
            AboutInfo.Width += AnimationStep
            If AboutInfo.Width > ExpandedWidth Then AboutInfo.Width = ExpandedWidth
        Else
            TimerPanel_Extend.Enabled = False
        End If
    End Sub
End Class
