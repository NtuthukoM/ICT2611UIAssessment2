<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssessmentMarkCalculatorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtStudNumber = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnComputeFinalMark = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.txtAs2 = New System.Windows.Forms.TextBox()
        Me.txtAs3 = New System.Windows.Forms.TextBox()
        Me.txtAs1 = New System.Windows.Forms.TextBox()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblStudNumberValidation = New System.Windows.Forms.Label()
        Me.lblAs1Validation = New System.Windows.Forms.Label()
        Me.lblAs2Validation = New System.Windows.Forms.Label()
        Me.lblAs3Validation = New System.Windows.Forms.Label()
        Me.lblExamValidation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Exam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Assignment 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Assignment 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Assignment 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Student Number"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(203, 38)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 6
        '
        'txtStudNumber
        '
        Me.txtStudNumber.Location = New System.Drawing.Point(203, 82)
        Me.txtStudNumber.MaxLength = 8
        Me.txtStudNumber.Name = "txtStudNumber"
        Me.txtStudNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtStudNumber.TabIndex = 0
        '
        'txtResult
        '
        Me.txtResult.Enabled = False
        Me.txtResult.Location = New System.Drawing.Point(331, 273)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(76, 22)
        Me.txtResult.TabIndex = 8
        '
        'btnComputeFinalMark
        '
        Me.btnComputeFinalMark.Location = New System.Drawing.Point(454, 351)
        Me.btnComputeFinalMark.Name = "btnComputeFinalMark"
        Me.btnComputeFinalMark.Size = New System.Drawing.Size(129, 29)
        Me.btnComputeFinalMark.TabIndex = 9
        Me.btnComputeFinalMark.Text = "Compute final mark"
        Me.btnComputeFinalMark.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(589, 351)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(129, 29)
        Me.btnClearForm.TabIndex = 10
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'txtAs2
        '
        Me.txtAs2.Location = New System.Drawing.Point(203, 153)
        Me.txtAs2.Name = "txtAs2"
        Me.txtAs2.Size = New System.Drawing.Size(100, 22)
        Me.txtAs2.TabIndex = 2
        '
        'txtAs3
        '
        Me.txtAs3.Location = New System.Drawing.Point(203, 190)
        Me.txtAs3.Name = "txtAs3"
        Me.txtAs3.Size = New System.Drawing.Size(100, 22)
        Me.txtAs3.TabIndex = 3
        '
        'txtAs1
        '
        Me.txtAs1.Location = New System.Drawing.Point(203, 118)
        Me.txtAs1.Name = "txtAs1"
        Me.txtAs1.Size = New System.Drawing.Size(100, 22)
        Me.txtAs1.TabIndex = 1
        '
        'txtExam
        '
        Me.txtExam.Location = New System.Drawing.Point(203, 230)
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(100, 22)
        Me.txtExam.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(42, 273)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 16)
        Me.lblResult.TabIndex = 15
        '
        'lblStudNumberValidation
        '
        Me.lblStudNumberValidation.AutoSize = True
        Me.lblStudNumberValidation.Location = New System.Drawing.Point(328, 84)
        Me.lblStudNumberValidation.Name = "lblStudNumberValidation"
        Me.lblStudNumberValidation.Size = New System.Drawing.Size(156, 16)
        Me.lblStudNumberValidation.TabIndex = 16
        Me.lblStudNumberValidation.Text = "lblStudNumberValidation"
        '
        'lblAs1Validation
        '
        Me.lblAs1Validation.AutoSize = True
        Me.lblAs1Validation.Location = New System.Drawing.Point(328, 121)
        Me.lblAs1Validation.Name = "lblAs1Validation"
        Me.lblAs1Validation.Size = New System.Drawing.Size(48, 16)
        Me.lblAs1Validation.TabIndex = 17
        Me.lblAs1Validation.Text = "Label7"
        '
        'lblAs2Validation
        '
        Me.lblAs2Validation.AutoSize = True
        Me.lblAs2Validation.Location = New System.Drawing.Point(328, 159)
        Me.lblAs2Validation.Name = "lblAs2Validation"
        Me.lblAs2Validation.Size = New System.Drawing.Size(48, 16)
        Me.lblAs2Validation.TabIndex = 18
        Me.lblAs2Validation.Text = "Label7"
        '
        'lblAs3Validation
        '
        Me.lblAs3Validation.AutoSize = True
        Me.lblAs3Validation.Location = New System.Drawing.Point(328, 196)
        Me.lblAs3Validation.Name = "lblAs3Validation"
        Me.lblAs3Validation.Size = New System.Drawing.Size(48, 16)
        Me.lblAs3Validation.TabIndex = 19
        Me.lblAs3Validation.Text = "Label7"
        '
        'lblExamValidation
        '
        Me.lblExamValidation.AutoSize = True
        Me.lblExamValidation.Location = New System.Drawing.Point(328, 233)
        Me.lblExamValidation.Name = "lblExamValidation"
        Me.lblExamValidation.Size = New System.Drawing.Size(48, 16)
        Me.lblExamValidation.TabIndex = 20
        Me.lblExamValidation.Text = "Label7"
        '
        'AssessmentMarkCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 392)
        Me.Controls.Add(Me.lblExamValidation)
        Me.Controls.Add(Me.lblAs3Validation)
        Me.Controls.Add(Me.lblAs2Validation)
        Me.Controls.Add(Me.lblAs1Validation)
        Me.Controls.Add(Me.lblStudNumberValidation)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtExam)
        Me.Controls.Add(Me.txtAs1)
        Me.Controls.Add(Me.txtAs3)
        Me.Controls.Add(Me.txtAs2)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnComputeFinalMark)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtStudNumber)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AssessmentMarkCalculatorForm"
        Me.Text = "Calculate Final Mark"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtStudNumber As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnComputeFinalMark As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents txtAs2 As TextBox
    Friend WithEvents txtAs3 As TextBox
    Friend WithEvents txtAs1 As TextBox
    Friend WithEvents txtExam As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblStudNumberValidation As Label
    Friend WithEvents lblAs1Validation As Label
    Friend WithEvents lblAs2Validation As Label
    Friend WithEvents lblAs3Validation As Label
    Friend WithEvents lblExamValidation As Label
End Class
