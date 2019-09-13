' Program Name: Softball Scoreboard
' Author:       Aidan J Culley
' Date:         September 12th, 2019
' Purpose:      Calculates innings score no idea how this works

Option Strict On
Public Class frmSoftball
    Private Sub BtnInnings_Click(sender As Object, e As EventArgs) Handles btnInnings.Click
        ' The btnInnings_Click event accepts and displays up to 7 innings

        ' Declaring variables
        Dim strInnings As String
        Dim decInnings As Decimal
        Dim decTotalInnings As Decimal = 0D

        '   Information strings
        Dim strInputMessage As String = "Enter the innings for run #"
        Dim strInputHeading As String = "Innings"
        Dim strNormalMessage As String = "Enter the innings for run #"

        '   Errors
        Dim strNonNumericError As String = "Error - Enter a valid number for the inning #"
        Dim strNegativeError As String = "Error - Enter a positive value for the inning #"

        '   Loops
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries = 7
        Dim intNumberOfEntries = 1

        strInnings = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strInnings = strCancelClicked
            If IsNumeric(strInnings) Then
                decInnings = Convert.ToDecimal(strInnings)
                If decInnings > 0 Then
                    lstInnings.Items.Add(decInnings)
                    decTotalInnings += decInnings
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strInnings = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        If intNumberOfEntries > 1 Then
            lblFinalScore.Visible = True
            lblFinalScore.Text = "The final score is " & decTotalInnings.ToString("F1")
        End If

        btnInnings.Enabled = False
    End Sub
End Class
