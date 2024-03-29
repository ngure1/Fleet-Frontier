Imports MySql.Data.MySqlClient

Public Class UpdateVehicle
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NumberPlateTextBox.Text = ""
        FuelTextBox.Text = ""
        AvailabilityComboBox.SelectedIndex = -1
        AvailabilityComboBox.Text = ""
    End Sub

    Private Sub CancelVehicleButton_Click(sender As Object, e As EventArgs) Handles CancelVehicleButton.Click
        Me.Close()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateVehicleButton_Click(sender As Object, e As EventArgs) Handles UpdateVehicleButton.Click
        ' Get updated vehicle details from form fields
        Dim updatedNumberPlate As String = NumberPlateTextBox.Text
        Dim updatedFuelCost As String = FuelTextBox.Text
        Dim updatedAvailability As String = AvailabilityComboBox.Text

        ' Update vehicle details in the database
        Try
            Using connection As New MySqlConnection(ConnectionString)
                connection.Open()
                Dim query As String = "UPDATE vehicle SET numberPlate = @numberPlate, `fuel_cost/km` = @fuelCost, is_available = @availability WHERE vehicle_id = @vehicleId;"

                Dim isAvailableValue As Integer = If(updatedAvailability.ToLower() = "true", 1, 0)

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@numberPlate", updatedNumberPlate)
                    command.Parameters.AddWithValue("@fuelCost", updatedFuelCost)
                    command.Parameters.AddWithValue("@availability", isAvailableValue)
                    ' You need to provide the vehicle ID here based on your application logic
                    ' For example, you can pass the vehicle ID to the UpdateVehicle form constructor
                    ' and store it in a private variable to use it here.
                    ' For demonstration purposes, let's assume the vehicle ID is stored in a private variable called _vehicleId
                    command.Parameters.AddWithValue("@vehicleId", _vehicleId)


                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Display success message
                        MessageBox.Show("Vehicle details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' Display error message if no rows were affected
                        MessageBox.Show("Failed to update vehicle details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Display error message if an exception occurs
            MessageBox.Show("An error occurred while updating vehicle details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Clear form fields
        NumberPlateTextBox.Text = ""
        FuelTextBox.Text = ""
        AvailabilityComboBox.SelectedIndex = -1
        AvailabilityComboBox.Text = ""

        ' Return focus to the first textbox
        NumberPlateTextBox.Focus()
    End Sub



    Private _vehicleId As String
    Private _vehicleDetails As Dictionary(Of String, String)

    Public Sub New(vehicleId As String, vehicleDetails As Dictionary(Of String, String))
        InitializeComponent()

        ' Store the provided vehicle ID and details
        _vehicleId = vehicleId
        _vehicleDetails = vehicleDetails

        ' Populate form fields with the provided vehicle details
        PopulateFormFields()
    End Sub

    Private Sub PopulateFormFields()
        ' Populate form fields with the stored vehicle details
        If _vehicleDetails.ContainsKey("number_plate") Then
            NumberPlateTextBox.Text = _vehicleDetails("number_plate")
        End If

        If _vehicleDetails.ContainsKey("fuel_cost") Then
            FuelTextBox.Text = _vehicleDetails("fuel_cost")
        End If

        If _vehicleDetails.ContainsKey("is_available") Then
            AvailabilityComboBox.Text = _vehicleDetails("is_available")
        End If
    End Sub
End Class