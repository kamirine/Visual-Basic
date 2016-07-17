Public Class CalculateTotal

    Dim FILE_NAME As String = "C:\ShoppingFile\ItemList.txt"
    Dim oFile As System.IO.File
    Dim oWrite As System.IO.StreamWriter
    Dim oRead As System.IO.StreamReader
    Dim r As New IO.StreamReader("C:\ShoppingFile\ItemList.txt")
    Public Sub Calculation()
        
        Dim strTextFromFile As String = IO.File.ReadAllText("C:\ShoppingFile\ItemList.txt")
        Dim strResults As String = String.Empty


        Dim strLine As String = String.Empty

        Dim Total As Integer = 0
        Do While r.Peek() >= 0
            strLine = String.Empty
            strLine = r.ReadLine

            Dim Value As String = strLine.Substring(strLine.LastIndexOf("$") + 1)
            If Value <> String.Empty Then
                Total = Total + Convert.ToInt32(Value)

            End If
        Loop

        Form1.txtTotal.Text = Total.ToString

        
    End Sub

End Class
