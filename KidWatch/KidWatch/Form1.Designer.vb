<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.MusicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.reminderTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SentTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NewMessageButton = New System.Windows.Forms.Button()
        Me.ViewMessage = New System.Windows.Forms.TabPage()
        Me.DeleteMessagePicture = New System.Windows.Forms.PictureBox()
        Me.KeepMessagePicture = New System.Windows.Forms.PictureBox()
        Me.PreviewLabel = New System.Windows.Forms.Label()
        Me.PreviewPicture = New System.Windows.Forms.PictureBox()
        Me.MessageCentre = New System.Windows.Forms.TabPage()
        Me.MessageTime2 = New System.Windows.Forms.Label()
        Me.MessageTime1 = New System.Windows.Forms.Label()
        Me.MessageDate2 = New System.Windows.Forms.Label()
        Me.MessageDate1 = New System.Windows.Forms.Label()
        Me.MsgPreviewPicture2 = New System.Windows.Forms.PictureBox()
        Me.MsgPreviewPicture1 = New System.Windows.Forms.PictureBox()
        Me.MsgSenderPicture2 = New System.Windows.Forms.PictureBox()
        Me.MsgSenderPicture1 = New System.Windows.Forms.PictureBox()
        Me.Sending = New System.Windows.Forms.TabPage()
        Me.SentPicture = New System.Windows.Forms.PictureBox()
        Me.CancelPicture = New System.Windows.Forms.PictureBox()
        Me.ConfirmPicture = New System.Windows.Forms.PictureBox()
        Me.HelloButton = New System.Windows.Forms.Button()
        Me.SendingAddPicture = New System.Windows.Forms.PictureBox()
        Me.SendExistingPicture = New System.Windows.Forms.PictureBox()
        Me.SendingTypePicture = New System.Windows.Forms.PictureBox()
        Me.SendingToPicture = New System.Windows.Forms.PictureBox()
        Me.SendMessage = New System.Windows.Forms.TabPage()
        Me.TextMessageBox = New System.Windows.Forms.PictureBox()
        Me.VideoMessageBox = New System.Windows.Forms.PictureBox()
        Me.PictureMessageBox = New System.Windows.Forms.PictureBox()
        Me.VoiceMessageBox = New System.Windows.Forms.PictureBox()
        Me.Faces = New System.Windows.Forms.TabPage()
        Me.Face4 = New System.Windows.Forms.Button()
        Me.Face3 = New System.Windows.Forms.Button()
        Me.Face2 = New System.Windows.Forms.Button()
        Me.Face1 = New System.Windows.Forms.Button()
        Me.Reminder = New System.Windows.Forms.TabPage()
        Me.dismissReminder = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CallPage = New System.Windows.Forms.TabPage()
        Me.CallerPicture = New System.Windows.Forms.PictureBox()
        Me.HangUpBtn = New System.Windows.Forms.Button()
        Me.AcceptBtn = New System.Windows.Forms.Button()
        Me.CallingPicture = New System.Windows.Forms.PictureBox()
        Me.PhoneBook = New System.Windows.Forms.TabPage()
        Me.CallJesBtn = New System.Windows.Forms.Button()
        Me.CallThomasBtn = New System.Windows.Forms.Button()
        Me.CallDadBtn = New System.Windows.Forms.Button()
        Me.CallMomBtn = New System.Windows.Forms.Button()
        Me.Playlist = New System.Windows.Forms.TabPage()
        Me.PlaylistIcon2 = New System.Windows.Forms.PictureBox()
        Me.PlaylistIcon1 = New System.Windows.Forms.PictureBox()
        Me.Playlist2 = New System.Windows.Forms.Label()
        Me.Playlist1 = New System.Windows.Forms.Label()
        Me.Disrupt = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Calendar = New System.Windows.Forms.TabPage()
        Me.WeekdaySelect7 = New System.Windows.Forms.PictureBox()
        Me.WeekdaySelect6 = New System.Windows.Forms.PictureBox()
        Me.WeekdaySelect5 = New System.Windows.Forms.PictureBox()
        Me.WeekdaySelect4 = New System.Windows.Forms.PictureBox()
        Me.WeekdaySelect3 = New System.Windows.Forms.PictureBox()
        Me.WeekdaySelect2 = New System.Windows.Forms.PictureBox()
        Me.WeekdaySelect1 = New System.Windows.Forms.PictureBox()
        Me.EventPicture2 = New System.Windows.Forms.PictureBox()
        Me.EventPicture1 = New System.Windows.Forms.PictureBox()
        Me.dayButton = New System.Windows.Forms.Button()
        Me.dayEventTime2 = New System.Windows.Forms.Label()
        Me.dayEventName2 = New System.Windows.Forms.Label()
        Me.dayEventTime1 = New System.Windows.Forms.Label()
        Me.dayEventName1 = New System.Windows.Forms.Label()
        Me.day7Button = New System.Windows.Forms.Button()
        Me.day6Button = New System.Windows.Forms.Button()
        Me.day5Button = New System.Windows.Forms.Button()
        Me.day4Button = New System.Windows.Forms.Button()
        Me.day3Button = New System.Windows.Forms.Button()
        Me.day2Button = New System.Windows.Forms.Button()
        Me.day1Button = New System.Windows.Forms.Button()
        Me.weekButton = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Clock = New System.Windows.Forms.TabPage()
        Me.DisruptiveToggleButton = New System.Windows.Forms.Button()
        Me.ChangeFace = New System.Windows.Forms.Button()
        Me.ClockDate = New System.Windows.Forms.Label()
        Me.ClockTime = New System.Windows.Forms.Label()
        Me.Music = New System.Windows.Forms.TabPage()
        Me.RepeatButton = New System.Windows.Forms.Button()
        Me.ShufftleButton = New System.Windows.Forms.Button()
        Me.PlaylistButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.NowPlaying = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Main = New System.Windows.Forms.TabPage()
        Me.MessagesButton = New System.Windows.Forms.Button()
        Me.ContactsButton = New System.Windows.Forms.Button()
        Me.ClockButton = New System.Windows.Forms.Button()
        Me.callButton = New System.Windows.Forms.Button()
        Me.CalendarButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.WatchBgImg = New System.Windows.Forms.PictureBox()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.FailedCall = New System.Windows.Forms.TabPage()
        Me.FailedCallerPicture = New System.Windows.Forms.PictureBox()
        Me.VoiceMailButton = New System.Windows.Forms.Button()
        Me.RedialButton = New System.Windows.Forms.Button()
        Me.FailedCallPicture = New System.Windows.Forms.PictureBox()
        Me.CallTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ViewMessage.SuspendLayout()
        CType(Me.DeleteMessagePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeepMessagePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviewPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessageCentre.SuspendLayout()
        CType(Me.MsgPreviewPicture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsgPreviewPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsgSenderPicture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsgSenderPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sending.SuspendLayout()
        CType(Me.SentPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendingAddPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendExistingPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendingTypePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendingToPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SendMessage.SuspendLayout()
        CType(Me.TextMessageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideoMessageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMessageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoiceMessageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Faces.SuspendLayout()
        Me.Reminder.SuspendLayout()
        Me.CallPage.SuspendLayout()
        CType(Me.CallerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CallingPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhoneBook.SuspendLayout()
        Me.Playlist.SuspendLayout()
        CType(Me.PlaylistIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaylistIcon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Disrupt.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Calendar.SuspendLayout()
        CType(Me.WeekdaySelect7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekdaySelect6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekdaySelect5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekdaySelect4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekdaySelect3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekdaySelect2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekdaySelect1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventPicture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clock.SuspendLayout()
        Me.Music.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main.SuspendLayout()
        CType(Me.WatchBgImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTabControl.SuspendLayout()
        Me.FailedCall.SuspendLayout()
        CType(Me.FailedCallerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FailedCallPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeBtn
        '
        Me.HomeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Location = New System.Drawing.Point(148, 43)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(26, 23)
        Me.HomeBtn.TabIndex = 3
        Me.HomeBtn.Text = "<|"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'MusicTimer
        '
        '
        'ClockTimer
        '
        '
        'reminderTimer
        '
        Me.reminderTimer.Enabled = True
        Me.reminderTimer.Interval = 1000
        '
        'SentTimer
        '
        '
        'NewMessageButton
        '
        Me.NewMessageButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.message_outline_512
        Me.NewMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NewMessageButton.Location = New System.Drawing.Point(159, 72)
        Me.NewMessageButton.Name = "NewMessageButton"
        Me.NewMessageButton.Size = New System.Drawing.Size(40, 40)
        Me.NewMessageButton.TabIndex = 4
        Me.NewMessageButton.UseVisualStyleBackColor = True
        Me.NewMessageButton.Visible = False
        '
        'ViewMessage
        '
        Me.ViewMessage.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.ViewMessage.Controls.Add(Me.DeleteMessagePicture)
        Me.ViewMessage.Controls.Add(Me.KeepMessagePicture)
        Me.ViewMessage.Controls.Add(Me.PreviewLabel)
        Me.ViewMessage.Controls.Add(Me.PreviewPicture)
        Me.ViewMessage.Location = New System.Drawing.Point(4, 22)
        Me.ViewMessage.Name = "ViewMessage"
        Me.ViewMessage.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewMessage.Size = New System.Drawing.Size(153, 154)
        Me.ViewMessage.TabIndex = 13
        Me.ViewMessage.Text = "ViewMessage"
        Me.ViewMessage.UseVisualStyleBackColor = True
        '
        'DeleteMessagePicture
        '
        Me.DeleteMessagePicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.delete_512
        Me.DeleteMessagePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteMessagePicture.Location = New System.Drawing.Point(113, 114)
        Me.DeleteMessagePicture.Name = "DeleteMessagePicture"
        Me.DeleteMessagePicture.Size = New System.Drawing.Size(40, 40)
        Me.DeleteMessagePicture.TabIndex = 3
        Me.DeleteMessagePicture.TabStop = False
        '
        'KeepMessagePicture
        '
        Me.KeepMessagePicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.check_mark_7_512
        Me.KeepMessagePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.KeepMessagePicture.Location = New System.Drawing.Point(0, 114)
        Me.KeepMessagePicture.Name = "KeepMessagePicture"
        Me.KeepMessagePicture.Size = New System.Drawing.Size(40, 40)
        Me.KeepMessagePicture.TabIndex = 2
        Me.KeepMessagePicture.TabStop = False
        '
        'PreviewLabel
        '
        Me.PreviewLabel.AutoSize = True
        Me.PreviewLabel.Location = New System.Drawing.Point(10, 29)
        Me.PreviewLabel.Name = "PreviewLabel"
        Me.PreviewLabel.Size = New System.Drawing.Size(39, 13)
        Me.PreviewLabel.TabIndex = 1
        Me.PreviewLabel.Text = "Label1"
        Me.PreviewLabel.Visible = False
        '
        'PreviewPicture
        '
        Me.PreviewPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PreviewPicture.Location = New System.Drawing.Point(0, -8)
        Me.PreviewPicture.Name = "PreviewPicture"
        Me.PreviewPicture.Size = New System.Drawing.Size(153, 162)
        Me.PreviewPicture.TabIndex = 0
        Me.PreviewPicture.TabStop = False
        '
        'MessageCentre
        '
        Me.MessageCentre.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.MessageCentre.Controls.Add(Me.MessageTime2)
        Me.MessageCentre.Controls.Add(Me.MessageTime1)
        Me.MessageCentre.Controls.Add(Me.MessageDate2)
        Me.MessageCentre.Controls.Add(Me.MessageDate1)
        Me.MessageCentre.Controls.Add(Me.MsgPreviewPicture2)
        Me.MessageCentre.Controls.Add(Me.MsgPreviewPicture1)
        Me.MessageCentre.Controls.Add(Me.MsgSenderPicture2)
        Me.MessageCentre.Controls.Add(Me.MsgSenderPicture1)
        Me.MessageCentre.Location = New System.Drawing.Point(4, 22)
        Me.MessageCentre.Name = "MessageCentre"
        Me.MessageCentre.Padding = New System.Windows.Forms.Padding(3)
        Me.MessageCentre.Size = New System.Drawing.Size(153, 154)
        Me.MessageCentre.TabIndex = 12
        Me.MessageCentre.Text = "Messages"
        Me.MessageCentre.UseVisualStyleBackColor = True
        '
        'MessageTime2
        '
        Me.MessageTime2.AutoSize = True
        Me.MessageTime2.Location = New System.Drawing.Point(10, 117)
        Me.MessageTime2.Name = "MessageTime2"
        Me.MessageTime2.Size = New System.Drawing.Size(34, 13)
        Me.MessageTime2.TabIndex = 9
        Me.MessageTime2.Text = "20:33"
        '
        'MessageTime1
        '
        Me.MessageTime1.AutoSize = True
        Me.MessageTime1.Location = New System.Drawing.Point(10, 45)
        Me.MessageTime1.Name = "MessageTime1"
        Me.MessageTime1.Size = New System.Drawing.Size(34, 13)
        Me.MessageTime1.TabIndex = 8
        Me.MessageTime1.Text = "09:33"
        '
        'MessageDate2
        '
        Me.MessageDate2.AutoSize = True
        Me.MessageDate2.Location = New System.Drawing.Point(10, 80)
        Me.MessageDate2.Name = "MessageDate2"
        Me.MessageDate2.Size = New System.Drawing.Size(39, 13)
        Me.MessageDate2.TabIndex = 7
        Me.MessageDate2.Text = "Label5"
        '
        'MessageDate1
        '
        Me.MessageDate1.AutoSize = True
        Me.MessageDate1.Location = New System.Drawing.Point(10, 10)
        Me.MessageDate1.Name = "MessageDate1"
        Me.MessageDate1.Size = New System.Drawing.Size(39, 13)
        Me.MessageDate1.TabIndex = 6
        Me.MessageDate1.Text = "Label1"
        '
        'MsgPreviewPicture2
        '
        Me.MsgPreviewPicture2.BackgroundImage = Global.KidWatch.My.Resources.Resources.husky
        Me.MsgPreviewPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MsgPreviewPicture2.Location = New System.Drawing.Point(103, 97)
        Me.MsgPreviewPicture2.Name = "MsgPreviewPicture2"
        Me.MsgPreviewPicture2.Size = New System.Drawing.Size(50, 50)
        Me.MsgPreviewPicture2.TabIndex = 5
        Me.MsgPreviewPicture2.TabStop = False
        '
        'MsgPreviewPicture1
        '
        Me.MsgPreviewPicture1.BackgroundImage = Global.KidWatch.My.Resources.Resources.speaker_512
        Me.MsgPreviewPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MsgPreviewPicture1.Location = New System.Drawing.Point(100, 26)
        Me.MsgPreviewPicture1.Name = "MsgPreviewPicture1"
        Me.MsgPreviewPicture1.Size = New System.Drawing.Size(50, 50)
        Me.MsgPreviewPicture1.TabIndex = 4
        Me.MsgPreviewPicture1.TabStop = False
        Me.MsgPreviewPicture1.Tag = "Voice"
        '
        'MsgSenderPicture2
        '
        Me.MsgSenderPicture2.BackgroundImage = Global.KidWatch.My.Resources.Resources.marge
        Me.MsgSenderPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MsgSenderPicture2.Location = New System.Drawing.Point(53, 97)
        Me.MsgSenderPicture2.Name = "MsgSenderPicture2"
        Me.MsgSenderPicture2.Size = New System.Drawing.Size(50, 50)
        Me.MsgSenderPicture2.TabIndex = 3
        Me.MsgSenderPicture2.TabStop = False
        '
        'MsgSenderPicture1
        '
        Me.MsgSenderPicture1.BackgroundImage = Global.KidWatch.My.Resources.Resources.BartSimpson13
        Me.MsgSenderPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MsgSenderPicture1.Location = New System.Drawing.Point(53, 26)
        Me.MsgSenderPicture1.Name = "MsgSenderPicture1"
        Me.MsgSenderPicture1.Size = New System.Drawing.Size(50, 50)
        Me.MsgSenderPicture1.TabIndex = 2
        Me.MsgSenderPicture1.TabStop = False
        '
        'Sending
        '
        Me.Sending.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.Sending.Controls.Add(Me.SentPicture)
        Me.Sending.Controls.Add(Me.CancelPicture)
        Me.Sending.Controls.Add(Me.ConfirmPicture)
        Me.Sending.Controls.Add(Me.HelloButton)
        Me.Sending.Controls.Add(Me.SendingAddPicture)
        Me.Sending.Controls.Add(Me.SendExistingPicture)
        Me.Sending.Controls.Add(Me.SendingTypePicture)
        Me.Sending.Controls.Add(Me.SendingToPicture)
        Me.Sending.Location = New System.Drawing.Point(4, 22)
        Me.Sending.Name = "Sending"
        Me.Sending.Padding = New System.Windows.Forms.Padding(3)
        Me.Sending.Size = New System.Drawing.Size(153, 154)
        Me.Sending.TabIndex = 11
        Me.Sending.Text = "Sending"
        Me.Sending.UseVisualStyleBackColor = True
        '
        'SentPicture
        '
        Me.SentPicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.forward_512
        Me.SentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SentPicture.Location = New System.Drawing.Point(26, 27)
        Me.SentPicture.Name = "SentPicture"
        Me.SentPicture.Size = New System.Drawing.Size(100, 100)
        Me.SentPicture.TabIndex = 8
        Me.SentPicture.TabStop = False
        Me.SentPicture.Visible = False
        '
        'CancelPicture
        '
        Me.CancelPicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.x_mark_4_512
        Me.CancelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelPicture.Location = New System.Drawing.Point(80, 112)
        Me.CancelPicture.Name = "CancelPicture"
        Me.CancelPicture.Size = New System.Drawing.Size(70, 40)
        Me.CancelPicture.TabIndex = 7
        Me.CancelPicture.TabStop = False
        '
        'ConfirmPicture
        '
        Me.ConfirmPicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.check_mark_7_512_gray
        Me.ConfirmPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ConfirmPicture.Location = New System.Drawing.Point(5, 112)
        Me.ConfirmPicture.Name = "ConfirmPicture"
        Me.ConfirmPicture.Size = New System.Drawing.Size(70, 40)
        Me.ConfirmPicture.TabIndex = 6
        Me.ConfirmPicture.TabStop = False
        '
        'HelloButton
        '
        Me.HelloButton.Location = New System.Drawing.Point(3, 65)
        Me.HelloButton.Name = "HelloButton"
        Me.HelloButton.Size = New System.Drawing.Size(75, 23)
        Me.HelloButton.TabIndex = 4
        Me.HelloButton.Text = "HIHIHIHI~"
        Me.HelloButton.UseVisualStyleBackColor = True
        '
        'SendingAddPicture
        '
        Me.SendingAddPicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.plus_6_24
        Me.SendingAddPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SendingAddPicture.Location = New System.Drawing.Point(119, 79)
        Me.SendingAddPicture.Name = "SendingAddPicture"
        Me.SendingAddPicture.Size = New System.Drawing.Size(28, 27)
        Me.SendingAddPicture.TabIndex = 3
        Me.SendingAddPicture.TabStop = False
        '
        'SendExistingPicture
        '
        Me.SendExistingPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SendExistingPicture.Location = New System.Drawing.Point(6, 46)
        Me.SendExistingPicture.Name = "SendExistingPicture"
        Me.SendExistingPicture.Size = New System.Drawing.Size(60, 60)
        Me.SendExistingPicture.TabIndex = 2
        Me.SendExistingPicture.TabStop = False
        '
        'SendingTypePicture
        '
        Me.SendingTypePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SendingTypePicture.Location = New System.Drawing.Point(87, 46)
        Me.SendingTypePicture.Name = "SendingTypePicture"
        Me.SendingTypePicture.Size = New System.Drawing.Size(60, 60)
        Me.SendingTypePicture.TabIndex = 1
        Me.SendingTypePicture.TabStop = False
        '
        'SendingToPicture
        '
        Me.SendingToPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SendingToPicture.Location = New System.Drawing.Point(58, 0)
        Me.SendingToPicture.Name = "SendingToPicture"
        Me.SendingToPicture.Size = New System.Drawing.Size(40, 40)
        Me.SendingToPicture.TabIndex = 0
        Me.SendingToPicture.TabStop = False
        '
        'SendMessage
        '
        Me.SendMessage.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.SendMessage.Controls.Add(Me.TextMessageBox)
        Me.SendMessage.Controls.Add(Me.VideoMessageBox)
        Me.SendMessage.Controls.Add(Me.PictureMessageBox)
        Me.SendMessage.Controls.Add(Me.VoiceMessageBox)
        Me.SendMessage.Location = New System.Drawing.Point(4, 22)
        Me.SendMessage.Name = "SendMessage"
        Me.SendMessage.Padding = New System.Windows.Forms.Padding(3)
        Me.SendMessage.Size = New System.Drawing.Size(153, 154)
        Me.SendMessage.TabIndex = 10
        Me.SendMessage.Text = "SendMsg"
        Me.SendMessage.UseVisualStyleBackColor = True
        '
        'TextMessageBox
        '
        Me.TextMessageBox.BackgroundImage = Global.KidWatch.My.Resources.Resources.chat_4_512
        Me.TextMessageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TextMessageBox.Location = New System.Drawing.Point(7, 6)
        Me.TextMessageBox.Name = "TextMessageBox"
        Me.TextMessageBox.Size = New System.Drawing.Size(60, 60)
        Me.TextMessageBox.TabIndex = 3
        Me.TextMessageBox.TabStop = False
        '
        'VideoMessageBox
        '
        Me.VideoMessageBox.BackgroundImage = Global.KidWatch.My.Resources.Resources.video_call_512
        Me.VideoMessageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VideoMessageBox.Location = New System.Drawing.Point(84, 83)
        Me.VideoMessageBox.Name = "VideoMessageBox"
        Me.VideoMessageBox.Size = New System.Drawing.Size(60, 60)
        Me.VideoMessageBox.TabIndex = 2
        Me.VideoMessageBox.TabStop = False
        '
        'PictureMessageBox
        '
        Me.PictureMessageBox.BackgroundImage = Global.KidWatch.My.Resources.Resources.picture_512
        Me.PictureMessageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureMessageBox.Location = New System.Drawing.Point(7, 83)
        Me.PictureMessageBox.Name = "PictureMessageBox"
        Me.PictureMessageBox.Size = New System.Drawing.Size(60, 60)
        Me.PictureMessageBox.TabIndex = 1
        Me.PictureMessageBox.TabStop = False
        '
        'VoiceMessageBox
        '
        Me.VoiceMessageBox.BackgroundImage = Global.KidWatch.My.Resources.Resources.microphone_512
        Me.VoiceMessageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VoiceMessageBox.Location = New System.Drawing.Point(86, 6)
        Me.VoiceMessageBox.Name = "VoiceMessageBox"
        Me.VoiceMessageBox.Size = New System.Drawing.Size(60, 60)
        Me.VoiceMessageBox.TabIndex = 0
        Me.VoiceMessageBox.TabStop = False
        '
        'Faces
        '
        Me.Faces.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.Faces.Controls.Add(Me.Face4)
        Me.Faces.Controls.Add(Me.Face3)
        Me.Faces.Controls.Add(Me.Face2)
        Me.Faces.Controls.Add(Me.Face1)
        Me.Faces.Location = New System.Drawing.Point(4, 22)
        Me.Faces.Name = "Faces"
        Me.Faces.Padding = New System.Windows.Forms.Padding(3)
        Me.Faces.Size = New System.Drawing.Size(153, 154)
        Me.Faces.TabIndex = 9
        Me.Faces.Text = "Faces"
        Me.Faces.UseVisualStyleBackColor = True
        '
        'Face4
        '
        Me.Face4.BackgroundImage = Global.KidWatch.My.Resources.Resources._1291876726031
        Me.Face4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Face4.Location = New System.Drawing.Point(84, 84)
        Me.Face4.Name = "Face4"
        Me.Face4.Size = New System.Drawing.Size(50, 50)
        Me.Face4.TabIndex = 3
        Me.Face4.UseVisualStyleBackColor = True
        '
        'Face3
        '
        Me.Face3.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_6_512_blue
        Me.Face3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Face3.Location = New System.Drawing.Point(15, 84)
        Me.Face3.Name = "Face3"
        Me.Face3.Size = New System.Drawing.Size(50, 50)
        Me.Face3.TabIndex = 2
        Me.Face3.UseVisualStyleBackColor = True
        '
        'Face2
        '
        Me.Face2.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_6_512_black
        Me.Face2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Face2.Location = New System.Drawing.Point(84, 20)
        Me.Face2.Name = "Face2"
        Me.Face2.Size = New System.Drawing.Size(50, 50)
        Me.Face2.TabIndex = 1
        Me.Face2.UseVisualStyleBackColor = True
        '
        'Face1
        '
        Me.Face1.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_6_512_red
        Me.Face1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Face1.Location = New System.Drawing.Point(15, 19)
        Me.Face1.Name = "Face1"
        Me.Face1.Size = New System.Drawing.Size(50, 50)
        Me.Face1.TabIndex = 0
        Me.Face1.UseVisualStyleBackColor = True
        '
        'Reminder
        '
        Me.Reminder.Controls.Add(Me.dismissReminder)
        Me.Reminder.Controls.Add(Me.Label4)
        Me.Reminder.Controls.Add(Me.Label3)
        Me.Reminder.Controls.Add(Me.Label2)
        Me.Reminder.Location = New System.Drawing.Point(4, 22)
        Me.Reminder.Name = "Reminder"
        Me.Reminder.Size = New System.Drawing.Size(153, 154)
        Me.Reminder.TabIndex = 8
        Me.Reminder.Text = "Reminder"
        Me.Reminder.UseVisualStyleBackColor = True
        '
        'dismissReminder
        '
        Me.dismissReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dismissReminder.Location = New System.Drawing.Point(8, 120)
        Me.dismissReminder.Name = "dismissReminder"
        Me.dismissReminder.Size = New System.Drawing.Size(134, 23)
        Me.dismissReminder.TabIndex = 3
        Me.dismissReminder.Text = "Dismiss"
        Me.dismissReminder.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "happening now!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 61)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Meet Jason to exchange pokemon cards outside of gym"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Event Reminder"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CallPage
        '
        Me.CallPage.Controls.Add(Me.CallerPicture)
        Me.CallPage.Controls.Add(Me.HangUpBtn)
        Me.CallPage.Controls.Add(Me.AcceptBtn)
        Me.CallPage.Controls.Add(Me.CallingPicture)
        Me.CallPage.Location = New System.Drawing.Point(4, 22)
        Me.CallPage.Name = "CallPage"
        Me.CallPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CallPage.Size = New System.Drawing.Size(153, 154)
        Me.CallPage.TabIndex = 7
        Me.CallPage.Text = "CallPage"
        Me.CallPage.UseVisualStyleBackColor = True
        '
        'CallerPicture
        '
        Me.CallerPicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.marge
        Me.CallerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CallerPicture.Location = New System.Drawing.Point(43, -1)
        Me.CallerPicture.Name = "CallerPicture"
        Me.CallerPicture.Size = New System.Drawing.Size(100, 100)
        Me.CallerPicture.TabIndex = 4
        Me.CallerPicture.TabStop = False
        '
        'HangUpBtn
        '
        Me.HangUpBtn.BackgroundImage = Global.KidWatch.My.Resources.Resources.no_phone_call
        Me.HangUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HangUpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HangUpBtn.ForeColor = System.Drawing.Color.Red
        Me.HangUpBtn.Location = New System.Drawing.Point(78, 99)
        Me.HangUpBtn.Name = "HangUpBtn"
        Me.HangUpBtn.Size = New System.Drawing.Size(70, 50)
        Me.HangUpBtn.TabIndex = 3
        Me.HangUpBtn.UseVisualStyleBackColor = True
        '
        'AcceptBtn
        '
        Me.AcceptBtn.BackgroundImage = Global.KidWatch.My.Resources.Resources.call_512
        Me.AcceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AcceptBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceptBtn.ForeColor = System.Drawing.Color.Green
        Me.AcceptBtn.Location = New System.Drawing.Point(5, 99)
        Me.AcceptBtn.Name = "AcceptBtn"
        Me.AcceptBtn.Size = New System.Drawing.Size(70, 50)
        Me.AcceptBtn.TabIndex = 2
        Me.AcceptBtn.UseVisualStyleBackColor = True
        Me.AcceptBtn.Visible = False
        '
        'CallingPicture
        '
        Me.CallingPicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.call_512
        Me.CallingPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CallingPicture.Location = New System.Drawing.Point(0, -1)
        Me.CallingPicture.Name = "CallingPicture"
        Me.CallingPicture.Size = New System.Drawing.Size(43, 44)
        Me.CallingPicture.TabIndex = 1
        Me.CallingPicture.TabStop = False
        '
        'PhoneBook
        '
        Me.PhoneBook.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.PhoneBook.Controls.Add(Me.CallJesBtn)
        Me.PhoneBook.Controls.Add(Me.CallThomasBtn)
        Me.PhoneBook.Controls.Add(Me.CallDadBtn)
        Me.PhoneBook.Controls.Add(Me.CallMomBtn)
        Me.PhoneBook.Location = New System.Drawing.Point(4, 22)
        Me.PhoneBook.Name = "PhoneBook"
        Me.PhoneBook.Padding = New System.Windows.Forms.Padding(3)
        Me.PhoneBook.Size = New System.Drawing.Size(153, 154)
        Me.PhoneBook.TabIndex = 6
        Me.PhoneBook.Text = "PhoneBook"
        Me.PhoneBook.UseVisualStyleBackColor = True
        '
        'CallJesBtn
        '
        Me.CallJesBtn.BackgroundImage = Global.KidWatch.My.Resources.Resources.Lisa_Simpson
        Me.CallJesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CallJesBtn.Location = New System.Drawing.Point(77, 74)
        Me.CallJesBtn.Name = "CallJesBtn"
        Me.CallJesBtn.Size = New System.Drawing.Size(70, 70)
        Me.CallJesBtn.TabIndex = 4
        Me.CallJesBtn.UseVisualStyleBackColor = True
        '
        'CallThomasBtn
        '
        Me.CallThomasBtn.BackgroundImage = Global.KidWatch.My.Resources.Resources.BartSimpson13
        Me.CallThomasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CallThomasBtn.Location = New System.Drawing.Point(-2, 74)
        Me.CallThomasBtn.Name = "CallThomasBtn"
        Me.CallThomasBtn.Size = New System.Drawing.Size(70, 70)
        Me.CallThomasBtn.TabIndex = 3
        Me.CallThomasBtn.UseVisualStyleBackColor = True
        '
        'CallDadBtn
        '
        Me.CallDadBtn.BackgroundImage = Global.KidWatch.My.Resources.Resources.homerpoint
        Me.CallDadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CallDadBtn.Location = New System.Drawing.Point(77, 0)
        Me.CallDadBtn.Name = "CallDadBtn"
        Me.CallDadBtn.Size = New System.Drawing.Size(70, 70)
        Me.CallDadBtn.TabIndex = 2
        Me.CallDadBtn.UseVisualStyleBackColor = True
        '
        'CallMomBtn
        '
        Me.CallMomBtn.BackgroundImage = Global.KidWatch.My.Resources.Resources.marge
        Me.CallMomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CallMomBtn.Location = New System.Drawing.Point(-2, 1)
        Me.CallMomBtn.Name = "CallMomBtn"
        Me.CallMomBtn.Size = New System.Drawing.Size(70, 70)
        Me.CallMomBtn.TabIndex = 1
        Me.CallMomBtn.UseVisualStyleBackColor = True
        '
        'Playlist
        '
        Me.Playlist.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.Playlist.Controls.Add(Me.PlaylistIcon2)
        Me.Playlist.Controls.Add(Me.PlaylistIcon1)
        Me.Playlist.Controls.Add(Me.Playlist2)
        Me.Playlist.Controls.Add(Me.Playlist1)
        Me.Playlist.Location = New System.Drawing.Point(4, 22)
        Me.Playlist.Name = "Playlist"
        Me.Playlist.Padding = New System.Windows.Forms.Padding(3)
        Me.Playlist.Size = New System.Drawing.Size(153, 154)
        Me.Playlist.TabIndex = 5
        Me.Playlist.Text = "Playlist"
        Me.Playlist.UseVisualStyleBackColor = True
        '
        'PlaylistIcon2
        '
        Me.PlaylistIcon2.BackgroundImage = Global.KidWatch.My.Resources.Resources.video_5_512
        Me.PlaylistIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaylistIcon2.Location = New System.Drawing.Point(21, 72)
        Me.PlaylistIcon2.Name = "PlaylistIcon2"
        Me.PlaylistIcon2.Size = New System.Drawing.Size(30, 30)
        Me.PlaylistIcon2.TabIndex = 3
        Me.PlaylistIcon2.TabStop = False
        '
        'PlaylistIcon1
        '
        Me.PlaylistIcon1.BackgroundImage = Global.KidWatch.My.Resources.Resources.star_6_512
        Me.PlaylistIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaylistIcon1.Location = New System.Drawing.Point(21, 36)
        Me.PlaylistIcon1.Name = "PlaylistIcon1"
        Me.PlaylistIcon1.Size = New System.Drawing.Size(30, 30)
        Me.PlaylistIcon1.TabIndex = 2
        Me.PlaylistIcon1.TabStop = False
        '
        'Playlist2
        '
        Me.Playlist2.AutoSize = True
        Me.Playlist2.Location = New System.Drawing.Point(53, 44)
        Me.Playlist2.Name = "Playlist2"
        Me.Playlist2.Size = New System.Drawing.Size(84, 13)
        Me.Playlist2.TabIndex = 1
        Me.Playlist2.Text = "Favourite Songs"
        '
        'Playlist1
        '
        Me.Playlist1.AutoSize = True
        Me.Playlist1.Location = New System.Drawing.Point(53, 79)
        Me.Playlist1.Name = "Playlist1"
        Me.Playlist1.Size = New System.Drawing.Size(39, 13)
        Me.Playlist1.TabIndex = 0
        Me.Playlist1.Text = "Disney"
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
        'Calendar
        '
        Me.Calendar.Controls.Add(Me.WeekdaySelect7)
        Me.Calendar.Controls.Add(Me.WeekdaySelect6)
        Me.Calendar.Controls.Add(Me.WeekdaySelect5)
        Me.Calendar.Controls.Add(Me.WeekdaySelect4)
        Me.Calendar.Controls.Add(Me.WeekdaySelect3)
        Me.Calendar.Controls.Add(Me.WeekdaySelect2)
        Me.Calendar.Controls.Add(Me.WeekdaySelect1)
        Me.Calendar.Controls.Add(Me.EventPicture2)
        Me.Calendar.Controls.Add(Me.EventPicture1)
        Me.Calendar.Controls.Add(Me.dayButton)
        Me.Calendar.Controls.Add(Me.dayEventTime2)
        Me.Calendar.Controls.Add(Me.dayEventName2)
        Me.Calendar.Controls.Add(Me.dayEventTime1)
        Me.Calendar.Controls.Add(Me.dayEventName1)
        Me.Calendar.Controls.Add(Me.day7Button)
        Me.Calendar.Controls.Add(Me.day6Button)
        Me.Calendar.Controls.Add(Me.day5Button)
        Me.Calendar.Controls.Add(Me.day4Button)
        Me.Calendar.Controls.Add(Me.day3Button)
        Me.Calendar.Controls.Add(Me.day2Button)
        Me.Calendar.Controls.Add(Me.day1Button)
        Me.Calendar.Controls.Add(Me.weekButton)
        Me.Calendar.Controls.Add(Me.PictureBox5)
        Me.Calendar.Location = New System.Drawing.Point(4, 22)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.Padding = New System.Windows.Forms.Padding(3)
        Me.Calendar.Size = New System.Drawing.Size(153, 154)
        Me.Calendar.TabIndex = 3
        Me.Calendar.Text = "Calendar"
        Me.Calendar.UseVisualStyleBackColor = True
        '
        'WeekdaySelect7
        '
        Me.WeekdaySelect7.BackColor = System.Drawing.Color.LightGray
        Me.WeekdaySelect7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeekdaySelect7.Location = New System.Drawing.Point(85, 14)
        Me.WeekdaySelect7.Name = "WeekdaySelect7"
        Me.WeekdaySelect7.Size = New System.Drawing.Size(14, 14)
        Me.WeekdaySelect7.TabIndex = 29
        Me.WeekdaySelect7.TabStop = False
        '
        'WeekdaySelect6
        '
        Me.WeekdaySelect6.BackColor = System.Drawing.Color.LightGray
        Me.WeekdaySelect6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeekdaySelect6.Location = New System.Drawing.Point(71, 14)
        Me.WeekdaySelect6.Name = "WeekdaySelect6"
        Me.WeekdaySelect6.Size = New System.Drawing.Size(14, 14)
        Me.WeekdaySelect6.TabIndex = 28
        Me.WeekdaySelect6.TabStop = False
        '
        'WeekdaySelect5
        '
        Me.WeekdaySelect5.BackColor = System.Drawing.Color.LightGray
        Me.WeekdaySelect5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeekdaySelect5.Location = New System.Drawing.Point(57, 14)
        Me.WeekdaySelect5.Name = "WeekdaySelect5"
        Me.WeekdaySelect5.Size = New System.Drawing.Size(14, 14)
        Me.WeekdaySelect5.TabIndex = 27
        Me.WeekdaySelect5.TabStop = False
        '
        'WeekdaySelect4
        '
        Me.WeekdaySelect4.BackColor = System.Drawing.Color.LightGray
        Me.WeekdaySelect4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeekdaySelect4.Location = New System.Drawing.Point(43, 14)
        Me.WeekdaySelect4.Name = "WeekdaySelect4"
        Me.WeekdaySelect4.Size = New System.Drawing.Size(14, 14)
        Me.WeekdaySelect4.TabIndex = 26
        Me.WeekdaySelect4.TabStop = False
        '
        'WeekdaySelect3
        '
        Me.WeekdaySelect3.BackColor = System.Drawing.Color.LightGray
        Me.WeekdaySelect3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeekdaySelect3.Location = New System.Drawing.Point(29, 14)
        Me.WeekdaySelect3.Name = "WeekdaySelect3"
        Me.WeekdaySelect3.Size = New System.Drawing.Size(14, 14)
        Me.WeekdaySelect3.TabIndex = 25
        Me.WeekdaySelect3.TabStop = False
        '
        'WeekdaySelect2
        '
        Me.WeekdaySelect2.BackColor = System.Drawing.Color.LightGray
        Me.WeekdaySelect2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeekdaySelect2.Location = New System.Drawing.Point(15, 14)
        Me.WeekdaySelect2.Name = "WeekdaySelect2"
        Me.WeekdaySelect2.Size = New System.Drawing.Size(14, 14)
        Me.WeekdaySelect2.TabIndex = 24
        Me.WeekdaySelect2.TabStop = False
        '
        'WeekdaySelect1
        '
        Me.WeekdaySelect1.BackColor = System.Drawing.Color.LightGray
        Me.WeekdaySelect1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeekdaySelect1.Location = New System.Drawing.Point(1, 14)
        Me.WeekdaySelect1.Name = "WeekdaySelect1"
        Me.WeekdaySelect1.Size = New System.Drawing.Size(14, 14)
        Me.WeekdaySelect1.TabIndex = 23
        Me.WeekdaySelect1.TabStop = False
        '
        'EventPicture2
        '
        Me.EventPicture2.BackgroundImage = Global.KidWatch.My.Resources.Resources.doctor_suitecase_512
        Me.EventPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EventPicture2.Location = New System.Drawing.Point(0, 93)
        Me.EventPicture2.Name = "EventPicture2"
        Me.EventPicture2.Size = New System.Drawing.Size(50, 50)
        Me.EventPicture2.TabIndex = 22
        Me.EventPicture2.TabStop = False
        Me.EventPicture2.Visible = False
        '
        'EventPicture1
        '
        Me.EventPicture1.BackgroundImage = Global.KidWatch.My.Resources.Resources.birthday_cake_512
        Me.EventPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EventPicture1.Location = New System.Drawing.Point(0, 40)
        Me.EventPicture1.Name = "EventPicture1"
        Me.EventPicture1.Size = New System.Drawing.Size(50, 50)
        Me.EventPicture1.TabIndex = 21
        Me.EventPicture1.TabStop = False
        Me.EventPicture1.Visible = False
        '
        'dayButton
        '
        Me.dayButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.today_512
        Me.dayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dayButton.Location = New System.Drawing.Point(101, 0)
        Me.dayButton.Name = "dayButton"
        Me.dayButton.Size = New System.Drawing.Size(40, 40)
        Me.dayButton.TabIndex = 20
        Me.dayButton.UseVisualStyleBackColor = True
        Me.dayButton.Visible = False
        '
        'dayEventTime2
        '
        Me.dayEventTime2.AutoSize = True
        Me.dayEventTime2.Location = New System.Drawing.Point(50, 119)
        Me.dayEventTime2.Name = "dayEventTime2"
        Me.dayEventTime2.Size = New System.Drawing.Size(34, 13)
        Me.dayEventTime2.TabIndex = 17
        Me.dayEventTime2.Text = "10:45"
        Me.dayEventTime2.Visible = False
        '
        'dayEventName2
        '
        Me.dayEventName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayEventName2.Location = New System.Drawing.Point(50, 94)
        Me.dayEventName2.MaximumSize = New System.Drawing.Size(134, 25)
        Me.dayEventName2.Name = "dayEventName2"
        Me.dayEventName2.Size = New System.Drawing.Size(134, 25)
        Me.dayEventName2.TabIndex = 16
        Me.dayEventName2.Text = "bedtime"
        Me.dayEventName2.Visible = False
        '
        'dayEventTime1
        '
        Me.dayEventTime1.AutoSize = True
        Me.dayEventTime1.Location = New System.Drawing.Point(50, 65)
        Me.dayEventTime1.Name = "dayEventTime1"
        Me.dayEventTime1.Size = New System.Drawing.Size(34, 13)
        Me.dayEventTime1.TabIndex = 15
        Me.dayEventTime1.Text = "10:45"
        Me.dayEventTime1.Visible = False
        '
        'dayEventName1
        '
        Me.dayEventName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayEventName1.Location = New System.Drawing.Point(50, 40)
        Me.dayEventName1.MaximumSize = New System.Drawing.Size(134, 25)
        Me.dayEventName1.Name = "dayEventName1"
        Me.dayEventName1.Size = New System.Drawing.Size(134, 25)
        Me.dayEventName1.TabIndex = 14
        Me.dayEventName1.Text = "pizza at roccos"
        Me.dayEventName1.Visible = False
        '
        'day7Button
        '
        Me.day7Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day7Button.FlatAppearance.BorderSize = 0
        Me.day7Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day7Button.Location = New System.Drawing.Point(95, 103)
        Me.day7Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day7Button.Name = "day7Button"
        Me.day7Button.Size = New System.Drawing.Size(37, 37)
        Me.day7Button.TabIndex = 13
        Me.day7Button.Tag = "7"
        Me.day7Button.Text = "S 0"
        Me.day7Button.UseVisualStyleBackColor = False
        '
        'day6Button
        '
        Me.day6Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day6Button.FlatAppearance.BorderSize = 0
        Me.day6Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day6Button.Location = New System.Drawing.Point(58, 103)
        Me.day6Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day6Button.Name = "day6Button"
        Me.day6Button.Size = New System.Drawing.Size(37, 37)
        Me.day6Button.TabIndex = 12
        Me.day6Button.Tag = "6"
        Me.day6Button.Text = "F 1"
        Me.day6Button.UseVisualStyleBackColor = False
        '
        'day5Button
        '
        Me.day5Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day5Button.FlatAppearance.BorderSize = 0
        Me.day5Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day5Button.Location = New System.Drawing.Point(21, 103)
        Me.day5Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day5Button.Name = "day5Button"
        Me.day5Button.Size = New System.Drawing.Size(37, 37)
        Me.day5Button.TabIndex = 11
        Me.day5Button.Tag = "5"
        Me.day5Button.Text = "T 2"
        Me.day5Button.UseVisualStyleBackColor = False
        '
        'day4Button
        '
        Me.day4Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day4Button.FlatAppearance.BorderSize = 0
        Me.day4Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day4Button.Location = New System.Drawing.Point(118, 57)
        Me.day4Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day4Button.Name = "day4Button"
        Me.day4Button.Size = New System.Drawing.Size(37, 37)
        Me.day4Button.TabIndex = 10
        Me.day4Button.Tag = "4"
        Me.day4Button.Text = "W 0"
        Me.day4Button.UseVisualStyleBackColor = False
        '
        'day3Button
        '
        Me.day3Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day3Button.FlatAppearance.BorderSize = 0
        Me.day3Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day3Button.Location = New System.Drawing.Point(78, 57)
        Me.day3Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day3Button.Name = "day3Button"
        Me.day3Button.Size = New System.Drawing.Size(37, 37)
        Me.day3Button.TabIndex = 9
        Me.day3Button.Tag = "3"
        Me.day3Button.Text = "T 1"
        Me.day3Button.UseVisualStyleBackColor = False
        '
        'day2Button
        '
        Me.day2Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day2Button.FlatAppearance.BorderSize = 0
        Me.day2Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day2Button.Location = New System.Drawing.Point(38, 57)
        Me.day2Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day2Button.Name = "day2Button"
        Me.day2Button.Size = New System.Drawing.Size(37, 37)
        Me.day2Button.TabIndex = 8
        Me.day2Button.Tag = "2"
        Me.day2Button.Text = "M 1"
        Me.day2Button.UseVisualStyleBackColor = False
        '
        'day1Button
        '
        Me.day1Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.day1Button.FlatAppearance.BorderSize = 0
        Me.day1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.day1Button.Location = New System.Drawing.Point(-2, 57)
        Me.day1Button.Margin = New System.Windows.Forms.Padding(0)
        Me.day1Button.Name = "day1Button"
        Me.day1Button.Size = New System.Drawing.Size(37, 37)
        Me.day1Button.TabIndex = 7
        Me.day1Button.Tag = "1"
        Me.day1Button.Text = "S 0"
        Me.day1Button.UseVisualStyleBackColor = False
        '
        'weekButton
        '
        Me.weekButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.calendar_3_512
        Me.weekButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.weekButton.Location = New System.Drawing.Point(100, -2)
        Me.weekButton.Name = "weekButton"
        Me.weekButton.Size = New System.Drawing.Size(40, 40)
        Me.weekButton.TabIndex = 3
        Me.weekButton.UseVisualStyleBackColor = True
        Me.weekButton.Visible = False
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
        'Clock
        '
        Me.Clock.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.Clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Clock.Controls.Add(Me.DisruptiveToggleButton)
        Me.Clock.Controls.Add(Me.ChangeFace)
        Me.Clock.Controls.Add(Me.ClockDate)
        Me.Clock.Controls.Add(Me.ClockTime)
        Me.Clock.Location = New System.Drawing.Point(4, 22)
        Me.Clock.Name = "Clock"
        Me.Clock.Padding = New System.Windows.Forms.Padding(3)
        Me.Clock.Size = New System.Drawing.Size(153, 154)
        Me.Clock.TabIndex = 2
        Me.Clock.Text = "Clock"
        Me.Clock.UseVisualStyleBackColor = True
        '
        'DisruptiveToggleButton
        '
        Me.DisruptiveToggleButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.speaker_512_black
        Me.DisruptiveToggleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DisruptiveToggleButton.Location = New System.Drawing.Point(10, 105)
        Me.DisruptiveToggleButton.Name = "DisruptiveToggleButton"
        Me.DisruptiveToggleButton.Size = New System.Drawing.Size(35, 35)
        Me.DisruptiveToggleButton.TabIndex = 4
        Me.DisruptiveToggleButton.UseVisualStyleBackColor = True
        '
        'ChangeFace
        '
        Me.ChangeFace.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_6_512_black
        Me.ChangeFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChangeFace.Location = New System.Drawing.Point(104, 105)
        Me.ChangeFace.Name = "ChangeFace"
        Me.ChangeFace.Size = New System.Drawing.Size(35, 35)
        Me.ChangeFace.TabIndex = 3
        Me.ChangeFace.UseVisualStyleBackColor = True
        '
        'ClockDate
        '
        Me.ClockDate.AutoSize = True
        Me.ClockDate.BackColor = System.Drawing.Color.Transparent
        Me.ClockDate.Location = New System.Drawing.Point(45, 20)
        Me.ClockDate.Name = "ClockDate"
        Me.ClockDate.Size = New System.Drawing.Size(61, 13)
        Me.ClockDate.TabIndex = 2
        Me.ClockDate.Text = "1111-11-11"
        '
        'ClockTime
        '
        Me.ClockTime.AutoSize = True
        Me.ClockTime.BackColor = System.Drawing.Color.Transparent
        Me.ClockTime.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockTime.Location = New System.Drawing.Point(29, 50)
        Me.ClockTime.Name = "ClockTime"
        Me.ClockTime.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ClockTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClockTime.Size = New System.Drawing.Size(95, 54)
        Me.ClockTime.TabIndex = 1
        Me.ClockTime.Text = "07:45"
        Me.ClockTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Main
        '
        Me.Main.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Main.Controls.Add(Me.MessagesButton)
        Me.Main.Controls.Add(Me.ContactsButton)
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
        'MessagesButton
        '
        Me.MessagesButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.read_message_512
        Me.MessagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MessagesButton.Location = New System.Drawing.Point(86, 126)
        Me.MessagesButton.Name = "MessagesButton"
        Me.MessagesButton.Size = New System.Drawing.Size(50, 50)
        Me.MessagesButton.TabIndex = 7
        Me.MessagesButton.UseVisualStyleBackColor = True
        '
        'ContactsButton
        '
        Me.ContactsButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.conference_512
        Me.ContactsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactsButton.Location = New System.Drawing.Point(14, 126)
        Me.ContactsButton.Name = "ContactsButton"
        Me.ContactsButton.Size = New System.Drawing.Size(50, 50)
        Me.ContactsButton.TabIndex = 6
        Me.ContactsButton.UseVisualStyleBackColor = True
        '
        'ClockButton
        '
        Me.ClockButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.time_10_512
        Me.ClockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClockButton.Location = New System.Drawing.Point(12, 52)
        Me.ClockButton.Name = "ClockButton"
        Me.ClockButton.Size = New System.Drawing.Size(50, 50)
        Me.ClockButton.TabIndex = 5
        Me.ClockButton.UseVisualStyleBackColor = True
        '
        'callButton
        '
        Me.callButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.phone_icon
        Me.callButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.callButton.Location = New System.Drawing.Point(86, 52)
        Me.callButton.Name = "callButton"
        Me.callButton.Size = New System.Drawing.Size(50, 50)
        Me.callButton.TabIndex = 4
        Me.callButton.UseVisualStyleBackColor = True
        '
        'CalendarButton
        '
        Me.CalendarButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.calendar_3_512
        Me.CalendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CalendarButton.Location = New System.Drawing.Point(14, -21)
        Me.CalendarButton.Name = "CalendarButton"
        Me.CalendarButton.Size = New System.Drawing.Size(50, 50)
        Me.CalendarButton.TabIndex = 3
        Me.CalendarButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.music_icon
        Me.MusicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MusicButton.Location = New System.Drawing.Point(86, -21)
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
        Me.WatchBgImg.Size = New System.Drawing.Size(157, 151)
        Me.WatchBgImg.TabIndex = 0
        Me.WatchBgImg.TabStop = False
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
        Me.MainTabControl.Controls.Add(Me.Reminder)
        Me.MainTabControl.Controls.Add(Me.Faces)
        Me.MainTabControl.Controls.Add(Me.SendMessage)
        Me.MainTabControl.Controls.Add(Me.Sending)
        Me.MainTabControl.Controls.Add(Me.MessageCentre)
        Me.MainTabControl.Controls.Add(Me.ViewMessage)
        Me.MainTabControl.Controls.Add(Me.FailedCall)
        Me.MainTabControl.Location = New System.Drawing.Point(-1, 1)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(161, 180)
        Me.MainTabControl.TabIndex = 2
        '
        'FailedCall
        '
        Me.FailedCall.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.FailedCall.Controls.Add(Me.FailedCallerPicture)
        Me.FailedCall.Controls.Add(Me.VoiceMailButton)
        Me.FailedCall.Controls.Add(Me.RedialButton)
        Me.FailedCall.Controls.Add(Me.FailedCallPicture)
        Me.FailedCall.Location = New System.Drawing.Point(4, 22)
        Me.FailedCall.Name = "FailedCall"
        Me.FailedCall.Padding = New System.Windows.Forms.Padding(3)
        Me.FailedCall.Size = New System.Drawing.Size(153, 154)
        Me.FailedCall.TabIndex = 14
        Me.FailedCall.Text = "FailedCall"
        Me.FailedCall.UseVisualStyleBackColor = True
        '
        'FailedCallerPicture
        '
        Me.FailedCallerPicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.marge
        Me.FailedCallerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FailedCallerPicture.Location = New System.Drawing.Point(46, 2)
        Me.FailedCallerPicture.Name = "FailedCallerPicture"
        Me.FailedCallerPicture.Size = New System.Drawing.Size(100, 100)
        Me.FailedCallerPicture.TabIndex = 8
        Me.FailedCallerPicture.TabStop = False
        '
        'VoiceMailButton
        '
        Me.VoiceMailButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.microphone_512_black
        Me.VoiceMailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VoiceMailButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoiceMailButton.ForeColor = System.Drawing.Color.Red
        Me.VoiceMailButton.Location = New System.Drawing.Point(80, 102)
        Me.VoiceMailButton.Name = "VoiceMailButton"
        Me.VoiceMailButton.Size = New System.Drawing.Size(70, 50)
        Me.VoiceMailButton.TabIndex = 7
        Me.VoiceMailButton.UseVisualStyleBackColor = True
        '
        'RedialButton
        '
        Me.RedialButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.call_512
        Me.RedialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RedialButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedialButton.ForeColor = System.Drawing.Color.Green
        Me.RedialButton.Location = New System.Drawing.Point(7, 102)
        Me.RedialButton.Name = "RedialButton"
        Me.RedialButton.Size = New System.Drawing.Size(70, 50)
        Me.RedialButton.TabIndex = 6
        Me.RedialButton.UseVisualStyleBackColor = True
        '
        'FailedCallPicture
        '
        Me.FailedCallPicture.BackgroundImage = Global.KidWatch.My.Resources.Resources.broken_link_512
        Me.FailedCallPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FailedCallPicture.Location = New System.Drawing.Point(2, 2)
        Me.FailedCallPicture.Name = "FailedCallPicture"
        Me.FailedCallPicture.Size = New System.Drawing.Size(43, 44)
        Me.FailedCallPicture.TabIndex = 5
        Me.FailedCallPicture.TabStop = False
        '
        'CallTimer
        '
        Me.CallTimer.Interval = 10000
        '
        'KidWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.KidWatch.My.Resources.Resources.blue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(189, 186)
        Me.Controls.Add(Me.NewMessageButton)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.MainTabControl)
        Me.DoubleBuffered = True
        Me.Name = "KidWatch"
        Me.Text = "KidWatch"
        Me.ViewMessage.ResumeLayout(False)
        Me.ViewMessage.PerformLayout()
        CType(Me.DeleteMessagePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeepMessagePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviewPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessageCentre.ResumeLayout(False)
        Me.MessageCentre.PerformLayout()
        CType(Me.MsgPreviewPicture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsgPreviewPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsgSenderPicture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsgSenderPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sending.ResumeLayout(False)
        CType(Me.SentPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendingAddPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendExistingPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendingTypePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendingToPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SendMessage.ResumeLayout(False)
        CType(Me.TextMessageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideoMessageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMessageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoiceMessageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Faces.ResumeLayout(False)
        Me.Reminder.ResumeLayout(False)
        Me.CallPage.ResumeLayout(False)
        CType(Me.CallerPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CallingPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhoneBook.ResumeLayout(False)
        Me.Playlist.ResumeLayout(False)
        Me.Playlist.PerformLayout()
        CType(Me.PlaylistIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaylistIcon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Disrupt.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Calendar.ResumeLayout(False)
        Me.Calendar.PerformLayout()
        CType(Me.WeekdaySelect7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekdaySelect6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekdaySelect5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekdaySelect4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekdaySelect3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekdaySelect2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekdaySelect1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventPicture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clock.ResumeLayout(False)
        Me.Clock.PerformLayout()
        Me.Music.ResumeLayout(False)
        Me.Music.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main.ResumeLayout(False)
        CType(Me.WatchBgImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTabControl.ResumeLayout(False)
        Me.FailedCall.ResumeLayout(False)
        CType(Me.FailedCallerPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FailedCallPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MusicTimer As System.Windows.Forms.Timer
    Friend WithEvents ClockTimer As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents reminderTimer As System.Windows.Forms.Timer
    Friend WithEvents HomeBtn As System.Windows.Forms.Button
    Friend WithEvents SentTimer As System.Windows.Forms.Timer
    Friend WithEvents NewMessageButton As System.Windows.Forms.Button
    Friend WithEvents ViewMessage As System.Windows.Forms.TabPage
    Friend WithEvents DeleteMessagePicture As System.Windows.Forms.PictureBox
    Friend WithEvents KeepMessagePicture As System.Windows.Forms.PictureBox
    Friend WithEvents PreviewLabel As System.Windows.Forms.Label
    Friend WithEvents PreviewPicture As System.Windows.Forms.PictureBox
    Friend WithEvents MessageCentre As System.Windows.Forms.TabPage
    Friend WithEvents MessageDate2 As System.Windows.Forms.Label
    Friend WithEvents MessageDate1 As System.Windows.Forms.Label
    Friend WithEvents MsgPreviewPicture2 As System.Windows.Forms.PictureBox
    Friend WithEvents MsgPreviewPicture1 As System.Windows.Forms.PictureBox
    Friend WithEvents MsgSenderPicture2 As System.Windows.Forms.PictureBox
    Friend WithEvents MsgSenderPicture1 As System.Windows.Forms.PictureBox
    Friend WithEvents Sending As System.Windows.Forms.TabPage
    Friend WithEvents SentPicture As System.Windows.Forms.PictureBox
    Friend WithEvents CancelPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ConfirmPicture As System.Windows.Forms.PictureBox
    Friend WithEvents HelloButton As System.Windows.Forms.Button
    Friend WithEvents SendingAddPicture As System.Windows.Forms.PictureBox
    Friend WithEvents SendExistingPicture As System.Windows.Forms.PictureBox
    Friend WithEvents SendingTypePicture As System.Windows.Forms.PictureBox
    Friend WithEvents SendingToPicture As System.Windows.Forms.PictureBox
    Friend WithEvents SendMessage As System.Windows.Forms.TabPage
    Friend WithEvents TextMessageBox As System.Windows.Forms.PictureBox
    Friend WithEvents VideoMessageBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureMessageBox As System.Windows.Forms.PictureBox
    Friend WithEvents VoiceMessageBox As System.Windows.Forms.PictureBox
    Friend WithEvents Faces As System.Windows.Forms.TabPage
    Friend WithEvents Face4 As System.Windows.Forms.Button
    Friend WithEvents Face3 As System.Windows.Forms.Button
    Friend WithEvents Face2 As System.Windows.Forms.Button
    Friend WithEvents Face1 As System.Windows.Forms.Button
    Friend WithEvents Reminder As System.Windows.Forms.TabPage
    Friend WithEvents dismissReminder As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CallPage As System.Windows.Forms.TabPage
    Friend WithEvents CallerPicture As System.Windows.Forms.PictureBox
    Friend WithEvents HangUpBtn As System.Windows.Forms.Button
    Friend WithEvents AcceptBtn As System.Windows.Forms.Button
    Friend WithEvents CallingPicture As System.Windows.Forms.PictureBox
    Friend WithEvents PhoneBook As System.Windows.Forms.TabPage
    Friend WithEvents CallJesBtn As System.Windows.Forms.Button
    Friend WithEvents CallThomasBtn As System.Windows.Forms.Button
    Friend WithEvents CallDadBtn As System.Windows.Forms.Button
    Friend WithEvents CallMomBtn As System.Windows.Forms.Button
    Friend WithEvents Playlist As System.Windows.Forms.TabPage
    Friend WithEvents PlaylistIcon2 As System.Windows.Forms.PictureBox
    Friend WithEvents PlaylistIcon1 As System.Windows.Forms.PictureBox
    Friend WithEvents Playlist2 As System.Windows.Forms.Label
    Friend WithEvents Playlist1 As System.Windows.Forms.Label
    Friend WithEvents Disrupt As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Calendar As System.Windows.Forms.TabPage
    Friend WithEvents WeekdaySelect7 As System.Windows.Forms.PictureBox
    Friend WithEvents WeekdaySelect6 As System.Windows.Forms.PictureBox
    Friend WithEvents WeekdaySelect5 As System.Windows.Forms.PictureBox
    Friend WithEvents WeekdaySelect4 As System.Windows.Forms.PictureBox
    Friend WithEvents WeekdaySelect3 As System.Windows.Forms.PictureBox
    Friend WithEvents WeekdaySelect2 As System.Windows.Forms.PictureBox
    Friend WithEvents WeekdaySelect1 As System.Windows.Forms.PictureBox
    Friend WithEvents EventPicture2 As System.Windows.Forms.PictureBox
    Friend WithEvents EventPicture1 As System.Windows.Forms.PictureBox
    Friend WithEvents dayButton As System.Windows.Forms.Button
    Friend WithEvents dayEventTime2 As System.Windows.Forms.Label
    Friend WithEvents dayEventName2 As System.Windows.Forms.Label
    Friend WithEvents dayEventTime1 As System.Windows.Forms.Label
    Friend WithEvents dayEventName1 As System.Windows.Forms.Label
    Friend WithEvents day7Button As System.Windows.Forms.Button
    Friend WithEvents day6Button As System.Windows.Forms.Button
    Friend WithEvents day5Button As System.Windows.Forms.Button
    Friend WithEvents day4Button As System.Windows.Forms.Button
    Friend WithEvents day3Button As System.Windows.Forms.Button
    Friend WithEvents day2Button As System.Windows.Forms.Button
    Friend WithEvents day1Button As System.Windows.Forms.Button
    Friend WithEvents weekButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Clock As System.Windows.Forms.TabPage
    Friend WithEvents ChangeFace As System.Windows.Forms.Button
    Friend WithEvents ClockDate As System.Windows.Forms.Label
    Friend WithEvents ClockTime As System.Windows.Forms.Label
    Friend WithEvents Music As System.Windows.Forms.TabPage
    Friend WithEvents RepeatButton As System.Windows.Forms.Button
    Friend WithEvents ShufftleButton As System.Windows.Forms.Button
    Friend WithEvents PlaylistButton As System.Windows.Forms.Button
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents NowPlaying As System.Windows.Forms.Label
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Main As System.Windows.Forms.TabPage
    Friend WithEvents MessagesButton As System.Windows.Forms.Button
    Friend WithEvents ContactsButton As System.Windows.Forms.Button
    Friend WithEvents ClockButton As System.Windows.Forms.Button
    Friend WithEvents callButton As System.Windows.Forms.Button
    Friend WithEvents CalendarButton As System.Windows.Forms.Button
    Friend WithEvents MusicButton As System.Windows.Forms.Button
    Friend WithEvents WatchBgImg As System.Windows.Forms.PictureBox
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents MessageTime2 As System.Windows.Forms.Label
    Friend WithEvents MessageTime1 As System.Windows.Forms.Label
    Friend WithEvents DisruptiveToggleButton As System.Windows.Forms.Button
    Friend WithEvents FailedCall As System.Windows.Forms.TabPage
    Friend WithEvents CallTimer As System.Windows.Forms.Timer
    Friend WithEvents FailedCallerPicture As System.Windows.Forms.PictureBox
    Friend WithEvents VoiceMailButton As System.Windows.Forms.Button
    Friend WithEvents RedialButton As System.Windows.Forms.Button
    Friend WithEvents FailedCallPicture As System.Windows.Forms.PictureBox

End Class
