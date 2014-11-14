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
    Dim songNumber As Integer = 0


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

    Private Sub CalendarButton_Click(sender As Object, e As EventArgs) Handles CalendarButton.Click
        MainTabControl.SelectedTab = Calendar
    End Sub

    'Worker thread plays song.
    Private Sub BackgroundWorkerMusic_DoWork(ByVal sender As Object, _
                                         ByVal e As System.ComponentModel.DoWorkEventArgs) _
                                     Handles BackgroundWorkerMusic.DoWork
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(songs(songNumber)), _
                               AudioPlayMode.WaitToComplete)
    End Sub
    'Monitors the state of Music worker to change icon and iamge
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, _
                                                 ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
                                             Handles BackgroundWorkerMusic.RunWorkerCompleted
        If repeat Then
            Me.BackgroundWorkerMusic.RunWorkerAsync()
        ElseIf shuffle Then

        ElseIf songNumber = MAXSONGS - 1 Then
            playing = False
            PlayButton.BackgroundImage = My.Resources.play_512
        Else
            songNumber += 1
            Me.BackgroundWorkerMusic.RunWorkerAsync()
        End If
    End Sub
    'Toggle play/stop which we'll call pause for now
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If playing Then

            BackgroundWorkerMusic.CancelAsync()
            My.Computer.Audio.Stop()
            PlayButton.BackgroundImage = My.Resources.play_512
        Else
            'songs = "Zelda_A_Link_To_The_Past_Chest_Fanfare"
            Me.BackgroundWorkerMusic.WorkerSupportsCancellation = True
            Me.BackgroundWorkerMusic.RunWorkerAsync()
            PlayButton.BackgroundImage = My.Resources.pause_512
        End If
        playing = Not playing
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

End Class
