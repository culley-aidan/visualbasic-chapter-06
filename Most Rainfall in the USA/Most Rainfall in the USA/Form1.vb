' Program Name: Most Rainfall in the USA
' Author:       Aidan J Culley
' Date:         September 12th, 2019
' Purpose:      Calculating average rainfall

Option Strict On
Public Class frmRainfall
    Private Sub BtnRainfall_Click(sender As Object, e As EventArgs) Handles btnRainfall.Click
        Dim strRainfall As String
        Dim decRainfall As Decimal
        Dim decAverageRainfall As Decimal
        Dim decTotalRainfall As Decimal = 0D

        Dim strInputMessage As String = "Enter the rainfall for month #"
        Dim strInputHeading As String = "Rainfall"
        Dim strNormalMessage As String = "Enter the rainfall for month #"

        Dim strNonNumericError As String = "Error - Enter a number for rainfall value during the month #"
        Dim strNegativeError As String = "Error - Enter a positive number for the rainfall value during the month #"

        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainfall = strCancelClicked
            If IsNumeric(strRainfall) Then
                decRainfall = Convert.ToDecimal(strRainfall)
                If decRainfall > 0 Then
                    lstRainfall.Items.Add(decRainfall)
                    decTotalRainfall += decRainfall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        If intNumberOfEntries > 1 Then
            lblTotalAverage.Visible = True
            decAverageRainfall = decTotalRainfall / (intNumberOfEntries - 1)
            lblTotalAverage.Text = "Average Rainfall per Month is " & decAverageRainfall.ToString("F1") & " inches"
        Else
            MsgBox("No rainfall value entered")
        End If
        btnRainfall.Enabled = False
    End Sub

    Private Sub MnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstRainfall.Items.Clear()
        lblTotalAverage.Visible = False
        btnRainfall.Enabled = True
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
