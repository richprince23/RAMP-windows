Imports Telerik.WinControls
Imports DevExpress.Utils.Taskbar
Imports PVS.AVPlayer
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.WindowsAPICodePack

Public Class Main
    Public mplayer As Player
    Public Taginfo
    Public myCoolFile1 As String = My.Computer.FileSystem.SpecialDirectories.MyMusic & "\Default.rampl"       'default playlist
    Public myCoolFile As String
    Public fIndex As Integer
    Public curFile As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        mplayer = New Player
        mplayer.Display.Window = DispPnl
        mplayer.Display.ResizeRedraw = True
        mplayer.Display.Mode = DisplayMode.CoverCenter
        mplayer.Sliders.AudioVolume = VolTkbar

        Mini.Show()
        Mini.Hide()
        PLayList.Show()
        PLayList.Hide()

    End Sub

    Private Sub Main_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop, DispPnl.DragDrop
        Try
            Dim handl As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
            For Each s As String In handl
                ' AddFileToListview(s
                Dim sz As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(s)
                If s.EndsWith(".m3u") Or s.EndsWith(".m3u8") Then
                    Dim readpl() As String = IO.File.ReadAllLines(s.ToString)
                    For Each line As String In readpl
                        If Not line.StartsWith("#") Then
                            If Not line.StartsWith("file:///") Then
                                Dim cst As New ListViewItem(line)
                                cst.ImageIndex = 0
                                PLayList.lvPl.Items.Add(cst)
                            Else
                                Dim newLine As String
                                newLine = line.Remove("file:///")
                                newLine = newLine.Replace("/", "\")
                                newLine = newLine.Replace("%20", " ")
                                Dim cst As New ListViewItem(newLine)
                                cst.ImageIndex = 0
                                PLayList.lvPl.Items.Add(cst)
                            End If
                        End If
                    Next
                    'Exit For
                ElseIf s.EndsWith(".mpl") Or s.EndsWith(".rampl") Then
                    Dim myCoolFileLines() As String = IO.File.ReadAllLines(s.ToString) '// load your file as a string array.
                    For Each line As String In myCoolFileLines '// loop thru array list.
                        Dim lineArray() As String = line.Split("#") '// separate by "#" character.
                        Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
                        newItem.SubItems.Add(lineArray(1)) '// add SubItem.
                        newItem.ImageIndex = 0
                        PLayList.lvPl.Items.Add(newItem) '// add Item to ListView.
                    Next

                Else

                    Dim mb As Integer = 1024000
                    Dim dtls As New ListViewItem(s)
                    dtls.ImageIndex = 0
                    dtls.SubItems.Add(Math.Round(sz.Length / mb, 2) & " MB")
                    PLayList.lvPl.Items.Add(dtls)
                End If
            Next

            Dim cr As Integer = PLayList.lvPl.Items.Count - 1
            PLayList.lvPl.Items(cr).Selected = True
            mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
            If mplayer.LastErrorCode = 277 Then
                PLayList.lvPl.Items(0).Selected = True
                mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'auyomatically saving playlist when playlist closes
            Dim myWriter As New IO.StreamWriter(myCoolFile1)
            For Each myItem As ListViewItem In PLayList.lvPl.Items
                myWriter.WriteLine(myItem.Text & "#" & myItem.SubItems(1).Text)  '// write Item and SubItem.
            Next
            myWriter.Close()
        Catch ex As Exception
        End Try
        Mini.Dispose()
        RemoveHandler My.Application.StartupNextInstance, AddressOf Me_StartupNextInstance
        Me.Dispose()
    End Sub
#Region "Shortkuts"
    Private Sub Main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            '' single key shortcuts

            If e.KeyCode = Keys.Space Or e.KeyCode = Keys.MediaPlayPause Then
                Dim num As Integer = 0
                num = Val(LblNum2.Text) + 1
                LblNum2.Text = num
                Select Case LblNum2.Text
                    Case 1
                        mplayer.Resume()
                    Case 2
                        mplayer.Pause()
                        LblNum2.Text = 0
                End Select
                'nt1.ShowBalloonTip(3000, "MPLite Player", "MPLite - Playing : " & Path.GetFileName(mplayer.FileName), ToolTipIcon.Info)
            ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.MediaStop Then
                'stop
                If mplayer.Playing = True Then
                    mplayer.Stop()
                End If

            ElseIf e.KeyCode = Keys.N Or e.KeyCode = Keys.MediaNextTrack Then
                'next
                radbtnNxt.PerformClick()

            ElseIf e.KeyCode = Keys.P Or e.KeyCode = Keys.MediaPreviousTrack Then
                'previous
                radbtnPrev.PerformClick()
            ElseIf e.KeyCode = Keys.M Or e.KeyCode = Keys.VolumeMute Then
                'set mute button
                If mplayer.Mute = False Then
                    mplayer.Mute = True
                    MuteRadbtn.Image = My.Resources.Mute_16px
                    VolTkbar.Value = 0
                    RadMenuItem47.IsChecked = True

                Else
                    mplayer.Mute = False
                    MuteRadbtn.Image = My.Resources.Voice_16px
                    VolTkbar.Value = VolTkbar.Maximum
                    RadMenuItem47.IsChecked = False

                End If

            ElseIf e.KeyCode = Keys.R Then
                'shufle
                If radbtnShfl.BackColor = Color.White Then
                    shuffle(True)
                Else
                    shuffle(False)
                End If
                RadMenuItem40.PerformClick()
            ElseIf e.KeyCode = Keys.C Then
                Dim num As Integer = 0
                num = Val(lblnum.Text) + 1
                lblnum.Text = num
                Select Case lblnum.Text
                    Case 1
                        mplayer.Display.Mode = DisplayMode.CoverCenter
                    Case 2
                        mplayer.Display.Mode = DisplayMode.Center
                    Case 3
                        mplayer.Display.Mode = DisplayMode.SizeToFit
                    Case 4
                        mplayer.Display.Mode = DisplayMode.SizeToFitCenter
                    Case 5
                        mplayer.Display.Mode = DisplayMode.Stretch
                    Case 6
                        mplayer.Display.Mode = DisplayMode.Zoom
                    Case 7
                        mplayer.Display.Mode = DisplayMode.ZoomCenter
                    Case 8
                        lblnum.Text = 0
                End Select
            ElseIf e.KeyCode = Keys.F Then

                If mplayer.HasVideo = True Then
                    If mplayer.FullScreen = False Then
                        mplayer.FullScreen = True
                        mplayer.FullScreenMode = FullScreenMode.Parent
                        RadMenuItem28.IsChecked = True

                    Else
                        mplayer.FullScreen = False
                        RadMenuItem28.IsChecked = False

                    End If
                End If

            ElseIf e.KeyCode = Keys.L Then
                'l  for loop
                If radbtnLoop.BackColor = Color.White Then
                    loopp(True)
                Else
                    loopp(False)
                End If
                RadMenuItem48.PerformClick()

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
                        mplayer.Position.Skip(60)
                    Case Keys.Left
                        mplayer.Position.Skip(-60)

                    Case Keys.Up Or Keys.VolumeUp Or Keys.PageUp
                        mplayer.Audio.Volume = mplayer.Audio.Volume + 100
                    Case Keys.Down Or Keys.VolumeDown
                        mplayer.Audio.Volume -= mplayer.Audio.Volume - 100

                End Select
            End If
            'ElseIf e.Modifiers = Keys.Alt Then
            If e.Alt Then
                Select Case e.KeyCode

                    Case Keys.Right
                        mplayer.Position.Skip(10)
                    Case Keys.Left
                        mplayer.Position.Skip(-10)
                End Select

            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'addig event handlers
        AddHandler mplayer.Events.MediaPositionChanged, AddressOf MPlayer_MediaPositionChanged
        AddHandler mplayer.Events.MediaStarted, AddressOf mplayer_MediaStarted
        AddHandler mplayer.Events.MediaEnded, AddressOf MPlayer_MediaEnded
        AddHandler mplayer.Events.MediaAudioVolumeChanged, AddressOf mplayer_MediaAudioVolumeChnaged
        AddHandler mplayer.Events.MediaPaused, AddressOf mplayer_MediaPaused
        AddHandler mplayer.Events.MediaResumed, AddressOf mplayer_Resumed
        mplayer.Audio.Volume = 2000

        Try
           

            mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
            Me.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub radbtnFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnFS.Click
        'set fullscreen mode
        Try
            If mplayer.HasVideo = True Then
                If mplayer.FullScreen = False Then
                    mplayer.FullScreen = True
                    mplayer.FullScreenMode = FullScreenMode.Parent
                    RadMenuItem28.IsChecked = True

                Else
                    mplayer.FullScreen = False
                    RadMenuItem28.IsChecked = False

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub radbtnScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnScale.Click
        Try
            Dim num As Integer = 0
            num = Val(lblnum.Text) + 1
            lblnum.Text = num
            Select Case lblnum.Text
                Case 1
                    mplayer.Display.Mode = DisplayMode.CoverCenter
                Case 2
                    mplayer.Display.Mode = DisplayMode.Center
                Case 3
                    mplayer.Display.Mode = DisplayMode.SizeToFit
                Case 4
                    mplayer.Display.Mode = DisplayMode.SizeToFitCenter
                Case 5
                    mplayer.Display.Mode = DisplayMode.Stretch
                Case 6
                    mplayer.Display.Mode = DisplayMode.Zoom
                Case 7
                    mplayer.Display.Mode = DisplayMode.ZoomCenter
                Case 8
                    lblnum.Text = 0
            End Select
        Catch ex As Exception
            MsgBox("No video", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub radbtnMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnMini.Click
        Me.Hide()
        Mini.Show()

    End Sub

    Private Sub lvPl_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub radbtnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnLoad.Click
        'Try
        On Error Resume Next
        'loading files
        Using ofd As New OpenFileDialog
            With ofd
                .Title = "Open Media Files"
                .Filter = "All Media Files|*.3gp;*.aa;*.aac;*.aiff;*.amr;*.ape;*.flac;*.m4a;*.mid;*.midi;*.mka;*.mp3;*.mpc;*.ogg;*.opus;*.ra;*.rm;*.wav;*.wma;*.wv;*.asf;*.avi;*.bik;*.divx;*.dvx;*.f4v;*.flv;*.h264;*.hdmov;*.mkv;*.mov;*.mp2;*.mp4;*.mpeg;*.mpeg4;*.mpg;*.mpv;*.mts;*.ogg;*.ogm;*.ogv;*.qt;*.rm;*.rms;*.rmvb;*.swf;*.ts;*.vfw;*.vob;*.webm;*.wmv;*.xvid" +
                "|Audio Files|*.3gp;*.aa;*.aac;*.aiff;*.amr;*.ape;*.flac;*.m4a;*.mid;*.midi;*.mka;*.mp3;*.mpc;*.ogg;*.opus;*.ra;*.rm;*.wav;*.wma;*.wv" +
                "|Videos Files|*.asf;*.avi;*.bik;*.divx;*.dvx;*.f4v;*.flv;*.h264;*.hdmov;*.mkv;*.mov;*.mp2;*.mp4;*.mpeg;*.mpeg4;*.mpg;*.mpv;*.mts;*.ogg;*.ogm;*.ogv;*.qt;*.rm;*.rms;*.rmvb;*.swf;*.ts;*.vfw;*.vob;*.webm;*.wmv;*.xvid" +
                "|RAMP Playlist Files|*.mpl;*.rampl;*.m3u"
                .FileName = ""
                .Multiselect = True
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    Dim format As String = IO.Path.GetExtension(ofd.FileName)
                    If format = ".mpl" Or format = ".rampl" Then

                        If IO.File.Exists(ofd.FileName) Then '// check if file exists.
                            Dim myCoolFileLines() As String = IO.File.ReadAllLines(ofd.FileName) '// load your file as a string array.
                            For Each line As String In myCoolFileLines '// loop thru array list.
                                Dim lineArray() As String = line.Split("#") '// separate by "#" character.
                                Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
                                newItem.SubItems.Add(lineArray(1)) '// add SubItem.
                                newItem.ImageIndex = 0
                                PLayList.lvPl.Items.Add(newItem) '// add Item to ListView.
                            Next
                            For i As Integer = 0 To PLayList.lvPl.Items.Count - 1
                                PLayList.lvPl.Items(0).Selected = True
                            Next
                            mplayer.Play(PLayList.lvPl.SelectedItems(0).Text)

                        End If

                    ElseIf format = ".m3u" Or format = ".m3u8" Then
                        Dim readpl() As String = IO.File.ReadAllLines(ofd.FileName)
                        For Each line As String In readpl
                            If Not line.StartsWith("#") Then
                                If Not line.StartsWith("file:///") Then
                                    Dim cst As New ListViewItem(line)
                                    cst.ImageIndex = 0
                                    PLayList.lvPl.Items.Add(cst)
                                Else
                                    Dim newLine As String
                                    newLine = line.Remove("file:///")
                                    newLine = newLine.Replace("/", "\")
                                    newLine = newLine.Replace("%20", " ")
                                    Dim cst As New ListViewItem(newLine)
                                    cst.ImageIndex = 0
                                    PLayList.lvPl.Items.Add(cst)
                                End If
                            End If
                        Next
                        For i As Integer = 0 To PLayList.lvPl.Items.Count - 1
                            PLayList.lvPl.Items(0).Selected = True
                        Next
                        mplayer.Play(PLayList.lvPl.SelectedItems(0).Text)

                    Else

                        For Each ff As String In ofd.FileNames
                            Dim tagg As New Mp3Class(ff)
                            Dim sz As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(ff)
                            Dim mb As Integer = 1024000

                            Dim dtls As New ListViewItem((ff))
                            dtls.SubItems.Add(Math.Round(sz.Length / mb, 2) & " MB")

                            dtls.ImageIndex = 0
                            PLayList.lvPl.Items.Add(dtls)
                            'select first track
                        Next
                        For i As Integer = 0 To PLayList.lvPl.Items.Count
                            PLayList.lvPl.Items(0).Selected = True
                        Next
                        mplayer.Play(PLayList.lvPl.SelectedItems(0).Text)

                    End If
                End If

            End With
        End Using
        ' Catch ex As Exception

        'End Try
    End Sub

    Private Sub tm1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm1.Tick

    End Sub

    Private Sub MPlayer_MediaPositionChanged(ByVal sender As Object, ByVal e As PositionEventArgs)
        Try
            mplayer.TaskbarProgress.Add(Me)
            mplayer.TaskbarProgress.Add(Mini)
            mplayer.TaskbarProgress.Mode = TaskbarProgressMode.Progress
            'update progrssbar on playing

            mplayer.Sliders.Position = Tkbar1
            Mini.rPgbar2.Maximum = Tkbar1.Maximum
            Mini.rPgbar2.Value1 = Tkbar1.Value

            ' set volume scroll
            LblT1.Text = mplayer.Position.FromBegin.ToString.Remove(8)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub MPlayer_MediaEnded(ByVal sender As Object, ByVal e As EndedEventArgs)
        PLayList.Focus()
        Try
            Select Case e.StopReason
                Case StopReason.AutoStop

                    radbtnPlay.Image = My.Resources.Play_24px
                    Mini.radbtnPlay.Image = My.Resources.Play_24px
                    tbplay.Image = My.Resources.Play_24px
                    Me.Text = "RAMP Player"
                    Mini.Lbl.Text = "RAMP Player Mini"
                    PLayList.Text = "RAMP Player - Playlist"
                    Taginfo = Nothing
                    DispPnl.BackgroundImage = Nothing
                    Mini.PbxTag.BackgroundImage = Nothing

                Case StopReason.Finished
                    If PLayList.lvPl.Items.Count > 1 Then
                        If radbtnLoop.BackColor = Color.Gray Then
                            mplayer.Repeat = True
                            ' radbtnLoad.BackColor = Color.Gray
                            ' mplayer.Play(PLayList.lvPl.SelectedItems(0).Text)

                            radbtnPlay.Image = My.Resources.Play_24px
                            Mini.radbtnPlay.Image = My.Resources.Play_24px
                            tbplay.Image = My.Resources.Play_24px

                            Me.Text = "RAMP Player"
                            Mini.Lbl.Text = "RAMP Player Mini"
                            PLayList.Text = "RAMP Player - Playlist"
                            SubTrackLbl.Text = ""
                            Taginfo = Nothing
                            DispPnl.BackgroundImage = Nothing
                            Mini.PbxTag.BackgroundImage = Nothing
                        ElseIf radbtnShfl.BackColor = Color.Gray Then
                            shuffle(True)
                            mplayer.Play(PLayList.lvPl.SelectedItems(0).Text)

                        Else
                            Nxt()
                        End If
                    Else
                        radbtnPlay.Image = My.Resources.Play_24px
                        Mini.radbtnPlay.Image = My.Resources.Play_24px
                        tbplay.Image = My.Resources.Play_24px

                        Taginfo = Nothing
                        DispPnl.BackgroundImage = Nothing
                        Mini.PbxTag.BackgroundImage = Nothing
                        Me.Text = "RAMP Player"
                        Mini.Lbl.Text = "RAMP Player Mini"
                        PLayList.Text = "RAMP Player - Playlist"
                        SubTrackLbl.Text = ""
                    End If

                Case StopReason.UserStop
                    mplayer.Stop()
                    radbtnPlay.Image = My.Resources.Play_24px
                    Mini.radbtnPlay.Image = My.Resources.Play_24px
                    tbplay.Image = My.Resources.Play_24px

                    Taginfo = Nothing
                    DispPnl.BackgroundImage = Nothing
                    Mini.PbxTag.BackgroundImage = Nothing
                    Me.Text = "RAMP Player"
                    Mini.Lbl.Text = "RAMP Player Mini"
                    PLayList.Text = "RAMP Player - Playlist"
                    SubTrackLbl.Text = ""
            End Select
        Catch ex As Exception

        End Try

    End Sub


    Private Sub radbtnPlst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnPlst.Click
        If PLayList.Visible = False Then
            PLayList.Show()
        Else
            PLayList.Hide()
        End If
    End Sub

    Private Sub mplayer_MediaStarted(ByVal sender As Object, ByVal e As EventArgs)
        Try
            LblT2.Text = mplayer.Position.ToEnd.ToString.Remove(8)
            'change playicon
            radbtnPlay.Image = My.Resources.Pause_24px
            Mini.radbtnPlay.Image = My.Resources.Pause_24px
            tbplay.Image = My.Resources.Pause_24px

            If mplayer.HasVideo = False Then

                Taginfo = mplayer.Media.GetTagInfo()
                DispPnl.BackgroundImageLayout = ImageLayout.Zoom

                DispPnl.BackgroundImage = Taginfo.Image
                Mini.PbxTag.BackgroundImage = Taginfo.image
                SubTrackLbl.Text = Taginfo.Artist + vbNewLine + Taginfo.Title
                Me.Text = "Playing: " + Taginfo.Title + " - RAMP Player"
                Mini.Lbl.Text = Taginfo.Title
                PLayList.Text = "Playing: " + Taginfo.Title

                'show alert
                Alert.ThemeName = MaterialPinkTheme.ThemeName
                Alert.ContentText = Taginfo.Artist + vbNewLine + Taginfo.Title '
                Alert.CaptionText = "RAMP Player"
                Alert.Show()
            Else
                'change playicon
                RadMenuItem62.Enabled = True
                Taginfo = Nothing
                DispPnl.BackgroundImage = Nothing
                Mini.PbxTag.BackgroundImage = Nothing
                SubTrackLbl.Text = ""

                Me.Text = "Playing: " + mplayer.Media.GetName(MediaName.FileName) + " - RAMP Player"
                Mini.Lbl.Text = mplayer.Media.GetName(MediaName.FileName)
                PLayList.Text = "Playing: " + mplayer.Media.GetName(MediaName.FileName)
                'show alert
                Alert.ContentText = "Showing " + vbNewLine + mplayer.Media.GetName(MediaName.FileName) '
                Alert.CaptionText = "RAMP Player"
                Alert.Show()
            End If
        Catch ex As Exception

        End Try
        'set duartions

    End Sub

    Private Sub DispPnl_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DispPnl.DragEnter, Me.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.Copy

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DispPnl_dbclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DispPnl.MouseDoubleClick
        Try
            If mplayer.HasVideo = True Then
                If mplayer.FullScreen = False Then
                    mplayer.FullScreen = True
                    mplayer.FullScreenMode = FullScreenMode.Parent

                Else
                    mplayer.FullScreen = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mplayer_MediaAudioVolumeChnaged(ByVal sender As Object, ByVal e As EventArgs)
        'set volume levels with mute button
        If VolTkbar.Value = 0 Then
            MuteRadbtn.Image = My.Resources.Mute_16px
            mplayer.Audio.Mute = True
        ElseIf VolTkbar.Value < (VolTkbar.Maximum / 2) Then
            MuteRadbtn.Image = My.Resources.Low_Volume_16px
            mplayer.Mute = False
            Lbl.Text = mplayer.Audio.Volume
        ElseIf VolTkbar.Value > (VolTkbar.Maximum / 2) Then
            MuteRadbtn.Image = My.Resources.Voice_16px
            mplayer.Mute = False
            Lbl.Text = mplayer.Audio.Volume

        End If
    End Sub

    Private Sub MuteRadbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuteRadbtn.Click
        'set mute button
        If mplayer.Mute = False Then
            mplayer.Mute = True
            MuteRadbtn.Image = My.Resources.Mute_16px
            VolTkbar.Value = 0
            RadMenuItem47.IsChecked = True

        Else
            mplayer.Mute = False
            MuteRadbtn.Image = My.Resources.Voice_16px
            VolTkbar.Value = VolTkbar.Maximum
            RadMenuItem47.IsChecked = False

        End If
    End Sub

    Private Sub radbtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnStop.Click
        Try
            mplayer.Stop()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub shuffle(ByVal ampa As Boolean)
        On Error Resume Next
        If ampa = True Then
            radbtnShfl.BackColor = Color.Gray
            Mini.radbtnShfl.BackColor = Color.Gray

            Randomize()
            Dim cc As Integer = PLayList.lvPl.Items.Count
            'Dim cr As Integer = PLayList.lvPl.Items.IndexOf(PLayList.lvPl.SelectedItems(0))
            'For i As Integer = 0 To cc
            '    Dim r As New Random()
            '    ' lbl1.Text = r.Next(1, cc)
            '    cr = r.Next(0, cc - 1)
            '    PLayList.lvPl.Items(cr).Selected = True
            'Next
            Dim rand As New Random()
            fIndex = rand.Next(0, cc - 1)
            PLayList.lvPl.Items(fIndex).Selected = True
            PLayList.lvPl.Select()

        Else
            radbtnShfl.BackColor = Color.White
            Mini.radbtnShfl.BackColor = Color.White
        End If

    End Sub

    Private Sub radbtnShfl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnShfl.Click
        If radbtnShfl.BackColor = Color.White Then

            shuffle(True)
        Else
            shuffle(False)

        End If
        RadMenuItem40.PerformClick()
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
                    mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
                Else
                    PLayList.lvPl.Items(0).Selected = True
                    mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
                End If
                If mplayer.LastErrorCode = 277 Then
                    PLayList.lvPl.Items(0).Selected = True
                    mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
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
        mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
        If mplayer.LastErrorCode = 277 Then
            PLayList.lvPl.Items(0).Selected = True
            mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
        End If

        'nt1.ShowBalloonTip(3000, "MPLite Player", "MPLite - Playing : " & Path.GetFileName(mplayer.FileName), ToolTipIcon.Info)
    End Sub
    Private Sub radbtnNxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnNxt.Click
        Try
            If radbtnShfl.BackColor = Color.Gray Then
                shuffle(True)
                mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)
            Else
                Nxt()

            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub radbtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnPrev.Click
        Try
            If radbtnShfl.BackColor = Color.Gray Then
                shuffle(True)
                mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)

            Else
                prev()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub loopp(ByVal ampa As Boolean)
        Try
            If ampa = True Then
                radbtnLoop.BackColor = Color.Gray
                Mini.radbtnLoop.BackColor = Color.Gray
                mplayer.Repeat = True

            Else
                radbtnLoop.BackColor = Color.White
                Mini.radbtnLoop.BackColor = Color.White
                mplayer.Repeat = False

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub radbtnLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnLoop.Click
        If radbtnLoop.BackColor = Color.White Then
            loopp(True)
        Else
            loopp(False)
        End If
        RadMenuItem48.PerformClick()
    End Sub

    Private Sub Me_StartupNextInstance(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs)
        'load files at startup
        'Try
        '    If e.CommandLine.Count > 0 Then
        '        For Each args As String In e.CommandLine
        '            Dim format As String = IO.Path.GetExtension(args)
        '            If format = ".mpl" Or format = ".rampl" Then

        '                If IO.File.Exists(args) Then '// check if file exists.
        '                    Dim myCoolFileLines() As String = IO.File.ReadAllLines(args) '// load your file as a string array.
        '                    For Each line As String In myCoolFileLines '// loop thru array list.
        '                        Dim lineArray() As String = line.Split("#") '// separate by "#" character.
        '                        Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
        '                        newItem.SubItems.Add(lineArray(1)) '// add SubItem.
        '                        newItem.ImageIndex = 0
        '                        PLayList.lvPl.Items.Add(newItem) '// add Item to ListView.
        '                    Next

        '                End If
        '            ElseIf format = ".m3u" Then

        '                Dim readpl() As String = IO.File.ReadAllLines(args)
        '                For Each line As String In readpl
        '                    If Not line.StartsWith("#") Then
        '                        PLayList.lvPl.Items.Add(line)

        '                    End If
        '                Next

        '            Else
        '                'PLayList.lvPl.BeginUpdate()
        '                For Each ff As String In args
        '                    Dim sz As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(ff)
        '                    Dim mb As Integer = 1024000

        '                    Dim dtls As New ListViewItem((ff))
        '                    dtls.SubItems.Add(Math.Round(sz.Length / mb, 2, 2) & " MB")

        '                    dtls.ImageIndex = 0
        '                    PLayList.lvPl.Items.Add(dtls)
        '                    'select first track
        '                Next
        '                'PLayList.lvPl.EndUpdate()
        '                For i As Integer = 0 To PLayList.lvPl.Items.Count
        '                    PLayList.lvPl.Items(0).Selected = True
        '                Next
        '                ' mplayer.Play(PLayList.lvPl.SelectedItems(0).SubItems(0).Text)

        '            End If
        '        Next

        '    Else
        '        If IO.File.Exists(myCoolFile1) Then '// check if file exists.
        '            Dim myCoolFileLines() As String = IO.File.ReadAllLines(myCoolFile1) '// load your file as a string array.
        '            For Each line As String In myCoolFileLines '// loop thru array list.
        '                Dim lineArray() As String = line.Split("#") '// separate by "#" character.
        '                Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
        '                newItem.SubItems.Add(lineArray(1))
        '                newItem.ImageIndex = 0
        '                PLayList.lvPl.Items.Add(newItem) '// add Item to ListView.

        '            Next
        '            For i As Integer = 0 To PLayList.lvPl.Items.Count
        '                PLayList.lvPl.Items(0).Selected = True

        '            Next

        '        End If

        '    End If

        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub radbtnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnPlay.Click
        Try
            If mplayer.Playing = True Then
                Dim num As Integer = 0
                num = Val(LblNum2.Text) + 1
                LblNum2.Text = num
                Select Case LblNum2.Text
                    Case 1
                        mplayer.Pause()
                    Case 2
                        mplayer.Resume()
                        LblNum2.Text = 0
                End Select
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Main_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Console.WriteLine(Me.Size)
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Mini.Show()

        End If
    End Sub

    Private Sub RadMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem14.Click
        radbtnPlay.PerformClick()
    End Sub

    Private Sub VolTkbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolTkbar.Scroll

    End Sub

    Private Sub RadMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem18.Click
        Application.Exit()
    End Sub

    Private Sub RadMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem8.Click
        radbtnLoad.PerformClick()
    End Sub

    Private Sub RadMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem9.Click
        PLayList.AdFolbtn.PerformClick()
    End Sub

    Private Sub mplayer_MediaPaused(ByVal sender As Object, ByVal e As EventArgs)
        Try

            radbtnPlay.Image = My.Resources.Play_24px
            Mini.radbtnPlay.Image = My.Resources.Play_24px
            tbplay.Image = My.Resources.Play_24px

            'Taginfo = Nothing
            'DispPnl.BackgroundImage = Nothing
            'Mini.PbxTag.BackgroundImage = Nothing
            SubTrackLbl.Text = Taginfo.Artist + vbNewLine + Taginfo.Title
            Me.Text = "Paused: " + Taginfo.Title + " - RAMP Player"
            Mini.Lbl.Text = Taginfo.Title
            PLayList.Text = "Paused: " + Taginfo.Title

        Catch ex As Exception
        End Try
    End Sub

    Private Sub mplayer_Resumed(ByVal sender As Object, ByVal e As EventArgs)

        radbtnPlay.Image = My.Resources.Pause_24px
        Mini.radbtnPlay.Image = My.Resources.Pause_24px
        tbplay.Image = My.Resources.Pause_24px
        SubTrackLbl.Text = Taginfo.Artist + vbNewLine + Taginfo.Title
        Me.Text = "Playing: " + Taginfo.Title + " - RAMP Player"
        Mini.Lbl.Text = Taginfo.Title
        PLayList.Text = "Playing: " + Taginfo.Title

    End Sub

    Private Sub RadMenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem46.Click
        Try
            mplayer.SystemPanels.ShowDisplaySettings()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem23.Click
        Try
            mplayer.SystemPanels.ShowAudioDevices()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem24.Click
        Try
            'audio mixer
            mplayer.SystemPanels.ShowAudioMixer()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem47.Click

        MuteRadbtn.PerformClick()
    End Sub

    Private Sub RadMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem15.Click
        radbtnStop.PerformClick()
    End Sub

    Private Sub RadMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem16.Click
        radbtnNxt.PerformClick()
    End Sub

    Private Sub RadMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem17.Click
        radbtnPrev.PerformClick()
    End Sub

    Private Sub RadMenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem41.Click
        Try
            mplayer.Speed = 1500
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem42.Click
        Try
            mplayer.Speed = 1250
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem43.Click
        Try
            mplayer.Speed = 1000
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem44.Click
        Try
            mplayer.Speed = 850
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem45.Click
        Try
            mplayer.Speed = 700
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem40.Click
        If RadMenuItem40.IsChecked = True Then
            shuffle(True)
        Else
            shuffle(False)
        End If
    End Sub

    Private Sub RadMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem48.Click
        'radbtnLoop.PerformClick()
        If RadMenuItem48.IsChecked = True Then
            loopp(True)
        Else
            loopp(False)
        End If
    End Sub

    Private Sub RadMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem20.Click
        Try
            If RadMenuItem47.IsChecked = True Then
                RadMenuItem47.ToggleState = Enumerations.ToggleState.Off
                mplayer.Audio.Volume += 100
            Else
                mplayer.Audio.Volume += 100
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem21.Click
        Try
            If RadMenuItem47.IsChecked = True Then
                RadMenuItem47.ToggleState = Enumerations.ToggleState.Off
                mplayer.Audio.Volume -= 100
            Else
                mplayer.Audio.Volume -= 100
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem63.Click
        If mplayer.Subtitles.Enabled = True Then

        End If
    End Sub

    Private Sub RadMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem30.Click
        If mplayer.HasVideo = True Then
            If RadMenuItem30.IsChecked = True Then
                mplayer.Video.Enabled = False
            Else
                mplayer.Video.Enabled = True
            End If
        End If

    End Sub

    Private Sub RadMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem28.Click
        radbtnFS.PerformClick()
    End Sub

    Private Sub RadMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem31.Click

    End Sub

    Private Sub RadMenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem36.Click
        PLayList.ClFlbtn.PerformClick()
    End Sub

    Private Sub RadMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem37.Click
        PLayList.Savebtn.PerformClick()
    End Sub

    Private Sub RadMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem38.Click
        Try
            'auyomatically saving playlist when playlist closes
            Dim myWriter As New IO.StreamWriter(myCoolFile1)
            For Each myItem As ListViewItem In PLayList.lvPl.Items
                myWriter.WriteLine(myItem.Text & "#" & myItem.SubItems(1).Text)  '// write Item and SubItem.
            Next
            myWriter.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem12.Click
        RadAboutBox1.Show()
    End Sub

    Private Sub RadMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem35.Click
        radbtnPlst.PerformClick()
    End Sub

    Private Sub RadMenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem64.Click
        radbtnMini.PerformClick()
    End Sub

    Private Sub RadMenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem62.Click
        If mplayer.HasVideo Then
            Using ofd As New OpenFileDialog
                With ofd
                    .Filter = "Subtitle File|*.srt"
                    .Title = "Add Subtitle File"
                    .Multiselect = False
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        mplayer.Subtitles.FileName = .FileName.ToString

                    End If
                End With
            End Using
        End If
    End Sub

    Private Sub DispPnlPP_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispPnlPP.DoubleClick
        Try
            If mplayer.HasVideo = True Then
                If mplayer.FullScreen = False Then
                    mplayer.FullScreen = True
                    mplayer.FullScreenMode = FullScreenMode.Parent

                Else
                    mplayer.FullScreen = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem10.Click
        Process.Start("explorer.exe", "https://www.facebook.com/rpsystemsinc")

    End Sub

    Private Sub RadMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem11.Click
        Process.Start("explorer.exe", "https://www.rpsystemsinc.wordpress.com")

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        RadMenuItem14.PerformClick()
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        radbtnNxt.PerformClick()
    End Sub

    Private Sub PreviousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousToolStripMenuItem.Click
        radbtnPrev.PerformClick()
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        radbtnStop.PerformClick()
    End Sub

    Private Sub ShuffleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShuffleToolStripMenuItem.Click
        radbtnShfl.PerformClick()
    End Sub

    Private Sub RepeatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeatToolStripMenuItem.Click
        radbtnLoop.PerformClick()
    End Sub

    Private Sub FullscreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullscreenToolStripMenuItem.Click
        radbtnFS.PerformClick()
    End Sub

    Private Sub AspectRatioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AspectRatioToolStripMenuItem.Click
        radbtnScale.PerformClick()
    End Sub

    Private Sub PlaylistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaylistToolStripMenuItem.Click
        radbtnPlst.PerformClick()
    End Sub

    Private Sub MiniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiniToolStripMenuItem.Click
        If Me.Visible = True Then
            Me.Hide()
            Mini.Show()
        Else
            Mini.Hide()
            Me.Show()
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        On Error Resume Next
        Application.Exit()
    End Sub

    Private Sub Nt1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Nt1.MouseDoubleClick
        If Me.Visible = True Then
            Me.Hide()
            Mini.Show()
        Else
            Mini.Hide()
            Me.Show()
        End If
    End Sub

    Private Sub RadMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem25.Click
        mplayer.Audio.Balance = 1000
    End Sub

    Private Sub RadMenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem26.Click
        mplayer.Audio.Balance = 0
    End Sub

    Private Sub RadMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem27.Click
        mplayer.Audio.Balance = 500

    End Sub

    Private Sub RadMenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMenuItem65.Click
        If Me.Size <> Me.MinimumSize Then
            Me.Size = Me.MinimumSize
        Else 'If Me.Size = Me.MinimumSize Then
            Dim msz As New Size(1157, 701)
            Me.Size = msz
        End If

    End Sub

    Private Sub tbplay_Click(ByVal sender As System.Object, ByVal e As DevExpress.Utils.Taskbar.ThumbButtonClickEventArgs) Handles tbplay.Click
        radbtnPlay.PerformClick()

    End Sub

    Private Sub tbnext_Click(ByVal sender As System.Object, ByVal e As DevExpress.Utils.Taskbar.ThumbButtonClickEventArgs) Handles tbnext.Click
        radbtnNxt.PerformClick()
    End Sub

    Private Sub tbstop_Click(ByVal sender As System.Object, ByVal e As DevExpress.Utils.Taskbar.ThumbButtonClickEventArgs) Handles tbstop.Click
        radbtnStop.PerformClick()
    End Sub

    Private Sub tbprev_Click(ByVal sender As System.Object, ByVal e As DevExpress.Utils.Taskbar.ThumbButtonClickEventArgs) Handles tbprev.Click
        radbtnPrev.PerformClick()
    End Sub
End Class
