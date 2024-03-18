Public Class UpdateVehicle
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

        'Clearing the textboxes after successful adding a new vehicle
        NumberPlateTextBox.Text = ""
        FuelTextBox.Text = ""
        AvailabilityComboBox.SelectedIndex = -1
        AvailabilityComboBox.Text = ""

        'Returning the cursor to the first textbox
        NumberPlateTextBox.Focus()
    End Sub
End Class