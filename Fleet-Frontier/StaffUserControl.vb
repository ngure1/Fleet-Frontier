Imports MySql.Data.MySqlClient

Public Class StaffUserControl
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
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
                Dim query As String = "SELECT employee_id, employee_name, employee_type, employee_phone_number, date_of_entry FROM employee"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim nameLabel As New Label()
                            nameLabel.Text = "Name: " & reader("employee_name").ToString()
                            nameLabel.Location = New Point(10, 10)
                            nameLabel.Font = New Font(nameLabel.Font, FontStyle.Bold) ' Set font to bold

                            Dim phoneLabel As New Label()
                            phoneLabel.Text = "Phone Number:"
                            phoneLabel.Location = New Point(10, 40)

                            Dim phoneNumberLabel As New Label()
                            phoneNumberLabel.Text = reader("employee_phone_number").ToString()
                            phoneNumberLabel.Location = New Point(130, 40) ' Adjust X position accordingly

                            Dim entryDateLabel As New Label()
                            entryDateLabel.Text = "Date of Entry:"
                            entryDateLabel.Location = New Point(10, 70)

                            Dim entryDateValueLabel As New Label()
                            entryDateValueLabel.Text = reader("date_of_entry").ToString()
                            entryDateValueLabel.Location = New Point(130, 70) ' Adjust X position accordingly

                            ' Create a panel to hold employee details
                            Dim employeePanel As New Panel()
                            employeePanel.BorderStyle = BorderStyle.FixedSingle
                            employeePanel.Size = New Size(400, 120)
                            employeePanel.Controls.Add(nameLabel)
                            employeePanel.Controls.Add(phoneLabel)
                            employeePanel.Controls.Add(phoneNumberLabel)
                            employeePanel.Controls.Add(entryDateLabel)
                            employeePanel.Controls.Add(entryDateValueLabel)


                            ' Calculate the position of the employee panel based on the index
                            Dim panelYPosition As Integer = 10 + (130 * GetConductorPanelCount())
                            employeePanel.Location = New Point(10, panelYPosition)

                            ' Determine which panel to add the employee details to based on employee type
                            Dim employeeType As String = reader("employee_type").ToString()
                            If employeeType = "Driver" Then
                                DriversListPanel.Controls.Add(employeePanel)
                            ElseIf employeeType = "Conductor" Then
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
    End Sub


    Private Function GetConductorPanelCount() As Integer
        Return ConductorListPanel.Controls.OfType(Of Panel)().Count()
    End Function

    Private Sub ClearEmployeePanels()
        DriversListPanel.Controls.Clear()
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
End Class
