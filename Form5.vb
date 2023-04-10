Public Class Form5
    Dim z As Integer = 0
    Dim a(2) As Integer
    Dim d As New Random
    Dim b As Integer = 100
    Dim p As Integer = 0
    Dim r As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = "Resources\GM.mp3"
        AxWindowsMediaPlayer1.Visible = False
        AxWindowsMediaPlayer2.Visible = False
        AxWindowsMediaPlayer1.settings.volume = 50
        AxWindowsMediaPlayer2.settings.volume = 100
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        PictureBox3.BackgroundImage = ImageList1.Images(0)
        PictureBox4.BackgroundImage = ImageList1.Images(0)
        PictureBox5.BackgroundImage = ImageList1.Images(0)
        Label1.Text = "目前金額 :" & b & "元"
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        b = b - 10
        AxWindowsMediaPlayer2.URL = "Resources\5454.mp3"
        AxWindowsMediaPlayer2.Ctlcontrols.play()
        Label1.Text = "目前金額 :" & b & "元"
        Timer1.Enabled = True
        Timer2.Enabled = True
        Button1.Enabled = False
        asd()
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        If p >= 1 Then
        Else
            PictureBox3.BackgroundImage = ImageList1.Images(z)
        End If
        If p >= 2 Then
        Else
            PictureBox4.BackgroundImage = ImageList1.Images(z)
        End If
        If p >= 3 Then
        Else
            PictureBox5.BackgroundImage = ImageList1.Images(z)
        End If

        If z < 4 Then
            z += 1
        Else
            z = 0
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False

        Dim i, x, y As Integer
        y = 5
        For i = 0 To 2
            x = d.Next(y)
            a(i) = x
        Next
        Timer3.Enabled = True
    End Sub
    Sub asd()
        PictureBox6.Visible = False
        PictureBox7.Visible = True
        If Timer2.Enabled = False And Timer1.Enabled = False Then
            PictureBox6.Visible = True
            PictureBox7.Visible = False
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Form4.Show()
    End Sub
    Sub chk()
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        If a(0) = 0 And a(1) = 0 And a(2) = 0 Then
            b += 50
            Label1.Text = "幸運777+50元"
        ElseIf a(0) = 0 And a(1) = 0 Or a(1) = 0 And a(2) = 0 Or a(0) = 0 And a(2) = 0 Then
            b += 20
        ElseIf a(0) = 1 And a(1) = 1 And a(2) = 1 Then
            b += 15
        ElseIf a(0) = 1 And a(1) = 1 Or a(1) = 1 And a(2) = 1 Or a(0) = 1 And a(2) = 1 Then
            b += 5
        ElseIf a(0) = 2 And a(1) = 2 And a(2) = 2 Then
            b += 15
        ElseIf a(0) = 2 And a(1) = 2 Or a(1) = 2 And a(2) = 2 Or a(0) = 2 And a(2) = 2 Then
            b += 5
        ElseIf a(0) = 4 And a(1) = 4 And a(2) = 4 Then
            b += 15
        ElseIf a(0) = 4 And a(1) = 4 Or a(1) = 4 And a(2) = 4 Or a(0) = 4 And a(2) = 4 Then
            b += 5
        ElseIf a(0) = 3 And a(1) = 3 And a(2) = 3 Then
            b -= 100
        ElseIf a(0) = 3 And a(1) = 3 Or a(1) = 3 And a(2) = 3 Or a(0) = 3 And a(2) = 3 Then
            b -= 30
        End If
        Label1.Text = "目前金額 :" & b & "元"
        If b <= 5 Then
            Label1.Text = " 金額不足 ~ "
            PictureBox6.Enabled = False
            Button2.Enabled = True
        End If
        If b <= 0 Then
            Label1.Text = " 阿拉花瓜 !"
            PictureBox6.Enabled = False
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox6.Enabled = True
        Button2.Enabled = False
        b = 100
        Label1.Text = "目前金額 :" & b & "元"
        PictureBox3.BackgroundImage = ImageList1.Images(0)
        PictureBox4.BackgroundImage = ImageList1.Images(0)
        PictureBox5.BackgroundImage = ImageList1.Images(0)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        p += 1
        If p = 1 Then
            PictureBox3.BackgroundImage = ImageList1.Images(a(0))
        ElseIf p = 2 Then
            PictureBox4.BackgroundImage = ImageList1.Images(a(1))
        ElseIf p = 3 Then
            PictureBox5.BackgroundImage = ImageList1.Images(a(2))
            chk()
            Button1.Enabled = True
            Timer3.Enabled = False
            Timer1.Enabled = False
            p = 0
        End If
        asd()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("遊戲說明2.txt")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form5_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form4.Show()
    End Sub
End Class