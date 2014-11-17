<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentUI
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
        Me.CallJimmy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TrackChild = New System.Windows.Forms.TabPage()
        Me.ParentCallPage = New System.Windows.Forms.TabPage()
        Me.ParentHangUp = New System.Windows.Forms.Button()
        Me.ParentAccept = New System.Windows.Forms.Button()
        Me.ParentCallTitle = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TrackChild.SuspendLayout()
        Me.ParentCallPage.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CallJimmy
        '
        Me.CallJimmy.Location = New System.Drawing.Point(69, 231)
        Me.CallJimmy.Name = "CallJimmy"
        Me.CallJimmy.Size = New System.Drawing.Size(70, 40)
        Me.CallJimmy.TabIndex = 1
        Me.CallJimmy.Text = "Call Jimmy"
        Me.CallJimmy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Jimmy's Location: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "132 Jarvis St, Toronto ON"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.KidWatch.My.Resources.Resources.map
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 288)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TrackChild)
        Me.TabControl.Controls.Add(Me.ParentCallPage)
        Me.TabControl.Location = New System.Drawing.Point(0, -1)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(218, 314)
        Me.TabControl.TabIndex = 3
        '
        'TrackChild
        '
        Me.TrackChild.Controls.Add(Me.CallJimmy)
        Me.TrackChild.Controls.Add(Me.Label1)
        Me.TrackChild.Controls.Add(Me.PictureBox1)
        Me.TrackChild.Location = New System.Drawing.Point(4, 22)
        Me.TrackChild.Name = "TrackChild"
        Me.TrackChild.Padding = New System.Windows.Forms.Padding(3)
        Me.TrackChild.Size = New System.Drawing.Size(210, 288)
        Me.TrackChild.TabIndex = 1
        Me.TrackChild.Text = "Track Child"
        Me.TrackChild.UseVisualStyleBackColor = True
        '
        'ParentCallPage
        '
        Me.ParentCallPage.BackColor = System.Drawing.Color.LemonChiffon
        Me.ParentCallPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ParentCallPage.Controls.Add(Me.ParentHangUp)
        Me.ParentCallPage.Controls.Add(Me.ParentAccept)
        Me.ParentCallPage.Controls.Add(Me.ParentCallTitle)
        Me.ParentCallPage.Controls.Add(Me.PictureBox2)
        Me.ParentCallPage.Location = New System.Drawing.Point(4, 22)
        Me.ParentCallPage.Name = "ParentCallPage"
        Me.ParentCallPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ParentCallPage.Size = New System.Drawing.Size(210, 288)
        Me.ParentCallPage.TabIndex = 0
        Me.ParentCallPage.Text = "Call"
        '
        'ParentHangUp
        '
        Me.ParentHangUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParentHangUp.ForeColor = System.Drawing.Color.Red
        Me.ParentHangUp.Location = New System.Drawing.Point(25, 238)
        Me.ParentHangUp.Name = "ParentHangUp"
        Me.ParentHangUp.Size = New System.Drawing.Size(156, 34)
        Me.ParentHangUp.TabIndex = 3
        Me.ParentHangUp.Text = "Hang Up"
        Me.ParentHangUp.UseVisualStyleBackColor = True
        '
        'ParentAccept
        '
        Me.ParentAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParentAccept.ForeColor = System.Drawing.Color.Green
        Me.ParentAccept.Location = New System.Drawing.Point(25, 194)
        Me.ParentAccept.Name = "ParentAccept"
        Me.ParentAccept.Size = New System.Drawing.Size(156, 38)
        Me.ParentAccept.TabIndex = 2
        Me.ParentAccept.Text = "Accept"
        Me.ParentAccept.UseVisualStyleBackColor = True
        '
        'ParentCallTitle
        '
        Me.ParentCallTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParentCallTitle.AutoSize = True
        Me.ParentCallTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParentCallTitle.Location = New System.Drawing.Point(25, 21)
        Me.ParentCallTitle.Name = "ParentCallTitle"
        Me.ParentCallTitle.Size = New System.Drawing.Size(114, 25)
        Me.ParentCallTitle.TabIndex = 1
        Me.ParentCallTitle.Text = "Call Child"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.KidWatch.My.Resources.Resources.phone_icon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(25, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(156, 124)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'ParentUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 314)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "ParentUI"
        Me.Text = "ParentUI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TrackChild.ResumeLayout(False)
        Me.TrackChild.PerformLayout()
        Me.ParentCallPage.ResumeLayout(False)
        Me.ParentCallPage.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CallJimmy As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents ParentCallPage As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TrackChild As System.Windows.Forms.TabPage
    Friend WithEvents ParentHangUp As System.Windows.Forms.Button
    Friend WithEvents ParentAccept As System.Windows.Forms.Button
    Friend WithEvents ParentCallTitle As System.Windows.Forms.Label
End Class
