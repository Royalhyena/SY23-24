Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2DPlatformer
    Dim movespeed As Integer = 15
    Dim isjumping As Boolean
    Dim p As Integer
    Private Sub Form2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
            Case Keys.Up
                TmrUp.Start()
                isjumping = True
            Case Keys.Left
                TmrLeft.Start()

        End Select
    End Sub

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        PBPlayer.Left += 10
    End Sub

    Private Sub Form2DPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Stop()
            Case Keys.Up
                TmrUp.Stop()
                isjumping = False
            Case Keys.Left
                TmrLeft.Stop()
        End Select
    End Sub

    Private Sub TmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        PBPlayer.Left -= 10
    End Sub

    Private Sub TmrUp_Tick(sender As Object, e As EventArgs) Handles TmrUp.Tick
        PBPlayer.Top -= 10
    End Sub

    Private Sub TmrGameLogic_Tick(sender As Object, e As EventArgs) Handles TmrGameLogic.Tick
        TextBox1.Text = p
        If PBPlayer.Bounds.IntersectsWith(PBGround.Bounds) Then
            TmrGravity.Stop()
        Else
            If isjumping = False Then
                TmrGravity.Start()
            End If
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Bound" Then
                    If PBPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        TmrGravity.Stop()
                    End If
                End If
            End If
            If b.Tag = "Restart" Then
                If PBPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    PBPlayer.Location = New Point(50, 300)
                    p = p + 1
                End If
            End If
            If b.Tag = "Collectable" Then
                If b.Visible And PBPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    p = p - 1
                End If
            End If

            If b.Tag = "Win" Then
                If PBPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    PBAir.BackColor = Color.Yellow
                End If
            End If

        Next

    End Sub

    Private Sub Form2DPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrGameLogic.Start()
        p = -15

    End Sub

    Private Sub TmrGravity_Tick(sender As Object, e As EventArgs) Handles TmrGravity.Tick
        PBPlayer.Top += movespeed

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub



    'The next time this is opened im going to delete everything  :(
    'You wouldn't dare!!!! ):
End Class
