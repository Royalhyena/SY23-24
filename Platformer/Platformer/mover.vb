Imports System.Runtime.CompilerServices

Public Class mover
    Public Property speed As Integer = 10
    Public Property interval As Integer = 500
    Public Property sprite As PictureBox
    Dim xder As Integer = 1
    Dim yder As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not sprite Is Nothing Then
            sprite.Left += xder * speed
            sprite.Top += yder * speed
            If sprite.Left > Me.Left + Me.Width And xder = 1 Then
                xder = 0
                yder = 1
            End If
            If sprite.Left < Me.Left And xder = -1 Then
                xder = 0
                yder = -1
            End If
            If sprite.Top > Me.Top + Me.Height And yder = 1 Then
                yder = 0
                xder = -1
            End If
            If sprite.Top < Me.Top And yder = -1 Then
                yder = 0
                xder = 1
            End If
        End If
    End Sub

    Private Sub mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = interval
        If Not sprite Is Nothing Then
            sprite.Left += Me.Left
            sprite.Top += Me.Top
        End If
    End Sub
End Class
