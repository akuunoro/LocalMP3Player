<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_cdplayer = New System.Windows.Forms.Label()
        Me.lbl_trackplaying = New System.Windows.Forms.Label()
        Me.lbl_Track = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btn_PlayPause = New FontAwesome.Sharp.IconButton()
        Me.btn_Next = New FontAwesome.Sharp.IconButton()
        Me.btn_Previous = New FontAwesome.Sharp.IconButton()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cdplayer
        '
        Me.lbl_cdplayer.AutoSize = True
        Me.lbl_cdplayer.BackColor = System.Drawing.SystemColors.WindowText
        Me.lbl_cdplayer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cdplayer.ForeColor = System.Drawing.Color.Aqua
        Me.lbl_cdplayer.Location = New System.Drawing.Point(312, 9)
        Me.lbl_cdplayer.Name = "lbl_cdplayer"
        Me.lbl_cdplayer.Size = New System.Drawing.Size(176, 32)
        Me.lbl_cdplayer.TabIndex = 0
        Me.lbl_cdplayer.Text = "CD PLAYER"
        '
        'lbl_trackplaying
        '
        Me.lbl_trackplaying.AutoSize = True
        Me.lbl_trackplaying.BackColor = System.Drawing.Color.Black
        Me.lbl_trackplaying.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trackplaying.ForeColor = System.Drawing.Color.Aqua
        Me.lbl_trackplaying.Location = New System.Drawing.Point(242, 60)
        Me.lbl_trackplaying.Name = "lbl_trackplaying"
        Me.lbl_trackplaying.Size = New System.Drawing.Size(256, 32)
        Me.lbl_trackplaying.TabIndex = 4
        Me.lbl_trackplaying.Text = "TRACK PLAYING:"
        '
        'lbl_Track
        '
        Me.lbl_Track.AutoSize = True
        Me.lbl_Track.BackColor = System.Drawing.SystemColors.WindowText
        Me.lbl_Track.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Track.ForeColor = System.Drawing.Color.Aqua
        Me.lbl_Track.Location = New System.Drawing.Point(495, 60)
        Me.lbl_Track.Name = "lbl_Track"
        Me.lbl_Track.Size = New System.Drawing.Size(31, 32)
        Me.lbl_Track.TabIndex = 5
        Me.lbl_Track.Text = "1"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 164)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(776, 331)
        Me.AxWindowsMediaPlayer1.TabIndex = 6
        '
        'btn_PlayPause
        '
        Me.btn_PlayPause.BackColor = System.Drawing.Color.Black
        Me.btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PlayPause.ForeColor = System.Drawing.Color.Aqua
        Me.btn_PlayPause.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.btn_PlayPause.IconColor = System.Drawing.Color.Aqua
        Me.btn_PlayPause.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_PlayPause.Location = New System.Drawing.Point(342, 95)
        Me.btn_PlayPause.Name = "btn_PlayPause"
        Me.btn_PlayPause.Size = New System.Drawing.Size(89, 54)
        Me.btn_PlayPause.TabIndex = 9
        Me.btn_PlayPause.UseVisualStyleBackColor = False
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.Black
        Me.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Next.ForeColor = System.Drawing.Color.Aqua
        Me.btn_Next.IconChar = FontAwesome.Sharp.IconChar.ArrowsTurnRight
        Me.btn_Next.IconColor = System.Drawing.Color.Aqua
        Me.btn_Next.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Next.Location = New System.Drawing.Point(437, 95)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(89, 54)
        Me.btn_Next.TabIndex = 10
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'btn_Previous
        '
        Me.btn_Previous.BackColor = System.Drawing.Color.Black
        Me.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Previous.ForeColor = System.Drawing.Color.Aqua
        Me.btn_Previous.IconChar = FontAwesome.Sharp.IconChar.ArrowsTurnRight
        Me.btn_Previous.IconColor = System.Drawing.Color.Aqua
        Me.btn_Previous.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_Previous.Location = New System.Drawing.Point(247, 95)
        Me.btn_Previous.Name = "btn_Previous"
        Me.btn_Previous.Size = New System.Drawing.Size(89, 54)
        Me.btn_Previous.TabIndex = 11
        Me.btn_Previous.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Previous)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.btn_PlayPause)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.lbl_Track)
        Me.Controls.Add(Me.lbl_trackplaying)
        Me.Controls.Add(Me.lbl_cdplayer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "CD PLAYER"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_cdplayer As Label
    Friend WithEvents lbl_trackplaying As Label
    Friend WithEvents lbl_Track As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btn_PlayPause As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Next As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Previous As FontAwesome.Sharp.IconButton
End Class
