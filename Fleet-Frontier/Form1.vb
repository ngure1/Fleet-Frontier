Imports System.Runtime.CompilerServices

Public Class MainForm
    Private HomePageUserControl As HomePageUserControl
    Private VehiclesUserControl As VehiclesUserControl
    Private StaffUserControl As StaffUserControl
    Private TripsUserControl As TripsUserControl
    Private RentingUserControl As RentingUserControl

    Private CurrentUserControl As UserControl

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Instantiate user controls
        VehiclesUserControl = New VehiclesUserControl()
        StaffUserControl = New StaffUserControl()
        TripsUserControl = New TripsUserControl()
        HomePageUserControl = New HomePageUserControl()
        RentingUserControl = New RentingUserControl()


        ' Show VehicleUserControl initially
        CurrentUserControl = HomePageUserControl
        AddUserControlToPanel(CurrentUserControl)
    End Sub

    Private Sub AddUserControlToPanel(userControl As UserControl)
        ' Remove the current user control from the panel
        BodyPanel.Controls.Clear()

        ' Add the desired user control to the panel
        BodyPanel.Controls.Add(userControl)
        userControl.Dock = DockStyle.Fill
    End Sub



    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        System.Windows.Forms.Application.Exit()

    End Sub

    Private Sub minimizeButton_Click(sender As Object, e As EventArgs) Handles minimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub VehicleButton_Click(sender As Object, e As EventArgs) Handles VehicleButton.Click

        CurrentUserControl = VehiclesUserControl

        ' Switch between user controls
        AddUserControlToPanel(CurrentUserControl)

    End Sub

    Private Sub tripButton_Click(sender As Object, e As EventArgs) Handles tripButton.Click
        CurrentUserControl = TripsUserControl

        ' Switch between user controls
        AddUserControlToPanel(CurrentUserControl)
    End Sub

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        CurrentUserControl = HomePageUserControl

        ' Switch between user controls
        AddUserControlToPanel(CurrentUserControl)
    End Sub

    Private Sub StaffButton_Click(sender As Object, e As EventArgs) Handles StaffButton.Click
        CurrentUserControl = StaffUserControl

        ' Switch between user controls
        AddUserControlToPanel(CurrentUserControl)
    End Sub

    Private Sub rentButton_Click(sender As Object, e As EventArgs) Handles rentButton.Click
        CurrentUserControl = RentingUserControl

        ' Switch between user controls
        AddUserControlToPanel(CurrentUserControl)
    End Sub
End Class
