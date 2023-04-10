Public Class Form1
    Sub Start1()
        StartButton1.Visible = True

        StartButton2.Visible = True

        StartButton3.Visible = True

        TimeLabel1.Visible = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.Default
        AxWindowsMediaPlayer1.URL = "Resources\screen1.wav"
        AxWindowsMediaPlayer1.Visible = False
        AxWindowsMediaPlayer2.URL = "Resources\windows.wav"
        AxWindowsMediaPlayer1.Visible = False
        AxWindowsMediaPlayer1.settings.volume = 50
        AxWindowsMediaPlayer2.settings.volume = 50
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        Me.Text = "Happy Farm^_^"
        TimeLabel1.Text = "現在時間為:" & Now()
        Start1()
    End Sub

    Private Sub StartButton1_Click(sender As Object, e As EventArgs) Handles StartButton1.Click
        Try
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer2.Ctlcontrols.play()
            Form2.Show()
            Hide()

        Catch ex As Exception
        End Try



    End Sub

    Private Sub StartButton2_Click(sender As Object, e As EventArgs) Handles StartButton2.Click
        AxWindowsMediaPlayer2.Ctlcontrols.play()
        StartButton1.Visible = False
        StartButton2.Visible = False
        StartButton3.Visible = False
        HScrollBar1.Visible = True
        Label1.Visible = True
        LinkLabel1.Visible = True
        mission.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub StartButton3_Click(sender As Object, e As EventArgs) Handles StartButton3.Click
        AxWindowsMediaPlayer2.Ctlcontrols.play()
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel1.Text = "現在時間為:" & Now()
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartButton1.Visible = True
        StartButton2.Visible = True
        StartButton3.Visible = True
        HScrollBar1.Visible = False
        Label1.Visible = False
        LinkLabel1.Visible = False
        mission.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label1.Text = "音量:" & Math.Round(101 - HScrollBar1.Value)
        AxWindowsMediaPlayer1.settings.volume = Math.Round(101 - HScrollBar1.Value)
        AxWindowsMediaPlayer2.settings.volume = Math.Round(101 - HScrollBar1.Value)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("遊戲說明3.txt")
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
End Class
