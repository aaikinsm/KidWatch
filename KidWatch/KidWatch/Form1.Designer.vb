﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Calendar = New System.Windows.Forms.TabPage()
        Me.createEventButton = New System.Windows.Forms.Button()
        Me.eventNameBox = New System.Windows.Forms.TextBox()
        Me.eventLabel = New System.Windows.Forms.Label()
        Me.eventName = New System.Windows.Forms.Label()
        Me.calendarLabel = New System.Windows.Forms.Label()
        Me.CalendarPicker = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Disrupt = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Playlist = New System.Windows.Forms.TabPage()
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
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.CallTitle = New System.Windows.Forms.Label()
        Me.MusicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ClockButton = New System.Windows.Forms.Button()
        Me.MainTabControl.SuspendLayout()
        Me.Main.SuspendLayout()
        CType(Me.WatchBgImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Music.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clock.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Calendar.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Disrupt.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhoneBook.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CallPage.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MainTabControl.Location = New System.Drawing.Point(0, 1)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(161, 180)
        Me.MainTabControl.TabIndex = 2
        '
        'Main
        '
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
        'callButton
        '
        Me.callButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.phone_icon
        Me.callButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.callButton.Location = New System.Drawing.Point(54, 116)
        Me.callButton.Name = "callButton"
        Me.callButton.Size = New System.Drawing.Size(50, 50)
        Me.callButton.TabIndex = 4
        Me.callButton.UseVisualStyleBackColor = True
        '
        'CalendarButton
        '
        Me.CalendarButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.calendar_icon
        Me.CalendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CalendarButton.Location = New System.Drawing.Point(54, -22)
        Me.CalendarButton.Name = "CalendarButton"
        Me.CalendarButton.Size = New System.Drawing.Size(50, 50)
        Me.CalendarButton.TabIndex = 3
        Me.CalendarButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.music_icon
        Me.MusicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MusicButton.Location = New System.Drawing.Point(54, 47)
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
        Me.WatchBgImg.Size = New System.Drawing.Size(151, 151)
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
        Me.Clock.Controls.Add(Me.Label1)
        Me.Clock.Controls.Add(Me.time)
        Me.Clock.Controls.Add(Me.PictureBox4)
        Me.Clock.Location = New System.Drawing.Point(4, 22)
        Me.Clock.Name = "Clock"
        Me.Clock.Padding = New System.Windows.Forms.Padding(3)
        Me.Clock.Size = New System.Drawing.Size(153, 154)
        Me.Clock.TabIndex = 2
        Me.Clock.Text = "Clock"
        Me.Clock.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Monday Nov. 16"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.BackColor = System.Drawing.Color.White
        Me.time.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.Location = New System.Drawing.Point(20, 45)
        Me.time.Name = "time"
        Me.time.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.time.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.time.Size = New System.Drawing.Size(79, 54)
        Me.time.TabIndex = 1
        Me.time.Text = "7:45"
        Me.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.KidWatch.My.Resources.Resources.blue
        Me.PictureBox4.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(154, 155)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Calendar
        '
        Me.Calendar.Controls.Add(Me.createEventButton)
        Me.Calendar.Controls.Add(Me.eventNameBox)
        Me.Calendar.Controls.Add(Me.eventLabel)
        Me.Calendar.Controls.Add(Me.eventName)
        Me.Calendar.Controls.Add(Me.calendarLabel)
        Me.Calendar.Controls.Add(Me.CalendarPicker)
        Me.Calendar.Controls.Add(Me.PictureBox5)
        Me.Calendar.Location = New System.Drawing.Point(4, 22)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.Padding = New System.Windows.Forms.Padding(3)
        Me.Calendar.Size = New System.Drawing.Size(153, 154)
        Me.Calendar.TabIndex = 3
        Me.Calendar.Text = "Calendar"
        Me.Calendar.UseVisualStyleBackColor = True
        '
        'createEventButton
        '
        Me.createEventButton.Location = New System.Drawing.Point(35, 119)
        Me.createEventButton.Name = "createEventButton"
        Me.createEventButton.Size = New System.Drawing.Size(75, 23)
        Me.createEventButton.TabIndex = 6
        Me.createEventButton.Text = "Create"
        Me.createEventButton.UseVisualStyleBackColor = True
        '
        'eventNameBox
        '
        Me.eventNameBox.Location = New System.Drawing.Point(6, 93)
        Me.eventNameBox.Name = "eventNameBox"
        Me.eventNameBox.Size = New System.Drawing.Size(135, 20)
        Me.eventNameBox.TabIndex = 5
        '
        'eventLabel
        '
        Me.eventLabel.Location = New System.Drawing.Point(3, 42)
        Me.eventLabel.Name = "eventLabel"
        Me.eventLabel.Size = New System.Drawing.Size(141, 48)
        Me.eventLabel.TabIndex = 4
        Me.eventLabel.Text = "please enter the name of the event"
        '
        'eventName
        '
        Me.eventName.AutoSize = True
        Me.eventName.Location = New System.Drawing.Point(9, 46)
        Me.eventName.Name = "eventName"
        Me.eventName.Size = New System.Drawing.Size(0, 13)
        Me.eventName.TabIndex = 3
        '
        'calendarLabel
        '
        Me.calendarLabel.AutoSize = True
        Me.calendarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendarLabel.Location = New System.Drawing.Point(-2, 3)
        Me.calendarLabel.Name = "calendarLabel"
        Me.calendarLabel.Size = New System.Drawing.Size(153, 13)
        Me.calendarLabel.TabIndex = 2
        Me.calendarLabel.Text = "Pick a date to see events"
        '
        'CalendarPicker
        '
        Me.CalendarPicker.Location = New System.Drawing.Point(6, 19)
        Me.CalendarPicker.Name = "CalendarPicker"
        Me.CalendarPicker.Size = New System.Drawing.Size(138, 20)
        Me.CalendarPicker.TabIndex = 1
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
        Me.Playlist.Location = New System.Drawing.Point(4, 22)
        Me.Playlist.Name = "Playlist"
        Me.Playlist.Padding = New System.Windows.Forms.Padding(3)
        Me.Playlist.Size = New System.Drawing.Size(153, 154)
        Me.Playlist.TabIndex = 5
        Me.Playlist.Text = "Playlist"
        Me.Playlist.UseVisualStyleBackColor = True
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
        Me.VScrollBar1.Location = New System.Drawing.Point(128, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(22, 154)
        Me.VScrollBar1.TabIndex = 0
        '
        'CallPage
        '
        Me.CallPage.Controls.Add(Me.HangUpBtn)
        Me.CallPage.Controls.Add(Me.AcceptBtn)
        Me.CallPage.Controls.Add(Me.PictureBox7)
        Me.CallPage.Controls.Add(Me.CallTitle)
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
        'MusicTimer
        '
        '
        'ClockTimer
        '
        '
        'ClockButton
        '
        Me.ClockButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.clock
        Me.ClockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClockButton.Location = New System.Drawing.Point(54, 185)
        Me.ClockButton.Name = "ClockButton"
        Me.ClockButton.Size = New System.Drawing.Size(50, 50)
        Me.ClockButton.TabIndex = 5
        Me.ClockButton.UseVisualStyleBackColor = True
        '
        'KidWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(153, 178)
        Me.Controls.Add(Me.MainTabControl)
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
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Calendar.ResumeLayout(False)
        Me.Calendar.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Disrupt.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhoneBook.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CallPage.ResumeLayout(False)
        Me.CallPage.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents Main As System.Windows.Forms.TabPage
    Friend WithEvents Music As System.Windows.Forms.TabPage
    Friend WithEvents Clock As System.Windows.Forms.TabPage
    Friend WithEvents Calendar As System.Windows.Forms.TabPage
    Friend WithEvents Disrupt As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents WatchBgImg As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
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
    Friend WithEvents CalendarPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents calendarLabel As System.Windows.Forms.Label
    Friend WithEvents MusicTimer As System.Windows.Forms.Timer
    Friend WithEvents eventName As System.Windows.Forms.Label
    Friend WithEvents eventLabel As System.Windows.Forms.Label
    Friend WithEvents eventNameBox As System.Windows.Forms.TextBox
    Friend WithEvents createEventButton As System.Windows.Forms.Button
    Friend WithEvents callButton As System.Windows.Forms.Button
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents ClockTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Playlist As System.Windows.Forms.TabPage
    Friend WithEvents PhoneBook As System.Windows.Forms.TabPage
    Friend WithEvents CallDadBtn As System.Windows.Forms.Button
    Friend WithEvents CallMomBtn As System.Windows.Forms.Button
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents CallJesBtn As System.Windows.Forms.Button
    Friend WithEvents CallThomasBtn As System.Windows.Forms.Button
    Friend WithEvents CallPage As System.Windows.Forms.TabPage
    Friend WithEvents HangUpBtn As System.Windows.Forms.Button
    Friend WithEvents AcceptBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents CallTitle As System.Windows.Forms.Label
    Friend WithEvents ClockButton As System.Windows.Forms.Button

End Class
