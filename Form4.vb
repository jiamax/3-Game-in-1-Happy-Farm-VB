Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Hide()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Hide()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Hide()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = "期末專案" & Now
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Me.Text = "期末專案" & Now
            Dim f As Integer
            Dim ps As String
            Dim a As Integer = 3
            Do
                ps = InputBox("請輸入密碼:", "密碼", "2018")
                a = a - 1
                If ps = "" Then
                    End
                ElseIf ps = 2018 Then
                    MsgBox("進入系統", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "登入中...")
                    AxWindowsMediaPlayer1.URL = "Resources\YPM.mp3"
                    AxWindowsMediaPlayer1.Visible = False
                    AxWindowsMediaPlayer1.settings.volume = 100
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                Else
                    If a = 0 Then
                        MsgBox("你是駭客嗎?你的密碼輸入錯誤3次  滾!!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "關閉中...")
                        End
                    Else
                        MsgBox("密碼錯誤還剩" & a & "次,請重新輸入", MsgBoxStyle.OkOnly, "錯誤")
                    End If
                End If
            Loop While a > 0 And ps <> 2018
        Catch ex As Exception
        End Try


    End Sub

    Private Sub Form4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
End Class