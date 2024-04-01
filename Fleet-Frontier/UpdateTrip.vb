Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class UpdateTrip
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    Dim adapter As MySqlDataAdapter
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub CancelTripButton_Click(sender As Object, e As EventArgs) Handles CancelTripButton.Click
        Me.Close()
    End Sub
    Public Sub ClearComboBoxes()
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
        IsTripCompleteComboBox.SelectedIndex = -1
        IsTripCompleteComboBox.Text = ""
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearComboBoxes()

    End Sub

    ' Declare a private field to store the trip details
    Private _tripDetails As Dictionary(Of String, String)
    Private _tripId As String

    ' Constructor that accepts trip details
    Public Sub New(ByVal tripId As String, ByVal tripDetails As Dictionary(Of String, String))
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize connection
        connection = New MySqlConnection(ConnectionString)
        connection.Open()

        ' Store the trip details in the private field
        _tripDetails = tripDetails
        _tripId = tripId



        ' Populate the textboxes with the trip details
        TripFromComboBox.Text = _tripDetails("trip_from")
        TripToComboBox.Text = _tripDetails("trip_to")
        IsTripCompleteComboBox.Text = _tripDetails("has_arrived")
        ' Populate VehicleComboBox with vehicle ID and number plate
        VehicleComboBox.Text = _tripDetails("vehicle_id") & " - " & _tripDetails("vehicle_number_plate")

        ' Populate DriverComboBox with driver ID and name
        DriverComboBox.Text = _tripDetails("driver_id") & " - " & _tripDetails("driver_name")

        ' Populate ConductorComboBox with conductor ID and name
        ConductorComboBox.Text = _tripDetails("conductor_id") & " - " & _tripDetails("conductor_name")
        ' Populate other textboxes as needed
        PopulateVehicleComboBox()
        PopulateDriverComboBox()
        PopulateConductorComboBox()
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

    Private Sub UpdateTripButton_Click(sender As Object, e As EventArgs) Handles UpdateTripButton.Click
        ' Read selected values from combo boxes
        Dim tripFrom As String = TripFromComboBox.Text
        Dim tripTo As String = TripToComboBox.Text
        Dim vehicleInfo As String = VehicleComboBox.Text
        Dim driverInfo As String = DriverComboBox.Text
        Dim conductorInfo As String = ConductorComboBox.Text
        Dim isTripComplete As String = IsTripCompleteComboBox.Text

        ' Extract vehicle ID and driver ID from the selected combo box values
        Dim vehicleId As String = vehicleInfo.Split("-"c)(0).Trim()
        Dim driverId As String = driverInfo.Split("-"c)(0).Trim()
        Dim conductorId As String = conductorInfo.Split("-"c)(0).Trim()
        Dim hasArrived As Integer = If(isTripComplete.ToLower() = "true", 1, 0)

        ' Construct the update query for trip details
        Dim updateTripQuery As String = "UPDATE trip " &
                                    "SET trip_from = @tripFrom, trip_to = @tripTo, " &
                                    "vehicle_id = @vehicleId, " &
                                    "has_arrived = @hasArrived " &
                                    "WHERE trip_id = @tripId;"

        ' Construct the update query for driver and conductor details in trip_employee table
        ' Construct the update query for driver and conductor details in trip_employee table
        Dim updateTripEmployeeQuery As String = "UPDATE trip_employee AS te " &
                                            "INNER JOIN employee AS e ON te.employee_id = e.employee_id " &
                                            "SET te.employee_id = @driverId " &
                                            "WHERE te.trip_id = @tripId AND e.employee_type = 'Driver'; " &
                                            "UPDATE trip_employee AS te " &
                                            "INNER JOIN employee AS e ON te.employee_id = e.employee_id " &
                                            "SET te.employee_id = @conductorId " &
                                            "WHERE te.trip_id = @tripId AND e.employee_type = 'Conductor';"

        ' Create MySqlConnection for the update
        Using connection As New MySqlConnection(ConnectionString)
            ' Create MySqlCommand for trip update
            Using command As New MySqlCommand(updateTripQuery, connection)
                ' Add parameters for trip update
                command.Parameters.AddWithValue("@tripFrom", tripFrom)
                command.Parameters.AddWithValue("@tripTo", tripTo)
                command.Parameters.AddWithValue("@vehicleId", vehicleId)
                command.Parameters.AddWithValue("@hasArrived", hasArrived)
                command.Parameters.AddWithValue("@tripId", _tripId)

                Try
                    ' Open the connection
                    connection.Open()
                    ' Execute the trip update query
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    ' Show error message if trip update fails
                    MessageBox.Show("Error updating trip details: " & ex.Message)
                    Return ' Exit the event handler
                End Try
            End Using

            ' Create MySqlCommand for trip_employee update
            Using command As New MySqlCommand(updateTripEmployeeQuery, connection)
                ' Add parameters for trip_employee update
                command.Parameters.AddWithValue("@driverId", driverId)
                command.Parameters.AddWithValue("@conductorId", conductorId)
                command.Parameters.AddWithValue("@tripId", _tripId)

                Try
                    ' Execute the trip_employee update query
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    ' Show error message if trip_employee update fails
                    MessageBox.Show("Error updating trip employees: " & ex.Message)
                    Return ' Exit the event handler
                End Try
            End Using
        End Using

        MessageBox.Show("Trip updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'After updating, clear the fields
        ClearComboBoxes()
        TripFromComboBox.Focus()
    End Sub

End Class