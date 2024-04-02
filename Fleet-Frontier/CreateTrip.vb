Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class CreateTrip
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    Dim adapter As MySqlDataAdapter
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub


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

        ' Calculate the position to center AddVehicle form relative to Form1
        Dim mainFormCenterX As Integer = Owner.Location.X + (Owner.Width - Width) \ 2
        Dim mainFormCenterY As Integer = Owner.Location.Y + (Owner.Height - Height) \ 2

        ' Set the start position of AddVehicle form
        StartPosition = FormStartPosition.Manual
        Location = New Point(mainFormCenterX, mainFormCenterY)
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

            ' Execute the insert query
            Dim tripId As Integer = Convert.ToInt32(command.ExecuteScalar())

            ' Insert data into the trip_employee table
            Dim driverId As Integer = Integer.Parse(DriverComboBox.SelectedItem.ToString().Split("-"c)(0).Trim())
            Dim conductorId As Integer = Integer.Parse(ConductorComboBox.SelectedItem.ToString().Split("-"c)(0).Trim())

            Dim tripEmployeeInsertQuery As String = "INSERT INTO trip_employee (trip_id, employee_id, employee_type) VALUES (@tripId, @driverId, 'Driver'), (@tripId, @conductorId, 'Conductor');"
            command = New MySqlCommand(tripEmployeeInsertQuery, connection)
            command.Parameters.AddWithValue("@tripId", tripId)
            command.Parameters.AddWithValue("@driverId", driverId)
            command.Parameters.AddWithValue("@conductorId", conductorId)

            ' Execute the insert query for trip_employee
            command.ExecuteNonQuery()


            ' Update driver availability
            Dim updateDriverQuery As String = "UPDATE employee SET is_available = FALSE WHERE employee_id IN (SELECT employee_id FROM trip_employee WHERE trip_id = @tripId AND employee_type = 'Driver');"
            command = New MySqlCommand(updateDriverQuery, connection)
            command.Parameters.AddWithValue("@tripId", tripId)
            command.ExecuteNonQuery()

            ' Update conductor availability
            Dim updateConductorQuery As String = "UPDATE employee SET is_available = FALSE WHERE employee_id IN (SELECT employee_id FROM trip_employee WHERE trip_id = @tripId AND employee_type = 'Conductor');"
            command = New MySqlCommand(updateConductorQuery, connection)
            command.Parameters.AddWithValue("@tripId", tripId)
            command.ExecuteNonQuery()

            ' Update vehicle availability
            Dim updateVehicleQuery As String = "UPDATE vehicle SET is_available = FALSE WHERE vehicle_id = @vehicleId;"
            command = New MySqlCommand(updateVehicleQuery, connection)
            command.Parameters.AddWithValue("@vehicleId", vehicleId)
            command.ExecuteNonQuery()

            'Refreshing combo boxes after updating availability
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

        TripFromComboBox.Focus()

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

    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False

    End Sub

    Private Sub CancelTripButton_Click(sender As Object, e As EventArgs) Handles CancelTripButton.Click
        Me.Close()
    End Sub
End Class