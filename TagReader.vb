Public Class TagReader
    Dim drag As Boolean
    Dim mx As Integer
    Dim msy As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Tag_Reader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

    End Sub
    Private Sub tagreader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mx = Cursor.Position.X - Me.Left
        msy = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub tagreader_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - msy
            Me.Left = Cursor.Position.X - mx

        End If
    End Sub

    Private Sub tagreader_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False

    End Sub
End Class
