<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GamePlay
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
        Me.panelGame = New System.Windows.Forms.Panel()
        Me.panelResults = New System.Windows.Forms.Panel()
        Me.picSaberR = New System.Windows.Forms.PictureBox()
        Me.picSaberL = New System.Windows.Forms.PictureBox()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.lblPlayAgain = New System.Windows.Forms.Label()
        Me.lblScoreWinBtm = New System.Windows.Forms.Label()
        Me.picPlayerWins = New System.Windows.Forms.PictureBox()
        Me.lblScoreTop = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEndGame = New System.Windows.Forms.Button()
        Me.lblscorep2 = New System.Windows.Forms.Label()
        Me.lblscorep1 = New System.Windows.Forms.Label()
        Me.picbullet3 = New System.Windows.Forms.Label()
        Me.picBullet2 = New System.Windows.Forms.Label()
        Me.picbullet = New System.Windows.Forms.Label()
        Me.picCtr = New System.Windows.Forms.PictureBox()
        Me.picsaber2 = New System.Windows.Forms.PictureBox()
        Me.picSaber1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.panelGame.SuspendLayout()
        Me.panelResults.SuspendLayout()
        CType(Me.picSaberR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaberL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerWins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picCtr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsaber2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaber1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelGame
        '
        Me.panelGame.Controls.Add(Me.panelResults)
        Me.panelGame.Controls.Add(Me.btnEndGame)
        Me.panelGame.Controls.Add(Me.lblscorep2)
        Me.panelGame.Controls.Add(Me.lblscorep1)
        Me.panelGame.Controls.Add(Me.picbullet3)
        Me.panelGame.Controls.Add(Me.picBullet2)
        Me.panelGame.Controls.Add(Me.picbullet)
        Me.panelGame.Controls.Add(Me.picCtr)
        Me.panelGame.Controls.Add(Me.picsaber2)
        Me.panelGame.Controls.Add(Me.picSaber1)
        Me.panelGame.Location = New System.Drawing.Point(0, 0)
        Me.panelGame.Name = "panelGame"
        Me.panelGame.Size = New System.Drawing.Size(1750, 939)
        Me.panelGame.TabIndex = 6
        '
        'panelResults
        '
        Me.panelResults.Controls.Add(Me.picSaberR)
        Me.panelResults.Controls.Add(Me.picSaberL)
        Me.panelResults.Controls.Add(Me.btnNo)
        Me.panelResults.Controls.Add(Me.btnYes)
        Me.panelResults.Controls.Add(Me.lblPlayAgain)
        Me.panelResults.Controls.Add(Me.lblScoreWinBtm)
        Me.panelResults.Controls.Add(Me.picPlayerWins)
        Me.panelResults.Controls.Add(Me.lblScoreTop)
        Me.panelResults.Controls.Add(Me.MenuStrip1)
        Me.panelResults.Location = New System.Drawing.Point(0, 0)
        Me.panelResults.Name = "panelResults"
        Me.panelResults.Size = New System.Drawing.Size(1750, 939)
        Me.panelResults.TabIndex = 15
        Me.panelResults.Visible = False
        '
        'picSaberR
        '
        Me.picSaberR.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.emptysaber
        Me.picSaberR.Location = New System.Drawing.Point(1472, 120)
        Me.picSaberR.Name = "picSaberR"
        Me.picSaberR.Size = New System.Drawing.Size(87, 639)
        Me.picSaberR.TabIndex = 8
        Me.picSaberR.TabStop = False
        '
        'picSaberL
        '
        Me.picSaberL.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.emptysaber
        Me.picSaberL.Location = New System.Drawing.Point(189, 120)
        Me.picSaberL.Name = "picSaberL"
        Me.picSaberL.Size = New System.Drawing.Size(87, 639)
        Me.picSaberL.TabIndex = 7
        Me.picSaberL.TabStop = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.Black
        Me.btnNo.BackgroundImage = Global.Final_Anthony_Wickham.My.Resources.Resources.no
        Me.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNo.Location = New System.Drawing.Point(993, 748)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(223, 104)
        Me.btnNo.TabIndex = 6
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.Black
        Me.btnYes.BackgroundImage = Global.Final_Anthony_Wickham.My.Resources.Resources.yes
        Me.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnYes.Location = New System.Drawing.Point(534, 748)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(223, 104)
        Me.btnYes.TabIndex = 5
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'lblPlayAgain
        '
        Me.lblPlayAgain.AutoSize = True
        Me.lblPlayAgain.Font = New System.Drawing.Font("Courier New", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayAgain.ForeColor = System.Drawing.Color.White
        Me.lblPlayAgain.Location = New System.Drawing.Point(687, 643)
        Me.lblPlayAgain.Name = "lblPlayAgain"
        Me.lblPlayAgain.Size = New System.Drawing.Size(377, 60)
        Me.lblPlayAgain.TabIndex = 4
        Me.lblPlayAgain.Text = "Play Again?"
        '
        'lblScoreWinBtm
        '
        Me.lblScoreWinBtm.AutoSize = True
        Me.lblScoreWinBtm.Font = New System.Drawing.Font("Courier New", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreWinBtm.ForeColor = System.Drawing.Color.White
        Me.lblScoreWinBtm.Location = New System.Drawing.Point(767, 491)
        Me.lblScoreWinBtm.Name = "lblScoreWinBtm"
        Me.lblScoreWinBtm.Size = New System.Drawing.Size(217, 60)
        Me.lblScoreWinBtm.TabIndex = 3
        Me.lblScoreWinBtm.Text = "P2: XX"
        '
        'picPlayerWins
        '
        Me.picPlayerWins.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.p1wins
        Me.picPlayerWins.Location = New System.Drawing.Point(534, 101)
        Me.picPlayerWins.Name = "picPlayerWins"
        Me.picPlayerWins.Size = New System.Drawing.Size(682, 229)
        Me.picPlayerWins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayerWins.TabIndex = 2
        Me.picPlayerWins.TabStop = False
        '
        'lblScoreTop
        '
        Me.lblScoreTop.AutoSize = True
        Me.lblScoreTop.Font = New System.Drawing.Font("Courier New", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreTop.ForeColor = System.Drawing.Color.White
        Me.lblScoreTop.Location = New System.Drawing.Point(767, 412)
        Me.lblScoreTop.Name = "lblScoreTop"
        Me.lblScoreTop.Size = New System.Drawing.Size(217, 60)
        Me.lblScoreTop.TabIndex = 1
        Me.lblScoreTop.Text = "P1: XX"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1750, 42)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 38)
        Me.FileToolStripMenuItem.Text = "File"
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
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'btnEndGame
        '
        Me.btnEndGame.BackColor = System.Drawing.Color.Black
        Me.btnEndGame.BackgroundImage = Global.Final_Anthony_Wickham.My.Resources.Resources.ender
        Me.btnEndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEndGame.Location = New System.Drawing.Point(801, 17)
        Me.btnEndGame.Name = "btnEndGame"
        Me.btnEndGame.Size = New System.Drawing.Size(148, 51)
        Me.btnEndGame.TabIndex = 14
        Me.btnEndGame.UseVisualStyleBackColor = False
        '
        'lblscorep2
        '
        Me.lblscorep2.AutoSize = True
        Me.lblscorep2.Font = New System.Drawing.Font("Consolas", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscorep2.ForeColor = System.Drawing.Color.White
        Me.lblscorep2.Location = New System.Drawing.Point(1413, 10)
        Me.lblscorep2.Name = "lblscorep2"
        Me.lblscorep2.Size = New System.Drawing.Size(118, 51)
        Me.lblscorep2.TabIndex = 13
        Me.lblscorep2.Text = "P1: "
        Me.lblscorep2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblscorep1
        '
        Me.lblscorep1.AutoSize = True
        Me.lblscorep1.Font = New System.Drawing.Font("Consolas", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscorep1.ForeColor = System.Drawing.Color.White
        Me.lblscorep1.Location = New System.Drawing.Point(180, 10)
        Me.lblscorep1.Name = "lblscorep1"
        Me.lblscorep1.Size = New System.Drawing.Size(118, 51)
        Me.lblscorep1.TabIndex = 12
        Me.lblscorep1.Text = "P1: "
        Me.lblscorep1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picbullet3
        '
        Me.picbullet3.BackColor = System.Drawing.Color.Red
        Me.picbullet3.Location = New System.Drawing.Point(821, 667)
        Me.picbullet3.Name = "picbullet3"
        Me.picbullet3.Size = New System.Drawing.Size(100, 5)
        Me.picbullet3.TabIndex = 11
        Me.picbullet3.Visible = False
        '
        'picBullet2
        '
        Me.picBullet2.BackColor = System.Drawing.Color.Red
        Me.picBullet2.Location = New System.Drawing.Point(821, 200)
        Me.picBullet2.Name = "picBullet2"
        Me.picBullet2.Size = New System.Drawing.Size(100, 5)
        Me.picBullet2.TabIndex = 10
        Me.picBullet2.Visible = False
        '
        'picbullet
        '
        Me.picbullet.BackColor = System.Drawing.Color.Red
        Me.picbullet.Location = New System.Drawing.Point(821, 467)
        Me.picbullet.Name = "picbullet"
        Me.picbullet.Size = New System.Drawing.Size(100, 5)
        Me.picbullet.TabIndex = 9
        '
        'picCtr
        '
        Me.picCtr.Image = Global.Final_Anthony_Wickham.My.Resources.Resources.trooperblack
        Me.picCtr.Location = New System.Drawing.Point(505, 145)
        Me.picCtr.Name = "picCtr"
        Me.picCtr.Size = New System.Drawing.Size(740, 649)
        Me.picCtr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCtr.TabIndex = 8
        Me.picCtr.TabStop = False
        '
        'picsaber2
        '
        Me.picsaber2.Location = New System.Drawing.Point(1675, 297)
        Me.picsaber2.Name = "picsaber2"
        Me.picsaber2.Size = New System.Drawing.Size(80, 345)
        Me.picsaber2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsaber2.TabIndex = 7
        Me.picsaber2.TabStop = False
        '
        'picSaber1
        '
        Me.picSaber1.Location = New System.Drawing.Point(-5, 297)
        Me.picSaber1.Name = "picSaber1"
        Me.picSaber1.Size = New System.Drawing.Size(80, 345)
        Me.picSaber1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSaber1.TabIndex = 6
        Me.picSaber1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'GamePlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1724, 929)
        Me.Controls.Add(Me.panelGame)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GamePlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.panelGame.ResumeLayout(False)
        Me.panelGame.PerformLayout()
        Me.panelResults.ResumeLayout(False)
        Me.panelResults.PerformLayout()
        CType(Me.picSaberR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaberL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerWins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picCtr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsaber2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaber1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelGame As Panel
    Friend WithEvents picbullet As Label
    Friend WithEvents picCtr As PictureBox
    Friend WithEvents picsaber2 As PictureBox
    Friend WithEvents picSaber1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picbullet3 As Label
    Friend WithEvents picBullet2 As Label
    Friend WithEvents lblscorep1 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblscorep2 As Label
    Friend WithEvents btnEndGame As Button
    Friend WithEvents panelResults As Panel
    Friend WithEvents lblScoreTop As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picPlayerWins As PictureBox
    Friend WithEvents lblScoreWinBtm As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents lblPlayAgain As Label
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents picSaberR As PictureBox
    Friend WithEvents picSaberL As PictureBox
End Class
