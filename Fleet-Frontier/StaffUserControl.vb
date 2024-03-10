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
            openedAddStaffForm.Owner = FindForm()
            ' Subscribe to the LocationChanged event of Form1
            AddHandler openedAddStaffForm.Owner.LocationChanged, AddressOf MainForm_LocationChanged
            ' Center the AddStaffForm relative to Form1
            CenterFormRelativeToMainForm(openedAddStaffForm)
            openedAddStaffForm.Show()
        End If
    End Sub

    ' Event handler for the LocationChanged event of Form1
    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs)
        ' Center the AddStaffForm relative to Form1 whenever Form1's location changes
        CenterFormRelativeToMainForm(openedAddStaffForm)
    End Sub

    ' Method to center the AddStaffForm relative to Form1
    Private Sub CenterFormRelativeToMainForm(form As Form)
        If form IsNot Nothing AndAlso form.Owner IsNot Nothing Then
            Dim mainFormCenterX As Integer = form.Owner.Location.X + (form.Owner.Width - form.Width) \ 2
            Dim mainFormCenterY As Integer = form.Owner.Location.Y + (form.Owner.Height - form.Height) \ 2
            form.Location = New Point(mainFormCenterX, mainFormCenterY)
        End If
    End Sub
End Class