Public Class KidWatch
    Private YOfset As Integer = 0
    Private clicked As Boolean = False
    Const watchHeight As Integer = 190
    Const watchwidth As Integer = 167

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
End Class
