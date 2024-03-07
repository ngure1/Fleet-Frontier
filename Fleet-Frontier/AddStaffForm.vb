Public Class AddStaffForm
    Private Sub AddStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub

    Private Sub AddStaffCloseButton_Click(sender As Object, e As EventArgs) Handles AddStaffCloseButton.Click
        Me.Hide()
    End Sub
End Class