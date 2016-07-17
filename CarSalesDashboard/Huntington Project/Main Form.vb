'Author:    Ranjeet Kumar, Jana
'Date:      April 17, 2016
'Project:   Huntington Solution- Week 13

Public Class Form1
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Me.Close()
    End Sub

    Dim Fulltime As Integer = 0
    Dim parttime As Integer = 0
    Dim newcars As Integer = 0
    Dim usedcars As Integer = 0
    Dim numbersold As Integer = 0
    Dim empId As String = ""

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        empId = Me.TB1.Text.ToString()
        If TB2.Text = "" Then
            numbersold = 0
        Else : numbersold = Me.TB2.Text
        End If
        If empId.Substring(0, 1) <> "1" And empId.Substring(0, 1) <> "2" Then
            Form2.Label1.Text = "The ID Must begin with the Number 1 or 2"
            Form2.Show()
        ElseIf empId.Substring(3).ToUpper() <> "F" And empId.Substring(3).ToUpper() <> "P" Then
            Form2.Label1.Text = "The ID Must end with the letter P or F"
            Form2.Show()
        Else
            If empId.Substring(0, 1) = 1 Then
                newcars = newcars + numbersold
            Else : usedcars = usedcars + numbersold
            End If
            If empId.Substring(3).ToUpper() = "F" Then
                Fulltime = Fulltime + numbersold
            Else
                parttime = parttime + numbersold
            End If
        End If
        Tb3.Text = Fulltime.ToString()
        Tb4.Text = parttime.ToString()
        Tb5.Text = newcars.ToString()
        Tb6.Text = usedcars.ToString()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        MessageBox.Show("No Code Written")
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        MessageBox.Show("No Code Written")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("No Code Written")
    End Sub

    Private Sub VisualStudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualStudioToolStripMenuItem.Click
        MessageBox.Show("No Code Written")
    End Sub
End Class
