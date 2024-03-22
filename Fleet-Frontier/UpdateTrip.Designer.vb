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
        ClearButton = New Button()
        TripToComboBox = New ComboBox()
        ToLabel = New Label()
        TripFromComboBox = New ComboBox()
        FromLabel = New Label()
        ConductorComboBox = New ComboBox()
        DriverComboBox = New ComboBox()
        VehicleComboBox = New ComboBox()
        StartTripButton = New Button()
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
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(398, 33)
        Panel1.TabIndex = 7
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
        exitButton.Location = New Point(373, 0)
        exitButton.Margin = New Padding(3, 2, 3, 2)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(25, 33)
        exitButton.TabIndex = 5
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(46, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 29)
        Label1.TabIndex = 0
        Label1.Text = "Update Trip"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ClearButton)
        Panel2.Controls.Add(TripToComboBox)
        Panel2.Controls.Add(ToLabel)
        Panel2.Controls.Add(TripFromComboBox)
        Panel2.Controls.Add(FromLabel)
        Panel2.Controls.Add(ConductorComboBox)
        Panel2.Controls.Add(DriverComboBox)
        Panel2.Controls.Add(VehicleComboBox)
        Panel2.Controls.Add(StartTripButton)
        Panel2.Controls.Add(CancelTripButton)
        Panel2.Controls.Add(ConductorTextbox)
        Panel2.Controls.Add(DriverLabel)
        Panel2.Controls.Add(VehicleLabel)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 33)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(398, 419)
        Panel2.TabIndex = 8
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(23, 333)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(86, 26)
        ClearButton.TabIndex = 18
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' TripToComboBox
        ' 
        TripToComboBox.FormattingEnabled = True
        TripToComboBox.Location = New Point(214, 59)
        TripToComboBox.Margin = New Padding(1)
        TripToComboBox.Name = "TripToComboBox"
        TripToComboBox.Size = New Size(160, 23)
        TripToComboBox.TabIndex = 17
        ' 
        ' ToLabel
        ' 
        ToLabel.AutoSize = True
        ToLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        ToLabel.Location = New Point(216, 34)
        ToLabel.Margin = New Padding(1, 0, 1, 0)
        ToLabel.Name = "ToLabel"
        ToLabel.Size = New Size(24, 26)
        ToLabel.TabIndex = 16
        ToLabel.Text = "To"
        ' 
        ' TripFromComboBox
        ' 
        TripFromComboBox.FormattingEnabled = True
        TripFromComboBox.Location = New Point(23, 59)
        TripFromComboBox.Margin = New Padding(1)
        TripFromComboBox.Name = "TripFromComboBox"
        TripFromComboBox.Size = New Size(160, 23)
        TripFromComboBox.TabIndex = 15
        ' 
        ' FromLabel
        ' 
        FromLabel.AutoSize = True
        FromLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        FromLabel.Location = New Point(25, 35)
        FromLabel.Margin = New Padding(1, 0, 1, 0)
        FromLabel.Name = "FromLabel"
        FromLabel.Size = New Size(39, 26)
        FromLabel.TabIndex = 14
        FromLabel.Text = "From"
        ' 
        ' ConductorComboBox
        ' 
        ConductorComboBox.FormattingEnabled = True
        ConductorComboBox.Location = New Point(23, 263)
        ConductorComboBox.Margin = New Padding(1)
        ConductorComboBox.Name = "ConductorComboBox"
        ConductorComboBox.Size = New Size(350, 23)
        ConductorComboBox.TabIndex = 13
        ' 
        ' DriverComboBox
        ' 
        DriverComboBox.FormattingEnabled = True
        DriverComboBox.Location = New Point(23, 190)
        DriverComboBox.Margin = New Padding(1)
        DriverComboBox.Name = "DriverComboBox"
        DriverComboBox.Size = New Size(350, 23)
        DriverComboBox.TabIndex = 12
        ' 
        ' VehicleComboBox
        ' 
        VehicleComboBox.FormattingEnabled = True
        VehicleComboBox.Location = New Point(23, 114)
        VehicleComboBox.Margin = New Padding(1)
        VehicleComboBox.Name = "VehicleComboBox"
        VehicleComboBox.Size = New Size(350, 23)
        VehicleComboBox.TabIndex = 11
        ' 
        ' StartTripButton
        ' 
        StartTripButton.BackColor = Color.Gray
        StartTripButton.FlatAppearance.BorderSize = 0
        StartTripButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        StartTripButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        StartTripButton.FlatStyle = FlatStyle.Flat
        StartTripButton.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StartTripButton.ForeColor = Color.Black
        StartTripButton.Location = New Point(287, 333)
        StartTripButton.Margin = New Padding(3, 2, 3, 2)
        StartTripButton.Name = "StartTripButton"
        StartTripButton.Size = New Size(86, 26)
        StartTripButton.TabIndex = 10
        StartTripButton.Text = "Start"
        StartTripButton.UseVisualStyleBackColor = False
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
        CancelTripButton.Location = New Point(154, 333)
        CancelTripButton.Margin = New Padding(3, 2, 3, 2)
        CancelTripButton.Name = "CancelTripButton"
        CancelTripButton.Size = New Size(86, 26)
        CancelTripButton.TabIndex = 9
        CancelTripButton.Text = "Cancel"
        CancelTripButton.UseVisualStyleBackColor = False
        ' 
        ' ConductorTextbox
        ' 
        ConductorTextbox.AutoSize = True
        ConductorTextbox.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConductorTextbox.Location = New Point(23, 239)
        ConductorTextbox.Name = "ConductorTextbox"
        ConductorTextbox.Size = New Size(67, 26)
        ConductorTextbox.TabIndex = 5
        ConductorTextbox.Text = "Conductor"
        ' 
        ' DriverLabel
        ' 
        DriverLabel.AutoSize = True
        DriverLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DriverLabel.Location = New Point(23, 164)
        DriverLabel.Name = "DriverLabel"
        DriverLabel.Size = New Size(46, 26)
        DriverLabel.TabIndex = 3
        DriverLabel.Text = "Driver"
        ' 
        ' VehicleLabel
        ' 
        VehicleLabel.AutoSize = True
        VehicleLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VehicleLabel.Location = New Point(23, 90)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New Size(48, 26)
        VehicleLabel.TabIndex = 1
        VehicleLabel.Text = "Vehicle"
        ' 
        ' UpdateTrip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 452)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
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
    Friend WithEvents StartTripButton As Button
    Friend WithEvents CancelTripButton As Button
    Friend WithEvents ConductorTextbox As Label
    Friend WithEvents DriverLabel As Label
    Friend WithEvents VehicleLabel As Label
End Class
