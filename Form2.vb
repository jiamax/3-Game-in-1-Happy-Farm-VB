Public Class Form2
    Dim money1 As Integer = 1000
    Dim level1 As Integer = 1
    Dim mousestate1 As Integer = 1
    Dim time As Integer = 1
    Dim exp1(10) As Integer
    Dim plantPorgress(10) As ProgressBar
    Dim applepl(10), cabbage1(10), tomato1(10), watermelon1(10), strawberry1(10), pumpkin1(10), carrot1(10), wheat1(10), radish1(10), marrow1(10), misson1(5), missontitle(5) As Integer
    Dim buttonfinish(10) As Integer
    Dim applepn, cabbagen, tomaton, watermelonn, strawberryn, pumpkinn, carrotn, wheatn, radishn, marrown, x, water(5) As Integer
    Dim rndNum As New Random()
    Dim rndNum2 As New Random()
    Dim rndNum3 As New Random()
    Dim rndNum4 As New Random()
    Dim rndNum5 As New Random()


    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form4.Show()
    End Sub

    Sub startmissions()
        missontitle(1) = 1
        misson1(1) = rndNum.Next(1, 4)
        CheckBox1.Text = "蘋果" & misson1(1) & "個"
    End Sub
    Sub missionslevel()
        If CheckBox1.Checked = True Then
            CheckBox1.Checked = False
            x = 1
                For e = 1 To 9
                If level.Text = e Then
                    missontitle(1) = rndNum.Next(1, e)
                End If
            Next

            checkmissons()
        End If

        If CheckBox2.Checked = True And CheckBox2.Enabled = True Then
            CheckBox2.Checked = False
            x = 2
            For e = 1 To 9
                If level.Text = e Then
                    missontitle(2) = rndNum2.Next(1, e)
                End If
            Next

            checkmissons()
        End If

        If CheckBox3.Checked = True And CheckBox3.Enabled = True Then
            CheckBox3.Checked = False
            For i = 3 To 3
                x = i
                For e = 1 To 9
                    If level.Text = e Then
                        missontitle(i) = rndNum3.Next(1, e)
                    End If
                Next
            Next
            checkmissons()
        End If
        If CheckBox4.Checked = True And CheckBox4.Enabled = True Then
            CheckBox4.Checked = False

            x = 4
            For e = 1 To 9
                If level.Text = e Then
                    missontitle(4) = rndNum4.Next(1, e)
                End If
            Next
            checkmissons()
        End If
        If CheckBox5.Checked = True And CheckBox5.Enabled = True Then
            CheckBox5.Checked = False

            x = 5
            For e = 1 To 9
                If level.Text = e Then
                    missontitle(5) = rndNum5.Next(1, e)
                End If
            Next

            checkmissons()
        End If
    End Sub

    Sub checkmissons()
        If x = 1 Then
            For i = x To x
                misson1(i) = rndNum5.Next(1, 4)
                If missontitle(i) = 1 Then

                    CheckBox1.Text = "蘋果" & misson1(i) & "個"
                End If

                If missontitle(i) = 2 Then

                    CheckBox1.Text = "高麗菜" & misson1(i) & "個"
                End If

                If missontitle(i) = 3 Then

                    CheckBox1.Text = "番茄" & misson1(i) & "個"
                End If

                If missontitle(i) = 4 Then

                    CheckBox1.Text = "西瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 5 Then

                    CheckBox1.Text = "草莓" & misson1(i) & "個"
                End If

                If missontitle(i) = 6 Then

                    CheckBox1.Text = "南瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 7 Then

                    CheckBox1.Text = "胡蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 8 Then

                    CheckBox1.Text = "小麥" & misson1(i) & "個"
                End If

                If missontitle(i) = 9 Then

                    CheckBox1.Text = "紅皮蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 10 Then

                    CheckBox1.Text = "翠玉瓜" & misson1(i) & "個"
                End If
            Next

        End If

        If x = 2 Then
            For i = x To x
                misson1(i) = rndNum4.Next(1, 4)
                If missontitle(i) = 1 Then

                    CheckBox2.Text = "蘋果" & misson1(i) & "個"
                End If

                If missontitle(i) = 2 Then

                    CheckBox2.Text = "高麗菜" & misson1(i) & "個"
                End If

                If missontitle(i) = 3 Then

                    CheckBox2.Text = "番茄" & misson1(i) & "個"
                End If

                If missontitle(i) = 4 Then

                    CheckBox2.Text = "西瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 5 Then

                    CheckBox2.Text = "草莓" & misson1(i) & "個"
                End If

                If missontitle(i) = 6 Then

                    CheckBox2.Text = "南瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 7 Then

                    CheckBox2.Text = "胡蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 8 Then

                    CheckBox2.Text = "小麥" & misson1(i) & "個"
                End If

                If missontitle(i) = 9 Then

                    CheckBox2.Text = "紅皮蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 10 Then

                    CheckBox2.Text = "翠玉瓜" & misson1(i) & "個"
                End If
            Next
        End If



        If x = 3 Then
            For i = x To x
                misson1(i) = rndNum3.Next(1, 4)
                If missontitle(i) = 1 Then

                    CheckBox3.Text = "蘋果" & misson1(i) & "個"
                End If

                If missontitle(i) = 2 Then

                    CheckBox3.Text = "高麗菜" & misson1(i) & "個"
                End If

                If missontitle(i) = 3 Then

                    CheckBox3.Text = "番茄" & misson1(i) & "個"
                End If

                If missontitle(i) = 4 Then

                    CheckBox3.Text = "西瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 5 Then

                    CheckBox3.Text = "草莓" & misson1(i) & "個"
                End If

                If missontitle(i) = 6 Then

                    CheckBox3.Text = "南瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 7 Then

                    CheckBox3.Text = "胡蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 8 Then

                    CheckBox3.Text = "小麥" & misson1(i) & "個"
                End If

                If missontitle(i) = 9 Then

                    CheckBox3.Text = "紅皮蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 10 Then

                    CheckBox3.Text = "翠玉瓜" & misson1(i) & "個"
                End If
            Next
        End If


        If x = 4 Then
            For i = x To x
                misson1(i) = rndNum2.Next(1, 4)
                If missontitle(i) = 1 Then

                    CheckBox4.Text = "蘋果" & misson1(i) & "個"
                End If

                If missontitle(i) = 2 Then

                    CheckBox4.Text = "高麗菜" & misson1(i) & "個"
                End If

                If missontitle(i) = 3 Then

                    CheckBox4.Text = "番茄" & misson1(i) & "個"
                End If

                If missontitle(i) = 4 Then

                    CheckBox4.Text = "西瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 5 Then

                    CheckBox4.Text = "草莓" & misson1(i) & "個"
                End If

                If missontitle(i) = 6 Then

                    CheckBox4.Text = "南瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 7 Then

                    CheckBox4.Text = "胡蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 8 Then

                    CheckBox4.Text = "小麥" & misson1(i) & "個"
                End If

                If missontitle(i) = 9 Then

                    CheckBox4.Text = "紅皮蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 10 Then

                    CheckBox4.Text = "翠玉瓜" & misson1(i) & "個"
                End If
            Next
        End If


        If x = 5 Then
            For i = x To x
                misson1(i) = rndNum5.Next(1, 4)
                If missontitle(i) = 1 Then

                    CheckBox5.Text = "蘋果" & misson1(i) & "個"
                End If

                If missontitle(i) = 2 Then

                    CheckBox5.Text = "高麗菜" & misson1(i) & "個"
                End If

                If missontitle(i) = 3 Then

                    CheckBox5.Text = "番茄" & misson1(i) & "個"
                End If

                If missontitle(i) = 4 Then

                    CheckBox5.Text = "西瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 5 Then

                    CheckBox5.Text = "草莓" & misson1(i) & "個"
                End If

                If missontitle(i) = 6 Then

                    CheckBox5.Text = "南瓜" & misson1(i) & "個"
                End If

                If missontitle(i) = 7 Then

                    CheckBox5.Text = "胡蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 8 Then

                    CheckBox5.Text = "小麥" & misson1(i) & "個"
                End If

                If missontitle(i) = 9 Then

                    CheckBox5.Text = "紅皮蘿蔔" & misson1(i) & "個"
                End If

                If missontitle(i) = 10 Then

                    CheckBox5.Text = "翠玉瓜" & misson1(i) & "個"
                End If
            Next
        End If





    End Sub
    Public Sub restart()
        applepn = 0
        cabbagen = 0
        tomaton = 0
        watermelonn = 0
        strawberryn = 0
        pumpkinn = 0
        carrotn = 0
        wheatn = 0
        radishn = 0
        marrown = 0
        applepn1.Text = applepn
        cabbagen1.Text = cabbagen
        tomaton1.Text = tomaton
        watermelonn1.Text = watermelonn
        strawberryn1.Text = strawberryn
        pumpkinn1.Text = pumpkinn
        carrotn1.Text = carrotn
        wheatn1.Text = wheatn
        radishn1.Text = radishn
        marrown1.Text = marrown
        level.Text = level1
        Money.Text = money1

        For i = 1 To 10
            applepl(i) = 0
            cabbage1(i) = 0
            tomato1(i) = 0
            watermelon1(i) = 0
            strawberry1(i) = 0
            buttonfinish(i) = 0
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startmissions()
        Button1.BackgroundImage = ImageList1.Images(0)
        Button2.BackgroundImage = ImageList1.Images(0)
        Button3.BackgroundImage = ImageList1.Images(0)
        Button7.BackgroundImage = ImageList1.Images(0)
        button20.BackgroundImage = ImageList1.Images(0)
        ProgressBar1.Maximum = 100
        Me.Text = "Happy Farm^_^"
        AxWindowsMediaPlayer1.URL = "Resources\Bengal.wav"
        AxWindowsMediaPlayer1.Visible = False
        restart()

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (BACK1.Visible = False) Then
            mousestate1 = 4
            Try
                Me.Cursor = New Cursor("ico\water.ico")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (BACK1.Visible = False) Then
            mousestate1 = 5
            Try

                Me.Cursor = New Cursor("ico\chop2.ico")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (BACK1.Visible = False) Then
            mousestate1 = 2
            Try

                Me.Cursor = New Cursor("ico\manure.ico")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        If (BACK1.Visible = False) Then
            mousestate1 = 3
            Try

                Me.Cursor = New Cursor("ico\poison.ico")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (BACK1.Visible = False) Then
            mousestate1 = 1
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = ProgressBar1.Value + 50
        checklevel()


    End Sub
    Private Sub checklevel()
        If level.Text = 1 And (ProgressBar1.Value > 95) Then
            ProgressBar1.Value = 0
            level.Text = level.Text + 1
            ProgressBar1.Maximum = 200
            Button11.Visible = True
            Panel2.Visible = True
        End If
        If level.Text = 2 And (ProgressBar1.Value > 150) Then
            ProgressBar1.Value = 0
            level.Text = level.Text + 1
            ProgressBar1.Maximum = 300
            Button12.Visible = True
            Panel3.Visible = True
            CheckBox2.Enabled = True
            CheckBox2.Visible = True
            missionslevel()
        End If
        If level.Text = 3 And (ProgressBar1.Value > 250) Then
            ProgressBar1.Value = 0
            level.Text = level.Text + 1
            ProgressBar1.Maximum = 400
            Button13.Visible = True
            Panel4.Visible = True
            CheckBox3.Enabled = True
            CheckBox3.Visible = True
            missionslevel()
        End If
        If level.Text = 4 And (ProgressBar1.Value > 350) Then
            ProgressBar1.Value = 0
            level.Text = level.Text + 1
            ProgressBar1.Maximum = 500
            Button14.Visible = True
            Panel5.Visible = True
            CheckBox4.Enabled = True
            CheckBox4.Visible = True
            missionslevel()
        End If
        If level.Text = 5 And (ProgressBar1.Value > 450) Then
            ProgressBar1.Value = 0
            level.Text = level.Text + 1
            ProgressBar1.Maximum = 600
            Button15.Visible = True
            Panel6.Visible = True
            CheckBox5.Enabled = True
            CheckBox5.Visible = True
            missionslevel()
        End If
        If level.Text = 6 And (ProgressBar1.Value > 550) Then
            ProgressBar1.Value = 0
            level.Text = level.Text + 1
            ProgressBar1.Maximum = 700
            Button16.Visible = True
            Panel7.Visible = True
        End If
        If level.Text = 7 And (ProgressBar1.Value > 650) Then
            ProgressBar1.Value = 0
            level.Text = level.Text + 1
            ProgressBar1.Maximum = 900
            Button17.Visible = True
            Panel8.Visible = True
        End If
        If level.Text = 8 And (ProgressBar1.Value > 750) Then
            ProgressBar1.Value = 0
            ProgressBar1.Maximum = 999999
            level.Text = level.Text + 1
            Button18.Visible = True
            Panel9.Visible = True
            Panel10.Visible = True
        End If
        If level.Text = 9 And (ProgressBar1.Value > 999999) Then
            ProgressBar1.Value = 0
            ProgressBar1.Maximum = 999999

            End
        End If

    End Sub
    Private Sub Shop_Click(sender As Object, e As EventArgs) Handles Shop.Click
        If ((mousestate1 = 1) And BACK1.Visible = False) Then
            SHOP1.Visible = True
            BACK1.Visible = True
            restart1()
        End If

    End Sub

    Sub restart1()

        For i = 0 To 10
            If buttonfinish(i) = 2 Then

            Else
                pumpkin1(i) = 0
                carrot1(i) = 0
                wheat1(i) = 0
                radish1(i) = 0
                marrow1(i) = 0
                applepl(i) = 0
                cabbage1(i) = 0
                tomato1(i) = 0
                watermelon1(i) = 0
                strawberry1(i) = 0

            End If

        Next
    End Sub


    Private Sub apple_Click(sender As Object, e As EventArgs) Handles apple.Click
        If level.Text > 0 Then

            SHOP1.Visible = False
            For i = 1 To 10
                If applepl(i) = 2 Then
                    applepl(i) = 2
                Else


                    applepl(i) = 1
                End If
            Next

            Try
                Me.Cursor = New Cursor("ico\apple_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()
        End If

    End Sub
    Private Sub FlatStyleChange1()
        Button3.FlatStyle = FlatStyle.Popup
        Button3.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Popup
        Button1.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Popup
        Button2.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Popup
        Button7.FlatAppearance.BorderSize = 0
        button20.FlatStyle = FlatStyle.Popup
        button20.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub FlatStyleChange2()
        Button3.FlatStyle = FlatStyle.Flat
        Button3.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.FlatAppearance.BorderSize = 0
        button20.FlatStyle = FlatStyle.Flat
        button20.FlatAppearance.BorderSize = 0

    End Sub
    Private Sub lepchange()
        For i = 1 To 10

            If (buttonfinish(i) = 1) Then

                If (applepl(i) = 2) Then
                    applepl(i) = 1
                End If

                If (cabbage1(i) = 2) Then
                    cabbage1(i) = 1
                End If

                If (tomato1(i) = 2) Then
                    tomato1(i) = 1
                End If

                If (watermelon1(i) = 2) Then
                    watermelon1(i) = 1
                End If

                If (strawberry1(i) = 2) Then
                    strawberry1(i) = 1
                End If

                If (pumpkin1(i) = 2) Then
                    pumpkin1(i) = 1
                End If
                If (carrot1(i) = 2) Then
                    carrot1(i) = 1
                End If

                If wheat1(i) = 2 Then
                    wheat1(i) = 1
                End If
                If radish1(i) = 2 Then

                    radish1(i) = 1
                End If
                If marrow1(i) = 2 Then
                    marrow1(i) = 1
                End If


            End If
        Next

    End Sub
    Private Sub uepchange()
        For i = 1 To 10

            If buttonfinish(i) = 0 Or buttonfinish(i) = 1 Then
                If (applepl(i) = 1 Or cabbage1(i) = 1 Or tomato1(i) = 1 Or watermelon1(i) = 1 Or strawberry1(i) = 1 Or pumpkin1(i) = 1 Or carrot1(i) = 1 Or wheat1(i) = 1 Or radish1(i) = 1 Or marrow1(i) = 1) Then
                    pumpkin1(i) = 0
                    wheat1(i) = 0
                    carrot1(i) = 0
                    applepl(i) = 0
                    cabbage1(i) = 0
                    tomato1(i) = 0
                    watermelon1(i) = 0
                    strawberry1(i) = 0
                    radish1(i) = 0
                    marrow1(i) = 0
                End If
            End If


        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Timer1.Interval = 100 Then
            If mousestate1 = 2 Then
                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    Timer1.Interval = 10
                    Money.Text = Money.Text - 50
                End If
            End If
        End If
        If mousestate1 = 4 Then
            water(0) = 1
        End If
        If water(0) = 1 Then
            Try
                Me.Controls.Add(plantPorgress(1))
                plantPorgress(1).BringToFront()
                Timer1.Enabled = True
                water(0) = 0
            Catch ex As Exception

            End Try

        End If
        If (buttonfinish(3) = 0 And BACK1.Visible = True) Then
            If (applepl(3) = 1) Then
                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled

                Else
                    buttonfinish(3) = 2
                    exp1(3) = 1
                    Money.Text = Money.Text - 50
                    applepl(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(1)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 100
                    End With

                End If
            End If

            If (cabbage1(3) = 1) Then
                If (Money.Text - 100 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 2
                    Money.Text = Money.Text - 100
                    cabbage1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(4)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 120
                    End With
                End If
            End If

            If (tomato1(3) = 1) Then
                If (Money.Text - 150 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 3
                    Money.Text = Money.Text - 150
                    tomato1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(7)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (watermelon1(3) = 1) Then
                If (Money.Text - 200 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 4
                    Money.Text = Money.Text - 200
                    watermelon1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(13)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (strawberry1(3) = 1) Then
                If (Money.Text - 250 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 5
                    Money.Text = Money.Text - 250
                    strawberry1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(10)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 180
                    End With

                End If
            End If

            If (pumpkin1(3) = 1) Then
                If (Money.Text - 300 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 6
                    Money.Text = Money.Text - 300
                    pumpkin1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(16)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (carrot1(3) = 1) Then
                If (Money.Text - 450 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 7
                    Money.Text = Money.Text - 450
                    carrot1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(19)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (wheat1(3) = 1) Then
                If (Money.Text - 500 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 8
                    Money.Text = Money.Text - 500
                    wheat1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(22)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (radish1(3) = 1) Then
                If (Money.Text - 550 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 9
                    Money.Text = Money.Text - 550
                    radish1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(27)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (marrow1(3) = 1) Then
                If (Money.Text - 600 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(3) = 2
                    exp1(3) = 10
                    Money.Text = Money.Text - 600
                    marrow1(3) = 2
                    Button3.BackgroundImage = ImageList1.Images(31)
                    plantPorgress(1) = New ProgressBar
                    With plantPorgress(1)
                        .Top = Button3.Top - 15
                        .Left = Button3.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 250
                    End With

                End If
            End If

        End If


        If (buttonfinish(3) = 1 And mousestate1 = 5) Then
            Timer1.Interval = 100

            If (exp1(3) = 1) Then
                ProgressBar1.Value = ProgressBar1.Value + 5
                buttonfinih3(3)
                applepn1.Text = applepn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(3) = 2) Then
                ProgressBar1.Value = ProgressBar1.Value + 10
                buttonfinih3(3)
                cabbagen1.Text = cabbagen1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(3) = 3) Then
                ProgressBar1.Value = ProgressBar1.Value + 15
                buttonfinih3(3)
                tomaton1.Text = tomaton1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(3) = 4) Then
                ProgressBar1.Value = ProgressBar1.Value + 20
                buttonfinih3(3)
                watermelonn1.Text = watermelonn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(3) = 5) Then
                ProgressBar1.Value = ProgressBar1.Value + 25
                buttonfinih3(3)
                strawberryn1.Text = strawberryn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(3) = 6) Then
                ProgressBar1.Value = ProgressBar1.Value + 30
                buttonfinih3(3)
                pumpkinn1.Text = pumpkinn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(3) = 7) Then
                ProgressBar1.Value = ProgressBar1.Value + 40
                buttonfinih3(3)
                carrotn1.Text = carrotn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(3) = 8) Then
                ProgressBar1.Value = ProgressBar1.Value + 50
                buttonfinih3(3)
                wheatn1.Text = wheatn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(3) = 9) Then
                ProgressBar1.Value = ProgressBar1.Value + 60
                buttonfinih3(3)
                radishn1.Text = radishn1.Text + rndNum.Next(1, 4)
            End If


            If (exp1(3) = 10) Then
                ProgressBar1.Value = ProgressBar1.Value + 70
                buttonfinih3(3)
                marrown1.Text = marrown1.Text + rndNum.Next(1, 4)
            End If
            checklevel()
        End If


    End Sub

    Sub buttonfinih3(x)
        checklevel()
        buttonfinish(x) = 0
        If x = 3 Then
            Button3.BackgroundImage = ImageList1.Images(0)
        ElseIf x = 1 Then
            Button1.BackgroundImage = ImageList1.Images(0)
        ElseIf x = 2 Then
            Button2.BackgroundImage = ImageList1.Images(0)
        ElseIf x = 4 Then
            button20.BackgroundImage = ImageList1.Images(0)
        ElseIf x = 5 Then
            Button7.BackgroundImage = ImageList1.Images(0)
        End If
        exp1(x) = 0
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BACK1.Click

        If (home2.Visible = True And SHOP1.Visible = False) Then
            home2.Visible = False
            BACK1.Visible = False
        ElseIf (home2.Visible = False And SHOP1.Visible = True) Then
            SHOP1.Visible = False
            BACK1.Visible = False
            FlatStyleChange2()
            uepchange()

        Else
            uepchange()

            SHOP1.Visible = True
            FlatStyleChange2()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        BACK1.Visible = True
        home2.Visible = True
    End Sub

    Private Sub Button5_Click_3(sender As Object, e As EventArgs) Handles Button5.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Button5.Visible = False
            Money.Text = Money.Text + 1500
        Else

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button11.Visible = False

        Else

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button12.Visible = False

        Else

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button13.Visible = False

        Else

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button14.Visible = False

        Else

        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button15.Visible = False

        Else

        End If
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button15.Visible = False

        Else

        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button16.Visible = False

        Else

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button17.Visible = False

        Else

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim X As Integer
        X = MsgBox("是否要販售?", 4 + 32, "販賣動物")
        If X = 6 Then
            Money.Text = Money.Text + 1500
            Button18.Visible = False

        Else

        End If
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub applepn1_Click(sender As Object, e As EventArgs) Handles applepn1.Click
        Try
            Dim aa As Integer
            aa = InputBox("要賣出多少:", "販售")
            If aa = 0 Then
                applepn1.Text = applepn1.Text - 0
            Else
                applepn1.Text = applepn1.Text - aa
                Money.Text = Money.Text + (aa * 100)
                If applepn1.Text < 0 Then
                    applepn1.Text = applepn1.Text + aa
                    Money.Text = Money.Text - (aa * 100)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        mission.Visible = False
        missionslevel()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer6.Interval = 100 Then
            If mousestate1 = 2 Then

                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    Timer6.Interval = 10
                    Money.Text = Money.Text - 50
                End If
            End If
        End If
        If mousestate1 = 4 Then
            water(2) = 1
        End If
        If water(2) = 1 Then
            Try
                Me.Controls.Add(plantPorgress(2))
                plantPorgress(2).BringToFront()
                Timer6.Enabled = True
                water(2) = 0
            Catch ex As Exception

            End Try

        End If
        If (buttonfinish(1) = 0 And BACK1.Visible = True) Then
            If (applepl(1) = 1) Then
                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled

                Else
                    buttonfinish(1) = 2
                    exp1(1) = 1
                    Money.Text = Money.Text - 50
                    applepl(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(1)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 100
                    End With

                End If
            End If

            If (cabbage1(1) = 1) Then
                If (Money.Text - 100 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(1) = 2
                    exp1(1) = 2
                    Money.Text = Money.Text - 100
                    cabbage1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(4)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 120
                    End With

                End If
            End If


            If (tomato1(1) = 1) Then
                If (Money.Text - 150 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(1) = 2
                    exp1(1) = 3
                    Money.Text = Money.Text - 150
                    tomato1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(7)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (watermelon1(1) = 1) Then
                If (Money.Text - 200 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(1) = 2
                    exp1(1) = 4
                    Money.Text = Money.Text - 200
                    watermelon1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(13)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (strawberry1(1) = 1) Then
                If (Money.Text - 250 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(1) = 2
                    exp1(1) = 5
                    Money.Text = Money.Text - 250
                    strawberry1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(10)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 180
                    End With

                End If
            End If

            If (pumpkin1(1) = 1) Then
                If (Money.Text - 300 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(1) = 2
                    exp1(1) = 6
                    Money.Text = Money.Text - 300
                    pumpkin1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(16)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (carrot1(1) = 1) Then
                If (Money.Text - 450 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(1) = 2
                    exp1(1) = 7
                    Money.Text = Money.Text - 450
                    carrot1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(19)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (wheat1(1) = 1) Then
                If (Money.Text - 500 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(1) = 2
                    exp1(1) = 8
                    Money.Text = Money.Text - 500
                    wheat1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(22)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (radish1(1) = 1) Then
                If (Money.Text - 550 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(1) = 2
                    exp1(1) = 9
                    Money.Text = Money.Text - 550
                    radish1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(27)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (marrow1(1) = 1) Then
                If (Money.Text - 600 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    exp1(1) = 10
                    Money.Text = Money.Text - 600
                    marrow1(1) = 2
                    Button1.BackgroundImage = ImageList1.Images(31)
                    plantPorgress(2) = New ProgressBar
                    With plantPorgress(2)
                        .Top = Button1.Top - 15
                        .Left = Button1.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 250
                    End With

                End If
            End If

        End If


        If (buttonfinish(1) = 1 And mousestate1 = 5) Then

            Timer6.Interval = 100
            If (exp1(1) = 1) Then
                ProgressBar1.Value = ProgressBar1.Value + 5
                buttonfinih3(1)
                applepn1.Text = applepn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(1) = 2) Then
                ProgressBar1.Value = ProgressBar1.Value + 10
                buttonfinih3(1)
                cabbagen1.Text = cabbagen1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(1) = 3) Then
                ProgressBar1.Value = ProgressBar1.Value + 15
                buttonfinih3(1)
                tomaton1.Text = tomaton1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(1) = 4) Then
                ProgressBar1.Value = ProgressBar1.Value + 20
                buttonfinih3(1)
                watermelonn1.Text = watermelonn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(1) = 5) Then
                ProgressBar1.Value = ProgressBar1.Value + 25
                buttonfinih3(1)
                strawberryn1.Text = strawberryn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(1) = 6) Then
                ProgressBar1.Value = ProgressBar1.Value + 30
                buttonfinih3(1)
                pumpkinn1.Text = pumpkinn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(1) = 7) Then
                ProgressBar1.Value = ProgressBar1.Value + 40
                buttonfinih3(1)
                carrotn1.Text = carrotn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(1) = 8) Then
                ProgressBar1.Value = ProgressBar1.Value + 50
                buttonfinih3(1)
                wheatn1.Text = wheatn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(1) = 9) Then
                ProgressBar1.Value = ProgressBar1.Value + 60
                buttonfinih3(1)
                radishn1.Text = radishn1.Text + rndNum.Next(1, 4)
            End If


            If (exp1(1) = 10) Then
                ProgressBar1.Value = ProgressBar1.Value + 70
                buttonfinih3(1)
                marrown1.Text = marrown1.Text + rndNum.Next(1, 4)
            End If

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Timer9.Interval = 100 Then
            If mousestate1 = 2 Then

                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    Timer9.Interval = 10
                    Money.Text = Money.Text - 50
                End If
            End If
        End If
        If mousestate1 = 4 Then
            water(4) = 1
        End If
        If water(4) = 1 Then
            Try
                Me.Controls.Add(plantPorgress(5))
                plantPorgress(5).BringToFront()
                Timer9.Enabled = True
                water(4) = 0
            Catch ex As Exception

            End Try

        End If
        If (buttonfinish(5) = 0 And BACK1.Visible = True) Then
            If (applepl(5) = 1) Then
                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled

                Else
                    buttonfinish(5) = 2
                    exp1(5) = 1
                    Money.Text = Money.Text - 50
                    applepl(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(1)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 100
                    End With

                End If
            End If

            If (cabbage1(5) = 1) Then
                If (Money.Text - 100 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 2
                    Money.Text = Money.Text - 100
                    cabbage1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(4)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 120
                    End With

                End If
            End If


            If (tomato1(5) = 1) Then
                If (Money.Text - 150 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 3
                    Money.Text = Money.Text - 150
                    tomato1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(7)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (watermelon1(5) = 1) Then
                If (Money.Text - 200 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 4
                    Money.Text = Money.Text - 200
                    watermelon1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(13)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (strawberry1(5) = 1) Then
                If (Money.Text - 250 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 5
                    Money.Text = Money.Text - 250
                    strawberry1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(10)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 180
                    End With

                End If
            End If

            If (pumpkin1(5) = 1) Then
                If (Money.Text - 300 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 6
                    Money.Text = Money.Text - 300
                    pumpkin1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(16)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (carrot1(5) = 1) Then
                If (Money.Text - 450 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 7
                    Money.Text = Money.Text - 450
                    carrot1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(19)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (wheat1(5) = 1) Then
                If (Money.Text - 500 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 8
                    Money.Text = Money.Text - 500
                    wheat1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(22)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (radish1(5) = 1) Then
                If (Money.Text - 550 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 9
                    Money.Text = Money.Text - 550
                    radish1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(27)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (marrow1(5) = 1) Then
                If (Money.Text - 600 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(5) = 2
                    exp1(5) = 10
                    Money.Text = Money.Text - 600
                    marrow1(5) = 2
                    Button7.BackgroundImage = ImageList1.Images(31)
                    plantPorgress(5) = New ProgressBar
                    With plantPorgress(5)
                        .Top = Button7.Top - 15
                        .Left = Button7.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 250
                    End With

                End If
            End If

        End If


        If (buttonfinish(5) = 1 And mousestate1 = 5) Then
            Timer9.Interval = 100

            If (exp1(5) = 1) Then
                ProgressBar1.Value = ProgressBar1.Value + 5
                buttonfinih3(5)
                applepn1.Text = applepn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(5) = 2) Then
                ProgressBar1.Value = ProgressBar1.Value + 10
                buttonfinih3(5)
                cabbagen1.Text = cabbagen1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(5) = 3) Then
                ProgressBar1.Value = ProgressBar1.Value + 15
                buttonfinih3(5)
                tomaton1.Text = tomaton1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(5) = 4) Then
                ProgressBar1.Value = ProgressBar1.Value + 20
                buttonfinih3(5)
                watermelonn1.Text = watermelonn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(5) = 5) Then
                ProgressBar1.Value = ProgressBar1.Value + 25
                buttonfinih3(5)
                strawberryn1.Text = strawberryn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(5) = 6) Then
                ProgressBar1.Value = ProgressBar1.Value + 30
                buttonfinih3(5)
                pumpkinn1.Text = pumpkinn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(5) = 7) Then
                ProgressBar1.Value = ProgressBar1.Value + 40
                buttonfinih3(5)
                carrotn1.Text = carrotn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(5) = 8) Then
                ProgressBar1.Value = ProgressBar1.Value + 50
                buttonfinih3(5)
                wheatn1.Text = wheatn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(5) = 9) Then
                ProgressBar1.Value = ProgressBar1.Value + 60
                buttonfinih3(5)
                radishn1.Text = radishn1.Text + rndNum.Next(1, 4)
            End If


            If (exp1(5) = 10) Then
                ProgressBar1.Value = ProgressBar1.Value + 70
                buttonfinih3(5)
                marrown1.Text = marrown1.Text + rndNum.Next(1, 4)
            End If

        End If
    End Sub

    Private Sub level_Click(sender As Object, e As EventArgs) Handles level.Click
        Timer3.Enabled = True
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If (applepl(1) = 2) Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5

            If (plantPorgress(2).Value = 50) Then
                Button1.BackgroundImage = ImageList1.Images(2)
            End If
            If (plantPorgress(2).Value = 100) Then
                Button1.BackgroundImage = ImageList1.Images(3)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()
            End If

        End If

        If (cabbage1(1) = 2) Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5
            If (plantPorgress(2).Value = 80) Then
                Button1.BackgroundImage = ImageList1.Images(5)
            End If
            If (plantPorgress(2).Value = 120) Then
                Button1.BackgroundImage = ImageList1.Images(6)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()
            End If
        End If
        If (tomato1(1) = 2) Then
            buttonfinish(1) = 2
            Try
                plantPorgress(2).Value = plantPorgress(2).Value + 5
                If (plantPorgress(1).Value = 100) Then
                    Button1.BackgroundImage = ImageList1.Images(8)
                End If
                If (plantPorgress(2).Value = 150) Then
                    Button1.BackgroundImage = ImageList1.Images(9)
                    plantPorgress(2).Value = 0
                    plantPorgress(2).Visible = False

                    Timer6.Enabled = False
                    buttonfinish(1) = 1
                    lepchange()
                End If
            Catch

            End Try
        End If




        If (watermelon1(1) = 2) Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5
            If (plantPorgress(2).Value = 100) Then
                Button1.BackgroundImage = ImageList1.Images(14)
            End If
            If (plantPorgress(2).Value = 150) Then
                Button1.BackgroundImage = ImageList1.Images(15)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()
            End If
        End If

        If (strawberry1(1) = 2) Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5
            If (plantPorgress(2).Value = 120) Then
                Button1.BackgroundImage = ImageList1.Images(11)
            End If
            If (plantPorgress(2).Value = 180) Then
                Button1.BackgroundImage = ImageList1.Images(12)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()
            End If
        End If

        If (pumpkin1(1) = 2) Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5
            If (plantPorgress(2).Value = 150) Then
                Button1.BackgroundImage = ImageList1.Images(17)
            End If
            If (plantPorgress(2).Value = 200) Then
                Button1.BackgroundImage = ImageList1.Images(18)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()
            End If
        End If

        If (carrot1(1) = 2) Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5
            If (plantPorgress(2).Value = 150) Then
                Button1.BackgroundImage = ImageList1.Images(20)
            End If
            If (plantPorgress(2).Value = 200) Then
                Button1.BackgroundImage = ImageList1.Images(21)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()

            End If
        End If

        If wheat1(1) = 2 Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5
            If (plantPorgress(2).Value = 100) Then
                Button1.BackgroundImage = ImageList1.Images(23)
            End If

            If (plantPorgress(2).Value = 180) Then
                Button1.BackgroundImage = ImageList1.Images(24)
            End If

            If (plantPorgress(2).Value = 220) Then
                Button1.BackgroundImage = ImageList1.Images(25)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()
            End If
        End If
        If radish1(1) = 2 Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5

            If (plantPorgress(2).Value = 180) Then
                Button1.BackgroundImage = ImageList1.Images(28)
            End If

            If (plantPorgress(2).Value = 220) Then
                Button1.BackgroundImage = ImageList1.Images(29)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()
            End If
        End If

        If marrow1(1) = 2 Then
            buttonfinish(1) = 2
            plantPorgress(2).Value = plantPorgress(2).Value + 5

            If (plantPorgress(2).Value = 100) Then
                Button1.BackgroundImage = ImageList1.Images(32)
            End If

            If (plantPorgress(2).Value = 200) Then
                Button1.BackgroundImage = ImageList1.Images(33)
            End If

            If (plantPorgress(2).Value = 250) Then
                Button1.BackgroundImage = ImageList1.Images(34)
                plantPorgress(2).Value = 0
                plantPorgress(2).Visible = False

                Timer6.Enabled = False
                buttonfinish(1) = 1
                lepchange()
            End If
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If (applepl(2) = 2) Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5

            If (plantPorgress(3).Value = 50) Then
                Button2.BackgroundImage = ImageList1.Images(2)
            End If
            If (plantPorgress(3).Value = 100) Then
                Button2.BackgroundImage = ImageList1.Images(3)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()
            End If

        End If

        If (cabbage1(2) = 2) Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5
            If (plantPorgress(3).Value = 80) Then
                Button2.BackgroundImage = ImageList1.Images(5)
            End If
            If (plantPorgress(3).Value = 120) Then
                Button2.BackgroundImage = ImageList1.Images(6)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()
            End If
        End If
        If (tomato1(2) = 2) Then
            buttonfinish(2) = 2
            Try
                plantPorgress(3).Value = plantPorgress(3).Value + 5
                If (plantPorgress(3).Value = 100) Then
                    Button2.BackgroundImage = ImageList1.Images(8)
                End If
                If (plantPorgress(3).Value = 150) Then
                    Button2.BackgroundImage = ImageList1.Images(9)
                    plantPorgress(3).Value = 0
                    plantPorgress(3).Visible = False

                    Timer7.Enabled = False
                    buttonfinish(2) = 1
                    lepchange()
                End If
            Catch

            End Try
        End If




        If (watermelon1(2) = 2) Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5
            If (plantPorgress(3).Value = 100) Then
                Button2.BackgroundImage = ImageList1.Images(14)
            End If
            If (plantPorgress(3).Value = 150) Then
                Button2.BackgroundImage = ImageList1.Images(15)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()
            End If
        End If

        If (strawberry1(2) = 2) Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5
            If (plantPorgress(3).Value = 120) Then
                Button2.BackgroundImage = ImageList1.Images(11)
            End If
            If (plantPorgress(3).Value = 180) Then
                Button2.BackgroundImage = ImageList1.Images(12)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()
            End If
        End If

        If (pumpkin1(2) = 2) Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5
            If (plantPorgress(3).Value = 150) Then
                Button2.BackgroundImage = ImageList1.Images(17)
            End If
            If (plantPorgress(3).Value = 200) Then
                Button2.BackgroundImage = ImageList1.Images(18)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()
            End If
        End If

        If (carrot1(2) = 2) Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5
            If (plantPorgress(3).Value = 150) Then
                Button2.BackgroundImage = ImageList1.Images(20)
            End If
            If (plantPorgress(3).Value = 200) Then
                Button2.BackgroundImage = ImageList1.Images(21)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()

            End If
        End If

        If wheat1(2) = 2 Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5
            If (plantPorgress(3).Value = 100) Then
                Button2.BackgroundImage = ImageList1.Images(23)
            End If

            If (plantPorgress(3).Value = 180) Then
                Button2.BackgroundImage = ImageList1.Images(24)
            End If

            If (plantPorgress(3).Value = 220) Then
                Button2.BackgroundImage = ImageList1.Images(25)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()
            End If
        End If
        If radish1(2) = 2 Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5

            If (plantPorgress(3).Value = 180) Then
                Button2.BackgroundImage = ImageList1.Images(28)
            End If

            If (plantPorgress(3).Value = 220) Then
                Button2.BackgroundImage = ImageList1.Images(29)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()
            End If
        End If

        If marrow1(2) = 2 Then
            buttonfinish(2) = 2
            plantPorgress(3).Value = plantPorgress(3).Value + 5

            If (plantPorgress(3).Value = 100) Then
                Button2.BackgroundImage = ImageList1.Images(32)
            End If

            If (plantPorgress(3).Value = 200) Then
                Button2.BackgroundImage = ImageList1.Images(33)
            End If

            If (plantPorgress(3).Value = 250) Then
                Button2.BackgroundImage = ImageList1.Images(34)
                plantPorgress(3).Value = 0
                plantPorgress(3).Visible = False

                Timer7.Enabled = False
                buttonfinish(2) = 1
                lepchange()
            End If
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If (applepl(4) = 2) Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5

            If (plantPorgress(4).Value = 50) Then
                button20.BackgroundImage = ImageList1.Images(2)
            End If
            If (plantPorgress(4).Value = 100) Then
                button20.BackgroundImage = ImageList1.Images(3)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False

                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()
            End If

        End If

        If (cabbage1(4) = 2) Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5
            If (plantPorgress(4).Value = 80) Then
                button20.BackgroundImage = ImageList1.Images(5)
            End If
            If (plantPorgress(4).Value = 120) Then
                button20.BackgroundImage = ImageList1.Images(6)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False

                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()
            End If
        End If
        If (tomato1(4) = 2) Then
            buttonfinish(4) = 2
            Try
                plantPorgress(4).Value = plantPorgress(4).Value + 5
                If (plantPorgress(4).Value = 100) Then
                    button20.BackgroundImage = ImageList1.Images(8)
                End If
                If (plantPorgress(4).Value = 150) Then
                    button20.BackgroundImage = ImageList1.Images(9)
                    plantPorgress(4).Value = 0
                    plantPorgress(4).Visible = False

                    Timer8.Enabled = False
                    buttonfinish(4) = 1
                    lepchange()
                End If
            Catch

            End Try
        End If




        If (watermelon1(4) = 2) Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5
            If (plantPorgress(4).Value = 100) Then
                button20.BackgroundImage = ImageList1.Images(14)
            End If
            If (plantPorgress(4).Value = 150) Then
                button20.BackgroundImage = ImageList1.Images(15)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False

                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()
            End If
        End If

        If (strawberry1(4) = 2) Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5
            If (plantPorgress(4).Value = 120) Then
                button20.BackgroundImage = ImageList1.Images(11)
            End If
            If (plantPorgress(4).Value = 180) Then
                button20.BackgroundImage = ImageList1.Images(12)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False


                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()
            End If
        End If

        If (pumpkin1(4) = 2) Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5
            If (plantPorgress(4).Value = 150) Then
                button20.BackgroundImage = ImageList1.Images(17)
            End If
            If (plantPorgress(4).Value = 200) Then
                button20.BackgroundImage = ImageList1.Images(18)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False

                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()
            End If
        End If

        If (carrot1(4) = 2) Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5
            If (plantPorgress(4).Value = 150) Then
                button20.BackgroundImage = ImageList1.Images(20)
            End If
            If (plantPorgress(4).Value = 200) Then
                button20.BackgroundImage = ImageList1.Images(21)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False

                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()

            End If
        End If

        If wheat1(4) = 2 Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5
            If (plantPorgress(4).Value = 100) Then
                button20.BackgroundImage = ImageList1.Images(23)
            End If

            If (plantPorgress(4).Value = 180) Then
                button20.BackgroundImage = ImageList1.Images(24)
            End If

            If (plantPorgress(4).Value = 220) Then
                button20.BackgroundImage = ImageList1.Images(25)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False

                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()
            End If
        End If
        If radish1(4) = 2 Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5

            If (plantPorgress(4).Value = 180) Then
                button20.BackgroundImage = ImageList1.Images(28)
            End If

            If (plantPorgress(4).Value = 220) Then
                button20.BackgroundImage = ImageList1.Images(29)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False

                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()
            End If
        End If

        If marrow1(4) = 2 Then
            buttonfinish(4) = 2
            plantPorgress(4).Value = plantPorgress(4).Value + 5

            If (plantPorgress(4).Value = 100) Then
                button20.BackgroundImage = ImageList1.Images(32)
            End If

            If (plantPorgress(4).Value = 200) Then
                button20.BackgroundImage = ImageList1.Images(33)
            End If

            If (plantPorgress(4).Value = 250) Then
                button20.BackgroundImage = ImageList1.Images(34)
                plantPorgress(4).Value = 0
                plantPorgress(4).Visible = False

                Timer8.Enabled = False
                buttonfinish(4) = 1
                lepchange()
            End If
        End If
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If (applepl(5) = 2) Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(5).Value + 5

            If (plantPorgress(5).Value = 50) Then
                Button7.BackgroundImage = ImageList1.Images(2)
            End If
            If (plantPorgress(5).Value = 100) Then
                Button7.BackgroundImage = ImageList1.Images(3)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False

                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()
            End If

        End If

        If (cabbage1(5) = 2) Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(5).Value + 5
            If (plantPorgress(5).Value = 80) Then
                Button7.BackgroundImage = ImageList1.Images(5)
            End If
            If (plantPorgress(5).Value = 120) Then
                Button7.BackgroundImage = ImageList1.Images(6)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False

                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()
            End If
        End If
        If (tomato1(5) = 2) Then
            buttonfinish(5) = 2
            Try
                plantPorgress(5).Value = plantPorgress(5).Value + 5
                If (plantPorgress(5).Value = 100) Then
                    Button7.BackgroundImage = ImageList1.Images(8)
                End If
                If (plantPorgress(5).Value = 150) Then
                    Button7.BackgroundImage = ImageList1.Images(9)
                    plantPorgress(5).Value = 0
                    plantPorgress(5).Visible = False

                    Timer9.Enabled = False
                    buttonfinish(5) = 1
                    lepchange()
                End If
            Catch

            End Try
        End If




        If (watermelon1(5) = 2) Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(5).Value + 5
            If (plantPorgress(5).Value = 100) Then
                Button7.BackgroundImage = ImageList1.Images(14)
            End If
            If (plantPorgress(5).Value = 150) Then
                Button7.BackgroundImage = ImageList1.Images(15)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False

                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()
            End If
        End If

        If (strawberry1(5) = 2) Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(5).Value + 5
            If (plantPorgress(5).Value = 120) Then
                Button7.BackgroundImage = ImageList1.Images(11)
            End If
            If (plantPorgress(5).Value = 180) Then
                Button7.BackgroundImage = ImageList1.Images(12)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False


                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()
            End If
        End If

        If (pumpkin1(5) = 2) Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(5).Value + 5
            If (plantPorgress(5).Value = 150) Then
                Button7.BackgroundImage = ImageList1.Images(17)
            End If
            If (plantPorgress(5).Value = 200) Then
                Button7.BackgroundImage = ImageList1.Images(18)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False

                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()
            End If
        End If

        If (carrot1(5) = 2) Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(5).Value + 5
            If (plantPorgress(5).Value = 150) Then
                Button7.BackgroundImage = ImageList1.Images(20)
            End If
            If (plantPorgress(5).Value = 200) Then
                Button7.BackgroundImage = ImageList1.Images(21)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False

                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()

            End If
        End If

        If wheat1(5) = 2 Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(4).Value + 5
            If (plantPorgress(5).Value = 100) Then
                Button7.BackgroundImage = ImageList1.Images(23)
            End If

            If (plantPorgress(5).Value = 180) Then
                Button7.BackgroundImage = ImageList1.Images(24)
            End If

            If (plantPorgress(5).Value = 220) Then
                Button7.BackgroundImage = ImageList1.Images(25)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False

                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()
            End If
        End If
        If radish1(5) = 2 Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(5).Value + 5

            If (plantPorgress(5).Value = 180) Then
                Button7.BackgroundImage = ImageList1.Images(28)
            End If

            If (plantPorgress(5).Value = 220) Then
                Button7.BackgroundImage = ImageList1.Images(29)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False

                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()
            End If
        End If

        If marrow1(5) = 2 Then
            buttonfinish(5) = 2
            plantPorgress(5).Value = plantPorgress(5).Value + 5

            If (plantPorgress(5).Value = 100) Then
                Button7.BackgroundImage = ImageList1.Images(32)
            End If

            If (plantPorgress(5).Value = 200) Then
                Button7.BackgroundImage = ImageList1.Images(33)
            End If

            If (plantPorgress(5).Value = 250) Then
                Button7.BackgroundImage = ImageList1.Images(34)
                plantPorgress(5).Value = 0
                plantPorgress(5).Visible = False

                Timer9.Enabled = False
                buttonfinish(5) = 1
                lepchange()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Timer7.Interval = 100 Then
            If mousestate1 = 2 Then

                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    Timer7.Interval = 10
                    Money.Text = Money.Text - 50
                End If
            End If
        End If
        If mousestate1 = 4 Then
            water(1) = 1
        End If
        If water(1) = 1 Then
            Try
                Me.Controls.Add(plantPorgress(3))
                plantPorgress(3).BringToFront()
                Timer7.Enabled = True
                water(1) = 0
            Catch ex As Exception

            End Try

        End If
        If (buttonfinish(2) = 0 And BACK1.Visible = True) Then
            If (applepl(2) = 1) Then
                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled

                Else
                    buttonfinish(2) = 2
                    exp1(2) = 1
                    Money.Text = Money.Text - 50
                    applepl(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(1)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 100
                    End With

                End If
            End If

            If (cabbage1(2) = 1) Then
                If (Money.Text - 100 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 2
                    Money.Text = Money.Text - 100
                    cabbage1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(4)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 120
                    End With

                End If
            End If


            If (tomato1(2) = 1) Then
                If (Money.Text - 150 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 3
                    Money.Text = Money.Text - 150
                    tomato1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(7)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (watermelon1(2) = 1) Then
                If (Money.Text - 200 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 4
                    Money.Text = Money.Text - 200
                    watermelon1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(13)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (strawberry1(2) = 1) Then
                If (Money.Text - 250 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 5
                    Money.Text = Money.Text - 250
                    strawberry1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(10)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 180
                    End With

                End If
            End If

            If (pumpkin1(2) = 1) Then
                If (Money.Text - 300 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 6
                    Money.Text = Money.Text - 300
                    pumpkin1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(16)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (carrot1(2) = 1) Then
                If (Money.Text - 450 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 7
                    Money.Text = Money.Text - 450
                    carrot1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(19)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (wheat1(2) = 1) Then
                If (Money.Text - 500 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 8
                    Money.Text = Money.Text - 500
                    wheat1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(22)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (radish1(2) = 1) Then
                If (Money.Text - 550 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 9
                    Money.Text = Money.Text - 550
                    radish1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(27)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (marrow1(2) = 1) Then
                If (Money.Text - 600 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(2) = 2
                    exp1(2) = 10
                    Money.Text = Money.Text - 600
                    marrow1(2) = 2
                    Button2.BackgroundImage = ImageList1.Images(31)
                    plantPorgress(3) = New ProgressBar
                    With plantPorgress(3)
                        .Top = Button2.Top - 15
                        .Left = Button2.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 250
                    End With

                End If
            End If

        End If


        If (buttonfinish(2) = 1 And mousestate1 = 5) Then
            Timer7.Interval = 100

            If (exp1(2) = 1) Then
                ProgressBar1.Value = ProgressBar1.Value + 5
                buttonfinih3(2)
                applepn1.Text = applepn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(2) = 2) Then
                ProgressBar1.Value = ProgressBar1.Value + 10
                buttonfinih3(2)
                cabbagen1.Text = cabbagen1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(2) = 3) Then
                ProgressBar1.Value = ProgressBar1.Value + 15
                buttonfinih3(2)
                tomaton1.Text = tomaton1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(2) = 4) Then
                ProgressBar1.Value = ProgressBar1.Value + 20
                buttonfinih3(2)
                watermelonn1.Text = watermelonn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(2) = 5) Then
                ProgressBar1.Value = ProgressBar1.Value + 25
                buttonfinih3(2)
                strawberryn1.Text = strawberryn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(2) = 6) Then
                ProgressBar1.Value = ProgressBar1.Value + 30
                buttonfinih3(2)
                pumpkinn1.Text = pumpkinn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(2) = 7) Then
                ProgressBar1.Value = ProgressBar1.Value + 40
                buttonfinih3(2)
                carrotn1.Text = carrotn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(2) = 8) Then
                ProgressBar1.Value = ProgressBar1.Value + 50
                buttonfinih3(2)
                wheatn1.Text = wheatn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(2) = 9) Then
                ProgressBar1.Value = ProgressBar1.Value + 60
                buttonfinih3(2)
                radishn1.Text = radishn1.Text + rndNum.Next(1, 4)
            End If


            If (exp1(2) = 10) Then
                ProgressBar1.Value = ProgressBar1.Value + 70
                buttonfinih3(2)
                marrown1.Text = marrown1.Text + rndNum.Next(1, 4)
            End If

        End If
    End Sub

    Private Sub button20_Click(sender As Object, e As EventArgs) Handles button20.Click
        If Timer8.Interval = 100 Then
            If mousestate1 = 2 Then

                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    Timer8.Interval = 10
                    Money.Text = Money.Text - 50
                End If
            End If
        End If
        If mousestate1 = 4 Then
            water(3) = 1
        End If
        If water(3) = 1 Then
            Try
                Me.Controls.Add(plantPorgress(4))
                plantPorgress(4).BringToFront()
                Timer8.Enabled = True
                water(3) = 0
            Catch ex As Exception

            End Try

        End If
        If (buttonfinish(4) = 0 And BACK1.Visible = True) Then
            If (applepl(4) = 1) Then
                If (Money.Text - 50 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled

                Else
                    buttonfinish(4) = 2
                    exp1(4) = 1
                    Money.Text = Money.Text - 50
                    applepl(4) = 2
                    button20.BackgroundImage = ImageList1.Images(1)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 100
                    End With

                End If
            End If

            If (cabbage1(4) = 1) Then
                If (Money.Text - 100 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 2
                    Money.Text = Money.Text - 100
                    cabbage1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(4)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 120
                    End With

                End If
            End If


            If (tomato1(4) = 1) Then
                If (Money.Text - 150 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 3
                    Money.Text = Money.Text - 150
                    tomato1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(7)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (watermelon1(4) = 1) Then
                If (Money.Text - 200 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 4
                    Money.Text = Money.Text - 200
                    watermelon1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(13)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 150
                    End With

                End If
            End If

            If (strawberry1(4) = 1) Then
                If (Money.Text - 250 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 5
                    Money.Text = Money.Text - 250
                    strawberry1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(10)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 180
                    End With

                End If
            End If

            If (pumpkin1(4) = 1) Then
                If (Money.Text - 300 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 6
                    Money.Text = Money.Text - 300
                    pumpkin1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(16)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (carrot1(4) = 1) Then
                If (Money.Text - 450 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 7
                    Money.Text = Money.Text - 450
                    carrot1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(19)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 200
                    End With

                End If
            End If

            If (wheat1(4) = 1) Then
                If (Money.Text - 500 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 8
                    Money.Text = Money.Text - 500
                    wheat1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(22)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (radish1(4) = 1) Then
                If (Money.Text - 550 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 9
                    Money.Text = Money.Text - 550
                    radish1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(27)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 220
                    End With

                End If
            End If

            If (marrow1(4) = 1) Then
                If (Money.Text - 600 < 0) Then
                    Money.ForeColor = Color.Red
                    Timer2.Enabled = Enabled
                Else
                    buttonfinish(4) = 2
                    exp1(4) = 10
                    Money.Text = Money.Text - 600
                    marrow1(4) = 2
                    button20.BackgroundImage = ImageList1.Images(31)
                    plantPorgress(4) = New ProgressBar
                    With plantPorgress(4)
                        .Top = button20.Top - 15
                        .Left = button20.Left + 40
                        .Width = 45
                        .Height = 12
                        .Tag = 1
                        .Text = ""
                        .Font = New Font("", 12)
                        .Maximum = 250
                    End With

                End If
            End If

        End If


        If (buttonfinish(4) = 1 And mousestate1 = 5) Then

            Timer8.Interval = 100
            If (exp1(4) = 1) Then
                ProgressBar1.Value = ProgressBar1.Value + 5
                buttonfinih3(4)
                applepn1.Text = applepn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(4) = 2) Then
                ProgressBar1.Value = ProgressBar1.Value + 10
                buttonfinih3(4)
                cabbagen1.Text = cabbagen1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(4) = 3) Then
                ProgressBar1.Value = ProgressBar1.Value + 15
                buttonfinih3(4)
                tomaton1.Text = tomaton1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(4) = 4) Then
                ProgressBar1.Value = ProgressBar1.Value + 20
                buttonfinih3(4)
                watermelonn1.Text = watermelonn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(4) = 5) Then
                ProgressBar1.Value = ProgressBar1.Value + 25
                buttonfinih3(4)
                strawberryn1.Text = strawberryn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(4) = 6) Then
                ProgressBar1.Value = ProgressBar1.Value + 30
                buttonfinih3(4)
                pumpkinn1.Text = pumpkinn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(4) = 7) Then
                ProgressBar1.Value = ProgressBar1.Value + 40
                buttonfinih3(4)
                carrotn1.Text = carrotn1.Text + rndNum.Next(1, 4)
            End If
            If (exp1(4) = 8) Then
                ProgressBar1.Value = ProgressBar1.Value + 50
                buttonfinih3(4)
                wheatn1.Text = wheatn1.Text + rndNum.Next(1, 4)
            End If

            If (exp1(4) = 9) Then
                ProgressBar1.Value = ProgressBar1.Value + 60
                buttonfinih3(4)
                radishn1.Text = radishn1.Text + rndNum.Next(1, 4)
            End If


            If (exp1(4) = 10) Then
                ProgressBar1.Value = ProgressBar1.Value + 70
                buttonfinih3(4)
                marrown1.Text = marrown1.Text + rndNum.Next(1, 4)
            End If

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub cabbagen1_Click(sender As Object, e As EventArgs) Handles cabbagen1.Click
        Try
            Dim bb As Integer
            bb = InputBox("要賣出多少:", "販售")
            If bb = 0 Then
                cabbagen1.Text = cabbagen1.Text - 0
            Else
                cabbagen1.Text = cabbagen1.Text - bb
                Money.Text = Money.Text + (bb * 150)
                If cabbagen1.Text < 0 Then
                    cabbagen1.Text = cabbagen1.Text + bb
                    Money.Text = Money.Text - (bb * 150)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tomaton1_Click(sender As Object, e As EventArgs) Handles tomaton1.Click
        Try
            Dim cc As Integer
            cc = InputBox("要賣出多少:", "販售")
            If cc = 0 Then
                tomaton1.Text = tomaton1.Text - 0
            Else
                tomaton1.Text = tomaton1.Text - cc
                Money.Text = Money.Text + (cc * 200)
                If tomaton1.Text < 0 Then
                    tomaton1.Text = tomaton1.Text + cc
                    Money.Text = Money.Text - (cc * 200)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub watermelonn1_Click(sender As Object, e As EventArgs) Handles watermelonn1.Click
        Try
            Dim dd As Integer
            dd = InputBox("要賣出多少:", "販售")
            If dd = 0 Then
                watermelonn1.Text = watermelonn1.Text - 0
            Else
                watermelonn1.Text = watermelonn1.Text - dd
                Money.Text = Money.Text + (dd * 250)
                If watermelonn1.Text < 0 Then
                    watermelonn1.Text = watermelonn1.Text + dd
                    Money.Text = Money.Text - (dd * 250)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub strawberryn1_Click(sender As Object, e As EventArgs) Handles strawberryn1.Click
        Try
            Dim ee As Integer
            ee = InputBox("要賣出多少:", "販售")
            If ee = 0 Then
                strawberryn1.Text = strawberryn1.Text - 0
            Else
                strawberryn1.Text = strawberryn1.Text - ee
                Money.Text = Money.Text + (ee * 300)
                If strawberryn1.Text < 0 Then
                    strawberryn1.Text = strawberryn1.Text + ee
                    Money.Text = Money.Text - (ee * 300)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pumpkinn1_Click(sender As Object, e As EventArgs) Handles pumpkinn1.Click
        Try
            Dim ff As Integer
            ff = InputBox("要賣出多少:", "販售")
            If ff = 0 Then
                pumpkinn1.Text = pumpkinn1.Text - 0
            Else
                pumpkinn1.Text = pumpkinn1.Text - ff
                Money.Text = Money.Text + (ff * 350)
                If pumpkinn1.Text < 0 Then
                    pumpkinn1.Text = pumpkinn1.Text + ff
                    Money.Text = Money.Text - (ff * 350)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub carrotn1_Click(sender As Object, e As EventArgs) Handles carrotn1.Click
        Try
            Dim gg As Integer
            gg = InputBox("要賣出多少:", "販售")
            If gg = 0 Then
                carrotn1.Text = carrotn1.Text - 0
            Else
                carrotn1.Text = carrotn1.Text - gg
                Money.Text = Money.Text + (gg * 400)
                If carrotn1.Text < 0 Then
                    carrotn1.Text = carrotn1.Text + gg
                    Money.Text = Money.Text - (gg * 400)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub wheatn1_Click(sender As Object, e As EventArgs) Handles wheatn1.Click
        Try
            Dim hh As Integer
            hh = InputBox("要賣出多少:", "販售")
            If hh = 0 Then
                wheatn1.Text = wheatn1.Text - 0
            Else
                wheatn1.Text = wheatn1.Text - hh
                Money.Text = Money.Text + (hh * 450)
                If wheatn1.Text < 0 Then
                    wheatn1.Text = wheatn1.Text + hh
                    Money.Text = Money.Text - (hh * 450)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub radishn1_Click(sender As Object, e As EventArgs) Handles radishn1.Click
        Try
            Dim ii As Integer
            ii = InputBox("要賣出多少:", "販售")
            If ii = 0 Then
                radishn1.Text = radishn1.Text - 0
            Else
                radishn1.Text = radishn1.Text - ii
                Money.Text = Money.Text + (ii * 500)
                If radishn1.Text < 0 Then
                    radishn1.Text = radishn1.Text + ii
                    Money.Text = Money.Text - (ii * 500)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub marrown1_Click(sender As Object, e As EventArgs) Handles marrown1.Click
        Try
            Dim jj As Integer
            jj = InputBox("要賣出多少:", "販售")
            If jj = 0 Then
                marrown1.Text = marrown1.Text - 0
            Else
                marrown1.Text = marrown1.Text - jj
                Money.Text = Money.Text + (jj * 550)
                If marrown1.Text < 0 Then
                    marrown1.Text = marrown1.Text + jj
                    Money.Text = Money.Text - (jj * 550)
                Else

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SHOP1_Enter(sender As Object, e As EventArgs) Handles SHOP1.Enter

    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles watermelon.Click
        If level.Text > 2 Then
            SHOP1.Visible = False
            For i = 1 To 10
                watermelon1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\watermelon_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        mission.Visible = True

    End Sub

    Private Sub misson_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (time < 0) Then
            Money.ForeColor = Color.Black
            Timer2.Enabled = False
        Else
            time = time - 1
        End If

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub marrow_Click(sender As Object, e As EventArgs) Handles marrow.Click
        If level.Text > 7 Then
            SHOP1.Visible = False
            For i = 1 To 10
                marrow1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\vegetable_marrow_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()
        End If

    End Sub

    Private Sub radish_Click(sender As Object, e As EventArgs) Handles radish.Click

        If level.Text > 6 Then
            SHOP1.Visible = False
            For i = 1 To 10
                radish1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\radish_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()
        End If

    End Sub

    Private Sub wheat_Click(sender As Object, e As EventArgs) Handles wheat.Click
        If level.Text > 5 Then

            SHOP1.Visible = False
            For i = 1 To 10
                wheat1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\wheat_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()

        End If

    End Sub

    Private Sub carrot_Click(sender As Object, e As EventArgs) Handles carrot.Click
        If level.Text > 4 Then
            SHOP1.Visible = False
            For i = 1 To 10
                carrot1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\carrot_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()

        End If

    End Sub

    Private Sub pumpkin_shop_Click(sender As Object, e As EventArgs) Handles pumpkin_shop.Click
        If level.Text > 4 Then
            SHOP1.Visible = False
            For i = 1 To 10
                pumpkin1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\pumpkin_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()

        End If

    End Sub

    Private Sub strawberry_Click(sender As Object, e As EventArgs) Handles strawberry.Click
        If level.Text > 3 Then
            SHOP1.Visible = False
            For i = 1 To 10
                strawberry1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\strawberry_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()
        End If

    End Sub

    Private Sub tomato_Click(sender As Object, e As EventArgs) Handles tomato.Click
        If level.Text > 2 Then
            SHOP1.Visible = False
            For i = 1 To 10
                tomato1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\tomato_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()
        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles cabbage.Click

        If level.Text > 1 Then
            SHOP1.Visible = False
            For i = 1 To 10
                cabbage1(i) = 1
            Next

            Try

                Me.Cursor = New Cursor("ico\cabbage_small.ico")
            Catch ex As Exception

            End Try
            FlatStyleChange1()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (applepl(3) = 2) Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5

            If (plantPorgress(1).Value = 50) Then
                Button3.BackgroundImage = ImageList1.Images(2)
            End If
            If (plantPorgress(1).Value = 100) Then
                Button3.BackgroundImage = ImageList1.Images(3)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()
            End If

        End If

        If (cabbage1(3) = 2) Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5
            If (plantPorgress(1).Value = 80) Then
                Button3.BackgroundImage = ImageList1.Images(5)
            End If
            If (plantPorgress(1).Value = 120) Then
                Button3.BackgroundImage = ImageList1.Images(6)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()
            End If
        End If
        If (tomato1(3) = 2) Then
            buttonfinish(3) = 2
            Try
                plantPorgress(1).Value = plantPorgress(1).Value + 5
                If (plantPorgress(1).Value = 100) Then
                    Button3.BackgroundImage = ImageList1.Images(8)
                End If
                If (plantPorgress(1).Value = 150) Then
                    Button3.BackgroundImage = ImageList1.Images(9)
                    plantPorgress(1).Value = 0
                    plantPorgress(1).Visible = False

                    Timer1.Enabled = False
                    buttonfinish(3) = 1
                    lepchange()
                End If
            Catch

            End Try
        End If




        If (watermelon1(3) = 2) Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5
            If (plantPorgress(1).Value = 100) Then
                Button3.BackgroundImage = ImageList1.Images(14)
            End If
            If (plantPorgress(1).Value = 150) Then
                Button3.BackgroundImage = ImageList1.Images(15)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()
            End If
        End If

        If (strawberry1(3) = 2) Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5
            If (plantPorgress(1).Value = 120) Then
                Button3.BackgroundImage = ImageList1.Images(11)
            End If
            If (plantPorgress(1).Value = 180) Then
                Button3.BackgroundImage = ImageList1.Images(12)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()
            End If
        End If

        If (pumpkin1(3) = 2) Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5
            If (plantPorgress(1).Value = 150) Then
                Button3.BackgroundImage = ImageList1.Images(17)
            End If
            If (plantPorgress(1).Value = 200) Then
                Button3.BackgroundImage = ImageList1.Images(18)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()
            End If
        End If

        If (carrot1(3) = 2) Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5
            If (plantPorgress(1).Value = 150) Then
                Button3.BackgroundImage = ImageList1.Images(20)
            End If
            If (plantPorgress(1).Value = 200) Then
                Button3.BackgroundImage = ImageList1.Images(21)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()

            End If
        End If

        If wheat1(3) = 2 Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5
            If (plantPorgress(1).Value = 100) Then
                Button3.BackgroundImage = ImageList1.Images(23)
            End If

            If (plantPorgress(1).Value = 180) Then
                Button3.BackgroundImage = ImageList1.Images(24)
            End If

            If (plantPorgress(1).Value = 220) Then
                Button3.BackgroundImage = ImageList1.Images(25)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()
            End If
        End If
        If radish1(3) = 2 Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5

            If (plantPorgress(1).Value = 180) Then
                Button3.BackgroundImage = ImageList1.Images(28)
            End If

            If (plantPorgress(1).Value = 220) Then
                Button3.BackgroundImage = ImageList1.Images(29)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()
            End If
        End If

        If marrow1(3) = 2 Then
            buttonfinish(3) = 2
            plantPorgress(1).Value = plantPorgress(1).Value + 5

            If (plantPorgress(1).Value = 100) Then
                Button3.BackgroundImage = ImageList1.Images(32)
            End If

            If (plantPorgress(1).Value = 200) Then
                Button3.BackgroundImage = ImageList1.Images(33)
            End If

            If (plantPorgress(1).Value = 250) Then
                Button3.BackgroundImage = ImageList1.Images(34)
                plantPorgress(1).Value = 0
                plantPorgress(1).Visible = False

                Timer1.Enabled = False
                buttonfinish(3) = 1
                lepchange()
            End If
        End If
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click

        If (CheckBox1.Checked = True) Then

        Else
            For i = 1 To 1
                If missontitle(i) = 1 Then
                    If applepn1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        applepn1.Text = applepn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 2 Then
                    If cabbagen1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        cabbagen1.Text = cabbagen1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 3 Then
                    If tomaton1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        tomaton1.Text = tomaton1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 4 Then
                    If watermelonn1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        watermelonn1.Text = watermelonn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 5 Then
                    If strawberryn1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        strawberryn1.Text = strawberryn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 6 Then
                    If pumpkinn1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        pumpkinn1.Text = pumpkinn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 7 Then
                    If carrotn1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        carrotn1.Text = carrotn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 8 Then
                    If wheatn1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        wheatn1.Text = wheatn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 9 Then
                    If radishn1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        radishn1.Text = radishn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 10 Then
                    If marrown1.Text - misson1(1) > -1 Then
                        CheckBox1.Checked = True
                        marrown1.Text = marrown1.Text - misson1(i)
                        getmoney()
                    End If
                End If
            Next

        End If

    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If (CheckBox2.Checked = True) Then

        Else

            For i = 1 To 2
                If missontitle(i) = 1 Then
                    If applepn1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        applepn1.Text = applepn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 2 Then
                    If cabbagen1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        cabbagen1.Text = cabbagen1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 3 Then
                    If tomaton1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        tomaton1.Text = tomaton1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 4 Then
                    If watermelonn1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        watermelonn1.Text = watermelonn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 5 Then
                    If strawberryn1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        strawberryn1.Text = strawberryn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 6 Then
                    If pumpkinn1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        pumpkinn1.Text = pumpkinn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 7 Then
                    If carrotn1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        carrotn1.Text = carrotn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 8 Then
                    If wheatn1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        wheatn1.Text = wheatn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 9 Then
                    If radishn1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        radishn1.Text = radishn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 10 Then
                    If marrown1.Text - misson1(i) > -1 Then
                        CheckBox2.Checked = True
                        marrown1.Text = marrown1.Text - misson1(i)
                        getmoney()
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        If (CheckBox3.Checked = True) Then

        Else

            For i = 1 To 3
                If missontitle(i) = 1 Then
                    If applepn1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        applepn1.Text = applepn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 2 Then
                    If cabbagen1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        cabbagen1.Text = cabbagen1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 3 Then
                    If tomaton1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        tomaton1.Text = tomaton1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 4 Then
                    If watermelonn1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        watermelonn1.Text = watermelonn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 5 Then
                    If strawberryn1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        strawberryn1.Text = strawberryn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 6 Then
                    If pumpkinn1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        pumpkinn1.Text = pumpkinn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 7 Then
                    If carrotn1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        carrotn1.Text = carrotn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 8 Then
                    If wheatn1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        wheatn1.Text = wheatn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 9 Then
                    If radishn1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        radishn1.Text = radishn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 10 Then
                    If marrown1.Text - misson1(i) > -1 Then
                        CheckBox3.Checked = True
                        marrown1.Text = marrown1.Text - misson1(i)
                        getmoney()
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        If (CheckBox4.Checked = True) Then

        Else

            For i = 1 To 4
                If missontitle(i) = 1 Then
                    If applepn1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        applepn1.Text = applepn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 2 Then
                    If cabbagen1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        cabbagen1.Text = cabbagen1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 3 Then
                    If tomaton1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        tomaton1.Text = tomaton1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 4 Then
                    If watermelonn1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        watermelonn1.Text = watermelonn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 5 Then
                    If strawberryn1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        strawberryn1.Text = strawberryn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 6 Then
                    If pumpkinn1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        pumpkinn1.Text = pumpkinn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 7 Then
                    If carrotn1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        carrotn1.Text = carrotn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 8 Then
                    If wheatn1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        wheatn1.Text = wheatn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 9 Then
                    If radishn1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        radishn1.Text = radishn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 9 Then
                    If marrown1.Text - misson1(i) > -1 Then
                        CheckBox4.Checked = True
                        marrown1.Text = marrown1.Text - misson1(i)
                        getmoney()
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        If (CheckBox5.Checked = True) Then

        Else

            For i = 1 To 5
                If missontitle(i) = 1 Then
                    If applepn1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        applepn1.Text = applepn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 2 Then
                    If cabbagen1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        cabbagen1.Text = cabbagen1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 3 Then
                    If tomaton1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        tomaton1.Text = tomaton1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 4 Then
                    If watermelonn1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        watermelonn1.Text = watermelonn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 5 Then
                    If strawberryn1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        strawberryn1.Text = strawberryn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 6 Then
                    If pumpkinn1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        pumpkinn1.Text = pumpkinn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 7 Then
                    If carrotn1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        carrotn1.Text = carrotn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 8 Then
                    If wheatn1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        wheatn1.Text = wheatn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 9 Then
                    If radishn1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        radishn1.Text = radishn1.Text - misson1(i)
                        getmoney()
                    End If
                End If
                If missontitle(i) = 10 Then
                    If marrown1.Text - misson1(i) > -1 Then
                        CheckBox5.Checked = True
                        marrown1.Text = marrown1.Text - misson1(i)
                        getmoney()
                    End If
                End If
            Next
        End If
    End Sub
    Sub getmoney()
        If level.Text > 0 And level.Text < 4 Then
            Money.Text = Money.Text + rndNum.Next(200, 700)
            ProgressBar1.Value = ProgressBar1.Value + 25
        End If
        If level.Text > 4 And level.Text < 6 Then
            Money.Text = Money.Text + rndNum.Next(500, 2000)
            ProgressBar1.Value = ProgressBar1.Value + 50
        End If
        If level.Text > 6 And level.Text < 9 Then
            Money.Text = Money.Text + rndNum.Next(1000, 4000)
            ProgressBar1.Value = ProgressBar1.Value + 60
        End If
        checklevel()

    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Button3_MouseUp(sender As Object, e As MouseEventArgs) Handles Button3.MouseUp
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop2.ico")
        End If
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure1.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water1.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop.ico")
        End If
    End Sub

    Private Sub button20_MouseDown(sender As Object, e As MouseEventArgs) Handles button20.MouseDown
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure1.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water1.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop.ico")
        End If
    End Sub

    Private Sub button20_MouseUp(sender As Object, e As MouseEventArgs) Handles button20.MouseUp
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop2.ico")
        End If
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure1.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water1.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop.ico")
        End If
    End Sub

    Private Sub Button7_MouseDown(sender As Object, e As MouseEventArgs) Handles Button7.MouseDown
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure1.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water1.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop.ico")
        End If
    End Sub

    Private Sub Button7_MouseUp(sender As Object, e As MouseEventArgs) Handles Button7.MouseUp
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop2.ico")
        End If
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure1.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water1.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop.ico")
        End If
    End Sub

    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop2.ico")
        End If
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        If (mousestate1 = 2) Then
            Me.Cursor = New Cursor("ico\manure.ico")
        End If

        If (mousestate1 = 4) Then
            Me.Cursor = New Cursor("ico\water.ico")
        End If

        If (mousestate1 = 5) Then
            Me.Cursor = New Cursor("ico\chop2.ico")
        End If
    End Sub
End Class