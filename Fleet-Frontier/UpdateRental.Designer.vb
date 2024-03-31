<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateRental))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        exitButton = New Button()
        UpdateRentalLabel = New Label()
        Panel2 = New Panel()
        CustomerNameTextBox = New TextBox()
        ClearButton = New Button()
        CustomerNameLabel = New Label()
        VehicleComboBox = New ComboBox()
        UpdateRentalButton = New Button()
        CancelRentalButton = New Button()
        VehicleLabel = New Label()
        IsReturnedComboBox = New ComboBox()
        Label1 = New Label()
        CustomerPhoneNumberTextBox = New TextBox()
        Label2 = New Label()
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
        Panel1.Controls.Add(UpdateRentalLabel)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(569, 55)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 55)
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
        exitButton.Location = New Point(533, 0)
        exitButton.Margin = New Padding(4, 3, 4, 3)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(36, 55)
        exitButton.TabIndex = 5
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' UpdateRentalLabel
        ' 
        UpdateRentalLabel.AutoSize = True
        UpdateRentalLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateRentalLabel.Location = New Point(66, 5)
        UpdateRentalLabel.Margin = New Padding(4, 0, 4, 0)
        UpdateRentalLabel.Name = "UpdateRentalLabel"
        UpdateRentalLabel.Size = New Size(140, 45)
        UpdateRentalLabel.TabIndex = 0
        UpdateRentalLabel.Text = "Update Rental"
        UpdateRentalLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(CustomerPhoneNumberTextBox)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(IsReturnedComboBox)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(CustomerNameTextBox)
        Panel2.Controls.Add(ClearButton)
        Panel2.Controls.Add(CustomerNameLabel)
        Panel2.Controls.Add(VehicleComboBox)
        Panel2.Controls.Add(UpdateRentalButton)
        Panel2.Controls.Add(CancelRentalButton)
        Panel2.Controls.Add(VehicleLabel)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 55)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(569, 650)
        Panel2.TabIndex = 9
        ' 
        ' CustomerNameTextBox
        ' 
        CustomerNameTextBox.Location = New Point(23, 76)
        CustomerNameTextBox.Margin = New Padding(4, 5, 4, 5)
        CustomerNameTextBox.Name = "CustomerNameTextBox"
        CustomerNameTextBox.Size = New Size(498, 31)
        CustomerNameTextBox.TabIndex = 19
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(33, 555)
        ClearButton.Margin = New Padding(4, 5, 4, 5)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(123, 43)
        ClearButton.TabIndex = 18
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' CustomerNameLabel
        ' 
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        CustomerNameLabel.Location = New Point(23, 27)
        CustomerNameLabel.Margin = New Padding(1, 0, 1, 0)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New Size(134, 39)
        CustomerNameLabel.TabIndex = 14
        CustomerNameLabel.Text = "Customer Name"
        ' 
        ' VehicleComboBox
        ' 
        VehicleComboBox.FormattingEnabled = True
        VehicleComboBox.Location = New Point(23, 319)
        VehicleComboBox.Margin = New Padding(1, 2, 1, 2)
        VehicleComboBox.Name = "VehicleComboBox"
        VehicleComboBox.Size = New Size(498, 33)
        VehicleComboBox.TabIndex = 11
        ' 
        ' UpdateRentalButton
        ' 
        UpdateRentalButton.BackColor = Color.Gray
        UpdateRentalButton.FlatAppearance.BorderSize = 0
        UpdateRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        UpdateRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        UpdateRentalButton.FlatStyle = FlatStyle.Flat
        UpdateRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UpdateRentalButton.ForeColor = Color.Black
        UpdateRentalButton.Location = New Point(410, 555)
        UpdateRentalButton.Margin = New Padding(4, 3, 4, 3)
        UpdateRentalButton.Name = "UpdateRentalButton"
        UpdateRentalButton.Size = New Size(123, 43)
        UpdateRentalButton.TabIndex = 10
        UpdateRentalButton.Text = "Update"
        UpdateRentalButton.UseVisualStyleBackColor = False
        ' 
        ' CancelRentalButton
        ' 
        CancelRentalButton.BackColor = Color.Gray
        CancelRentalButton.FlatAppearance.BorderSize = 0
        CancelRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CancelRentalButton.FlatStyle = FlatStyle.Flat
        CancelRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CancelRentalButton.ForeColor = Color.Red
        CancelRentalButton.Location = New Point(220, 555)
        CancelRentalButton.Margin = New Padding(4, 3, 4, 3)
        CancelRentalButton.Name = "CancelRentalButton"
        CancelRentalButton.Size = New Size(123, 43)
        CancelRentalButton.TabIndex = 9
        CancelRentalButton.Text = "Cancel"
        CancelRentalButton.UseVisualStyleBackColor = False
        ' 
        ' VehicleLabel
        ' 
        VehicleLabel.AutoSize = True
        VehicleLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VehicleLabel.Location = New Point(23, 278)
        VehicleLabel.Margin = New Padding(4, 0, 4, 0)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New Size(68, 39)
        VehicleLabel.TabIndex = 1
        VehicleLabel.Text = "Vehicle"
        ' 
        ' IsReturnedComboBox
        ' 
        IsReturnedComboBox.FormattingEnabled = True
        IsReturnedComboBox.Items.AddRange(New Object() {"True", "False"})
        IsReturnedComboBox.Location = New Point(23, 433)
        IsReturnedComboBox.Margin = New Padding(1, 2, 1, 2)
        IsReturnedComboBox.Name = "IsReturnedComboBox"
        IsReturnedComboBox.Size = New Size(498, 33)
        IsReturnedComboBox.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 392)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 39)
        Label1.TabIndex = 20
        Label1.Text = "Is Returned"
        ' 
        ' CustomerPhoneNumberTextBox
        ' 
        CustomerPhoneNumberTextBox.Location = New Point(23, 192)
        CustomerPhoneNumberTextBox.Margin = New Padding(4, 5, 4, 5)
        CustomerPhoneNumberTextBox.Name = "CustomerPhoneNumberTextBox"
        CustomerPhoneNumberTextBox.Size = New Size(498, 31)
        CustomerPhoneNumberTextBox.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(23, 143)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 39)
        Label2.TabIndex = 22
        Label2.Text = "Customer Phone Number"
        ' 
        ' UpdateRental
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(569, 705)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UpdateRental"
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
    Friend WithEvents UpdateRentalLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClearButton As Button
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents VehicleComboBox As ComboBox
    Friend WithEvents UpdateRentalButton As Button
    Friend WithEvents CancelRentalButton As Button
    Friend WithEvents VehicleLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents CustomerPhoneNumberTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IsReturnedComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
