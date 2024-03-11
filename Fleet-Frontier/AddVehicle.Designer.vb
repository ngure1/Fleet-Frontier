<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVehicle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddVehicle))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        exitButton = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        ClearButton = New Button()
        Button2 = New Button()
        CancelVehicleButton = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label3 = New Label()
        FuelTextBox = New TextBox()
        Label2 = New Label()
        NumberPlateTextBox = New TextBox()
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
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(453, 44)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 44)
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
        exitButton.Location = New Point(424, 0)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(29, 44)
        exitButton.TabIndex = 5
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 37)
        Label1.TabIndex = 0
        Label1.Text = "Add Vehicle"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ClearButton)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(CancelVehicleButton)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(FuelTextBox)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(NumberPlateTextBox)
        Panel2.Location = New Point(11, 59)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(431, 526)
        Panel2.TabIndex = 1
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(18, 444)
        ClearButton.Margin = New Padding(3, 4, 3, 4)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(98, 35)
        ClearButton.TabIndex = 11
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gray
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(315, 444)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 35)
        Button2.TabIndex = 10
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CancelVehicleButton
        ' 
        CancelVehicleButton.BackColor = Color.Gray
        CancelVehicleButton.FlatAppearance.BorderSize = 0
        CancelVehicleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelVehicleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CancelVehicleButton.FlatStyle = FlatStyle.Flat
        CancelVehicleButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        CancelVehicleButton.ForeColor = Color.Red
        CancelVehicleButton.Location = New Point(165, 444)
        CancelVehicleButton.Name = "CancelVehicleButton"
        CancelVehicleButton.Size = New Size(98, 35)
        CancelVehicleButton.TabIndex = 9
        CancelVehicleButton.Text = "Cancel"
        CancelVehicleButton.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(95, 369)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(47, 371)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 31)
        Label5.TabIndex = 7
        Label5.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(9, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 31)
        Label3.TabIndex = 3
        Label3.Text = "Fuel consumption/km"
        ' 
        ' FuelTextBox
        ' 
        FuelTextBox.Location = New Point(16, 275)
        FuelTextBox.Name = "FuelTextBox"
        FuelTextBox.Size = New Size(399, 27)
        FuelTextBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 31)
        Label2.TabIndex = 1
        Label2.Text = "Number Plate"
        ' 
        ' NumberPlateTextBox
        ' 
        NumberPlateTextBox.Location = New Point(18, 140)
        NumberPlateTextBox.Name = "NumberPlateTextBox"
        NumberPlateTextBox.Size = New Size(399, 27)
        NumberPlateTextBox.TabIndex = 0
        ' 
        ' AddVehicle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(453, 595)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddVehicle"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents exitButton As Button
    Friend WithEvents NumberPlateTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FuelTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CancelVehicleButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClearButton As Button
End Class
