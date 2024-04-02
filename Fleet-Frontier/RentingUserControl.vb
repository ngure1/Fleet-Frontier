Imports MySql.Data.MySqlClient

Public Class RentingUserControl
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    Private openedAddRentalForm As AddRentalForm
    Private Sub NewRentalButton_Click(sender As Object, e As EventArgs) Handles NewRentalButton.Click
        ' Check if the form is already open and not disposed
        If openedAddRentalForm IsNot Nothing AndAlso Not openedAddRentalForm.IsDisposed Then
            ' If open, bring the existing form to the front
            openedAddRentalForm.BringToFront()
        Else
            ' If not open, create a new instance of the form
            openedAddRentalForm = New AddRentalForm()
            openedAddRentalForm.Owner = FindForm()
            ' Subscribe to the LocationChanged event of the parent form
            AddHandler openedAddRentalForm.Owner.LocationChanged, AddressOf RentalUserControl_LocationChanged
            ' Center the AddRentalForm relative to the parent form
            CenterFormRelativeToParent(openedAddRentalForm)
            openedAddRentalForm.Show()
        End If
    End Sub

    Private Sub RentalUserControl_LocationChanged(sender As Object, e As EventArgs)
        ' When the location of the parent form changes, re-center the AddRentalForm
        CenterFormRelativeToParent(openedAddRentalForm)
    End Sub

    Private Sub CenterFormRelativeToParent(form As Form)
        ' Center the form relative to the parent form
        form.Location = New Point(Me.Location.X + (Me.Width - form.Width) \ 2, Me.Location.Y + (Me.Height - form.Height) \ 2)
    End Sub

    Private Sub LoadRentals()
        ClearRentalPanels()

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            Dim query As String = "SELECT " &
                "h.hire_id, " &
                "h.customer_name, " &
                "h.customer_phone_number, " &
                "h.is_returned, " &
                "v.numberPlate AS vehicle_number_plate " &
            "FROM " &
                "hire h " &
            "JOIN " &
                "vehicle v ON h.vehicle_id = v.vehicle_id;"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim rentalPanel As New Panel()
                        rentalPanel.BorderStyle = BorderStyle.FixedSingle
                        rentalPanel.Size = New Size(400, 100)

                        ' Customer Name Label
                        Dim customerNameHeaderLabel As New Label()
                        customerNameHeaderLabel.Text = "Customer Name:"
                        customerNameHeaderLabel.Location = New Point(10, 10)

                        Dim customerNameValueLabel As New Label()
                        customerNameValueLabel.Text = reader("customer_name").ToString()
                        customerNameValueLabel.Location = New Point(150, 10)

                        ' Phone Number Label
                        Dim phoneNumberHeaderLabel As New Label()
                        phoneNumberHeaderLabel.Text = "Phone Number:"
                        phoneNumberHeaderLabel.Location = New Point(10, 30)

                        Dim phoneNumberValueLabel As New Label()
                        phoneNumberValueLabel.Text = reader("customer_phone_number").ToString()
                        phoneNumberValueLabel.Location = New Point(150, 30)

                        ' Vehicle Number Plate Label
                        Dim vehicleNumberPlateHeaderLabel As New Label()
                        vehicleNumberPlateHeaderLabel.Text = "Vehicle Number Plate:"
                        vehicleNumberPlateHeaderLabel.Location = New Point(10, 50)

                        Dim vehicleNumberPlateValueLabel As New Label()
                        vehicleNumberPlateValueLabel.Text = reader("vehicle_number_plate").ToString()
                        vehicleNumberPlateValueLabel.Location = New Point(150, 50)

                        ' Rental Status Label
                        Dim rentalStatusHeaderLabel As New Label()
                        rentalStatusHeaderLabel.Text = "Rental Status:"
                        rentalStatusHeaderLabel.Location = New Point(10, 70)

                        Dim rentalStatusValueLabel As New Label()
                        Dim rentalStatus As String = If(Convert.ToBoolean(reader("is_returned")), "Returned", "Not Returned")
                        rentalStatusValueLabel.Text = rentalStatus
                        rentalStatusValueLabel.Location = New Point(150, 70)

                        ' Buttons
                        Dim updateButton As New Button()
                        updateButton.Text = "Update"
                        updateButton.Location = New Point(300, 10)
                        updateButton.Size = New Size(80, 30)

                        ' Add click event handler for update button
                        Dim hireId As String = reader("hire_id") ' You need to set the hire ID accordingly
                        AddHandler updateButton.Click, Sub(sender As Object, e As EventArgs)
                                                           UpdateRentalButton_Click(sender, e, hireId)
                                                       End Sub

                        Dim deleteButton As New Button()
                        deleteButton.Text = "Delete"
                        deleteButton.Location = New Point(300, 60)
                        deleteButton.Size = New Size(80, 30)
                        deleteButton.Tag = reader("hire_id").ToString() ' Store hire ID as Tag
                        AddHandler deleteButton.Click, AddressOf DeleteRentalButton_Click

                        ' Add labels and buttons to the rental panel
                        rentalPanel.Controls.Add(customerNameHeaderLabel)
                        rentalPanel.Controls.Add(customerNameValueLabel)
                        rentalPanel.Controls.Add(phoneNumberHeaderLabel)
                        rentalPanel.Controls.Add(phoneNumberValueLabel)
                        rentalPanel.Controls.Add(vehicleNumberPlateHeaderLabel)
                        rentalPanel.Controls.Add(vehicleNumberPlateValueLabel)
                        rentalPanel.Controls.Add(rentalStatusHeaderLabel)
                        rentalPanel.Controls.Add(rentalStatusValueLabel)
                        rentalPanel.Controls.Add(updateButton)
                        rentalPanel.Controls.Add(deleteButton)


                        ' Calculate the position of the rentalPanel based on the index
                        Dim panelYPosition As Integer = 10 + (110 * RentalsBodyPanel.Controls.Count)
                        rentalPanel.Location = New Point(10, panelYPosition)

                        RentalsBodyPanel.Controls.Add(rentalPanel) ' Add rentalPanel to RentalsBodyPanel
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub ClearRentalPanels()
        ' Clear all rental panels from the RentalsBodyPanel
        RentalsBodyPanel.Controls.Clear()
    End Sub
    Private Sub RefreshRentalPanels()
        ' Clear all rental panels from the RentalsBodyPanel
        ClearRentalPanels()
        LoadRentals()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RefreshRentalPanels()
    End Sub

    Private Sub DeleteRentalButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim rentalId As String = button.Tag.ToString()

        ' Prompt for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this rental?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            ' Perform deletion from the database
            Try
                Using connection As New MySqlConnection(ConnectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM hire WHERE hire_id = @rentalId"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@rentalId", rentalId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Remove the rental panel from its parent
                            Dim panel As Panel = CType(button.Parent, Panel)
                            panel.Parent.Controls.Remove(panel)

                            ' Refresh the rental panels
                            RefreshRentalPanels()

                            MessageBox.Show("Rental deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to delete rental.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting rental: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub RentingUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRentals()
    End Sub

    Private Sub UpdateRentalButton_Click(sender As Object, e As EventArgs, hireId As String)
        ' Fetch rental details based on hireId
        Dim rentalDetails As New Dictionary(Of String, String)()
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Dim query As String = "SELECT " &
            "h.hire_id, " &
            "h.vehicle_id, " &
            "h.customer_name, " &
            "h.customer_phone_number, " &
            "h.is_returned, " &
            "v.numberPlate " &
        "FROM " &
            "hire h " &
        "JOIN " &
            "vehicle v ON h.vehicle_id = v.vehicle_id " &
        "WHERE " &
            "h.hire_id = @hireId;"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@hireId", hireId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        rentalDetails.Add("vehicle_id", reader("vehicle_id").ToString())
                        rentalDetails.Add("customer_name", reader("customer_name").ToString())
                        rentalDetails.Add("customer_phone_number", reader("customer_phone_number").ToString())
                        rentalDetails.Add("is_returned", reader("is_returned").ToString())
                        rentalDetails.Add("vehicle_number_plate", reader("numberPlate").ToString()) ' Add vehicle ID
                        ' Add other rental details as needed
                    End If
                End Using
            End Using
        End Using
        ' Open UpdateRental form and pass rental details
        Dim updateRentalForm As New UpdateRental(hireId, rentalDetails)
        updateRentalForm.ShowDialog()
    End Sub

End Class
