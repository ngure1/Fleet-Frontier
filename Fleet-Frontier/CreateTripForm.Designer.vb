<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTripForm
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
        Panel2 = New Panel()
        ToComboBox = New ComboBox()
        ToLabel = New Label()
        ComboBox1 = New ComboBox()
        FromLabel = New Label()
        ConductorComboBox = New ComboBox()
        DriverComboBox = New ComboBox()
        VehicleComboBox = New ComboBox()
        StartTripButton = New Button()
        CancelTripButton = New Button()
        ConductorTextbox = New Label()
        DriverLabel = New Label()
        VehicleLabel = New Label()
        exitButton = New Button()
        CreateTrip = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ToComboBox)
        Panel2.Controls.Add(ToLabel)
        Panel2.Controls.Add(ComboBox1)
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
        Panel2.Location = New Point(0, 90)
        Panel2.Margin = New Padding(6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1227, 1014)
        Panel2.TabIndex = 5
        ' 
        ' ToComboBox
        ' 
        ToComboBox.FormattingEnabled = True
        ToComboBox.Location = New Point(496, 102)
        ToComboBox.Name = "ToComboBox"
        ToComboBox.Size = New Size(382, 49)
        ToComboBox.TabIndex = 17
        ' 
        ' ToLabel
        ' 
        ToLabel.AutoSize = True
        ToLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        ToLabel.Location = New Point(496, 45)
        ToLabel.Name = "ToLabel"
        ToLabel.Size = New Size(53, 63)
        ToLabel.TabIndex = 16
        ToLabel.Text = "To"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(32, 102)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(333, 49)
        ComboBox1.TabIndex = 15
        ' 
        ' FromLabel
        ' 
        FromLabel.AutoSize = True
        FromLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        FromLabel.Location = New Point(32, 45)
        FromLabel.Name = "FromLabel"
        FromLabel.Size = New Size(87, 63)
        FromLabel.TabIndex = 14
        FromLabel.Text = "From"
        ' 
        ' ConductorComboBox
        ' 
        ConductorComboBox.FormattingEnabled = True
        ConductorComboBox.Location = New Point(32, 644)
        ConductorComboBox.Name = "ConductorComboBox"
        ConductorComboBox.Size = New Size(846, 49)
        ConductorComboBox.TabIndex = 13
        ' 
        ' DriverComboBox
        ' 
        DriverComboBox.FormattingEnabled = True
        DriverComboBox.Location = New Point(32, 459)
        DriverComboBox.Name = "DriverComboBox"
        DriverComboBox.Size = New Size(846, 49)
        DriverComboBox.TabIndex = 12
        ' 
        ' VehicleComboBox
        ' 
        VehicleComboBox.FormattingEnabled = True
        VehicleComboBox.Location = New Point(32, 272)
        VehicleComboBox.Name = "VehicleComboBox"
        VehicleComboBox.Size = New Size(846, 49)
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
        StartTripButton.Location = New Point(525, 910)
        StartTripButton.Margin = New Padding(6)
        StartTripButton.Name = "StartTripButton"
        StartTripButton.Size = New Size(208, 72)
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
        CancelTripButton.Location = New Point(178, 910)
        CancelTripButton.Margin = New Padding(6)
        CancelTripButton.Name = "CancelTripButton"
        CancelTripButton.Size = New Size(208, 72)
        CancelTripButton.TabIndex = 9
        CancelTripButton.Text = "Cancel"
        CancelTripButton.UseVisualStyleBackColor = False
        ' 
        ' ConductorTextbox
        ' 
        ConductorTextbox.AutoSize = True
        ConductorTextbox.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConductorTextbox.Location = New Point(32, 578)
        ConductorTextbox.Margin = New Padding(6, 0, 6, 0)
        ConductorTextbox.Name = "ConductorTextbox"
        ConductorTextbox.Size = New Size(147, 63)
        ConductorTextbox.TabIndex = 5
        ConductorTextbox.Text = "Conductor"
        ' 
        ' DriverLabel
        ' 
        DriverLabel.AutoSize = True
        DriverLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DriverLabel.Location = New Point(32, 394)
        DriverLabel.Margin = New Padding(6, 0, 6, 0)
        DriverLabel.Name = "DriverLabel"
        DriverLabel.Size = New Size(99, 63)
        DriverLabel.TabIndex = 3
        DriverLabel.Text = "Driver"
        ' 
        ' VehicleLabel
        ' 
        VehicleLabel.AutoSize = True
        VehicleLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VehicleLabel.Location = New Point(32, 213)
        VehicleLabel.Margin = New Padding(6, 0, 6, 0)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New Size(106, 63)
        VehicleLabel.TabIndex = 1
        VehicleLabel.Text = "Vehicle"
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
        exitButton.Location = New Point(1165, 0)
        exitButton.Margin = New Padding(6)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(62, 90)
        exitButton.TabIndex = 5
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' CreateTrip
        ' 
        CreateTrip.AutoSize = True
        CreateTrip.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CreateTrip.Location = New Point(6, 14)
        CreateTrip.Margin = New Padding(6, 0, 6, 0)
        CreateTrip.Name = "CreateTrip"
        CreateTrip.Size = New Size(179, 74)
        CreateTrip.TabIndex = 0
        CreateTrip.Text = "Create Trip"
        CreateTrip.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(exitButton)
        Panel1.Controls.Add(CreateTrip)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1227, 90)
        Panel1.TabIndex = 4
        ' 
        ' CreateTripForm
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1227, 1104)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CreateTripForm"
        Text = "CreateTripForm"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToComboBox As ComboBox
    Friend WithEvents ToLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FromLabel As Label
    Friend WithEvents ConductorComboBox As ComboBox
    Friend WithEvents DriverComboBox As ComboBox
    Friend WithEvents VehicleComboBox As ComboBox
    Friend WithEvents StartTripButton As Button
    Friend WithEvents CancelTripButton As Button
    Friend WithEvents ConductorTextbox As Label
    Friend WithEvents DriverLabel As Label
    Friend WithEvents VehicleLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents CreateTrip As Label
    Friend WithEvents Panel1 As Panel
End Class
