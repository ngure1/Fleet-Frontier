Imports MySql.Data.MySqlClient

Public Class HomePageUserControl
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    Dim connection As MySqlConnection = New MySqlConnection(ConnectionString)

    Private Sub HomePageUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Open the database connection
            connection.Open()

            ' Count available vehicles
            Dim availableVehiclesCount As Integer = CountVehiclesByAvailability(True)
            VehicleAvailableLabel.Text = availableVehiclesCount.ToString()

            ' Count rented out vehicles
            Dim rentedOutVehiclesCount As Integer = CountRentedOutVehicles()
            RentedLabel.Text = rentedOutVehiclesCount.ToString

            ' Count vehicles on a trip
            Dim vehiclesOnTripCount As Integer = CountVehiclesOnTrip()
            VehicleOnTripLabel.Text = vehiclesOnTripCount.ToString

            ' Calculate total vehicles
            Dim totalVehicles As Integer = availableVehiclesCount + rentedOutVehiclesCount + vehiclesOnTripCount
            TotalVehiclesLabel.Text = totalVehicles.ToString

            ' Count available drivers
            Dim availableDriversCount As Integer = CountAvailableEmployees("Driver")
            AvailableDriversLabel.Text = availableDriversCount.ToString()

            ' Count available conductors
            Dim availableConductorsCount As Integer = CountAvailableEmployees("Conductor")
            AvailableConductorsLabel.Text = availableConductorsCount.ToString()

            ' Count employees that are not available
            Dim unavailableEmployeesCount As Integer = CountUnavailableEmployees()
            StaffOnTripLabel.Text = unavailableEmployeesCount.ToString()

            ' Calculate total employees
            Dim totalEmployees As Integer = availableDriversCount + availableConductorsCount + unavailableEmployeesCount
            StaffTotalLabel.Text = totalEmployees.ToString()


            ' Execute the SQL query
            Dim query As String = "SELECT trip.trip_id, trip.vehicle_id, vehicle.numberPlate, trip.trip_start_time, trip.has_arrived
                                    FROM trip
                                    JOIN vehicle ON trip.vehicle_id = vehicle.vehicle_id
                                    WHERE trip.has_arrived = FALSE;
                                   "
            Dim cmd As MySqlCommand = New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop through the result set
            Dim spacing As Integer = 20 ' Adjust the spacing value as needed
            Dim currentYPos As Integer = 120 ' Track the current Y position of the panel
            While reader.Read()
                ' Create a panel to contain the labels for this row
                Dim panel As New Panel()
                panel.Dock = DockStyle.Top ' Dock to the top of the TripPanel
                panel.BorderStyle = BorderStyle.FixedSingle
                panel.Height = 100 ' Set panel height
                panel.Margin = New Padding(0, spacing, 0, 0) ' Add top margin for spacing

                ' Create labels for each column
                Dim tripIdLabel As New Label()
                tripIdLabel.Text = "Trip ID: "
                tripIdLabel.Location = New Point(10, 10)
                panel.Controls.Add(tripIdLabel)

                Dim tripIdValueLabel As New Label()
                tripIdValueLabel.Text = reader("trip_id").ToString()
                tripIdValueLabel.Location = New Point(110, 10)
                panel.Controls.Add(tripIdValueLabel)

                ' Create label for Vehicle ID (column 1)
                Dim vehicleIdLabel As New Label()
                vehicleIdLabel.Text = "Vehicle ID: "
                vehicleIdLabel.Location = New Point(10, 30)
                panel.Controls.Add(vehicleIdLabel)

                Dim vehicleIdValueLabel As New Label()
                vehicleIdValueLabel.Text = reader("vehicle_id").ToString()
                vehicleIdValueLabel.Location = New Point(110, 30)
                panel.Controls.Add(vehicleIdValueLabel)

                ' Create label for Number Plate (column 2)
                Dim numberPlateLabel As New Label()
                numberPlateLabel.Text = "Number Plate: "
                numberPlateLabel.Location = New Point(10, 50)
                panel.Controls.Add(numberPlateLabel)

                Dim numberPlateValueLabel As New Label()
                numberPlateValueLabel.Text = reader("numberPlate").ToString()
                numberPlateValueLabel.Location = New Point(110, 50)
                panel.Controls.Add(numberPlateValueLabel)

                ' Create label for Trip Start Time (column 1)
                Dim tripStartTimeLabel As New Label()
                tripStartTimeLabel.Text = "Trip Start Time: "
                tripStartTimeLabel.Location = New Point(10, 70)
                panel.Controls.Add(tripStartTimeLabel)

                Dim tripStartTimeValueLabel As New Label()
                tripStartTimeValueLabel.Text = reader("trip_start_time").ToString()
                tripStartTimeValueLabel.Location = New Point(110, 70)
                panel.Controls.Add(tripStartTimeValueLabel)


                ' Calculate the Y position for the next panel
                currentYPos += panel.Height + spacing

                ' Add the panel to the TripPanel
                TripPanel.Controls.Add(panel)
            End While




        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection
            connection.Close()
        End Try
    End Sub

    Private Function CountVehiclesByAvailability(isAvailable As Boolean) As Integer
        Dim query As String = "SELECT COUNT(*) FROM vehicle WHERE is_available = @IsAvailable"
        Dim cmd As MySqlCommand = New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@IsAvailable", isAvailable)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function CountRentedOutVehicles() As Integer
        Dim query As String = "SELECT COUNT(*) FROM hire WHERE is_returned = FALSE"
        Dim cmd As MySqlCommand = New MySqlCommand(query, connection)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function CountVehiclesOnTrip() As Integer
        Dim query As String = "SELECT COUNT(DISTINCT vehicle_id) FROM trip WHERE has_arrived = FALSE"
        Dim cmd As MySqlCommand = New MySqlCommand(query, connection)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function CountAvailableEmployees(employeeType As String) As Integer
        Dim query As String = "SELECT COUNT(*) FROM employee WHERE is_available = TRUE AND employee_type = @EmployeeType"
        Dim cmd As MySqlCommand = New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@EmployeeType", employeeType)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function CountUnavailableEmployees() As Integer
        Dim query As String = "SELECT COUNT(*) FROM employee WHERE is_available = FALSE"
        Dim cmd As MySqlCommand = New MySqlCommand(query, connection)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function
End Class

