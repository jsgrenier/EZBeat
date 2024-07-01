Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class VolumeTrackbar
    Inherits Control

    Private _value As Integer
    Private _maximum As Integer = 100
    Private _minimum As Integer = 0
    Private _thumbColor As Color = Color.Red
    Private _trackColor As Color = Color.FromArgb(195, 196, 196)
    Private _thumbSize As Integer = 15
    Private _filledColor As Color = Color.Red
    Private _hoverPosition As Integer = -1
    Private _hoverColor As Color = Color.Blue
    Private _isHovering As Boolean = False
    Private _isDragging As Boolean = False
    Private _dragValue As Integer = 0
    Private _dragPosition As Integer = 0



    Public Sub New()
        Me.DoubleBuffered = True
    End Sub


    <Browsable(True), DefaultValue(GetType(Color), "Blue")>
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

    <Browsable(True), DefaultValue(15)>
    Public Property ThumbSize As Integer
        Get
            Return _thumbSize
        End Get
        Set(value As Integer)
            _thumbSize = value
            Invalidate()
        End Set
    End Property

    <Browsable(True), DefaultValue(GetType(Color), "Red")>
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
            _dragValue = (e.X / (Width - 1)) * (_maximum - _minimum)
            _dragPosition = e.X
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        _isHovering = True
        _hoverPosition = e.X
        Invalidate()
        If _isDragging Then
            _dragValue = (e.X / (Width - 1)) * (_maximum - _minimum)
            _dragPosition = e.X
            Value = _dragValue ' Set the Value here
        End If
    End Sub


    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            _isDragging = False
            OnScroll(EventArgs.Empty)
        End If
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim trackWidth As Integer = Width - ThumbSize
        Dim rect As New Rectangle(ThumbSize / 2, Height / 2 - 2, trackWidth, 4)
        Dim thumbRect As Rectangle
        If _isDragging Then
            thumbRect = New Rectangle(_dragPosition - (ThumbSize / 2), Height / 2 - ThumbSize / 2, ThumbSize, ThumbSize)
        Else
            thumbRect = New Rectangle((Value / (_maximum - _minimum) * trackWidth) + (ThumbSize / 2) - (ThumbSize / 2), Height / 2 - ThumbSize / 2, ThumbSize, ThumbSize)
        End If
        Dim filledRect As New Rectangle(ThumbSize / 2, Height / 2 - 2, thumbRect.X, 4)
        Dim hoverRect As New Rectangle(thumbRect.Right, Height / 2 - 2, _hoverPosition - thumbRect.Right, 4)

        Using b As New SolidBrush(_trackColor)
            g.FillRectangle(b, rect)
        End Using

        Using b As New SolidBrush(FilledColor)
            g.FillRectangle(b, filledRect)
        End Using

        If _hoverPosition > thumbRect.Right Then
            Using b As New SolidBrush(HoverColor)
                g.FillRectangle(b, hoverRect)
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

