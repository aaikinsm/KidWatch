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
    '    • choose watch face(2)
    '    • Be reminded of appointments (2), hide reminder (1)
    '    • Leave message (1), automatic redial (2)
    '    • Send voice(1), video(2) or picture (2) message
    '    • Receive message(1) and listen to/view it (2)
    '    • Review messages (1) and keep(1) or discard them (1)
    '    • Music: play song(1), pause(1), next/previous song(2), repeat/shuffle(1)
    '    • Make watch non-disruptive/normal(1), non-disruptive options(1)
    'Parent's U.I.


    Const watchHeight As Integer = 190
    Const watchwidth As Integer = 167
    Private YOfsetCalendar As Integer = 0, YOfsetMusic As Integer = 0, YOfsetCall As Integer = 0, YOfsetClock As Integer = 0
    Private clicked As Boolean = False
    Private locked As Boolean = True

    'Variables for music
    Dim playing As Boolean = False
    Dim shuffle As Boolean = False
    Dim repeat As Boolean = False
    Const MAXSONGS As Integer = 2
    Dim songs() As String = {"Zelda_A_Link_To_The_Past_Chest_Fanfare", "Legend_of_Zelda_A_Link_to_the_Past_Dark_World_Jazz_OC_ReMix"}
    Dim songLength() As Double = {1.5, 224.5}
    Dim songName() As String = {"Chest", "Dark World Jazz"}
    Dim songNumber As Integer = 0
    Dim currentSongLength As Double

    'Variables for calendar
    Dim eventsDict As New Dictionary(Of DateTime, String)

    'Main menu scroll
    Private Sub Menu_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseDown, MusicButton.MouseDown, callButton.MouseDown, WatchBgImg.MouseDown
        clicked = True
        YOfsetCalendar = Cursor.Position.Y - CalendarButton.Location.Y
        YOfsetMusic = Cursor.Position.Y - MusicButton.Location.Y
        YOfsetCall = Cursor.Position.Y - callButton.Location.Y
        YOfsetClock = Cursor.Position.Y - ClockButton.Location.Y
    End Sub
    Private Sub Menu_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseMove, MusicButton.MouseMove, callButton.MouseMove, WatchBgImg.MouseMove
        If (clicked) Then
            CalendarButton.Location = New Drawing.Point(CalendarButton.Location.X, (Cursor.Position.Y - YOfsetCalendar))
            MusicButton.Location = New Drawing.Point(MusicButton.Location.X, (Cursor.Position.Y - YOfsetMusic))
            callButton.Location = New Drawing.Point(callButton.Location.X, (Cursor.Position.Y - YOfsetCall))
            ClockButton.Location = New Drawing.Point(ClockButton.Location.X, (Cursor.Position.Y - YOfsetClock))
        End If
    End Sub
    Private Sub Menu_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseUp, MusicButton.MouseUp, callButton.MouseUp, WatchBgImg.MouseUp
        clicked = False
    End Sub

    Private Sub KidWatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainTabControl.Appearance = TabAppearance.FlatButtons
        MainTabControl.ItemSize = New Size(0, 1)
        MainTabControl.SizeMode = TabSizeMode.Fixed
        MainTabControl.SelectedTab = Clock
        ClockTimer.Start()
        ParentUI.Show()
        Me.Size = New Size(watchwidth, watchHeight)
        Me.MaximumSize = New Size(watchwidth, watchHeight)

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

    Private Sub ClockButton_MouseClick(sender As Object, e As MouseEventArgs) Handles ClockButton.MouseClick
        MainTabControl.SelectedTab = Clock
    End Sub


    Private Sub ClockPage_Click(sender As Object, e As EventArgs) Handles time.MouseEnter
        MainTabControl.SelectedTab = Main
    End Sub



    Private Sub ClockTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockTimer.Tick
        If (My.Computer.Clock.LocalTime.Second Mod 2 = 0) Then
            time.Text = Format(My.Computer.Clock.LocalTime.Hour) + ":" + Format(My.Computer.Clock.LocalTime.Minute)
        Else
            time.Text = Format(My.Computer.Clock.LocalTime.Hour) + " " + Format(My.Computer.Clock.LocalTime.Minute)
        End If
    End Sub

    Private Sub MusicTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MusicTimer.Tick
        currentSongLength -= MusicTimer.Interval / 1000
        If currentSongLength <= 0 Then
            If repeat Then
                PlayMusic()
            ElseIf shuffle Then
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

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If songNumber + 1 < MAXSONGS Then
            songNumber += 1
            PlayMusic()
        Else
            StopMusic()
        End If
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If songNumber - 1 >= 0 Then
            songNumber -= 1
            PlayMusic()
        End If
    End Sub

    Private Sub PlaylistButton_Click(sender As Object, e As EventArgs) Handles PlaylistButton.Click
        MainTabControl.SelectedTab = Playlist
    End Sub

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
    End Sub

    Private Sub showDay()
        dayEventName1.Visible = True
        dayEventName2.Visible = True
        dayEventTime1.Visible = True
        dayEventTime2.Visible = True
    End Sub

    Private Sub hideEvent()
        eventName.Visible = False
        eventTime.Visible = False
    End Sub

    Private Sub showEvent()
        eventName.Visible = True
        eventTime.Visible = True
    End Sub

    Private Sub weekButton_Click(sender As Object, e As EventArgs) Handles weekButton.Click
        weekButton.Visible = False
        calendarTitle.Text = "Choose a day"

        hideDay()
        showWeek()
    End Sub

    Private Sub weekDay_Click(sender As Object, e As EventArgs) Handles day1Button.Click, day2Button.Click, day3Button.Click, day4Button.Click, day5Button.Click, day6Button.Click, day7Button.Click
        weekButton.Visible = True

        If sender.Tag = 1 Then
            calendarTitle.Text = "Sunday"
            dayEventName1.Text = "no events"
            dayEventName2.Text = ""
            dayEventTime1.Text = ""
            dayEventTime2.Text = ""
        ElseIf sender.Tag = 2 Then
            calendarTitle.Text = "Monday"
            dayEventName1.Text = "karate"
            dayEventName2.Text = ""
            dayEventTime1.Text = "6:00 PM"
            dayEventTime2.Text = ""
        ElseIf sender.Tag = 3 Then
            calendarTitle.Text = "Tuesday"
            dayEventName1.Text = "soccer practice"
            dayEventName2.Text = ""
            dayEventTime1.Text = "5:00 PM"
            dayEventTime2.Text = ""
        ElseIf sender.Tag = 4 Then
            calendarTitle.Text = "Wednesday"
            dayEventName1.Text = "no events"
            dayEventName2.Text = ""
            dayEventTime1.Text = ""
            dayEventTime2.Text = ""
        ElseIf sender.Tag = 5 Then
            calendarTitle.Text = "Thursday"
            dayEventName1.Text = "birthday party"
            dayEventName2.Text = "dinner @ grandma's"
            dayEventTime1.Text = "4:00 PM"
            dayEventTime2.Text = "7:00 PM"
        ElseIf sender.Tag = 6 Then
            calendarTitle.Text = "Friday"
            dayEventName1.Text = "field trip"
            dayEventName2.Text = ""
            dayEventTime1.Text = "9:00 AM"
            dayEventTime2.Text = ""
        ElseIf sender.Tag = 7 Then
            calendarTitle.Text = "Saturday"
            dayEventName1.Text = "no events"
            dayEventName2.Text = ""
            dayEventTime1.Text = ""
            dayEventTime2.Text = ""
        Else
        End If

        hideWeek()
        showDay()
    End Sub

    Private Sub dayEventName1_Click(sender As Object, e As EventArgs) Handles dayEventName1.Click
        eventName.Text = dayEventName1.Text
        eventTime.Text = dayEventTime1.Text

        hideDay()
        showEvent()

        weekButton.Visible = False
        dayButton.Visible = True
    End Sub

    Private Sub dayEventName2_Click(sender As Object, e As EventArgs) Handles dayEventName2.Click
        eventName.Text = dayEventName2.Text
        eventTime.Text = dayEventTime2.Text

        hideDay()
        showEvent()

        weekButton.Visible = False
        dayButton.Visible = True
    End Sub

    Private Sub dayButton_Click(sender As Object, e As EventArgs) Handles dayButton.Click
        weekButton.Visible = True
        dayButton.Visible = False

        hideEvent()
        showDay()
    End Sub

    Private Sub CallBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles CallMomBtn.MouseClick, CallDadBtn.MouseClick, CallThomasBtn.MouseClick, CallJesBtn.MouseClick
        MainTabControl.SelectedTab = CallPage
        AcceptBtn.Hide()
        HangUpBtn.Text = "Cancel Call"
        If sender.Name = "CallMomBtn" Then
            CallTitle.Text = "Calling Mom"
            ParentUI.TabControl.SelectedTab = ParentUI.ParentCallPage
            ParentUI.ParentCallTitle.Text = "Jimmy"
        ElseIf sender.Name = "CallDadBtn" Then
            CallTitle.Text = "Calling Dad"
        ElseIf sender.Name = "CallThomasBtn" Then
            CallTitle.Text = "Calling Thomas"
        ElseIf sender.Name = "CallJesBtn" Then
            CallTitle.Text = "Calling Jessica"
        End If
    End Sub


    Private Sub HangUpBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles HangUpBtn.MouseClick
        MainTabControl.SelectedTab = Main
        ParentUI.TabControl.SelectedTab = ParentUI.TrackChild
    End Sub



    Public Sub IncomingCall(callerName As String)
        MainTabControl.SelectedTab = CallPage
        CallTitle.Text = callerName
        AcceptBtn.Show()
        HangUpBtn.Text = "Hang Up"
    End Sub

    Private Sub AcceptBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles AcceptBtn.MouseClick
        AcceptBtn.Hide()
        ParentUI.ParentHangUp.Text = "Hang Up"
    End Sub

End Class
