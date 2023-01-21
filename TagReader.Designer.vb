<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TagReader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TagReader))
        Me.lblMP3TagReaderByJweezyBeatz = New System.Windows.Forms.Label()
        Me.tbcn1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tbxFrequency = New System.Windows.Forms.TextBox()
        Me.tbxDuration = New System.Windows.Forms.TextBox()
        Me.tbxBitrate = New System.Windows.Forms.TextBox()
        Me.tbxMP3type = New System.Windows.Forms.TextBox()
        Me.tbxLayer = New System.Windows.Forms.TextBox()
        Me.tbxMpegtype = New System.Windows.Forms.TextBox()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblBitrate = New System.Windows.Forms.Label()
        Me.lblMP3Type = New System.Windows.Forms.Label()
        Me.lblLayer = New System.Windows.Forms.Label()
        Me.lblMPEGTYPE = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbxAlbum = New System.Windows.Forms.TextBox()
        Me.tbxGenre = New System.Windows.Forms.TextBox()
        Me.tbxYear = New System.Windows.Forms.TextBox()
        Me.tbxComments = New System.Windows.Forms.TextBox()
        Me.tbxArtiste = New System.Windows.Forms.TextBox()
        Me.tbxSongTitle = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tbcn1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMP3TagReaderByJweezyBeatz
        '
        Me.lblMP3TagReaderByJweezyBeatz.AutoSize = True
        Me.lblMP3TagReaderByJweezyBeatz.Location = New System.Drawing.Point(9, 296)
        Me.lblMP3TagReaderByJweezyBeatz.Name = "lblMP3TagReaderByJweezyBeatz"
        Me.lblMP3TagReaderByJweezyBeatz.Size = New System.Drawing.Size(198, 17)
        Me.lblMP3TagReaderByJweezyBeatz.TabIndex = 1
        Me.lblMP3TagReaderByJweezyBeatz.Text = "MP3 Tag Reader by JweezyBeatz"
        '
        'tbcn1
        '
        Me.tbcn1.Controls.Add(Me.TabPage1)
        Me.tbcn1.Controls.Add(Me.TabPage2)
        Me.tbcn1.Location = New System.Drawing.Point(5, 2)
        Me.tbcn1.Name = "tbcn1"
        Me.tbcn1.SelectedIndex = 0
        Me.tbcn1.Size = New System.Drawing.Size(340, 288)
        Me.tbcn1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tbxFrequency)
        Me.TabPage1.Controls.Add(Me.tbxDuration)
        Me.TabPage1.Controls.Add(Me.tbxBitrate)
        Me.TabPage1.Controls.Add(Me.tbxMP3type)
        Me.TabPage1.Controls.Add(Me.tbxLayer)
        Me.TabPage1.Controls.Add(Me.tbxMpegtype)
        Me.TabPage1.Controls.Add(Me.lblFrequency)
        Me.TabPage1.Controls.Add(Me.lblDuration)
        Me.TabPage1.Controls.Add(Me.lblBitrate)
        Me.TabPage1.Controls.Add(Me.lblMP3Type)
        Me.TabPage1.Controls.Add(Me.lblLayer)
        Me.TabPage1.Controls.Add(Me.lblMPEGTYPE)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(332, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MP3 Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tbxFrequency
        '
        Me.tbxFrequency.Location = New System.Drawing.Point(93, 201)
        Me.tbxFrequency.Name = "tbxFrequency"
        Me.tbxFrequency.ReadOnly = True
        Me.tbxFrequency.Size = New System.Drawing.Size(161, 20)
        Me.tbxFrequency.TabIndex = 11
        Me.tbxFrequency.Text = "Frequency"
        '
        'tbxDuration
        '
        Me.tbxDuration.Location = New System.Drawing.Point(93, 164)
        Me.tbxDuration.Name = "tbxDuration"
        Me.tbxDuration.ReadOnly = True
        Me.tbxDuration.Size = New System.Drawing.Size(161, 20)
        Me.tbxDuration.TabIndex = 9
        Me.tbxDuration.Text = "Duration"
        '
        'tbxBitrate
        '
        Me.tbxBitrate.Location = New System.Drawing.Point(93, 127)
        Me.tbxBitrate.Name = "tbxBitrate"
        Me.tbxBitrate.ReadOnly = True
        Me.tbxBitrate.Size = New System.Drawing.Size(161, 20)
        Me.tbxBitrate.TabIndex = 7
        Me.tbxBitrate.Text = "Bitrate"
        '
        'tbxMP3type
        '
        Me.tbxMP3type.Location = New System.Drawing.Point(92, 90)
        Me.tbxMP3type.Name = "tbxMP3type"
        Me.tbxMP3type.ReadOnly = True
        Me.tbxMP3type.Size = New System.Drawing.Size(161, 20)
        Me.tbxMP3type.TabIndex = 5
        Me.tbxMP3type.Text = "MP3type"
        '
        'tbxLayer
        '
        Me.tbxLayer.Location = New System.Drawing.Point(92, 53)
        Me.tbxLayer.Name = "tbxLayer"
        Me.tbxLayer.ReadOnly = True
        Me.tbxLayer.Size = New System.Drawing.Size(161, 20)
        Me.tbxLayer.TabIndex = 3
        Me.tbxLayer.Text = "Layer"
        '
        'tbxMpegtype
        '
        Me.tbxMpegtype.Location = New System.Drawing.Point(93, 16)
        Me.tbxMpegtype.Name = "tbxMpegtype"
        Me.tbxMpegtype.ReadOnly = True
        Me.tbxMpegtype.Size = New System.Drawing.Size(161, 20)
        Me.tbxMpegtype.TabIndex = 1
        Me.tbxMpegtype.Text = "mpegtype"
        '
        'lblFrequency
        '
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Location = New System.Drawing.Point(6, 201)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(74, 17)
        Me.lblFrequency.TabIndex = 10
        Me.lblFrequency.Text = "Frequency :"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(6, 164)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(65, 17)
        Me.lblDuration.TabIndex = 8
        Me.lblDuration.Text = "Duration :"
        '
        'lblBitrate
        '
        Me.lblBitrate.AutoSize = True
        Me.lblBitrate.Location = New System.Drawing.Point(6, 127)
        Me.lblBitrate.Name = "lblBitrate"
        Me.lblBitrate.Size = New System.Drawing.Size(52, 17)
        Me.lblBitrate.TabIndex = 6
        Me.lblBitrate.Text = "Bitrate :"
        '
        'lblMP3Type
        '
        Me.lblMP3Type.AutoSize = True
        Me.lblMP3Type.Location = New System.Drawing.Point(6, 90)
        Me.lblMP3Type.Name = "lblMP3Type"
        Me.lblMP3Type.Size = New System.Drawing.Size(72, 17)
        Me.lblMP3Type.TabIndex = 4
        Me.lblMP3Type.Text = "MP3 Type :"
        '
        'lblLayer
        '
        Me.lblLayer.AutoSize = True
        Me.lblLayer.Location = New System.Drawing.Point(6, 53)
        Me.lblLayer.Name = "lblLayer"
        Me.lblLayer.Size = New System.Drawing.Size(46, 17)
        Me.lblLayer.TabIndex = 2
        Me.lblLayer.Text = "Layer :"
        '
        'lblMPEGTYPE
        '
        Me.lblMPEGTYPE.AutoSize = True
        Me.lblMPEGTYPE.Location = New System.Drawing.Point(6, 16)
        Me.lblMPEGTYPE.Name = "lblMPEGTYPE"
        Me.lblMPEGTYPE.Size = New System.Drawing.Size(81, 17)
        Me.lblMPEGTYPE.TabIndex = 0
        Me.lblMPEGTYPE.Text = "MPEG Type :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tbxAlbum)
        Me.TabPage2.Controls.Add(Me.tbxGenre)
        Me.TabPage2.Controls.Add(Me.tbxYear)
        Me.TabPage2.Controls.Add(Me.tbxComments)
        Me.TabPage2.Controls.Add(Me.tbxArtiste)
        Me.TabPage2.Controls.Add(Me.tbxSongTitle)
        Me.TabPage2.Controls.Add(Me.lblGenre)
        Me.TabPage2.Controls.Add(Me.lblYear)
        Me.TabPage2.Controls.Add(Me.lblComments)
        Me.TabPage2.Controls.Add(Me.lblAlbum)
        Me.TabPage2.Controls.Add(Me.lblArtist)
        Me.TabPage2.Controls.Add(Me.lblFilename)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(332, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "IDv1"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tbxAlbum
        '
        Me.tbxAlbum.Location = New System.Drawing.Point(103, 107)
        Me.tbxAlbum.Name = "tbxAlbum"
        Me.tbxAlbum.ReadOnly = True
        Me.tbxAlbum.Size = New System.Drawing.Size(203, 20)
        Me.tbxAlbum.TabIndex = 5
        Me.tbxAlbum.Text = "Album"
        '
        'tbxGenre
        '
        Me.tbxGenre.Location = New System.Drawing.Point(103, 236)
        Me.tbxGenre.Name = "tbxGenre"
        Me.tbxGenre.ReadOnly = True
        Me.tbxGenre.Size = New System.Drawing.Size(100, 20)
        Me.tbxGenre.TabIndex = 11
        Me.tbxGenre.Text = "Genre"
        '
        'tbxYear
        '
        Me.tbxYear.Location = New System.Drawing.Point(103, 201)
        Me.tbxYear.Name = "tbxYear"
        Me.tbxYear.ReadOnly = True
        Me.tbxYear.Size = New System.Drawing.Size(100, 20)
        Me.tbxYear.TabIndex = 9
        Me.tbxYear.Text = "Year"
        '
        'tbxComments
        '
        Me.tbxComments.Location = New System.Drawing.Point(103, 144)
        Me.tbxComments.Multiline = True
        Me.tbxComments.Name = "tbxComments"
        Me.tbxComments.ReadOnly = True
        Me.tbxComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxComments.Size = New System.Drawing.Size(203, 51)
        Me.tbxComments.TabIndex = 7
        Me.tbxComments.Text = "Comments"
        '
        'tbxArtiste
        '
        Me.tbxArtiste.Location = New System.Drawing.Point(103, 67)
        Me.tbxArtiste.Name = "tbxArtiste"
        Me.tbxArtiste.ReadOnly = True
        Me.tbxArtiste.Size = New System.Drawing.Size(203, 20)
        Me.tbxArtiste.TabIndex = 3
        Me.tbxArtiste.Text = "Artiste"
        '
        'tbxSongTitle
        '
        Me.tbxSongTitle.Location = New System.Drawing.Point(103, 28)
        Me.tbxSongTitle.Name = "tbxSongTitle"
        Me.tbxSongTitle.ReadOnly = True
        Me.tbxSongTitle.Size = New System.Drawing.Size(203, 20)
        Me.tbxSongTitle.TabIndex = 1
        Me.tbxSongTitle.Text = "Song Title"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(20, 239)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(50, 17)
        Me.lblGenre.TabIndex = 10
        Me.lblGenre.Text = "Genre :"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(20, 204)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(40, 17)
        Me.lblYear.TabIndex = 8
        Me.lblYear.Text = "Year :"
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(19, 147)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(77, 17)
        Me.lblComments.TabIndex = 6
        Me.lblComments.Text = "Comments :"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(20, 110)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(52, 17)
        Me.lblAlbum.TabIndex = 4
        Me.lblAlbum.Text = "Album :"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(20, 70)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(45, 17)
        Me.lblArtist.TabIndex = 2
        Me.lblArtist.Text = "Artist :"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(19, 28)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(66, 17)
        Me.lblFilename.TabIndex = 0
        Me.lblFilename.Text = "Filename :"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(270, 296)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 27)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TagReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepPink
        Me.ClientSize = New System.Drawing.Size(346, 323)
        Me.Controls.Add(Me.lblMP3TagReaderByJweezyBeatz)
        Me.Controls.Add(Me.tbcn1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TagReader"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.Text = "TagReader"
        Me.ThemeName = "Fluent"
        Me.tbcn1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMP3TagReaderByJweezyBeatz As System.Windows.Forms.Label
    Friend WithEvents tbcn1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tbxFrequency As System.Windows.Forms.TextBox
    Friend WithEvents tbxDuration As System.Windows.Forms.TextBox
    Friend WithEvents tbxBitrate As System.Windows.Forms.TextBox
    Friend WithEvents tbxMP3type As System.Windows.Forms.TextBox
    Friend WithEvents tbxLayer As System.Windows.Forms.TextBox
    Friend WithEvents tbxMpegtype As System.Windows.Forms.TextBox
    Friend WithEvents lblFrequency As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents lblBitrate As System.Windows.Forms.Label
    Friend WithEvents lblMP3Type As System.Windows.Forms.Label
    Friend WithEvents lblLayer As System.Windows.Forms.Label
    Friend WithEvents lblMPEGTYPE As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tbxAlbum As System.Windows.Forms.TextBox
    Friend WithEvents tbxGenre As System.Windows.Forms.TextBox
    Friend WithEvents tbxYear As System.Windows.Forms.TextBox
    Friend WithEvents tbxComments As System.Windows.Forms.TextBox
    Friend WithEvents tbxArtiste As System.Windows.Forms.TextBox
    Friend WithEvents tbxSongTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblAlbum As System.Windows.Forms.Label
    Friend WithEvents lblArtist As System.Windows.Forms.Label
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

