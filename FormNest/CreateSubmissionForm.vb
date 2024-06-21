Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text
Imports System.Text.RegularExpressions

Public Class CreateSubmissionForm
    Dim stopwatch As New Stopwatch()
    ' Regular expressions for validation
    Private Const EmailRegex As String = "^[^\s@]+@[^\s@]+\.[^\s@]{2,}$"
    Private Const GitHubLinkRegex As String = "^https://github\.com/.+$"
    Private Const PhoneRegex As String = "^\+\d{2}\d{10}$"  ' Assuming a 2-digit country code

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial form load event
        UpdateStopwatchDisplay()
        Me.KeyPreview = True  ' Enable key capture for the form
        ' Set placeholder text
        TextBox2.Text = "e.g., user@example.com"
        TextBox3.Text = "e.g., +911234567890"
        TextBox4.Text = "e.g., https://github.com/username"
        TextBox2.ForeColor = Color.Gray
        TextBox3.ForeColor = Color.Gray
        TextBox4.ForeColor = Color.Gray
    End Sub

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus, TextBox3.GotFocus, TextBox4.GotFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        Select Case textBox.Name
            Case TextBox2.Name
                If textBox.Text = "e.g., user@example.com" Then
                    textBox.Text = ""
                    textBox.ForeColor = Color.Black
                End If
            Case TextBox3.Name
                If textBox.Text = "e.g., +911234567890" Then
                    textBox.Text = ""
                    textBox.ForeColor = Color.Black
                End If
            Case TextBox4.Name
                If textBox.Text = "e.g., https://github.com/username" Then
                    textBox.Text = ""
                    textBox.ForeColor = Color.Black
                End If
        End Select
    End Sub

    Private Sub TextBox_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus, TextBox3.LostFocus, TextBox4.LostFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            textBox.ForeColor = Color.Gray
            Select Case textBox.Name
                Case TextBox2.Name
                    textBox.Text = "e.g., user@example.com"
                Case TextBox3.Name
                    textBox.Text = "e.g., +911234567890"
                Case TextBox4.Name
                    textBox.Text = "e.g., https://github.com/username"
            End Select
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Toggle the stopwatch running state
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub btnSubmitForm_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Submit the form data
        If ValidateFormData() Then
            SaveSubmission()
        Else
            MessageBox.Show("Please ensure all fields are filled correctly.", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateFormData() As Boolean
        ' Updated validation checks
        Return Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso
               Regex.IsMatch(TextBox2.Text, EmailRegex) AndAlso
               Regex.IsMatch(TextBox3.Text, PhoneRegex) AndAlso
               Regex.IsMatch(TextBox4.Text, GitHubLinkRegex) AndAlso
               TextBox2.Text <> "e.g., user@example.com" AndAlso
               TextBox3.Text <> "e.g., +911234567890" AndAlso
               TextBox4.Text <> "e.g., https://github.com/username"
    End Function

    Private Async Sub SaveSubmission()
        ' Create an anonymous object to represent the submission data
        Dim submission = New With {
            .name = TextBox1.Text,
            .email = TextBox2.Text,
            .phone = TextBox3.Text,
            .githubLink = TextBox4.Text,
            .stopwatchTime = TextBox5.Text
        }

        ' Convert the submission object to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        ' Use the HttpClient from the HttpClientManager
        Try
            Dim response As HttpResponseMessage = Await HttpClientManager.Client.PostAsync("submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show($"Submission for {TextBox1.Text} has been saved.", "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetForm()
            Else
                MessageBox.Show("Failed to save submission: " + Await response.Content.ReadAsStringAsync(), "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Optionally reset stopwatch after submission attempt
            stopwatch.Reset()
            UpdateStopwatchDisplay()
        End Try
    End Sub

    Private Sub UpdateStopwatchDisplay()
        ' Update the display for the stopwatch
        TextBox5.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub ResetForm()
        ' Clear all text fields and reset the stopwatch
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        stopwatch.Reset()
        UpdateStopwatchDisplay()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Handle keyboard shortcuts for the form
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmitForm_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch_Click(sender, e)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' Placeholder for any Label5 click events
    End Sub
End Class
