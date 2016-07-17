'System.Windows.Forms.Form
Option Explicit On
Option Infer Off

Public Class frmMain
    
    Public MonthlyDues As Int16 = 0
    'Calculate button with class constructors
    Public Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        MyNewClass.Calc()

        If (lblAdditionalFee.Text.ToString() <> "") Then
            lblMonthlyDues.Text = Format(CInt(txtBasicFee.Text) + CInt(lblAdditionalFee.Text), "0.00")
        Else : lblMonthlyDues.Text = Format(txtBasicFee.Text, "0.00")
        End If


    End Sub
    Public Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public additionalCharges As Double = 0.0


End Class
' New Class with Constructors and procedure

Class MyNewClass
    Inherits frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Shared Sub Calc()

        frmMain.additionalCharges = 0
        Select Case True

            Case frmMain.RadioButton1.Checked()

                frmMain.RadioButton2.Checked = False

                If frmMain.chkGolf.Checked = True Then

                    frmMain.additionalCharges = frmMain.additionalCharges + 25

                End If

                If frmMain.chkTennis.Checked = True Then

                    frmMain.additionalCharges = frmMain.additionalCharges + 30

                End If

                If frmMain.chkBall.Checked = True Then

                    frmMain.additionalCharges = frmMain.additionalCharges + 20

                End If
                frmMain.lblAdditionalFee.Text = Format(frmMain.additionalCharges, "0.00")
                frmMain.txtBasicFee.Text = "50.00"
                frmMain.lblMonthlyDues.Text = frmMain.lblAdditionalFee.Text + frmMain.txtBasicFee.Text

            Case frmMain.RadioButton2.Checked()
                frmMain.RadioButton1.Checked = False
                If frmMain.chkGolf.Checked() Then

                    frmMain.additionalCharges = frmMain.additionalCharges + 35

                End If

                If frmMain.chkTennis.Checked() Then

                    frmMain.additionalCharges = frmMain.additionalCharges + 50

                End If

                If frmMain.chkBall.Checked() Then

                    frmMain.additionalCharges = frmMain.additionalCharges + 30

                End If

                frmMain.lblAdditionalFee.Text = Format(frmMain.additionalCharges, "0.00")
                frmMain.txtBasicFee.Text = "90.00"
                frmMain.lblMonthlyDues.Text = frmMain.lblAdditionalFee.Text + frmMain.txtBasicFee.Text


            Case Else

        End Select

    End Sub

End Class
