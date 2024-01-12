﻿Imports System.IO

Public Class Form1
    Dim records(50) As String
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outfile As New IO.StreamWriter("Data.txt")
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

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Data.txt") Then
            Dim inFile As New IO.StreamReader("Data.txt")
            records(0) = inFile.ReadLine
            records(1) = inFile.ReadLine
            inFile.Close()
        End If
    End Sub
End Class
