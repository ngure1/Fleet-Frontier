Public Class UpdateStaff
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CancelStaffButton_Click(sender As Object, e As EventArgs) Handles CancelStaffButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        PhoneNumberTextBox.Text = ""
        TypeComboBox.SelectedIndex = -1
        TypeComboBox.Text = ""
        AvailabilityComboBox.SelectedIndex = -1
        AvailabilityComboBox.Text = ""
    End Sub

    Private Sub AddStaffConfirmButton_Click(sender As Object, e As EventArgs) Handles AddStaffConfirmButton.Click
        'Clearing the textboxes after successful adding a new vehicle
        NameTextBox.Text = ""
        PhoneNumberTextBox.Text = ""
        TypeComboBox.SelectedIndex = -1
        TypeComboBox.Text = ""
        AvailabilityComboBox.SelectedIndex = -1
        AvailabilityComboBox.Text = ""

        'Returning the cursor to the first textbox
        NameTextBox.Focus()
    End Sub
End Class