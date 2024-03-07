Public Class StaffUserControl
    Private Sub AddStaffButton_Click(sender As Object, e As EventArgs) Handles AddStaffButton.Click
        Dim AddStaffForm As New AddStaffForm
        AddStaffForm.Show()
    End Sub
End Class
