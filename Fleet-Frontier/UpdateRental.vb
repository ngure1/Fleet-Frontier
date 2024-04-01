Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient

Public Class UpdateRental
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
    Dim adapter As MySqlDataAdapter

    Private ReadOnly _hireId As String
    Private ReadOnly _rentalDetails As Dictionary(Of String, String)

    Public Sub New(ByVal hireId As String, ByVal rentalDetails As Dictionary(Of String, String))
        InitializeComponent()

        connection = New MySqlConnection(ConnectionString)
        connection.Open()

        ' Save the hire ID and rental details
        _hireId = hireId
        _rentalDetails = rentalDetails

        ' Pre-fill the text boxes and combo boxes with rental details
        CustomerNameTextBox.Text = _rentalDetails("customer_name")
        CustomerPhoneNumberTextBox.Text = _rentalDetails("customer_phone_number")
        ' Populate VehicleComboBox with vehicle ID and number plate
        VehicleComboBox.Text = _rentalDetails("vehicle_id") & " - " & _rentalDetails("vehicle_number_plate")


        ' Set the rental status combo box based on the 'is_returned' value
        If Convert.ToBoolean(_rentalDetails("is_returned")) Then
            IsReturnedComboBox.SelectedIndex = IsReturnedComboBox.FindStringExact("True")
        Else
            IsReturnedComboBox.SelectedIndex = IsReturnedComboBox.FindStringExact("False")
        End If
        PopulateVehicleComboBox()
    End Sub

    Private Sub PopulateVehicleComboBox()
        VehicleComboBox.Items.Clear() ' Clear existing items

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

    Private Sub UpdateRentalButton_Click(sender As Object, e As EventArgs) Handles UpdateRentalButton.Click

        Dim customerName As String = CustomerNameTextBox.Text
        Dim customerPhoneNumber As String = CustomerPhoneNumberTextBox.Text
        Dim vehicleInfo As String = VehicleComboBox.SelectedItem.ToString()
        Dim vehicleId As Integer = Integer.Parse(vehicleInfo.Split("-"c)(0).Trim())
        Dim isReturned As String = IsReturnedComboBox.Text

        Dim isReturnedValue As Integer = If(isReturned.ToLower() = "true", 1, 0)

        ' Update query to update rental details
        Dim updateRentalQuery As String = "UPDATE hire " &
                                      "SET customer_name = @customerName, " &
                                      "customer_phone_number = @customerPhoneNumber, " &
                                      "is_returned = @isReturnedValue " &
                                      "WHERE hire_id = @hireId;"

        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(updateRentalQuery, connection)
                command.Parameters.AddWithValue("@customerName", customerName)
                command.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber)
                command.Parameters.AddWithValue("@isReturnedValue", isReturnedValue)
                command.Parameters.AddWithValue("@hireId", _hireId)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Rental updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to update rental.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error updating rental: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using


        CustomerNameTextBox.Text = ""
        CustomerPhoneNumberTextBox.Text = ""
        VehicleComboBox.SelectedIndex = -1
        VehicleComboBox.Text = ""
        IsReturnedComboBox.SelectedIndex = -1
        IsReturnedComboBox.Text = ""

        CustomerNameTextBox.Focus()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        CustomerNameTextBox.Text = ""
        VehicleComboBox.SelectedIndex = -1
        VehicleComboBox.Text = ""
    End Sub

    Private Sub CancelRentalButton_Click(sender As Object, e As EventArgs) Handles CancelRentalButton.Click
        Me.Close()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub
End Class