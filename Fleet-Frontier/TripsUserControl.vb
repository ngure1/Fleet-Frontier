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
            openedCreateTripForm.Owner = FindForm()
            ' Subscribe to the LocationChanged event of Form1
            AddHandler openedCreateTripForm.Owner.LocationChanged, AddressOf MainForm_LocationChanged
            ' Center the CreateTrip form relative to Form1
            CenterFormRelativeToMainForm(openedCreateTripForm)
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
            "t.trip_start_time, " &
            "t.has_arrived, " &
            "d.employee_id AS driver_id, " &
            "d.employee_name AS driver_name, " &
            "c.employee_id AS conductor_id, " &
            "c.employee_name AS conductor_name, " &
            "v.numberPlate AS vehicle_number_plate " &
            "FROM " &
            "trip t " &
            "JOIN " &
            "trip_employee ted ON t.trip_id = ted.trip_id " &
            "JOIN " &
            "employee d ON ted.employee_id = d.employee_id AND d.employee_type = 'Driver' " &
            "JOIN " &
            "trip_employee tec ON t.trip_id = tec.trip_id " &
            "JOIN " &
            "employee c ON tec.employee_id = c.employee_id AND c.employee_type = 'Conductor' " &
            "JOIN " &
            "vehicle v ON t.vehicle_id = v.vehicle_id"
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

                        Dim startTimeLabel As New Label()
                        startTimeLabel.Text = "Start Time: "
                        startTimeLabel.Location = New Point(10, 50)

                        Dim startTimeValueLabel As New Label()
                        startTimeValueLabel.Text = reader("trip_start_time").ToString()
                        startTimeValueLabel.Location = New Point(120, 50)

                        Dim driverIdLabel As New Label()
                        driverIdLabel.Text = "Driver Id: " & reader("driver_id").ToString()
                        driverIdLabel.Location = New Point(10, 70)

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

                        Dim vehicleLabel As New Label()
                        vehicleLabel.Text = "Vehicle: " & reader("vehicle_number_plate").ToString() ' Display vehicle number plate
                        vehicleLabel.Location = New Point(10, 150)

                        Dim hasArrivedLabel As New Label()
                        hasArrivedLabel.Text = "Status: " & reader("has_arrived").ToString()
                        hasArrivedLabel.Location = New Point(10, 170)

                        Dim statusDot As New Label()
                        statusDot.AutoSize = True
                        statusDot.Location = New Point(120, 170)
                        statusDot.Font = New Font(statusDot.Font, FontStyle.Bold)

                        ' Check if the trip has arrived
                        Dim hasArrived As Integer = reader("has_arrived")
                        If hasArrived Then
                            statusDot.Text = "Complete"
                            statusDot.ForeColor = Color.Green
                        Else
                            statusDot.Text = "In transit"
                            statusDot.ForeColor = Color.Red
                        End If

                        Dim updateButton As New Button()
                        updateButton.Text = "Update"
                        updateButton.Location = New Point(300, 10)
                        Dim tripId As String = reader("trip_id").ToString()
                        AddHandler updateButton.Click, Sub(sender As Object, e As EventArgs)
                                                           UpdateButton_Click(sender, e, tripId)
                                                       End Sub



                        Dim deleteButton As New Button()
                        deleteButton.Text = "Delete"
                        deleteButton.Location = New Point(300, 160)
                        deleteButton.Tag = reader("trip_id").ToString() ' Store trip ID as Tag
                        AddHandler deleteButton.Click, AddressOf DeleteButton_Click


                        tripPanel.Controls.Add(fromLabel)
                        tripPanel.Controls.Add(toLabel)
                        tripPanel.Controls.Add(startTimeLabel)
                        tripPanel.Controls.Add(startTimeValueLabel)
                        tripPanel.Controls.Add(driverIdLabel)
                        tripPanel.Controls.Add(driverNameLabel)
                        tripPanel.Controls.Add(driverNameValueLabel)
                        tripPanel.Controls.Add(conductorIdLabel)
                        tripPanel.Controls.Add(conductorNameLabel)
                        tripPanel.Controls.Add(conductorNameValueLabel)
                        tripPanel.Controls.Add(vehicleLabel)
                        tripPanel.Controls.Add(hasArrivedLabel)
                        tripPanel.Controls.Add(statusDot)
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
    ' Add this handler to handle the delete button click
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim tripId As String = button.Tag.ToString()

        ' Prompt for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this trip?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            ' Perform deletion from the database
            Try
                Using connection As New MySqlConnection(ConnectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM trip WHERE trip_id = @tripId"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@tripId", tripId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Remove the trip panel from its parent
                            Dim panel As Panel = CType(button.Parent, Panel)
                            panel.Parent.Controls.Remove(panel)

                            ' Refresh the trip panels
                            RefreshTripPanels()

                            MessageBox.Show("Trip deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Failed to delete trip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting trip: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Event handler for the LocationChanged event of Form1
    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs)
        ' Center the CreateTrip form relative to Form1 whenever Form1's location changes
        CenterFormRelativeToMainForm(openedCreateTripForm)
    End Sub

    ' Method to center the CreateTrip form relative to Form1
    Private Sub CenterFormRelativeToMainForm(form As Form)
        If form IsNot Nothing AndAlso form.Owner IsNot Nothing Then
            Dim mainFormCenterX As Integer = form.Owner.Location.X + (form.Owner.Width - form.Width) \ 2
            Dim mainFormCenterY As Integer = form.Owner.Location.Y + (form.Owner.Height - form.Height) \ 2
            form.Location = New Point(mainFormCenterX, mainFormCenterY)
        End If

    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RefreshTripPanels()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs, tripId As String)
        ' Fetch trip details based on tripId
        Dim tripDetails As New Dictionary(Of String, String)()
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Dim query As String = "SELECT " &
                "t.trip_id, " &
                "t.trip_from, " &
                "t.trip_to, " &
                "t.has_arrived, " &
                "v.vehicle_id, " &
                "v.numberPlate, " &
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
                "employee c ON tec.employee_id = c.employee_id AND c.employee_type = 'Conductor' " &
            "JOIN " &
                "vehicle v ON t.vehicle_id = v.vehicle_id " &
            "WHERE " &
                "t.trip_id = @tripId;"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@tripId", tripId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        tripDetails.Add("trip_from", reader("trip_from").ToString())
                        tripDetails.Add("trip_to", reader("trip_to").ToString())
                        tripDetails.Add("has_arrived", reader("has_arrived").ToString())
                        tripDetails.Add("driver_id", reader("driver_id").ToString())
                        tripDetails.Add("driver_name", reader("driver_name").ToString())
                        tripDetails.Add("conductor_id", reader("conductor_id").ToString())
                        tripDetails.Add("conductor_name", reader("conductor_name").ToString())
                        tripDetails.Add("vehicle_id", reader("vehicle_id").ToString())
                        tripDetails.Add("vehicle_number_plate", reader("numberPlate").ToString()) ' Add vehicle ID
                        ' Add other trip details as needed
                    End If
                End Using
            End Using
        End Using
        ' Open UpdateTrip form and pass trip details
        Dim updateTripForm As New UpdateTrip(tripId, tripDetails)
        updateTripForm.ShowDialog()
    End Sub

End Class
