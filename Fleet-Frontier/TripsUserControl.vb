Imports MySql.Data.MySqlClient

Public Class TripsUserControl
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    ' Declare a shared variable to store the reference to the opened form
    Public openedCreateTripForm As CreateTrip = Nothing
    Private Sub AddTripsButton_Click(sender As Object, e As EventArgs) Handles AddTripsButton.Click
        ' Check if the form is already open and not disposed
        If openedCreateTripForm IsNot Nothing AndAlso Not openedCreateTripForm.IsDisposed Then
            ' If open, bring the existing form to the front
            openedCreateTripForm.BringToFront()
        Else
            ' If not open, create a new instance of the form
            openedCreateTripForm = New CreateTrip()
            openedCreateTripForm.Show()
        End If
    End Sub


    Private Sub TripsUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTrips()
    End Sub

    Private Sub LoadTrips()
        ClearTripPanels()

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            Dim query As String = "SELECT " &
    "t.trip_id, " &
    "t.trip_from, " &
    "t.trip_to, " &
    "t.trip_No, " &
    "t.trip_start_time, " &
    "d.employee_id AS driver_id, " &
    "d.employee_name AS driver_name, " &
    "c.employee_id AS conductor_id, " &
    "c.employee_name AS conductor_name " &
"FROM " &
    "trip t " &
"JOIN " &
    "trip_employee ted ON t.trip_id = ted.trip_id " &
"JOIN " &
    "employee d ON ted.employee_id = d.employee_id AND d.employee_type = 'Driver' " &
"JOIN " &
    "trip_employee tec ON t.trip_id = tec.trip_id " &
"JOIN " &
    "employee c ON tec.employee_id = c.employee_id AND c.employee_type = 'Conductor';"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim tripPanel As New Panel()
                        tripPanel.BorderStyle = BorderStyle.FixedSingle
                        tripPanel.Size = New Size(400, 200)

                        Dim fromLabel As New Label()
                        fromLabel.Text = "From: " & reader("trip_from").ToString()
                        fromLabel.Location = New Point(10, 10)

                        Dim toLabel As New Label()
                        toLabel.Text = "To: " & reader("trip_to").ToString()
                        toLabel.Location = New Point(10, 30)

                        Dim tripNoLabel As New Label()
                        tripNoLabel.Text = "Trip No: " & reader("trip_No").ToString()
                        tripNoLabel.Location = New Point(10, 50)

                        Dim startTimeLabel As New Label()
                        startTimeLabel.Text = "Start Time: "
                        startTimeLabel.Location = New Point(10, 70)

                        Dim startTimeValueLabel As New Label()
                        startTimeValueLabel.Text = reader("trip_start_time").ToString()
                        startTimeValueLabel.Location = New Point(120, 70)

                        Dim driverNameLabel As New Label()
                        driverNameLabel.Text = "Driver Name: "
                        driverNameLabel.Location = New Point(10, 90)

                        Dim driverNameValueLabel As New Label()
                        driverNameValueLabel.Text = reader("driver_name").ToString()
                        driverNameValueLabel.Location = New Point(120, 90)

                        Dim conductorIdLabel As New Label()
                        conductorIdLabel.Text = "Conductor ID: " & reader("conductor_id").ToString()
                        conductorIdLabel.Location = New Point(10, 110)

                        Dim conductorNameLabel As New Label()
                        conductorNameLabel.Text = "Donda's Name:"
                        conductorNameLabel.Location = New Point(10, 130)

                        Dim conductorNameValueLabel As New Label()
                        conductorNameValueLabel.Text = reader("conductor_name").ToString()
                        conductorNameValueLabel.Location = New Point(120, 130)

                        Dim updateButton As New Button()
                        updateButton.Text = "Update"
                        updateButton.Location = New Point(300, 10)
                        ' Add click event handler for update button

                        Dim deleteButton As New Button()
                        deleteButton.Text = "Delete"
                        deleteButton.Location = New Point(300, 40)
                        ' Add click event handler for delete button

                        tripPanel.Controls.Add(fromLabel)
                        tripPanel.Controls.Add(toLabel)
                        tripPanel.Controls.Add(tripNoLabel)
                        tripPanel.Controls.Add(startTimeLabel)
                        tripPanel.Controls.Add(startTimeValueLabel)
                        tripPanel.Controls.Add(driverNameLabel)
                        tripPanel.Controls.Add(driverNameValueLabel)
                        tripPanel.Controls.Add(conductorIdLabel)
                        tripPanel.Controls.Add(conductorNameLabel)
                        tripPanel.Controls.Add(conductorNameValueLabel)
                        tripPanel.Controls.Add(updateButton)
                        tripPanel.Controls.Add(deleteButton)

                        ' Calculate the position of the tripPanel based on the index
                        Dim panelYPosition As Integer = 10 + (210 * TripsBodyPanel.Controls.Count)
                        tripPanel.Location = New Point(10, panelYPosition)

                        TripsBodyPanel.Controls.Add(tripPanel) ' Add tripPanel to TripsBodyPanel
                    End While

                End Using
            End Using
        End Using
    End Sub

    Private Sub ClearTripPanels()
        TripsBodyPanel.Controls.Clear() ' Clear all controls from TripsBodyPanel
    End Sub

    ' Event handlers for Update and Delete buttons can be implemented here

    Public Sub RefreshTripPanels()
        ClearTripPanels()
        LoadTrips()
    End Sub

    Private Sub AddOrUpdateTrip()
        ' Your code to add or update a trip in the MySQL database goes here
        ' After adding or updating, call RefreshTripPanels() to refresh the display
        RefreshTripPanels()
    End Sub
End Class
