<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mini
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mini))
        Me.FluentTheme = New Telerik.WinControls.Themes.FluentTheme()
        Me.rPgbar2 = New Telerik.WinControls.UI.RadProgressBar()
        Me.PlaybackCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AspectRatioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadButton8 = New Telerik.WinControls.UI.RadButton()
        Me.radbtnLoop = New Telerik.WinControls.UI.RadButton()
        Me.radbtnShfl = New Telerik.WinControls.UI.RadButton()
        Me.radbtnNxt = New Telerik.WinControls.UI.RadButton()
        Me.radbtnStop = New Telerik.WinControls.UI.RadButton()
        Me.radbtnPrev = New Telerik.WinControls.UI.RadButton()
        Me.radbtnPlay = New Telerik.WinControls.UI.RadButton()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.PbxTag = New System.Windows.Forms.PictureBox()
        Me.Tt = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.rPgbar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlaybackCMS.SuspendLayout()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radbtnLoop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radbtnShfl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radbtnNxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radbtnStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radbtnPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radbtnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxTag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rPgbar2
        '
        Me.rPgbar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rPgbar2.ContextMenuStrip = Me.PlaybackCMS
        Me.rPgbar2.Location = New System.Drawing.Point(83, 0)
        Me.rPgbar2.Name = "rPgbar2"
        Me.rPgbar2.Size = New System.Drawing.Size(265, 17)
        Me.rPgbar2.TabIndex = 0
        Me.rPgbar2.TabStop = False
        Me.rPgbar2.ThemeName = "MaterialPink"
        '
        'PlaybackCMS
        '
        Me.PlaybackCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.NextToolStripMenuItem, Me.PreviousToolStripMenuItem, Me.StopToolStripMenuItem, Me.ShuffleToolStripMenuItem, Me.RepeatToolStripMenuItem, Me.ToolStripSeparator1, Me.FullscreenToolStripMenuItem, Me.AspectRatioToolStripMenuItem, Me.ToolStripSeparator2, Me.PlaylistToolStripMenuItem, Me.MiniToolStripMenuItem, Me.ToolStripSeparator3, Me.QuitToolStripMenuItem})
        Me.PlaybackCMS.Name = "PlaybackCMS"
        Me.PlaybackCMS.ShowCheckMargin = True
        Me.PlaybackCMS.Size = New System.Drawing.Size(166, 264)
        Me.PlaybackCMS.Text = "Playback"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.RAMP.My.Resources.Resources.Play_24px
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem1.Text = "Play/Pause"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.End_24px
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Skip_to_Start_24px
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PreviousToolStripMenuItem.Text = "Previous "
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Stop_24px
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.StopToolStripMenuItem.Text = "Stop "
        '
        'ShuffleToolStripMenuItem
        '
        Me.ShuffleToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Shuffle_24px
        Me.ShuffleToolStripMenuItem.Name = "ShuffleToolStripMenuItem"
        Me.ShuffleToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ShuffleToolStripMenuItem.Text = "Shuffle "
        '
        'RepeatToolStripMenuItem
        '
        Me.RepeatToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Repeat_24px
        Me.RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem"
        Me.RepeatToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RepeatToolStripMenuItem.Text = "Repeat "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'FullscreenToolStripMenuItem
        '
        Me.FullscreenToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Showing_Video_Frames_24px
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.FullscreenToolStripMenuItem.Text = "Fullscreen"
        '
        'AspectRatioToolStripMenuItem
        '
        Me.AspectRatioToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Frame_24px
        Me.AspectRatioToolStripMenuItem.Name = "AspectRatioToolStripMenuItem"
        Me.AspectRatioToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AspectRatioToolStripMenuItem.Text = "Aspect Ratio "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(162, 6)
        '
        'PlaylistToolStripMenuItem
        '
        Me.PlaylistToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Playlist_24px
        Me.PlaylistToolStripMenuItem.Name = "PlaylistToolStripMenuItem"
        Me.PlaylistToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PlaylistToolStripMenuItem.Text = "Playlist "
        '
        'MiniToolStripMenuItem
        '
        Me.MiniToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Transition_Both_Directions_24px
        Me.MiniToolStripMenuItem.Name = "MiniToolStripMenuItem"
        Me.MiniToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MiniToolStripMenuItem.Text = "Mini"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(162, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = Global.RAMP.My.Resources.Resources.Close_Window_16px
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'RadButton8
        '
        Me.RadButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton8.ContextMenuStrip = Me.PlaybackCMS
        Me.RadButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadButton8.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButton8.Image = Global.RAMP.My.Resources.Resources.Transition_Both_Directions_24px
        Me.RadButton8.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton8.Location = New System.Drawing.Point(311, 36)
        Me.RadButton8.Name = "RadButton8"
        Me.RadButton8.Size = New System.Drawing.Size(37, 36)
        Me.RadButton8.TabIndex = 8
        Me.RadButton8.TabStop = False
        Me.RadButton8.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.RadButton8, "show Main Window")
        '
        'radbtnLoop
        '
        Me.radbtnLoop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.radbtnLoop.ContextMenuStrip = Me.PlaybackCMS
        Me.radbtnLoop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radbtnLoop.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.radbtnLoop.Image = Global.RAMP.My.Resources.Resources.Repeat_24px
        Me.radbtnLoop.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radbtnLoop.Location = New System.Drawing.Point(273, 36)
        Me.radbtnLoop.Name = "radbtnLoop"
        Me.radbtnLoop.Size = New System.Drawing.Size(37, 36)
        Me.radbtnLoop.TabIndex = 7
        Me.radbtnLoop.TabStop = False
        Me.radbtnLoop.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.radbtnLoop, "Repeat current media")
        '
        'radbtnShfl
        '
        Me.radbtnShfl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.radbtnShfl.ContextMenuStrip = Me.PlaybackCMS
        Me.radbtnShfl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radbtnShfl.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.radbtnShfl.Image = Global.RAMP.My.Resources.Resources.Shuffle_24px
        Me.radbtnShfl.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radbtnShfl.Location = New System.Drawing.Point(235, 36)
        Me.radbtnShfl.Name = "radbtnShfl"
        Me.radbtnShfl.Size = New System.Drawing.Size(37, 36)
        Me.radbtnShfl.TabIndex = 6
        Me.radbtnShfl.TabStop = False
        Me.radbtnShfl.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.radbtnShfl, "Shuffle playback")
        '
        'radbtnNxt
        '
        Me.radbtnNxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.radbtnNxt.ContextMenuStrip = Me.PlaybackCMS
        Me.radbtnNxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radbtnNxt.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.radbtnNxt.Image = Global.RAMP.My.Resources.Resources.End_24px
        Me.radbtnNxt.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radbtnNxt.Location = New System.Drawing.Point(197, 36)
        Me.radbtnNxt.Name = "radbtnNxt"
        Me.radbtnNxt.Size = New System.Drawing.Size(37, 36)
        Me.radbtnNxt.TabIndex = 5
        Me.radbtnNxt.TabStop = False
        Me.radbtnNxt.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.radbtnNxt, "Play next media")
        '
        'radbtnStop
        '
        Me.radbtnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.radbtnStop.ContextMenuStrip = Me.PlaybackCMS
        Me.radbtnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radbtnStop.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.radbtnStop.Image = Global.RAMP.My.Resources.Resources.Stop_24px
        Me.radbtnStop.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radbtnStop.Location = New System.Drawing.Point(159, 36)
        Me.radbtnStop.Name = "radbtnStop"
        Me.radbtnStop.Size = New System.Drawing.Size(37, 36)
        Me.radbtnStop.TabIndex = 4
        Me.radbtnStop.TabStop = False
        Me.radbtnStop.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.radbtnStop, "Stop media playback")
        '
        'radbtnPrev
        '
        Me.radbtnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.radbtnPrev.ContextMenuStrip = Me.PlaybackCMS
        Me.radbtnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radbtnPrev.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.radbtnPrev.Image = Global.RAMP.My.Resources.Resources.Skip_to_Start_24px
        Me.radbtnPrev.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radbtnPrev.Location = New System.Drawing.Point(121, 36)
        Me.radbtnPrev.Name = "radbtnPrev"
        Me.radbtnPrev.Size = New System.Drawing.Size(37, 36)
        Me.radbtnPrev.TabIndex = 3
        Me.radbtnPrev.TabStop = False
        Me.radbtnPrev.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.radbtnPrev, "Play previous media")
        '
        'radbtnPlay
        '
        Me.radbtnPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.radbtnPlay.ContextMenuStrip = Me.PlaybackCMS
        Me.radbtnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radbtnPlay.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.radbtnPlay.Image = Global.RAMP.My.Resources.Resources.Play_24px
        Me.radbtnPlay.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radbtnPlay.Location = New System.Drawing.Point(83, 36)
        Me.radbtnPlay.Name = "radbtnPlay"
        Me.radbtnPlay.Size = New System.Drawing.Size(37, 36)
        Me.radbtnPlay.TabIndex = 2
        Me.radbtnPlay.TabStop = False
        Me.radbtnPlay.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.radbtnPlay, "Play/pause playback")
        '
        'Lbl
        '
        Me.Lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl.BackColor = System.Drawing.Color.DeepPink
        Me.Lbl.ContextMenuStrip = Me.PlaybackCMS
        Me.Lbl.ForeColor = System.Drawing.Color.White
        Me.Lbl.Location = New System.Drawing.Point(83, 20)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(265, 17)
        Me.Lbl.TabIndex = 1
        '
        'PbxTag
        '
        Me.PbxTag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PbxTag.BackColor = System.Drawing.Color.Transparent
        Me.PbxTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxTag.ContextMenuStrip = Me.PlaybackCMS
        Me.PbxTag.Location = New System.Drawing.Point(0, 0)
        Me.PbxTag.Name = "PbxTag"
        Me.PbxTag.Size = New System.Drawing.Size(77, 72)
        Me.PbxTag.TabIndex = 9
        Me.PbxTag.TabStop = False
        Me.Tt.SetToolTip(Me.PbxTag, "Album Art")
        '
        'Mini
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(339, 72)
        Me.ContextMenuStrip = Me.PlaybackCMS
        Me.ControlBox = False
        Me.Controls.Add(Me.PbxTag)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.radbtnNxt)
        Me.Controls.Add(Me.radbtnLoop)
        Me.Controls.Add(Me.radbtnStop)
        Me.Controls.Add(Me.radbtnPlay)
        Me.Controls.Add(Me.radbtnPrev)
        Me.Controls.Add(Me.radbtnShfl)
        Me.Controls.Add(Me.RadButton8)
        Me.Controls.Add(Me.rPgbar2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(318, 72)
        Me.Name = "Mini"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mini"
        Me.ThemeName = "MaterialPink"
        CType(Me.rPgbar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlaybackCMS.ResumeLayout(False)
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radbtnLoop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radbtnShfl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radbtnNxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radbtnStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radbtnPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radbtnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxTag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FluentTheme As Telerik.WinControls.Themes.FluentTheme
    Friend WithEvents rPgbar2 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents radbtnLoop As Telerik.WinControls.UI.RadButton
    Friend WithEvents radbtnShfl As Telerik.WinControls.UI.RadButton
    Friend WithEvents radbtnNxt As Telerik.WinControls.UI.RadButton
    Friend WithEvents radbtnStop As Telerik.WinControls.UI.RadButton
    Friend WithEvents radbtnPrev As Telerik.WinControls.UI.RadButton
    Friend WithEvents radbtnPlay As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton8 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Public WithEvents PbxTag As System.Windows.Forms.PictureBox
    Friend WithEvents PlaybackCMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShuffleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FullscreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AspectRatioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tt As System.Windows.Forms.ToolTip
End Class

