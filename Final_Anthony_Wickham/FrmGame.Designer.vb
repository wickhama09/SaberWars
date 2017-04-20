<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGame))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnFight = New System.Windows.Forms.Button()
        Me.picplayer2vssaber = New System.Windows.Forms.PictureBox()
        Me.picplayer1vssaber = New System.Windows.Forms.PictureBox()
        Me.picplayer2vs = New System.Windows.Forms.PictureBox()
        Me.picplayer1vs = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.picVs = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblp2select = New System.Windows.Forms.Label()
        Me.lblp1select = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picSaberRight = New System.Windows.Forms.PictureBox()
        Me.picSaberLeft = New System.Windows.Forms.PictureBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMove = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picplayer2vssaber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picplayer1vssaber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picplayer2vs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picplayer1vs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picVs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaberRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaberLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Controls.Add(Me.picSaberRight)
        Me.Panel1.Controls.Add(Me.picSaberLeft)
        Me.Panel1.Controls.Add(Me.lblStart)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1719, 932)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnFight)
        Me.Panel2.Controls.Add(Me.picplayer2vssaber)
        Me.Panel2.Controls.Add(Me.picplayer1vssaber)
        Me.Panel2.Controls.Add(Me.picplayer2vs)
        Me.Panel2.Controls.Add(Me.picplayer1vs)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.picVs)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.lblp2select)
        Me.Panel2.Controls.Add(Me.lblp1select)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1719, 932)
        Me.Panel2.TabIndex = 26
        Me.Panel2.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.btnStart)
        Me.Panel3.Location = New System.Drawing.Point(177, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1365, 702)
        Me.Panel3.TabIndex = 8
        Me.Panel3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.mid
        Me.PictureBox4.Location = New System.Drawing.Point(557, 213)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(247, 206)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(902, 213)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(394, 206)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.p1
        Me.PictureBox2.Location = New System.Drawing.Point(106, 213)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(362, 206)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.controls
        Me.PictureBox1.Location = New System.Drawing.Point(466, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Black
        Me.btnStart.BackgroundImage = Global.Final_Anthony_Wickham.My.Resources.Resources.start
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStart.Location = New System.Drawing.Point(518, 510)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(324, 116)
        Me.btnStart.TabIndex = 0
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnFight
        '
        Me.btnFight.BackColor = System.Drawing.Color.Black
        Me.btnFight.BackgroundImage = Global.Final_Anthony_Wickham.My.Resources.Resources.confirm1
        Me.btnFight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFight.Location = New System.Drawing.Point(643, 667)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(432, 153)
        Me.btnFight.TabIndex = 7
        Me.btnFight.UseVisualStyleBackColor = False
        '
        'picplayer2vssaber
        '
        Me.picplayer2vssaber.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.emptysaber
        Me.picplayer2vssaber.Location = New System.Drawing.Point(1352, 237)
        Me.picplayer2vssaber.Name = "picplayer2vssaber"
        Me.picplayer2vssaber.Size = New System.Drawing.Size(80, 345)
        Me.picplayer2vssaber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picplayer2vssaber.TabIndex = 6
        Me.picplayer2vssaber.TabStop = False
        '
        'picplayer1vssaber
        '
        Me.picplayer1vssaber.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.emptysaber
        Me.picplayer1vssaber.Location = New System.Drawing.Point(296, 237)
        Me.picplayer1vssaber.Name = "picplayer1vssaber"
        Me.picplayer1vssaber.Size = New System.Drawing.Size(80, 345)
        Me.picplayer1vssaber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picplayer1vssaber.TabIndex = 5
        Me.picplayer1vssaber.TabStop = False
        '
        'picplayer2vs
        '
        Me.picplayer2vs.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.vsvader
        Me.picplayer2vs.Location = New System.Drawing.Point(1081, 65)
        Me.picplayer2vs.Name = "picplayer2vs"
        Me.picplayer2vs.Size = New System.Drawing.Size(608, 166)
        Me.picplayer2vs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picplayer2vs.TabIndex = 3
        Me.picplayer2vs.TabStop = False
        Me.picplayer2vs.Visible = False
        '
        'picplayer1vs
        '
        Me.picplayer1vs.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.vsvader
        Me.picplayer1vs.Location = New System.Drawing.Point(30, 65)
        Me.picplayer1vs.Name = "picplayer1vs"
        Me.picplayer1vs.Size = New System.Drawing.Size(608, 166)
        Me.picplayer1vs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picplayer1vs.TabIndex = 2
        Me.picplayer1vs.TabStop = False
        Me.picplayer1vs.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(1159, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 303)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player 2:"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(66, 225)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(255, 40)
        Me.RadioButton5.TabIndex = 7
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Darth Vader"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(66, 170)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(236, 40)
        Me.RadioButton6.TabIndex = 6
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Mace Windu"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(66, 115)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(312, 40)
        Me.RadioButton7.TabIndex = 5
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Luke Skywalker"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(66, 60)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(312, 40)
        Me.RadioButton8.TabIndex = 4
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Obi-Wan Kenobi"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'picVs
        '
        Me.picVs.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.vslogo2
        Me.picVs.Location = New System.Drawing.Point(743, 398)
        Me.picVs.Name = "picVs"
        Me.picVs.Size = New System.Drawing.Size(233, 136)
        Me.picVs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVs.TabIndex = 1
        Me.picVs.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(108, 584)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 303)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player 1:"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(65, 225)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(255, 40)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Darth Vader"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(65, 170)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(236, 40)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Mace Windu"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(65, 115)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(312, 40)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Luke Skywalker"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(65, 60)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(312, 40)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Obi-Wan Kenobi"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1719, 42)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 38)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'lblp2select
        '
        Me.lblp2select.AutoSize = True
        Me.lblp2select.Font = New System.Drawing.Font("Courier New", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp2select.ForeColor = System.Drawing.Color.White
        Me.lblp2select.Location = New System.Drawing.Point(1149, 95)
        Me.lblp2select.Name = "lblp2select"
        Me.lblp2select.Size = New System.Drawing.Size(473, 60)
        Me.lblp2select.TabIndex = 10
        Me.lblp2select.Text = "Choose A Saber"
        Me.lblp2select.Visible = False
        '
        'lblp1select
        '
        Me.lblp1select.AutoSize = True
        Me.lblp1select.Font = New System.Drawing.Font("Courier New", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp1select.ForeColor = System.Drawing.Color.White
        Me.lblp1select.Location = New System.Drawing.Point(98, 95)
        Me.lblp1select.Name = "lblp1select"
        Me.lblp1select.Size = New System.Drawing.Size(473, 60)
        Me.lblp1select.TabIndex = 9
        Me.lblp1select.Text = "Choose A Saber"
        Me.lblp1select.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(357, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 30)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(697, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 30)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(1245, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 30)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(845, 451)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 30)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(1658, 511)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 30)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1624, 831)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 30)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(1113, 871)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 30)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(513, 871)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 30)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(182, 890)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 30)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1245, 770)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 30)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1317, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 30)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1624, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 30)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(50, 574)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 30)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(772, 649)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 30)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(115, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 30)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(346, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 30)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(447, 682)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 30)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1129, 603)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 30)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(869, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(576, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1092, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(532, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "."
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.saberponglogo
        Me.picLogo.Location = New System.Drawing.Point(724, 391)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(100, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'picSaberRight
        '
        Me.picSaberRight.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.bluesabercut
        Me.picSaberRight.Location = New System.Drawing.Point(1440, 98)
        Me.picSaberRight.Name = "picSaberRight"
        Me.picSaberRight.Size = New System.Drawing.Size(112, 722)
        Me.picSaberRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSaberRight.TabIndex = 3
        Me.picSaberRight.TabStop = False
        Me.picSaberRight.Visible = False
        '
        'picSaberLeft
        '
        Me.picSaberLeft.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.redsabercutedit
        Me.picSaberLeft.Location = New System.Drawing.Point(167, 98)
        Me.picSaberLeft.Name = "picSaberLeft"
        Me.picSaberLeft.Size = New System.Drawing.Size(112, 722)
        Me.picSaberLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSaberLeft.TabIndex = 2
        Me.picSaberLeft.TabStop = False
        Me.picSaberLeft.Visible = False
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStart.Font = New System.Drawing.Font("Courier New", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(527, 760)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(665, 60)
        Me.lblStart.TabIndex = 1
        Me.lblStart.Text = "Press Space to Start"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1200
        '
        'Timer4
        '
        Me.Timer4.Interval = 500
        '
        'Timer5
        '
        Me.Timer5.Interval = 500
        '
        'Timer6
        '
        Me.Timer6.Interval = 10
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(77, 38)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'FrmGame
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1724, 929)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Saber Wars"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picplayer2vssaber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picplayer1vssaber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picplayer2vs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picplayer1vs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picVs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaberRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaberLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStart As Label
    Friend WithEvents picSaberRight As PictureBox
    Friend WithEvents picSaberLeft As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picVs As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents picplayer1vs As PictureBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents picplayer2vs As PictureBox
    Friend WithEvents picplayer1vssaber As PictureBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents picplayer2vssaber As PictureBox
    Friend WithEvents btnFight As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TimerMove As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents lblp1select As Label
    Friend WithEvents lblp2select As Label
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
