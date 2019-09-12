' Program Name: Fitness Challenge
' Author:       Aidan J Culley
' Date:         September 12th, 2019
' Purpose:      The Fitness Challenge program enteres the weight loss
'               loss from the team members for a fitness challenge. It displays each
'               weight loss value. After all weight loss values have been entered, 
'               it displays the average weight loss for the team.

Option Strict On
Public Class frmFitness
    Private Sub BtnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        ' The btnWeightLoss_Click event accepts and displays up to 8 weight loss values
        ' and then calculates and displays the average weight loss for the team

        ' Declaring variables

        '   Weight values
        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0D

        '   Information strings
        Dim strInputMessage As String = "Enter the weight loss for team member #"
        Dim strInputHeading As String = "Weight Loss"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"

        '   Errors
        Dim strNonNumericError As String = "Error - Enter a number for the weight loss of team member #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss of team member #"

        ' Declare and initialize loop variables 
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the weight loss of up to 8 team members.
        ' The loop terminates when the user has entered 8 weight loss values or the user 
        ' clicks the cancel button or the close button in the inputbox
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strCancelClicked
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
    End Sub
End Class
