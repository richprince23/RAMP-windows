Imports PVS.AVPlayer

Public Class Mini

    Dim drag As Boolean
    Dim mx As Integer
    Dim msy As Integer

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton8.Click
        Me.Hide()
        Main.Show()
        Main.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Mini_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub Mini_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sz As New Size(Screen.PrimaryScreen.Bounds.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        Me.Location = sz
        Me.Focus()
    End Sub

    Private Sub radbtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnStop.Click
        Main.radbtnStop.PerformClick()
    End Sub

    Private Sub radbtnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnPlay.Click
        Main.radbtnPlay.PerformClick()
    End Sub

    Private Sub radbtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnPrev.Click
        Main.radbtnPrev.PerformClick()
    End Sub

    Private Sub radbtnNxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnNxt.Click
        Main.radbtnNxt.PerformClick()
    End Sub

    Private Sub radbtnShfl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnShfl.Click
        Main.radbtnShfl.PerformClick()
        radbtnShfl.BackColor = Main.radbtnShfl.BackColor
    End Sub

    Private Sub radbtnLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnLoop.Click
        Main.radbtnLoop.PerformClick()
        radbtnLoop.BackColor = Main.radbtnLoop.BackColor
    End Sub


    Private Sub rPgbar2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rPgbar2.MouseDown, Me.MouseDown, Lbl.MouseDown, PbxTag.MouseDown
        drag = True
        Me.Cursor = Cursors.SizeAll
        mx = Cursor.Position.X - Me.Left
        msy = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub rPgbar2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rPgbar2.MouseMove, Me.MouseMove, Lbl.MouseMove, PbxTag.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - msy
            Me.Left = Cursor.Position.X - mx

        End If
    End Sub

    Private Sub rPgbar2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rPgbar2.MouseUp, Me.MouseUp, Lbl.MouseUp, PbxTag.MouseUp
        drag = False
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        On Error Resume Next
        Application.Exit()
    End Sub
    Private Sub MiniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiniToolStripMenuItem.Click
        If Me.Visible = True Then
            Me.Hide()
            Main.Show()
        Else
            Main.Hide()
            Me.Show()
        End If
    End Sub
    Private Sub PlaylistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaylistToolStripMenuItem.Click
        Main.radbtnPlst.PerformClick()
    End Sub
    Private Sub AspectRatioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AspectRatioToolStripMenuItem.Click
        Main.radbtnScale.PerformClick()
    End Sub
    Private Sub FullscreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullscreenToolStripMenuItem.Click
        Main.radbtnFS.PerformClick()
    End Sub
    Private Sub RepeatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeatToolStripMenuItem.Click
        Main.radbtnLoop.PerformClick()
    End Sub
    Private Sub ShuffleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShuffleToolStripMenuItem.Click
        Main.radbtnShfl.PerformClick()
    End Sub
    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        Main.radbtnStop.PerformClick()
    End Sub
    Private Sub PreviousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousToolStripMenuItem.Click
        Main.radbtnPrev.PerformClick()
    End Sub
    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Main.radbtnNxt.PerformClick()
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Main.RadMenuItem14.PerformClick()
    End Sub
    Private Sub shuffle(ByVal ampa As Boolean)
        On Error Resume Next
        If ampa = True Then
            Main.radbtnShfl.BackColor = Color.Gray
            radbtnShfl.BackColor = Color.Gray

            Randomize()
            Dim cc As Integer = PLayList.lvPl.Items.Count
            Dim cr As Integer = PLayList.lvPl.Items.IndexOf(PLayList.lvPl.SelectedItems(0))
            For i As Integer = 0 To cc
                Dim r As New Random()
                ' lbl1.Text = r.Next(1, cc)
                cr = r.Next(0, cc - 1)
                PLayList.lvPl.Items(cr).Selected = True
            Next
        Else
            Main.radbtnShfl.BackColor = Color.White
            radbtnShfl.BackColor = Color.White
        End If

    End Sub
    Sub loopp(ByVal ampa As Boolean)
        Try
            If ampa = True Then
                Main.radbtnLoop.BackColor = Color.Gray
                radbtnLoop.BackColor = Color.Gray
                Main.mplayer.Repeat = True

            Else
                Main.radbtnLoop.BackColor = Color.White
                radbtnLoop.BackColor = Color.White
                Main.mplayer.Repeat = False

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub prev()
        Try
            Dim cr As Integer = PLayList.lvPl.Items.IndexOf(PLayList.lvPl.SelectedItems(0))
            Dim cc As Integer = PLayList.lvPl.Items.Count
            If cc > 1 Then
                cr = cr - 1
                PLayList.lvPl.Items(cr).Selected = True

                If cr <> 0 Then
                    PLayList.lvPl.Items(cr).Selected = True
                    Main.mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
                Else
                    PLayList.lvPl.Items(0).Selected = True
                    Main.mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
                End If
                If Main.mplayer.LastErrorCode = 277 Then
                    PLayList.lvPl.Items(0).Selected = True
                    Main.mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
                End If
            End If
            ' nt1.ShowBalloonTip(3000, "MPLite Player", "MPLite - Playing : " & Path.GetFileName(mplayer.FileName), ToolTipIcon.Info)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Nxt()
        On Error Resume Next

        Dim cr As Integer = PLayList.lvPl.Items.IndexOf(PLayList.lvPl.SelectedItems(0))
        cr = cr + 1
        PLayList.lvPl.Items(cr).Selected = True
        If cr = PLayList.lvPl.Items.Count Then
            PLayList.lvPl.Items(0).Selected = True
        End If
        Main.mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
        If Main.mplayer.LastErrorCode = 277 Then
            PLayList.lvPl.Items(0).Selected = True
            Main.mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
        End If

        'nt1.ShowBalloonTip(3000, "MPLite Player", "MPLite - Playing : " & Path.GetFileName(mplayer.FileName), ToolTipIcon.Info)
    End Sub
    'Private Sub radbtnNxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnNxt.Click
    '    Try
    '        If radbtnShfl.BackColor = Color.Gray Then
    '            shuffle(True)
    '            Main.mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
    '        Else
    '            Nxt()

    '        End If
    '    Catch ex As Exception
    '    End Try

    'End Sub
    Private Sub Mini_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            '' single key shortcuts

            If e.KeyCode = Keys.Space Or e.KeyCode = Keys.MediaPlayPause Then
                Dim num As Integer = 0
                num = Val(Main.LblNum2.Text) + 1
                Main.LblNum2.Text = num
                Select Case Main.LblNum2.Text
                    Case 1
                        Main.mplayer.Resume()
                    Case 2
                        Main.mplayer.Pause()
                        Main.LblNum2.Text = 0
                End Select
                'nt1.ShowBalloonTip(3000, "MPLite Player", "MPLite - Playing : " & Path.GetFileName(main.mplayer.FileName), ToolTipIcon.Info)
            ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.MediaStop Then
                'stop
                If Main.mplayer.Playing = True Then
                    Main.mplayer.Stop()
                End If

            ElseIf e.KeyCode = Keys.N Or e.KeyCode = Keys.MediaNextTrack Then
                'next
                radbtnNxt.PerformClick()
            ElseIf e.KeyCode = Keys.P Or e.KeyCode = Keys.MediaPreviousTrack Then
                'previous
                radbtnPrev.PerformClick()
            ElseIf e.KeyCode = Keys.M Or e.KeyCode = Keys.VolumeMute Then
                'set mute button
                If Main.mplayer.Mute = False Then
                    Main.mplayer.Mute = True
                    Main.MuteRadbtn.Image = My.Resources.Mute_16px
                    Main.VolTkbar.Value = 0
                    Main.RadMenuItem47.IsChecked = True

                Else
                    Main.mplayer.Mute = False
                    Main.MuteRadbtn.Image = My.Resources.Voice_16px
                    Main.VolTkbar.Value = Main.VolTkbar.Maximum
                    Main.RadMenuItem47.IsChecked = False

                End If

            ElseIf e.KeyCode = Keys.R Then
                'shufle
                If radbtnShfl.BackColor = Color.White Then
                    shuffle(True)
                Else
                    shuffle(False)
                End If
                Main.RadMenuItem40.PerformClick()
            ElseIf e.KeyCode = Keys.C Then
                Dim num As Integer = 0
                num = Val(Main.lblnum.Text) + 1
                Main.lblnum.Text = num
                Select Case Main.lblnum.Text
                    Case 1
                        Main.mplayer.Display.Mode = DisplayMode.CoverCenter
                    Case 2
                        Main.mplayer.Display.Mode = DisplayMode.Center
                    Case 3
                        Main.mplayer.Display.Mode = DisplayMode.SizeToFit
                    Case 4
                        Main.mplayer.Display.Mode = DisplayMode.SizeToFitCenter
                    Case 5
                        Main.mplayer.Display.Mode = DisplayMode.Stretch
                    Case 6
                        Main.mplayer.Display.Mode = DisplayMode.Zoom
                    Case 7
                        Main.mplayer.Display.Mode = DisplayMode.ZoomCenter
                    Case 8
                        Main.lblnum.Text = 0
                End Select
            ElseIf e.KeyCode = Keys.F Then

                If Main.mplayer.HasVideo = True Then
                    If Main.mplayer.FullScreen = False Then
                        Main.mplayer.FullScreen = True
                        Main.mplayer.FullScreenMode = FullScreenMode.Parent
                        Main.RadMenuItem28.IsChecked = True

                    Else
                        Main.mplayer.FullScreen = False
                        Main.RadMenuItem28.IsChecked = False

                    End If
                End If

            ElseIf e.KeyCode = Keys.L Then
                'l  for loop
                If radbtnLoop.BackColor = Color.White Then
                    loopp(True)
                Else
                    loopp(False)
                End If
                Main.RadMenuItem48.PerformClick()

            ElseIf e.KeyCode = Keys.T Then
                If PLayList.Visible = False Then
                    PLayList.Show()
                Else
                    PLayList.Hide()
                End If
            Else

            End If
            '' HANDLE CONTROL SHORTCUTS
            If e.Control Then
                ' e.Handled = True

                Select Case e.KeyCode
                    Case Keys.Q
                        'close app
                        Application.Exit()
                    Case Keys.Right
                        Main.mplayer.Position.Skip(60)
                    Case Keys.Left
                        Main.mplayer.Position.Skip(-60)

                    Case Keys.Up Or Keys.VolumeUp Or Keys.PageUp
                        Main.mplayer.Audio.Volume = Main.mplayer.Audio.Volume + 100
                    Case Keys.Down Or Keys.VolumeDown
                        Main.mplayer.Audio.Volume -= Main.mplayer.Audio.Volume - 100

                End Select
            End If
            'ElseIf e.Modifiers = Keys.Alt Then
            If e.Alt Then
                Select Case e.KeyCode

                    Case Keys.Right
                        Main.mplayer.Position.Skip(10)
                    Case Keys.Left
                        Main.mplayer.Position.Skip(-10)
                End Select

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
