Public Class KidWatch
    Const watchHeight As Integer = 190
    Const watchwidth As Integer = 167
    Private YOfset As Integer = 0
    Private clicked As Boolean = False
    Dim playing As Boolean = False


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

    Private Sub MusicButton_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        MainTabControl.SelectedTab = Music
    End Sub

    'This method is executed in a worker thread.
    Private Sub BackgroundWorkerMusic_DoWork(ByVal sender As Object, _
                                         ByVal e As System.ComponentModel.DoWorkEventArgs) _
                                     Handles BackgroundWorkerMusic.DoWork
        My.Computer.Audio.Play(My.Resources.Zelda_A_Link_To_The_Past_Chest_Fanfare, _
                               AudioPlayMode.WaitToComplete)
    End Sub


    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If Not playing Then
            'My.Computer.Audio.Play(My.Resources.Zelda_A_Link_To_The_Past_Chest_Fanfare, AudioPlayMode.Background)
            Me.BackgroundWorkerMusic.RunWorkerAsync()
            PlayButton.BackgroundImage = My.Resources.pause_512
        Else
            My.Computer.Audio.Stop()
            PlayButton.BackgroundImage = My.Resources.play_512
        End If
        playing = Not playing
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, _
                                                     ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
                                                 Handles BackgroundWorkerMusic.RunWorkerCompleted
        PlayButton.BackgroundImage = My.Resources.play_512
    End Sub
End Class
