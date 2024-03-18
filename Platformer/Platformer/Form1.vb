Imports System.Reflection.Emit

Public Class Form2Dplat
    Dim movespeed As Integer = 5
    Dim isjumping As Boolean
    Dim Coin As Integer
    Private Sub Form2dPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.D
                TmrRight.Start()
            Case Keys.A
                TmrLeft.Start()
            Case Keys.W
                TmrUp.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub TMRD_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        PicPlayer.Left += movespeed
    End Sub

    Private Sub Form2dPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.D
                TmrRight.Stop()
            Case Keys.A
                TmrLeft.Stop()
            Case Keys.W
                TmrUp.Stop()
                isjumping = False
        End Select
    End Sub


    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
            PicPlayer.Left -= moveSpeed
        End Sub

        Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
            PicPlayer.Top -= moveSpeed
        End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
            If PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
                TmrGravity.Stop()
            Else
                If isJumping = False Then
                    TmrGravity.Start()
                End If
            End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Bounds" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        TmrGravity.Stop()
                    End If
                End If
            End If
            If b.Tag = "Reset" Then
                If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    PicPlayer.Location = New Point(25, 951)
                End If
            End If
            If b.Tag = "Win" Then
                If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    Label1.Text = "You Win!"
                End If
            End If
            If b.Tag = "Coin" Then
                If b.Visible = True And PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    Label2.Text = Coin
                    Coin += 1
                End If
            End If
        Next




    End Sub

        Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
            PicPlayer.Top += moveSpeed
        End Sub
End Class