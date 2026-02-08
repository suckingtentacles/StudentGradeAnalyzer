<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnAnalyze = New System.Windows.Forms.Button()
        Me.TxtFilePath = New System.Windows.Forms.TextBox()
        Me.LstResults = New System.Windows.Forms.ListBox()
        Me.LblFileLabel = New System.Windows.Forms.Label()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.LblStatistics = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()

        ' BtnBrowse
        Me.BtnBrowse.Location = New System.Drawing.Point(12, 12)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(100, 30)
        Me.BtnBrowse.TabIndex = 0
        Me.BtnBrowse.Text = "Browse File"
        Me.BtnBrowse.UseVisualStyleBackColor = True

        ' BtnAnalyze
        Me.BtnAnalyze.Location = New System.Drawing.Point(125, 12)
        Me.BtnAnalyze.Name = "BtnAnalyze"
        Me.BtnAnalyze.Size = New System.Drawing.Size(100, 30)
        Me.BtnAnalyze.TabIndex = 1
        Me.BtnAnalyze.Text = "Analyze"
        Me.BtnAnalyze.UseVisualStyleBackColor = True

        ' TxtFilePath
        Me.TxtFilePath.Location = New System.Drawing.Point(238, 17)
        Me.TxtFilePath.Name = "TxtFilePath"
        Me.TxtFilePath.ReadOnly = True
        Me.TxtFilePath.Size = New System.Drawing.Size(350, 20)
        Me.TxtFilePath.TabIndex = 2

        ' LblFileLabel
        Me.LblFileLabel.AutoSize = True
        Me.LblFileLabel.Location = New System.Drawing.Point(12, 55)
        Me.LblFileLabel.Name = "LblFileLabel"
        Me.LblFileLabel.Size = New System.Drawing.Size(77, 13)
        Me.LblFileLabel.TabIndex = 3
        Me.LblFileLabel.Text = "Student Results:"

        ' LstResults
        Me.LstResults.FormattingEnabled = True
        Me.LstResults.Location = New System.Drawing.Point(12, 75)
        Me.LstResults.Name = "LstResults"
        Me.LstResults.Size = New System.Drawing.Size(576, 290)
        Me.LstResults.TabIndex = 4

        ' LblResults
        Me.LblResults.AutoSize = True
        Me.LblResults.Location = New System.Drawing.Point(600, 75)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(0, 13)
        Me.LblResults.TabIndex = 5

        ' LblStatistics
        Me.LblStatistics.AutoSize = True
        Me.LblStatistics.Location = New System.Drawing.Point(600, 150)
        Me.LblStatistics.Name = "LblStatistics"
        Me.LblStatistics.Size = New System.Drawing.Size(0, 13)
        Me.LblStatistics.TabIndex = 6

        ' OpenFileDialog1
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"

        ' Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.LblStatistics)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.LstResults)
        Me.Controls.Add(Me.LblFileLabel)
        Me.Controls.Add(Me.TxtFilePath)
        Me.Controls.Add(Me.BtnAnalyze)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Name = "Form1"
        Me.Text = "Student Grade Analyzer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents BtnAnalyze As System.Windows.Forms.Button
    Friend WithEvents TxtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents LstResults As System.Windows.Forms.ListBox
    Friend WithEvents LblFileLabel As System.Windows.Forms.Label
    Friend WithEvents LblResults As System.Windows.Forms.Label
    Friend WithEvents LblStatistics As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
