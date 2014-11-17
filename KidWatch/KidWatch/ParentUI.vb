﻿Public Class ParentUI

    Private Sub CallJimmy_MouseClick(sender As Object, e As MouseEventArgs) Handles CallJimmy.MouseClick
        KidWatch.IncomingCall("Mom")
        TabControl.SelectedTab = ParentCallPage
        ParentCallTitle.Text = "Calling Jimmy"
        ParentHangUp.Text = "Cancel Call"
        ParentAccept.Hide()
    End Sub


    Private Sub ParentHangUp_MouseClick(sender As Object, e As MouseEventArgs) Handles ParentHangUp.MouseClick
        KidWatch.MainTabControl.SelectedTab = KidWatch.Main
        TabControl.SelectedTab = TrackChild
    End Sub

    Private Sub ParentAccept_MouseClick(sender As Object, e As MouseEventArgs) Handles ParentAccept.MouseClick
        ParentAccept.Hide()
        KidWatch.HangUpBtn.Text = "Hang up"
    End Sub
End Class