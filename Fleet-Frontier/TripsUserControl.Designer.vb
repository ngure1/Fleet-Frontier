<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TripsUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TripsUserControl))
        TripsHeaderPanel = New Panel()
        AddTripsButton = New Button()
        TripsSearchBar = New TextBox()
        TripsLabel = New Label()
        TripsBodyPanel = New Panel()
        TripsHeaderPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TripsHeaderPanel
        ' 
        TripsHeaderPanel.BackColor = Color.Silver
        TripsHeaderPanel.Controls.Add(AddTripsButton)
        TripsHeaderPanel.Controls.Add(TripsSearchBar)
        TripsHeaderPanel.Controls.Add(TripsLabel)
        TripsHeaderPanel.Dock = DockStyle.Top
        TripsHeaderPanel.Location = New Point(20, 20)
        TripsHeaderPanel.Name = "TripsHeaderPanel"
        TripsHeaderPanel.Size = New Size(984, 70)
        TripsHeaderPanel.TabIndex = 0
        ' 
        ' AddTripsButton
        ' 
        AddTripsButton.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        AddTripsButton.BackColor = Color.Gray
        AddTripsButton.FlatAppearance.BorderSize = 0
        AddTripsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddTripsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        AddTripsButton.FlatStyle = FlatStyle.Flat
        AddTripsButton.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        AddTripsButton.Location = New Point(818, 15)
        AddTripsButton.Name = "AddTripsButton"
        AddTripsButton.Size = New Size(151, 39)
        AddTripsButton.TabIndex = 6
        AddTripsButton.Text = "Start Trip"
        AddTripsButton.UseVisualStyleBackColor = False
        ' 
        ' TripsSearchBar
        ' 
        TripsSearchBar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TripsSearchBar.BackColor = Color.White
        TripsSearchBar.Location = New Point(609, 21)
        TripsSearchBar.MinimumSize = New Size(130, 27)
        TripsSearchBar.Name = "TripsSearchBar"
        TripsSearchBar.PlaceholderText = "Search"
        TripsSearchBar.Size = New Size(184, 27)
        TripsSearchBar.TabIndex = 5
        ' 
        ' TripsLabel
        ' 
        TripsLabel.AutoSize = True
        TripsLabel.Font = New Font("MV Boli", 15F, FontStyle.Bold)
        TripsLabel.Image = CType(resources.GetObject("TripsLabel.Image"), Image)
        TripsLabel.ImageAlign = ContentAlignment.MiddleLeft
        TripsLabel.Location = New Point(16, 19)
        TripsLabel.Name = "TripsLabel"
        TripsLabel.Size = New Size(102, 32)
        TripsLabel.TabIndex = 2
        TripsLabel.Text = "  Trips"
        TripsLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TripsBodyPanel
        ' 
        TripsBodyPanel.BackColor = Color.Silver
        TripsBodyPanel.Dock = DockStyle.Fill
        TripsBodyPanel.Location = New Point(20, 90)
        TripsBodyPanel.Name = "TripsBodyPanel"
        TripsBodyPanel.Size = New Size(984, 551)
        TripsBodyPanel.TabIndex = 1
        ' 
        ' TripsUserControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TripsBodyPanel)
        Controls.Add(TripsHeaderPanel)
        Name = "TripsUserControl"
        Padding = New Padding(20)
        Size = New Size(1024, 661)
        TripsHeaderPanel.ResumeLayout(False)
        TripsHeaderPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TripsHeaderPanel As Panel
    Friend WithEvents TripsBodyPanel As Panel
    Friend WithEvents TripsLabel As Label
    Friend WithEvents AddTripsButton As Button
    Friend WithEvents TripsSearchBar As TextBox

End Class
