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
        RefreshButton = New Button()
        RentSearchBar = New TextBox()
        NewRentalButton = New Button()
        RentLabel = New Label()
        RentalsBodyPanel = New Panel()
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
        TabPanel.Location = New Point(25, 25)
        TabPanel.Margin = New Padding(4)
        TabPanel.Name = "TabPanel"
        TabPanel.Size = New Size(1230, 82)
        TabPanel.TabIndex = 0
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        RefreshButton.Location = New Point(585, 16)
        RefreshButton.Margin = New Padding(2)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(136, 48)
        RefreshButton.TabIndex = 9
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' RentSearchBar
        ' 
        RentSearchBar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        RentSearchBar.BackColor = Color.White
        RentSearchBar.Location = New Point(754, 24)
        RentSearchBar.Margin = New Padding(4)
        RentSearchBar.MinimumSize = New Size(162, 27)
        RentSearchBar.Name = "RentSearchBar"
        RentSearchBar.PlaceholderText = "Search"
        RentSearchBar.Size = New Size(226, 31)
        RentSearchBar.TabIndex = 4
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
        NewRentalButton.Location = New Point(1029, 16)
        NewRentalButton.Margin = New Padding(4)
        NewRentalButton.Name = "NewRentalButton"
        NewRentalButton.Size = New Size(186, 49)
        NewRentalButton.TabIndex = 3
        NewRentalButton.Text = "New Rental"
        NewRentalButton.UseVisualStyleBackColor = False
        ' 
        ' RentLabel
        ' 
        RentLabel.AutoSize = True
        RentLabel.Font = New Font("MV Boli", 15F, FontStyle.Bold)
        RentLabel.Image = CType(resources.GetObject("RentLabel.Image"), Image)
        RentLabel.ImageAlign = ContentAlignment.MiddleLeft
        RentLabel.Location = New Point(18, 21)
        RentLabel.Margin = New Padding(4, 0, 4, 0)
        RentLabel.Name = "RentLabel"
        RentLabel.Size = New Size(190, 40)
        RentLabel.TabIndex = 2
        RentLabel.Text = "  Rent out" & vbCrLf
        RentLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' RentalsBodyPanel
        ' 
        RentalsBodyPanel.BackColor = Color.Silver
        RentalsBodyPanel.Dock = DockStyle.Fill
        RentalsBodyPanel.Location = New Point(25, 107)
        RentalsBodyPanel.Margin = New Padding(4)
        RentalsBodyPanel.Name = "RentalsBodyPanel"
        RentalsBodyPanel.Size = New Size(1230, 694)
        RentalsBodyPanel.TabIndex = 1
        ' 
        ' RentingUserControl
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(RentalsBodyPanel)
        Controls.Add(TabPanel)
        Margin = New Padding(4)
        Name = "RentingUserControl"
        Padding = New Padding(25)
        Size = New Size(1280, 826)
        TabPanel.ResumeLayout(False)
        TabPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabPanel As Panel
    Friend WithEvents RentalsBodyPanel As Panel
    Friend WithEvents RentLabel As Label
    Friend WithEvents NewRentalButton As Button
    Friend WithEvents RentSearchBar As TextBox
    Friend WithEvents RefreshButton As Button

End Class
