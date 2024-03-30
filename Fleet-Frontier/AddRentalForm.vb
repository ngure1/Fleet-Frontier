Imports MySql.Data.MySqlClient

Public Class AddRentalForm
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    Dim adapter As MySqlDataAdapter

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearRentalButton.Click
        CustomerNameTextBox.Text = ""
        CustomerPhoneNumberTextBox.Text = ""
        VehicleComboBox.Text = ""
    End Sub
    Private Sub CancelRentalButton_Click(sender As Object, e As EventArgs) Handles CancelRentalButton.Click
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles ExitAddRentalButton.Click
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
    Private Sub AddRentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to your database
        connection = New MySqlConnection(ConnectionString)
        Try
            connection.Open()
            PopulateVehicleComboBox()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub AddRentalButton_Click(sender As Object, e As EventArgs) Handles AddRentalButton.Click
        connection = New MySqlConnection(ConnectionString)
        Try
            Dim customerName As String = CustomerNameTextBox.Text
            Dim customerPhoneNumber As String = CustomerPhoneNumberTextBox.Text
            Dim vehicleId As Integer = Integer.Parse(VehicleComboBox.SelectedItem.ToString().Split("-"c)(0).Trim())


            ' Construct the SQL query with placeholders
            Dim createRentalQuery As String = "INSERT INTO hire (vehicle_id, customer_name, customer_phone_number, is_returned) VALUES (@vehicleId, @customerName, @customerPhoneNumber, FALSE);"

            ' Create a MySqlConnection and MySqlCommand
            Using connection As New MySqlConnection(ConnectionString)
                Using command As New MySqlCommand(createRentalQuery, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@vehicleId", vehicleId)
                    command.Parameters.AddWithValue("@customerName", customerName)
                    command.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber)

                    ' Open the connection
                    connection.Open()

                    ' Execute the query
                    command.ExecuteNonQuery()

                    ' Inform the user about the successful operation
                    MessageBox.Show("Rental added successfully.")
                End Using
            End Using

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show($"Error adding rental: {ex.Message}")
        End Try
    End Sub
End Class