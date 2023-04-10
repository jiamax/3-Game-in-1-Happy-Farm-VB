Public Class Form3
    Dim r1 As New Random
    Dim a(10) As Integer
    Dim x, y, z, c, w, s As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        z = 1
        c = 1
        PictureBox3.BackgroundImage = Nothing
        PictureBox4.BackgroundImage = Nothing
        PictureBox5.BackgroundImage = Nothing
        PictureBox8.BackgroundImage = Nothing
        PictureBox9.BackgroundImage = Nothing
        PictureBox10.BackgroundImage = Nothing
        restart()
        checkx()
        checky()
        check()
        PictureBox11.Enabled = True
        Button1.Enabled = True
        Label3.Text = ""
        PictureBox1.Image = ImageList1.Images(52)
        Label1.Text = "莊家"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = "Resources\2121.mp3"
        AxWindowsMediaPlayer1.Visible = False
        AxWindowsMediaPlayer1.settings.volume = 100
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        x = 0
        y = 0
        z = 1
        c = 1
        w = 0
        s = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Nothing
        Timer1.Enabled = True
        Button1.Enabled = False
        PictureBox11.Enabled = False
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        z += 1

        If z = 2 Then

            PictureBox8.BackgroundImage = ImageList1.Images(a(7))
        ElseIf z = 3 Then

            PictureBox9.BackgroundImage = ImageList1.Images(a(8))
        ElseIf z = 4 Then

            PictureBox10.BackgroundImage = ImageList1.Images(a(9))
            If y > 21 Then
                Label3.Text = "你輸了 嫩!!"
            Else
                Label3.Text = "你贏了 !!"
            End If
            PictureBox11.Enabled = False
            Button1.Enabled = False
        End If

        checky()
        If y > 21 Then
            Label3.Text = "你輸了 嫩!!"
            PictureBox11.Enabled = False
            Button1.Enabled = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If y > x Then
            c += 1
            astop()
            checkx()
        Else
            Timer1.Enabled = False
            astop()
            checkx()
            check()
            Label1.Text = "莊家         " & x & "點"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("遊戲說明1.txt")
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Sub restart()
        For i = 0 To 9
            a(i) = r1.Next(51)
        Next
        PictureBox1.BackgroundImage = ImageList1.Images(a(0))
        PictureBox2.BackgroundImage = ImageList1.Images(a(1))
        PictureBox6.BackgroundImage = ImageList1.Images(a(5))
        PictureBox7.BackgroundImage = ImageList1.Images(a(6))
    End Sub
    Sub checkx() '莊家
        x = 0
        For b = 0 To c
            If a(b) Mod 13 > 8 Then
                x = x + 10
            ElseIf (a(b) Mod 13) = 0 Then
                x = x + 11
                s += 1
            Else
                x = x + (a(b) Mod 13) + 1
            End If
            For q = 0 To 4
                If s > 0 Then
                    If (a(q) Mod 13) = 0 And x > 21 Then
                        x = x - 10
                        s -= 1
                    End If
                End If
            Next
        Next
        s = 0
    End Sub
    Sub checky() '玩家
        y = 0
        For i = 0 To z
            If a(i + 5) Mod 13 > 8 Then
                y = y + 10
            ElseIf (a(i + 5) Mod 13) = 0 Then
                y = y + 11
                w += 1
            Else
                y = y + (a(i + 5) Mod 13) + 1
            End If
            Label2.Text = "玩家         " & y & "點"

            For q = 5 To 9
                If w > 0 Then
                    If (a(q) Mod 13) = 0 And y > 21 Then
                        y = y - 10
                        w -= 1
                    End If
                    Label2.Text = "玩家         " & y & "點"
                End If
            Next
        Next
        w = 0
    End Sub
    Sub check() '勝負

        If y > 21 Then
            Label3.Text = "你輸了 嫩!!"
        ElseIf y > x Then
            Label3.Text = "你贏了 !!"
        ElseIf y < x Then
            If x > 21 Then
                Label3.Text = "你贏了!!"
            Else
                Label3.Text = "你輸了 嫩!!"
            End If
        ElseIf y = x Then
            Label3.Text = "平手!!!!"
        ElseIf x = 21 Then
            Label3.Text = "你輸了 嫩!!"
        End If
        PictureBox1.Image = Nothing
        PictureBox11.Enabled = False
        Button1.Enabled = False
    End Sub
    Sub astop()
        If c = 2 Then
            PictureBox3.BackgroundImage = ImageList1.Images(a(2))

        ElseIf c = 3 Then
            PictureBox4.BackgroundImage = ImageList1.Images(a(3))

        ElseIf c = 4 Then
            PictureBox5.BackgroundImage = ImageList1.Images(a(4))
            If x > 21 Then
                Label3.Text = "你贏了 !!"
            Else
                Label3.Text = "你輸了 嫩!!"
            End If
            PictureBox11.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form4.Show()
    End Sub
End Class