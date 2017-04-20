'Program Name:  Saber Wars
'Author:        Anthony Wickham
'Date:          5/5/14
'Purpose:       A Star Wars themed game based on pong.


Option Strict On

Public Class FrmGame
    'Declare variables

    Dim sz As Integer
    Dim no As Integer

    Public player1saber As String
    Public player2saber As String


    Dim entpressed As Boolean
    Dim p1up As Boolean
    Dim p1down As Boolean
    Dim p2up As Boolean
    Dim p2down As Boolean
    Dim selectflash1 As Boolean
    Dim selectflash2 As Boolean

    Dim lblStar(21) As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Specifies what happens when the form loads
        Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Panel2.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Panel2.Height / 2)))
        GamePlay.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Panel2.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Panel2.Height / 2)))
        sz = 0
        no = 0
        createstararray()
        picLogo.Visible = False
        picLogo.Size = New Size(1, 1)
        Timer2.Enabled = False
        lblStart.Visible = False
        TimerMove.Enabled = True
        TimerMove.Start()
        Timer3.Enabled = True
        Timer3.Start()
        selectflash1 = True
        selectflash2 = True


        picSaberLeft.Image = My.Resources.emptysaber
        picSaberRight.Image = My.Resources.emptysaber
        picSaberLeft.Visible = True
        picSaberRight.Visible = True
        picLogo.Image = My.Resources.logo



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Timer 2 animates logo and plays sound for opening splash screen
        If sz < 10 Then
            Timer2.Interval = 3

        ElseIf sz = 130 Then

            Timer2.Stop()

        Else
            Timer2.Interval = 50
        End If
        If sz = 1 Then
            My.Computer.Audio.Play(My.Resources.thememidwav, AudioPlayMode.BackgroundLoop)
        End If



        sz += 1

        picLogo.Size = New Size(sz * 3, sz * 2)
        centerpic()



    End Sub


    Public Sub centerpic()
        'a method for centering the logo during splash screen
        picLogo.Left = CInt(((Panel1.Width - picLogo.Width) / 2))
        picLogo.Top = CInt(((Panel1.Height - picLogo.Height) / 2) - 20)


        ' picLogo.Location = New Point(Panel1.Width / 3, Panel1.Height / 3)
    End Sub

    Private Sub FrmGame_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer 1 animates the label in the splash screen
        If lblStart.Visible = True Then
            lblStart.Visible = False
        ElseIf lblStart.Visible = False Then
            lblStart.BackColor = Color.Transparent
            lblStart.Visible = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'Timer 3 animates the sabers on the splash screen
        no += 1

        If no = 1 Then
            picSaberLeft.Image = My.Resources.redsabercutedit
            My.Computer.Audio.Play(My.Resources.saberon, AudioPlayMode.Background)

        End If
        If no = 2 Then
            picSaberRight.Image = My.Resources.bluesabercut
            My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)

        End If
        If no = 3 Then
            Timer2.Enabled = True
            picLogo.Visible = True
            Timer2.Start()
            Timer3.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub createstararray()
        'stores stars in an array
        lblStar(0) = Label1
        lblStar(1) = Label2
        lblStar(2) = Label3
        lblStar(3) = Label4
        lblStar(4) = Label5
        lblStar(5) = Label6
        lblStar(6) = Label7
        lblStar(7) = Label8
        lblStar(8) = Label9
        lblStar(9) = Label10
        lblStar(10) = Label11
        lblStar(11) = Label12
        lblStar(12) = Label13
        lblStar(13) = Label14
        lblStar(14) = Label15
        lblStar(15) = Label16
        lblStar(16) = Label17
        lblStar(17) = Label18
        lblStar(18) = Label19
        lblStar(19) = Label20
        lblStar(20) = Label21
        For i As Integer = 0 To 20
            lblStar(i).SendToBack()
        Next



    End Sub

    Public Sub FrmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'What happens when keys are pressed
        If e.KeyValue = Keys.Space Then
            Panel2.Visible = True
            Panel3.Visible = False
            Panel1.Visible = True
            Timer4.Enabled = True
            Timer4.Start()
            Timer5.Enabled = True
            Timer5.Start()
            My.Computer.Audio.Stop()
        End If
        If e.KeyValue = Keys.Q Then
            p1up = True
        End If
        If e.KeyValue = Keys.A Then
            p1down = True
        End If
        If e.KeyValue = Keys.Up Then
            p2up = True
        End If
        If e.KeyValue = Keys.Down Then
            p2down = True
        End If

        If e.KeyValue = Keys.Return Then
            entpressed = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'changes player 1 selection to obi wan
        picplayer1vs.Image = My.Resources.vsobiwan
        picplayer1vssaber.Image = My.Resources.bluesabercut
        My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)
        player1saber = "blue"
        picplayer1vs.Visible = True
        selectflash1 = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'changes player 1 selection to luke skywalker
        picplayer1vs.Image = My.Resources.vsluke
        picplayer1vssaber.Image = My.Resources.greensabercutedit
        My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)
        player1saber = "green"
        picplayer1vs.Visible = True
        selectflash1 = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        'changes player 1 selection to mace windu
        picplayer1vs.Image = My.Resources.vswindu
        picplayer1vssaber.Image = My.Resources.purplesabercutedit
        My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)
        player1saber = "purple"
        picplayer1vs.Visible = True
        selectflash1 = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        'changes player 1 to darth vader
        picplayer1vs.Image = My.Resources.vsvader
        picplayer1vssaber.Image = My.Resources.redsabercutedit
        My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)
        player1saber = "red"
        picplayer1vs.Visible = True
        selectflash1 = False
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        'changes player 2 to obi wan
        picplayer2vs.Image = My.Resources.vsobiwan
        picplayer2vssaber.Image = My.Resources.bluesabercut
        My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)
        player2saber = "blue"
        picplayer2vs.Visible = True
        selectflash2 = False

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        'changes player 2 to luke skywalker
        picplayer2vs.Image = My.Resources.vsluke
        picplayer2vssaber.Image = My.Resources.greensabercutedit
        My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)
        player2saber = "green"
        picplayer2vs.Visible = True
        selectflash2 = False
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        'changes player 2 to mace windu
        picplayer2vs.Image = My.Resources.vswindu
        picplayer2vssaber.Image = My.Resources.purplesabercutedit
        My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)
        player2saber = "purple"
        picplayer2vs.Visible = True
        selectflash2 = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        'changes player 2 to darth vader
        picplayer2vs.Image = My.Resources.vsvader
        picplayer2vssaber.Image = My.Resources.redsabercutedit
        My.Computer.Audio.Play(My.Resources.coolsaber, AudioPlayMode.Background)
        player2saber = "red"
        picplayer2vs.Visible = True
        selectflash2 = False
    End Sub

    Private Sub btnFight_Click(sender As Object, e As EventArgs) Handles btnFight.Click
        'shows controls after player selection

        Panel3.Visible = True
        Panel3.Show()

        Timer2.Dispose()





    End Sub

    Public Sub FrmGame_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'what happens when keys are no longer pressed
        If e.KeyValue = Keys.Q Then
            p1up = False
        End If
        If e.KeyValue = Keys.A Then
            p1down = False
        End If
        If e.KeyValue = Keys.P Then
            p2up = False
        End If
        If e.KeyValue = Keys.L Then
            p2down = False
        End If
        If e.KeyValue = Keys.Return Then
            entpressed = False
        End If
    End Sub





    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint


    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'hides all forms and opens the game panel where the game plays, starts necessary timers
        Me.Hide()
        TimerMove.Enabled = True
        TimerMove.Start()
        GamePlay.Refresh()
        GamePlay.player1selection = player1saber
        GamePlay.player2selection = player2saber
        GamePlay.Timer2.Enabled = True
        GamePlay.Timer2.Start()
        GamePlay.Timer1.Enabled = True
        GamePlay.Timer1.Start()
        GamePlay.Show()
        GamePlay.restartgame()


    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'animates player 1 selection label
        If selectflash1 = True Then
            If lblp1select.Visible = True Then
                lblp1select.Visible = False
            ElseIf lblp1select.Visible = False Then
                lblp1select.BackColor = Color.Transparent
                lblp1select.Visible = True
            End If
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        'animates player 2 selection label
        If selectflash2 = True Then
            If lblp2select.Visible = True Then
                lblp2select.Visible = False
            ElseIf lblp2select.Visible = False Then
                lblp2select.BackColor = Color.Transparent
                lblp2select.Visible = True
            End If
        End If
    End Sub

    Private Sub FrmGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Confirms closing on any close of the form

        '


        If MsgBox("Are you sure you want to Exit ?", vbYesNo) = vbNo Then
            e.Cancel = True
        End If
        GamePlay.Close()




    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        'takes player back to player select screen
        Panel3.Hide()
        Panel2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'closes forms
        GamePlay.Close()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'displays program details
        If MessageBox.Show("Program Name: Saber Wars v1.0" & vbCrLf & "Programmed by: Anthony Wickham" & vbCrLf & "Date of Last Revision: 05/05/16", "About Saber Wars",
         MessageBoxButtons.OK, MessageBoxIcon.Information) _
         = DialogResult.OK Then



        End If
    End Sub
End Class
