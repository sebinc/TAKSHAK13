Public Class Form3

   
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If pc1.Top = -171 Then
            pc1.Top = pc1.Height
        ElseIf pc1.Top = -172 Then
            pc1.Top = pc1.Height
        ElseIf pc1.Top = -173 Then
            pc1.Top = pc1.Height
        ElseIf pc1.Top = -174 Then
            pc1.Top = pc1.Height
        Else
            pc1.Top -= 4
        End If
    End Sub
End Class
