<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateVehicle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateVehicle))
        Panel2 = New Panel()
        ClearButton = New Button()
        UpdateVehicleButton = New Button()
        CancelVehicleButton = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        FuelLabel = New Label()
        FuelTextBox = New TextBox()
        NumberPlateLabel = New Label()
        NumberPlateTextBox = New TextBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        exitButton = New Button()
        UpdateVehicleLabel = New Label()
        AvailabilityLabel = New Label()
        AvailabilityComboBox = New ComboBox()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(AvailabilityComboBox)
        Panel2.Controls.Add(AvailabilityLabel)
        Panel2.Controls.Add(ClearButton)
        Panel2.Controls.Add(UpdateVehicleButton)
        Panel2.Controls.Add(CancelVehicleButton)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(FuelLabel)
        Panel2.Controls.Add(FuelTextBox)
        Panel2.Controls.Add(NumberPlateLabel)
        Panel2.Controls.Add(NumberPlateTextBox)
        Panel2.Location = New Point(0, 37)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(382, 395)
        Panel2.TabIndex = 2
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(16, 333)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(86, 26)
        ClearButton.TabIndex = 11
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' UpdateVehicleButton
        ' 
        UpdateVehicleButton.BackColor = Color.Gray
        UpdateVehicleButton.FlatAppearance.BorderSize = 0
        UpdateVehicleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        UpdateVehicleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        UpdateVehicleButton.FlatStyle = FlatStyle.Flat
        UpdateVehicleButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        UpdateVehicleButton.ForeColor = Color.Black
        UpdateVehicleButton.Location = New Point(276, 333)
        UpdateVehicleButton.Margin = New Padding(3, 2, 3, 2)
        UpdateVehicleButton.Name = "UpdateVehicleButton"
        UpdateVehicleButton.Size = New Size(86, 26)
        UpdateVehicleButton.TabIndex = 10
        UpdateVehicleButton.Text = "Update"
        UpdateVehicleButton.UseVisualStyleBackColor = False
        ' 
        ' CancelVehicleButton
        ' 
        CancelVehicleButton.BackColor = Color.Gray
        CancelVehicleButton.FlatAppearance.BorderSize = 0
        CancelVehicleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelVehicleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CancelVehicleButton.FlatStyle = FlatStyle.Flat
        CancelVehicleButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        CancelVehicleButton.ForeColor = Color.Red
        CancelVehicleButton.Location = New Point(144, 333)
        CancelVehicleButton.Margin = New Padding(3, 2, 3, 2)
        CancelVehicleButton.Name = "CancelVehicleButton"
        CancelVehicleButton.Size = New Size(86, 26)
        CancelVehicleButton.TabIndex = 9
        CancelVehicleButton.Text = "Cancel"
        CancelVehicleButton.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(83, 277)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(219, 23)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(41, 278)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 26)
        Label5.TabIndex = 7
        Label5.Text = "Date"
        ' 
        ' FuelLabel
        ' 
        FuelLabel.AutoSize = True
        FuelLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FuelLabel.Location = New Point(11, 113)
        FuelLabel.Name = "FuelLabel"
        FuelLabel.Size = New Size(126, 26)
        FuelLabel.TabIndex = 3
        FuelLabel.Text = "Fuel consumption/km"
        ' 
        ' FuelTextBox
        ' 
        FuelTextBox.Location = New Point(11, 141)
        FuelTextBox.Margin = New Padding(3, 2, 3, 2)
        FuelTextBox.Name = "FuelTextBox"
        FuelTextBox.Size = New Size(350, 23)
        FuelTextBox.TabIndex = 2
        ' 
        ' NumberPlateLabel
        ' 
        NumberPlateLabel.AutoSize = True
        NumberPlateLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NumberPlateLabel.Location = New Point(11, 30)
        NumberPlateLabel.Name = "NumberPlateLabel"
        NumberPlateLabel.Size = New Size(83, 26)
        NumberPlateLabel.TabIndex = 1
        NumberPlateLabel.Text = "Number Plate"
        ' 
        ' NumberPlateTextBox
        ' 
        NumberPlateTextBox.Location = New Point(11, 58)
        NumberPlateTextBox.Margin = New Padding(3, 2, 3, 2)
        NumberPlateTextBox.Name = "NumberPlateTextBox"
        NumberPlateTextBox.Size = New Size(350, 23)
        NumberPlateTextBox.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(exitButton)
        Panel1.Controls.Add(UpdateVehicleLabel)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(382, 33)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' exitButton
        ' 
        exitButton.Dock = DockStyle.Right
        exitButton.FlatAppearance.BorderSize = 0
        exitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        exitButton.FlatStyle = FlatStyle.Flat
        exitButton.Font = New Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitButton.ForeColor = Color.Black
        exitButton.Location = New Point(357, 0)
        exitButton.Margin = New Padding(3, 2, 3, 2)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(25, 33)
        exitButton.TabIndex = 5
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' UpdateVehicleLabel
        ' 
        UpdateVehicleLabel.AutoSize = True
        UpdateVehicleLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateVehicleLabel.Location = New Point(41, 3)
        UpdateVehicleLabel.Name = "UpdateVehicleLabel"
        UpdateVehicleLabel.Size = New Size(102, 29)
        UpdateVehicleLabel.TabIndex = 0
        UpdateVehicleLabel.Text = "Update Vehicle"
        UpdateVehicleLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' AvailabilityLabel
        ' 
        AvailabilityLabel.AutoSize = True
        AvailabilityLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        AvailabilityLabel.Location = New Point(11, 198)
        AvailabilityLabel.Name = "AvailabilityLabel"
        AvailabilityLabel.Size = New Size(75, 26)
        AvailabilityLabel.TabIndex = 12
        AvailabilityLabel.Text = "Availability"
        ' 
        ' AvailabilityComboBox
        ' 
        AvailabilityComboBox.FormattingEnabled = True
        AvailabilityComboBox.Location = New Point(11, 227)
        AvailabilityComboBox.Name = "AvailabilityComboBox"
        AvailabilityComboBox.Size = New Size(345, 23)
        AvailabilityComboBox.TabIndex = 13
        ' 
        ' UpdateVehicle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 432)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "UpdateVehicle"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClearButton As Button
    Friend WithEvents UpdateVehicleButton As Button
    Friend WithEvents CancelVehicleButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents FuelLabel As Label
    Friend WithEvents FuelTextBox As TextBox
    Friend WithEvents NumberPlateLabel As Label
    Friend WithEvents NumberPlateTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitButton As Button
    Friend WithEvents UpdateVehicleLabel As Label
    Friend WithEvents AvailabilityComboBox As ComboBox
    Friend WithEvents AvailabilityLabel As Label
End Class
