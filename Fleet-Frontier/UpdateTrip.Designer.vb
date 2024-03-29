<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTrip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateTrip))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        exitButton = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        IsTripCompleteComboBox = New ComboBox()
        IsTripCompleteLabel = New Label()
        ClearButton = New Button()
        TripToComboBox = New ComboBox()
        ToLabel = New Label()
        TripFromComboBox = New ComboBox()
        FromLabel = New Label()
        ConductorComboBox = New ComboBox()
        DriverComboBox = New ComboBox()
        VehicleComboBox = New ComboBox()
        UpdateTripButton = New Button()
        CancelTripButton = New Button()
        ConductorTextbox = New Label()
        DriverLabel = New Label()
        VehicleLabel = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(exitButton)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(569, 55)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 55)
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
        exitButton.Location = New Point(533, 0)
        exitButton.Margin = New Padding(4, 3, 4, 3)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(36, 55)
        exitButton.TabIndex = 5
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(66, 5)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 45)
        Label1.TabIndex = 0
        Label1.Text = "Update Trip"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(IsTripCompleteComboBox)
        Panel2.Controls.Add(IsTripCompleteLabel)
        Panel2.Controls.Add(ClearButton)
        Panel2.Controls.Add(TripToComboBox)
        Panel2.Controls.Add(ToLabel)
        Panel2.Controls.Add(TripFromComboBox)
        Panel2.Controls.Add(FromLabel)
        Panel2.Controls.Add(ConductorComboBox)
        Panel2.Controls.Add(DriverComboBox)
        Panel2.Controls.Add(VehicleComboBox)
        Panel2.Controls.Add(UpdateTripButton)
        Panel2.Controls.Add(CancelTripButton)
        Panel2.Controls.Add(ConductorTextbox)
        Panel2.Controls.Add(DriverLabel)
        Panel2.Controls.Add(VehicleLabel)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 55)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(569, 720)
        Panel2.TabIndex = 8
        ' 
        ' IsTripCompleteComboBox
        ' 
        IsTripCompleteComboBox.FormattingEnabled = True
        IsTripCompleteComboBox.Items.AddRange(New Object() {"True", "False"})
        IsTripCompleteComboBox.Location = New Point(32, 554)
        IsTripCompleteComboBox.Margin = New Padding(1, 2, 1, 2)
        IsTripCompleteComboBox.Name = "IsTripCompleteComboBox"
        IsTripCompleteComboBox.Size = New Size(498, 33)
        IsTripCompleteComboBox.TabIndex = 20
        ' 
        ' IsTripCompleteLabel
        ' 
        IsTripCompleteLabel.AutoSize = True
        IsTripCompleteLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IsTripCompleteLabel.Location = New Point(32, 514)
        IsTripCompleteLabel.Margin = New Padding(4, 0, 4, 0)
        IsTripCompleteLabel.Name = "IsTripCompleteLabel"
        IsTripCompleteLabel.Size = New Size(138, 39)
        IsTripCompleteLabel.TabIndex = 19
        IsTripCompleteLabel.Text = "Is Trip Complete"
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(32, 639)
        ClearButton.Margin = New Padding(4, 5, 4, 5)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(123, 43)
        ClearButton.TabIndex = 18
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' TripToComboBox
        ' 
        TripToComboBox.FormattingEnabled = True
        TripToComboBox.Items.AddRange(New Object() {"Juja", "Thika", "Nairobi"})
        TripToComboBox.Location = New Point(306, 98)
        TripToComboBox.Margin = New Padding(1, 2, 1, 2)
        TripToComboBox.Name = "TripToComboBox"
        TripToComboBox.Size = New Size(227, 33)
        TripToComboBox.TabIndex = 17
        ' 
        ' ToLabel
        ' 
        ToLabel.AutoSize = True
        ToLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        ToLabel.Location = New Point(309, 57)
        ToLabel.Margin = New Padding(1, 0, 1, 0)
        ToLabel.Name = "ToLabel"
        ToLabel.Size = New Size(33, 39)
        ToLabel.TabIndex = 16
        ToLabel.Text = "To"
        ' 
        ' TripFromComboBox
        ' 
        TripFromComboBox.FormattingEnabled = True
        TripFromComboBox.Items.AddRange(New Object() {"Juja", "Thika", "Nairobi"})
        TripFromComboBox.Location = New Point(33, 98)
        TripFromComboBox.Margin = New Padding(1, 2, 1, 2)
        TripFromComboBox.Name = "TripFromComboBox"
        TripFromComboBox.Size = New Size(227, 33)
        TripFromComboBox.TabIndex = 15
        ' 
        ' FromLabel
        ' 
        FromLabel.AutoSize = True
        FromLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        FromLabel.Location = New Point(36, 58)
        FromLabel.Margin = New Padding(1, 0, 1, 0)
        FromLabel.Name = "FromLabel"
        FromLabel.Size = New Size(55, 39)
        FromLabel.TabIndex = 14
        FromLabel.Text = "From"
        ' 
        ' ConductorComboBox
        ' 
        ConductorComboBox.FormattingEnabled = True
        ConductorComboBox.Location = New Point(33, 438)
        ConductorComboBox.Margin = New Padding(1, 2, 1, 2)
        ConductorComboBox.Name = "ConductorComboBox"
        ConductorComboBox.Size = New Size(498, 33)
        ConductorComboBox.TabIndex = 13
        ' 
        ' DriverComboBox
        ' 
        DriverComboBox.FormattingEnabled = True
        DriverComboBox.Location = New Point(33, 317)
        DriverComboBox.Margin = New Padding(1, 2, 1, 2)
        DriverComboBox.Name = "DriverComboBox"
        DriverComboBox.Size = New Size(498, 33)
        DriverComboBox.TabIndex = 12
        ' 
        ' VehicleComboBox
        ' 
        VehicleComboBox.FormattingEnabled = True
        VehicleComboBox.Location = New Point(33, 190)
        VehicleComboBox.Margin = New Padding(1, 2, 1, 2)
        VehicleComboBox.Name = "VehicleComboBox"
        VehicleComboBox.Size = New Size(498, 33)
        VehicleComboBox.TabIndex = 11
        ' 
        ' UpdateTripButton
        ' 
        UpdateTripButton.BackColor = Color.Gray
        UpdateTripButton.FlatAppearance.BorderSize = 0
        UpdateTripButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        UpdateTripButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        UpdateTripButton.FlatStyle = FlatStyle.Flat
        UpdateTripButton.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UpdateTripButton.ForeColor = Color.Black
        UpdateTripButton.Location = New Point(409, 639)
        UpdateTripButton.Margin = New Padding(4, 3, 4, 3)
        UpdateTripButton.Name = "UpdateTripButton"
        UpdateTripButton.Size = New Size(123, 43)
        UpdateTripButton.TabIndex = 10
        UpdateTripButton.Text = "Update"
        UpdateTripButton.UseVisualStyleBackColor = False
        ' 
        ' CancelTripButton
        ' 
        CancelTripButton.BackColor = Color.Gray
        CancelTripButton.FlatAppearance.BorderSize = 0
        CancelTripButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelTripButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CancelTripButton.FlatStyle = FlatStyle.Flat
        CancelTripButton.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CancelTripButton.ForeColor = Color.Red
        CancelTripButton.Location = New Point(219, 639)
        CancelTripButton.Margin = New Padding(4, 3, 4, 3)
        CancelTripButton.Name = "CancelTripButton"
        CancelTripButton.Size = New Size(123, 43)
        CancelTripButton.TabIndex = 9
        CancelTripButton.Text = "Cancel"
        CancelTripButton.UseVisualStyleBackColor = False
        ' 
        ' ConductorTextbox
        ' 
        ConductorTextbox.AutoSize = True
        ConductorTextbox.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConductorTextbox.Location = New Point(33, 398)
        ConductorTextbox.Margin = New Padding(4, 0, 4, 0)
        ConductorTextbox.Name = "ConductorTextbox"
        ConductorTextbox.Size = New Size(94, 39)
        ConductorTextbox.TabIndex = 5
        ConductorTextbox.Text = "Conductor"
        ' 
        ' DriverLabel
        ' 
        DriverLabel.AutoSize = True
        DriverLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DriverLabel.Location = New Point(33, 273)
        DriverLabel.Margin = New Padding(4, 0, 4, 0)
        DriverLabel.Name = "DriverLabel"
        DriverLabel.Size = New Size(63, 39)
        DriverLabel.TabIndex = 3
        DriverLabel.Text = "Driver"
        ' 
        ' VehicleLabel
        ' 
        VehicleLabel.AutoSize = True
        VehicleLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VehicleLabel.Location = New Point(33, 150)
        VehicleLabel.Margin = New Padding(4, 0, 4, 0)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New Size(68, 39)
        VehicleLabel.TabIndex = 1
        VehicleLabel.Text = "Vehicle"
        ' 
        ' UpdateTrip
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(569, 775)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UpdateTrip"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClearButton As Button
    Friend WithEvents TripToComboBox As ComboBox
    Friend WithEvents ToLabel As Label
    Friend WithEvents TripFromComboBox As ComboBox
    Friend WithEvents FromLabel As Label
    Friend WithEvents ConductorComboBox As ComboBox
    Friend WithEvents DriverComboBox As ComboBox
    Friend WithEvents VehicleComboBox As ComboBox
    Friend WithEvents UpdateTripButton As Button
    Friend WithEvents CancelTripButton As Button
    Friend WithEvents ConductorTextbox As Label
    Friend WithEvents DriverLabel As Label
    Friend WithEvents VehicleLabel As Label
    Friend WithEvents IsTripCompleteComboBox As ComboBox
    Friend WithEvents IsTripCompleteLabel As Label
End Class
