<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        controlBarPanel = New Panel()
        minimizeButton = New Button()
        controlBarLabel = New Label()
        exitButton = New Button()
        controlBarIcon = New PictureBox()
        sideBar = New Panel()
        tripButton = New Button()
        logoutButton = New Button()
        rentButton = New Button()
        staffButton = New Button()
        vehicleButton = New Button()
        vehicleMenu = New ContextMenuStrip(components)
        AddVehicleToolStripMenuItem = New ToolStripMenuItem()
        FleetCatalogueToolStripMenuItem = New ToolStripMenuItem()
        homeButton = New Button()
        logoPanel = New Panel()
        logoLabel = New Label()
        busLogo = New PictureBox()
        footerPanel = New Panel()
        headerPanel = New Panel()
        HomePageLabel = New Label()
        staffMenu = New ContextMenuStrip(components)
        addStaffButton = New ToolStripMenuItem()
        allStaffButton = New ToolStripMenuItem()
        middlePanel = New Panel()
        Panel1 = New Panel()
        WelcomeLabel = New Label()
        PictureBox1 = New PictureBox()
        HomePageUserControl1 = New HomePageUserControl()
        controlBarPanel.SuspendLayout()
        CType(controlBarIcon, ComponentModel.ISupportInitialize).BeginInit()
        sideBar.SuspendLayout()
        vehicleMenu.SuspendLayout()
        logoPanel.SuspendLayout()
        CType(busLogo, ComponentModel.ISupportInitialize).BeginInit()
        headerPanel.SuspendLayout()
        staffMenu.SuspendLayout()
        middlePanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' controlBarPanel
        ' 
        controlBarPanel.BackColor = Color.FromArgb(64, 64, 64)
        controlBarPanel.Controls.Add(minimizeButton)
        controlBarPanel.Controls.Add(controlBarLabel)
        controlBarPanel.Controls.Add(exitButton)
        controlBarPanel.Controls.Add(controlBarIcon)
        controlBarPanel.Dock = DockStyle.Top
        controlBarPanel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        controlBarPanel.ForeColor = Color.White
        controlBarPanel.Location = New Point(0, 0)
        controlBarPanel.Margin = New Padding(2, 3, 2, 3)
        controlBarPanel.Name = "controlBarPanel"
        controlBarPanel.Size = New Size(1188, 34)
        controlBarPanel.TabIndex = 0
        ' 
        ' minimizeButton
        ' 
        minimizeButton.Dock = DockStyle.Right
        minimizeButton.FlatAppearance.BorderSize = 0
        minimizeButton.FlatStyle = FlatStyle.Flat
        minimizeButton.Font = New Font("Leelawadee UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        minimizeButton.ForeColor = Color.Black
        minimizeButton.Location = New Point(1130, 0)
        minimizeButton.Name = "minimizeButton"
        minimizeButton.Size = New Size(29, 34)
        minimizeButton.TabIndex = 4
        minimizeButton.Text = "-"
        minimizeButton.UseVisualStyleBackColor = True
        ' 
        ' controlBarLabel
        ' 
        controlBarLabel.AutoSize = True
        controlBarLabel.Font = New Font("MV Boli", 11.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        controlBarLabel.ForeColor = Color.FromArgb(255, 128, 0)
        controlBarLabel.Location = New Point(45, 4)
        controlBarLabel.Margin = New Padding(2, 0, 2, 0)
        controlBarLabel.Name = "controlBarLabel"
        controlBarLabel.Size = New Size(278, 49)
        controlBarLabel.TabIndex = 0
        controlBarLabel.Text = "Fleet Frontier"
        ' 
        ' exitButton
        ' 
        exitButton.Dock = DockStyle.Right
        exitButton.FlatAppearance.BorderSize = 0
        exitButton.FlatStyle = FlatStyle.Flat
        exitButton.Font = New Font("Leelawadee UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        exitButton.ForeColor = Color.Black
        exitButton.Location = New Point(1159, 0)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(29, 34)
        exitButton.TabIndex = 1
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' controlBarIcon
        ' 
        controlBarIcon.BackColor = Color.FromArgb(255, 128, 0)
        controlBarIcon.Dock = DockStyle.Left
        controlBarIcon.Image = CType(resources.GetObject("controlBarIcon.Image"), Image)
        controlBarIcon.Location = New Point(0, 0)
        controlBarIcon.Name = "controlBarIcon"
        controlBarIcon.Size = New Size(40, 34)
        controlBarIcon.SizeMode = PictureBoxSizeMode.StretchImage
        controlBarIcon.TabIndex = 3
        controlBarIcon.TabStop = False
        ' 
        ' sideBar
        ' 
        sideBar.BackColor = Color.DimGray
        sideBar.Controls.Add(tripButton)
        sideBar.Controls.Add(logoutButton)
        sideBar.Controls.Add(rentButton)
        sideBar.Controls.Add(staffButton)
        sideBar.Controls.Add(vehicleButton)
        sideBar.Controls.Add(homeButton)
        sideBar.Controls.Add(logoPanel)
        sideBar.Dock = DockStyle.Left
        sideBar.Location = New Point(0, 34)
        sideBar.Margin = New Padding(2, 3, 2, 3)
        sideBar.Name = "sideBar"
        sideBar.Size = New Size(223, 678)
        sideBar.TabIndex = 0
        ' 
        ' tripButton
        ' 
        tripButton.Dock = DockStyle.Top
        tripButton.FlatAppearance.BorderSize = 0
        tripButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0)
        tripButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0)
        tripButton.FlatStyle = FlatStyle.Flat
        tripButton.Font = New Font("Gabriola", 9.0F)
        tripButton.ForeColor = Color.White
        tripButton.Image = CType(resources.GetObject("tripButton.Image"), Image)
        tripButton.ImageAlign = ContentAlignment.MiddleLeft
        tripButton.Location = New Point(0, 332)
        tripButton.Margin = New Padding(2, 3, 2, 3)
        tripButton.Name = "tripButton"
        tripButton.Padding = New Padding(6, 0, 0, 0)
        tripButton.Size = New Size(223, 50)
        tripButton.TabIndex = 6
        tripButton.Text = "Trips"
        tripButton.TextAlign = ContentAlignment.MiddleLeft
        tripButton.TextImageRelation = TextImageRelation.ImageBeforeText
        tripButton.UseVisualStyleBackColor = True
        ' 
        ' logoutButton
        ' 
        logoutButton.Dock = DockStyle.Bottom
        logoutButton.FlatAppearance.BorderSize = 0
        logoutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0)
        logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0)
        logoutButton.FlatStyle = FlatStyle.Flat
        logoutButton.Font = New Font("Gabriola", 9.0F)
        logoutButton.ForeColor = Color.White
        logoutButton.Image = CType(resources.GetObject("logoutButton.Image"), Image)
        logoutButton.ImageAlign = ContentAlignment.MiddleLeft
        logoutButton.Location = New Point(0, 628)
        logoutButton.Margin = New Padding(2, 3, 2, 3)
        logoutButton.Name = "logoutButton"
        logoutButton.Padding = New Padding(6, 0, 0, 0)
        logoutButton.Size = New Size(223, 50)
        logoutButton.TabIndex = 5
        logoutButton.Text = "Log Out "
        logoutButton.TextAlign = ContentAlignment.MiddleLeft
        logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText
        logoutButton.UseVisualStyleBackColor = True
        ' 
        ' rentButton
        ' 
        rentButton.Dock = DockStyle.Top
        rentButton.FlatAppearance.BorderSize = 0
        rentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0)
        rentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0)
        rentButton.FlatStyle = FlatStyle.Flat
        rentButton.Font = New Font("Gabriola", 9.0F)
        rentButton.ForeColor = Color.White
        rentButton.Image = CType(resources.GetObject("rentButton.Image"), Image)
        rentButton.ImageAlign = ContentAlignment.MiddleLeft
        rentButton.Location = New Point(0, 282)
        rentButton.Margin = New Padding(2, 3, 2, 3)
        rentButton.Name = "rentButton"
        rentButton.Padding = New Padding(6, 0, 0, 0)
        rentButton.Size = New Size(223, 50)
        rentButton.TabIndex = 4
        rentButton.Text = "Renting"
        rentButton.TextAlign = ContentAlignment.MiddleLeft
        rentButton.TextImageRelation = TextImageRelation.ImageBeforeText
        rentButton.UseVisualStyleBackColor = True
        ' 
        ' staffButton
        ' 
        staffButton.Dock = DockStyle.Top
        staffButton.FlatAppearance.BorderSize = 0
        staffButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0)
        staffButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0)
        staffButton.FlatStyle = FlatStyle.Flat
        staffButton.Font = New Font("Gabriola", 9.0F)
        staffButton.ForeColor = Color.White
        staffButton.Image = CType(resources.GetObject("staffButton.Image"), Image)
        staffButton.ImageAlign = ContentAlignment.MiddleLeft
        staffButton.Location = New Point(0, 232)
        staffButton.Margin = New Padding(2, 3, 2, 3)
        staffButton.Name = "staffButton"
        staffButton.Padding = New Padding(6, 0, 0, 0)
        staffButton.Size = New Size(223, 50)
        staffButton.TabIndex = 3
        staffButton.Text = "Staff"
        staffButton.TextAlign = ContentAlignment.MiddleLeft
        staffButton.TextImageRelation = TextImageRelation.ImageBeforeText
        staffButton.UseVisualStyleBackColor = True
        ' 
        ' vehicleButton
        ' 
        vehicleButton.AllowDrop = True
        vehicleButton.ContextMenuStrip = vehicleMenu
        vehicleButton.Dock = DockStyle.Top
        vehicleButton.FlatAppearance.BorderSize = 0
        vehicleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0)
        vehicleButton.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        vehicleButton.FlatStyle = FlatStyle.Flat
        vehicleButton.Font = New Font("Gabriola", 9.0F)
        vehicleButton.ForeColor = Color.White
        vehicleButton.Image = CType(resources.GetObject("vehicleButton.Image"), Image)
        vehicleButton.ImageAlign = ContentAlignment.MiddleLeft
        vehicleButton.Location = New Point(0, 182)
        vehicleButton.Margin = New Padding(2, 3, 2, 3)
        vehicleButton.Name = "vehicleButton"
        vehicleButton.Padding = New Padding(6, 0, 0, 0)
        vehicleButton.Size = New Size(223, 50)
        vehicleButton.TabIndex = 2
        vehicleButton.Text = "Vehicle"
        vehicleButton.TextAlign = ContentAlignment.MiddleLeft
        vehicleButton.TextImageRelation = TextImageRelation.ImageBeforeText
        vehicleButton.UseVisualStyleBackColor = True
        ' 
        ' vehicleMenu
        ' 
        vehicleMenu.BackColor = Color.Gray
        vehicleMenu.ImageScalingSize = New Size(20, 20)
        vehicleMenu.Items.AddRange(New ToolStripItem() {AddVehicleToolStripMenuItem, FleetCatalogueToolStripMenuItem})
        vehicleMenu.Name = "vehicleMenu"
        vehicleMenu.ShowImageMargin = False
        vehicleMenu.Size = New Size(219, 128)
        ' 
        ' AddVehicleToolStripMenuItem
        ' 
        AddVehicleToolStripMenuItem.BackColor = Color.Gray
        AddVehicleToolStripMenuItem.CheckOnClick = True
        AddVehicleToolStripMenuItem.Font = New Font("Gabriola", 9.0F)
        AddVehicleToolStripMenuItem.ForeColor = Color.White
        AddVehicleToolStripMenuItem.Name = "AddVehicleToolStripMenuItem"
        AddVehicleToolStripMenuItem.Size = New Size(218, 62)
        AddVehicleToolStripMenuItem.Text = "Add Vehicle"
        ' 
        ' FleetCatalogueToolStripMenuItem
        ' 
        FleetCatalogueToolStripMenuItem.BackColor = Color.Gray
        FleetCatalogueToolStripMenuItem.CheckOnClick = True
        FleetCatalogueToolStripMenuItem.Font = New Font("Gabriola", 9.0F)
        FleetCatalogueToolStripMenuItem.ForeColor = Color.White
        FleetCatalogueToolStripMenuItem.Name = "FleetCatalogueToolStripMenuItem"
        FleetCatalogueToolStripMenuItem.Size = New Size(218, 62)
        FleetCatalogueToolStripMenuItem.Text = "Fleet Catalogue"
        ' 
        ' homeButton
        ' 
        homeButton.Dock = DockStyle.Top
        homeButton.FlatAppearance.BorderSize = 0
        homeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0)
        homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0)
        homeButton.FlatStyle = FlatStyle.Flat
        homeButton.Font = New Font("Gabriola", 9.0F)
        homeButton.ForeColor = Color.White
        homeButton.Image = CType(resources.GetObject("homeButton.Image"), Image)
        homeButton.ImageAlign = ContentAlignment.MiddleLeft
        homeButton.Location = New Point(0, 132)
        homeButton.Margin = New Padding(2, 3, 2, 3)
        homeButton.Name = "homeButton"
        homeButton.Padding = New Padding(6, 0, 0, 0)
        homeButton.Size = New Size(223, 50)
        homeButton.TabIndex = 1
        homeButton.Text = "Home"
        homeButton.TextAlign = ContentAlignment.MiddleLeft
        homeButton.TextImageRelation = TextImageRelation.ImageBeforeText
        homeButton.UseVisualStyleBackColor = True
        ' 
        ' logoPanel
        ' 
        logoPanel.Controls.Add(logoLabel)
        logoPanel.Controls.Add(busLogo)
        logoPanel.Dock = DockStyle.Top
        logoPanel.Location = New Point(0, 0)
        logoPanel.Margin = New Padding(2, 3, 2, 3)
        logoPanel.Name = "logoPanel"
        logoPanel.Size = New Size(223, 132)
        logoPanel.TabIndex = 0
        ' 
        ' logoLabel
        ' 
        logoLabel.AutoSize = True
        logoLabel.Font = New Font("MV Boli", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        logoLabel.ForeColor = Color.DarkOrange
        logoLabel.Location = New Point(13, 87)
        logoLabel.Margin = New Padding(2, 0, 2, 0)
        logoLabel.Name = "logoLabel"
        logoLabel.Size = New Size(376, 52)
        logoLabel.TabIndex = 1
        logoLabel.Text = "FLEET FRONTIER"
        ' 
        ' busLogo
        ' 
        busLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        busLogo.Image = CType(resources.GetObject("busLogo.Image"), Image)
        busLogo.Location = New Point(13, 6)
        busLogo.Margin = New Padding(2, 3, 2, 3)
        busLogo.Name = "busLogo"
        busLogo.Size = New Size(194, 107)
        busLogo.SizeMode = PictureBoxSizeMode.StretchImage
        busLogo.TabIndex = 0
        busLogo.TabStop = False
        ' 
        ' footerPanel
        ' 
        footerPanel.BackColor = Color.DarkGray
        footerPanel.Dock = DockStyle.Bottom
        footerPanel.Location = New Point(223, 677)
        footerPanel.Margin = New Padding(2, 3, 2, 3)
        footerPanel.Name = "footerPanel"
        footerPanel.Size = New Size(965, 35)
        footerPanel.TabIndex = 1
        ' 
        ' headerPanel
        ' 
        headerPanel.BackColor = Color.Silver
        headerPanel.Controls.Add(HomePageLabel)
        headerPanel.Dock = DockStyle.Top
        headerPanel.Location = New Point(223, 34)
        headerPanel.Margin = New Padding(2, 3, 2, 3)
        headerPanel.Name = "headerPanel"
        headerPanel.Size = New Size(965, 53)
        headerPanel.TabIndex = 2
        ' 
        ' HomePageLabel
        ' 
        HomePageLabel.AutoSize = True
        HomePageLabel.Dock = DockStyle.Top
        HomePageLabel.Font = New Font("Gabriola", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0)
        HomePageLabel.Location = New Point(0, 0)
        HomePageLabel.Name = "HomePageLabel"
        HomePageLabel.Size = New Size(152, 63)
        HomePageLabel.TabIndex = 0
        HomePageLabel.Text = "Home Page"
        ' 
        ' staffMenu
        ' 
        staffMenu.BackColor = Color.Gray
        staffMenu.ImageScalingSize = New Size(20, 20)
        staffMenu.Items.AddRange(New ToolStripItem() {addStaffButton, allStaffButton})
        staffMenu.Name = "vehicleMenu"
        staffMenu.ShowImageMargin = False
        staffMenu.Size = New Size(166, 128)
        ' 
        ' addStaffButton
        ' 
        addStaffButton.BackColor = Color.Gray
        addStaffButton.CheckOnClick = True
        addStaffButton.Font = New Font("Gabriola", 9.0F)
        addStaffButton.ForeColor = Color.White
        addStaffButton.Name = "addStaffButton"
        addStaffButton.Size = New Size(165, 62)
        addStaffButton.Text = "Add Staff"
        ' 
        ' allStaffButton
        ' 
        allStaffButton.BackColor = Color.Gray
        allStaffButton.CheckOnClick = True
        allStaffButton.Font = New Font("Gabriola", 9.0F)
        allStaffButton.ForeColor = Color.White
        allStaffButton.Name = "allStaffButton"
        allStaffButton.Size = New Size(165, 62)
        allStaffButton.Text = "All Staff"
        ' 
        ' middlePanel
        ' 
        middlePanel.Controls.Add(Panel1)
        middlePanel.Controls.Add(HomePageUserControl1)
        middlePanel.Dock = DockStyle.Fill
        middlePanel.Location = New Point(223, 87)
        middlePanel.Name = "middlePanel"
        middlePanel.Size = New Size(965, 590)
        middlePanel.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(WelcomeLabel)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(965, 590)
        Panel1.TabIndex = 1
        ' 
        ' WelcomeLabel
        ' 
        WelcomeLabel.AutoSize = True
        WelcomeLabel.BackColor = Color.Transparent
        WelcomeLabel.Dock = DockStyle.Fill
        WelcomeLabel.Font = New Font("Gabriola", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0)
        WelcomeLabel.Location = New Point(0, 0)
        WelcomeLabel.Name = "WelcomeLabel"
        WelcomeLabel.Size = New Size(249, 189)
        WelcomeLabel.TabIndex = 0
        WelcomeLabel.Text = "Welcome Back!!" + vbCrLf + "Fleet-Frontier Sacco" + vbCrLf + vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.fleet_frontier_pic
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(965, 590)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' HomePageUserControl1
        ' 
        HomePageUserControl1.Dock = DockStyle.Fill
        HomePageUserControl1.Location = New Point(0, 0)
        HomePageUserControl1.Name = "HomePageUserControl1"
        HomePageUserControl1.Size = New Size(965, 590)
        HomePageUserControl1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(16.0F, 37.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1188, 712)
        ControlBox = False
        Controls.Add(middlePanel)
        Controls.Add(headerPanel)
        Controls.Add(footerPanel)
        Controls.Add(sideBar)
        Controls.Add(controlBarPanel)
        Font = New Font("Impact", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 3, 2, 3)
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        controlBarPanel.ResumeLayout(False)
        controlBarPanel.PerformLayout()
        CType(controlBarIcon, ComponentModel.ISupportInitialize).EndInit()
        sideBar.ResumeLayout(False)
        vehicleMenu.ResumeLayout(False)
        logoPanel.ResumeLayout(False)
        logoPanel.PerformLayout()
        CType(busLogo, ComponentModel.ISupportInitialize).EndInit()
        headerPanel.ResumeLayout(False)
        headerPanel.PerformLayout()
        staffMenu.ResumeLayout(False)
        middlePanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents controlBarPanel As Panel
    Friend WithEvents sideBar As Panel
    Friend WithEvents footerPanel As Panel
    Friend WithEvents headerPanel As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents homeButton As Button
    Friend WithEvents logoutButton As Button
    Friend WithEvents rentButton As Button
    Friend WithEvents staffButton As Button
    Friend WithEvents vehicleButton As Button
    Friend WithEvents tripButton As Button
    Friend WithEvents controlBarLabel As Label
    Friend WithEvents busLogo As PictureBox
    Friend WithEvents logoLabel As Label
    Friend WithEvents vehicleMenu As ContextMenuStrip
    Friend WithEvents AddVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FleetCatalogueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitButton As Button
    Friend WithEvents controlBarIcon As PictureBox
    Friend WithEvents minimizeButton As Button
    Friend WithEvents staffMenu As ContextMenuStrip
    Friend WithEvents addStaffButton As ToolStripMenuItem
    Friend WithEvents allStaffButton As ToolStripMenuItem
    Friend WithEvents middlePanel As Panel
    Friend WithEvents HomePageLabel As Label
    Friend WithEvents HomePageUserControl1 As HomePageUserControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
