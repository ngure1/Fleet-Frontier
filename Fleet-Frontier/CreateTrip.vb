Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class CreateTrip
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    Dim adapter As MySqlDataAdapter
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    '' Private _tripsUserControl As TripsUserControl

    'Public Sub New(tripsUserControl As TripsUserControl)
    '   InitializeComponent()
    '  _tripsUserControl = tripsUserControl
    'End Sub

    Private Sub PopulateVehicleComboBox()
        ' Fetch data for vehicles
        Dim vehicleQuery As String = "SELECT * FROM vehicle WHERE is_available > 0"
        adapter = New MySqlDataAdapter(vehicleQuery, connection)
        Dim vehicleTable As New DataTable()
        adapter.Fill(vehicleTable)

        ' Populate combo box with vehicle data
        For Each row As DataRow In vehicleTable.Rows
            Dim vehicleId As Integer = Convert.ToInt32(row("vehicle_id"))
            Dim numberPlate As String = row("numberPlate").ToString()
            Dim displayName As String = vehicleId.ToString() & " - " & numberPlate
            VehicleComboBox.Items.Add(displayName)
        Next
    End Sub
    Private Sub PopulateDriverComboBox()
        ' Fetch data for drivers
        Dim driverQuery As String = "SELECT * FROM employee WHERE employee_type = 'Driver' AND is_available > 0"
        adapter = New MySqlDataAdapter(driverQuery, connection)
        Dim driverTable As New DataTable()
        adapter.Fill(driverTable)

        ' Populate combo box with driver data
        For Each row As DataRow In driverTable.Rows
            Dim employeeId As Integer = Convert.ToInt32(row("employee_id"))
            Dim employeeName As String = row("employee_name").ToString()
            Dim displayName As String = employeeId.ToString() & " - " & employeeName
            DriverComboBox.Items.Add(displayName)
        Next
    End Sub
    Private Sub PopulateConductorComboBox()
        ' Fetch data for conductors
        Dim conductorQuery As String = "SELECT * FROM employee WHERE employee_type = 'Conductor' AND is_available > 0"
        adapter = New MySqlDataAdapter(conductorQuery, connection)
        Dim conductorTable As New DataTable()
        adapter.Fill(conductorTable)

        ' Populate combo box with conductor data
        For Each row As DataRow In conductorTable.Rows
            Dim employeeId As Integer = Convert.ToInt32(row("employee_id"))
            Dim employeeName As String = row("employee_name").ToString()
            Dim displayName As String = employeeId.ToString() & " - " & employeeName
            ConductorComboBox.Items.Add(displayName)
        Next
    End Sub
    Private Sub RefreshComboBoxes()
        'Clear the existing data in combo boxes
        VehicleComboBox.Items.Clear()
        DriverComboBox.Items.Clear()
        ConductorComboBox.Items.Clear()
        'Populate the combo boxes again
        PopulateVehicleComboBox()
        PopulateDriverComboBox()
        PopulateConductorComboBox()

    End Sub

    Private Sub CreateTrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to your database
        connection = New MySqlConnection(ConnectionString)
        Try
            connection.Open()
            PopulateVehicleComboBox()
            PopulateDriverComboBox()
            PopulateConductorComboBox()

            ' Data stored in an array for TripFrom
            Dim tripFromData As String() = {"Nairobi", "Thika", "Juja"}

            ' Populate TripFromComboBox with data from the array
            For Each location As String In tripFromData
                TripFromComboBox.Items.Add(location)
            Next

            Dim tripToData As String() = {"Nairobi", "Thika", "Juja"}

            ' Populate TripFromComboBox with data from the array
            For Each location As String In tripToData
                TripToComboBox.Items.Add(location)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub StartTripButton_Click(sender As Object, e As EventArgs) Handles StartTripButton.Click
        connection = New MySqlConnection(ConnectionString)
        Try
            connection.Open()
            ' Insert data into the trip table
            Dim vehicleId As Integer = Integer.Parse(VehicleComboBox.SelectedItem.ToString().Split("-"c)(0).Trim())
            Dim tripFrom As String = TripFromComboBox.SelectedItem.ToString()
            Dim tripTo As String = TripToComboBox.SelectedItem.ToString()
            Dim tripNo As Integer = 1 ' Assuming trip number is fixed for now
            Dim tripStartTime As DateTime = DateTime.Now ' Assuming trip start time is current time
            Dim hasArrived As Boolean = False ' Assuming trip hasn't arrived yet

            Dim tripInsertQuery As String = "INSERT INTO trip (vehicle_id, trip_from, trip_to, trip_No, trip_start_time, has_arrived) VALUES (@vehicleId, @tripFrom, @tripTo, @tripNo, @tripStartTime, @hasArrived); SELECT LAST_INSERT_ID();"
            command = New MySqlCommand(tripInsertQuery, connection)
            command.Parameters.AddWithValue("@vehicleId", vehicleId)
            command.Parameters.AddWithValue("@tripFrom", tripFrom)
            command.Parameters.AddWithValue("@tripTo", tripTo)
            command.Parameters.AddWithValue("@tripNo", tripNo)
            command.Parameters.AddWithValue("@tripStartTime", tripStartTime)
            command.Parameters.AddWithValue("@hasArrived", hasArrived)

            Dim tripId As Integer = Convert.ToInt32(command.ExecuteScalar()) ' Get the generated trip_id

            ' Insert data into the trip_employee table
            Dim driverId As Integer = Integer.Parse(DriverComboBox.SelectedItem.ToString().Split("-"c)(0).Trim())
            Dim conductorId As Integer = Integer.Parse(ConductorComboBox.SelectedItem.ToString().Split("-"c)(0).Trim())

            Dim tripEmployeeInsertQuery As String = "INSERT INTO trip_employee (trip_id, employee_id) VALUES (@tripId, @driverId), (@tripId, @conductorId);"
            command = New MySqlCommand(tripEmployeeInsertQuery, connection)
            command.Parameters.AddWithValue("@tripId", tripId)
            command.Parameters.AddWithValue("@driverId", driverId)
            command.Parameters.AddWithValue("@conductorId", conductorId)
            command.ExecuteNonQuery()

            ' Update vehicle, driver, and conductor availability to False
            Dim updateAvailabilityQuery As String = "UPDATE vehicle SET is_available = 0 WHERE vehicle_id = @vehicleId;" &
                                                "UPDATE employee SET is_available = 0 WHERE employee_id IN (@driverId, @conductorId);"
            command = New MySqlCommand(updateAvailabilityQuery, connection)
            command.Parameters.AddWithValue("@vehicleId", vehicleId)
            command.Parameters.AddWithValue("@driverId", driverId)
            command.Parameters.AddWithValue("@conductorId", conductorId)
            command.ExecuteNonQuery()

            'Refreshing combo boxes after udating availability
            RefreshComboBoxes()

            'Refreshing data in the view trip user control
            'If _tripsUserControl IsNot Nothing Then
            '_tripsUserControl.RefreshTripPanels()
            'Else
            'MessageBox.Show("TripsUserControl instance is null.")
            'End If

            MessageBox.Show("Trip started successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TripFromComboBox.SelectedIndex = -1
        TripFromComboBox.Text = ""
        TripToComboBox.SelectedIndex = -1
        TripToComboBox.Text = ""
        VehicleComboBox.SelectedIndex = -1
        VehicleComboBox.Text = ""
        DriverComboBox.SelectedIndex = -1
        DriverComboBox.Text = ""
        ConductorComboBox.SelectedIndex = -1
        ConductorComboBox.Text = ""
    End Sub
End Class