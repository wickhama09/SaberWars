'Program Name:  Saber Wars
'Author:        Anthony Wickham
'Date:          5/5/14
'Purpose:       A Star Wars themed game based on pong.



Option Strict On
Public Class GamePlay
    'Declare variables
    Public player1selection As String
    Public player2selection As String
    Dim matchlength As Integer = 50
    Dim bullet1dir As Integer
    Dim bullet2dir As Integer
    Dim bullet3dir As Integer

    Public cancancel As Boolean
    Dim bullet1on As Boolean
    Dim bullet2on As Boolean
    Dim bullet3on As Boolean
    Dim confsaberon As Boolean

    Dim qpress As Boolean
    Dim apress As Boolean
    Dim upress As Boolean
    Dim dpress As Boolean

    Dim notick As Integer

    Public saberstartpt1 As Point
    Public saberstartpt2 As Point

    Dim player1score As Integer
    Dim player2score As Integer

    Dim strscoretop As String
    Dim strscorebtm As String
    Dim whowon As String

    Dim bullet1canscore As Boolean
    Dim bullet2canscore As Boolean
    Dim bullet3canscore As Boolean

    Dim rn As New Random()

    Private Sub GamePlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'specifies what happens when this form loads
        player1selection = FrmGame.player1saber
        player2selection = FrmGame.player2saber
        If player1selection = "blue" Then
            picSaber1.Image = My.Resources.bluesabercut
        ElseIf player1selection = "green" Then
            picSaber1.Image = My.Resources.greensabercutedit
        ElseIf player1selection = "purple" Then
            picSaber1.Image = My.Resources.purplesabercutedit
        ElseIf player1selection = "red" Then
            picSaber1.Image = My.Resources.redsabercutedit
        End If
        picSaber1.Visible = True
        picCtr.SendToBack()
        Timer2.Enabled = True
        Timer2.Start()
        notick = 0
        picSaberL.SizeMode = PictureBoxSizeMode.StretchImage
        picSaberR.SizeMode = PictureBoxSizeMode.StretchImage

        saberstartpt1 = picSaber1.Location
        saberstartpt2 = picsaber2.Location
        If player2selection = "blue" Then
            picsaber2.Image = My.Resources.bluesabercut
        ElseIf player2selection = "green" Then
            picsaber2.Image = My.Resources.greensabercutedit
        ElseIf player2selection = "purple" Then
            picsaber2.Image = My.Resources.purplesabercutedit
        ElseIf player2selection = "red" Then
            picsaber2.Image = My.Resources.redsabercutedit
        End If
        picsaber2.Visible = True
        player1score = 0
        player2score = 0
        Timer1.Enabled = True
        Timer1.Start()
        bullet1on = True
        bullet1canscore = True
        bullet2on = False
        bullet2canscore = False
        bullet3on = False
        bullet3canscore = False



    End Sub

    Private Sub panelGame_Paint(sender As Object, e As PaintEventArgs) Handles panelGame.Paint


    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub movep1()
        ' moves player 1 saber
        If qpress = True Then
            If picSaber1.Top > 5 Then
                picSaber1.Top = picSaber1.Top - 20
            End If


        ElseIf apress = True Then
            If picSaber1.Top < 300 Then
                picSaber1.Top = picSaber1.Top + 20

            End If
        End If
    End Sub

    Public Sub movep2()
        ' moves player 2 saber
        If upress = True Then
            If picsaber2.Top > 5 Then
                picsaber2.Top = picsaber2.Top - 20
            End If
        ElseIf dpress = True Then
            If picsaber2.Top < 300 Then
                picsaber2.Top = picsaber2.Top + 20
            End If
        End If
    End Sub

    Public Sub movebullet()
        'moves the center bullet
        If bullet1on = False Then
            Dim test As Integer
            test = rn.Next(1, 150)
            If test = 50 Then
                bullet1dir = rn.Next(0, 2)
                picbullet.Location = New Point(CInt(panelGame.Width / 2), CInt(panelGame.Height / 2))
                If bullet1dir = 1 Then
                    picbullet.Left = picbullet.Left - 350
                ElseIf bullet1dir = 0 Then
                    picbullet.Left = picbullet.Left + 350
                End If
                picbullet.Visible = True
                bullet1on = True
                bullet1canscore = True

            End If


        End If
        If bullet1on = True Then


            If bullet1dir = 1 Then
                picbullet.Left = picbullet.Left + 20

            ElseIf bullet1dir = 0 Then
                picbullet.Left = picbullet.Left - 20
            End If
        End If
        If picbullet.Bounds.IntersectsWith(picsaber2.Bounds) Then
            bullet1dir = 0
            My.Computer.Audio.Play(My.Resources.lasrhit2, AudioPlayMode.Background)
        End If
        If picbullet.Bounds.IntersectsWith(picSaber1.Bounds) Then
            bullet1dir = 1
            My.Computer.Audio.Play(My.Resources.lasrhit3, AudioPlayMode.Background)
        End If
        If picbullet.Left > panelGame.Width Then
            bullet1on = False
            If bullet1canscore = True Then
                player1score += 1
                bullet1canscore = False
            End If

        End If
        If picbullet.Left < -100 Then
            bullet1on = False
            If bullet1canscore = True Then
                player2score += 1
                bullet1canscore = False
            End If

        End If
    End Sub

    Public Sub movebullet2()
        'moves the top bullet
        If bullet2on = False Then
            Dim test As Integer
            test = rn.Next(1, 150)
            If test = 1 Then
                bullet2dir = rn.Next(0, 2)
                picBullet2.Location = New Point(CInt(panelGame.Width / 2), CInt(panelGame.Height / 4))
                If bullet2dir = 1 Then
                    picBullet2.Left = picBullet2.Left - 350
                ElseIf bullet2dir = 0 Then
                    picBullet2.Left = picBullet2.Left + 350
                End If

                picBullet2.Visible = True
                bullet2on = True
                bullet2canscore = True

            End If

        End If
        If bullet2on = True Then
            If bullet2dir = 1 Then
                picBullet2.Left = picBullet2.Left + 20

            ElseIf bullet2dir = 0 Then
                picBullet2.Left = picBullet2.Left - 20
            End If
        End If

        If picBullet2.Bounds.IntersectsWith(picsaber2.Bounds) Then
            bullet2dir = 0
            My.Computer.Audio.Play(My.Resources.lasrhit2, AudioPlayMode.Background)
        End If
        If picBullet2.Bounds.IntersectsWith(picSaber1.Bounds) Then
            bullet2dir = 1
            My.Computer.Audio.Play(My.Resources.lasrhit3, AudioPlayMode.Background)
        End If
        If picBullet2.Left > panelGame.Width Then
            bullet2on = False
            If bullet2canscore = True Then
                player1score += 1
                bullet2canscore = False
            End If
        End If
        If picBullet2.Left < -100 Then
            bullet2on = False
            If bullet2canscore = True Then

                player2score += 1
                bullet2canscore = False
            End If
        End If
    End Sub

    Public Sub movebullet3()
        'moves the bottom bullet
        If bullet3on = False Then
            Dim test As Integer
            test = rn.Next(1, 150)
            If test = 99 Then
                bullet3dir = rn.Next(0, 2)
                picbullet3.Location = New Point(CInt((panelGame.Width / 2)), CInt((panelGame.Height / 4) * 3))
                If bullet3dir = 1 Then
                    picbullet3.Left = picbullet3.Left - 350
                ElseIf bullet3dir = 0 Then
                    picbullet3.Left = picbullet3.Left + 350
                End If
                picbullet3.Visible = True
                bullet3on = True
                bullet3canscore = True

            End If
        End If

        If bullet3on = True Then
            If bullet3dir = 1 Then
                picbullet3.Left = picbullet3.Left + 20

            ElseIf bullet3dir = 0 Then
                picbullet3.Left = picbullet3.Left - 20
            End If
        End If
        If picbullet3.Bounds.IntersectsWith(picsaber2.Bounds) Then
            bullet3dir = 0
            My.Computer.Audio.Play(My.Resources.lasrhit2, AudioPlayMode.Background)
        End If
        If picbullet3.Bounds.IntersectsWith(picSaber1.Bounds) Then
            bullet3dir = 1
            My.Computer.Audio.Play(My.Resources.lasrhit3, AudioPlayMode.Background)
        End If
        If picbullet3.Left > panelGame.Width Then
            bullet3on = False
            If bullet3canscore = True Then
                player1score += 1
                bullet3canscore = False

            End If
        End If
        If picbullet3.Left < -100 Then
            bullet3on = False
            If bullet3canscore = True Then
                player2score += 1
                bullet3canscore = False

            End If

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'timer that animates players and bullets
        movep1()
        movep2()
        movebullet()
        movebullet2()
        movebullet3()

    End Sub

    Private Sub GamePlay_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'keypress down event keys
        If e.KeyValue = Keys.Q Then
            qpress = True
        End If
        If e.KeyValue = Keys.A Then
            apress = True
        End If
        If e.KeyValue = Keys.P Then
            upress = True
        End If
        If e.KeyValue = Keys.L Then
            dpress = True
        End If
    End Sub

    Private Sub GamePlay_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'keypress up event keys
        If e.KeyValue = Keys.Q Then
            qpress = False
        End If
        If e.KeyValue = Keys.A Then
            apress = False
        End If
        If e.KeyValue = Keys.P Then
            upress = False
        End If
        If e.KeyValue = Keys.L Then
            dpress = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles picbullet.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'updates score and checks for a win on timer 2 tick
        chkscore()
    End Sub

    Private Sub chkscore()
        'a method for updating the score and checking for a winner
        lblscorep1.Text = CType(player1score, String)
        lblscorep1.Location = New Point(CInt((panelGame.Width / 4) - (lblscorep1.Width / 2)), 10)
        lblscorep2.Text = CType(player2score, String)
        lblscorep2.Location = New Point(CInt(((panelGame.Width / 4) * 3) - (lblscorep1.Width / 2)), 10)
        If player1score >= matchlength Then
            Timer1.Stop()
            Timer2.Stop()
            whowon = "p1"
            lblScoreTop.Text = "P1: " & player1score
            lblScoreWinBtm.Text = "P2: " & player2score
            picPlayerWins.Image = My.Resources.p1wins
            panelResults.Show()

            Timer3.Start()

        ElseIf player2score >= matchlength Then
            Timer1.Stop()
            Timer2.Stop()
            whowon = "p2"
            lblScoreTop.Text = "P1: " & player1score
            lblScoreWinBtm.Text = "P2: " & player2score
            picPlayerWins.Image = My.Resources.p2wins
            panelResults.Show()

            Timer3.Start()

        End If
    End Sub

    Private Sub btnEndGame_Click(sender As Object, e As EventArgs) Handles btnEndGame.Click
        'ends the game prematurely
        Timer1.Stop()
        Timer2.Stop()
        lblScoreTop.Text = "P1: " & player1score
        lblScoreWinBtm.Text = "P2: " & player2score
        If player1score > player2score Then
            picPlayerWins.Image = My.Resources.p1wins
            whowon = "p1"
        ElseIf player2score > player1score Then
            picPlayerWins.Image = My.Resources.p2wins
            whowon = "p2"
        ElseIf player2score = player1score Then
            picPlayerWins.Image = My.Resources.tie
            whowon = "tie"
        End If
        panelResults.Show()

        Timer3.Start()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'animates the panel at the end of the game, sets saber images in relation to the winner
        notick += 1
        If lblPlayAgain.Visible = True Then
            lblPlayAgain.Visible = False
        ElseIf lblPlayAgain.Visible = False Then
            lblPlayAgain.BackColor = Color.Transparent
            lblPlayAgain.Visible = True
        End If
        If notick = 2 Then
            If whowon = "p1" Then
                If player1selection = "blue" Then
                    picSaberL.Image = My.Resources.bluesabercut
                ElseIf player1selection = "green" Then
                    picSaberL.Image = My.Resources.greensabercutedit
                ElseIf player1selection = "purple" Then
                    picSaberL.Image = My.Resources.purplesabercutedit
                ElseIf player1selection = "red" Then
                    picSaberL.Image = My.Resources.redsabercutedit
                End If
                If player1selection = "blue" Then
                    picSaberR.Image = My.Resources.bluesabercut
                ElseIf player1selection = "green" Then
                    picSaberR.Image = My.Resources.greensabercutedit
                ElseIf player1selection = "purple" Then
                    picSaberR.Image = My.Resources.purplesabercutedit
                ElseIf player1selection = "red" Then
                    picSaberR.Image = My.Resources.redsabercutedit
                End If
            ElseIf whowon = "p2" Then
                If player2selection = "blue" Then
                    picSaberL.Image = My.Resources.bluesabercut
                ElseIf player2selection = "green" Then
                    picSaberL.Image = My.Resources.greensabercutedit
                ElseIf player2selection = "purple" Then
                    picSaberL.Image = My.Resources.purplesabercutedit
                ElseIf player2selection = "red" Then
                    picSaberL.Image = My.Resources.redsabercutedit
                End If
                If player2selection = "blue" Then
                    picSaberR.Image = My.Resources.bluesabercut
                ElseIf player2selection = "green" Then
                    picSaberR.Image = My.Resources.greensabercutedit
                ElseIf player2selection = "purple" Then
                    picSaberR.Image = My.Resources.purplesabercutedit
                ElseIf player2selection = "red" Then
                    picSaberR.Image = My.Resources.redsabercutedit
                End If
            ElseIf whowon = "tie" Then
                If player1selection = "blue" Then
                    picSaberL.Image = My.Resources.bluesabercut
                ElseIf player1selection = "green" Then
                    picSaberL.Image = My.Resources.greensabercutedit
                ElseIf player1selection = "purple" Then
                    picSaberL.Image = My.Resources.purplesabercutedit
                ElseIf player1selection = "red" Then
                    picSaberL.Image = My.Resources.redsabercutedit
                End If
                If player2selection = "blue" Then
                    picSaberR.Image = My.Resources.bluesabercut
                ElseIf player2selection = "green" Then
                    picSaberR.Image = My.Resources.greensabercutedit
                ElseIf player2selection = "purple" Then
                    picSaberR.Image = My.Resources.purplesabercutedit
                ElseIf player2selection = "red" Then
                    picSaberR.Image = My.Resources.redsabercutedit
                End If

            End If
            My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)







        End If
        If notick = 6 Then
            My.Computer.Audio.Play(My.Resources.imperialwavtrimmed, AudioPlayMode.Background)
        End If



    End Sub



    Public Sub restartgame()
        'a method to re initialize values to where they should be on a game restart

        panelResults.Hide()
        player1score = 0
        player2score = 0
        Timer3.Enabled = False

        FrmGame.Panel3.Hide()
        FrmGame.Panel2.Visible = True
        player1selection = FrmGame.player1saber
        player2selection = FrmGame.player2saber
        If player1selection = "blue" Then
            picSaber1.Image = My.Resources.bluesabercut
        ElseIf player1selection = "green" Then
            picSaber1.Image = My.Resources.greensabercutedit
        ElseIf player1selection = "purple" Then
            picSaber1.Image = My.Resources.purplesabercutedit
        ElseIf player1selection = "red" Then
            picSaber1.Image = My.Resources.redsabercutedit
        End If
        picSaber1.Visible = True
        picCtr.SendToBack()
        Timer2.Enabled = True
        Timer2.Start()
        notick = 0
        picSaberL.SizeMode = PictureBoxSizeMode.StretchImage
        picSaberR.SizeMode = PictureBoxSizeMode.StretchImage

        If player2selection = "blue" Then
            picsaber2.Image = My.Resources.bluesabercut
        ElseIf player2selection = "green" Then
            picsaber2.Image = My.Resources.greensabercutedit
        ElseIf player2selection = "purple" Then
            picsaber2.Image = My.Resources.purplesabercutedit
        ElseIf player2selection = "red" Then
            picsaber2.Image = My.Resources.redsabercutedit
        End If
        picsaber2.Visible = True
        player1score = 0
        player2score = 0
        Timer1.Enabled = True
        Timer1.Start()

        bullet1on = True
        bullet1canscore = True
        bullet2on = False
        bullet2canscore = False
        bullet3on = False
        bullet3canscore = False
        picSaberL.Image = My.Resources.emptysaber
        picSaberR.Image = My.Resources.emptysaber
        picBullet2.Visible = False
        picbullet3.Visible = False
        picbullet3.Location = New Point(CInt((panelGame.Width / 2)), CInt((panelGame.Height / 4) * 3))
        picBullet2.Location = New Point(CInt((panelGame.Width / 2)), CInt((panelGame.Height / 4)))
        picSaber1.Location = saberstartpt1
        picsaber2.Location = saberstartpt2

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        'closes forms

        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        'returns to player selection screen
        My.Computer.Audio.Stop()
        Me.Hide()
        FrmGame.Show()

    End Sub

    Private Sub GamePlay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Confirms closing on any close of the form







        If MsgBox("Are you sure you want to Exit ?", vbYesNo) = vbNo Then
            e.Cancel = True
        End If




    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays program details

        If MessageBox.Show("Program Name: Saber Wars v1.0" & vbCrLf & "Programmed by: Anthony Wickham" & vbCrLf & "Date of Last Revision: 05/05/16", "About Saber Wars",
         MessageBoxButtons.OK, MessageBoxIcon.Information) _
         = DialogResult.OK Then



        End If
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        'sends player back to player selection panel
        My.Computer.Audio.Stop()
        Me.Hide()
        FrmGame.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub GamePlay_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FrmGame.Dispose()
    End Sub
End Class