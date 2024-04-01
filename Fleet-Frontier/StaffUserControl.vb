Imports MySql.Data.MySqlClient

Public Class StaffUserControl
    Public Shared ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    ' Declare a shared variable to store the reference to the opened form
    Public openedAddStaffForm As AddStaffForm = Nothing

    Private Sub AddStaffButton_Click(sender As Object, e As EventArgs) Handles AddStaffButton.Click
        ' Check if the form is already open and not disposed
        If openedAddStaffForm IsNot Nothing AndAlso Not openedAddStaffForm.IsDisposed Then
            ' If open, bring the existing form to the front
            openedAddStaffForm.BringToFront()
        Else
            ' If not open, create a new instance of the form
            openedAddStaffForm = New AddStaffForm()
            openedAddStaffForm.Owner = FindForm()
            ' Subscribe to the LocationChanged event of StaffUserControl
            AddHandler openedAddStaffForm.Owner.LocationChanged, AddressOf StaffUserControl_LocationChanged
            ' Center the AddStaffForm relative to StaffUserControl
            CenterFormRelativeToStaffUserControl(openedAddStaffForm)
            openedAddStaffForm.Show()
        End If
    End Sub

    Private Sub StaffUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
    End Sub

    Private Sub LoadEmployees()
        ClearEmployeePanels()

        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT employee_id, employee_name, employee_type, employee_phone_number,is_available, date_of_entry FROM employee"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim employeePanel As New Panel()
                            employeePanel.BorderStyle = BorderStyle.FixedSingle
                            employeePanel.Size = New Size(400, 115)

                            Dim labelXPosition As Integer = 10 ' X position for labels
                            Dim valueXPosition As Integer = 130 ' X position for values
                            Dim controlYPosition As Integer = 20 ' Starting Y position
                            Dim spacing As Integer = 30 ' Spacing between controls

                            Dim nameLabelTitle As New Label() ' Label for "Name:" title
                            nameLabelTitle.Text = "Name: "
                            nameLabelTitle.Location = New Point(labelXPosition, controlYPosition)
                            nameLabelTitle.Font = New Font(nameLabelTitle.Font, FontStyle.Regular) ' Set font to normal

                            Dim nameLabel As New Label() ' Label for employee name
                            nameLabel.Text = reader("employee_name").ToString()
                            nameLabel.Location = New Point(valueXPosition, controlYPosition)
                            nameLabel.Font = New Font(nameLabel.Font, FontStyle.Regular) ' Set font to normal

                            ' Set font to normal for other labels as well
                            Dim phoneLabel As New Label()
                            phoneLabel.Text = "Phone Number:"
                            phoneLabel.Location = New Point(labelXPosition, controlYPosition + spacing)
                            phoneLabel.Font = New Font(phoneLabel.Font, FontStyle.Regular)

                            Dim phoneNumberLabel As New Label()
                            phoneNumberLabel.Text = reader("employee_phone_number").ToString()
                            phoneNumberLabel.Location = New Point(valueXPosition, controlYPosition + spacing)
                            phoneNumberLabel.Font = New Font(phoneNumberLabel.Font, FontStyle.Regular)

                            Dim entryDateLabel As New Label()
                            entryDateLabel.Text = "Date of Entry:"
                            entryDateLabel.Location = New Point(labelXPosition, controlYPosition + 2 * spacing)
                            entryDateLabel.Font = New Font(entryDateLabel.Font, FontStyle.Regular)

                            Dim entryDateValueLabel As New Label()
                            entryDateValueLabel.Text = reader("date_of_entry").ToString()
                            entryDateValueLabel.Location = New Point(valueXPosition, controlYPosition + 2 * spacing)
                            entryDateValueLabel.Font = New Font(entryDateValueLabel.Font, FontStyle.Regular)

                            Dim deleteButton As New Button()
                            deleteButton.Text = "Delete"
                            deleteButton.Location = New Point(300, 70)
                            deleteButton.Tag = reader("employee_id").ToString() ' Store employee ID as Tag
                            deleteButton.Size = New Size(80, 40)
                            AddHandler deleteButton.Click, AddressOf DeleteButton_Click


                            Dim updateButton As New Button()
                            updateButton.Text = "Update"
                            updateButton.Location = New Point(300, 10)
                            updateButton.Tag = reader("employee_id").ToString() ' Store employee ID as Tag
                            updateButton.Size = New Size(80, 40)
                            AddHandler updateButton.Click, AddressOf UpdateButton_Click

                            employeePanel.Controls.Add(nameLabelTitle)
                            employeePanel.Controls.Add(nameLabel)
                            employeePanel.Controls.Add(phoneLabel)
                            employeePanel.Controls.Add(phoneNumberLabel)
                            employeePanel.Controls.Add(entryDateLabel)
                            employeePanel.Controls.Add(entryDateValueLabel)
                            employeePanel.Controls.Add(deleteButton)
                            employeePanel.Controls.Add(updateButton)

                            ' Add the employee panel to the parent control
                            Controls.Add(employeePanel)





                            ' Determine which panel to add the employee details to based on employee type
                            Dim employeeType As String = reader("employee_type").ToString()
                            If employeeType = "Driver" Then
                                ' Calculate the position of the driver panel based on the index
                                Dim driverPanelYPosition As Integer = 10 + (130 * GetDriverPanelCount())
                                employeePanel.Location = New Point(10, driverPanelYPosition)
                                DriversListPanel.Controls.Add(employeePanel)
                            ElseIf employeeType = "Conductor" Then
                                ' Calculate the position of the conductor panel based on the index
                                Dim conductorPanelYPosition As Integer = 10 + (130 * GetConductorPanelCount())
                                employeePanel.Location = New Point(10, conductorPanelYPosition)
                                ConductorListPanel.Controls.Add(employeePanel)
                            End If
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading employees: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Make ConductorListPanel scrollable
        ConductorListPanel.AutoScroll = True

        ' Make DriverListPanel scrollable
        DriversListPanel.AutoScroll = True

    End Sub
    ' Add this handler to handle the delete button click
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim employeeId As String = button.Tag.ToString()

        ' Prompt for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            ' Perform deletion from the database
            Try
                Using connection As New MySqlConnection(ConnectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM employee WHERE employee_id = @employeeId"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@employeeId", employeeId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Remove the employee panel from its parent
                            Dim panel As Panel = CType(button.Parent, Panel)
                            panel.Parent.Controls.Remove(panel)

                            ' Refresh the staff panels
                            RefreshStaffPanels()

                            MessageBox.Show("Staff member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to delete staff member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting staff member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    ' define the EmployeeData class to represent employee information
    Public Class EmployeeData
        Public Property Id As Integer
        Public Property Name As String
        Public Property PhoneNumber As String
        Public Property Type As String
        Public Property Is_Available As String
        Public Property EntryDate As Date
    End Class

    ' Add a new event handler for the update button click
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim employeeId As String = button.Tag.ToString()

        ' Retrieve employee data based on employeeId
        Dim employeeData As EmployeeData = RetrieveEmployeeData(employeeId)

        ' Pass the retrieved employee data to the UpdateStaffForm
        Dim updateForm As New UpdateStaff(employeeData)
        updateForm.ShowDialog()

        ' Refresh the employee panels after update
        RefreshStaffPanels()
    End Sub

    Private Function RetrieveEmployeeData(employeeId As String) As EmployeeData
        Dim employeeData As New EmployeeData()

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM employee WHERE employee_id = @employeeId"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@employeeId", employeeId)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        employeeData.Id = Convert.ToInt32(reader("employee_id"))
                        employeeData.Name = reader("employee_name").ToString()
                        employeeData.PhoneNumber = reader("employee_phone_number").ToString()
                        employeeData.Type = reader("employee_type").ToString()
                        employeeData.EntryDate = Convert.ToDateTime(reader("date_of_entry"))
                        employeeData.Is_Available = reader("is_available").ToString()
                    End If
                End Using
            End Using
        End Using

        Return employeeData
    End Function



    Private Function GetConductorPanelCount() As Integer
        Return ConductorListPanel.Controls.OfType(Of Panel)().Count()
    End Function

    Private Function GetDriverPanelCount() As Integer
        Return DriversListPanel.Controls.OfType(Of Panel)().Count()
    End Function

    Private Sub ClearEmployeePanels()
        DriversListPanel.Controls.Clear()
        ConductorListPanel.Controls.Clear() ' Clear ConductorListPanel as well
    End Sub

    Public Sub RefreshStaffPanels()
        ClearEmployeePanels()
        LoadEmployees()
    End Sub

    Private Sub StaffUserControl_LocationChanged(sender As Object, e As EventArgs)
        CenterFormRelativeToStaffUserControl(openedAddStaffForm)
    End Sub

    Private Sub CenterFormRelativeToStaffUserControl(form As Form)
        If form IsNot Nothing AndAlso form.Owner IsNot Nothing Then
            Dim staffUserControlCenterX As Integer = form.Owner.Location.X + (form.Owner.Width - form.Width) \ 2
            Dim staffUserControlCenterY As Integer = form.Owner.Location.Y + (form.Owner.Height - form.Height) \ 2
            form.Location = New Point(staffUserControlCenterX, staffUserControlCenterY)
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RefreshStaffPanels()
    End Sub
End Class
