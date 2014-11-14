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
    '    • View time(2) , date(1), choose watch face(2)
    '    • Be reminded of appointments (2), hide reminder (1)
    '    • View day(1), week(1) schedules and specific appointment (2)
    '    • Call parent (1), hang up(1), call alternate parent (2) other people (2)
    '    • Leave message (1), automatic redial (2)
    '    • receive call (2) and answer(1) or not(1)
    '    • Send voice(1), video(2) or picture (2) message
    '    • Receive message(1) and listen to/view it (2)
    '    • Review messages (1) and keep(1) or discard them (1)
    '    • Music: play song(1), pause(1), next/previous song(2), repeat/shuffle(1)
    '    • Make watch non-disruptive/normal(1), non-disruptive options(1)
    'Parent's U.I.
    '    • Track child: see child(ren) on map (2)
    '    • Call one (1) or more (2) children from map


    Const watchHeight As Integer = 190
    Const watchwidth As Integer = 167
    Private YOfsetCalendar As Integer = 0, YOfsetMusic As Integer = 0, YOfsetCall As Integer = 0
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
    Private Sub Menu_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseDown, MusicButton.MouseDown, callButton.MouseDown
        clicked = True
        YOfsetCalendar = Cursor.Position.Y - CalendarButton.Location.Y
        YOfsetMusic = Cursor.Position.Y - MusicButton.Location.Y
        YOfsetCall = Cursor.Position.Y - callButton.Location.Y
    End Sub
    Private Sub Menu_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseMove, MusicButton.MouseMove, callButton.MouseMove
        If (clicked) Then
            CalendarButton.Location = New Drawing.Point(CalendarButton.Location.X, (Cursor.Position.Y - YOfsetCalendar))
            MusicButton.Location = New Drawing.Point(MusicButton.Location.X, (Cursor.Position.Y - YOfsetMusic))
            callButton.Location = New Drawing.Point(callButton.Location.X, (Cursor.Position.Y - YOfsetCall))
        End If
    End Sub
    Private Sub Menu_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CalendarButton.MouseUp, MusicButton.MouseUp, callButton.MouseUp
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

    Private Sub CalendarPicker_ValueChanged(sender As Object, e As EventArgs) Handles CalendarPicker.ValueChanged
        If eventsDict.ContainsKey(CalendarPicker.Value.ToString()) Then
            ' populate event data with details
            eventLabel.Text = eventsDict.Item(sender.value.ToString())
            eventNameBox.Visible = False
            createEventButton.Visible = False
        Else
            ' make event creation visible
            eventLabel.Text = "please enter the name of the event"
            eventNameBox.Visible = True
            createEventButton.Visible = True
        End If
    End Sub

    Private Sub createEventButton_Click(sender As Object, e As EventArgs) Handles createEventButton.Click
        If eventNameBox.Text.Length > 0 Then
            eventsDict.Add(CalendarPicker.Value.ToString(), eventNameBox.Text)

            eventLabel.Text = "created event"
            eventNameBox.Visible = False
            createEventButton.Visible = False

            eventNameBox.Text = ""
        Else
            eventLabel.Text = "event name missing"
        End If
    End Sub

    Private Sub PlaylistButton_Click(sender As Object, e As EventArgs) Handles PlaylistButton.Click
        MainTabControl.SelectedTab = Playlist
    End Sub
End Class
