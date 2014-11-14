Public Class KidWatch
    Const watchHeight As Integer = 190
    Const watchwidth As Integer = 167
    Private YOfset As Integer = 0
    Private clicked As Boolean = False

    'Variables for music
    Dim playing As Boolean = False
    Dim shuffle As Boolean = False
    Dim repeat As Boolean = False
    Const MAXSONGS As Integer = 2
    Dim songs() As String = {"Zelda_A_Link_To_The_Past_Chest_Fanfare", "Legend_of_Zelda_A_Link_to_the_Past_Dark_World_Jazz_OC_ReMix"}
    Dim songLength() As Double = {1.5, 224.5}
    Dim songName() As String = {"Chest", "Dark World Jazz"}
    Dim songNumber As Integer = 0
    Dim currentSongLength


    Private Sub Label1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        clicked = True
        YOfset = Cursor.Position.Y - Label1.Location.Y
    End Sub


    Private Sub Label1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If (clicked) Then
            Label1.Location = New Drawing.Point(Label1.Location.X, Cursor.Position.Y - YOfset)
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        clicked = False
    End Sub

    Private Sub KidWatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainTabControl.Appearance = TabAppearance.FlatButtons
        MainTabControl.ItemSize = New Size(0, 1)
        MainTabControl.SizeMode = TabSizeMode.Fixed
        Me.Size = New Size(watchwidth, watchHeight)


    End Sub
    'Sample tab switching
    Private Sub MusicButton_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        MainTabControl.SelectedTab = Music
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
            RepeatButton.BackgroundImage = My.Resources.repeat_512
        Else
            RepeatButton.BackgroundImage = My.Resources.repeat_512_green
        End If
        repeat = Not repeat
    End Sub

    'Toggle Shuffle
    Private Sub SufftleButton_Click(sender As Object, e As EventArgs) Handles ShufftleButton.Click
        If shuffle Then
            ShufftleButton.BackgroundImage = My.Resources.repeat_512
        Else
            ShufftleButton.BackgroundImage = My.Resources.repeat_512_green
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
End Class
