<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StartButton1 = New System.Windows.Forms.Button()
        Me.StartButton2 = New System.Windows.Forms.Button()
        Me.StartButton3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabel1 = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.mission = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mission.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartButton1
        '
        Me.StartButton1.BackColor = System.Drawing.Color.Transparent
        Me.StartButton1.BackgroundImage = Global.final.My.Resources.Resources.button1_a
        Me.StartButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StartButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton1.FlatAppearance.BorderSize = 0
        Me.StartButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StartButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StartButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton1.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartButton1.ForeColor = System.Drawing.Color.Blue
        Me.StartButton1.Location = New System.Drawing.Point(400, 225)
        Me.StartButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton1.Name = "StartButton1"
        Me.StartButton1.Size = New System.Drawing.Size(243, 89)
        Me.StartButton1.TabIndex = 0
        Me.StartButton1.Text = "開始"
        Me.StartButton1.UseVisualStyleBackColor = False
        Me.StartButton1.Visible = False
        '
        'StartButton2
        '
        Me.StartButton2.BackColor = System.Drawing.Color.Transparent
        Me.StartButton2.BackgroundImage = Global.final.My.Resources.Resources.button1_a
        Me.StartButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StartButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton2.FlatAppearance.BorderSize = 0
        Me.StartButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StartButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StartButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton2.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartButton2.ForeColor = System.Drawing.Color.Blue
        Me.StartButton2.Location = New System.Drawing.Point(400, 350)
        Me.StartButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton2.Name = "StartButton2"
        Me.StartButton2.Size = New System.Drawing.Size(243, 89)
        Me.StartButton2.TabIndex = 1
        Me.StartButton2.Text = "選項"
        Me.StartButton2.UseVisualStyleBackColor = False
        Me.StartButton2.Visible = False
        '
        'StartButton3
        '
        Me.StartButton3.BackColor = System.Drawing.Color.Transparent
        Me.StartButton3.BackgroundImage = Global.final.My.Resources.Resources.button1_a
        Me.StartButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StartButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton3.FlatAppearance.BorderSize = 0
        Me.StartButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StartButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StartButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton3.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartButton3.ForeColor = System.Drawing.Color.Blue
        Me.StartButton3.Location = New System.Drawing.Point(400, 475)
        Me.StartButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton3.Name = "StartButton3"
        Me.StartButton3.Size = New System.Drawing.Size(243, 89)
        Me.StartButton3.TabIndex = 2
        Me.StartButton3.Text = "離開"
        Me.StartButton3.UseVisualStyleBackColor = False
        Me.StartButton3.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TimeLabel1
        '
        Me.TimeLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TimeLabel1.Location = New System.Drawing.Point(728, 662)
        Me.TimeLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeLabel1.Name = "TimeLabel1"
        Me.TimeLabel1.Size = New System.Drawing.Size(301, 29)
        Me.TimeLabel1.TabIndex = 3
        Me.TimeLabel1.Text = "time"
        Me.TimeLabel1.UseWaitCursor = True
        Me.TimeLabel1.Visible = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(162, 485)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(4)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(448, 42)
        Me.AxWindowsMediaPlayer1.TabIndex = 4
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(162, 530)
        Me.AxWindowsMediaPlayer2.Margin = New System.Windows.Forms.Padding(4)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(448, 23)
        Me.AxWindowsMediaPlayer2.TabIndex = 5
        Me.AxWindowsMediaPlayer2.UseWaitCursor = True
        Me.AxWindowsMediaPlayer2.Visible = False
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'mission
        '
        Me.mission.BackColor = System.Drawing.Color.Transparent
        Me.mission.BackgroundImage = Global.final.My.Resources.Resources.wood_pattern
        Me.mission.Controls.Add(Me.Button1)
        Me.mission.Controls.Add(Me.LinkLabel1)
        Me.mission.Controls.Add(Me.Label1)
        Me.mission.Controls.Add(Me.HScrollBar1)
        Me.mission.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mission.Location = New System.Drawing.Point(150, 86)
        Me.mission.Name = "mission"
        Me.mission.Size = New System.Drawing.Size(756, 524)
        Me.mission.TabIndex = 24
        Me.mission.TabStop = False
        Me.mission.Text = "選項"
        Me.mission.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 88)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "返回"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(291, 219)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(168, 47)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "遊戲說明"
        Me.LinkLabel1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "音量:50"
        Me.Label1.Visible = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(142, 96)
        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(516, 35)
        Me.HScrollBar1.TabIndex = 6
        Me.HScrollBar1.Value = 50
        Me.HScrollBar1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.final.My.Resources.Resources._11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1043, 689)
        Me.Controls.Add(Me.mission)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.TimeLabel1)
        Me.Controls.Add(Me.StartButton3)
        Me.Controls.Add(Me.StartButton2)
        Me.Controls.Add(Me.StartButton1)
        Me.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1061, 736)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1061, 736)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mission.ResumeLayout(False)
        Me.mission.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartButton1 As Button
    Friend WithEvents StartButton2 As Button
    Friend WithEvents StartButton3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeLabel1 As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents mission As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
End Class
