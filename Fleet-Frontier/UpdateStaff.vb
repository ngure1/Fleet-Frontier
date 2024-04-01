Imports System.Windows.Forms
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports Fleet_Frontier.StaffUserControl

Public Class UpdateStaff

    ' Add a property to store the employee ID
    Private _employeeId As Integer
    Public Property EmployeeId As Integer
        Get
            Return _employeeId
        End Get
        Set(ByVal value As Integer)
            _employeeId = value
        End Set
    End Property

    ' Constructor to initialize the form with employee data
    Public Sub New(ByVal employeeData As EmployeeData)
        InitializeComponent()

        ' Set the EmployeeId property
        Me.EmployeeId = employeeData.Id
        AvailabilityComboBox.Items.AddRange({"True", "False"})

        ' Set the default value of the AvailabilityComboBox based on the data from the database
        If employeeData.Is_Available = "True" Then
            AvailabilityComboBox.SelectedIndex = 0 ' True
        Else
            AvailabilityComboBox.SelectedIndex = 1 ' False
        End If

        ' Populate the text boxes with the retrieved employee data
        NameTextBox.Text = employeeData.Name
        PhoneNumberTextBox.Text = employeeData.PhoneNumber
        TypeComboBox.Text = employeeData.Type
        StaffDateTimePicker.Value = employeeData.EntryDate

    End Sub

    ' Button click event to handle update
    Private Sub AddStaffConfirmButton_Click(sender As Object, e As EventArgs) Handles AddStaffConfirmButton.Click
        Try
            Using conn As New MySqlConnection(StaffUserControl.ConnectionString)
                conn.Open()

                ' Check if the employee exists
                If Not EmployeeExists(conn, _employeeId) Then
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                ' Convert the availability to the corresponding integer value
                Dim availabilityValue As Integer
                If AvailabilityComboBox.SelectedIndex = 0 Then ' True
                    availabilityValue = 1
                Else
                    availabilityValue = 0 ' False
                End If

                Dim query As String = "UPDATE employee SET employee_name = @name, employee_phone_number = @phoneNumber, employee_type = @type, is_available = @availability, date_of_entry = @date WHERE employee_id = @employeeId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", NameTextBox.Text)
                    cmd.Parameters.AddWithValue("@phoneNumber", PhoneNumberTextBox.Text)
                    cmd.Parameters.AddWithValue("@type", TypeComboBox.Text)
                    cmd.Parameters.AddWithValue("@availability", availabilityValue)
                    cmd.Parameters.AddWithValue("@date", StaffDateTimePicker.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@employeeId", _employeeId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to update employee. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to check if the employee exists
    Private Function EmployeeExists(conn As MySqlConnection, employeeId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM employee WHERE employee_id = @employeeId"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@employeeId", employeeId)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    ' Button click event to close the form
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    ' Button click event to cancel and close the form
    Private Sub CancelStaffButton_Click(sender As Object, e As EventArgs) Handles CancelStaffButton.Click
        Me.Close()
    End Sub

    ' Button click event to clear the form fields
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        PhoneNumberTextBox.Text = ""
        TypeComboBox.SelectedIndex = -1
        TypeComboBox.Text = ""
        AvailabilityComboBox.SelectedIndex = -1
        AvailabilityComboBox.Text = ""
    End Sub


End Class
