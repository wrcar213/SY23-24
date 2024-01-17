
Imports System.IO
Imports System.Net.WebRequestMethods

Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        F1.Text = ""
        F2.Text = ""
        F3.Text = ""
        F4.Text = ""
        F5.Text = ""
        F6.Text = ""
        F7.Text = ""
        F8.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outfile As New IO.StreamWriter("data.txt")
        outfile.Write(F1.Text)
        outfile.Write("|")
        outfile.Write(F2.Text)
        outfile.Write("|")
        outfile.Write(F3.Text)
        outfile.Write("|")
        outfile.Write(F4.Text)
        outfile.Write("|")
        outfile.Write(F5.Text)
        outfile.Write("|")
        outfile.Write(F6.Text)
        outfile.Write("|")
        outfile.Write(F7.Text)
        outfile.Write("|")
        outfile.Write(F8.Text)
        outfile.Write("|")
        outfile.WriteLine(PictureBox1.Location)
        outfile.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            While (Not inFile.EndOfStream)
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            Showrecord(0)
        End If
    End Sub
    Public Sub Showrecord(Index As Integer)
        Dim fields() As String
        If records(Index) <> Nothing Then
            fields = records(Index).Split("|")
            F1.Text = fields(0)
            F2.Text = fields(1)
            F3.Text = fields(2)
            F4.Text = fields(3)
            F5.Text = fields(4)
            F6.Text = fields(5)
            F7.Text = fields(6)
            F8.Text = fields(7)
            If IO.File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If

    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        current = 0
        Showrecord(0)
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        current = count - 1
        Showrecord(current)
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If current > 0 Then
            current = current - 1
            Showrecord(current)
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If current < count - 1 Then
            current = current + 1
            Showrecord(current)
        End If
    End Sub
End Class