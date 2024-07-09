Public Class TrackCtxMenu
    Public Event PlayClicked As EventHandler
    Public Event DLClicked As EventHandler

    Private Sub Guna2Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Button1.MouseDown
        RaiseEvent PlayClicked(Me, e)
    End Sub

    Private Sub Guna2Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Button3.MouseDown
        RaiseEvent DLClicked(Me, e)
    End Sub
End Class
