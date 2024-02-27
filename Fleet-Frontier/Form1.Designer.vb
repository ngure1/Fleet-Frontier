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
        Panel1 = New Panel()
        minimizeButton = New Button()
        Button2 = New Button()
        exitButton = New Button()
        Label1 = New Label()
        sideBar = New Panel()
        tripButton = New Button()
        logoutButton = New Button()
        rentButton = New Button()
        staffButton = New Button()
        vehicleButton = New Button()
        homeButton = New Button()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        sideBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(minimizeButton)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(exitButton)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1182, 33)
        Panel1.TabIndex = 0
        ' 
        ' minimizeButton
        ' 
        minimizeButton.Dock = DockStyle.Right
        minimizeButton.FlatAppearance.BorderSize = 0
        minimizeButton.FlatStyle = FlatStyle.Flat
        minimizeButton.ForeColor = Color.Black
        minimizeButton.Location = New Point(1058, 0)
        minimizeButton.Name = "minimizeButton"
        minimizeButton.Size = New Size(40, 33)
        minimizeButton.TabIndex = 3
        minimizeButton.Text = "-"
        minimizeButton.TextAlign = ContentAlignment.TopCenter
        minimizeButton.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Right
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(1098, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(41, 33)
        Button2.TabIndex = 2
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' exitButton
        ' 
        exitButton.Dock = DockStyle.Right
        exitButton.FlatAppearance.BorderSize = 0
        exitButton.FlatStyle = FlatStyle.Flat
        exitButton.ForeColor = Color.Black
        exitButton.Location = New Point(1139, 0)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(43, 33)
        exitButton.TabIndex = 1
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 0
        Label1.Text = "Fleet Frontier"
        ' 
        ' sideBar
        ' 
        sideBar.BackColor = Color.Gray
        sideBar.Controls.Add(tripButton)
        sideBar.Controls.Add(logoutButton)
        sideBar.Controls.Add(rentButton)
        sideBar.Controls.Add(staffButton)
        sideBar.Controls.Add(vehicleButton)
        sideBar.Controls.Add(homeButton)
        sideBar.Controls.Add(Panel4)
        sideBar.Dock = DockStyle.Left
        sideBar.Location = New Point(0, 33)
        sideBar.Name = "sideBar"
        sideBar.Size = New Size(223, 520)
        sideBar.TabIndex = 0
        ' 
        ' tripButton
        ' 
        tripButton.Dock = DockStyle.Top
        tripButton.FlatAppearance.BorderSize = 0
        tripButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        tripButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        tripButton.FlatStyle = FlatStyle.Flat
        tripButton.ForeColor = Color.White
        tripButton.ImageAlign = ContentAlignment.MiddleLeft
        tripButton.Location = New Point(0, 256)
        tripButton.Name = "tripButton"
        tripButton.Padding = New Padding(5, 0, 0, 0)
        tripButton.Size = New Size(223, 37)
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
        logoutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        logoutButton.FlatStyle = FlatStyle.Flat
        logoutButton.ForeColor = Color.White
        logoutButton.ImageAlign = ContentAlignment.MiddleLeft
        logoutButton.Location = New Point(0, 483)
        logoutButton.Name = "logoutButton"
        logoutButton.Padding = New Padding(5, 0, 0, 0)
        logoutButton.Size = New Size(223, 37)
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
        rentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        rentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        rentButton.FlatStyle = FlatStyle.Flat
        rentButton.ForeColor = Color.White
        rentButton.ImageAlign = ContentAlignment.MiddleLeft
        rentButton.Location = New Point(0, 219)
        rentButton.Name = "rentButton"
        rentButton.Padding = New Padding(5, 0, 0, 0)
        rentButton.Size = New Size(223, 37)
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
        staffButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        staffButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        staffButton.FlatStyle = FlatStyle.Flat
        staffButton.ForeColor = Color.White
        staffButton.ImageAlign = ContentAlignment.MiddleLeft
        staffButton.Location = New Point(0, 182)
        staffButton.Name = "staffButton"
        staffButton.Padding = New Padding(5, 0, 0, 0)
        staffButton.Size = New Size(223, 37)
        staffButton.TabIndex = 3
        staffButton.Text = "Staff"
        staffButton.TextAlign = ContentAlignment.MiddleLeft
        staffButton.TextImageRelation = TextImageRelation.ImageBeforeText
        staffButton.UseVisualStyleBackColor = True
        ' 
        ' vehicleButton
        ' 
        vehicleButton.Dock = DockStyle.Top
        vehicleButton.FlatAppearance.BorderSize = 0
        vehicleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        vehicleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        vehicleButton.FlatStyle = FlatStyle.Flat
        vehicleButton.ForeColor = Color.White
        vehicleButton.ImageAlign = ContentAlignment.MiddleLeft
        vehicleButton.Location = New Point(0, 145)
        vehicleButton.Name = "vehicleButton"
        vehicleButton.Padding = New Padding(5, 0, 0, 0)
        vehicleButton.Size = New Size(223, 37)
        vehicleButton.TabIndex = 2
        vehicleButton.Text = "Vehicle"
        vehicleButton.TextAlign = ContentAlignment.MiddleLeft
        vehicleButton.TextImageRelation = TextImageRelation.ImageBeforeText
        vehicleButton.UseVisualStyleBackColor = True
        ' 
        ' homeButton
        ' 
        homeButton.Dock = DockStyle.Top
        homeButton.FlatAppearance.BorderSize = 0
        homeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        homeButton.FlatStyle = FlatStyle.Flat
        homeButton.ForeColor = Color.White
        homeButton.ImageAlign = ContentAlignment.MiddleLeft
        homeButton.Location = New Point(0, 108)
        homeButton.Name = "homeButton"
        homeButton.Padding = New Padding(5, 0, 0, 0)
        homeButton.Size = New Size(223, 37)
        homeButton.TabIndex = 1
        homeButton.Text = "Home"
        homeButton.TextAlign = ContentAlignment.MiddleLeft
        homeButton.TextImageRelation = TextImageRelation.ImageBeforeText
        homeButton.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(223, 108)
        Panel4.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGray
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(223, 516)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(959, 37)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(223, 33)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(959, 63)
        Panel2.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 553)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(sideBar)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        sideBar.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents sideBar As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents homeButton As Button
    Friend WithEvents logoutButton As Button
    Friend WithEvents rentButton As Button
    Friend WithEvents staffButton As Button
    Friend WithEvents vehicleButton As Button
    Friend WithEvents tripButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents minimizeButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents exitButton As Button

End Class
