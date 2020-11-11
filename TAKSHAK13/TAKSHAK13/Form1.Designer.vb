<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.maxbtn = New System.Windows.Forms.Button()
        Me.minbtn = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.readme = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panelzoom = New System.Windows.Forms.Panel()
        Me.zoombox = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.evtlbl = New System.Windows.Forms.Label()
        Me.evtbtn4 = New System.Windows.Forms.Button()
        Me.evtbtn3 = New System.Windows.Forms.Button()
        Me.evtbtn2 = New System.Windows.Forms.Button()
        Me.evtbtn1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comb1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.serch = New System.Windows.Forms.Button()
        Me.desct = New System.Windows.Forms.Label()
        Me.sercht = New System.Windows.Forms.TextBox()
        Me.desc = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btncam1 = New System.Windows.Forms.Button()
        Me.btncam2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.aboutbtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cam1 = New System.Windows.Forms.PictureBox()
        Me.cam2 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panelzoom.SuspendLayout()
        CType(Me.zoombox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cam1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cam2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(14, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'closebtn
        '
        Me.closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebtn.ForeColor = System.Drawing.Color.Transparent
        Me.closebtn.Location = New System.Drawing.Point(1166, 3)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(28, 26)
        Me.closebtn.TabIndex = 0
        Me.closebtn.Text = "X"
        Me.ToolTip1.SetToolTip(Me.closebtn, "close")
        Me.closebtn.UseVisualStyleBackColor = False
        '
        'maxbtn
        '
        Me.maxbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxbtn.BackColor = System.Drawing.Color.SteelBlue
        Me.maxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maxbtn.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.maxbtn.Location = New System.Drawing.Point(1135, 3)
        Me.maxbtn.Name = "maxbtn"
        Me.maxbtn.Size = New System.Drawing.Size(28, 26)
        Me.maxbtn.TabIndex = 0
        Me.maxbtn.Text = "[]"
        Me.ToolTip1.SetToolTip(Me.maxbtn, "maximize/normal")
        Me.maxbtn.UseVisualStyleBackColor = False
        '
        'minbtn
        '
        Me.minbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minbtn.BackColor = System.Drawing.Color.SteelBlue
        Me.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minbtn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.minbtn.Location = New System.Drawing.Point(1104, 3)
        Me.minbtn.Name = "minbtn"
        Me.minbtn.Size = New System.Drawing.Size(28, 26)
        Me.minbtn.TabIndex = 0
        Me.minbtn.Text = "-"
        Me.ToolTip1.SetToolTip(Me.minbtn, "minimize")
        Me.minbtn.UseVisualStyleBackColor = False
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.title.Font = New System.Drawing.Font("Dyuthi", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(255, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.title.Location = New System.Drawing.Point(50, 3)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(117, 24)
        Me.title.TabIndex = 1
        Me.title.Text = "CHAKRAVYUH"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.readme)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panelzoom)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.comb1)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Splitter1)
        Me.Panel2.Controls.Add(Me.aboutbtn)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(3, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1193, 629)
        Me.Panel2.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Panel2, "Find a place")
        '
        'readme
        '
        Me.readme.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.readme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.readme.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.readme.Location = New System.Drawing.Point(725, 7)
        Me.readme.Name = "readme"
        Me.readme.Size = New System.Drawing.Size(110, 35)
        Me.readme.TabIndex = 16
        Me.readme.Text = "Read Me"
        Me.ToolTip1.SetToolTip(Me.readme, "read me first")
        Me.readme.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Location = New System.Drawing.Point(32, 436)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(159, 138)
        Me.Panel3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MAP  Settings"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(19, 93)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Enable Map Zoom"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(19, 64)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(108, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Enable Map Drag"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panelzoom
        '
        Me.Panelzoom.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panelzoom.Controls.Add(Me.zoombox)
        Me.Panelzoom.Location = New System.Drawing.Point(32, 156)
        Me.Panelzoom.Name = "Panelzoom"
        Me.Panelzoom.Size = New System.Drawing.Size(277, 256)
        Me.Panelzoom.TabIndex = 15
        '
        'zoombox
        '
        Me.zoombox.Location = New System.Drawing.Point(-14, -145)
        Me.zoombox.Name = "zoombox"
        Me.zoombox.Size = New System.Drawing.Size(1604, 910)
        Me.zoombox.TabIndex = 4
        Me.zoombox.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox5.Controls.Add(Me.evtlbl)
        Me.GroupBox5.Controls.Add(Me.evtbtn4)
        Me.GroupBox5.Controls.Add(Me.evtbtn3)
        Me.GroupBox5.Controls.Add(Me.evtbtn2)
        Me.GroupBox5.Controls.Add(Me.evtbtn1)
        Me.GroupBox5.Location = New System.Drawing.Point(206, 174)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 400)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'evtlbl
        '
        Me.evtlbl.AutoSize = True
        Me.evtlbl.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evtlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.evtlbl.Location = New System.Drawing.Point(39, 32)
        Me.evtlbl.Name = "evtlbl"
        Me.evtlbl.Size = New System.Drawing.Size(60, 21)
        Me.evtlbl.TabIndex = 4
        Me.evtlbl.Text = "Hints"
        '
        'evtbtn4
        '
        Me.evtbtn4.BackgroundImage = Global.TAKSHAK13.My.Resources.Resources.button2
        Me.evtbtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.evtbtn4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.evtbtn4.Location = New System.Drawing.Point(22, 173)
        Me.evtbtn4.Name = "evtbtn4"
        Me.evtbtn4.Size = New System.Drawing.Size(150, 23)
        Me.evtbtn4.TabIndex = 3
        Me.evtbtn4.Text = "Time bomb"
        Me.evtbtn4.UseVisualStyleBackColor = True
        '
        'evtbtn3
        '
        Me.evtbtn3.BackgroundImage = Global.TAKSHAK13.My.Resources.Resources.button2
        Me.evtbtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.evtbtn3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.evtbtn3.Location = New System.Drawing.Point(22, 138)
        Me.evtbtn3.Name = "evtbtn3"
        Me.evtbtn3.Size = New System.Drawing.Size(150, 23)
        Me.evtbtn3.TabIndex = 2
        Me.evtbtn3.Text = "The Maze"
        Me.evtbtn3.UseVisualStyleBackColor = True
        '
        'evtbtn2
        '
        Me.evtbtn2.BackgroundImage = Global.TAKSHAK13.My.Resources.Resources.button2
        Me.evtbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.evtbtn2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.evtbtn2.Location = New System.Drawing.Point(22, 104)
        Me.evtbtn2.Name = "evtbtn2"
        Me.evtbtn2.Size = New System.Drawing.Size(150, 23)
        Me.evtbtn2.TabIndex = 1
        Me.evtbtn2.Text = "laser challege"
        Me.evtbtn2.UseVisualStyleBackColor = True
        '
        'evtbtn1
        '
        Me.evtbtn1.BackgroundImage = Global.TAKSHAK13.My.Resources.Resources.button2
        Me.evtbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.evtbtn1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.evtbtn1.Location = New System.Drawing.Point(22, 73)
        Me.evtbtn1.Name = "evtbtn1"
        Me.evtbtn1.Size = New System.Drawing.Size(150, 23)
        Me.evtbtn1.TabIndex = 0
        Me.evtbtn1.Text = "find out ham radio"
        Me.evtbtn1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(178, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "select keyword"
        '
        'comb1
        '
        Me.comb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.comb1.ForeColor = System.Drawing.SystemColors.Window
        Me.comb1.FormattingEnabled = True
        Me.comb1.Location = New System.Drawing.Point(51, 14)
        Me.comb1.Name = "comb1"
        Me.comb1.Size = New System.Drawing.Size(121, 21)
        Me.comb1.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.serch)
        Me.GroupBox3.Controls.Add(Me.desct)
        Me.GroupBox3.Controls.Add(Me.sercht)
        Me.GroupBox3.Controls.Add(Me.desc)
        Me.GroupBox3.Location = New System.Drawing.Point(274, 174)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(458, 376)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(94, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "key word search eg. g6"
        '
        'serch
        '
        Me.serch.BackColor = System.Drawing.Color.Silver
        Me.serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.serch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.serch.Location = New System.Drawing.Point(240, 12)
        Me.serch.Name = "serch"
        Me.serch.Size = New System.Drawing.Size(75, 23)
        Me.serch.TabIndex = 5
        Me.serch.Text = "SEARCH"
        Me.ToolTip1.SetToolTip(Me.serch, "Search")
        Me.serch.UseVisualStyleBackColor = False
        '
        'desct
        '
        Me.desct.AutoSize = True
        Me.desct.BackColor = System.Drawing.Color.DarkGray
        Me.desct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.desct.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desct.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.desct.Location = New System.Drawing.Point(38, 62)
        Me.desct.Name = "desct"
        Me.desct.Size = New System.Drawing.Size(27, 20)
        Me.desct.TabIndex = 10
        Me.desct.Text = "title"
        '
        'sercht
        '
        Me.sercht.BackColor = System.Drawing.SystemColors.MenuBar
        Me.sercht.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sercht.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.sercht.Location = New System.Drawing.Point(65, 12)
        Me.sercht.Name = "sercht"
        Me.sercht.Size = New System.Drawing.Size(154, 24)
        Me.sercht.TabIndex = 4
        Me.sercht.Text = "search keyword"
        '
        'desc
        '
        Me.desc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.desc.BackColor = System.Drawing.Color.DarkSlateGray
        Me.desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.desc.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.desc.Location = New System.Drawing.Point(23, 97)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(413, 260)
        Me.desc.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button3.Location = New System.Drawing.Point(302, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 34)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Find keyword"
        Me.ToolTip1.SetToolTip(Me.Button3, "use this section for finding the hints")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.Controls.Add(Me.btncam1)
        Me.GroupBox4.Controls.Add(Me.btncam2)
        Me.GroupBox4.Location = New System.Drawing.Point(341, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(820, 71)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'btncam1
        '
        Me.btncam1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncam1.BackgroundImage = CType(resources.GetObject("btncam1.BackgroundImage"), System.Drawing.Image)
        Me.btncam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncam1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncam1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncam1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncam1.Location = New System.Drawing.Point(261, 16)
        Me.btncam1.Name = "btncam1"
        Me.btncam1.Size = New System.Drawing.Size(107, 36)
        Me.btncam1.TabIndex = 5
        Me.btncam1.Text = "Map1"
        Me.ToolTip1.SetToolTip(Me.btncam1, "enables camera1 map")
        Me.btncam1.UseVisualStyleBackColor = True
        '
        'btncam2
        '
        Me.btncam2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncam2.BackgroundImage = CType(resources.GetObject("btncam2.BackgroundImage"), System.Drawing.Image)
        Me.btncam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncam2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncam2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncam2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncam2.Location = New System.Drawing.Point(384, 16)
        Me.btncam2.Name = "btncam2"
        Me.btncam2.Size = New System.Drawing.Size(110, 36)
        Me.btncam2.TabIndex = 6
        Me.btncam2.Text = "Map2"
        Me.ToolTip1.SetToolTip(Me.btncam2, "enables camera2 map")
        Me.btncam2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button2.Location = New System.Drawing.Point(456, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 34)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Show MAP"
        Me.ToolTip1.SetToolTip(Me.Button2, "Show map of the maze")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 629)
        Me.Splitter1.TabIndex = 7
        Me.Splitter1.TabStop = False
        '
        'aboutbtn
        '
        Me.aboutbtn.BackColor = System.Drawing.Color.Transparent
        Me.aboutbtn.BackgroundImage = CType(resources.GetObject("aboutbtn.BackgroundImage"), System.Drawing.Image)
        Me.aboutbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.aboutbtn.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutbtn.ForeColor = System.Drawing.Color.Gold
        Me.aboutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aboutbtn.Location = New System.Drawing.Point(1030, 6)
        Me.aboutbtn.Name = "aboutbtn"
        Me.aboutbtn.Size = New System.Drawing.Size(57, 36)
        Me.aboutbtn.TabIndex = 2
        Me.aboutbtn.Text = "About"
        Me.ToolTip1.SetToolTip(Me.aboutbtn, "about app")
        Me.aboutbtn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.cam1)
        Me.GroupBox2.Controls.Add(Me.cam2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(341, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(820, 509)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'cam1
        '
        Me.cam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cam1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.cam1.Location = New System.Drawing.Point(14, 30)
        Me.cam1.Name = "cam1"
        Me.cam1.Size = New System.Drawing.Size(800, 455)
        Me.cam1.TabIndex = 0
        Me.cam1.TabStop = False
        '
        'cam2
        '
        Me.cam2.BackgroundImage = CType(resources.GetObject("cam2.BackgroundImage"), System.Drawing.Image)
        Me.cam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cam2.Location = New System.Drawing.Point(14, 30)
        Me.cam2.Name = "cam2"
        Me.cam2.Size = New System.Drawing.Size(800, 460)
        Me.cam2.TabIndex = 3
        Me.cam2.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 300
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1188, 49)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 660)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.minbtn)
        Me.Controls.Add(Me.maxbtn)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1300, 750)
        Me.Name = "Form1"
        Me.Text = "Chakravyuh"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panelzoom.ResumeLayout(False)
        CType(Me.zoombox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.cam1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cam2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents closebtn As System.Windows.Forms.Button
    Friend WithEvents maxbtn As System.Windows.Forms.Button
    Friend WithEvents minbtn As System.Windows.Forms.Button
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cam1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents aboutbtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cam2 As System.Windows.Forms.PictureBox
    Friend WithEvents btncam2 As System.Windows.Forms.Button
    Friend WithEvents btncam1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents desct As System.Windows.Forms.Label
    Friend WithEvents desc As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents comb1 As System.Windows.Forms.ComboBox
    Friend WithEvents serch As System.Windows.Forms.Button
    Friend WithEvents sercht As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents evtlbl As System.Windows.Forms.Label
    Friend WithEvents evtbtn3 As System.Windows.Forms.Button
    Friend WithEvents evtbtn2 As System.Windows.Forms.Button
    Friend WithEvents evtbtn1 As System.Windows.Forms.Button
    Friend WithEvents zoombox As System.Windows.Forms.PictureBox
    Friend WithEvents Panelzoom As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents readme As System.Windows.Forms.Button
    Friend WithEvents evtbtn4 As System.Windows.Forms.Button

End Class
