﻿Imports System.Globalization

Public Class KidWatch

    '   _._ 
    '  /,,,\ 
    ' ()a,a() 
    ' (\_=_/) 
    ' (,._,.) 
    ' /( : )\ 
    '(( ) ( )) 
    ' \/"""\/       NOW THAT I HAVE YOUR ATTENTION!!
    ' '\ | /` 
    '  | | |        Here is the list of features we need to implement, 
    '  \_|_/ 
    ' _/| |\_       Remove the parts you are currently working on / already completed features 
    '                    from this list to avoid repetition
    '
    'General features
    '    Screen layouts include access to future features: playlists management, 
    '    configuration (1 each) 
    'Children Watch
    '    • Leave message (1), automatic redial (2)
    '    • Send voice(1), video(2) or picture (2) message
    '    • Receive message(1) and listen to/view it (2)
    '    • Review messages (1) and keep(1) or discard them (1)
    '    • Make watch non-disruptive/normal(1), non-disruptive options(1)
    'Parent's U.I.


    Const watchHeight As Integer = 195
    Const watchwidth As Integer = 170
    Private YOfsetCalendar As Integer = 0, YOfsetMusic As Integer = 0, YOfsetCall As Integer = 0, YOfsetClock As Integer = 0, YOfsetSend As Integer = 0, YOfsetMessages As Integer = 0
    Private clicked As Boolean = False
    Private locked As Boolean = True

    'Variables for music
    Dim playing As Boolean = False
    Dim shuffle As Boolean = False
    Dim repeat As Boolean = False
    Const MAXSONGS As Integer = 10
    Dim songs() As String = {"Zelda_A_Link_To_The_Past_Chest_Fanfare", "Luffy", "Zoro", "Nami", "Usopp", "Sanji", "Vivi", "Chopper", "Robin", "franky", "Brook Eyecatch", "Crochet d'oeil"}
    Dim songLength() As Double = {1.5, 6, 7, 7, 7, 8, 7, 6, 8, 7, 8, 10}
    Dim songName() As String = {"Chest", "Luffy", "Zoro", "Nami", "Usopp", "Sanji", "Vivi", "Chopper", "Robin", "Franky", "Brook", "Crochet d'oeil"}
    Dim songNumber As Integer = 0
    Dim currentSongLength As Double
    Dim shuffle_rn As New Random

    'Variables for calendar
    Dim eventsDict As New Dictionary(Of DateTime, String)
    Dim reminderCounter As Integer = 0
    Dim pastTabPage
    'Dim weekdayPictures() As PictureBox = Control.Find()

    'Main menu scroll
    Private Sub Menu_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseDown, MusicButton.MouseDown, callButton.MouseDown, WatchBgImg.MouseDown, MessagesButton.MouseDown, SendMessageButton.MouseDown
        clicked = True
        YOfsetCalendar = Cursor.Position.Y - CalendarButton.Location.Y
        YOfsetMusic = Cursor.Position.Y - MusicButton.Location.Y
        YOfsetCall = Cursor.Position.Y - callButton.Location.Y
        YOfsetClock = Cursor.Position.Y - ClockButton.Location.Y
        YOfsetMessages = Cursor.Position.Y - MessagesButton.Location.Y
        YOfsetSend = Cursor.Position.Y - SendMessageButton.Location.Y
    End Sub
    Private Sub Menu_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseMove, MusicButton.MouseMove, callButton.MouseMove, WatchBgImg.MouseMove
        If (clicked) Then
            CalendarButton.Location = New Drawing.Point(CalendarButton.Location.X, (Cursor.Position.Y - YOfsetCalendar))
            MusicButton.Location = New Drawing.Point(MusicButton.Location.X, (Cursor.Position.Y - YOfsetMusic))
            callButton.Location = New Drawing.Point(callButton.Location.X, (Cursor.Position.Y - YOfsetCall))
            ClockButton.Location = New Drawing.Point(ClockButton.Location.X, (Cursor.Position.Y - YOfsetClock))
            SendMessageButton.Location = New Drawing.Point(SendMessageButton.Location.X, (Cursor.Position.Y - YOfsetSend))
            MessagesButton.Location = New Drawing.Point(MessagesButton.Location.X, (Cursor.Position.Y - YOfsetMessages))
        End If
    End Sub
    Private Sub Menu_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseUp, MusicButton.MouseUp, callButton.MouseUp, WatchBgImg.MouseUp
        clicked = False
    End Sub
    'At Launch set dynamic paramters
    Private Sub KidWatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainTabControl.Appearance = TabAppearance.FlatButtons
        MainTabControl.ItemSize = New Size(0, 1)
        MainTabControl.SizeMode = TabSizeMode.Fixed
        MainTabControl.SelectedTab = Clock
        ClockTimer.Start()
        ParentUI.Show()
        Me.Size = New Size(watchwidth, watchHeight)
        Me.MaximumSize = New Size(watchwidth, watchHeight)
        HomeBtn.Location = New Point(watchwidth - 40, 10)
        Set_Date()
    End Sub
    'Sample tab switching
    Private Sub MusicButton_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        MainTabControl.SelectedTab = Music
    End Sub
    Private Sub CalendarButton_Click(sender As Object, e As EventArgs) Handles CalendarButton.Click
        MainTabControl.SelectedTab = Calendar
    End Sub
    Private Sub callButton_MouseClick(sender As Object, e As MouseEventArgs) Handles callButton.MouseClick
        MainTabControl.SelectedTab = PhoneBook
    End Sub
    Private Sub ClockPage_Click(sender As Object, e As EventArgs) Handles ClockTime.MouseClick
        MainTabControl.SelectedTab = Main
    End Sub
    Private Sub ClockButton_MouseClick(sender As Object, e As MouseEventArgs) Handles ClockButton.MouseClick
        MainTabControl.SelectedTab = Clock
    End Sub
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        MainTabControl.SelectedTab = Main
    End Sub
    Private Sub MessageButton_Click(sender As Object, e As EventArgs) Handles SendMessageButton.Click
        MainTabControl.SelectedTab = SendMessage
    End Sub

    Private Sub ReminderTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reminderTimer.Tick
        reminderCounter += 1
        'Console.WriteLine(reminderCounter)
        If reminderCounter >= 10 Then
            ' pop up a reminder
            pastTabPage = MainTabControl.SelectedTab
            MainTabControl.SelectedTab = Reminder
            reminderTimer.Stop()
        End If
    End Sub

    '###### Clock and Faces ######
    'Clock timer
    Private Sub ClockTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockTimer.Tick
        ClockTime.Text = Format(My.Computer.Clock.LocalTime, "hh:mm")
    End Sub
    'Sets the current date
    Private Sub Set_Date()
        'ClockDate.Text = DateTime.Today.ToString("dddd") + " " + DateTime.Today.ToString("MMM") + "." + DateTime.Today.ToString("dd")
        ClockDate.Text = DateTime.Today.ToString("yyyy") + "-" + DateTime.Today.ToString("MM") + "-" + DateTime.Today.ToString("dd")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ChangeFace.Click
        MainTabControl.SelectedTab = Faces
    End Sub
    Private Sub Face1_Click(sender As Object, e As EventArgs) Handles Face1.Click
        Clock.BackgroundImage = My.Resources.stars
        ClockDate.ForeColor = Color.Red
        ClockTime.ForeColor = Color.Red
        ChangeFace.BackgroundImage = My.Resources.time_6_512_red
        MainTabControl.SelectedTab = Clock
    End Sub
    Private Sub Face3_Click(sender As Object, e As EventArgs) Handles Face3.Click
        Clock.BackgroundImage = My.Resources.blue
        ClockDate.ForeColor = Color.Blue
        ClockTime.ForeColor = Color.Blue
        ChangeFace.BackgroundImage = My.Resources.time_6_512_blue
        MainTabControl.SelectedTab = Clock
    End Sub
    Private Sub Face2_Click(sender As Object, e As EventArgs) Handles Face2.Click
        Clock.BackgroundImage = My.Resources.blue
        ClockDate.ForeColor = Color.Black
        ClockTime.ForeColor = Color.Black
        ChangeFace.BackgroundImage = My.Resources.time_6_512_blue
        MainTabControl.SelectedTab = Clock
    End Sub
    Private Sub Face4_Click(sender As Object, e As EventArgs) Handles Face4.Click
        Clock.BackgroundImage = My.Resources._1291876726031
        Clock.BackgroundImageLayout = ImageLayout.Stretch
        ClockDate.ForeColor = Color.Black
        ClockTime.ForeColor = Color.Black
        ChangeFace.BackgroundImage = My.Resources.time_6_512_black
        MainTabControl.SelectedTab = Clock
    End Sub

    '###### MUSIC PLAYER ######
    Private Sub MusicTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MusicTimer.Tick
        currentSongLength -= MusicTimer.Interval / 1000
        If currentSongLength <= 0 Then
            If repeat Then
                PlayMusic()
            ElseIf shuffle Then
                songNumber = shuffle_rn.Next(MAXSONGS)
                PlayMusic()
            ElseIf songNumber = MAXSONGS - 1 Then
                StopMusic()
            Else
                songNumber += 1
                PlayMusic()
            End If
        End If

    End Sub
    'Toggle play/stop which we'll call pause for now
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If playing Then
            StopMusic()
        Else
            PlayMusic()
        End If
        'playing = Not playing
    End Sub
    'Stop
    Private Sub StopMusic()
        My.Computer.Audio.Stop()
        PlayButton.BackgroundImage = My.Resources.play_512
        playing = False
        MusicTimer.Stop()
        NowPlaying.Visible = False
    End Sub
    ' Play
    Private Sub PlayMusic()
        currentSongLength = songLength(songNumber)
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(songs(songNumber)), _
                               AudioPlayMode.Background)
        PlayButton.BackgroundImage = My.Resources.pause_512
        playing = True
        NowPlaying.Text = "Playing: " + songName(songNumber)
        NowPlaying.Visible = True
        MusicTimer.Start()
    End Sub
    ' Toggle Repeat
    Private Sub RepeatButton_Click(sender As Object, e As EventArgs) Handles RepeatButton.Click
        If repeat Then
            RepeatButton.BackgroundImage = My.Resources.repeat_512_green
        Else
            RepeatButton.BackgroundImage = My.Resources.repeat_512
        End If
        repeat = Not repeat
    End Sub
    'Toggle Shuffle
    Private Sub SufftleButton_Click(sender As Object, e As EventArgs) Handles ShufftleButton.Click
        If shuffle Then
            ShufftleButton.BackgroundImage = My.Resources.shuffle_512_green
        Else
            ShufftleButton.BackgroundImage = My.Resources.shuffle_512
        End If
        shuffle = Not shuffle
    End Sub
    'Next Song
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If shuffle Then
            songNumber = shuffle_rn.Next(MAXSONGS)
            PlayMusic()
        ElseIf songNumber + 1 < MAXSONGS Then
            songNumber += 1
            PlayMusic()
        Else
            StopMusic()
        End If
    End Sub
    'Previous Song
    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If songNumber - 1 >= 0 Then
            songNumber -= 1
            PlayMusic()
        End If
    End Sub
    'Playlists
    Private Sub PlaylistButton_Click(sender As Object, e As EventArgs) Handles PlaylistButton.Click
        MainTabControl.SelectedTab = Playlist
    End Sub
    Private Sub Playlist2_Click(sender As Object, e As EventArgs) Handles Playlist2.Click
        MainTabControl.SelectedTab = Music
    End Sub
    Private Sub Playlist1_Click(sender As Object, e As EventArgs) Handles Playlist1.Click
        MainTabControl.SelectedTab = Music
    End Sub

    '###### Calendar ######
    Private Sub hideWeek()
        day1Button.Visible = False
        day2Button.Visible = False
        day3Button.Visible = False
        day4Button.Visible = False
        day5Button.Visible = False
        day6Button.Visible = False
        day7Button.Visible = False
    End Sub

    Private Sub showWeek()
        day1Button.Visible = True
        day2Button.Visible = True
        day3Button.Visible = True
        day4Button.Visible = True
        day5Button.Visible = True
        day6Button.Visible = True
        day7Button.Visible = True
    End Sub

    Private Sub hideDay()
        dayEventName1.Visible = False
        dayEventName2.Visible = False
        dayEventTime1.Visible = False
        dayEventTime2.Visible = False
        EventPicture1.Visible = False
        EventPicture2.Visible = False
    End Sub

    Private Sub showDay()
        dayEventName1.Visible = True
        dayEventName2.Visible = True
        dayEventTime1.Visible = True
        dayEventTime2.Visible = True
        EventPicture1.Visible = True
        EventPicture2.Visible = True
    End Sub

    Private Sub clearWeekdayPictures()
        Dim weekdayPicture() As PictureBox = {WeekdaySelect1, WeekdaySelect2, WeekdaySelect3, WeekdaySelect4, _
                                  WeekdaySelect5, WeekdaySelect6, WeekdaySelect7}
        Dim i As Integer = 0
        For i = 0 To 6
            weekdayPicture(i).BackColor = Color.LightGray
        Next
    End Sub
    'Private Sub hideEvent()
    '    'eventName.Visible = False
    '    'eventTime.Visible = False
    'End Sub

    'Private Sub showEvent()
    '    'eventName.Visible = True
    '    'eventTime.Visible = True
    'End Sub
    Private Sub weekButton_Click(sender As Object, e As EventArgs) Handles weekButton.Click
        weekButton.Visible = False
        'calendarTitle.Text = "Choose a day"
        clearWeekdayPictures()
        hideDay()
        showWeek()
    End Sub
    Private Sub weekDay_Click(sender As Object, e As EventArgs) Handles day1Button.Click, day2Button.Click, day3Button.Click, day4Button.Click, day5Button.Click, day6Button.Click, day7Button.Click
        weekButton.Visible = True
        dayEventName1.Text = "no events"
        dayEventName2.Text = ""
        dayEventTime1.Text = ""
        dayEventTime2.Text = ""
        EventPicture1.BackgroundImage = Nothing
        EventPicture2.BackgroundImage = Nothing
        Dim weekdayPicture() As PictureBox = {WeekdaySelect1, WeekdaySelect2, WeekdaySelect3, WeekdaySelect4, _
                                  WeekdaySelect5, WeekdaySelect6, WeekdaySelect7}
        weekdayPicture(sender.Tag - 1).BackColor = Color.Green
        If sender.Tag = 1 Then
            '   calendarTitle.Text = "Sunday"
        ElseIf sender.Tag = 2 Then
            '  calendarTitle.Text = "Monday"
            dayEventName1.Text = "karate"
            dayEventTime1.Text = "6:00 PM"
            EventPicture1.BackgroundImage = My.Resources.clenched_fist_512
        ElseIf sender.Tag = 3 Then
            ' calendarTitle.Text = "Tuesday"
            dayEventName1.Text = "soccer practice"
            dayEventTime1.Text = "5:00 PM"
            EventPicture1.BackgroundImage = My.Resources.soccer_3_512
        ElseIf sender.Tag = 4 Then
            'calendarTitle.Text = "Wednesday"
        ElseIf sender.Tag = 5 Then
            'calendarTitle.Text = "Thursday"
            dayEventName1.Text = "birthday party"
            dayEventName2.Text = "dinner @ grandma's"
            dayEventTime1.Text = "4:00 PM"
            dayEventTime2.Text = "7:00 PM"
            EventPicture1.BackgroundImage = My.Resources.birthday_cake_512
            EventPicture2.BackgroundImage = My.Resources.bread_512
        ElseIf sender.Tag = 6 Then
            'calendarTitle.Text = "Friday"
            dayEventName1.Text = "field trip"
            dayEventTime1.Text = "9:00 AM"
            EventPicture1.BackgroundImage = My.Resources.bus_4_512
        ElseIf sender.Tag = 7 Then
            'calendarTitle.Text = "Saturday"
        Else
        End If

        hideWeek()
        showDay()
    End Sub
    'Private Sub dayEventName1_Click(sender As Object, e As EventArgs) Handles dayEventName1.Click
    '    'eventName.Text = dayEventName1.Text
    '    'eventTime.Text = dayEventTime1.Text

    '    hideDay()
    '    showEvent()

    '    weekButton.Visible = False
    '    dayButton.Visible = True
    'End Sub

    'Private Sub dayEventName2_Click(sender As Object, e As EventArgs) Handles dayEventName2.Click
    '    'eventName.Text = dayEventName2.Text
    '    'eventTime.Text = dayEventTime2.Text

    '    hideDay()
    '    showEvent()

    '    weekButton.Visible = False
    '    dayButton.Visible = True
    'End Sub
    Private Sub dayButton_Click(sender As Object, e As EventArgs) Handles dayButton.Click
        weekButton.Visible = True
        dayButton.Visible = False
        'hideEvent()
        showDay()
    End Sub

    '###### Phone and Messaging ######
    Private Sub CallBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles CallMomBtn.MouseClick, CallDadBtn.MouseClick, CallThomasBtn.MouseClick, CallJesBtn.MouseClick
        MainTabControl.SelectedTab = CallPage
        AcceptBtn.Hide()
        SetCallerPicture(sender.Name)
        'HangUpBtn.Text = "Cancel Call"
        If sender.Name = "CallMomBtn" Then
            'CallTitle.Text = "Calling Mom"
            ParentUI.TabControl.SelectedTab = ParentUI.ParentCallPage
            ParentUI.ParentCallTitle.Text = "Jimmy"
        ElseIf sender.Name = "CallDadBtn" Then
            'CallTitle.Text = "Calling Dad"
        ElseIf sender.Name = "CallThomasBtn" Then
            'CallTitle.Text = "Calling Thomas"
        ElseIf sender.Name = "CallJesBtn" Then
            'CallTitle.Text = "Calling Jessica"
        End If
    End Sub
    Private Sub SetCallerPicture(name As String)
        If name = "CallMomBtn" Then
            CallerPicture.BackgroundImage = My.Resources.marge
        ElseIf name = "CallDadBtn" Then
            CallerPicture.BackgroundImage = My.Resources.homerpoint
        ElseIf name = "CallThomasBtn" Then
            CallerPicture.BackgroundImage = My.Resources.BartSimpson13
        ElseIf name = "CallJesBtn" Then
            CallerPicture.BackgroundImage = My.Resources.Lisa_Simpson
        End If
    End Sub
    Private Sub HangUpBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles HangUpBtn.MouseClick
        MainTabControl.SelectedTab = Main
        ParentUI.TabControl.SelectedTab = ParentUI.TrackChild
    End Sub



    Public Sub IncomingCall(callerName As String)
        MainTabControl.SelectedTab = CallPage
        'CallTitle.Text = callerName
        SetCallerPicture(callerName)
        AcceptBtn.Show()
        HangUpBtn.Text = "Hang Up"
    End Sub

    Private Sub AcceptBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles AcceptBtn.MouseClick
        AcceptBtn.Hide()
        ParentUI.ParentHangUp.Text = "Hang Up"
    End Sub

    Private Sub dismissReminder_Click(sender As Object, e As EventArgs) Handles dismissReminder.Click
        MainTabControl.SelectedTab = pastTabPage
    End Sub


End Class
