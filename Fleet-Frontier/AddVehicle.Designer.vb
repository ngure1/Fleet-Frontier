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
        Button1 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        AvailabilityTextBox = New TextBox()
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
        Panel1.Margin = New Padding(7, 5, 7, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(967, 90)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(7, 5, 7, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 90)
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
        exitButton.Location = New Point(906, 0)
        exitButton.Margin = New Padding(7, 5, 7, 5)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(61, 90)
        exitButton.TabIndex = 5
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(100, 8)
        Label1.Margin = New Padding(7, 0, 7, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 74)
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
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(AvailabilityTextBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(FuelTextBox)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(NumberPlateTextBox)
        Panel2.Location = New Point(24, 120)
        Panel2.Margin = New Padding(7, 5, 7, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(913, 1076)
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
        ClearButton.Location = New Point(32, 910)
        ClearButton.Margin = New Padding(7, 8, 7, 8)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(209, 71)
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
        Button2.Location = New Point(673, 910)
        Button2.Margin = New Padding(7, 5, 7, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(209, 71)
        Button2.TabIndex = 10
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(350, 910)
        Button1.Margin = New Padding(7, 5, 7, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(209, 71)
        Button1.TabIndex = 9
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(202, 757)
        DateTimePicker1.Margin = New Padding(7, 5, 7, 5)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(526, 47)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(100, 760)
        Label5.Margin = New Padding(7, 0, 7, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 63)
        Label5.TabIndex = 7
        Label5.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(32, 579)
        Label4.Margin = New Padding(7, 0, 7, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 63)
        Label4.TabIndex = 5
        Label4.Text = "Availability"
        ' 
        ' AvailabilityTextBox
        ' 
        AvailabilityTextBox.Location = New Point(32, 648)
        AvailabilityTextBox.Margin = New Padding(7, 5, 7, 5)
        AvailabilityTextBox.Name = "AvailabilityTextBox"
        AvailabilityTextBox.Size = New Size(844, 47)
        AvailabilityTextBox.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(32, 394)
        Label3.Margin = New Padding(7, 0, 7, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(277, 63)
        Label3.TabIndex = 3
        Label3.Text = "Fuel consumption/km"
        ' 
        ' FuelTextBox
        ' 
        FuelTextBox.Location = New Point(32, 465)
        FuelTextBox.Margin = New Padding(7, 5, 7, 5)
        FuelTextBox.Name = "FuelTextBox"
        FuelTextBox.Size = New Size(844, 47)
        FuelTextBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 213)
        Label2.Margin = New Padding(7, 0, 7, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 63)
        Label2.TabIndex = 1
        Label2.Text = "Number Plate"
        ' 
        ' NumberPlateTextBox
        ' 
        NumberPlateTextBox.Location = New Point(32, 284)
        NumberPlateTextBox.Margin = New Padding(7, 5, 7, 5)
        NumberPlateTextBox.Name = "NumberPlateTextBox"
        NumberPlateTextBox.Size = New Size(844, 47)
        NumberPlateTextBox.TabIndex = 0
        ' 
        ' AddVehicle
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(967, 1225)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(7, 5, 7, 5)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents AvailabilityTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FuelTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClearButton As Button
End Class
