Imports System.Runtime.CompilerServices

Public Class MainForm
    Private HomePageUserControl As HomePageUserControl
    Private VehiclesUserControl As VehiclesUserControl

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Instantiate the user controls
        HomePageUserControl = New HomePageUserControl()
        VehiclesUserControl = New VehiclesUserControl()

        ' Show UserControl1 initially
        Me.Controls.Add(HomePageUserControl)

        ' Hide UserControl2 initially
        VehiclesUserControl.Hide()
    End Sub





    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        System.Windows.Forms.Application.Exit()

    End Sub

    Private Sub minimizeButton_Click(sender As Object, e As EventArgs) Handles minimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
