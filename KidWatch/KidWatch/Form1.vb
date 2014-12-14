Imports System.Globalization
Imports System.Runtime.InteropServices

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
    '    • non-disruptive options(1)
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

    'Varibales for phone and messsging
    Dim calling As Boolean = False
    Dim messageReady As Boolean
    Dim messageSenderName As String
    Dim sentConfirmationCounter As Integer = 0
    Dim messageNumber As Integer
    Dim msg1 As Boolean = True
    Dim msg2 As Boolean = True

    'Variables for non-distrupt mode
    Dim muted As Boolean = False

    'Main menu scroll
    Private Sub Menu_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseDown, MusicButton.MouseDown, callButton.MouseDown, WatchBgImg.MouseDown, MessagesButton.MouseDown, ContactsButton.MouseDown
        clicked = True
        YOfsetCalendar = Cursor.Position.Y - CalendarButton.Location.Y
        YOfsetMusic = Cursor.Position.Y - MusicButton.Location.Y
        YOfsetCall = Cursor.Position.Y - callButton.Location.Y
        YOfsetClock = Cursor.Position.Y - ClockButton.Location.Y
        YOfsetMessages = Cursor.Position.Y - MessagesButton.Location.Y
        YOfsetSend = Cursor.Position.Y - ContactsButton.Location.Y
    End Sub
    Private Sub Menu_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseMove, MusicButton.MouseMove, callButton.MouseMove, WatchBgImg.MouseMove, MessagesButton.MouseMove, ContactsButton.MouseMove
        If (clicked) Then
            CalendarButton.Location = New Drawing.Point(CalendarButton.Location.X, (Cursor.Position.Y - YOfsetCalendar))
            MusicButton.Location = New Drawing.Point(MusicButton.Location.X, (Cursor.Position.Y - YOfsetMusic))
            callButton.Location = New Drawing.Point(callButton.Location.X, (Cursor.Position.Y - YOfsetCall))
            ClockButton.Location = New Drawing.Point(ClockButton.Location.X, (Cursor.Position.Y - YOfsetClock))
            ContactsButton.Location = New Drawing.Point(ContactsButton.Location.X, (Cursor.Position.Y - YOfsetSend))
            MessagesButton.Location = New Drawing.Point(MessagesButton.Location.X, (Cursor.Position.Y - YOfsetMessages))
        End If
    End Sub
    Private Sub Menu_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseUp, MusicButton.MouseUp, callButton.MouseUp, WatchBgImg.MouseUp, MessagesButton.MouseUp, ContactsButton.MouseUp
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
        NewMessageButton.Location = New Point(0, 0)
        Set_Date()
    End Sub
    'Simple tab switching
    Private Sub MusicButton_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        MainTabControl.SelectedTab = Music
    End Sub
    Private Sub CalendarButton_Click(sender As Object, e As EventArgs) Handles CalendarButton.Click
        MainTabControl.SelectedTab = Calendar
        Dim dayName As String = DateTime.Today.ToString("ddd")
        If dayName = "Sat" Then
            day1Button.PerformClick()
        ElseIf dayName = "Mon" Then
            day2Button.PerformClick()
        ElseIf dayName = "Tue" Then
            day3Button.PerformClick()
        ElseIf dayName = "Wed" Then
            day4Button.PerformClick()
        ElseIf dayName = "Thu" Then
            day5Button.PerformClick()
        ElseIf dayName = "Fri" Then
            day6Button.PerformClick()
        ElseIf dayName = "Sun" Then
            day7Button.PerformClick()
        End If
    End Sub
    Private Sub callButton_MouseClick(sender As Object, e As MouseEventArgs) Handles callButton.MouseClick
        MainTabControl.SelectedTab = PhoneBook
        calling = True
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
    Private Sub ContactsButton_Click(sender As Object, e As EventArgs) Handles ContactsButton.Click
        MainTabControl.SelectedTab = PhoneBook
        calling = False
    End Sub
    Private Sub MessagesButton_Click(sender As Object, e As EventArgs) Handles MessagesButton.Click
        MainTabControl.SelectedTab = MessageCentre
    End Sub

    Private Sub ReminderTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reminderTimer.Tick
        reminderCounter += 1
        'Console.WriteLine(reminderCounter)
        If reminderCounter = 10 Then
            ' pop up a reminder
            pastTabPage = MainTabControl.SelectedTab
            MainTabControl.SelectedTab = Reminder
        End If
        If reminderCounter = 20 Then
            NewMessageButton.Visible = True
            NewMessage()
        End If
        If reminderCounter >= 23 Then
            NewMessageButton.Visible = False
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
        Dim yesterday As DateTime = DateTime.Today.AddDays(-1)
        'ClockDate.Text = DateTime.Today.ToString("dddd") + " " + DateTime.Today.ToString("MMM") + "." + DateTime.Today.ToString("dd")
        ClockDate.Text = DateTime.Today.ToString("yyyy") + "-" + DateTime.Today.ToString("MM") + "-" + DateTime.Today.ToString("dd")
        MessageDate1.Text = ClockDate.Text
        MessageDate2.Text = yesterday.ToString("yyyy") + "-" + yesterday.ToString("MM") + "-" + yesterday.ToString("dd")
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
        SetContactPicture(sender.Name)
        If calling Then
            MainTabControl.SelectedTab = CallPage
            CallTimer.Start()
            AcceptBtn.Hide()
            'HangUpBtn.Text = "Cancel Call"
            If sender.Name = "CallMomBtn" Then
                'CallTitle.Text = "Calling Mom"
                ParentUI.TabControl.SelectedTab = ParentUI.ParentCallPage
                ParentUI.ParentCallTitle.Text = "Jimmy"
                'ElseIf sender.Name = "CallDadBtn" Then
                '    'CallTitle.Text = "Calling Dad"
                'ElseIf sender.Name = "CallThomasBtn" Then
                '    'CallTitle.Text = "Calling Thomas"
                'ElseIf sender.Name = "CallJesBtn" Then
                '    'CallTitle.Text = "Calling Jessica"
            End If
        Else
            MainTabControl.SelectedTab = SendMessage
        End If
    End Sub
    Private Sub SetContactPicture(name As String)
        If name = "CallMomBtn" Then
            CallerPicture.BackgroundImage = My.Resources.marge
        ElseIf name = "CallDadBtn" Then
            CallerPicture.BackgroundImage = My.Resources.homerpoint
        ElseIf name = "CallThomasBtn" Then
            CallerPicture.BackgroundImage = My.Resources.BartSimpson13
        ElseIf name = "CallJesBtn" Then
            CallerPicture.BackgroundImage = My.Resources.Lisa_Simpson
        End If
        SendingToPicture.BackgroundImage = CallerPicture.BackgroundImage
        FailedCallerPicture.BackgroundImage = CallerPicture.BackgroundImage
    End Sub
    Private Sub HangUpBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles HangUpBtn.MouseClick
        MainTabControl.SelectedTab = Main
        ParentUI.TabControl.SelectedTab = ParentUI.TrackChild
    End Sub
    Public Sub IncomingCall(callerName As String)
        MainTabControl.SelectedTab = CallPage
        SetContactPicture(callerName)
        AcceptBtn.Show()
        HangUpBtn.Text = "Hang Up"
    End Sub
    Private Sub AcceptBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles AcceptBtn.MouseClick
        AcceptBtn.Hide()
        ParentUI.ParentHangUp.Text = "Hang Up"
    End Sub
    Private Sub MessagePictureBox_Click(sender As Object, e As EventArgs) Handles TextMessageBox.Click, VoiceMessageBox.Click, PictureMessageBox.Click, VideoMessageBox.Click
        SendingTypePicture.BackgroundImage = sender.BackgroundImage
        messageReady = False
        HelloButton.BackColor = Color.Transparent
        HelloButton.Visible = False
        SendExistingPicture.Visible = True
        SendExistingPicture.BorderStyle = BorderStyle.None
        ConfirmPicture.BackgroundImage = My.Resources.check_mark_7_512_gray
        messageSenderName = sender.name
        If messageSenderName = "TextMessageBox" Then
            HelloButton.Visible = True
            SendExistingPicture.Visible = False
        ElseIf messageSenderName = "VoiceMessageBox" Then
            SendExistingPicture.BackgroundImage = My.Resources.speaker_512_blue
        ElseIf messageSenderName = "PictureMessageBox" Then
            SendExistingPicture.BackgroundImage = My.Resources.ladybug_large
        ElseIf messageSenderName = "VideoMessageBox" Then
            SendExistingPicture.BackgroundImage = My.Resources.fox
        End If
        MainTabControl.SelectedTab = Sending
    End Sub
    Private Sub HelloButton_Click(sender As Object, e As EventArgs) Handles HelloButton.Click
        HelloButton.BackColor = Color.LightGreen
        ToggleSend()
    End Sub
    Private Sub SendExistingPicture_Click(sender As Object, e As EventArgs) Handles SendExistingPicture.Click
        SendExistingPicture.BorderStyle = BorderStyle.FixedSingle
        ToggleSend()
        If messageSenderName = "VoiceMessageBox" Then
            If playing Then
                StopMusic()
                My.Computer.Audio.Play(My.Resources.Blue1, _
                               AudioPlayMode.WaitToComplete)
                PlayMusic()
            Else
                My.Computer.Audio.Play(My.Resources.Blue1, _
                               AudioPlayMode.WaitToComplete)
            End If
        End If
    End Sub
    Private Sub ToggleSend()
        ConfirmPicture.BackgroundImage = My.Resources.check_mark_7_512
        messageReady = True
    End Sub
    Private Sub CancelPicture_Click(sender As Object, e As EventArgs) Handles CancelPicture.Click
        MainTabControl.SelectedTab = SendMessage
    End Sub
    Private Sub ConfirmPicture_Click(sender As Object, e As EventArgs) Handles ConfirmPicture.Click
        If messageReady Then
            SentPicture.Visible = True
            sentConfirmationCounter = 0
            SentTimer.Start()
        End If
    End Sub
    Private Sub SentTimer_Tick(sender As Object, e As EventArgs) Handles SentTimer.Tick
        sentConfirmationCounter += 1
        If sentConfirmationCounter = 10 Then
            SentTimer.Stop()
            SentPicture.Visible = False
            MainTabControl.SelectedTab = Main
        End If
    End Sub
    Private Sub Message1_Click(sender As Object, e As EventArgs) Handles MsgSenderPicture1.Click, MsgPreviewPicture1.Click
        PreviewPicture.BackgroundImage = MsgPreviewPicture1.BackgroundImage
        PreviewPicture.Tag = MsgPreviewPicture1.Tag
        MessageTime1.Font = New Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        MessageTime1.ForeColor = Color.Black
        MainTabControl.SelectedTab = ViewMessage
        MessagesButton.BackgroundImage = My.Resources.read_message_512
        ViewingMessage(1)
    End Sub
    Private Sub Message2_Click(sender As Object, e As EventArgs) Handles MsgSenderPicture2.Click, MsgPreviewPicture2.Click
        PreviewPicture.BackgroundImage = MsgPreviewPicture2.BackgroundImage
        PreviewPicture.Tag = MsgPreviewPicture2.Tag
        MessageTime2.Font = New Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        MessageTime2.ForeColor = Color.Black
        MainTabControl.SelectedTab = ViewMessage
        ViewingMessage(2)
    End Sub
    Private Sub ViewingMessage(ByVal message As Integer)
        messageNumber = message
        If PreviewPicture.Tag = "Voice" Then
            If playing Then
                StopMusic()
            End If
            My.Computer.Audio.Play(My.Resources.Spam, AudioPlayMode.Background)
        End If
    End Sub
    Private Sub KeepMessagePicture_Click(sender As Object, e As EventArgs) Handles KeepMessagePicture.Click
        MainTabControl.SelectedTab = MessageCentre
    End Sub
    Private Sub DeleteMessagePicture_Click(sender As Object, e As EventArgs) Handles DeleteMessagePicture.Click
        If messageNumber = 1 Then
            MessageDate1.Text = MessageDate2.Text
            MessageTime1.Text = MessageTime2.Text
            MsgSenderPicture1.BackgroundImage = MsgSenderPicture2.BackgroundImage
            MsgPreviewPicture1.BackgroundImage = MsgPreviewPicture2.BackgroundImage
            MsgPreviewPicture1.Tag = MsgPreviewPicture2.Tag
            If Not msg2 Then
                MessageDate1.Visible = False
                MessageTime1.Visible = False
                MsgSenderPicture1.Visible = False
                MsgPreviewPicture1.Visible = False
                msg1 = False
            End If
        End If
        MessageDate2.Visible = False
        MessageTime2.Visible = False
        MsgSenderPicture2.Visible = False
        MsgPreviewPicture2.Visible = False
        msg2 = False
        MainTabControl.SelectedTab = MessageCentre
    End Sub
    Private Sub NewMessage()
        MessagesButton.BackgroundImage = My.Resources.message_outline_512

        MessageDate2.Text = MessageDate1.Text
        MessageTime2.Text = MessageTime1.Text
        MsgSenderPicture2.BackgroundImage = MsgSenderPicture1.BackgroundImage
        MsgPreviewPicture2.BackgroundImage = MsgPreviewPicture1.BackgroundImage
        MsgPreviewPicture2.Tag = MsgPreviewPicture1.Tag
        If msg2 Then
            MessageDate2.Visible = False
        End If
        If msg1 Then
            MessageTime2.Visible = True
            MsgSenderPicture2.Visible = True
            MsgPreviewPicture2.Visible = True
        End If
        MessageDate1.Text = DateTime.Today.ToString("yyyy") + "-" + DateTime.Today.ToString("MM") + "-" + DateTime.Today.ToString("dd")
        MessageTime1.Text = Format(My.Computer.Clock.LocalTime, "hh:mm")
        MessageTime1.Font = New Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        MessageTime1.ForeColor = Color.Red
        MsgSenderPicture1.BackgroundImage = My.Resources.homerpoint
        MsgPreviewPicture1.BackgroundImage = My.Resources.cat
        MsgPreviewPicture1.Tag = "New"
        If playing Then
            StopMusic()
            My.Computer.Audio.Play(My.Resources.message, _
                           AudioPlayMode.WaitToComplete)
            PlayMusic()
        Else
            My.Computer.Audio.Play(My.Resources.message, _
                           AudioPlayMode.WaitToComplete)
        End If
    End Sub
    Private Sub NewMessageButton_Click(sender As Object, e As EventArgs) Handles NewMessageButton.Click
        NewMessageButton.Visible = False
        Message1_Click(Nothing, Nothing)
    End Sub
    'Reminder and Notifications 
    Private Sub dismissReminder_Click(sender As Object, e As EventArgs) Handles dismissReminder.Click
        MainTabControl.SelectedTab = pastTabPage
    End Sub

    'Non-Distruptive
    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const WM_APPCOMMAND As Integer = &H319
    Declare Function SendMessageW Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub DisruptiveToggleButton_Click(sender As Object, e As EventArgs) Handles DisruptiveToggleButton.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, CType(APPCOMMAND_VOLUME_MUTE, IntPtr))
        muted = Not muted
        If muted Then
            DisruptiveToggleButton.BackgroundImage = My.Resources.mute_2_512
        Else
            DisruptiveToggleButton.BackgroundImage = My.Resources.speaker_512_black
        End If
    End Sub


    Private Sub CallTimer_Tick(sender As Object, e As EventArgs) Handles CallTimer.Tick
        MainTabControl.SelectedTab = FailedCall
        CallTimer.Stop()
    End Sub

    Private Sub RedialButton_Click(sender As Object, e As EventArgs) Handles RedialButton.Click
        MainTabControl.SelectedTab = CallPage
        CallTimer.Start()
    End Sub

    Private Sub VoiceMailButton_Click(sender As Object, e As EventArgs) Handles VoiceMailButton.Click
        SendingTypePicture.BackgroundImage = My.Resources.microphone_512_black
        messageReady = False
        HelloButton.BackColor = Color.Transparent
        HelloButton.Visible = False
        SendExistingPicture.Visible = True
        SendExistingPicture.BorderStyle = BorderStyle.None
        ConfirmPicture.BackgroundImage = My.Resources.check_mark_7_512_gray
        SendExistingPicture.BackgroundImage = My.Resources.speaker_512_blue
        messageSenderName = "VoiceMessageBox"
        MainTabControl.SelectedTab = Sending
    End Sub
End Class
