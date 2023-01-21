<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.Pbx = New System.Windows.Forms.PictureBox()
        Me.RAMPPLAYERLbl = New System.Windows.Forms.Label()
        Me.LoadingLbl = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        CType(Me.Pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pbx
        '
        Me.Pbx.BackColor = System.Drawing.Color.Transparent
        Me.Pbx.BackgroundImage = Global.RAMP.My.Resources.Resources.International_Music_100px
        Me.Pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pbx.Location = New System.Drawing.Point(36, 47)
        Me.Pbx.Name = "Pbx"
        Me.Pbx.Size = New System.Drawing.Size(250, 229)
        Me.Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pbx.TabIndex = 0
        Me.Pbx.TabStop = False
        '
        'RAMPPLAYERLbl
        '
        Me.RAMPPLAYERLbl.AutoSize = True
        Me.RAMPPLAYERLbl.BackColor = System.Drawing.Color.DarkBlue
        Me.RAMPPLAYERLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAMPPLAYERLbl.ForeColor = System.Drawing.Color.Yellow
        Me.RAMPPLAYERLbl.Location = New System.Drawing.Point(70, 9)
        Me.RAMPPLAYERLbl.Name = "RAMPPLAYERLbl"
        Me.RAMPPLAYERLbl.Size = New System.Drawing.Size(182, 26)
        Me.RAMPPLAYERLbl.TabIndex = 0
        Me.RAMPPLAYERLbl.Text = "RAMP PLAYER"
        '
        'LoadingLbl
        '
        Me.LoadingLbl.AutoSize = True
        Me.LoadingLbl.BackColor = System.Drawing.Color.DarkBlue
        Me.LoadingLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingLbl.ForeColor = System.Drawing.Color.Yellow
        Me.LoadingLbl.Location = New System.Drawing.Point(124, 279)
        Me.LoadingLbl.Name = "LoadingLbl"
        Me.LoadingLbl.Size = New System.Drawing.Size(86, 17)
        Me.LoadingLbl.TabIndex = 1
        Me.LoadingLbl.Text = "Loading ..."
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(106, 297)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(110, 17)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.TabIndex = 2
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(323, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.LoadingLbl)
        Me.Controls.Add(Me.RAMPPLAYERLbl)
        Me.Controls.Add(Me.Pbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.DarkBlue
        CType(Me.Pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pbx As System.Windows.Forms.PictureBox
    Friend WithEvents RAMPPLAYERLbl As System.Windows.Forms.Label
    Friend WithEvents LoadingLbl As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
End Class
