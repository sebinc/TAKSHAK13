Public Class Form5


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Form1.TopMost = False

    End Sub
    Private Sub cam2en_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cam2en.Click
        Form1.cam2.Show()
        Form1.btncam1.Enabled = True
        Form1.cam2.Enabled = True
        Form1.cam1.Hide()
        Form1.btncam2.Enabled = False
        Form1.Enabled = False
        Form4.Show()

        Me.Close()
        Me.Dispose()
        
    End Sub

    
End Class