Public Class TripsUserControl
    Private Sub AddTripsButton_Click(sender As Object, e As EventArgs) Handles AddTripsButton.Click
        Dim AddTripsForm As New CreateTrip
        AddTripsForm.Show()
    End Sub
End Class
