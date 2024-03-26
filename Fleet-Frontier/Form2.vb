Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = "Username"
        UsernameTextBox.ForeColor = Color.Gray

        TextBox1.Text = "Password"
        TextBox1.PasswordChar = ""
        TextBox1.ForeColor = Color.Gray
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = TextBox1.Text

        ' Check if username and password are not empty and not the default text
        If Not String.IsNullOrWhiteSpace(username) AndAlso username <> "Username" AndAlso
           Not String.IsNullOrWhiteSpace(password) AndAlso password <> "Password" Then
            ' Validate the username and password against the database
            If ValidateUser(username, password) Then
                ' If valid, show the main form
                Dim mainForm As New MainForm()
                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter a valid username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM user WHERE username = @username AND password = @password"
        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub UsernameTextBox_GotFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.GotFocus
        If UsernameTextBox.Text = "Username" Then
            UsernameTextBox.Text = ""
            UsernameTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UsernameTextBox_LostFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.LostFocus
        If UsernameTextBox.Text = "" Then
            UsernameTextBox.Text = "Username"
            UsernameTextBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Password" Then
            TextBox1.Text = ""
            TextBox1.PasswordChar = "•"
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Password"
            TextBox1.PasswordChar = ""
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub
End Class
