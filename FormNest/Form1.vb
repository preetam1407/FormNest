Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable key preview to handle key events at the form level
        Me.KeyPreview = True

        ' Apply styling
        StyleButton(btnViewSubmissions)
        StyleButton(btnCreateSubmission)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Handle shortcut keys
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub StyleButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        AddHandler btn.MouseEnter, AddressOf Button_MouseEnter
        AddHandler btn.MouseLeave, AddressOf Button_MouseLeave
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.DeepSkyBlue  ' Lighter shade on hover
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.CadetBlue  ' Original color
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

End Class
