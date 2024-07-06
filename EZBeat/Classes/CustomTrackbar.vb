Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class CustomTrackBar
    Inherits Control

    Private _value As Integer
    Private _maximum As Integer = 100
    Private _minimum As Integer = 0
    Private _thumbColor As Color = Color.FromArgb(29, 185, 84)
    Private _trackColor As Color = Color.FromArgb(66, 68, 75)
    Private _thumbSize As Integer = 15
    Private _filledColor As Color = Color.FromArgb(51, 192, 101)
    Private _hoverPosition As Integer = -1
    Private _hoverColor As Color = Color.FromArgb(78, 80, 89)
    Private _isHovering As Boolean = False
    Private _isDragging As Boolean = False
    Private _dragValue As Integer = 0
    Private _dragPosition As Integer = 0



    Public Sub New()
        Me.DoubleBuffered = True
    End Sub


    Public Property HoverColor As Color
        Get
            Return _hoverColor
        End Get
        Set(value As Color)
            _hoverColor = value
            Invalidate()
        End Set
    End Property



    Public Event Scroll As EventHandler
    Public Event ValueChanged As EventHandler

    Public Property Value As Integer
        Get
            Return _value
        End Get
        Set(value As Integer)
            If _value <> value Then
                _value = Math.Max(_minimum, Math.Min(_maximum, value))
                Invalidate()
                OnValueChanged(EventArgs.Empty)
            End If
        End Set
    End Property


    Public Property Maximum As Integer
        Get
            Return _maximum
        End Get
        Set(value As Integer)
            _maximum = value
            Invalidate()
        End Set
    End Property

    Public Property Minimum As Integer
        Get
            Return _minimum
        End Get
        Set(value As Integer)
            _minimum = value
            Invalidate()
        End Set
    End Property

    Public Property ThumbColor As Color
        Get
            Return _thumbColor
        End Get
        Set(value As Color)
            _thumbColor = value
            Invalidate()
        End Set
    End Property

    Public Property TrackColor As Color
        Get
            Return _trackColor
        End Get
        Set(value As Color)
            _trackColor = value
            Invalidate()
        End Set
    End Property

    Public Property ThumbSize As Integer
        Get
            Return _thumbSize
        End Get
        Set(value As Integer)
            _thumbSize = value
            Invalidate()
        End Set
    End Property

    Public Property FilledColor As Color
        Get
            Return _filledColor
        End Get
        Set(value As Color)
            _filledColor = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            _isDragging = True
            _dragValue = ((e.X - _thumbSize / 2) / (Width - _thumbSize)) * (_maximum - _minimum)
            _dragPosition = e.X
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        _isHovering = True
        _hoverPosition = e.X
        Invalidate()
        If _isDragging Then
            _dragValue = ((e.X - _thumbSize / 2) / (Width - _thumbSize)) * (_maximum - _minimum)
            _dragPosition = e.X
        End If
    End Sub


    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            _isDragging = False
            Value = _dragValue
            OnScroll(EventArgs.Empty)
        End If
    End Sub

    Private Function CreateRoundedRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Return path
    End Function

    Private Function CreateRightRoundedRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        path.AddLine(rect.X, rect.Y, rect.Right - radius, rect.Y)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddLine(rect.Right - radius, rect.Bottom, rect.X, rect.Bottom)
        path.CloseFigure()

        Return path
    End Function



    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim trackWidth As Integer = Width - ThumbSize
        Dim rect As New Rectangle(ThumbSize / 2, (Height - 8) / 2, trackWidth, 8)
        Dim thumbRect As Rectangle
        If _isDragging Then
            thumbRect = New Rectangle(Math.Min(Math.Max(_dragPosition - (ThumbSize / 2), 0), Width - ThumbSize), (Height - ThumbSize) / 2, ThumbSize, ThumbSize)
        Else
            thumbRect = New Rectangle(Math.Min(Math.Max((Value / (_maximum - _minimum) * trackWidth), 0), trackWidth), (Height - ThumbSize) / 2, ThumbSize, ThumbSize)
        End If
        Dim filledRect As New Rectangle(ThumbSize / 2, (Height - 8) / 2, thumbRect.X, 8)
        Dim hoverRect As New Rectangle(thumbRect.Right, (Height - 8) / 2, Math.Min(_hoverPosition - thumbRect.Right, trackWidth - thumbRect.Right + ThumbSize / 2), 8)

        Using b As New SolidBrush(_trackColor)
            Using path As GraphicsPath = CreateRoundedRectangle(rect, 8) ' Change the second parameter to adjust the border radius
                g.FillPath(b, path)
            End Using
        End Using

        Using b As New SolidBrush(FilledColor)
            Using path As GraphicsPath = CreateRoundedRectangle(filledRect, 8) ' Change the second parameter to adjust the border radius
                If Value < 1 Then

                Else
                    g.FillPath(b, path)
                End If

            End Using
        End Using

        If _hoverPosition > thumbRect.Right Then
            Using b As New SolidBrush(HoverColor)
                Using path As GraphicsPath = CreateRightRoundedRectangle(hoverRect, 8) ' Change the second parameter to adjust the border radius
                    g.FillPath(b, path)
                End Using
            End Using
        End If

        If _isHovering Then
            Using b As New SolidBrush(_thumbColor)
                g.FillEllipse(b, thumbRect)
            End Using
        End If
    End Sub



    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _isHovering = False
        _hoverPosition = -1
        Invalidate()
    End Sub

    Protected Overridable Sub OnScroll(e As EventArgs)
        RaiseEvent Scroll(Me, e)
    End Sub

    Protected Overridable Sub OnValueChanged(e As EventArgs)
        RaiseEvent ValueChanged(Me, e)
    End Sub
End Class

