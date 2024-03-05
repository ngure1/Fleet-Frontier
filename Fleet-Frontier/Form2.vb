Public Class LoginForm
    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = "Username"
        UsernameTextBox.ForeColor = Color.Black

        TextBox1.Text = "Password"
        TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Form1()

        newForm.Show()
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_GotFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.GotFocus
        If UsernameTextBox.Text = "Username" Then
            UsernameTextBox.Text = ""
            UsernameTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UsernameTextBox_LostFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.LostFocus
        If UsernameTextBox.Text = "" Then
            UsernameTextBox.Text = "Username"
            UsernameTextBox.ForeColor = Color.Black
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
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
End Class