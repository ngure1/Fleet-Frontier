Imports MySql.Data.MySqlClient

Public Class AddVehicle
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ConnectionString As String = "server=localhost;port=33062;userid=root;password='default123';database=fleet_finder"
        conn = New MySqlConnection(ConnectionString)

        Try
            conn.Open()
            Dim insertQuery As String = "INSERT INTO vehicle (numberPlate, `fuel_cost/km`, is_available, created_at) VALUES (@plate, @fuel, @availability, @time)"
            command = New MySqlCommand(insertQuery, conn)
            command.Parameters.AddWithValue("@plate", NumberPlateTextBox.Text)
            command.Parameters.AddWithValue("@fuel", FuelTextBox.Text)
            command.Parameters.AddWithValue("@availability", AvailabilityTextBox.Text)

            ' Convert DateTimePicker value to MySQL date format
            Dim formattedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            command.Parameters.AddWithValue("@time", formattedDate)

            command.ExecuteNonQuery()
            MessageBox.Show("Vehicle Created Successfully!!!")
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NumberPlateTextBox.Text = ""
        FuelTextBox.Text = ""
        AvailabilityTextBox.Text = ""
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
            Me.Top = Cursor.Position.Y - Me.mouseY
            Me.Left = Cursor.Position.X - Me.mouseX
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False

    End Sub
    Private Sub AddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calculate the position to center AddVehicle form relative to Form1
        Dim mainFormCenterX As Integer = Owner.Location.X + (Owner.Width - Width) \ 2
        Dim mainFormCenterY As Integer = Owner.Location.Y + (Owner.Height - Height) \ 2

        ' Set the start position of AddVehicle form
        StartPosition = FormStartPosition.Manual
        Location = New Point(mainFormCenterX, mainFormCenterY)
    End Sub

End Class
