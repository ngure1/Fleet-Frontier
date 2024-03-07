<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaffForm
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
        AddStaffPanel1 = New Panel()
        AddStaffCloseButton = New Button()
        AddStaffLabel = New Label()
        AddStaffPanel2 = New Panel()
        AddStaffTypeComboBox = New ComboBox()
        AddStaffDateTimePicker = New DateTimePicker()
        AddStaffDateLabel = New Label()
        AddStaffCancelButton = New Button()
        AddStaffButton = New Button()
        AddStaffAvailabilityTextBox = New TextBox()
        AddStaffPhoneTextBox = New TextBox()
        AddStaffNameTextBox = New TextBox()
        AddStaffAvailabilityLabel = New Label()
        AddStaffTypeLabel = New Label()
        AddStaffPhoneLabel = New Label()
        AddStaffNameLabel = New Label()
        AddStaffPanel1.SuspendLayout()
        AddStaffPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' AddStaffPanel1
        ' 
        AddStaffPanel1.BackColor = Color.Gray
        AddStaffPanel1.BorderStyle = BorderStyle.FixedSingle
        AddStaffPanel1.Controls.Add(AddStaffCloseButton)
        AddStaffPanel1.Controls.Add(AddStaffLabel)
        AddStaffPanel1.Dock = DockStyle.Top
        AddStaffPanel1.Location = New Point(20, 20)
        AddStaffPanel1.Name = "AddStaffPanel1"
        AddStaffPanel1.Size = New Size(564, 42)
        AddStaffPanel1.TabIndex = 10
        ' 
        ' AddStaffCloseButton
        ' 
        AddStaffCloseButton.BackColor = Color.Gray
        AddStaffCloseButton.Dock = DockStyle.Right
        AddStaffCloseButton.FlatAppearance.BorderSize = 0
        AddStaffCloseButton.FlatAppearance.MouseOverBackColor = Color.Silver
        AddStaffCloseButton.FlatStyle = FlatStyle.Flat
        AddStaffCloseButton.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffCloseButton.Location = New Point(487, 0)
        AddStaffCloseButton.Name = "AddStaffCloseButton"
        AddStaffCloseButton.Size = New Size(75, 40)
        AddStaffCloseButton.TabIndex = 1
        AddStaffCloseButton.Text = "X"
        AddStaffCloseButton.UseVisualStyleBackColor = False
        ' 
        ' AddStaffLabel
        ' 
        AddStaffLabel.AutoSize = True
        AddStaffLabel.BackColor = Color.Gray
        AddStaffLabel.Dock = DockStyle.Left
        AddStaffLabel.Font = New Font("Gabriola", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffLabel.Location = New Point(0, 0)
        AddStaffLabel.Name = "AddStaffLabel"
        AddStaffLabel.Padding = New Padding(10)
        AddStaffLabel.Size = New Size(83, 48)
        AddStaffLabel.TabIndex = 0
        AddStaffLabel.Text = "Add Staff"
        ' 
        ' AddStaffPanel2
        ' 
        AddStaffPanel2.BackColor = Color.Silver
        AddStaffPanel2.BorderStyle = BorderStyle.FixedSingle
        AddStaffPanel2.Controls.Add(AddStaffTypeComboBox)
        AddStaffPanel2.Controls.Add(AddStaffDateTimePicker)
        AddStaffPanel2.Controls.Add(AddStaffDateLabel)
        AddStaffPanel2.Controls.Add(AddStaffCancelButton)
        AddStaffPanel2.Controls.Add(AddStaffButton)
        AddStaffPanel2.Controls.Add(AddStaffAvailabilityTextBox)
        AddStaffPanel2.Controls.Add(AddStaffPhoneTextBox)
        AddStaffPanel2.Controls.Add(AddStaffNameTextBox)
        AddStaffPanel2.Controls.Add(AddStaffAvailabilityLabel)
        AddStaffPanel2.Controls.Add(AddStaffTypeLabel)
        AddStaffPanel2.Controls.Add(AddStaffPhoneLabel)
        AddStaffPanel2.Controls.Add(AddStaffNameLabel)
        AddStaffPanel2.Dock = DockStyle.Fill
        AddStaffPanel2.Location = New Point(20, 62)
        AddStaffPanel2.Name = "AddStaffPanel2"
        AddStaffPanel2.Padding = New Padding(10)
        AddStaffPanel2.Size = New Size(564, 425)
        AddStaffPanel2.TabIndex = 11
        ' 
        ' AddStaffTypeComboBox
        ' 
        AddStaffTypeComboBox.FormattingEnabled = True
        AddStaffTypeComboBox.Items.AddRange(New Object() {"Driver", "Conductor"})
        AddStaffTypeComboBox.Location = New Point(15, 204)
        AddStaffTypeComboBox.Name = "AddStaffTypeComboBox"
        AddStaffTypeComboBox.Size = New Size(382, 23)
        AddStaffTypeComboBox.TabIndex = 9
        ' 
        ' AddStaffDateTimePicker
        ' 
        AddStaffDateTimePicker.Location = New Point(138, 329)
        AddStaffDateTimePicker.Name = "AddStaffDateTimePicker"
        AddStaffDateTimePicker.Size = New Size(200, 23)
        AddStaffDateTimePicker.TabIndex = 8
        ' 
        ' AddStaffDateLabel
        ' 
        AddStaffDateLabel.AutoSize = True
        AddStaffDateLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffDateLabel.Location = New Point(91, 329)
        AddStaffDateLabel.Name = "AddStaffDateLabel"
        AddStaffDateLabel.Size = New Size(41, 29)
        AddStaffDateLabel.TabIndex = 3
        AddStaffDateLabel.Text = "Date"
        ' 
        ' AddStaffCancelButton
        ' 
        AddStaffCancelButton.BackColor = Color.Gray
        AddStaffCancelButton.FlatAppearance.BorderSize = 0
        AddStaffCancelButton.FlatAppearance.MouseOverBackColor = Color.Silver
        AddStaffCancelButton.FlatStyle = FlatStyle.Flat
        AddStaffCancelButton.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffCancelButton.ForeColor = Color.Red
        AddStaffCancelButton.Location = New Point(102, 375)
        AddStaffCancelButton.Name = "AddStaffCancelButton"
        AddStaffCancelButton.Size = New Size(85, 38)
        AddStaffCancelButton.TabIndex = 5
        AddStaffCancelButton.Text = "Cancel"
        AddStaffCancelButton.UseVisualStyleBackColor = False
        ' 
        ' AddStaffButton
        ' 
        AddStaffButton.BackColor = Color.Gray
        AddStaffButton.FlatAppearance.BorderSize = 0
        AddStaffButton.FlatAppearance.MouseOverBackColor = Color.Silver
        AddStaffButton.FlatStyle = FlatStyle.Flat
        AddStaffButton.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffButton.Location = New Point(299, 375)
        AddStaffButton.Name = "AddStaffButton"
        AddStaffButton.Size = New Size(83, 38)
        AddStaffButton.TabIndex = 6
        AddStaffButton.Text = "Add"
        AddStaffButton.UseVisualStyleBackColor = False
        ' 
        ' AddStaffAvailabilityTextBox
        ' 
        AddStaffAvailabilityTextBox.Location = New Point(15, 282)
        AddStaffAvailabilityTextBox.Name = "AddStaffAvailabilityTextBox"
        AddStaffAvailabilityTextBox.Size = New Size(386, 23)
        AddStaffAvailabilityTextBox.TabIndex = 7
        ' 
        ' AddStaffPhoneTextBox
        ' 
        AddStaffPhoneTextBox.Location = New Point(13, 127)
        AddStaffPhoneTextBox.Name = "AddStaffPhoneTextBox"
        AddStaffPhoneTextBox.Size = New Size(384, 23)
        AddStaffPhoneTextBox.TabIndex = 5
        ' 
        ' AddStaffNameTextBox
        ' 
        AddStaffNameTextBox.Location = New Point(13, 53)
        AddStaffNameTextBox.Name = "AddStaffNameTextBox"
        AddStaffNameTextBox.Size = New Size(384, 23)
        AddStaffNameTextBox.TabIndex = 4
        ' 
        ' AddStaffAvailabilityLabel
        ' 
        AddStaffAvailabilityLabel.AutoSize = True
        AddStaffAvailabilityLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffAvailabilityLabel.Location = New Point(46, 250)
        AddStaffAvailabilityLabel.Name = "AddStaffAvailabilityLabel"
        AddStaffAvailabilityLabel.Size = New Size(80, 29)
        AddStaffAvailabilityLabel.TabIndex = 3
        AddStaffAvailabilityLabel.Text = "Availability"
        ' 
        ' AddStaffTypeLabel
        ' 
        AddStaffTypeLabel.AutoSize = True
        AddStaffTypeLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffTypeLabel.Location = New Point(46, 172)
        AddStaffTypeLabel.Name = "AddStaffTypeLabel"
        AddStaffTypeLabel.Size = New Size(39, 29)
        AddStaffTypeLabel.TabIndex = 2
        AddStaffTypeLabel.Text = "Type"
        ' 
        ' AddStaffPhoneLabel
        ' 
        AddStaffPhoneLabel.AutoSize = True
        AddStaffPhoneLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffPhoneLabel.Location = New Point(46, 95)
        AddStaffPhoneLabel.Name = "AddStaffPhoneLabel"
        AddStaffPhoneLabel.Size = New Size(100, 29)
        AddStaffPhoneLabel.TabIndex = 1
        AddStaffPhoneLabel.Text = "Phone number"
        ' 
        ' AddStaffNameLabel
        ' 
        AddStaffNameLabel.AutoSize = True
        AddStaffNameLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffNameLabel.Location = New Point(46, 21)
        AddStaffNameLabel.Name = "AddStaffNameLabel"
        AddStaffNameLabel.Size = New Size(46, 29)
        AddStaffNameLabel.TabIndex = 0
        AddStaffNameLabel.Text = "Name"
        ' 
        ' AddStaffForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(604, 507)
        Controls.Add(AddStaffPanel2)
        Controls.Add(AddStaffPanel1)
        Name = "AddStaffForm"
        Padding = New Padding(20)
        Text = "Add Staff"
        AddStaffPanel1.ResumeLayout(False)
        AddStaffPanel1.PerformLayout()
        AddStaffPanel2.ResumeLayout(False)
        AddStaffPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AddStaffPanel1 As Panel
    Friend WithEvents AddStaffPanel2 As Panel
    Friend WithEvents AddStaffTypeComboBox As ComboBox
    Friend WithEvents AddStaffDateTimePicker As DateTimePicker
    Friend WithEvents AddStaffDateLabel As Label
    Friend WithEvents AddStaffCancelButton As Button
    Friend WithEvents AddStaffButton As Button
    Friend WithEvents AddStaffAvailabilityTextBox As TextBox
    Friend WithEvents AddStaffPhoneTextBox As TextBox
    Friend WithEvents AddStaffNameTextBox As TextBox
    Friend WithEvents AddStaffAvailabilityLabel As Label
    Friend WithEvents AddStaffTypeLabel As Label
    Friend WithEvents AddStaffPhoneLabel As Label
    Friend WithEvents AddStaffNameLabel As Label
    Friend WithEvents AddStaffLabel As Label
    Friend WithEvents AddStaffCloseButton As Button
End Class
