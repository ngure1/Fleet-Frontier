<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentingUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentingUserControl))
        TabPanel = New Panel()
        BodyPanel = New Panel()
        RentLabel = New Label()
        NewRentalButton = New Button()
        RentSearchBar = New TextBox()
        RefreshButton = New Button()
        TabPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabPanel
        ' 
        TabPanel.BackColor = Color.Silver
        TabPanel.Controls.Add(RefreshButton)
        TabPanel.Controls.Add(RentSearchBar)
        TabPanel.Controls.Add(NewRentalButton)
        TabPanel.Controls.Add(RentLabel)
        TabPanel.Dock = DockStyle.Top
        TabPanel.Location = New Point(20, 20)
        TabPanel.Name = "TabPanel"
        TabPanel.Size = New Size(984, 66)
        TabPanel.TabIndex = 0
        ' 
        ' BodyPanel
        ' 
        BodyPanel.BackColor = Color.Silver
        BodyPanel.Dock = DockStyle.Fill
        BodyPanel.Location = New Point(20, 86)
        BodyPanel.Name = "BodyPanel"
        BodyPanel.Size = New Size(984, 555)
        BodyPanel.TabIndex = 1
        ' 
        ' RentLabel
        ' 
        RentLabel.AutoSize = True
        RentLabel.Font = New Font("MV Boli", 15F, FontStyle.Bold)
        RentLabel.Image = CType(resources.GetObject("RentLabel.Image"), Image)
        RentLabel.ImageAlign = ContentAlignment.MiddleLeft
        RentLabel.Location = New Point(14, 17)
        RentLabel.Name = "RentLabel"
        RentLabel.Size = New Size(156, 32)
        RentLabel.TabIndex = 2
        RentLabel.Text = "  Rent out" & vbCrLf
        RentLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' NewRentalButton
        ' 
        NewRentalButton.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        NewRentalButton.BackColor = Color.Gray
        NewRentalButton.FlatAppearance.BorderSize = 0
        NewRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        NewRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        NewRentalButton.FlatStyle = FlatStyle.Flat
        NewRentalButton.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        NewRentalButton.Location = New Point(823, 13)
        NewRentalButton.Name = "NewRentalButton"
        NewRentalButton.Size = New Size(149, 39)
        NewRentalButton.TabIndex = 3
        NewRentalButton.Text = "New Rental"
        NewRentalButton.UseVisualStyleBackColor = False
        ' 
        ' RentSearchBar
        ' 
        RentSearchBar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        RentSearchBar.BackColor = Color.White
        RentSearchBar.Location = New Point(603, 19)
        RentSearchBar.MinimumSize = New Size(130, 27)
        RentSearchBar.Name = "RentSearchBar"
        RentSearchBar.PlaceholderText = "Search"
        RentSearchBar.Size = New Size(182, 27)
        RentSearchBar.TabIndex = 4
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        RefreshButton.Location = New Point(468, 13)
        RefreshButton.Margin = New Padding(2)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(109, 38)
        RefreshButton.TabIndex = 9
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' RentingUserControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BodyPanel)
        Controls.Add(TabPanel)
        Name = "RentingUserControl"
        Padding = New Padding(20)
        Size = New Size(1024, 661)
        TabPanel.ResumeLayout(False)
        TabPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabPanel As Panel
    Friend WithEvents BodyPanel As Panel
    Friend WithEvents RentLabel As Label
    Friend WithEvents NewRentalButton As Button
    Friend WithEvents RentSearchBar As TextBox
    Friend WithEvents RefreshButton As Button

End Class
