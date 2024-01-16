
Imports System.IO
Public Class Form1
    Dim records(50) As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outfile As New IO.StreamWriter("data.txt")
        outfile.Write(Field1.Text)
        outfile.Write("|")
        outfile.Write(Field2.Text)
        outfile.Write("|")
        outfile.Write(Field3.Text)
        outfile.Write("|")
        outfile.Write(Field4.Text)
        outfile.Write("|")
        outfile.Write(Field5.Text)
        outfile.Write("|")
        outfile.WriteLine(PictureBox1.ImageLocation)
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
            Dim idx As Integer = 0
            While (Not inFile.EndOfStream)
                records(idx) = inFile.ReadLine
                idx = idx + 1
            End While
            inFile.Close()
            Showrecord(0)
        End If
    End Sub
    Public Sub Showrecord(Index As Integer)
        Dim fields() As String
        fields = records(Index).Split("|")
        Field1.Text = fields(0)
        Field2.Text = fields(1)
        Field3.Text = fields(2)
        Field4.Text = fields(3)
        Field5.Text = fields(4)
        Field6.Text = fields(5)
        Field7.Text = fields(6)
        Field8.Text = fields(7)
        If File.Exists(fields(5)) Then
            PictureBox1.Load(fields(5))
        End If

    End Sub
End Class