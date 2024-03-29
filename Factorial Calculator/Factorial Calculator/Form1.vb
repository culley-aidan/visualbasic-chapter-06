﻿' Program Name: Factorial Calculator
' Author:       Aidan J Culley
' Date:         September 12th, 2019
' Purpose:      calculates factorials

Option Strict On
Public Class frmFactorial
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim strFactorialMax As String
        Dim decFactorialMax As Decimal
        Dim decFactorial As Decimal

        Dim strInputMessage As String = "Enter the factorials you want (1-12)"
        Dim strInputHeading As String = "Factorials"
        Dim strNormalMessage As String = "Enter the factorials you want (1-12)"

        Dim strNonNumericError As String = "Error - Enter a valid number between (1-12)"
        Dim strNegativeError As String = "Error - Enter a postive value"
        Dim strHighNumberError As String = "Error - Enter a number <= 12"

        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 13
        Dim intRequestedEntries As Decimal = 12
        Dim intNumberOfEntries As Integer = 1

        strFactorialMax = InputBox(strInputMessage, strInputHeading, " ")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strFactorialMax = strCancelClicked Or intNumberOfEntries > intRequestedEntries
            If IsNumeric(strFactorialMax) Then
                decFactorialMax = Convert.ToDecimal(strFactorialMax)
                intRequestedEntries = decFactorialMax
                If decFactorialMax >= 1 And decFactorialMax <= 12 Then
                    decFactorial = intNumberOfEntries
                    For i = 2 To intNumberOfEntries - 1
                        decFactorial = decFactorial * i
                    Next
                    lstFactorials.Items.Add(intNumberOfEntries & "!" & "=" & decFactorial)
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                ElseIf intRequestedEntries > (intMaxNumberOfEntries - 1) Then
                    strInputMessage = strHighNumberError
                    strFactorialMax = InputBox(strInputMessage, strInputHeading, " ")
                ElseIf intRequestedEntries = 0 Or intRequestedEntries < 0 Then
                    strInputMessage = strNegativeError
                    strFactorialMax = InputBox(strInputMessage, strInputHeading, " ")
                Else
                    strInputMessage = strNonNumericError
                    strFactorialMax = InputBox(strInputMessage, strInputHeading, " ")
                End If
            Else
                strInputMessage = strNonNumericError
                strFactorialMax = InputBox(strInputMessage, strInputHeading, " ")
            End If
        Loop
        If Not intNumberOfEntries > 1 Then
            MsgBox("No value entered")
        End If
        btnCalculate.Enabled = False
    End Sub

    Private Sub MnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstFactorials.Items.Clear()
        btnCalculate.Enabled = True
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
