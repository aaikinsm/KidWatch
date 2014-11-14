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
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.Main = New System.Windows.Forms.TabPage()
        Me.CalendarButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Music = New System.Windows.Forms.TabPage()
        Me.RepeatButton = New System.Windows.Forms.Button()
        Me.ShufftleButton = New System.Windows.Forms.Button()
        Me.PlaylistButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.NowPlaying = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Clock = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Calendar = New System.Windows.Forms.TabPage()
        Me.calendarLabel = New System.Windows.Forms.Label()
        Me.CalendarPicker = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Disrupt = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorkerMusic = New System.ComponentModel.BackgroundWorker()
        Me.MainTabControl.SuspendLayout()
        Me.Main.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Music.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Clock.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Calendar.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Disrupt.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.Main)
        Me.MainTabControl.Controls.Add(Me.Music)
        Me.MainTabControl.Controls.Add(Me.Clock)
        Me.MainTabControl.Controls.Add(Me.Calendar)
        Me.MainTabControl.Controls.Add(Me.Disrupt)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 1)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(159, 177)
        Me.MainTabControl.TabIndex = 2
        '
        'Main
        '
        Me.Main.Controls.Add(Me.CalendarButton)
        Me.Main.Controls.Add(Me.MusicButton)
        Me.Main.Controls.Add(Me.Label1)
        Me.Main.Controls.Add(Me.PictureBox1)
        Me.Main.Location = New System.Drawing.Point(4, 22)
        Me.Main.Name = "Main"
        Me.Main.Padding = New System.Windows.Forms.Padding(3)
        Me.Main.Size = New System.Drawing.Size(151, 151)
        Me.Main.TabIndex = 0
        Me.Main.Text = "Main"
        Me.Main.UseVisualStyleBackColor = True
        '
        'CalendarButton
        '
        Me.CalendarButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.calendar_icon
        Me.CalendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CalendarButton.Location = New System.Drawing.Point(6, 83)
        Me.CalendarButton.Name = "CalendarButton"
        Me.CalendarButton.Size = New System.Drawing.Size(50, 50)
        Me.CalendarButton.TabIndex = 3
        Me.CalendarButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.BackgroundImage = Global.KidWatch.My.Resources.Resources.music_icon
        Me.MusicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MusicButton.Location = New System.Drawing.Point(95, 83)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(50, 50)
        Me.MusicButton.TabIndex = 2
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KidWatch.My.Resources.Resources.blue
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 151)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.Music.Size = New System.Drawing.Size(151, 151)
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
        Me.NowPlaying.Location = New System.Drawing.Point(17, 17)
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
        'Clock
        '
        Me.Clock.Controls.Add(Me.PictureBox4)
        Me.Clock.Location = New System.Drawing.Point(4, 22)
        Me.Clock.Name = "Clock"
        Me.Clock.Padding = New System.Windows.Forms.Padding(3)
        Me.Clock.Size = New System.Drawing.Size(151, 151)
        Me.Clock.TabIndex = 2
        Me.Clock.Text = "Clock"
        Me.Clock.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.KidWatch.My.Resources.Resources.blue
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(151, 151)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Calendar
        '
        Me.Calendar.Controls.Add(Me.calendarLabel)
        Me.Calendar.Controls.Add(Me.CalendarPicker)
        Me.Calendar.Controls.Add(Me.PictureBox5)
        Me.Calendar.Location = New System.Drawing.Point(4, 22)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.Padding = New System.Windows.Forms.Padding(3)
        Me.Calendar.Size = New System.Drawing.Size(151, 151)
        Me.Calendar.TabIndex = 3
        Me.Calendar.Text = "Calendar"
        Me.Calendar.UseVisualStyleBackColor = True
        '
        'calendarLabel
        '
        Me.calendarLabel.AutoSize = True
        Me.calendarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendarLabel.Location = New System.Drawing.Point(-2, 3)
        Me.calendarLabel.Name = "calendarLabel"
        Me.calendarLabel.Size = New System.Drawing.Size(153, 13)
        Me.calendarLabel.TabIndex = 2
        Me.calendarLabel.Text = "Pick a date to see events"
        '
        'CalendarPicker
        '
        Me.CalendarPicker.Location = New System.Drawing.Point(8, 19)
        Me.CalendarPicker.Name = "CalendarPicker"
        Me.CalendarPicker.Size = New System.Drawing.Size(138, 20)
        Me.CalendarPicker.TabIndex = 1
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
        'Disrupt
        '
        Me.Disrupt.Controls.Add(Me.PictureBox2)
        Me.Disrupt.Location = New System.Drawing.Point(4, 22)
        Me.Disrupt.Name = "Disrupt"
        Me.Disrupt.Padding = New System.Windows.Forms.Padding(3)
        Me.Disrupt.Size = New System.Drawing.Size(151, 151)
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
        'BackgroundWorkerMusic
        '
        '
        'KidWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(160, 177)
        Me.Controls.Add(Me.MainTabControl)
        Me.Name = "KidWatch"
        Me.Text = "KidWatch"
        Me.MainTabControl.ResumeLayout(False)
        Me.Main.ResumeLayout(False)
        Me.Main.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Music.ResumeLayout(False)
        Me.Music.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Clock.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Calendar.ResumeLayout(False)
        Me.Calendar.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Disrupt.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents Main As System.Windows.Forms.TabPage
    Friend WithEvents Music As System.Windows.Forms.TabPage
    Friend WithEvents Clock As System.Windows.Forms.TabPage
    Friend WithEvents Calendar As System.Windows.Forms.TabPage
    Friend WithEvents Disrupt As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents MusicButton As System.Windows.Forms.Button
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorkerMusic As System.ComponentModel.BackgroundWorker
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents NowPlaying As System.Windows.Forms.Label
    Friend WithEvents PlaylistButton As System.Windows.Forms.Button
    Friend WithEvents RepeatButton As System.Windows.Forms.Button
    Friend WithEvents ShufftleButton As System.Windows.Forms.Button
    Friend WithEvents CalendarButton As System.Windows.Forms.Button
    Friend WithEvents CalendarPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents calendarLabel As System.Windows.Forms.Label

End Class
