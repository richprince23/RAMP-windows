Imports Microsoft.VisualBasic
Imports System

Public Partial Class RadAboutBox1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.radLabelProductName = New Telerik.WinControls.UI.RadLabel()
        Me.radLabelVersion = New Telerik.WinControls.UI.RadLabel()
        Me.radLabelCopyright = New Telerik.WinControls.UI.RadLabel()
        Me.radLabelCompanyName = New Telerik.WinControls.UI.RadLabel()
        Me.okRadButton = New Telerik.WinControls.UI.RadButton()
        Me.Pnl = New System.Windows.Forms.Panel()
        Me.FacebookLkLbl = New System.Windows.Forms.LinkLabel()
        Me.ShortcutsLkLbl = New System.Windows.Forms.LinkLabel()
        Me.radTextBoxDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.MaterialPinkTheme = New Telerik.WinControls.Themes.MaterialPinkTheme()
        Me.tableLayoutPanel.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelCopyright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.okRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl.SuspendLayout()
        CType(Me.radTextBoxDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel.ColumnCount = 2
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.75904!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.24096!))
        Me.tableLayoutPanel.Controls.Add(Me.logoPictureBox, 0, 0)
        Me.tableLayoutPanel.Controls.Add(Me.radLabelProductName, 1, 0)
        Me.tableLayoutPanel.Controls.Add(Me.radLabelVersion, 1, 1)
        Me.tableLayoutPanel.Controls.Add(Me.radLabelCopyright, 1, 2)
        Me.tableLayoutPanel.Controls.Add(Me.radLabelCompanyName, 1, 3)
        Me.tableLayoutPanel.Controls.Add(Me.okRadButton, 1, 5)
        Me.tableLayoutPanel.Controls.Add(Me.Pnl, 1, 4)
        Me.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 6
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.Size = New System.Drawing.Size(498, 344)
        Me.tableLayoutPanel.TabIndex = 0
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logoPictureBox.Image = Global.RAMP.My.Resources.Resources.International_Music_100px
        Me.logoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.tableLayoutPanel.SetRowSpan(Me.logoPictureBox, 6)
        Me.logoPictureBox.Size = New System.Drawing.Size(192, 338)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoPictureBox.TabIndex = 12
        Me.logoPictureBox.TabStop = False
        '
        'radLabelProductName
        '
        Me.radLabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radLabelProductName.Location = New System.Drawing.Point(204, 0)
        Me.radLabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.radLabelProductName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.radLabelProductName.Name = "radLabelProductName"
        '
        '
        '
        Me.radLabelProductName.RootElement.MaxSize = New System.Drawing.Size(0, 17)
        Me.radLabelProductName.Size = New System.Drawing.Size(100, 17)
        Me.radLabelProductName.TabIndex = 0
        Me.radLabelProductName.Text = "Product Name"
        Me.radLabelProductName.ThemeName = "MaterialPink"
        '
        'radLabelVersion
        '
        Me.radLabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radLabelVersion.Location = New System.Drawing.Point(204, 34)
        Me.radLabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.radLabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.radLabelVersion.Name = "radLabelVersion"
        '
        '
        '
        Me.radLabelVersion.RootElement.MaxSize = New System.Drawing.Size(0, 17)
        Me.radLabelVersion.Size = New System.Drawing.Size(57, 17)
        Me.radLabelVersion.TabIndex = 1
        Me.radLabelVersion.Text = "Version"
        Me.radLabelVersion.ThemeName = "MaterialPink"
        '
        'radLabelCopyright
        '
        Me.radLabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radLabelCopyright.Location = New System.Drawing.Point(204, 68)
        Me.radLabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.radLabelCopyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.radLabelCopyright.Name = "radLabelCopyright"
        '
        '
        '
        Me.radLabelCopyright.RootElement.MaxSize = New System.Drawing.Size(0, 17)
        Me.radLabelCopyright.Size = New System.Drawing.Size(70, 17)
        Me.radLabelCopyright.TabIndex = 2
        Me.radLabelCopyright.Text = "Copyright"
        Me.radLabelCopyright.ThemeName = "MaterialPink"
        '
        'radLabelCompanyName
        '
        Me.radLabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radLabelCompanyName.Location = New System.Drawing.Point(204, 102)
        Me.radLabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.radLabelCompanyName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.radLabelCompanyName.Name = "radLabelCompanyName"
        '
        '
        '
        Me.radLabelCompanyName.RootElement.MaxSize = New System.Drawing.Size(0, 17)
        Me.radLabelCompanyName.Size = New System.Drawing.Size(110, 17)
        Me.radLabelCompanyName.TabIndex = 3
        Me.radLabelCompanyName.Text = "Company Name"
        Me.radLabelCompanyName.ThemeName = "MaterialPink"
        '
        'okRadButton
        '
        Me.okRadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.okRadButton.Location = New System.Drawing.Point(420, 311)
        Me.okRadButton.Name = "okRadButton"
        Me.okRadButton.Size = New System.Drawing.Size(75, 30)
        Me.okRadButton.TabIndex = 5
        Me.okRadButton.Text = "&OK"
        Me.okRadButton.ThemeName = "MaterialPink"
        '
        'Pnl
        '
        Me.Pnl.Controls.Add(Me.FacebookLkLbl)
        Me.Pnl.Controls.Add(Me.ShortcutsLkLbl)
        Me.Pnl.Controls.Add(Me.radTextBoxDescription)
        Me.Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl.Location = New System.Drawing.Point(201, 139)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(294, 166)
        Me.Pnl.TabIndex = 4
        '
        'FacebookLkLbl
        '
        Me.FacebookLkLbl.AutoSize = True
        Me.FacebookLkLbl.Location = New System.Drawing.Point(74, 146)
        Me.FacebookLkLbl.Name = "FacebookLkLbl"
        Me.FacebookLkLbl.Size = New System.Drawing.Size(69, 17)
        Me.FacebookLkLbl.TabIndex = 2
        Me.FacebookLkLbl.TabStop = True
        Me.FacebookLkLbl.Text = "Facebook"
        '
        'ShortcutsLkLbl
        '
        Me.ShortcutsLkLbl.AutoSize = True
        Me.ShortcutsLkLbl.Location = New System.Drawing.Point(0, 146)
        Me.ShortcutsLkLbl.Name = "ShortcutsLkLbl"
        Me.ShortcutsLkLbl.Size = New System.Drawing.Size(69, 17)
        Me.ShortcutsLkLbl.TabIndex = 1
        Me.ShortcutsLkLbl.TabStop = True
        Me.ShortcutsLkLbl.Text = "Shortcuts"
        '
        'radTextBoxDescription
        '
        Me.radTextBoxDescription.AutoSize = False
        Me.radTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.radTextBoxDescription.Location = New System.Drawing.Point(0, 0)
        Me.radTextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.radTextBoxDescription.Multiline = True
        Me.radTextBoxDescription.Name = "radTextBoxDescription"
        Me.radTextBoxDescription.ReadOnly = True
        Me.radTextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.radTextBoxDescription.Size = New System.Drawing.Size(294, 140)
        Me.radTextBoxDescription.TabIndex = 0
        Me.radTextBoxDescription.TabStop = False
        Me.radTextBoxDescription.Text = "Description"
        Me.radTextBoxDescription.ThemeName = "MaterialPink"
        '
        'RadAboutBox1
        '
        Me.AcceptButton = Me.okRadButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 362)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RadAboutBox1"
        Me.Padding = New System.Windows.Forms.Padding(9)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About RAMP Player"
        Me.ThemeName = "MaterialPink"
        Me.tableLayoutPanel.ResumeLayout(False)
        Me.tableLayoutPanel.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelCopyright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.okRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl.ResumeLayout(False)
        Me.Pnl.PerformLayout()
        CType(Me.radTextBoxDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    #End Region

    Private tableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Private logoPictureBox As System.Windows.Forms.PictureBox
    Private radLabelProductName As Telerik.WinControls.UI.RadLabel
    Private radLabelVersion As Telerik.WinControls.UI.RadLabel
    Private radLabelCopyright As Telerik.WinControls.UI.RadLabel
    Private radLabelCompanyName As Telerik.WinControls.UI.RadLabel
    Private WithEvents okRadButton As Telerik.WinControls.UI.RadButton
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Private WithEvents radTextBoxDescription As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ShortcutsLkLbl As System.Windows.Forms.LinkLabel
    Friend WithEvents FacebookLkLbl As System.Windows.Forms.LinkLabel
    Friend WithEvents MaterialPinkTheme As Telerik.WinControls.Themes.MaterialPinkTheme
End Class
