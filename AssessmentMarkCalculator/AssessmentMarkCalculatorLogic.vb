
Public Class AssessmentMarkCalculatorLogic

    Public Function CalculateFinalMark(as1 As Double, as2 As Double, as3 As Double, exam As Double)
        Dim finalMark = (as1 * 0.1) + (as2 * 0.1) + (as3 * 0.3) + (exam * 0.5)
        Return finalMark
    End Function

    Public Function CalculateResult(finalMark As Double) As String
        Dim result As String = ""
        If finalMark < 40 Then
            result = "F"
        ElseIf finalMark >= 40 And finalMark < 75 Then
            result = "P"
        ElseIf finalMark >= 75 Then
            result = "D"
        End If
        If result = "" Then
            Throw New ApplicationException("Invalid final mark")

        End If
        Return result
    End Function

    Public Function CheckForNumeric(studnum As String) As Boolean
        Dim i As Integer
        Dim thisChar As Char
        Dim asciiValue As Integer
        Dim isValid As Boolean
        isValid = True
        For i = 0 To Len(studnum) - 1
            thisChar = studnum.Chars(i)
            asciiValue = Convert.ToByte(thisChar)
            If asciiValue < 48 Then isValid = False
            If asciiValue > 57 Then isValid = False
        Next i
        If isValid Then
            Return True
        Else
            Return False
        End If
        Throw New NotImplementedException()
    End Function
End Class
