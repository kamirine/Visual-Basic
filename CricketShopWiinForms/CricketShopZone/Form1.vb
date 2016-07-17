
Public Class Form1
    Dim ErrorCount As Integer
    Dim itemName As String = 8
    Dim itemPrice As String = 2
    Public strArray(itemName, itemPrice) As String

    Private Sub ItemList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemList.SelectedIndexChanged
        ItemList.Focus()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        'Creating Directory and text file 

        IO.Directory.CreateDirectory("C:\ShoppingFile")
        Dim w As New IO.StreamWriter("C:\ShoppingFile\ItemList.txt")
        '2-D array containing Item and their price
        strArray(0, 0) = "Cricket Ball"
        strArray(0, 1) = 800
        strArray(1, 0) = "Cricket Bat"
        strArray(1, 1) = 1120
        strArray(2, 0) = "Batting Gloves"
        strArray(2, 1) = 460
        strArray(3, 0) = "Batting Pads"
        strArray(3, 1) = 938
        strArray(4, 0) = "Cricket Helmet"
        strArray(4, 1) = 632
        strArray(5, 0) = "Cricket Shoes"
        strArray(5, 1) = 1199
        strArray(6, 0) = "Cricket Bags"
        strArray(6, 1) = 576
        strArray(7, 0) = "Aero Strippers"
        strArray(7, 1) = 934
        'Puting Item with  their price in Shopping List
        For i = 0 To 7
            If ItemList.Text = strArray(i, 0) Then
                ItemShop.Text = strArray(i, 0) & "  =  $" & strArray(i, 1) & Environment.NewLine & ItemShop.Text
            End If
        Next
        ItemList.Focus()
        'Writing Shopping List in Text File
        For i = 0 To 7
            If ItemList.Text = strArray(i, 0) Then
                w.WriteLine(ItemShop.Text)
                w.Close()
                Exit For
            End If
        Next
        ItemList.SetSelected(0, False)
        'w.WriteLine(ItemShop.Text)
        'w.WriteLine(strArray(1, 1))
        'w.WriteLine(ItemShop.Text)
        'w.WriteLine(strArray(2, 1))
        'w.WriteLine(ItemShop.Text)
        'w.WriteLine(strArray(3, 1))
        'w.WriteLine(ItemShop.Text)
        'w.WriteLine(strArray(4, 1))
        'w.WriteLine(ItemShop.Text)
        'w.WriteLine(strArray(5, 1))
        'w.WriteLine(ItemShop.Text)
        'w.WriteLine(strArray(6, 1))
        'w.WriteLine(ItemShop.Text)
        'w.WriteLine(strArray(7, 1))
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtPrice.Text = ""
        strArray(0, 0) = "Cricket Ball"
        strArray(0, 1) = 800
        strArray(1, 0) = "Cricket Bat"
        strArray(1, 1) = 1120
        strArray(2, 0) = "Batting Gloves"
        strArray(2, 1) = 460
        strArray(3, 0) = "Batting Pads"
        strArray(3, 1) = 938
        strArray(4, 0) = "Cricket Helmet"
        strArray(4, 1) = 632
        strArray(5, 0) = "Cricket Shoes"
        strArray(5, 1) = 1199
        strArray(6, 0) = "Cricket Bags"
        strArray(6, 1) = 576
        strArray(7, 0) = "Aero Strippers"
        strArray(7, 1) = 934
        'search item in array for the price
        For i As Integer = 0 To itemName - 1 Step 1
            If txtSrch.Text.ToLower() = strArray(i, 0).ToLower() Then
                txtPrice.Text = strArray(i, 1)
                Exit For

            End If
        Next
        If txtPrice.Text = "" Then
            MsgBox("Sorry ! This item is not 'FOUND' in sale item List ")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicBox.Enabled = False
        lblName.Enabled = True
        ItemList.Enabled = False
        lblItemList.Enabled = False
        lblSearch.Enabled = False
        lblPrice.Enabled = False
        btnSearch.Enabled = False
        lblShpCrt.Enabled = False
        ItemShop.Enabled = False
        btnAddItem.Enabled = False
        btnChckout.Enabled = False
        lblTotal.Enabled = False
        txtTotal.Enabled = False
        txtSrch.Enabled = False
        txtPrice.Enabled = False
    End Sub

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        txtPassword.TextBox.UseSystemPasswordChar = True
        'Checks to see if the value entered in the textbox field is the according to Validations
        Dim numberExists1 As Boolean, numberExists2 As Boolean, numberExists3 As Boolean, alphabetExists1 As Boolean, alphabetExists2 As Boolean, alphabetExists3 As Boolean
        Dim Temp As Object, i As Integer
        numberExists1 = False
        numberExists2 = False
        numberExists3 = False
        alphabetExists1 = False
        alphabetExists2 = False
        alphabetExists3 = False

        For i = 1 To Len(txtPassword.Text)
            Temp = Mid(txtPassword.Text, i, 1)
            If alphabetExists1 = False Then
                If InStr("ABCD", Temp) > 0 Then
                    alphabetExists1 = True
                Else
                    alphabetExists1 = False
                End If
            End If

            If numberExists1 = False Then
                If InStr("1234567890", Temp) > 0 Then
                    numberExists1 = True
                Else
                    numberExists1 = False
                End If
            End If

            If numberExists2 = False Then
                If InStr("1234567890", Temp) > 0 Then
                    numberExists2 = True
                Else
                    numberExists2 = False
                End If
            End If

            If alphabetExists2 = False Then
                If InStr("MNOPQRST", Temp) > 0 Then
                    alphabetExists2 = True
                Else
                    alphabetExists2 = False
                End If
            End If

            If numberExists3 = False Then
                If InStr("1234567890", Temp) > 0 Then
                    numberExists3 = True
                Else
                    numberExists3 = False
                End If
            End If

            If alphabetExists3 = False Then
                If InStr("ABCDEFGHIJKLMNOPQRSTUVWXYZ", Temp) > 0 Then
                    alphabetExists3 = True
                Else
                    alphabetExists3 = False
                End If
            End If
        Next i

        If alphabetExists1 = True And numberExists1 = True And numberExists2 = True And alphabetExists2 = True And numberExists3 = True And alphabetExists3 = True Then
            MessageBox.Show("You are successfully Enter in Application", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'If the password entered matches to all the 'Valildations, a message box will be displayed to the user informing them that the login 'was successful.
            txtPassword.Clear() 'Clears the characters in the textbox
            'Enable all controls
            PicBox.Enabled = True
            lblName.Enabled = True
            ItemList.Enabled = True
            lblItemList.Enabled = True
            lblSearch.Enabled = True
            lblPrice.Enabled = True
            btnSearch.Enabled = True
            lblShpCrt.Enabled = True
            ItemShop.Enabled = True
            btnAddItem.Enabled = True
            btnChckout.Enabled = True
            lblTotal.Enabled = True
            txtTotal.Enabled = True
            txtPrice.Enabled = True
            txtSrch.Enabled = True
            lblNotify.Enabled = False
        Else
            'Everytime login is not successful, the error count is incremented by 1 
            ErrorCount = ErrorCount + 1

            'Allows the user have another attempt at login
            MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

            txtPassword.Clear()

            'Positions the cursor in the textbox
            txtPassword.Focus()
        End If

        'If login was not successful at the first time, the value of the lblNotify is changed to 'alert the user that they have two more attempts left
        If (ErrorCount = 1) Then
            lblNotify.Text() = "You have 2 login attempts left"

            'If login was not successful for the second time, the value of the lblNotify is changed to alert the user that they have one more attempts left

        ElseIf (ErrorCount = 2) Then
            lblNotify.Text() = "You have 1 login attempt left"

            'If login was not successful for the third time, a message box appears alerting the user 'that they have no more login attempts left
        ElseIf (ErrorCount = 3) Then
            MessageBox.Show(" You have exceeded the maximum login attempts. System is now exiting. ", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'The system will then exit after the message box is closed
            Application.Exit()
        End If
    End Sub

    Private Sub btnChckout_Click(sender As Object, e As EventArgs) Handles btnChckout.Click
        Dim obj As CalculateTotal
        obj = New CalculateTotal
        obj.Calculation()
    End Sub

End Class
