﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ClickerControl
    Dim C As New Clicker
    Public Property Increment As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C.Increment = Increment
        C.Click()
        TextBox1.Text = C.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        C.reset()
        TextBox1.Text = C.count
    End Sub
End Class
