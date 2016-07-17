Imports System.IO

Public Class Form1
    Dim BVotes As Integer = 0
    Dim FVotes As Integer = 0
    Dim EVotes As Integer = 0
    Dim PVotes As Integer = 0
    Dim path As String = Application.StartupPath + "\Votes.txt"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub CommercialListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CommercialListBox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        File.WriteAllText(path, "")
        Dim f As StreamWriter
        f = My.Computer.FileSystem.OpenTextFileWriter(path, True)

        If Me.CommercialListBox.GetSelected(0) Then
            BVotes = BVotes + 1
        ElseIf Me.CommercialListBox.GetSelected(1) Then
            FVotes = FVotes + 1
        ElseIf Me.CommercialListBox.GetSelected(2) Then
            EVotes = EVotes + 1
        ElseIf Me.CommercialListBox.GetSelected(3) Then
            PVotes = PVotes + 1
        End If

        f.WriteLine("Bvotes " + BVotes.ToString())
        f.WriteLine("Fvotes " + FVotes.ToString())
        f.WriteLine("Evotes " + EVotes.ToString())
        f.WriteLine("Pvotes " + PVotes.ToString())
        f.Close()
        Form2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As StreamReader = New StreamReader(path)
        Dim line As String
        While r.Peek <> -1
            line = r.ReadLine()
            If line.Contains("Bvotes") Then
                TextBox1.Text = line.Substring(7).ToString()
            ElseIf line.Contains("Fvotes") Then
                TextBox2.Text = line.Substring(7).ToString()
            ElseIf line.Contains("Evotes") Then
                TextBox3.Text = line.Substring(7).ToString()
            ElseIf line.Contains("Pvotes") Then
                TextBox4.Text = line.Substring(7).ToString()
            End If
        End While
        r.Close()
    End Sub
End Class
