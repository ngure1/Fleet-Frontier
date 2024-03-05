Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub minimizeButton_Click(sender As Object, e As EventArgs) Handles minimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub vehicleButton_Click(sender As Object, e As EventArgs) Handles vehicleButton.Click
        vehicleMenu.Show(vehicleButton, 0, vehicleButton.Height)
    End Sub

    Private Sub staffButton_Click(sender As Object, e As EventArgs) Handles staffButton.Click
        staffMenu.Show(staffButton, 0, staffButton.Height)
    End Sub


End Class
