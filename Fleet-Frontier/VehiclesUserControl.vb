Imports MySql.Data.MySqlClient

Public Class VehiclesUserControl
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"

    ' Declare a shared variable to store the reference to the opened form
    Public openedAddVehicleForm As AddVehicle = Nothing
    Private Sub AddVehicleButton_Click(sender As Object, e As EventArgs) Handles AddVehicleButton.Click
        If openedAddVehicleForm IsNot Nothing AndAlso Not openedAddVehicleForm.IsDisposed Then
            ' If open, bring the existing form to the front
            openedAddVehicleForm.BringToFront()
        Else
            ' If not open, create a new instance of the form
            openedAddVehicleForm = New AddVehicle()
            ' Set the owner of AddVehicle form to Form1
            openedAddVehicleForm.Owner = FindForm()
            ' Subscribe to the LocationChanged event of Form1
            AddHandler openedAddVehicleForm.Owner.LocationChanged, AddressOf MainForm_LocationChanged
            ' Center the AddVehicle form relative to Form1
            CenterFormRelativeToMainForm(openedAddVehicleForm)
            openedAddVehicleForm.Show()
        End If
    End Sub

    ' Event handler for the LocationChanged event of Form1
    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs)
        ' Center the AddVehicle form relative to Form1 whenever Form1's location changes
        CenterFormRelativeToMainForm(openedAddVehicleForm)
    End Sub

    ' Method to center the AddVehicle form relative to Form1
    Private Sub CenterFormRelativeToMainForm(form As Form)
        If form IsNot Nothing AndAlso form.Owner IsNot Nothing Then
            Dim mainFormCenterX As Integer = form.Owner.Location.X + (form.Owner.Width - form.Width) \ 2
            Dim mainFormCenterY As Integer = form.Owner.Location.Y + (form.Owner.Height - form.Height) \ 2
            form.Location = New Point(mainFormCenterX, mainFormCenterY)
        End If
    End Sub


    Private Sub VehiclesUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVehicles()
    End Sub

    Private Sub LoadVehicles()
        ClearVehiclePanels()

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM vehicle"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim vehiclePanel As New Panel()
                        vehiclePanel.BorderStyle = BorderStyle.FixedSingle
                        vehiclePanel.Size = New Size(400, 150)

                        Dim numberPlateLabel As New Label()
                        numberPlateLabel.Text = "Number Plate:"
                        numberPlateLabel.Location = New Point(10, 10)

                        Dim numberPlateValueLabel As New Label()
                        numberPlateValueLabel.Text = reader("numberPlate").ToString()
                        numberPlateValueLabel.Location = New Point(130, 10) ' Adjust X position accordingly

                        Dim fuelCostLabel As New Label()
                        fuelCostLabel.Text = "Fuel Cost per km: $"
                        fuelCostLabel.Location = New Point(10, 30)

                        Dim fuelCostValueLabel As New Label()
                        fuelCostValueLabel.Text = reader("fuel_cost/km").ToString()
                        fuelCostValueLabel.Location = New Point(130, 30) ' Adjust X position accordingly

                        Dim availabilityLabel As New Label()
                        availabilityLabel.Text = "Availability:"
                        availabilityLabel.Location = New Point(10, 50)

                        Dim isAvailable As Boolean = Convert.ToBoolean(reader("is_available"))
                        Dim availabilityValueLabel As New Label()
                        availabilityValueLabel.Text = If(isAvailable, "Available", "Not Available")
                        availabilityValueLabel.Location = New Point(130, 50) ' Adjust X position accordingly


                        Dim updateButton As New Button()
                        updateButton.Text = "Update"
                        updateButton.Location = New Point(300, 10)
                        ' Add click event handler for update button

                        Dim deleteButton As New Button()
                        deleteButton.Text = "Delete"
                        deleteButton.Location = New Point(300, 70)
                        deleteButton.Tag = reader("vehicle_id").ToString() ' Store vehicle ID as Tag
                        AddHandler deleteButton.Click, AddressOf DeleteButton_Click


                        vehiclePanel.Controls.Add(numberPlateLabel)
                        vehiclePanel.Controls.Add(numberPlateValueLabel)
                        vehiclePanel.Controls.Add(fuelCostLabel)
                        vehiclePanel.Controls.Add(fuelCostValueLabel)
                        vehiclePanel.Controls.Add(availabilityLabel)
                        vehiclePanel.Controls.Add(availabilityValueLabel)
                        vehiclePanel.Controls.Add(updateButton)
                        vehiclePanel.Controls.Add(deleteButton)

                        ' Calculate the position of the vehiclePanel based on the index
                        Dim panelYPosition As Integer = 10 + (160 * VehicleBodypanel.Controls.Count)
                        vehiclePanel.Location = New Point(10, panelYPosition)

                        VehicleBodypanel.Controls.Add(vehiclePanel) ' Add vehiclePanel to VehicleBodypanel
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub ClearVehiclePanels()
        VehicleBodypanel.Controls.Clear() ' Clear all controls from VehicleBodypanel
    End Sub
    Public Sub RefreshVehiclePanels()
        ClearVehiclePanels()
        LoadVehicles()
    End Sub
    ' Add this handler to handle the delete button click
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim vehicleId As String = button.Tag.ToString()

        ' Prompt for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this vehicle?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            ' Perform deletion from the database
            Try
                Using connection As New MySqlConnection(ConnectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM vehicle WHERE vehicle_id = @vehicleId"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@vehicleId", vehicleId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Remove the vehicle panel from its parent
                            Dim panel As Panel = CType(button.Parent, Panel)
                            panel.Parent.Controls.Remove(panel)

                            ' Refresh the vehicle panels
                            RefreshVehiclePanels()

                            MessageBox.Show("Vehicle deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to delete vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting vehicle: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


End Class