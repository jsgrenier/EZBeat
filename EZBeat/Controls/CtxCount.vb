Public Class CtxCount
    Public Event Btn20Clicked As EventHandler
    Public Event Btn40Clicked As EventHandler
    Public Event Btn60Clicked As EventHandler
    Public Event Btn80Clicked As EventHandler
    Public Event Btn100Clicked As EventHandler

    Private Sub Btn20_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn20.MouseDown
        RaiseEvent Btn20Clicked(Me, e)
    End Sub
    Private Sub Btn40_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn40.MouseDown
        RaiseEvent Btn40Clicked(Me, e)
    End Sub
    Private Sub Btn60_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn60.MouseDown
        RaiseEvent Btn60Clicked(Me, e)
    End Sub
    Private Sub Btn80_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn80.MouseDown
        RaiseEvent Btn80Clicked(Me, e)
    End Sub
    Private Sub Btn100_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn100.MouseDown
        RaiseEvent Btn100Clicked(Me, e)
    End Sub
End Class
