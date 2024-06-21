Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class ViewSubmissionForm
    Dim currentIndex As Integer = 0
    Dim submissions As List(Of Submission) = New List(Of Submission)
    Dim filteredSubmissions As List(Of Submission) = New List(Of Submission)
    Dim isEditing As Boolean = False
    Dim isSearchActive As Boolean = False

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class

    Private Sub ViewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        Try
            Using response As HttpResponseMessage = Await HttpClientManager.Client.GetAsync("read/all")
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                    DisplaySubmission(0)  ' Display the first item if list is not empty
                Else
                    MessageBox.Show("Failed to load submissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            isSearchActive = False
            ButtonSearch.Text = "Search"
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If (isSearchActive AndAlso index >= 0 AndAlso index < filteredSubmissions.Count) OrElse (Not isSearchActive AndAlso index >= 0 AndAlso index < submissions.Count) Then
            Dim submission As Submission = If(isSearchActive, filteredSubmissions(index), submissions(index))
            NameField.Text = submission.Name
            EmailField.Text = submission.Email
            PhoneField.Text = submission.Phone
            GitHubField.Text = submission.GithubLink
            Stopwatchfield.Text = submission.StopwatchTime
            ToggleEditing(False)
        Else
            ClearDisplay()
        End If
    End Sub

    Private Sub EditSubmission_Click(sender As Object, e As EventArgs) Handles EditSubmission.Click
        If isEditing Then
            ' User is trying to save the changes
            SaveChanges()  ' This will save the data and toggle editing mode
        Else
            ' User is entering edit mode
            ToggleEditing(True)
        End If
    End Sub

    Private Sub ToggleEditing(enable As Boolean)
        NameField.ReadOnly = Not enable
        EmailField.ReadOnly = Not enable
        PhoneField.ReadOnly = Not enable
        GitHubField.ReadOnly = Not enable
        EditSubmission.Text = If(enable, "Save Changes", "Edit Submission")
        isEditing = enable
    End Sub

    Private Async Sub SaveChanges()
        If currentIndex >= 0 AndAlso currentIndex < (If(isSearchActive, filteredSubmissions.Count, submissions.Count)) Then
            Dim currentSubmission = If(isSearchActive, filteredSubmissions(currentIndex), submissions(currentIndex))
            Dim originalIndex = If(isSearchActive, submissions.IndexOf(currentSubmission), currentIndex)

            Dim json As String = JsonConvert.SerializeObject(New With {
            .name = NameField.Text,
            .email = EmailField.Text,
            .phone = PhoneField.Text,
            .githubLink = GitHubField.Text,
            .stopwatchTime = Stopwatchfield.Text
        })
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Try
                Using response As HttpResponseMessage = Await HttpClientManager.Client.PutAsync($"update/{originalIndex}", content)
                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Changes saved successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        currentSubmission.Name = NameField.Text
                        currentSubmission.Email = EmailField.Text
                        currentSubmission.Phone = PhoneField.Text
                        currentSubmission.GithubLink = GitHubField.Text
                        currentSubmission.StopwatchTime = Stopwatchfield.Text
                        DisplaySubmission(currentIndex)  ' Refresh display
                        ToggleEditing(False)  ' Exit editing mode
                    Else
                        Dim errorResponse As String = Await response.Content.ReadAsStringAsync()
                        MessageBox.Show("Failed to save changes: " & errorResponse, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ToggleEditing(False)
            End Try
        End If
    End Sub

    Private Async Sub DeleteSubmission_Click(sender As Object, e As EventArgs) Handles DeleteSubmission.Click
        If currentIndex >= 0 AndAlso currentIndex < (If(isSearchActive, filteredSubmissions.Count, submissions.Count)) Then
            Dim currentSubmission = If(isSearchActive, filteredSubmissions(currentIndex), submissions(currentIndex))
            Dim originalIndex = If(isSearchActive, submissions.IndexOf(currentSubmission), currentIndex)

            Try
                Using response As HttpResponseMessage = Await HttpClientManager.Client.DeleteAsync($"delete?index={originalIndex}")
                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        submissions.Remove(currentSubmission)  ' Remove from the original list
                        If isSearchActive Then filteredSubmissions.RemoveAt(currentIndex) ' Also remove from filtered if needed

                        If currentIndex >= (If(isSearchActive, filteredSubmissions.Count, submissions.Count)) Then
                            currentIndex -= 1  ' Adjust index if the last item was deleted
                        End If
                        DisplaySubmission(currentIndex)  ' Update display to new current index
                    Else
                        MessageBox.Show("Failed to delete submission: " + Await response.Content.ReadAsStringAsync(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If ButtonSearch.Text = "Clear Search" Then
            isSearchActive = False
            ButtonSearch.Text = "Search"
            TextBoxEmailSearch.Text = ""  ' Clear the search text box
            currentIndex = 0
        Else
            Dim emailToSearch As String = TextBoxEmailSearch.Text.Trim()
            If emailToSearch <> "" Then  ' Ensure we don't filter on an empty string
                filteredSubmissions = submissions.Where(Function(x) x.Email.Contains(emailToSearch)).ToList()
                isSearchActive = True
                ButtonSearch.Text = "Clear Search"
                currentIndex = 0
            End If
        End If
        DisplaySubmission(currentIndex)
    End Sub


    Private Sub ClearDisplay()
        NameField.Text = ""
        EmailField.Text = ""
        PhoneField.Text = ""
        GitHubField.Text = ""
        Stopwatchfield.Text = ""
    End Sub

    Private Sub NavigationButtons_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click, Previousbtn.Click
        If isEditing AndAlso MessageBox.Show("You have unsaved changes. Save changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SaveChanges()
        End If
        If sender Is Nextbtn AndAlso currentIndex < (If(isSearchActive, filteredSubmissions.Count, submissions.Count) - 1) Then
            currentIndex += 1
        ElseIf sender Is Previousbtn AndAlso currentIndex > 0 Then
            currentIndex -= 1
        End If
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Previousbtn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Nextbtn.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            DeleteSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            EditSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.F Then
            ButtonSearch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S AndAlso isEditing Then
            SaveChanges()
        End If
    End Sub
End Class
