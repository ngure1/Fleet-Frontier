Public Class StaffUserControl
    ' Declare a shared variable to store the reference to the opened form
    Public openedAddStaffForm As AddStaffForm = Nothing

    Private Sub AddStaffButton_Click(sender As Object, e As EventArgs) Handles AddStaffButton.Click
        ' Check if the form is already open and not disposed
        If openedAddStaffForm IsNot Nothing AndAlso Not openedAddStaffForm.IsDisposed Then
            ' If open, bring the existing form to the front
            openedAddStaffForm.BringToFront()
        Else
            ' If not open, create a new instance of the form
            openedAddStaffForm = New AddStaffForm()
            openedAddStaffForm.Show()
        End If
    End Sub
End Class
