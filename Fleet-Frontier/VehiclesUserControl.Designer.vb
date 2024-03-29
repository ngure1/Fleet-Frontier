<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehiclesUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VehiclesUserControl))
        Panel1 = New Panel()
        VehicleBodypanel = New Panel()
        VehicleHeaderPanel = New Panel()
        RefreshButton = New Button()
        AddVehicleButton = New Button()
        VehiclesLabel = New Label()
        VehicleSearchBar = New TextBox()
        Panel1.SuspendLayout()
        VehicleHeaderPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(VehicleBodypanel)
        Panel1.Controls.Add(VehicleHeaderPanel)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(21, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(982, 621)
        Panel1.TabIndex = 0
        ' 
        ' VehicleBodypanel
        ' 
        VehicleBodypanel.AutoScroll = True
        VehicleBodypanel.Dock = DockStyle.Fill
        VehicleBodypanel.Location = New Point(0, 61)
        VehicleBodypanel.Name = "VehicleBodypanel"
        VehicleBodypanel.Padding = New Padding(21, 20, 21, 20)
        VehicleBodypanel.Size = New Size(982, 560)
        VehicleBodypanel.TabIndex = 0
        ' 
        ' VehicleHeaderPanel
        ' 
        VehicleHeaderPanel.Controls.Add(RefreshButton)
        VehicleHeaderPanel.Controls.Add(AddVehicleButton)
        VehicleHeaderPanel.Controls.Add(VehiclesLabel)
        VehicleHeaderPanel.Controls.Add(VehicleSearchBar)
        VehicleHeaderPanel.Dock = DockStyle.Top
        VehicleHeaderPanel.Location = New Point(0, 0)
        VehicleHeaderPanel.Name = "VehicleHeaderPanel"
        VehicleHeaderPanel.Size = New Size(982, 61)
        VehicleHeaderPanel.TabIndex = 4
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        RefreshButton.Location = New Point(437, 11)
        RefreshButton.Margin = New Padding(2, 2, 2, 2)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(109, 38)
        RefreshButton.TabIndex = 8
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' AddVehicleButton
        ' 
        AddVehicleButton.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        AddVehicleButton.BackColor = Color.Gray
        AddVehicleButton.FlatAppearance.BorderSize = 0
        AddVehicleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddVehicleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddVehicleButton.FlatStyle = FlatStyle.Flat
        AddVehicleButton.Font = New Font("Gabriola", 12.0F, FontStyle.Bold)
        AddVehicleButton.Location = New Point(813, 15)
        AddVehicleButton.Name = "AddVehicleButton"
        AddVehicleButton.Size = New Size(149, 39)
        AddVehicleButton.TabIndex = 2
        AddVehicleButton.Text = "Add Vehicle"
        AddVehicleButton.UseVisualStyleBackColor = False
        ' 
        ' VehiclesLabel
        ' 
        VehiclesLabel.AutoSize = True
        VehiclesLabel.Font = New Font("MV Boli", 15.0F, FontStyle.Bold)
        VehiclesLabel.Image = CType(resources.GetObject("VehiclesLabel.Image"), Image)
        VehiclesLabel.ImageAlign = ContentAlignment.MiddleLeft
        VehiclesLabel.Location = New Point(17, 15)
        VehiclesLabel.Name = "VehiclesLabel"
        VehiclesLabel.Size = New Size(135, 32)
        VehiclesLabel.TabIndex = 1
        VehiclesLabel.Text = "  Vehicles"
        VehiclesLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' VehicleSearchBar
        ' 
        VehicleSearchBar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        VehicleSearchBar.BackColor = Color.White
        VehicleSearchBar.Location = New Point(614, 20)
        VehicleSearchBar.MinimumSize = New Size(130, 27)
        VehicleSearchBar.Name = "VehicleSearchBar"
        VehicleSearchBar.PlaceholderText = "Search"
        VehicleSearchBar.Size = New Size(182, 27)
        VehicleSearchBar.TabIndex = 0
        ' 
        ' VehiclesUserControl
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "VehiclesUserControl"
        Padding = New Padding(21, 20, 21, 20)
        Size = New Size(1024, 661)
        Panel1.ResumeLayout(False)
        VehicleHeaderPanel.ResumeLayout(False)
        VehicleHeaderPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents VehiclesLabel As Label
    Friend WithEvents VehicleSearchBar As TextBox
    Friend WithEvents AddVehicleButton As Button
    Friend WithEvents VehicleHeaderPanel As Panel
    Friend WithEvents VehicleBodypanel As Panel
    Friend WithEvents RefreshButton As Button

End Class
