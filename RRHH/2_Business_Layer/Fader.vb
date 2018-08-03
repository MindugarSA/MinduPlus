Imports System.Windows.Forms
Imports System.Threading

Class Fader
    Public Delegate Sub FadeCompleted()
    Private form As Form
    Private parent As IWin32Window
    Private _fadeDirection As FadeDirection
    Private _fadeSpeed As Single
    Private fadeFinished As FadeCompleted
    Private shouldClose As Boolean
    Private dialogResult As DialogResult

    Private Enum FadeDirection
        [In]
        Out
    End Enum

    Public Class FadeSpeed
        Public Shared ReadOnly Slowest As Single = 1
        Public Shared ReadOnly Slower As Single = 10
        Public Shared ReadOnly Slow As Single = 25
        Public Shared ReadOnly Normal As Single = 50
        Public Shared ReadOnly Fast As Single = 60
        Public Shared ReadOnly Faster As Single = 75
        Public Shared ReadOnly Fastest As Single = 100
    End Class

    Private Sub New(ByVal form As Form)
        Me.form = form
    End Sub

    Private Sub New(ByVal form As Form, ByVal parent As IWin32Window)
        Me.New(form)
        Me.parent = parent
    End Sub

    Private Function beginFade() As DialogResult
        While updateOpacity()
            Application.DoEvents()
            Thread.Sleep(10)
        End While

        fadeFinished?.Invoke()
        Return dialogResult
    End Function

    Private Function updateOpacity() As Boolean
        If form.IsDisposed Then Return False

        Select Case _fadeDirection
            Case FadeDirection.[In]

                If form.Opacity < 1.0 Then
                    form.Opacity += (_fadeSpeed / 1000.0)
                Else
                    Return False
                End If

            Case FadeDirection.Out

                If form.Opacity > 0.1 Then
                    form.Opacity -= (_fadeSpeed / 1000.0)
                Else

                    If Not shouldClose Then
                        form.Hide()
                    Else
                        form.Close()
                    End If

                    Return False
                End If
        End Select

        Return True
    End Function

    Private Function showDialog(ByVal fadeSpeed As Single, ByVal finished As FadeCompleted) As DialogResult
        dialogResult = form.ShowDialog(parent)
        fadeFinished = finished
        form.Opacity = 0
        Me._fadeSpeed = fadeSpeed
        _fadeDirection = FadeDirection.[In]
        Return beginFade()
    End Function

    Private Sub fadeIn(ByVal fadeSpeed As Single, ByVal finished As FadeCompleted)
        form.Opacity = 0
        form.Show()
        fadeFinished = finished
        Me._fadeSpeed = fadeSpeed
        _fadeDirection = FadeDirection.[In]
        beginFade()
    End Sub

    Private Sub fadeOut(ByVal fadeSpeed As Single, ByVal finished As FadeCompleted)
        If form.Opacity < 0.1 Then
            finished?.Invoke()
            Return
        End If

        fadeFinished = finished
        form.Opacity = 100
        Me._fadeSpeed = fadeSpeed
        _fadeDirection = FadeDirection.Out
        beginFade()
    End Sub

    Public Shared Function ShowDialog(ByVal form As Form, ByVal parent As Form, ByVal fadeSpeed As Single) As DialogResult
        Dim fader As Fader = New Fader(form, parent)
        Return fader.showDialog(fadeSpeed, Nothing)
    End Function

    Public Shared Function ShowDialog(ByVal form As Form, ByVal parent As Form, ByVal fadeSpeed As Single, ByVal finished As FadeCompleted) As DialogResult
        Dim fader As Fader = New Fader(form, parent)
        Return fader.showDialog(fadeSpeed, finished)
    End Function

    Public Shared Sub FadeIn(ByVal form As Form, ByVal fadeSpeed As Single, ByVal finished As FadeCompleted)
        Dim fader As Fader = New Fader(form)
        fader.fadeIn(fadeSpeed, finished)
    End Sub

    Public Shared Sub FadeOut(ByVal form As Form, ByVal fadeSpeed As Single, ByVal finished As FadeCompleted)
        Dim fader As Fader = New Fader(form)
        fader.fadeOut(fadeSpeed, finished)
    End Sub

    Public Shared Sub FadeIn(ByVal form As Form, ByVal fadeSpeed As Single)
        Dim fader As Fader = New Fader(form)
        fader.fadeIn(fadeSpeed, Nothing)
    End Sub

    Public Shared Sub FadeOut(ByVal form As Form, ByVal fadeSpeed As Single)
        Dim fader As Fader = New Fader(form)
        fader.fadeOut(fadeSpeed, Nothing)
    End Sub

    Public Shared Sub FadeOutAndClose(ByVal form As Form, ByVal fadeSpeed As Single)
        Dim fader As Fader = New Fader(form)
        fader.shouldClose = True
        fader.fadeOut(fadeSpeed, Nothing)
    End Sub

    Public Shared Sub FadeOutAndClose(ByVal form As Form, ByVal fadeSpeed As Single, ByVal finished As FadeCompleted)
        Dim fader As Fader = New Fader(form)
        fader.shouldClose = True
        fader.fadeOut(fadeSpeed, finished)
    End Sub
End Class
