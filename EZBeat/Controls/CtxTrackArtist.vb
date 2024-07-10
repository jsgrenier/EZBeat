Public Class CtxTrackArtist
    Public Event TrackClicked As EventHandler
    Public Event ArtistClicked As EventHandler

    Private Sub Guna2Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Button1.MouseDown
        RaiseEvent TrackClicked(Me, e)
    End Sub

    Private Sub Guna2Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2Button3.MouseDown
        RaiseEvent ArtistClicked(Me, e)
    End Sub
End Class
