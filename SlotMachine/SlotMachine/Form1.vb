Imports System.Reflection.Emit

Public Class Form1
    Dim dollars As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles spinButton.Click
        If dollars >= 1 Then
            dollars -= 1
            Label1.Text = dollars.ToString("c2")
            ReelControl1.Spin()
            ReelControl2.Spin()
            ReelControl3.Spin()
            r1Label.Text = ReelControl1.itemValue
            r2Label.Text = ReelControl2.itemValue
            r3Label.Text = ReelControl3.itemValue
        End If

        If ReelControl1.itemValue = ReelControl2.itemValue And ReelControl2.itemValue = ReelControl3.itemValue Then
            dollars += 50
            BackColor = Color.Green
        Else
            BackColor = Color.White
        End If
    End Sub

    Private Sub doButton_Click(sender As Object, e As EventArgs) Handles DoButton.Click
        dollars += 1
        Label1.Text = dollars.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r1Label.Text = ReelControl1.itemValue
        r2Label.Text = ReelControl2.itemValue
        r3Label.Text = ReelControl3.itemValue
    End Sub
End Class
