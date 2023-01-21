<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLayList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLayList))
        Me.imgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.lvPl = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PlsCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFlsToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFldrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RmvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClarAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SavAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClFlbtn = New Telerik.WinControls.UI.RadButton()
        Me.RmvFbtn = New Telerik.WinControls.UI.RadButton()
        Me.AdFolbtn = New Telerik.WinControls.UI.RadButton()
        Me.AddFLbtn = New Telerik.WinControls.UI.RadButton()
        Me.Savebtn = New Telerik.WinControls.UI.RadButton()
        Me.Clsbtn = New Telerik.WinControls.UI.RadButton()
        Me.Tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.PlsCMS.SuspendLayout()
        CType(Me.ClFlbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmvFbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdFolbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddFLbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Savebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clsbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLst
        '
        Me.imgLst.ImageStream = CType(resources.GetObject("imgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLst.Images.SetKeyName(0, "icons8_Circled_Play.ico")
        '
        'lvPl
        '
        Me.lvPl.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lvPl.AllowDrop = True
        Me.lvPl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvPl.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3})
        Me.lvPl.ContextMenuStrip = Me.PlsCMS
        Me.lvPl.ForeColor = System.Drawing.Color.Navy
        Me.lvPl.FullRowSelect = True
        Me.lvPl.GridLines = True
        Me.lvPl.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPl.HideSelection = False
        Me.lvPl.Location = New System.Drawing.Point(5, 3)
        Me.lvPl.MultiSelect = False
        Me.lvPl.Name = "lvPl"
        Me.lvPl.ShowItemToolTips = True
        Me.lvPl.Size = New System.Drawing.Size(950, 322)
        Me.lvPl.SmallImageList = Me.imgLst
        Me.lvPl.StateImageList = Me.imgLst
        Me.lvPl.TabIndex = 0
        Me.lvPl.UseCompatibleStateImageBehavior = False
        Me.lvPl.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "FilePath"
        Me.ColumnHeader1.Width = 800
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'PlsCMS
        '
        Me.PlsCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AddFlsToolStripMenuItem, Me.ToolStripMenuItem2, Me.AddFldrToolStripMenuItem, Me.ToolStripSeparator1, Me.RmvToolStripMenuItem, Me.ClarAllToolStripMenuItem, Me.ToolStripSeparator2, Me.SavAsToolStripMenuItem, Me.ToolStripSeparator3, Me.OpenFileLocationToolStripMenuItem, Me.MediaInfoToolStripMenuItem})
        Me.PlsCMS.Name = "PlsCMS"
        Me.PlsCMS.Size = New System.Drawing.Size(177, 204)
        Me.PlsCMS.Text = "Pls"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem1.Text = "Play"
        '
        'AddFlsToolStripMenuItem
        '
        Me.AddFlsToolStripMenuItem.Name = "AddFlsToolStripMenuItem"
        Me.AddFlsToolStripMenuItem.Size = New System.Drawing.Size(173, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem2.Text = "Add Files"
        '
        'AddFldrToolStripMenuItem
        '
        Me.AddFldrToolStripMenuItem.Name = "AddFldrToolStripMenuItem"
        Me.AddFldrToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AddFldrToolStripMenuItem.Text = "Add Folder "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'RmvToolStripMenuItem
        '
        Me.RmvToolStripMenuItem.Name = "RmvToolStripMenuItem"
        Me.RmvToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RmvToolStripMenuItem.Text = "Remove File"
        '
        'ClarAllToolStripMenuItem
        '
        Me.ClarAllToolStripMenuItem.Name = "ClarAllToolStripMenuItem"
        Me.ClarAllToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ClarAllToolStripMenuItem.Text = "Clear All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(173, 6)
        '
        'SavAsToolStripMenuItem
        '
        Me.SavAsToolStripMenuItem.Name = "SavAsToolStripMenuItem"
        Me.SavAsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SavAsToolStripMenuItem.Text = "Save Playlist As"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(173, 6)
        '
        'OpenFileLocationToolStripMenuItem
        '
        Me.OpenFileLocationToolStripMenuItem.Name = "OpenFileLocationToolStripMenuItem"
        Me.OpenFileLocationToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.OpenFileLocationToolStripMenuItem.Text = "Open File Location "
        '
        'MediaInfoToolStripMenuItem
        '
        Me.MediaInfoToolStripMenuItem.Name = "MediaInfoToolStripMenuItem"
        Me.MediaInfoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MediaInfoToolStripMenuItem.Text = "Media Info "
        '
        'ClFlbtn
        '
        Me.ClFlbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClFlbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClFlbtn.Image = Global.RAMP.My.Resources.Resources.Trash_24px
        Me.ClFlbtn.Location = New System.Drawing.Point(341, 331)
        Me.ClFlbtn.Name = "ClFlbtn"
        Me.ClFlbtn.Size = New System.Drawing.Size(112, 36)
        Me.ClFlbtn.TabIndex = 4
        Me.ClFlbtn.Text = "Clear All"
        Me.ClFlbtn.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.ClFlbtn.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.ClFlbtn, "Clear all media items from playlist")
        '
        'RmvFbtn
        '
        Me.RmvFbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RmvFbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RmvFbtn.Image = Global.RAMP.My.Resources.Resources.Delete_File_24px
        Me.RmvFbtn.Location = New System.Drawing.Point(229, 331)
        Me.RmvFbtn.Name = "RmvFbtn"
        Me.RmvFbtn.Size = New System.Drawing.Size(112, 36)
        Me.RmvFbtn.TabIndex = 3
        Me.RmvFbtn.Text = "Remove"
        Me.RmvFbtn.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RmvFbtn.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.RmvFbtn, "Remove selected media  file(s)")
        '
        'AdFolbtn
        '
        Me.AdFolbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AdFolbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdFolbtn.Image = Global.RAMP.My.Resources.Resources.Add_Folder_24px
        Me.AdFolbtn.Location = New System.Drawing.Point(117, 331)
        Me.AdFolbtn.Name = "AdFolbtn"
        Me.AdFolbtn.Size = New System.Drawing.Size(112, 36)
        Me.AdFolbtn.TabIndex = 2
        Me.AdFolbtn.Text = "Folder"
        Me.AdFolbtn.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.AdFolbtn.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.AdFolbtn, "Add media folder")
        '
        'AddFLbtn
        '
        Me.AddFLbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddFLbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddFLbtn.Image = Global.RAMP.My.Resources.Resources.Add_File_24px
        Me.AddFLbtn.Location = New System.Drawing.Point(5, 331)
        Me.AddFLbtn.Name = "AddFLbtn"
        Me.AddFLbtn.Size = New System.Drawing.Size(112, 36)
        Me.AddFLbtn.TabIndex = 1
        Me.AddFLbtn.Text = "File"
        Me.AddFLbtn.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.AddFLbtn.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.AddFLbtn, "Load media files")
        '
        'Savebtn
        '
        Me.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Savebtn.Image = Global.RAMP.My.Resources.Resources.Save_24px
        Me.Savebtn.Location = New System.Drawing.Point(453, 331)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(112, 36)
        Me.Savebtn.TabIndex = 5
        Me.Savebtn.Text = "Save"
        Me.Savebtn.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Savebtn.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.Savebtn, "Save playlist to file")
        '
        'Clsbtn
        '
        Me.Clsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clsbtn.Image = Global.RAMP.My.Resources.Resources.Close_Window_16px
        Me.Clsbtn.Location = New System.Drawing.Point(842, 331)
        Me.Clsbtn.Name = "Clsbtn"
        Me.Clsbtn.Size = New System.Drawing.Size(112, 36)
        Me.Clsbtn.TabIndex = 6
        Me.Clsbtn.Text = "Close"
        Me.Clsbtn.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Clsbtn.ThemeName = "MaterialPink"
        Me.Tt.SetToolTip(Me.Clsbtn, "Close Playlist window")
        '
        'PLayList
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.Clsbtn)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.lvPl)
        Me.Controls.Add(Me.ClFlbtn)
        Me.Controls.Add(Me.RmvFbtn)
        Me.Controls.Add(Me.AdFolbtn)
        Me.Controls.Add(Me.AddFLbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PLayList"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.Text = "RAMP Player - Playlist"
        Me.ThemeName = "MaterialPink"
        Me.PlsCMS.ResumeLayout(False)
        CType(Me.ClFlbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmvFbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdFolbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddFLbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Savebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clsbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgLst As System.Windows.Forms.ImageList
    Friend WithEvents AddFLbtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents AdFolbtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RmvFbtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents ClFlbtn As Telerik.WinControls.UI.RadButton
    Public WithEvents lvPl As System.Windows.Forms.ListView
    Friend WithEvents PlsCMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFlsToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddFldrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RmvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClarAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenFileLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Savebtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents Clsbtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents Tt As System.Windows.Forms.ToolTip
End Class

