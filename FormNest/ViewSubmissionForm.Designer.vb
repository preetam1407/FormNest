<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FullName = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.GitHubProfileLink = New System.Windows.Forms.Label()
        Me.StopwatchTime = New System.Windows.Forms.Label()
        Me.NameField = New System.Windows.Forms.TextBox()
        Me.EmailField = New System.Windows.Forms.TextBox()
        Me.PhoneField = New System.Windows.Forms.TextBox()
        Me.GitHubField = New System.Windows.Forms.TextBox()
        Me.Stopwatchfield = New System.Windows.Forms.TextBox()
        Me.Previousbtn = New System.Windows.Forms.Button()
        Me.Nextbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteSubmission = New System.Windows.Forms.Button()
        Me.EditSubmission = New System.Windows.Forms.Button()
        Me.TextBoxEmailSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FullName
        '
        Me.FullName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FullName.AutoSize = True
        Me.FullName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FullName.Location = New System.Drawing.Point(85, 100)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(108, 28)
        Me.FullName.TabIndex = 0
        Me.FullName.Text = "Full Name"
        '
        'Email
        '
        Me.Email.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Email.Location = New System.Drawing.Point(85, 150)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(145, 28)
        Me.Email.TabIndex = 1
        Me.Email.Text = "Email Address"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PhoneNumber.Location = New System.Drawing.Point(85, 200)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(154, 28)
        Me.PhoneNumber.TabIndex = 2
        Me.PhoneNumber.Text = "Phone Number"
        '
        'GitHubProfileLink
        '
        Me.GitHubProfileLink.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GitHubProfileLink.AutoSize = True
        Me.GitHubProfileLink.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GitHubProfileLink.Location = New System.Drawing.Point(85, 250)
        Me.GitHubProfileLink.Name = "GitHubProfileLink"
        Me.GitHubProfileLink.Size = New System.Drawing.Size(193, 28)
        Me.GitHubProfileLink.TabIndex = 3
        Me.GitHubProfileLink.Text = "GitHub Profile Link"
        '
        'StopwatchTime
        '
        Me.StopwatchTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.StopwatchTime.AutoSize = True
        Me.StopwatchTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StopwatchTime.Location = New System.Drawing.Point(85, 300)
        Me.StopwatchTime.Name = "StopwatchTime"
        Me.StopwatchTime.Size = New System.Drawing.Size(165, 28)
        Me.StopwatchTime.TabIndex = 4
        Me.StopwatchTime.Text = "Stopwatch Time"
        '
        'NameField
        '
        Me.NameField.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NameField.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NameField.Location = New System.Drawing.Point(285, 100)
        Me.NameField.Name = "NameField"
        Me.NameField.ReadOnly = True
        Me.NameField.Size = New System.Drawing.Size(300, 34)
        Me.NameField.TabIndex = 5
        '
        'EmailField
        '
        Me.EmailField.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmailField.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EmailField.Location = New System.Drawing.Point(285, 150)
        Me.EmailField.Name = "EmailField"
        Me.EmailField.ReadOnly = True
        Me.EmailField.Size = New System.Drawing.Size(300, 34)
        Me.EmailField.TabIndex = 6
        '
        'PhoneField
        '
        Me.PhoneField.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PhoneField.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PhoneField.Location = New System.Drawing.Point(285, 200)
        Me.PhoneField.Name = "PhoneField"
        Me.PhoneField.ReadOnly = True
        Me.PhoneField.Size = New System.Drawing.Size(300, 34)
        Me.PhoneField.TabIndex = 7
        '
        'GitHubField
        '
        Me.GitHubField.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GitHubField.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GitHubField.Location = New System.Drawing.Point(285, 250)
        Me.GitHubField.Name = "GitHubField"
        Me.GitHubField.ReadOnly = True
        Me.GitHubField.Size = New System.Drawing.Size(300, 34)
        Me.GitHubField.TabIndex = 8
        '
        'Stopwatchfield
        '
        Me.Stopwatchfield.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Stopwatchfield.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Stopwatchfield.Location = New System.Drawing.Point(285, 300)
        Me.Stopwatchfield.Name = "Stopwatchfield"
        Me.Stopwatchfield.ReadOnly = True
        Me.Stopwatchfield.Size = New System.Drawing.Size(300, 34)
        Me.Stopwatchfield.TabIndex = 9
        '
        'Previousbtn
        '
        Me.Previousbtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Previousbtn.BackColor = System.Drawing.Color.CadetBlue
        Me.Previousbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Previousbtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Previousbtn.ForeColor = System.Drawing.Color.White
        Me.Previousbtn.Location = New System.Drawing.Point(125, 360)
        Me.Previousbtn.Name = "Previousbtn"
        Me.Previousbtn.Size = New System.Drawing.Size(200, 40)
        Me.Previousbtn.TabIndex = 10
        Me.Previousbtn.Text = "PREVIOUS (CTRL +P)"
        Me.Previousbtn.UseVisualStyleBackColor = True
        '
        'Nextbtn
        '
        Me.Nextbtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Nextbtn.BackColor = System.Drawing.Color.CadetBlue
        Me.Nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nextbtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Nextbtn.ForeColor = System.Drawing.Color.White
        Me.Nextbtn.Location = New System.Drawing.Point(345, 360)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(200, 40)
        Me.Nextbtn.TabIndex = 11
        Me.Nextbtn.Text = "NEXT (CTRL + N)"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(85, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Preetam Chhimpa, Slidely Task 2 - View Submissions"
        '
        'DeleteSubmission
        '
        Me.DeleteSubmission.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DeleteSubmission.BackColor = System.Drawing.Color.CadetBlue
        Me.DeleteSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteSubmission.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteSubmission.ForeColor = System.Drawing.Color.White
        Me.DeleteSubmission.Location = New System.Drawing.Point(125, 410)
        Me.DeleteSubmission.Name = "DeleteSubmission"
        Me.DeleteSubmission.Size = New System.Drawing.Size(200, 40)
        Me.DeleteSubmission.TabIndex = 13
        Me.DeleteSubmission.Text = "DELETE SUBMISSION (CTRL + D)"
        Me.DeleteSubmission.UseVisualStyleBackColor = True
        '
        'EditSubmission
        '
        Me.EditSubmission.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditSubmission.BackColor = System.Drawing.Color.CadetBlue
        Me.EditSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSubmission.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.EditSubmission.ForeColor = System.Drawing.Color.White
        Me.EditSubmission.Location = New System.Drawing.Point(345, 410)
        Me.EditSubmission.Name = "EditSubmission"
        Me.EditSubmission.Size = New System.Drawing.Size(200, 40)
        Me.EditSubmission.TabIndex = 14
        Me.EditSubmission.Text = "EDIT SUBMISSION (CTRL + E)"
        Me.EditSubmission.UseVisualStyleBackColor = True
        '
        'TextBoxEmailSearch
        '
        Me.TextBoxEmailSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBoxEmailSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxEmailSearch.Location = New System.Drawing.Point(105, 50)
        Me.TextBoxEmailSearch.Name = "TextBoxEmailSearch"
        Me.TextBoxEmailSearch.Size = New System.Drawing.Size(300, 34)
        Me.TextBoxEmailSearch.TabIndex = 15
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonSearch.BackColor = System.Drawing.Color.CadetBlue
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Location = New System.Drawing.Point(425, 50)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(150, 35)
        Me.ButtonSearch.TabIndex = 16
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ViewSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(670, 558)
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxEmailSearch)
        Me.Controls.Add(Me.EditSubmission)
        Me.Controls.Add(Me.DeleteSubmission)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.Previousbtn)
        Me.Controls.Add(Me.Stopwatchfield)
        Me.Controls.Add(Me.GitHubField)
        Me.Controls.Add(Me.PhoneField)
        Me.Controls.Add(Me.EmailField)
        Me.Controls.Add(Me.NameField)
        Me.Controls.Add(Me.StopwatchTime)
        Me.Controls.Add(Me.GitHubProfileLink)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.FullName)
        Me.Name = "ViewSubmissionForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FullName As Label
    Friend WithEvents Email As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents GitHubProfileLink As Label
    Friend WithEvents StopwatchTime As Label
    Friend WithEvents NameField As TextBox
    Friend WithEvents EmailField As TextBox
    Friend WithEvents PhoneField As TextBox
    Friend WithEvents GitHubField As TextBox
    Friend WithEvents Stopwatchfield As TextBox
    Friend WithEvents Previousbtn As Button
    Friend WithEvents Nextbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteSubmission As Button
    Friend WithEvents EditSubmission As Button
    Friend WithEvents TextBoxEmailSearch As TextBox
    Friend WithEvents ButtonSearch As Button
End Class
