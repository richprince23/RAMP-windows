Imports Microsoft.VisualBasic.ApplicationServices

Public Class PLayList
    Public myCoolFile1 As String = My.Computer.FileSystem.SpecialDirectories.MyMusic & "\Default.rampl"       'default playlist
    Public myCoolFile As String
    Private Sub lvPl_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPl.DoubleClick
        Try

            'mplayer.Play(PLayList.lvPl.SelectedItems(0).Text)
            Dim s As String = lvPl.SelectedItems(0).Text
            If s.EndsWith(".m3u") Or s.EndsWith(".m3u8") Then
                Dim readpl() As String = IO.File.ReadAllLines(s.ToString)
                For Each line As String In readpl
                    If Not line.StartsWith("#") Then
                        If Not line.StartsWith("file:///") Then
                            Dim cst As New ListViewItem(line)
                            cst.ImageIndex = 0
                            lvPl.Items.Add(cst)
                        Else
                            Dim newLine As String
                            newLine = line.Remove("file:///")
                            newLine = newLine.Replace("/", "\")
                            newLine = newLine.Replace("%20", " ")
                            Dim cst As New ListViewItem(newLine)
                            cst.ImageIndex = 0
                            lvPl.Items.Add(cst)
                        End If
                        lvPl.SelectedItems(0).Remove()

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
                    lvPl.Items.Add(newItem) '// add Item to ListView.
                    lvPl.SelectedItems(0).Remove()

                Next
            End If
            Main.mplayer.Play(lvPl.SelectedItems(0).Text)

            If Main.mplayer.LastErrorCode = 277 Then
                lvPl.Items(0).Selected = True
                Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ClFlbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClFlbtn.Click
        'clear all items from playlist
        Try
            lvPl.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RmvFbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RmvFbtn.Click
        Try
            'lvPl.Items.RemoveAt(lvPl.Items.IndexOf(lvPl.SelectedItems(0)))
            For Each itm In lvPl.SelectedItems
                lvPl.Items.Remove(itm)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AdFolbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdFolbtn.Click
        Using ffd As New FolderBrowserDialog
            With ffd
                .Description = "Open Media Files"
                If .ShowDialog = DialogResult.OK Then
                    lvPl.BeginUpdate()
                    Dim dr As String = .SelectedPath.ToString
                    Dim format As String = "*.3gp;*.aa;*.aac;*.aiff;*.amr;*.ape;*.flac;*.m4a;*.mid;*.midi;*.mka;*.mp3;*.mpc;*.ogg;*.opus;*.ra;*.rm;*.wav;*.wma;*.wv;*.asf;*.avi;*.bik;*.divx;*.dvx;*.f4v;*.flv;*.h264;*.hdmov;*.mkv;*.mov;*.mp2;*.mp4;*.mpeg;*.mpeg4;*.mpg;*.mpv;*.mts;*.ogg;*.ogm;*.ogv;*.qt;*.rm;*.rms;*.rmvb;*.swf;*.ts;*.vfw;*.vob;*.webm;*.wmv;*.xvid"

                    For Each ff As String In My.Computer.FileSystem.GetFiles(dr, FileIO.SearchOption.SearchAllSubDirectories, format.Split(";"))
                        Dim sz As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(ff)
                        Dim mb As Integer = 1024000
                        Dim dtls As New ListViewItem(ff)
                        dtls.ImageIndex = 0
                        dtls.SubItems.Add(Math.Round(sz.Length / mb, 2) & " MB")
                        lvPl.Items.Add(dtls)
                    Next
                    lvPl.EndUpdate()
                End If
            End With
        End Using
    End Sub


    Private Sub AddFLbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFLbtn.Click
        On Error Resume Next
        'loading files
        Using ofd As New OpenFileDialog
            With ofd
                .Title = "Open Media Files"
                .Filter = "All Media Files|*.3gp;*.aa;*.aac;*.aiff;*.amr;*.ape;*.flac;*.m4a;*.mid;*.midi;*.mka;*.mp3;*.mpc;*.ogg;*.opus;*.ra;*.rm;*.wav;*.wma;*.wv;*.asf;*.avi;*.bik;*.divx;*.dvx;*.f4v;*.flv;*.h264;*.hdmov;*.mkv;*.mov;*.mp2;*.mp4;*.mpeg;*.mpeg4;*.mpg;*.mpv;*.mts;*.ogg;*.ogm;*.ogv;*.qt;*.rm;*.rms;*.rmvb;*.swf;*.ts;*.vfw;*.vob;*.webm;*.wmv;*.xvid;*.mpl;*.rampl;*.m3u;*.m3u8" +
                "|Audio Files|*.3gp;*.aa;*.aac;*.aiff;*.amr;*.ape;*.flac;*.m4a;*.mid;*.midi;*.mka;*.mp3;*.mpc;*.ogg;*.opus;*.ra;*.rm;*.wav;*.wma;*.wv" +
                "|Videos Files|*.asf;*.avi;*.bik;*.divx;*.dvx;*.f4v;*.flv;*.h264;*.hdmov;*.mkv;*.mov;*.mp2;*.mp4;*.mpeg;*.mpeg4;*.mpg;*.mpv;*.mts;*.ogg;*.ogm;*.ogv;*.qt;*.rm;*.rms;*.rmvb;*.swf;*.ts;*.vfw;*.vob;*.webm;*.wmv;*.xvid" +
                "|RAMP Playlist Files|*.mpl;*.rampl;*.m3u;*.m3u8"
                .FileName = ""
                .Multiselect = True
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    'lvPl.BeginUpdate()
                    Dim format As String = IO.Path.GetExtension(ofd.FileName)
                    If format = ".mpl" Or format = ".rampl" Then

                        If IO.File.Exists(ofd.FileName) Then '// check if file exists.
                            Dim myCoolFileLines() As String = IO.File.ReadAllLines(ofd.FileName) '// load your file as a string array.
                            For Each line As String In myCoolFileLines '// loop thru array list.
                                Dim lineArray() As String = line.Split("#") '// separate by "#" character.
                                Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
                                newItem.SubItems.Add(lineArray(1)) '// add SubItem.
                                newItem.ImageIndex = 0
                                lvPl.Items.Add(newItem) '// add Item to ListView.
                            Next

                        End If
                    ElseIf format = ".m3u" Or format = ".m3u8" Then
                        Dim readpl() As String = IO.File.ReadAllLines(ofd.FileName)

                        For Each line As String In readpl
                            If Not line.StartsWith("#") Then
                                If Not line.StartsWith("file:///") Then
                                    Dim cst As New ListViewItem(line)
                                    cst.ImageIndex = 0
                                    lvPl.Items.Add(cst)
                                Else
                                    Dim newLine As String
                                    newLine = line.Remove("file:///")
                                    newLine = newLine.Replace("/", "\")
                                    newLine = newLine.Replace("%20", " ")
                                    Dim cst As New ListViewItem(newLine)
                                    cst.ImageIndex = 0
                                    lvPl.Items.Add(cst)
                                End If
                            End If
                        Next
                    Else
                        lvPl.BeginUpdate()
                        For Each ff As String In ofd.FileNames
                            Dim sz As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(ff)
                            Dim mb As Integer = 1024000

                            Dim dtls As New ListViewItem((ff))
                            dtls.SubItems.Add(Math.Round(sz.Length / mb, 2) & " MB")

                            dtls.ImageIndex = 0
                            lvPl.Items.Add(dtls)
                            'select first track
                        Next
                        lvPl.EndUpdate()
                    End If
                    'PlayList.lvPl.EndUpdate()
                End If
            End With
        End Using
    End Sub
    Private Sub save()
        On Error Resume Next
        Dim sfd As New SaveFileDialog
        With sfd
            .DefaultExt = "RAMPlaylist File|*.rampl"
            .Filter = "RAM Playlist File|*.rampl"
            .Title = "Save RAM Playlist File"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                myCoolFile = sfd.FileName
                Dim myWriter As New IO.StreamWriter(myCoolFile)
                For Each myItem As ListViewItem In lvPl.Items
                    myWriter.WriteLine(myItem.Text & "#" & myItem.SubItems(1).Text)  '// write Item and SubItem.
                Next
                myWriter.Close()
            End If
        End With

    End Sub

    Private Sub Savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Savebtn.Click
        save()
    End Sub

    Private Sub PLayList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop, lvPl.DragDrop

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
                                lvPl.Items.Add(cst)
                            Else
                                Dim newLine As String
                                newLine = line.Remove("file:///")
                                newLine = newLine.Replace("/", "\")
                                newLine = newLine.Replace("%20", " ")
                                Dim cst As New ListViewItem(newLine)
                                MsgBox(newLine)
                                cst.ImageIndex = 0
                                lvPl.Items.Add(cst)
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
                        lvPl.Items.Add(newItem) '// add Item to ListView.
                    Next

                Else

                    Dim mb As Integer = 1024000
                    Dim dtls As New ListViewItem(s)
                    dtls.ImageIndex = 0
                    dtls.SubItems.Add(Math.Round(sz.Length / mb, 2) & " MB")
                    lvPl.Items.Add(dtls)
                End If
            Next

            Dim cr As Integer = lvPl.Items.Count - 1
            lvPl.Items(cr).Selected = True
            Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)
            If Main.mplayer.LastErrorCode = 277 Then
                lvPl.Items(0).Selected = True
                Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PLayList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'auyomatically saving playlist when playlist closes
            Dim myWriter As New IO.StreamWriter(myCoolFile1)
            For Each myItem As ListViewItem In lvPl.Items
                myWriter.WriteLine(myItem.Text & "#" & myItem.SubItems(1).Text)  '// write Item and SubItem.
            Next
            myWriter.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PLayList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'loading files at startup
        AddHandler My.Application.StartupNextInstance, AddressOf StartupNextInstanceEventArgs
        Me.Focus()

        Try
            If My.Application.CommandLineArgs.Count > 0 Then
                For Each args As String In My.Application.CommandLineArgs
                    Dim format As String = IO.Path.GetExtension(args)
                    If format = ".mpl" Or format = ".rampl" Then
                        If IO.File.Exists(args) Then '// check if file exists.
                            Dim myCoolFileLines() As String = IO.File.ReadAllLines(args) '// load your file as a string array.
                            For Each line As String In myCoolFileLines '// loop thru array list.
                                Dim lineArray() As String = line.Split("#") '// separate by "#" character.
                                Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
                                newItem.SubItems.Add(lineArray(1)) '// add SubItem.
                                newItem.ImageIndex = 0
                                lvPl.Items.Add(newItem) '// add Item to ListView.
                            Next
                            For i As Integer = 0 To lvPl.Items.Count
                                lvPl.Items(0).Selected = True
                            Next
                            Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)
                        End If

                    ElseIf format = ".m3u" Or format = ".m3u8" Then
                        Dim readpl() As String = IO.File.ReadAllLines(args)
                        For Each line As String In readpl
                            If Not line.StartsWith("file:///") Then
                                Dim cst As New ListViewItem(line)
                                cst.ImageIndex = 0
                                lvPl.Items.Add(cst)
                            Else
                                Dim newLine As String
                                newLine = line.Remove("file:///")
                                newLine = newLine.Replace("/", "\")
                                newLine = newLine.Replace("%20", " ")
                                Dim cst As New ListViewItem(newLine)
                                cst.ImageIndex = 0
                                lvPl.Items.Add(cst)
                            End If
                        Next
                        For i As Integer = 0 To lvPl.Items.Count
                            lvPl.Items(0).Selected = True
                        Next
                        Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)

                    Else

                        'For Each ff As String In args
                        Dim sz As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(args)
                        Dim mb As Integer = 1024000
                        Dim dtls As New ListViewItem((args))
                        dtls.SubItems.Add(Math.Round(sz.Length / mb, 2) & " MB")
                        dtls.ImageIndex = 0

                        lvPl.Items.Add(dtls)
                        ' Next

                        For i As Integer = 0 To lvPl.Items.Count
                            lvPl.Items(0).Selected = True
                        Next
                        Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)

                    End If
                Next

            Else
                If IO.File.Exists(myCoolFile1) Then '// check if file exists.
                    Dim myCoolFileLines() As String = IO.File.ReadAllLines(myCoolFile1) '// load your file as a string array.
                    For Each line As String In myCoolFileLines '// loop thru array list.
                        Dim lineArray() As String = line.Split("#") '// separate by "#" character.
                        Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
                        newItem.SubItems.Add(lineArray(1))
                        newItem.ImageIndex = 0
                        lvPl.Items.Add(newItem) '// add Item to ListView.

                    Next
                    For i As Integer = 0 To lvPl.Items.Count
                        lvPl.Items(0).Selected = True
                    Next
                    Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)

                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub StartupNextInstanceEventArgs(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs)
        Try
            If e.CommandLine.Count > 0 Then
                For Each args As String In e.CommandLine
                    Dim format As String = IO.Path.GetExtension(args)
                    If format = ".mpl" Or format = ".rampl" Then
                        If IO.File.Exists(args) Then '// check if file exists.
                            Dim myCoolFileLines() As String = IO.File.ReadAllLines(args) '// load your file as a string array.
                            For Each line As String In myCoolFileLines '// loop thru array list.
                                Dim lineArray() As String = line.Split("#") '// separate by "#" character.
                                Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
                                newItem.SubItems.Add(lineArray(1)) '// add SubItem.
                                newItem.ImageIndex = 0
                                lvPl.Items.Add(newItem) '// add Item to ListView.
                            Next
                            For i As Integer = 0 To lvPl.Items.Count
                                Dim cc As Integer = lvPl.Items.Count
                                lvPl.Items(cc - 1).Selected = True
                            Next
                            Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)
                        End If

                    ElseIf format = ".m3u" Or format = ".m3u8" Then
                        Dim readpl() As String = IO.File.ReadAllLines(args)
                        For Each line As String In readpl
                            If Not line.StartsWith("#") Then
                                If Not line.StartsWith("file:///") Then
                                    Dim cst As New ListViewItem(line)
                                    cst.ImageIndex = 0
                                    lvPl.Items.Add(cst)
                                Else
                                    Dim newLine As String
                                    newLine = line.Remove("file:///")
                                    newLine = newLine.Replace("/", "\")
                                    newLine = newLine.Replace("%20", " ")
                                    Dim cst As New ListViewItem(newLine)
                                    cst.ImageIndex = 0
                                    lvPl.Items.Add(cst)
                                End If
                            End If
                        Next
                        For i As Integer = 0 To lvPl.Items.Count
                            Dim cc As Integer = lvPl.Items.Count
                            lvPl.Items(cc - 1).Selected = True
                        Next
                        Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)

                    Else

                        'For Each ff As String In args
                        Dim sz As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(args)
                        Dim mb As Integer = 1024000
                        Dim dtls As New ListViewItem((args))
                        dtls.SubItems.Add(Math.Round(sz.Length / mb, 2) & " MB")
                        dtls.ImageIndex = 0

                        lvPl.Items.Add(dtls)
                        ' Next

                        For i As Integer = 0 To lvPl.Items.Count - 1
                            Dim cc As Integer = lvPl.Items.Count - 1
                            lvPl.Items(cc).Selected = True
                        Next
                        Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)

                    End If
                Next

            Else
                If IO.File.Exists(myCoolFile1) Then '// check if file exists.
                    Dim myCoolFileLines() As String = IO.File.ReadAllLines(myCoolFile1) '// load your file as a string array.
                    For Each line As String In myCoolFileLines '// loop thru array list.
                        Dim lineArray() As String = line.Split("#") '// separate by "#" character.
                        Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
                        newItem.SubItems.Add(lineArray(1))
                        newItem.ImageIndex = 0
                        lvPl.Items.Add(newItem) '// add Item to ListView.

                    Next
                    For i As Integer = 0 To lvPl.Items.Count
                        lvPl.Items(0).Selected = True
                    Next
                    Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)

                End If
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub clsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clsbtn.Click
        Me.Hide()

    End Sub

    Private Sub lvPl_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvPl.DragEnter, Me.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.Copy

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Main.mplayer.Play(lvPl.SelectedItems(0).Text)
            If Main.mplayer.LastErrorCode = 277 Then
                lvPl.Items(0).Selected = True
                Main.mplayer.Play(lvPl.SelectedItems(0).SubItems(0).Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AddFldrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFldrToolStripMenuItem.Click
        AdFolbtn.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        AddFLbtn.PerformClick()

    End Sub

    Private Sub RmvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RmvToolStripMenuItem.Click
        RmvFbtn.PerformClick()
    End Sub

    Private Sub ClarAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClarAllToolStripMenuItem.Click
        ClFlbtn.PerformClick()
    End Sub

    Private Sub SavAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavAsToolStripMenuItem.Click
        Savebtn.PerformClick()
    End Sub

    Private Sub OpenFileLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileLocationToolStripMenuItem.Click
        Try
            Process.Start("explorer.exe", IO.Path.GetDirectoryName(lvPl.SelectedItems(0).Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MediaInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaInfoToolStripMenuItem.Click
        On Error Resume Next
        TagReader.Show()
        Dim CurrentMp3 As Mp3Class
        CurrentMp3 = New Mp3Class(lvPl.SelectedItems(0).SubItems(0).Text)

        Dim CurrentID3v1 As Mp3Class.ID3v1TAG = CurrentMp3.ID3v1
        Dim Mp3FileInfo As System.IO.FileInfo = CurrentMp3.Mp3FileInfo

        Me.Text = "Mp3Class Demo '" & Mp3FileInfo.Name & "'"

        TagReader.tbxArtiste.Text = CurrentID3v1.Artist
        TagReader.tbxAlbum.Text = CurrentID3v1.Album
        TagReader.tbxSongTitle.Text = CurrentID3v1.SongTitle
        TagReader.tbxComments.Text = CurrentID3v1.Comment
        TagReader.tbxYear.Text = CurrentID3v1.Year
        TagReader.tbxGenre.Text = CurrentMp3.GetGenreString(CurrentID3v1.GenreID)
        TagReader.tbxMpegtype.Text = CurrentMp3.GetMPEGType.ToString
        TagReader.tbxLayer.Text = CurrentMp3.GetLayer.ToString

        If Not CurrentMp3.IsVBR() Then
            TagReader.tbxMP3type.Text = "Constant Bitrate"
        Else
            TagReader.tbxMP3type.Text = "Variable Bitrate"
        End If
        TagReader.tbxBitrate.Text = Val(CurrentMp3.GetBitrate) / 1000 & " Kbits/sec"
        TagReader.tbxDuration.Text = CurrentMp3.GetDurationString
        TagReader.tbxFrequency.Text = CurrentMp3.GetSamplingRateFreq & " Hz"


    End Sub

    Private Sub lvPl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPl.GotFocus
        lvPl.MultiSelect = True
        lvPl.HideSelection = False
    End Sub

    Private Sub lvPl_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPl.LostFocus
        lvPl.MultiSelect = False
        lvPl.HideSelection = True
    End Sub

    Private Sub PLayList_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        Me.Focus()
    End Sub

    Private Sub PLayList_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave

    End Sub
End Class
