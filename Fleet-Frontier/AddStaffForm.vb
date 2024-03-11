Imports MySql.Data.MySqlClient

Public Class AddStaffForm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub AddStaffCloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub AddStaffConfirmButton_Click(sender As Object, e As EventArgs) Handles AddStaffConfirmButton.Click
        Dim connectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
        conn = New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim insertQuery As String = "INSERT INTO employee(employee_name, employee_phone_number, employee_type, Is_available, date_of_entry) VALUES (@name, @phoneNumber, @type, @is_available, @date)"
            command = New MySqlCommand(insertQuery, conn)
            command.Parameters.AddWithValue("@name", NameTextBox.Text)
            command.Parameters.AddWithValue("@phoneNumber", PhoneNumberTextBox.Text)
            command.Parameters.AddWithValue("@type", TypeComboBox.Text)
            command.Parameters.AddWithValue("@is_available", AvailabilityTextBox.Text)

            Dim formattedDate As String = StaffDateTimePicker.Value.ToString("yyyy-MM-dd")
            command.Parameters.AddWithValue("@date", formattedDate)

            command.ExecuteNonQuery()
            MessageBox.Show("Employee Created Successfully!!!")

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        'Clearing the textboxes after successful adding a new vehicle
        NameTextBox.Text = ""
        PhoneNumberTextBox.Text = ""
        TypeComboBox.SelectedIndex = -1
        TypeComboBox.Text = ""
        AvailabilityTextBox.Text = ""

        'Returning the cursor to the first textbox
        NameTextBox.Focus()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        PhoneNumberTextBox.Text = ""
        TypeComboBox.SelectedIndex = -1
        TypeComboBox.Text = ""
        AvailabilityTextBox.Text = ""
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private Sub ControlBoxPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles ControlBoxPanel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub ControlBoxPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles ControlBoxPanel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - Me.mouseY
            Me.Left = Cursor.Position.X - Me.mouseX
        End If
    End Sub

    Private Sub ControlBoxPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles ControlBoxPanel.MouseUp
        draggable = False

    End Sub

    Private Sub CancelStaffButton_Click(sender As Object, e As EventArgs) Handles CancelStaffButton.Click
        Me.Close()
    End Sub
End Class
