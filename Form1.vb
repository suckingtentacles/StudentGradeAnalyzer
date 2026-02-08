Public Class Form1
    ' This variable stores the file path selected by the user
    Private selectedFilePath As String = ""

    ' PROCEDURE 1: Handle Browse Button Click
    ' This procedure is called when user clicks the "Browse File" button
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        ' Show the file dialog to let user select a file
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Store the selected file path
            selectedFilePath = OpenFileDialog1.FileName
            ' Display the file path in the textbox
            TxtFilePath.Text = selectedFilePath
        End If
    End Sub

    ' PROCEDURE 2: Handle Analyze Button Click
    ' This is the main procedure that orchestrates the analysis
    Private Sub BtnAnalyze_Click(sender As Object, e As EventArgs) Handles BtnAnalyze.Click
        ' First, check if a file was selected (CONDITIONAL)
        If selectedFilePath = "" Then
            MessageBox.Show("Please select a file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Clear previous results
        LstResults.Items.Clear()
        LblStatistics.Text = ""

        ' Call the procedure that reads and analyzes the file
        AnalyzeStudentFile(selectedFilePath)
    End Sub

    ' PROCEDURE 3: Read File and Analyze Students
    ' This procedure does the actual work of reading the file and processing data
    Private Sub AnalyzeStudentFile(filePath As String)
        Try
            ' Declare variables to store student data
            Dim studentLines As String()
            Dim totalAverage As Decimal = 0
            Dim passCount As Integer = 0
            Dim failCount As Integer = 0
            Dim studentCount As Integer = 0

            ' Read all lines from the file
            ' This fills the studentLines array with each line from the file
            studentLines = System.IO.File.ReadAllLines(filePath)

            ' LOOP: Process each student record in the file
            ' This loop goes through each line in the file one by one
            For i As Integer = 0 To studentLines.Length - 1
                ' Get the current line
                Dim line As String = studentLines(i)

                ' Skip empty lines
                If line.Trim() = "" Then
                    Continue For
                End If

                ' Call procedure to process this single student
                ProcessStudentRecord(line, totalAverage, passCount, failCount, studentCount)
            Next

            ' After processing all students, call procedure to display statistics
            If studentCount > 0 Then
                DisplayStatistics(totalAverage, passCount, failCount, studentCount)
            Else
                MessageBox.Show("No valid student records found in file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error reading file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' PROCEDURE 4: Process a Single Student Record
    ' Parameters: line (data), and variables to accumulate totals
    Private Sub ProcessStudentRecord(line As String, ByRef totalAverage As Decimal, ByRef passCount As Integer, ByRef failCount As Integer, ByRef studentCount As Integer)
        ' Split the line by comma to get individual values
        ' Example: "John Smith,85,90,78" becomes ["John Smith", "85", "90", "78"]
        Dim parts As String() = line.Split(","c)

        ' Check if the line has the correct format (CONDITIONAL)
        If parts.Length < 4 Then
            Return ' Skip this line if it doesn't have enough data
        End If

        ' Extract student name and grades
        Dim studentName As String = parts(0).Trim()
        Dim grade1 As Decimal = CDec(parts(1).Trim())
        Dim grade2 As Decimal = CDec(parts(2).Trim())
        Dim grade3 As Decimal = CDec(parts(3).Trim())

        ' Calculate average grade for this student
        Dim average As Decimal = (grade1 + grade2 + grade3) / 3

        ' CONDITIONAL: Check if student passed (average >= 75)
        Dim status As String
        If average >= 75 Then
            status = "PASSED"
            passCount += 1 ' Increment pass count
        Else
            status = "FAILED"
            failCount += 1 ' Increment fail count
        End If

        ' Add this student's info to the listbox
        ' This displays the result in the UI
        LstResults.Items.Add(studentName & " - Average: " & average.ToString("F2") & " - " & status)

        ' Add to total average and increment student count
        totalAverage += average
        studentCount += 1
    End Sub

    ' PROCEDURE 5: Display Overall Statistics
    ' Shows class average, pass/fail counts, etc.
    Private Sub DisplayStatistics(totalAverage As Decimal, passCount As Integer, failCount As Integer, studentCount As Integer)
        ' Calculate class average
        Dim classAverage As Decimal = totalAverage / studentCount

        ' Create the statistics text
        Dim stats As String = "=== STATISTICS ===" & vbCrLf
        stats &= "Total Students: " & studentCount & vbCrLf
        stats &= "Class Average: " & classAverage.ToString("F2") & vbCrLf
        stats &= "Passed: " & passCount & vbCrLf
        stats &= "Failed: " & failCount & vbCrLf
        stats &= "Pass Rate: " & ((passCount / studentCount) * 100).ToString("F2") & "%"

        ' Display in the statistics label
        LblStatistics.Text = stats
    End Sub

End Class
