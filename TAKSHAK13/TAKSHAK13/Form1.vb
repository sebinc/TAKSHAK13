Imports System.Data
Imports System.Data.OleDb





Public Class Form1
    Public con As New OleDb.OleDbConnection("Provider = Microsoft.Jet.OleDB.4.0;Data Source =13.mdb;")
    Dim t As Short = 0
    Public pass As Boolean = False
    Dim drag As Boolean
    Dim max As Short = takshak.takshak.m
    Dim xx As Short
    Dim yy As Short
    Dim mousex As Integer
    Dim mousey As Integer
    Dim srch As String = ""


    Public Function search(ByVal t As Short)
        If con.State = ConnectionState.Open Then
            con.Close()
        ElseIf con.State = ConnectionState.Closed Then
            con.Open()
            Dim adp As New OleDbDataAdapter("select * from tb1", con)
            Dim ds As New DataSet
            adp.Fill(ds)
            Dim dt As DataTable
            dt = ds.Tables(0)
            desct.Text = dt.Rows(t).Item(1)
            desc.Text = dt.Rows(t).Item(2)                   ' change is require to expand width add column 3 also
            con.Close()
        Else

            desct.Text = "no selection"
            desc.Text = ""

        End If
        Return Nothing

    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cam2.Hide()
        cam1.Show()
        GroupBox3.Hide()
        comb1.Hide()
        RadioButton2.Select()
        Label2.Hide()
        cam1.Left = 14
        cam1.Top = 35
        cam2.Left = 14
        Panelzoom.Hide()
        cam2.Top = 35
        GroupBox5.Hide()
        btncam1.Enabled = False
        Dim i As Short = 0
        Dim str As String = "sebin"
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from tb1", con)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt As DataTable
        For i = 0 To 10
            dt = ds.Tables(0)
            str = dt.Rows(i).Item(1)
            comb1.Items.Add(str)
        Next i
        con.Close()
        Me.cam1.BackgroundImage = takshak.My.Resources.map1
        cam1.BackgroundImageLayout = ImageLayout.Stretch
        Me.cam2.BackgroundImageLayout = ImageLayout.Tile
        zoombox.BackgroundImage = takshak.My.Resources.map1'change ********** require
        zoombox.BackgroundImageLayout = ImageLayout.Stretch
        xx = Me.Left
        yy = Me.Top
        
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            xx = Me.Left
            yy = Me.Top
        End If


    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub maxbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maxbtn.Click
        If Me.WindowState = FormWindowState.Maximized Then

            GroupBox2.Left = 350
            GroupBox4.Left = 350
            Me.WindowState = FormWindowState.Normal
            xx = Me.Left
            yy = Me.Top

        Else
            Me.WindowState = FormWindowState.Maximized
            GroupBox2.Left = 400
            GroupBox4.Left = 400
            xx = 0
            yy = 0
        End If



    End Sub

    Private Sub minbtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minbtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub




    Private Sub aboutbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutbtn.Click
        Form3.Show()

    End Sub



    Private Sub btncam1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncam1.Click
        cam1.Show()
        cam1.Enabled = True
        zoombox.BackgroundImage = takshak.My.Resources.map1'change is require**************** 
        zoombox.BackgroundImageLayout = ImageLayout.Stretch
        cam2.Hide()
        btncam1.Enabled = False
        btncam2.Enabled = True

    End Sub
    Private Sub cam1_Mousedown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam1.MouseDown
        If RadioButton1.Checked = True Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - cam1.Left
            mousey = Windows.Forms.Cursor.Position.Y - cam1.Top
        End If
    End Sub

    Private Sub cam1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cam1.MouseLeave
        Panelzoom.Hide()
    End Sub
    Private Sub cam2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cam2.MouseLeave
        Panelzoom.Hide()
    End Sub






    Private Sub cam1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam1.MouseMove
        If drag = True Then
            cam1.Left = Windows.Forms.Cursor.Position.X - mousex
            cam1.Top = Windows.Forms.Cursor.Position.Y - mousey
        ElseIf RadioButton2.Checked = True And Me.WindowState = FormWindowState.Normal Then
            Panelzoom.Show()
            zoombox.Left = -(((Windows.Forms.Cursor.Position.X - xx - 360) * 2) - 100)
            zoombox.Top = -(((Windows.Forms.Cursor.Position.Y - yy - 200) * 2) - 70)
        ElseIf RadioButton2.Checked = True And Me.WindowState = FormWindowState.Maximized Then
            Panelzoom.Show()
            zoombox.Left = -(((Windows.Forms.Cursor.Position.X - xx - 418) * 2) - 100)
            zoombox.Top = -(((Windows.Forms.Cursor.Position.Y - yy - 200) * 2) - 70)
        End If
    End Sub






    Private Sub cam1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam1.MouseUp
        drag = False
    End Sub
    Private Sub cam2_Mousedown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam2.MouseDown
        If RadioButton1.Checked = True Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - cam2.Left
            mousey = Windows.Forms.Cursor.Position.Y - cam2.Top
        End If
    End Sub







    Private Sub cam2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam2.MouseMove
        If drag = True Then
            cam2.Left = Windows.Forms.Cursor.Position.X - mousex
            cam2.Top = Windows.Forms.Cursor.Position.Y - mousey
        ElseIf RadioButton2.Checked = True And pass = True Then
            Panelzoom.Show()
            zoombox.Left = -(((Windows.Forms.Cursor.Position.X - xx - 360) * 2) - 100)
            zoombox.Top = -(((Windows.Forms.Cursor.Position.Y - yy - 200) * 2) - 70)
        ElseIf RadioButton2.Checked = True And Me.WindowState = FormWindowState.Maximized Then
            Panelzoom.Show()
            zoombox.Left = -(((Windows.Forms.Cursor.Position.X - xx - 418) * 2) - 100)
            zoombox.Top = -(((Windows.Forms.Cursor.Position.Y - yy - 200) * 2) - 70)
        End If

    End Sub






    Private Sub cam2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam2.MouseUp
        drag = False
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox2.Show()
        Panelzoom.Show()
        GroupBox4.Show()
        GroupBox5.Left = 300
        GroupBox5.Hide()
        GroupBox3.Hide()
        comb1.Hide()
        Label2.Hide()
        Panel3.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Form2.IsDisposed = False Then
            Form2.Dispose()
        End If
        Panel3.Hide()
        GroupBox5.Left = 950
        GroupBox5.Show()
        GroupBox5.Enabled = True
        Panelzoom.Hide()
        GroupBox2.Hide()
        
        GroupBox4.Hide()
        GroupBox3.Show()
        comb1.Show()
        comb1.Text = "select keyword"
        Label2.Show()
    End Sub

    Private Sub comb1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles comb1.MouseEnter
        comb1.DroppedDown = True

    End Sub

    Private Sub sercht_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sercht.TextChanged
        srch = sercht.Text
    End Sub

    Private Sub serch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serch.Click
        Dim i As Short = 0
        Dim j As Boolean = False
        Dim str As String = "sebin"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from tb1", con)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt As DataTable
        For i = 0 To max
            dt = ds.Tables(0)
            str = dt.Rows(i).Item(1)
            If str = srch Then
                desc.Text = dt.Rows(i).Item(2)
                desct.Text = str
                j = True
                Exit For
            End If
        Next i
        If j = False Then
            desc.Text = " sorry...." & vbNewLine & "Cant find the key word or place searched...use correct keyword....."
        End If
    End Sub

    Private Sub comb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comb1.SelectedIndexChanged
        t = comb1.SelectedIndex
        search(t)            'fn call
    End Sub

    Private Sub btncam2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncam2.Click
        If pass = False Then
            Form5.Show()
        Else
            zoombox.BackgroundImage = takshak.My.Resources.map2           'cahange is require************************************
            zoombox.BackgroundImageLayout = ImageLayout.Stretch
            cam2.Show()
            cam2.Enabled = True
            cam1.Hide()
            btncam2.Enabled = False
            btncam1.Enabled = True
        End If
    End Sub

   

    Private Sub evtbtn1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles evtbtn1.MouseEnter
        evtbtn1.Size = New Size(150, 40)
        evtbtn1.Top = evtbtn1.Top - 5
    End Sub

    Private Sub evtbtn1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles evtbtn1.MouseLeave
        evtbtn1.Size = New Size(150, 23)
        evtbtn1.Top = evtbtn1.Top + 5
    End Sub
    Private Sub evtbtn2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles evtbtn2.MouseEnter
        evtbtn2.Size = New Size(150, 40)
        evtbtn2.Top = evtbtn2.Top - 5
    End Sub

    Private Sub evtbtn2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles evtbtn2.MouseLeave
        evtbtn2.Size = New Size(150, 23)
        evtbtn2.Top = evtbtn2.Top + 5
    End Sub
    Private Sub evtbtn3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles evtbtn3.MouseEnter
        evtbtn3.Size = New Size(150, 40)
        evtbtn3.Top = evtbtn3.Top - 5
    End Sub

    Private Sub evtbtn3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles evtbtn3.MouseLeave
        evtbtn3.Size = New Size(150, 23)
        evtbtn3.Top = evtbtn3.Top + 5
    End Sub
    Private Sub evtbtn4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles evtbtn4.MouseEnter
        evtbtn4.Size = New Size(150, 40)
        evtbtn4.Top = evtbtn4.Top - 5
    End Sub

    Private Sub evtbtn4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles evtbtn4.MouseLeave
        evtbtn4.Size = New Size(150, 23)
        evtbtn4.Top = evtbtn4.Top + 5
    End Sub

    Private Sub evtbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evtbtn1.Click
        desc.Text = IO.File.ReadAllText("C:\Program Files\TAKSHAK13\chakravyuh\neo\hamradio.dat")
        desct.Text = "Wireless contact"
    End Sub

    Private Sub evtbtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evtbtn2.Click
        desc.Text = IO.File.ReadAllText("C:\Program Files\TAKSHAK13\chakravyuh\neo\laser.dat")
        desct.Text = "Laser challenge"
    End Sub

    Private Sub evtbtn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evtbtn3.Click
        desc.Text = IO.File.ReadAllText("C:\Program Files\TAKSHAK13\chakravyuh\neo\maze.dat")
        desct.Text = "The maze"
    End Sub

    Private Sub evtbtn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evtbtn4.Click
        desc.Text = IO.File.ReadAllText("C:\Program Files\TAKSHAK13\chakravyuh\neo\bomb.dat")
        desct.Text = "time bomb"
    End Sub

  
    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        cam1.Left = 14
        cam1.Top = 35
        cam2.Left = 14
        cam2.Top = 35
    End Sub

    Private Sub readme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles readme.Click
        Form6.Show()
        Me.Hide()
    End Sub

    
End Class
