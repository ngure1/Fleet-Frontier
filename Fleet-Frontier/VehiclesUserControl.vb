Public Class VehiclesUserControl
    Private Sub AddVehicleButton_Click(sender As Object, e As EventArgs) Handles AddVehicleButton.Click
        Dim AddVehicleForm As New AddVehicle
        AddVehicleForm.Show()
    End Sub

End Class
