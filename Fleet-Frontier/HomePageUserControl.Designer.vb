<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePageUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePageUserControl))
        Panel1 = New Panel()
        MonthCalendar1 = New MonthCalendar()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        VehiclePanel = New Panel()
        TotalVehiclesLabel = New Label()
        RentedLabel = New Label()
        VehicleOnTripLabel = New Label()
        VehicleAvailableLabel = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        AddVehicleButton = New Button()
        Label3 = New Label()
        TripPanel = New Panel()
        AddTripsButton = New Button()
        Label4 = New Label()
        StaffPanel = New Panel()
        StaffTotalLabel = New Label()
        Label20 = New Label()
        StaffOnTripLabel = New Label()
        AvailableConductorsLabel = New Label()
        AvailableDriversLabel = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label21 = New Label()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        AddStaffButton = New Button()
        Label5 = New Label()
        ActivityPanel = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        VehiclePanel.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TripPanel.SuspendLayout()
        StaffPanel.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        ActivityPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(MonthCalendar1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(726, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(298, 661)
        Panel1.TabIndex = 0
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        MonthCalendar1.Location = New Point(19, 42)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(152, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 28)
        Panel2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(33, 0)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(358, 27)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 28)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 14F, FontStyle.Bold)
        Label1.Location = New Point(50, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 45)
        Label1.TabIndex = 2
        Label1.Text = "Dashboard"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(22, 59)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(5)
        Panel3.Size = New Size(177, 45)
        Panel3.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Left
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(5, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        Label2.Location = New Point(321, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 37)
        Label2.TabIndex = 4
        Label2.Text = "Activity"
        ' 
        ' VehiclePanel
        ' 
        VehiclePanel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        VehiclePanel.Controls.Add(TotalVehiclesLabel)
        VehiclePanel.Controls.Add(RentedLabel)
        VehiclePanel.Controls.Add(VehicleOnTripLabel)
        VehiclePanel.Controls.Add(VehicleAvailableLabel)
        VehiclePanel.Controls.Add(Label9)
        VehiclePanel.Controls.Add(Label8)
        VehiclePanel.Controls.Add(Label7)
        VehiclePanel.Controls.Add(Label6)
        VehiclePanel.Controls.Add(PictureBox6)
        VehiclePanel.Controls.Add(PictureBox5)
        VehiclePanel.Controls.Add(PictureBox4)
        VehiclePanel.Controls.Add(PictureBox3)
        VehiclePanel.Controls.Add(AddVehicleButton)
        VehiclePanel.Controls.Add(Label3)
        VehiclePanel.Location = New Point(434, 48)
        VehiclePanel.Name = "VehiclePanel"
        VehiclePanel.Size = New Size(260, 206)
        VehiclePanel.TabIndex = 5
        ' 
        ' TotalVehiclesLabel
        ' 
        TotalVehiclesLabel.AutoSize = True
        TotalVehiclesLabel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TotalVehiclesLabel.ForeColor = Color.White
        TotalVehiclesLabel.Location = New Point(188, 163)
        TotalVehiclesLabel.Name = "TotalVehiclesLabel"
        TotalVehiclesLabel.Size = New Size(15, 20)
        TotalVehiclesLabel.TabIndex = 19
        TotalVehiclesLabel.Text = "*"
        ' 
        ' RentedLabel
        ' 
        RentedLabel.AutoSize = True
        RentedLabel.BackColor = Color.Orange
        RentedLabel.Location = New Point(188, 128)
        RentedLabel.Name = "RentedLabel"
        RentedLabel.Size = New Size(15, 20)
        RentedLabel.TabIndex = 18
        RentedLabel.Text = "*"
        ' 
        ' VehicleOnTripLabel
        ' 
        VehicleOnTripLabel.AutoSize = True
        VehicleOnTripLabel.BackColor = Color.DeepSkyBlue
        VehicleOnTripLabel.Location = New Point(188, 90)
        VehicleOnTripLabel.Name = "VehicleOnTripLabel"
        VehicleOnTripLabel.Size = New Size(15, 20)
        VehicleOnTripLabel.TabIndex = 17
        VehicleOnTripLabel.Text = "*"
        ' 
        ' VehicleAvailableLabel
        ' 
        VehicleAvailableLabel.AutoSize = True
        VehicleAvailableLabel.BackColor = Color.DarkSeaGreen
        VehicleAvailableLabel.Location = New Point(188, 55)
        VehicleAvailableLabel.Name = "VehicleAvailableLabel"
        VehicleAvailableLabel.Size = New Size(15, 20)
        VehicleAvailableLabel.TabIndex = 16
        VehicleAvailableLabel.Text = "*"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(63, 163)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 20)
        Label9.TabIndex = 15
        Label9.Text = "Total"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(63, 128)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 20)
        Label8.TabIndex = 14
        Label8.Text = "Rented out"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(63, 91)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 20)
        Label7.TabIndex = 13
        Label7.Text = "On trip"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(63, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 20)
        Label6.TabIndex = 12
        Label6.Text = "Available"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(24, 128)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(24, 24)
        PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(24, 163)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(24, 24)
        PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(24, 55)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 24)
        PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(24, 91)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(24, 24)
        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' AddVehicleButton
        ' 
        AddVehicleButton.BackColor = Color.Silver
        AddVehicleButton.FlatAppearance.MouseDownBackColor = Color.Gray
        AddVehicleButton.FlatAppearance.MouseOverBackColor = Color.Silver
        AddVehicleButton.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        AddVehicleButton.Location = New Point(210, 5)
        AddVehicleButton.Name = "AddVehicleButton"
        AddVehicleButton.Size = New Size(47, 47)
        AddVehicleButton.TabIndex = 7
        AddVehicleButton.Text = "+"
        AddVehicleButton.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        Label3.Location = New Point(63, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 37)
        Label3.TabIndex = 5
        Label3.Text = "Vehicle Status"
        ' 
        ' TripPanel
        ' 
        TripPanel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TripPanel.Controls.Add(AddTripsButton)
        TripPanel.Controls.Add(Label4)
        TripPanel.Location = New Point(15, 48)
        TripPanel.Name = "TripPanel"
        TripPanel.Padding = New Padding(10)
        TripPanel.Size = New Size(395, 473)
        TripPanel.TabIndex = 6
        ' 
        ' AddTripsButton
        ' 
        AddTripsButton.BackColor = Color.Silver
        AddTripsButton.FlatAppearance.MouseDownBackColor = Color.Gray
        AddTripsButton.FlatAppearance.MouseOverBackColor = Color.Silver
        AddTripsButton.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        AddTripsButton.Location = New Point(345, 3)
        AddTripsButton.Name = "AddTripsButton"
        AddTripsButton.Size = New Size(47, 47)
        AddTripsButton.TabIndex = 6
        AddTripsButton.Text = "+"
        AddTripsButton.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        Label4.Location = New Point(166, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 37)
        Label4.TabIndex = 5
        Label4.Text = "Trips"
        ' 
        ' StaffPanel
        ' 
        StaffPanel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        StaffPanel.Controls.Add(StaffTotalLabel)
        StaffPanel.Controls.Add(Label20)
        StaffPanel.Controls.Add(StaffOnTripLabel)
        StaffPanel.Controls.Add(AvailableConductorsLabel)
        StaffPanel.Controls.Add(AvailableDriversLabel)
        StaffPanel.Controls.Add(Label18)
        StaffPanel.Controls.Add(Label19)
        StaffPanel.Controls.Add(Label21)
        StaffPanel.Controls.Add(PictureBox7)
        StaffPanel.Controls.Add(PictureBox8)
        StaffPanel.Controls.Add(PictureBox9)
        StaffPanel.Controls.Add(PictureBox10)
        StaffPanel.Controls.Add(AddStaffButton)
        StaffPanel.Controls.Add(Label5)
        StaffPanel.Location = New Point(434, 260)
        StaffPanel.Name = "StaffPanel"
        StaffPanel.Size = New Size(260, 261)
        StaffPanel.TabIndex = 7
        ' 
        ' StaffTotalLabel
        ' 
        StaffTotalLabel.AutoSize = True
        StaffTotalLabel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        StaffTotalLabel.ForeColor = Color.White
        StaffTotalLabel.Location = New Point(221, 179)
        StaffTotalLabel.Name = "StaffTotalLabel"
        StaffTotalLabel.Size = New Size(15, 20)
        StaffTotalLabel.TabIndex = 31
        StaffTotalLabel.Text = "*"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(63, 107)
        Label20.Name = "Label20"
        Label20.Size = New Size(150, 20)
        Label20.TabIndex = 25
        Label20.Text = "Available Conductors"
        ' 
        ' StaffOnTripLabel
        ' 
        StaffOnTripLabel.AutoSize = True
        StaffOnTripLabel.BackColor = Color.Orange
        StaffOnTripLabel.Location = New Point(219, 144)
        StaffOnTripLabel.Name = "StaffOnTripLabel"
        StaffOnTripLabel.Size = New Size(15, 20)
        StaffOnTripLabel.TabIndex = 30
        StaffOnTripLabel.Text = "*"
        ' 
        ' AvailableConductorsLabel
        ' 
        AvailableConductorsLabel.AutoSize = True
        AvailableConductorsLabel.BackColor = Color.DeepSkyBlue
        AvailableConductorsLabel.Location = New Point(219, 107)
        AvailableConductorsLabel.Name = "AvailableConductorsLabel"
        AvailableConductorsLabel.Size = New Size(15, 20)
        AvailableConductorsLabel.TabIndex = 29
        AvailableConductorsLabel.Text = "*"
        ' 
        ' AvailableDriversLabel
        ' 
        AvailableDriversLabel.AutoSize = True
        AvailableDriversLabel.BackColor = Color.DarkSeaGreen
        AvailableDriversLabel.Location = New Point(219, 71)
        AvailableDriversLabel.Name = "AvailableDriversLabel"
        AvailableDriversLabel.Size = New Size(15, 20)
        AvailableDriversLabel.TabIndex = 28
        AvailableDriversLabel.Text = "*"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(63, 179)
        Label18.Name = "Label18"
        Label18.Size = New Size(42, 20)
        Label18.TabIndex = 27
        Label18.Text = "Total"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(63, 144)
        Label19.Name = "Label19"
        Label19.Size = New Size(55, 20)
        Label19.TabIndex = 26
        Label19.Text = "On trip"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(63, 71)
        Label21.Name = "Label21"
        Label21.Size = New Size(121, 20)
        Label21.TabIndex = 24
        Label21.Text = "Available Drivers"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(24, 144)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(24, 24)
        PictureBox7.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox7.TabIndex = 23
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(24, 179)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(24, 24)
        PictureBox8.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox8.TabIndex = 22
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(24, 71)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(24, 24)
        PictureBox9.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox9.TabIndex = 21
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(24, 107)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(24, 24)
        PictureBox10.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox10.TabIndex = 20
        PictureBox10.TabStop = False
        ' 
        ' AddStaffButton
        ' 
        AddStaffButton.BackColor = Color.Silver
        AddStaffButton.FlatAppearance.MouseDownBackColor = Color.Gray
        AddStaffButton.FlatAppearance.MouseOverBackColor = Color.Silver
        AddStaffButton.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        AddStaffButton.Location = New Point(209, 4)
        AddStaffButton.Name = "AddStaffButton"
        AddStaffButton.Size = New Size(47, 47)
        AddStaffButton.TabIndex = 8
        AddStaffButton.Text = "+"
        AddStaffButton.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        Label5.Location = New Point(104, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 37)
        Label5.TabIndex = 5
        Label5.Text = "Staff"
        ' 
        ' ActivityPanel
        ' 
        ActivityPanel.Controls.Add(Label2)
        ActivityPanel.Controls.Add(StaffPanel)
        ActivityPanel.Controls.Add(TripPanel)
        ActivityPanel.Controls.Add(VehiclePanel)
        ActivityPanel.Location = New Point(14, 111)
        ActivityPanel.Name = "ActivityPanel"
        ActivityPanel.Size = New Size(704, 531)
        ActivityPanel.TabIndex = 8
        ' 
        ' HomePageUserControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        Controls.Add(ActivityPanel)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(1)
        Name = "HomePageUserControl"
        Size = New Size(1024, 661)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        VehiclePanel.ResumeLayout(False)
        VehiclePanel.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TripPanel.ResumeLayout(False)
        TripPanel.PerformLayout()
        StaffPanel.ResumeLayout(False)
        StaffPanel.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ActivityPanel.ResumeLayout(False)
        ActivityPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents VehiclePanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TripPanel As Panel
    Friend WithEvents StaffPanel As Panel
    Friend WithEvents ActivityPanel As Panel
    Friend WithEvents AddTripsButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddVehicleButton As Button
    Friend WithEvents AddStaffButton As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TotalVehiclesLabel As Label
    Friend WithEvents RentedLabel As Label
    Friend WithEvents VehicleOnTripLabel As Label
    Friend WithEvents VehicleAvailableLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StaffTotalLabel As Label
    Friend WithEvents StaffOnTripLabel As Label
    Friend WithEvents AvailableConductorsLabel As Label
    Friend WithEvents AvailableDriversLabel As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox

End Class
