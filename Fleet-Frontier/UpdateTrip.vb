Public Class UpdateTrip
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub CancelTripButton_Click(sender As Object, e As EventArgs) Handles CancelTripButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TripFromComboBox.SelectedIndex = -1
        TripFromComboBox.Text = ""
        TripToComboBox.SelectedIndex = -1
        TripToComboBox.Text = ""
        VehicleComboBox.SelectedIndex = -1
        VehicleComboBox.Text = ""
        DriverComboBox.SelectedIndex = -1
        DriverComboBox.Text = ""
        ConductorComboBox.SelectedIndex = -1
        ConductorComboBox.Text = ""
    End Sub

    Private Sub StartTripButton_Click(sender As Object, e As EventArgs) Handles StartTripButton.Click
        TripFromComboBox.SelectedIndex = -1
        TripFromComboBox.Text = ""
        TripToComboBox.SelectedIndex = -1
        TripToComboBox.Text = ""
        VehicleComboBox.SelectedIndex = -1
        VehicleComboBox.Text = ""
        DriverComboBox.SelectedIndex = -1
        DriverComboBox.Text = ""
        ConductorComboBox.SelectedIndex = -1
        ConductorComboBox.Text = ""

        TripFromComboBox.Focus()
    End Sub
End Class