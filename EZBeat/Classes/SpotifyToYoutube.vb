Imports System.Threading
Imports YoutubeExplode.Common

Public Class SpotifyToYoutube
    Public Async Function GetUrl(trackname As String, artist As String) As Task(Of String)
        Dim youtube As New YoutubeExplode.YoutubeClient()
        Dim results = Await youtube.Search.GetVideosAsync(trackname & artist).CollectAsync(1)
        ' Check if a cancellation has been requested

        For Each result In results
            Try
                If TypeOf result Is YoutubeExplode.Search.VideoSearchResult Then
                    Dim track = DirectCast(result, YoutubeExplode.Search.VideoSearchResult)
                    Return track.Url
                End If
            Catch ex As OperationCanceledException
                ' The operation was cancelled. You can handle this case if needed.
                MsgBox(ex.ToString())
                Return Nothing
            Catch ex As Exception
                'Console.WriteLine(ex)
                Return Nothing
            End Try
        Next

        ' If no video was found
        Return Nothing
    End Function

    Public Async Function GetID(trackname As String, artist As String) As Task(Of String)
        Dim youtube As New YoutubeExplode.YoutubeClient()
        Dim results = Await youtube.Search.GetVideosAsync(trackname & artist).CollectAsync(1)
        ' Check if a cancellation has been requested

        For Each result In results
            Try
                If TypeOf result Is YoutubeExplode.Search.VideoSearchResult Then
                    Dim track = DirectCast(result, YoutubeExplode.Search.VideoSearchResult)
                    Return track.Url
                End If
            Catch ex As OperationCanceledException
                ' The operation was cancelled. You can handle this case if needed.
                MsgBox(ex.ToString())
                Return Nothing
            Catch ex As Exception
                'Console.WriteLine(ex)
                Return Nothing
            End Try
        Next

        ' If no video was found
        Return Nothing
    End Function
End Class
