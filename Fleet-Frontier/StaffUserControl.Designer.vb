<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffUserControl))
        StaffHeaderPanel = New Panel()
        AddStaffButton = New Button()
        StaffSearchBar = New TextBox()
        StaffLabel = New Label()
        StaffBodyPanel = New Panel()
        StaffTabControl = New TabControl()
        DriverTabPage = New TabPage()
        DriversListPanel = New Panel()
        DriverPanel1 = New Panel()
        DeleteDriver1Button = New Button()
        UpdateDriver1Button = New Button()
        Label2 = New Label()
        ConductorTabPage = New TabPage()
        ConductorListPanel = New Panel()
        ConductorPanel = New Panel()
        DeleteConductor1Button = New Button()
        UpdateConductor1Button = New Button()
        Label1 = New Label()
        StaffHeaderPanel.SuspendLayout()
        StaffBodyPanel.SuspendLayout()
        StaffTabControl.SuspendLayout()
        DriverTabPage.SuspendLayout()
        DriversListPanel.SuspendLayout()
        DriverPanel1.SuspendLayout()
        ConductorTabPage.SuspendLayout()
        ConductorListPanel.SuspendLayout()
        ConductorPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' StaffHeaderPanel
        ' 
        StaffHeaderPanel.BackColor = Color.Silver
        StaffHeaderPanel.Controls.Add(AddStaffButton)
        StaffHeaderPanel.Controls.Add(StaffSearchBar)
        StaffHeaderPanel.Controls.Add(StaffLabel)
        StaffHeaderPanel.Dock = DockStyle.Top
        StaffHeaderPanel.Location = New Point(20, 20)
        StaffHeaderPanel.Name = "StaffHeaderPanel"
        StaffHeaderPanel.Size = New Size(984, 67)
        StaffHeaderPanel.TabIndex = 0
        ' 
        ' AddStaffButton
        ' 
        AddStaffButton.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        AddStaffButton.BackColor = Color.Gray
        AddStaffButton.FlatAppearance.BorderSize = 0
        AddStaffButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddStaffButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        AddStaffButton.FlatStyle = FlatStyle.Flat
        AddStaffButton.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        AddStaffButton.Location = New Point(821, 15)
        AddStaffButton.Name = "AddStaffButton"
        AddStaffButton.Size = New Size(151, 39)
        AddStaffButton.TabIndex = 4
        AddStaffButton.Text = "Add staff"
        AddStaffButton.UseVisualStyleBackColor = False
        ' 
        ' StaffSearchBar
        ' 
        StaffSearchBar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        StaffSearchBar.BackColor = Color.White
        StaffSearchBar.Location = New Point(612, 21)
        StaffSearchBar.MinimumSize = New Size(130, 27)
        StaffSearchBar.Name = "StaffSearchBar"
        StaffSearchBar.PlaceholderText = "Search"
        StaffSearchBar.Size = New Size(184, 27)
        StaffSearchBar.TabIndex = 3
        ' 
        ' StaffLabel
        ' 
        StaffLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        StaffLabel.AutoSize = True
        StaffLabel.Font = New Font("MV Boli", 15F, FontStyle.Bold)
        StaffLabel.Image = CType(resources.GetObject("StaffLabel.Image"), Image)
        StaffLabel.ImageAlign = ContentAlignment.MiddleLeft
        StaffLabel.Location = New Point(14, 21)
        StaffLabel.Name = "StaffLabel"
        StaffLabel.Size = New Size(105, 32)
        StaffLabel.TabIndex = 2
        StaffLabel.Text = "  Staff"
        StaffLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' StaffBodyPanel
        ' 
        StaffBodyPanel.BackColor = Color.Silver
        StaffBodyPanel.Controls.Add(StaffTabControl)
        StaffBodyPanel.Dock = DockStyle.Fill
        StaffBodyPanel.Location = New Point(20, 87)
        StaffBodyPanel.Name = "StaffBodyPanel"
        StaffBodyPanel.Size = New Size(984, 554)
        StaffBodyPanel.TabIndex = 1
        ' 
        ' StaffTabControl
        ' 
        StaffTabControl.Appearance = TabAppearance.FlatButtons
        StaffTabControl.Controls.Add(DriverTabPage)
        StaffTabControl.Controls.Add(ConductorTabPage)
        StaffTabControl.Dock = DockStyle.Fill
        StaffTabControl.Font = New Font("Gabriola", 10F, FontStyle.Bold)
        StaffTabControl.Location = New Point(0, 0)
        StaffTabControl.Multiline = True
        StaffTabControl.Name = "StaffTabControl"
        StaffTabControl.Padding = New Point(4, 3)
        StaffTabControl.SelectedIndex = 0
        StaffTabControl.Size = New Size(984, 554)
        StaffTabControl.TabIndex = 0
        ' 
        ' DriverTabPage
        ' 
        DriverTabPage.BackColor = Color.Silver
        DriverTabPage.Controls.Add(DriversListPanel)
        DriverTabPage.Font = New Font("Gabriola", 9F)
        DriverTabPage.Location = New Point(4, 43)
        DriverTabPage.Name = "DriverTabPage"
        DriverTabPage.Padding = New Padding(5)
        DriverTabPage.Size = New Size(976, 507)
        DriverTabPage.TabIndex = 0
        DriverTabPage.Text = "Drivers"
        ' 
        ' DriversListPanel
        ' 
        DriversListPanel.AutoScroll = True
        DriversListPanel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DriversListPanel.Controls.Add(DriverPanel1)
        DriversListPanel.Dock = DockStyle.Fill
        DriversListPanel.Location = New Point(5, 5)
        DriversListPanel.Margin = New Padding(0)
        DriversListPanel.Name = "DriversListPanel"
        DriversListPanel.Padding = New Padding(20)
        DriversListPanel.Size = New Size(966, 497)
        DriversListPanel.TabIndex = 5
        ' 
        ' DriverPanel1
        ' 
        DriverPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DriverPanel1.BackColor = Color.Silver
        DriverPanel1.Controls.Add(DeleteDriver1Button)
        DriverPanel1.Controls.Add(UpdateDriver1Button)
        DriverPanel1.Controls.Add(Label2)
        DriverPanel1.Location = New Point(16, 23)
        DriverPanel1.Name = "DriverPanel1"
        DriverPanel1.Padding = New Padding(5)
        DriverPanel1.Size = New Size(927, 65)
        DriverPanel1.TabIndex = 0
        ' 
        ' DeleteDriver1Button
        ' 
        DeleteDriver1Button.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        DeleteDriver1Button.Font = New Font("Gabriola", 10F, FontStyle.Bold)
        DeleteDriver1Button.ForeColor = Color.Red
        DeleteDriver1Button.Location = New Point(835, 16)
        DeleteDriver1Button.Name = "DeleteDriver1Button"
        DeleteDriver1Button.Size = New Size(84, 33)
        DeleteDriver1Button.TabIndex = 2
        DeleteDriver1Button.Text = "Delete"
        DeleteDriver1Button.UseVisualStyleBackColor = True
        ' 
        ' UpdateDriver1Button
        ' 
        UpdateDriver1Button.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        UpdateDriver1Button.Font = New Font("Gabriola", 10F, FontStyle.Bold)
        UpdateDriver1Button.Location = New Point(726, 16)
        UpdateDriver1Button.Name = "UpdateDriver1Button"
        UpdateDriver1Button.Size = New Size(84, 33)
        UpdateDriver1Button.TabIndex = 1
        UpdateDriver1Button.Text = "Update"
        UpdateDriver1Button.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 13F, FontStyle.Bold)
        Label2.Location = New Point(8, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 40)
        Label2.TabIndex = 0
        Label2.Text = "Driver details"
        ' 
        ' ConductorTabPage
        ' 
        ConductorTabPage.BackColor = Color.Silver
        ConductorTabPage.Controls.Add(ConductorListPanel)
        ConductorTabPage.Location = New Point(4, 43)
        ConductorTabPage.Name = "ConductorTabPage"
        ConductorTabPage.Padding = New Padding(3)
        ConductorTabPage.Size = New Size(976, 507)
        ConductorTabPage.TabIndex = 1
        ConductorTabPage.Text = "Conductors"
        ' 
        ' ConductorListPanel
        ' 
        ConductorListPanel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConductorListPanel.Controls.Add(ConductorPanel)
        ConductorListPanel.Dock = DockStyle.Fill
        ConductorListPanel.Location = New Point(3, 3)
        ConductorListPanel.Name = "ConductorListPanel"
        ConductorListPanel.Size = New Size(970, 501)
        ConductorListPanel.TabIndex = 0
        ' 
        ' ConductorPanel
        ' 
        ConductorPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ConductorPanel.BackColor = Color.Silver
        ConductorPanel.Controls.Add(DeleteConductor1Button)
        ConductorPanel.Controls.Add(UpdateConductor1Button)
        ConductorPanel.Controls.Add(Label1)
        ConductorPanel.Location = New Point(20, 19)
        ConductorPanel.Name = "ConductorPanel"
        ConductorPanel.Padding = New Padding(5)
        ConductorPanel.Size = New Size(927, 65)
        ConductorPanel.TabIndex = 1
        ' 
        ' DeleteConductor1Button
        ' 
        DeleteConductor1Button.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        DeleteConductor1Button.Font = New Font("Gabriola", 10F, FontStyle.Bold)
        DeleteConductor1Button.ForeColor = Color.Red
        DeleteConductor1Button.Location = New Point(826, 16)
        DeleteConductor1Button.Name = "DeleteConductor1Button"
        DeleteConductor1Button.Size = New Size(84, 33)
        DeleteConductor1Button.TabIndex = 4
        DeleteConductor1Button.Text = "Delete"
        DeleteConductor1Button.UseVisualStyleBackColor = True
        ' 
        ' UpdateConductor1Button
        ' 
        UpdateConductor1Button.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        UpdateConductor1Button.Font = New Font("Gabriola", 10F, FontStyle.Bold)
        UpdateConductor1Button.Location = New Point(717, 16)
        UpdateConductor1Button.Name = "UpdateConductor1Button"
        UpdateConductor1Button.Size = New Size(84, 33)
        UpdateConductor1Button.TabIndex = 3
        UpdateConductor1Button.Text = "Update"
        UpdateConductor1Button.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 13F, FontStyle.Bold)
        Label1.Location = New Point(13, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 40)
        Label1.TabIndex = 0
        Label1.Text = "Conductor details"
        ' 
        ' StaffUserControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(StaffBodyPanel)
        Controls.Add(StaffHeaderPanel)
        Name = "StaffUserControl"
        Padding = New Padding(20)
        Size = New Size(1024, 661)
        StaffHeaderPanel.ResumeLayout(False)
        StaffHeaderPanel.PerformLayout()
        StaffBodyPanel.ResumeLayout(False)
        StaffTabControl.ResumeLayout(False)
        DriverTabPage.ResumeLayout(False)
        DriversListPanel.ResumeLayout(False)
        DriverPanel1.ResumeLayout(False)
        DriverPanel1.PerformLayout()
        ConductorTabPage.ResumeLayout(False)
        ConductorListPanel.ResumeLayout(False)
        ConductorPanel.ResumeLayout(False)
        ConductorPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents StaffHeaderPanel As Panel
    Friend WithEvents StaffBodyPanel As Panel
    Friend WithEvents StaffLabel As Label
    Friend WithEvents AddStaffButton As Button
    Friend WithEvents StaffSearchBar As TextBox
    Friend WithEvents StaffTabControl As TabControl
    Friend WithEvents DriverTabPage As TabPage
    Friend WithEvents ConductorTabPage As TabPage
    Friend WithEvents DriversListPanel As Panel
    Friend WithEvents DriverPanel1 As Panel
    Friend WithEvents DeleteDriver1Button As Button
    Friend WithEvents UpdateDriver1Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ConductorListPanel As Panel
    Friend WithEvents ConductorPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteConductor1Button As Button
    Friend WithEvents UpdateConductor1Button As Button

End Class
