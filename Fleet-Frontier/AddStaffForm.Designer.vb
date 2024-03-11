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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStaffForm))
        ControlBoxPanel = New Panel()
        ControlBoxIcon = New PictureBox()
        CloseButton = New Button()
        AddStaffLabel = New Label()
        BodyPanel = New Panel()
        ClearButton = New Button()
        TypeComboBox = New ComboBox()
        StaffDateTimePicker = New DateTimePicker()
        DateLabel = New Label()
        CancelStaffButton = New Button()
        AddStaffConfirmButton = New Button()
        PhoneNumberTextBox = New TextBox()
        NameTextBox = New TextBox()
        TypeLabel = New Label()
        PhoneNumberLabel = New Label()
        NameLabel = New Label()
        ControlBoxPanel.SuspendLayout()
        CType(ControlBoxIcon, ComponentModel.ISupportInitialize).BeginInit()
        BodyPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' ControlBoxPanel
        ' 
        ControlBoxPanel.BackColor = Color.Gray
        ControlBoxPanel.BorderStyle = BorderStyle.FixedSingle
        ControlBoxPanel.Controls.Add(ControlBoxIcon)
        ControlBoxPanel.Controls.Add(CloseButton)
        ControlBoxPanel.Controls.Add(AddStaffLabel)
        ControlBoxPanel.Dock = DockStyle.Top
        ControlBoxPanel.Location = New Point(0, 0)
        ControlBoxPanel.Margin = New Padding(3, 4, 3, 4)
        ControlBoxPanel.Name = "ControlBoxPanel"
        ControlBoxPanel.Size = New Size(517, 55)
        ControlBoxPanel.TabIndex = 10
        ' 
        ' ControlBoxIcon
        ' 
        ControlBoxIcon.Dock = DockStyle.Left
        ControlBoxIcon.Image = CType(resources.GetObject("ControlBoxIcon.Image"), Image)
        ControlBoxIcon.Location = New Point(0, 0)
        ControlBoxIcon.Name = "ControlBoxIcon"
        ControlBoxIcon.Size = New Size(53, 53)
        ControlBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage
        ControlBoxIcon.TabIndex = 2
        ControlBoxIcon.TabStop = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.Gray
        CloseButton.Dock = DockStyle.Right
        CloseButton.FlatAppearance.BorderSize = 0
        CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CloseButton.FlatStyle = FlatStyle.Flat
        CloseButton.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseButton.Location = New Point(475, 0)
        CloseButton.Margin = New Padding(3, 4, 3, 4)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(40, 53)
        CloseButton.TabIndex = 1
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' AddStaffLabel
        ' 
        AddStaffLabel.AutoSize = True
        AddStaffLabel.BackColor = Color.Gray
        AddStaffLabel.Font = New Font("Gabriola", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffLabel.Location = New Point(46, -1)
        AddStaffLabel.Name = "AddStaffLabel"
        AddStaffLabel.Padding = New Padding(11, 13, 11, 13)
        AddStaffLabel.Size = New Size(100, 61)
        AddStaffLabel.TabIndex = 0
        AddStaffLabel.Text = "Add Staff"
        ' 
        ' BodyPanel
        ' 
        BodyPanel.BackColor = Color.Silver
        BodyPanel.BorderStyle = BorderStyle.FixedSingle
        BodyPanel.Controls.Add(ClearButton)
        BodyPanel.Controls.Add(TypeComboBox)
        BodyPanel.Controls.Add(StaffDateTimePicker)
        BodyPanel.Controls.Add(DateLabel)
        BodyPanel.Controls.Add(CancelStaffButton)
        BodyPanel.Controls.Add(AddStaffConfirmButton)
        BodyPanel.Controls.Add(PhoneNumberTextBox)
        BodyPanel.Controls.Add(NameTextBox)
        BodyPanel.Controls.Add(TypeLabel)
        BodyPanel.Controls.Add(PhoneNumberLabel)
        BodyPanel.Controls.Add(NameLabel)
        BodyPanel.Location = New Point(11, 67)
        BodyPanel.Margin = New Padding(3, 4, 3, 4)
        BodyPanel.Name = "BodyPanel"
        BodyPanel.Padding = New Padding(11, 13, 11, 13)
        BodyPanel.Size = New Size(492, 607)
        BodyPanel.TabIndex = 11
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(28, 500)
        ClearButton.Margin = New Padding(3, 4, 3, 4)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(98, 35)
        ClearButton.TabIndex = 10
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' TypeComboBox
        ' 
        TypeComboBox.FormattingEnabled = True
        TypeComboBox.Items.AddRange(New Object() {"Driver", "Conductor"})
        TypeComboBox.Location = New Point(26, 363)
        TypeComboBox.Margin = New Padding(3, 4, 3, 4)
        TypeComboBox.Name = "TypeComboBox"
        TypeComboBox.Size = New Size(436, 28)
        TypeComboBox.TabIndex = 9
        ' 
        ' StaffDateTimePicker
        ' 
        StaffDateTimePicker.Location = New Point(125, 439)
        StaffDateTimePicker.Margin = New Padding(3, 4, 3, 4)
        StaffDateTimePicker.Name = "StaffDateTimePicker"
        StaffDateTimePicker.Size = New Size(246, 27)
        StaffDateTimePicker.TabIndex = 8
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateLabel.Location = New Point(69, 429)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(50, 37)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date"
        ' 
        ' CancelStaffButton
        ' 
        CancelStaffButton.BackColor = Color.Gray
        CancelStaffButton.FlatAppearance.BorderSize = 0
        CancelStaffButton.FlatAppearance.MouseOverBackColor = Color.Silver
        CancelStaffButton.FlatStyle = FlatStyle.Flat
        CancelStaffButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        CancelStaffButton.ForeColor = Color.Red
        CancelStaffButton.Location = New Point(197, 500)
        CancelStaffButton.Margin = New Padding(3, 4, 3, 4)
        CancelStaffButton.Name = "CancelStaffButton"
        CancelStaffButton.Size = New Size(98, 35)
        CancelStaffButton.TabIndex = 5
        CancelStaffButton.Text = "Cancel"
        CancelStaffButton.UseVisualStyleBackColor = False
        ' 
        ' AddStaffConfirmButton
        ' 
        AddStaffConfirmButton.BackColor = Color.Gray
        AddStaffConfirmButton.FlatAppearance.BorderSize = 0
        AddStaffConfirmButton.FlatAppearance.MouseOverBackColor = Color.Silver
        AddStaffConfirmButton.FlatStyle = FlatStyle.Flat
        AddStaffConfirmButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        AddStaffConfirmButton.Location = New Point(361, 500)
        AddStaffConfirmButton.Margin = New Padding(3, 4, 3, 4)
        AddStaffConfirmButton.Name = "AddStaffConfirmButton"
        AddStaffConfirmButton.Size = New Size(98, 35)
        AddStaffConfirmButton.TabIndex = 6
        AddStaffConfirmButton.Text = "Add"
        AddStaffConfirmButton.UseVisualStyleBackColor = False
        ' 
        ' PhoneNumberTextBox
        ' 
        PhoneNumberTextBox.Location = New Point(29, 247)
        PhoneNumberTextBox.Margin = New Padding(3, 4, 3, 4)
        PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        PhoneNumberTextBox.Size = New Size(438, 27)
        PhoneNumberTextBox.TabIndex = 5
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(29, 130)
        NameTextBox.Margin = New Padding(3, 4, 3, 4)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(438, 27)
        NameTextBox.TabIndex = 4
        ' 
        ' TypeLabel
        ' 
        TypeLabel.AutoSize = True
        TypeLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TypeLabel.Location = New Point(20, 322)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New Size(49, 37)
        TypeLabel.TabIndex = 2
        TypeLabel.Text = "Type"
        ' 
        ' PhoneNumberLabel
        ' 
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PhoneNumberLabel.Location = New Point(22, 208)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New Size(119, 37)
        PhoneNumberLabel.TabIndex = 1
        PhoneNumberLabel.Text = "Phone number"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameLabel.Location = New Point(21, 91)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(57, 37)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name"
        ' 
        ' AddStaffForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(517, 676)
        ControlBox = False
        Controls.Add(BodyPanel)
        Controls.Add(ControlBoxPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "AddStaffForm"
        ControlBoxPanel.ResumeLayout(False)
        ControlBoxPanel.PerformLayout()
        CType(ControlBoxIcon, ComponentModel.ISupportInitialize).EndInit()
        BodyPanel.ResumeLayout(False)
        BodyPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ControlBoxPanel As Panel
    Friend WithEvents BodyPanel As Panel
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents StaffDateTimePicker As DateTimePicker
    Friend WithEvents DateLabel As Label
    Friend WithEvents CancelStaffButton As Button
    Friend WithEvents AddStaffConfirmButton As Button
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents TypeLabel As Label
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddStaffLabel As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents ControlBoxIcon As PictureBox
    Friend WithEvents ClearButton As Button
End Class
