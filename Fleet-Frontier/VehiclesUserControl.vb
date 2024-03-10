Public Class VehiclesUserControl
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

End Class