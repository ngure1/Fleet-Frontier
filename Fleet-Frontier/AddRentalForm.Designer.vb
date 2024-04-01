<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRentalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRentalForm))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        ExitAddRentalButton = New Button()
        AddRentalLabel = New Label()
        Panel2 = New Panel()
        VehicleComboBox = New ComboBox()
        Label1 = New Label()
        CustomerPhoneNumberTextBox = New TextBox()
        ClearRentalButton = New Button()
        AddRentalButton = New Button()
        CancelRentalButton = New Button()
        VehicleLabel = New Label()
        CustomerNameLabel = New Label()
        CustomerNameTextBox = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(ExitAddRentalButton)
        Panel1.Controls.Add(AddRentalLabel)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(568, 55)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' ExitAddRentalButton
        ' 
        ExitAddRentalButton.Dock = DockStyle.Right
        ExitAddRentalButton.FlatAppearance.BorderSize = 0
        ExitAddRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ExitAddRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ExitAddRentalButton.FlatStyle = FlatStyle.Flat
        ExitAddRentalButton.Font = New Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ExitAddRentalButton.ForeColor = Color.Black
        ExitAddRentalButton.Location = New Point(532, 0)
        ExitAddRentalButton.Margin = New Padding(4)
        ExitAddRentalButton.Name = "ExitAddRentalButton"
        ExitAddRentalButton.Size = New Size(36, 55)
        ExitAddRentalButton.TabIndex = 5
        ExitAddRentalButton.Text = "X"
        ExitAddRentalButton.UseVisualStyleBackColor = True
        ' 
        ' AddRentalLabel
        ' 
        AddRentalLabel.AutoSize = True
        AddRentalLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddRentalLabel.Location = New Point(59, 5)
        AddRentalLabel.Margin = New Padding(4, 0, 4, 0)
        AddRentalLabel.Name = "AddRentalLabel"
        AddRentalLabel.Size = New Size(114, 45)
        AddRentalLabel.TabIndex = 0
        AddRentalLabel.Text = "Add Rental"
        AddRentalLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(VehicleComboBox)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(CustomerPhoneNumberTextBox)
        Panel2.Controls.Add(ClearRentalButton)
        Panel2.Controls.Add(AddRentalButton)
        Panel2.Controls.Add(CancelRentalButton)
        Panel2.Controls.Add(VehicleLabel)
        Panel2.Controls.Add(CustomerNameLabel)
        Panel2.Controls.Add(CustomerNameTextBox)
        Panel2.Location = New Point(14, 80)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(538, 657)
        Panel2.TabIndex = 3
        ' 
        ' VehicleComboBox
        ' 
        VehicleComboBox.FormattingEnabled = True
        VehicleComboBox.Location = New Point(30, 305)
        VehicleComboBox.Margin = New Padding(1, 2, 1, 2)
        VehicleComboBox.Name = "VehicleComboBox"
        VehicleComboBox.Size = New Size(498, 33)
        VehicleComboBox.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 161)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 39)
        Label1.TabIndex = 15
        Label1.Text = "Customer Phone Number"
        ' 
        ' CustomerPhoneNumberTextBox
        ' 
        CustomerPhoneNumberTextBox.Location = New Point(30, 204)
        CustomerPhoneNumberTextBox.Margin = New Padding(4)
        CustomerPhoneNumberTextBox.Name = "CustomerPhoneNumberTextBox"
        CustomerPhoneNumberTextBox.Size = New Size(498, 31)
        CustomerPhoneNumberTextBox.TabIndex = 14
        ' 
        ' ClearRentalButton
        ' 
        ClearRentalButton.BackColor = Color.Gray
        ClearRentalButton.FlatAppearance.BorderSize = 0
        ClearRentalButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearRentalButton.FlatStyle = FlatStyle.Flat
        ClearRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearRentalButton.ForeColor = Color.Blue
        ClearRentalButton.Location = New Point(22, 555)
        ClearRentalButton.Margin = New Padding(4, 5, 4, 5)
        ClearRentalButton.Name = "ClearRentalButton"
        ClearRentalButton.Size = New Size(122, 44)
        ClearRentalButton.TabIndex = 11
        ClearRentalButton.Text = "Clear"
        ClearRentalButton.UseVisualStyleBackColor = False
        ' 
        ' AddRentalButton
        ' 
        AddRentalButton.BackColor = Color.Gray
        AddRentalButton.FlatAppearance.BorderSize = 0
        AddRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        AddRentalButton.FlatStyle = FlatStyle.Flat
        AddRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        AddRentalButton.ForeColor = Color.Black
        AddRentalButton.Location = New Point(394, 555)
        AddRentalButton.Margin = New Padding(4)
        AddRentalButton.Name = "AddRentalButton"
        AddRentalButton.Size = New Size(122, 44)
        AddRentalButton.TabIndex = 10
        AddRentalButton.Text = "Add"
        AddRentalButton.UseVisualStyleBackColor = False
        ' 
        ' CancelRentalButton
        ' 
        CancelRentalButton.BackColor = Color.Gray
        CancelRentalButton.FlatAppearance.BorderSize = 0
        CancelRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CancelRentalButton.FlatStyle = FlatStyle.Flat
        CancelRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        CancelRentalButton.ForeColor = Color.Red
        CancelRentalButton.Location = New Point(206, 555)
        CancelRentalButton.Margin = New Padding(4)
        CancelRentalButton.Name = "CancelRentalButton"
        CancelRentalButton.Size = New Size(122, 44)
        CancelRentalButton.TabIndex = 9
        CancelRentalButton.Text = "Cancel"
        CancelRentalButton.UseVisualStyleBackColor = False
        ' 
        ' VehicleLabel
        ' 
        VehicleLabel.AutoSize = True
        VehicleLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VehicleLabel.Location = New Point(30, 264)
        VehicleLabel.Margin = New Padding(4, 0, 4, 0)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New Size(68, 39)
        VehicleLabel.TabIndex = 3
        VehicleLabel.Text = "Vehicle"
        ' 
        ' CustomerNameLabel
        ' 
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustomerNameLabel.Location = New Point(24, 50)
        CustomerNameLabel.Margin = New Padding(4, 0, 4, 0)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New Size(134, 39)
        CustomerNameLabel.TabIndex = 1
        CustomerNameLabel.Text = "Customer Name"
        ' 
        ' CustomerNameTextBox
        ' 
        CustomerNameTextBox.Location = New Point(30, 93)
        CustomerNameTextBox.Margin = New Padding(4)
        CustomerNameTextBox.Name = "CustomerNameTextBox"
        CustomerNameTextBox.Size = New Size(498, 31)
        CustomerNameTextBox.TabIndex = 0
        ' 
        ' AddRentalForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 674)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "AddRentalForm"
        Text = "AddRentalForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitAddRentalButton As Button
    Friend WithEvents AddRentalLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClearRentalButton As Button
    Friend WithEvents AddRentalButton As Button
    Friend WithEvents CancelRentalButton As Button
    Friend WithEvents VehicleLabel As Label
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerPhoneNumberTextBox As TextBox
    Friend WithEvents VehicleComboBox As ComboBox
End Class
