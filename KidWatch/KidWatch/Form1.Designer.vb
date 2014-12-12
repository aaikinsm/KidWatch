<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KidWatch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.Main = New System.Windows.Forms.TabPage()
        Me.ClockButton = New System.Windows.Forms.Button()
        Me.callButton = New System.Windows.Forms.Button()
        Me.CalendarButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.WatchBgImg = New System.Windows.Forms.PictureBox()
        Me.Music = New System.Windows.Forms.TabPage()
        Me.RepeatButton = New System.Windows.Forms.Button()
        Me.ShufftleButton = New System.Windows.Forms.Button()
        Me.PlaylistButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.NowPlaying = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Clock = New System.Windows.Forms.TabPage()
        Me.ChangeFace = New System.Windows.Forms.Button()
        Me.ClockDate = New System.Windows.Forms.Label()
        Me.ClockTime = New System.Windows.Forms.Label()
        Me.Calendar = New System.Windows.Forms.TabPage()
        Me.eventTime = New System.Windows.Forms.Label()
        Me.eventName = New System.Windows.Forms.Label()
        Me.dayEventTime2 = New System.Windows.Forms.Label()
        Me.dayEventName2 = New System.Windows.Forms.Label()
        Me.dayEventTime1 = New System.Windows.Forms.Label()
        Me.dayEventName1 = New System.Windows.Forms.Label()
        Me.day7Button = New System.Windows.Forms.Button()
        Me.day6Button = New System.Windows.Forms.Button()
        Me.day5Button = New System.Windows.Forms.Button()
        Me.day4Button = New System.Windows.Forms.Button()
        Me.day3Button = New System.Windows.Forms.Button()
        Me.day2Button = New System.Windows.Forms.Button()
        Me.day1Button = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Disrupt = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Playlist = New System.Windows.Forms.TabPage()
        Me.PlaylistIcon2 = New System.Windows.Forms.PictureBox()
        Me.PlaylistIcon1 = New System.Windows.Forms.PictureBox()
        Me.Playlist2 = New System.Windows.Forms.Label()
        Me.Playlist1 = New System.Windows.Forms.Label()
        Me.PhoneBook = New System.Windows.Forms.TabPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.CallJesBtn = New System.Windows.Forms.Button()
        Me.CallThomasBtn = New System.Windows.Forms.Button()
        Me.CallDadBtn = New System.Windows.Forms.Button()
        Me.CallMomBtn = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.CallPage = New System.Windows.Forms.TabPage()
        Me.HangUpBtn = New System.Windows.Forms.Button()
        Me.AcceptBtn = New System.Windows.Forms.Button()
        Me.CallTitle = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Reminder = New System.Windows.Forms.TabPage()
        Me.dismissReminder = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Faces = New System.Windows.Forms.TabPage()
        Me.Face4 = New System.Windows.Forms.Button()
        Me.Face3 = New System.Windows.Forms.Button()
        Me.Face2 = New System.Windows.Forms.Button()
        Me.Face1 = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.MusicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.reminderTimer = New System.Windows.Forms.Timer(Me.components)
        Me.calendarTitle = New System.Windows.Forms.Label()
        Me.weekButton = New System.Windows.Forms.Button()
        Me.dayButton = New System.Windows.Forms.Button()
        Me.MainTabControl.SuspendLayout()
        Me.Main.SuspendLayout()
        CType(Me.WatchBgImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Music.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clock.SuspendLayout()
        Me.Calendar.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Disrupt.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Playlist.SuspendLayout()
        CType(Me.PlaylistIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaylistIcon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhoneBook.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CallPage.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Reminder.SuspendLayout()
        Me.Faces.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.Main)
        Me.MainTabControl.Controls.Add(Me.Music)
        Me.MainTabControl.Controls.Add(Me.Clock)
        Me.MainTabControl.Controls.Add(Me.Calendar)
        Me.MainTabControl.Controls.Add(Me.Disrupt)
        Me.MainTabControl.Controls.Add(Me.Playlist)
        Me.MainTabControl.Controls.Add(Me.PhoneBook)
        Me.MainTabControl.Controls.Add(Me.CallPage)
        Me.MainTabControl.Controls.Add(Me.Reminder)
        Me.MainTabControl.Controls.Add(Me.Faces)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 1)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(161, 180)
        Me.MainTabControl.TabIndex = 2
        '
        'Main
        '
        Me.Main.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Main.Controls.Add(Me.ClockButton)
        Me.Main.Controls.Add(Me.callButton)
        Me.Main.Controls.Add(Me.CalendarButton)
        Me.Main.Controls.Add(Me.MusicButton)
        Me.Main.Controls.Add(Me.WatchBgImg)
        Me.Main.Location = New System.Drawing.Point(4, 22)
        Me.Main.Name = "Main"
        Me.Main.Padding = New System.Windows.Forms.Padding(3)
        Me.Main.Size = New System.Drawing.Size(153, 154)
        Me.Main.TabIndex = 0
        Me.Main.Text = "Main"
        Me.Main.UseVisualStyleBackColor = True
        '
        'ClockButton
        '
        Me.ClockButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_10_512
        Me.ClockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClockButton.Location = New System.Drawing.Point(6, 93)
        Me.ClockButton.Name = "ClockButton"
        Me.ClockButton.Size = New System.Drawing.Size(50, 50)
        Me.ClockButton.TabIndex = 5
        Me.ClockButton.UseVisualStyleBackColor = True
        '
        'callButton
        '
        Me.callButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.phone_icon
        Me.callButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.callButton.Location = New System.Drawing.Point(80, 93)
        Me.callButton.Name = "callButton"
        Me.callButton.Size = New System.Drawing.Size(50, 50)
        Me.callButton.TabIndex = 4
        Me.callButton.UseVisualStyleBackColor = True
        '
        'CalendarButton
        '
        Me.CalendarButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.calendar_icon
        Me.CalendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CalendarButton.Location = New System.Drawing.Point(8, 20)
        Me.CalendarButton.Name = "CalendarButton"
        Me.CalendarButton.Size = New System.Drawing.Size(50, 50)
        Me.CalendarButton.TabIndex = 3
        Me.CalendarButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.music_icon
        Me.MusicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MusicButton.Location = New System.Drawing.Point(80, 20)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(50, 50)
        Me.MusicButton.TabIndex = 2
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'WatchBgImg
        '
        Me.WatchBgImg.Image = Global.KidWatch.My.Resources.Resources.blue
        Me.WatchBgImg.Location = New System.Drawing.Point(0, 0)
        Me.WatchBgImg.Name = "WatchBgImg"
        Me.WatchBgImg.Size = New System.Drawing.Size(157, 151)
        Me.WatchBgImg.TabIndex = 0
        Me.WatchBgImg.TabStop = False
        '
        'Music
        '
        Me.Music.Controls.Add(Me.RepeatButton)
        Me.Music.Controls.Add(Me.ShufftleButton)
        Me.Music.Controls.Add(Me.PlaylistButton)
        Me.Music.Controls.Add(Me.PreviousButton)
        Me.Music.Controls.Add(Me.NextButton)
        Me.Music.Controls.Add(Me.NowPlaying)
        Me.Music.Controls.Add(Me.PlayButton)
        Me.Music.Controls.Add(Me.PictureBox3)
        Me.Music.Location = New System.Drawing.Point(4, 22)
        Me.Music.Name = "Music"
        Me.Music.Padding = New System.Windows.Forms.Padding(3)
        Me.Music.Size = New System.Drawing.Size(153, 154)
        Me.Music.TabIndex = 1
        Me.Music.Text = "Music"
        Me.Music.UseVisualStyleBackColor = True
        '
        'RepeatButton
        '
        Me.RepeatButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.repeat_512_green
        Me.RepeatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RepeatButton.Location = New System.Drawing.Point(10, 110)
        Me.RepeatButton.Name = "RepeatButton"
        Me.RepeatButton.Size = New System.Drawing.Size(30, 30)
        Me.RepeatButton.TabIndex = 7
        Me.RepeatButton.UseVisualStyleBackColor = True
        '
        'ShufftleButton
        '
        Me.ShufftleButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.shuffle_512_green
        Me.ShufftleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShufftleButton.Location = New System.Drawing.Point(110, 110)
        Me.ShufftleButton.Name = "ShufftleButton"
        Me.ShufftleButton.Size = New System.Drawing.Size(30, 30)
        Me.ShufftleButton.TabIndex = 6
        Me.ShufftleButton.UseVisualStyleBackColor = True
        '
        'PlaylistButton
        '
        Me.PlaylistButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.activity_feed_512
        Me.PlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaylistButton.Location = New System.Drawing.Point(60, 110)
        Me.PlaylistButton.Name = "PlaylistButton"
        Me.PlaylistButton.Size = New System.Drawing.Size(30, 30)
        Me.PlaylistButton.TabIndex = 5
        Me.PlaylistButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.previous_512
        Me.PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PreviousButton.Location = New System.Drawing.Point(10, 60)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(30, 30)
        Me.PreviousButton.TabIndex = 4
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.next_512
        Me.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextButton.Location = New System.Drawing.Point(110, 60)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(30, 30)
        Me.NextButton.TabIndex = 3
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'NowPlaying
        '
        Me.NowPlaying.AutoSize = True
        Me.NowPlaying.Location = New System.Drawing.Point(3, 17)
        Me.NowPlaying.Name = "NowPlaying"
        Me.NowPlaying.Size = New System.Drawing.Size(44, 13)
        Me.NowPlaying.TabIndex = 2
        Me.NowPlaying.Text = "Playing:"
        Me.NowPlaying.Visible = False
        '
        'PlayButton
        '
        Me.PlayButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.play_512
        Me.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayButton.Location = New System.Drawing.Point(50, 47)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(50, 50)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.KidWatch.My.Resources.Resources.blue
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(151, 151)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Clock
        '
        Me.Clock.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.Clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Clock.Controls.Add(Me.ChangeFace)
        Me.Clock.Controls.Add(Me.ClockDate)
        Me.Clock.Controls.Add(Me.ClockTime)
        Me.Clock.Location = New System.Drawing.Point(4, 22)
        Me.Clock.Name = "Clock"
        Me.Clock.Padding = New System.Windows.Forms.Padding(3)
        Me.Clock.Size = New System.Drawing.Size(153, 154)
        Me.Clock.TabIndex = 2
        Me.Clock.Text = "Clock"
        Me.Clock.UseVisualStyleBackColor = True
        '
        'ChangeFace
        '
        Me.ChangeFace.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_6_512_black
        Me.ChangeFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChangeFace.Location = New System.Drawing.Point(104, 105)
        Me.ChangeFace.Name = "ChangeFace"
        Me.ChangeFace.Size = New System.Drawing.Size(35, 35)
        Me.ChangeFace.TabIndex = 3
        Me.ChangeFace.UseVisualStyleBackColor = True
        '
        'ClockDate
        '
        Me.ClockDate.AutoSize = True
        Me.ClockDate.BackColor = System.Drawing.Color.Transparent
        Me.ClockDate.Location = New System.Drawing.Point(33, 20)
        Me.ClockDate.Name = "ClockDate"
        Me.ClockDate.Size = New System.Drawing.Size(86, 13)
        Me.ClockDate.TabIndex = 2
        Me.ClockDate.Text = "Monday Nov. 16"
        '
        'ClockTime
        '
        Me.ClockTime.AutoSize = True
        Me.ClockTime.BackColor = System.Drawing.Color.Transparent
        Me.ClockTime.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockTime.Location = New System.Drawing.Point(37, 50)
        Me.ClockTime.Name = "ClockTime"
        Me.ClockTime.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ClockTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClockTime.Size = New System.Drawing.Size(79, 54)
        Me.ClockTime.TabIndex = 1
        Me.ClockTime.Text = "7:45"
        Me.ClockTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Calendar
        '
        Me.Calendar.Controls.Add(Me.dayButton)
        Me.Calendar.Controls.Add(Me.eventTime)
        Me.Calendar.Controls.Add(Me.eventName)
        Me.Calendar.Controls.Add(Me.dayEventTime2)
        Me.Calendar.Controls.Add(Me.dayEventName2)
        Me.Calendar.Controls.Add(Me.dayEventTime1)
        Me.Calendar.Controls.Add(Me.dayEventName1)
        Me.Calendar.Controls.Add(Me.day7Button)
        Me.Calendar.Controls.Add(Me.day6Button)
        Me.Calendar.Controls.Add(Me.day5Button)
        Me.Calendar.Controls.Add(Me.day4Button)
        Me.Calendar.Controls.Add(Me.day3Button)
        Me.Calendar.Controls.Add(Me.day2Button)
        Me.Calendar.Controls.Add(Me.day1Button)
        Me.Calendar.Controls.Add(Me.weekButton)
        Me.Calendar.Controls.Add(Me.calendarTitle)
        Me.Calendar.Controls.Add(Me.PictureBox5)
        Me.Calendar.Location = New System.Drawing.Point(4, 22)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.Padding = New System.Windows.Forms.Padding(3)
        Me.Calendar.Size = New System.Drawing.Size(153, 154)
        Me.Calendar.TabIndex = 3
        Me.Calendar.Text = "Calendar"
        Me.Calendar.UseVisualStyleBackColor = True
        '
        'eventTime
        '
        Me.eventTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventTime.Location = New System.Drawing.Point(8, 96)
        Me.eventTime.Name = "eventTime"
        Me.eventTime.Size = New System.Drawing.Size(131, 23)
        Me.eventTime.TabIndex = 19
        Me.eventTime.Text = "10:45 PM"
        Me.eventTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.eventTime.Visible = False
        '
        'eventName
        '
        Me.eventName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventName.Location = New System.Drawing.Point(9, 55)
        Me.eventName.Name = "eventName"
        Me.eventName.Size = New System.Drawing.Size(131, 39)
        Me.eventName.TabIndex = 18
        Me.eventName.Text = "karate time"
        Me.eventName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.eventName.Visible = False
        '
        'dayEventTime2
        '
        Me.dayEventTime2.AutoSize = True
        Me.dayEventTime2.Location = New System.Drawing.Point(6, 119)
        Me.dayEventTime2.Name = "dayEventTime2"
        Me.dayEventTime2.Size = New System.Drawing.Size(34, 13)
        Me.dayEventTime2.TabIndex = 17
        Me.dayEventTime2.Text = "10:45"
        Me.dayEventTime2.Visible = False
        '
        'dayEventName2
        '
        Me.dayEventName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayEventName2.Location = New System.Drawing.Point(6, 94)
        Me.dayEventName2.MaximumSize = New System.Drawing.Size(134, 25)
        Me.dayEventName2.Name = "dayEventName2"
        Me.dayEventName2.Size = New System.Drawing.Size(134, 25)
        Me.dayEventName2.TabIndex = 16
        Me.dayEventName2.Text = "bedtime"
        Me.dayEventName2.Visible = False
        '
        'dayEventTime1
        '
        Me.dayEventTime1.AutoSize = True
        Me.dayEventTime1.Location = New System.Drawing.Point(6, 65)
        Me.dayEventTime1.Name = "dayEventTime1"
        Me.dayEventTime1.Size = New System.Drawing.Size(34, 13)
        Me.dayEventTime1.TabIndex = 15
        Me.dayEventTime1.Text = "10:45"
        Me.dayEventTime1.Visible = False
        '
        'dayEventName1
        '
        Me.dayEventName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayEventName1.Location = New System.Drawing.Point(6, 40)
        Me.dayEventName1.MaximumSize = New System.Drawing.Size(134, 25)
        Me.dayEventName1.Name = "dayEventName1"
        Me.dayEventName1.Size = New System.Drawing.Size(134, 25)
        Me.dayEventName1.TabIndex = 14
        Me.dayEventName1.Text = "pizza at roccos"
        Me.dayEventName1.Visible = False
        '
        'day7Button
        '
        Me.day7Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day7Button.FlatAppearance.BorderSize = 0
        Me.day7Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day7Button.Location = New System.Drawing.Point(124, 40)
        Me.day7Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day7Button.Name = "day7Button"
        Me.day7Button.Size = New System.Drawing.Size(20, 110)
        Me.day7Button.TabIndex = 13
        Me.day7Button.Tag = "7"
        Me.day7Button.Text = "S 0"
        Me.day7Button.UseVisualStyleBackColor = False
        '
        'day6Button
        '
        Me.day6Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day6Button.FlatAppearance.BorderSize = 0
        Me.day6Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day6Button.Location = New System.Drawing.Point(104, 40)
        Me.day6Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day6Button.Name = "day6Button"
        Me.day6Button.Size = New System.Drawing.Size(20, 110)
        Me.day6Button.TabIndex = 12
        Me.day6Button.Tag = "6"
        Me.day6Button.Text = "F 1"
        Me.day6Button.UseVisualStyleBackColor = False
        '
        'day5Button
        '
        Me.day5Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day5Button.FlatAppearance.BorderSize = 0
        Me.day5Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day5Button.Location = New System.Drawing.Point(84, 40)
        Me.day5Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day5Button.Name = "day5Button"
        Me.day5Button.Size = New System.Drawing.Size(20, 110)
        Me.day5Button.TabIndex = 11
        Me.day5Button.Tag = "5"
        Me.day5Button.Text = "T 2"
        Me.day5Button.UseVisualStyleBackColor = False
        '
        'day4Button
        '
        Me.day4Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day4Button.FlatAppearance.BorderSize = 0
        Me.day4Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day4Button.Location = New System.Drawing.Point(64, 40)
        Me.day4Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day4Button.Name = "day4Button"
        Me.day4Button.Size = New System.Drawing.Size(20, 110)
        Me.day4Button.TabIndex = 10
        Me.day4Button.Tag = "4"
        Me.day4Button.Text = "W 0"
        Me.day4Button.UseVisualStyleBackColor = False
        '
        'day3Button
        '
        Me.day3Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day3Button.FlatAppearance.BorderSize = 0
        Me.day3Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day3Button.Location = New System.Drawing.Point(44, 40)
        Me.day3Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day3Button.Name = "day3Button"
        Me.day3Button.Size = New System.Drawing.Size(20, 110)
        Me.day3Button.TabIndex = 9
        Me.day3Button.Tag = "3"
        Me.day3Button.Text = "T 1"
        Me.day3Button.UseVisualStyleBackColor = False
        '
        'day2Button
        '
        Me.day2Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day2Button.FlatAppearance.BorderSize = 0
        Me.day2Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day2Button.Location = New System.Drawing.Point(24, 40)
        Me.day2Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day2Button.Name = "day2Button"
        Me.day2Button.Size = New System.Drawing.Size(20, 110)
        Me.day2Button.TabIndex = 8
        Me.day2Button.Tag = "2"
        Me.day2Button.Text = "M 1"
        Me.day2Button.UseVisualStyleBackColor = False
        '
        'day1Button
        '
        Me.day1Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day1Button.FlatAppearance.BorderSize = 0
        Me.day1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day1Button.Location = New System.Drawing.Point(4, 40)
        Me.day1Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day1Button.Name = "day1Button"
        Me.day1Button.Size = New System.Drawing.Size(20, 110)
        Me.day1Button.TabIndex = 7
        Me.day1Button.Tag = "1"
        Me.day1Button.Text = "S 0"
        Me.day1Button.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.KidWatch.My.Resources.Resources.blue
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(151, 151)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Disrupt
        '
        Me.Disrupt.Controls.Add(Me.PictureBox2)
        Me.Disrupt.Location = New System.Drawing.Point(4, 22)
        Me.Disrupt.Name = "Disrupt"
        Me.Disrupt.Padding = New System.Windows.Forms.Padding(3)
        Me.Disrupt.Size = New System.Drawing.Size(153, 154)
        Me.Disrupt.TabIndex = 4
        Me.Disrupt.Text = "Disrupt"
        Me.Disrupt.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.KidWatch.My.Resources.Resources.blue
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(151, 151)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Playlist
        '
        Me.Playlist.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.Playlist.Controls.Add(Me.PlaylistIcon2)
        Me.Playlist.Controls.Add(Me.PlaylistIcon1)
        Me.Playlist.Controls.Add(Me.Playlist2)
        Me.Playlist.Controls.Add(Me.Playlist1)
        Me.Playlist.Location = New System.Drawing.Point(4, 22)
        Me.Playlist.Name = "Playlist"
        Me.Playlist.Padding = New System.Windows.Forms.Padding(3)
        Me.Playlist.Size = New System.Drawing.Size(153, 154)
        Me.Playlist.TabIndex = 5
        Me.Playlist.Text = "Playlist"
        Me.Playlist.UseVisualStyleBackColor = True
        '
        'PlaylistIcon2
        '
        Me.PlaylistIcon2.BackgroundImage = Global.KidWatch.My.Resources.Resources.video_5_512
        Me.PlaylistIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaylistIcon2.Location = New System.Drawing.Point(21, 72)
        Me.PlaylistIcon2.Name = "PlaylistIcon2"
        Me.PlaylistIcon2.Size = New System.Drawing.Size(30, 30)
        Me.PlaylistIcon2.TabIndex = 3
        Me.PlaylistIcon2.TabStop = False
        '
        'PlaylistIcon1
        '
        Me.PlaylistIcon1.BackgroundImage = Global.KidWatch.My.Resources.Resources.star_6_512
        Me.PlaylistIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaylistIcon1.Location = New System.Drawing.Point(21, 36)
        Me.PlaylistIcon1.Name = "PlaylistIcon1"
        Me.PlaylistIcon1.Size = New System.Drawing.Size(30, 30)
        Me.PlaylistIcon1.TabIndex = 2
        Me.PlaylistIcon1.TabStop = False
        '
        'Playlist2
        '
        Me.Playlist2.AutoSize = True
        Me.Playlist2.Location = New System.Drawing.Point(53, 44)
        Me.Playlist2.Name = "Playlist2"
        Me.Playlist2.Size = New System.Drawing.Size(84, 13)
        Me.Playlist2.TabIndex = 1
        Me.Playlist2.Text = "Favourite Songs"
        '
        'Playlist1
        '
        Me.Playlist1.AutoSize = True
        Me.Playlist1.Location = New System.Drawing.Point(53, 79)
        Me.Playlist1.Name = "Playlist1"
        Me.Playlist1.Size = New System.Drawing.Size(39, 13)
        Me.Playlist1.TabIndex = 0
        Me.Playlist1.Text = "Disney"
        '
        'PhoneBook
        '
        Me.PhoneBook.Controls.Add(Me.PictureBox6)
        Me.PhoneBook.Controls.Add(Me.CallJesBtn)
        Me.PhoneBook.Controls.Add(Me.CallThomasBtn)
        Me.PhoneBook.Controls.Add(Me.CallDadBtn)
        Me.PhoneBook.Controls.Add(Me.CallMomBtn)
        Me.PhoneBook.Controls.Add(Me.VScrollBar1)
        Me.PhoneBook.Location = New System.Drawing.Point(4, 22)
        Me.PhoneBook.Name = "PhoneBook"
        Me.PhoneBook.Padding = New System.Windows.Forms.Padding(3)
        Me.PhoneBook.Size = New System.Drawing.Size(153, 154)
        Me.PhoneBook.TabIndex = 6
        Me.PhoneBook.Text = "PhoneBook"
        Me.PhoneBook.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.KidWatch.My.Resources.Resources.phone_icon
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(47, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 27)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'CallJesBtn
        '
        Me.CallJesBtn.Location = New System.Drawing.Point(0, 120)
        Me.CallJesBtn.Name = "CallJesBtn"
        Me.CallJesBtn.Size = New System.Drawing.Size(125, 23)
        Me.CallJesBtn.TabIndex = 4
        Me.CallJesBtn.Text = "Jessica"
        Me.CallJesBtn.UseVisualStyleBackColor = True
        '
        'CallThomasBtn
        '
        Me.CallThomasBtn.Location = New System.Drawing.Point(0, 91)
        Me.CallThomasBtn.Name = "CallThomasBtn"
        Me.CallThomasBtn.Size = New System.Drawing.Size(125, 23)
        Me.CallThomasBtn.TabIndex = 3
        Me.CallThomasBtn.Text = "Thomas"
        Me.CallThomasBtn.UseVisualStyleBackColor = True
        '
        'CallDadBtn
        '
        Me.CallDadBtn.Location = New System.Drawing.Point(0, 62)
        Me.CallDadBtn.Name = "CallDadBtn"
        Me.CallDadBtn.Size = New System.Drawing.Size(125, 23)
        Me.CallDadBtn.TabIndex = 2
        Me.CallDadBtn.Text = "Dad"
        Me.CallDadBtn.UseVisualStyleBackColor = True
        '
        'CallMomBtn
        '
        Me.CallMomBtn.Location = New System.Drawing.Point(0, 33)
        Me.CallMomBtn.Name = "CallMomBtn"
        Me.CallMomBtn.Size = New System.Drawing.Size(125, 23)
        Me.CallMomBtn.TabIndex = 1
        Me.CallMomBtn.Text = "Mom"
        Me.CallMomBtn.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Enabled = False
        Me.VScrollBar1.Location = New System.Drawing.Point(128, 3)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(22, 151)
        Me.VScrollBar1.TabIndex = 0
        '
        'CallPage
        '
        Me.CallPage.Controls.Add(Me.HangUpBtn)
        Me.CallPage.Controls.Add(Me.AcceptBtn)
        Me.CallPage.Controls.Add(Me.CallTitle)
        Me.CallPage.Controls.Add(Me.PictureBox7)
        Me.CallPage.Location = New System.Drawing.Point(4, 22)
        Me.CallPage.Name = "CallPage"
        Me.CallPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CallPage.Size = New System.Drawing.Size(153, 154)
        Me.CallPage.TabIndex = 7
        Me.CallPage.Text = "CallPage"
        Me.CallPage.UseVisualStyleBackColor = True
        '
        'HangUpBtn
        '
        Me.HangUpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HangUpBtn.ForeColor = System.Drawing.Color.Red
        Me.HangUpBtn.Location = New System.Drawing.Point(0, 125)
        Me.HangUpBtn.Name = "HangUpBtn"
        Me.HangUpBtn.Size = New System.Drawing.Size(147, 23)
        Me.HangUpBtn.TabIndex = 3
        Me.HangUpBtn.Text = "Hang Up"
        Me.HangUpBtn.UseVisualStyleBackColor = True
        '
        'AcceptBtn
        '
        Me.AcceptBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceptBtn.ForeColor = System.Drawing.Color.Green
        Me.AcceptBtn.Location = New System.Drawing.Point(0, 99)
        Me.AcceptBtn.Name = "AcceptBtn"
        Me.AcceptBtn.Size = New System.Drawing.Size(147, 23)
        Me.AcceptBtn.TabIndex = 2
        Me.AcceptBtn.Text = "Accept"
        Me.AcceptBtn.UseVisualStyleBackColor = True
        Me.AcceptBtn.Visible = False
        '
        'CallTitle
        '
        Me.CallTitle.AutoSize = True
        Me.CallTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallTitle.Location = New System.Drawing.Point(8, 14)
        Me.CallTitle.Name = "CallTitle"
        Me.CallTitle.Size = New System.Drawing.Size(106, 20)
        Me.CallTitle.TabIndex = 0
        Me.CallTitle.Text = "Calling Mom"
        Me.CallTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.KidWatch.My.Resources.Resources.phone_icon
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(0, 37)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(153, 56)
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'Reminder
        '
        Me.Reminder.Controls.Add(Me.dismissReminder)
        Me.Reminder.Controls.Add(Me.Label4)
        Me.Reminder.Controls.Add(Me.Label3)
        Me.Reminder.Controls.Add(Me.Label2)
        Me.Reminder.Location = New System.Drawing.Point(4, 22)
        Me.Reminder.Name = "Reminder"
        Me.Reminder.Size = New System.Drawing.Size(153, 154)
        Me.Reminder.TabIndex = 8
        Me.Reminder.Text = "Reminder"
        Me.Reminder.UseVisualStyleBackColor = True
        '
        'dismissReminder
        '
        Me.dismissReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dismissReminder.Location = New System.Drawing.Point(8, 120)
        Me.dismissReminder.Name = "dismissReminder"
        Me.dismissReminder.Size = New System.Drawing.Size(134, 23)
        Me.dismissReminder.TabIndex = 3
        Me.dismissReminder.Text = "Dismiss"
        Me.dismissReminder.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "happening now!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 61)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Meet Jason to exchange pokemon cards outside of gym"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Event Reminder"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Faces
        '
        Me.Faces.Controls.Add(Me.Face4)
        Me.Faces.Controls.Add(Me.Face3)
        Me.Faces.Controls.Add(Me.Face2)
        Me.Faces.Controls.Add(Me.Face1)
        Me.Faces.Location = New System.Drawing.Point(4, 22)
        Me.Faces.Name = "Faces"
        Me.Faces.Padding = New System.Windows.Forms.Padding(3)
        Me.Faces.Size = New System.Drawing.Size(153, 154)
        Me.Faces.TabIndex = 9
        Me.Faces.Text = "Faces"
        Me.Faces.UseVisualStyleBackColor = True
        '
        'Face4
        '
        Me.Face4.BackgroundImage = Global.KidWatch.My.Resources.Resources._1291876726031
        Me.Face4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Face4.Location = New System.Drawing.Point(84, 84)
        Me.Face4.Name = "Face4"
        Me.Face4.Size = New System.Drawing.Size(50, 50)
        Me.Face4.TabIndex = 3
        Me.Face4.UseVisualStyleBackColor = True
        '
        'Face3
        '
        Me.Face3.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_6_512_blue
        Me.Face3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Face3.Location = New System.Drawing.Point(15, 84)
        Me.Face3.Name = "Face3"
        Me.Face3.Size = New System.Drawing.Size(50, 50)
        Me.Face3.TabIndex = 2
        Me.Face3.UseVisualStyleBackColor = True
        '
        'Face2
        '
        Me.Face2.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_6_512_black
        Me.Face2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Face2.Location = New System.Drawing.Point(84, 20)
        Me.Face2.Name = "Face2"
        Me.Face2.Size = New System.Drawing.Size(50, 50)
        Me.Face2.TabIndex = 1
        Me.Face2.UseVisualStyleBackColor = True
        '
        'Face1
        '
        Me.Face1.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_6_512_red
        Me.Face1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Face1.Location = New System.Drawing.Point(15, 19)
        Me.Face1.Name = "Face1"
        Me.Face1.Size = New System.Drawing.Size(50, 50)
        Me.Face1.TabIndex = 0
        Me.Face1.UseVisualStyleBackColor = True
        '
        'HomeBtn
        '
        Me.HomeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Location = New System.Drawing.Point(148, 43)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(26, 23)
        Me.HomeBtn.TabIndex = 3
        Me.HomeBtn.Text = "<|"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'MusicTimer
        '
        '
        'ClockTimer
        '
        '
        'reminderTimer
        '
        Me.reminderTimer.Enabled = True
        Me.reminderTimer.Interval = 1000
        '
        'calendarTitle
        '
        Me.calendarTitle.AutoSize = True
        Me.calendarTitle.Location = New System.Drawing.Point(6, 13)
        Me.calendarTitle.Name = "calendarTitle"
        Me.calendarTitle.Size = New System.Drawing.Size(72, 13)
        Me.calendarTitle.TabIndex = 2
        Me.calendarTitle.Text = "Choose a day"
        '
        'weekButton
        '
        Me.weekButton.Location = New System.Drawing.Point(91, 9)
        Me.weekButton.Name = "weekButton"
        Me.weekButton.Size = New System.Drawing.Size(54, 23)
        Me.weekButton.TabIndex = 3
        Me.weekButton.Text = "Week"
        Me.weekButton.UseVisualStyleBackColor = True
        Me.weekButton.Visible = False
        '
        'dayButton
        '
        Me.dayButton.Location = New System.Drawing.Point(91, 9)
        Me.dayButton.Name = "dayButton"
        Me.dayButton.Size = New System.Drawing.Size(54, 23)
        Me.dayButton.TabIndex = 20
        Me.dayButton.Text = "Day"
        Me.dayButton.UseVisualStyleBackColor = True
        Me.dayButton.Visible = False
        '
        'KidWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(167, 178)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.MainTabControl)
        Me.DoubleBuffered = True
        Me.Name = "KidWatch"
        Me.Text = "KidWatch"
        Me.MainTabControl.ResumeLayout(False)
        Me.Main.ResumeLayout(False)
        CType(Me.WatchBgImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Music.ResumeLayout(False)
        Me.Music.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clock.ResumeLayout(False)
        Me.Clock.PerformLayout()
        Me.Calendar.ResumeLayout(False)
        Me.Calendar.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Disrupt.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Playlist.ResumeLayout(False)
        Me.Playlist.PerformLayout()
        CType(Me.PlaylistIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaylistIcon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhoneBook.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CallPage.ResumeLayout(False)
        Me.CallPage.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Reminder.ResumeLayout(False)
        Me.Faces.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents Main As System.Windows.Forms.TabPage
    Friend WithEvents Music As System.Windows.Forms.TabPage
    Friend WithEvents Clock As System.Windows.Forms.TabPage
    Friend WithEvents Calendar As System.Windows.Forms.TabPage
    Friend WithEvents Disrupt As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents MusicButton As System.Windows.Forms.Button
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents NowPlaying As System.Windows.Forms.Label
    Friend WithEvents PlaylistButton As System.Windows.Forms.Button
    Friend WithEvents RepeatButton As System.Windows.Forms.Button
    Friend WithEvents ShufftleButton As System.Windows.Forms.Button
    Friend WithEvents CalendarButton As System.Windows.Forms.Button
    Friend WithEvents MusicTimer As System.Windows.Forms.Timer
    Friend WithEvents callButton As System.Windows.Forms.Button
    Friend WithEvents ClockTime As System.Windows.Forms.Label
    Friend WithEvents ClockTimer As System.Windows.Forms.Timer
    Friend WithEvents ClockDate As System.Windows.Forms.Label
    Friend WithEvents Playlist As System.Windows.Forms.TabPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents day7Button As System.Windows.Forms.Button
    Friend WithEvents day6Button As System.Windows.Forms.Button
    Friend WithEvents day5Button As System.Windows.Forms.Button
    Friend WithEvents day4Button As System.Windows.Forms.Button
    Friend WithEvents day3Button As System.Windows.Forms.Button
    Friend WithEvents day2Button As System.Windows.Forms.Button
    Friend WithEvents day1Button As System.Windows.Forms.Button
    Friend WithEvents dayEventTime2 As System.Windows.Forms.Label
    Friend WithEvents dayEventName2 As System.Windows.Forms.Label
    Friend WithEvents dayEventTime1 As System.Windows.Forms.Label
    Friend WithEvents dayEventName1 As System.Windows.Forms.Label
    Friend WithEvents eventName As System.Windows.Forms.Label
    Friend WithEvents eventTime As System.Windows.Forms.Label
    Friend WithEvents PhoneBook As System.Windows.Forms.TabPage
    Friend WithEvents CallDadBtn As System.Windows.Forms.Button
    Friend WithEvents CallMomBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents CallJesBtn As System.Windows.Forms.Button
    Friend WithEvents CallThomasBtn As System.Windows.Forms.Button
    Friend WithEvents CallPage As System.Windows.Forms.TabPage
    Friend WithEvents HangUpBtn As System.Windows.Forms.Button
    Friend WithEvents AcceptBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents CallTitle As System.Windows.Forms.Label
    Friend WithEvents ClockButton As System.Windows.Forms.Button
    Friend WithEvents reminderTimer As System.Windows.Forms.Timer
    Friend WithEvents Reminder As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dismissReminder As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HomeBtn As System.Windows.Forms.Button
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents ChangeFace As System.Windows.Forms.Button
    Friend WithEvents PlaylistIcon1 As System.Windows.Forms.PictureBox
    Friend WithEvents Playlist2 As System.Windows.Forms.Label
    Friend WithEvents Playlist1 As System.Windows.Forms.Label
    Friend WithEvents Faces As System.Windows.Forms.TabPage
    Friend WithEvents WatchBgImg As System.Windows.Forms.PictureBox
    Friend WithEvents Face1 As System.Windows.Forms.Button
    Friend WithEvents Face4 As System.Windows.Forms.Button
    Friend WithEvents Face3 As System.Windows.Forms.Button
    Friend WithEvents Face2 As System.Windows.Forms.Button
    Friend WithEvents PlaylistIcon2 As System.Windows.Forms.PictureBox
    Friend WithEvents dayButton As System.Windows.Forms.Button
    Friend WithEvents weekButton As System.Windows.Forms.Button
    Friend WithEvents calendarTitle As System.Windows.Forms.Label

End Class
