﻿Imports System.IO

Public Class Form1
    Dim records(50) As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
        Field6.Text = ""
        Field7.Text = ""
        Field8.Text = ""
        PictureBox1.Image = Nothing

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("Data.txt")
        outFile.Write(Field1.Text)
        outFile.Write("|")
        outFile.Write(Field2.Text)
        outFile.Write("|")
        outFile.Write(Field3.Text)
        outFile.Write("|")
        outFile.Write(Field4.Text)
        outFile.Write("|")
        outFile.Write(Field5.Text)
        outFile.Write("|")
        outFile.Write(Field6.Text)
        outFile.Write("|")
        outFile.Write(Field7.Text)
        outFile.Write("|")
        outFile.Write(Field8.Text)
        outFile.Write("|")
        outFile.WriteLine(PictureBox1.ImageLocation)
        outFile.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            records(0) = inFile.ReadLine
            inFile.Close()
            showrecord(0)
        End If
    End Sub
    Public Sub showrecord(index As Integer)
        Dim Fields() As String
        Fields = records(index).Split("|")
        Field1.Text = Fields(0)
        Field2.Text = Fields(1)
        Field3.Text = Fields(2)
        Field4.Text = Fields(3)
        Field5.Text = Fields(4)
        Field6.Text = Fields(5)
        Field7.Text = Fields(6)
        Field8.Text = Fields(7)
        If File.Exists(Fields(5)) Then
            PictureBox1.Load(Fields(5))
        End If

    End Sub
End Class