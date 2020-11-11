Public Class Form4
    Dim pwd As String = ""
    Dim npwd As String
    Dim zz As Short = 1

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True

        Form1.TopMost = False

        Select Case zz
            Case 1 : pwd = "pass"
            Case 2 : pwd = "littleboy"
            Case 3 : pwd = "flipcart"
            Case 4 : pwd = "webspider"
            Case 5 : pwd = "walter"
            Case 6 : pwd = "disney"
            Case 7 : pwd = "pinkpanther"
            Case 8 : pwd = "control"
            Case 9 : pwd = "laptop"
            Case 10 : pwd = "fatman"
            Case 11 : pwd = "shred"
            Case 12 : pwd = "mark"
            Case 13 : pwd = "macios"
            Case 14 : pwd = "usbbus"
            Case 15 : pwd = "jammer"
            Case 16 : pwd = "mosquito"
            Case 17 : pwd = "master"
            Case 18 : pwd = "mswindows"
            Case 19 : pwd = "algorithm"
            Case 20 : pwd = "cryptography"




        End Select

    End Sub
    
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        npwd = TextBox1.Text
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If pwd = npwd Then
            
            Form1.Show()
            Form1.TopMost = True
            Form1.Enabled = True
            Form1.cam2.BackgroundImage = takshak.My.Resources.map2
            Form1.cam2.BackgroundImageLayout = ImageLayout.Stretch
            Form1.zoombox.BackgroundImage = takshak.My.Resources.map2
            Form1.zoombox.BackgroundImageLayout = ImageLayout.Stretch
            MessageBox.Show("Password accepted", "admin ", MessageBoxButtons.OK)
            Form1.pass = True
    
        Me.Close()
        Me.Dispose()
        Else
        MessageBox.Show("PASSWORD can't be identyfied.", "ERROR", MessageBoxButtons.OK)

        End If
    End Sub
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Form1.Enabled = True
        Form1.TopMost = True

        Me.Close()
        Me.Dispose()

    End Sub
    
End Class

