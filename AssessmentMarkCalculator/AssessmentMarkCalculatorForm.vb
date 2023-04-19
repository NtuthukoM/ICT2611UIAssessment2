Public Class AssessmentMarkCalculatorForm

    Private assessmentMarkCalculatorLogic As AssessmentMarkCalculatorLogic

    Private Sub AssessmentMarkCalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        assessmentMarkCalculatorLogic = New AssessmentMarkCalculatorLogic()
        ClearValidationAndResult()
        txtDate.Text = Today
    End Sub

    Private Sub btnComputeFinalMark_Click(sender As Object, e As EventArgs) Handles btnComputeFinalMark.Click
        ClearValidationAndResult()
        'Validate input:
        Dim isValidInput = ValidateInput()

        'Update UI:
        If isValidInput Then
            Dim asMark1 = Double.Parse(txtAs1.Text)
            Dim asMark2 = Double.Parse(txtAs2.Text)
            Dim asMark3 = Double.Parse(txtAs3.Text)
            Dim exMark1 = Double.Parse(txtExam.Text)

            Dim finalMark = assessmentMarkCalculatorLogic.CalculateFinalMark(asMark1,
                                                                             asMark2,
                                                                             asMark3, exMark1)
            Dim result = assessmentMarkCalculatorLogic.CalculateResult(finalMark)
            txtResult.Text = Math.Round(finalMark, 2).ToString()
            lblResult.Text = String.Format("Final result for {0}: {1}", txtStudNumber.Text, result)
        Else
            txtResult.Text = "ERROR"
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        Dim isValidInput = True
        Dim studentNumber = txtStudNumber.Text
        If studentNumber.Length < 7 Then
            lblStudNumberValidation.ForeColor = Color.Red
            lblStudNumberValidation.Text = "student number must be between 7 and 8 characters"
            isValidInput = False
        End If
        'Student Number input is that it should all be numbers:
        If isValidInput Then
            If assessmentMarkCalculatorLogic.CheckForNumeric(studentNumber) = False Then
                lblStudNumberValidation.ForeColor = Color.Red
                lblStudNumberValidation.Text = "student number can only accept numbers"
                isValidInput = False
            End If
        End If

        'Assignment 1:
        Dim assessment = "Assignment 1"
        Dim strmark = txtAs1.Text
        If ValidateAssessment(lblAs1Validation, assessment, strmark) = False Then
            isValidInput = False
        End If
        'Assignment 2:
        assessment = "Assignment 2"
        strmark = txtAs2.Text
        If ValidateAssessment(lblAs2Validation, assessment, strmark) = False Then
            isValidInput = False
        End If
        'Assignment 3:
        assessment = "Assignment 3"
        strmark = txtAs3.Text
        If ValidateAssessment(lblAs3Validation, assessment, strmark) = False Then
            isValidInput = False
        End If
        'Exam:
        assessment = "Exam"
        strmark = txtExam.Text
        If ValidateAssessment(lblExamValidation, assessment, strmark) = False Then
            isValidInput = False
        End If

        Return isValidInput
    End Function

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        txtAs1.Text = ""
        txtAs2.Text = ""
        txtAs3.Text = ""
        txtStudNumber.Text = ""
        txtExam.Text = ""
        'Validation labels:
        ClearValidationAndResult()
    End Sub

    Private Sub ClearValidationAndResult()
        lblAs1Validation.Text = ""
        lblAs2Validation.Text = ""
        lblAs3Validation.Text = ""
        lblExamValidation.Text = ""
        lblStudNumberValidation.Text = ""
        lblResult.Text = ""
        txtResult.Text = ""
    End Sub

    ''' <summary>
    ''' Validate assessment input and updates associated label if there's an issue
    ''' </summary>
    ''' <param name="lbl">Associated label </param>
    ''' <param name="assessment">Assessment being validated</param>
    ''' <param name="strmark">Assessment input</param>
    ''' <returns></returns>
    Private Function ValidateAssessment(ByRef lbl As Label, assessment As String, strmark As String) As Boolean
        Dim isValidInput As Boolean = True
        Dim asMark1 As Double
        If Double.TryParse(strmark, asMark1) Then
            If asMark1 > 100 Or asMark1 < 0 Then
                lbl.Text = String.Format("{0} can only be between 0 and 100", assessment)
                isValidInput = False
            End If
        Else
            lbl.Text = String.Format("{0} can only accept numbers", assessment)
            isValidInput = False
        End If

        Return isValidInput
    End Function

End Class
