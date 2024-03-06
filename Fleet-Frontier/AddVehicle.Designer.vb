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
        Panel1 = New Panel()
        exitButton = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(exitButton)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(455, 44)
        Panel1.TabIndex = 0
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
        exitButton.Location = New Point(426, 0)
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
        Label1.Location = New Point(3, 7)
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
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(12, 59)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(431, 526)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gray
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(247, 444)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 35)
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
        Button1.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(84, 444)
        Button1.Name = "Button1"
        Button1.Size = New Size(98, 35)
        Button1.TabIndex = 9
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
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
        Label5.Location = New Point(47, 370)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 31)
        Label5.TabIndex = 7
        Label5.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(15, 282)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 31)
        Label4.TabIndex = 5
        Label4.Text = "Availability"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(15, 316)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(400, 27)
        TextBox3.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 31)
        Label3.TabIndex = 3
        Label3.Text = "Fuel consumption/km"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(15, 226)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(400, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 31)
        Label2.TabIndex = 1
        Label2.Text = "Number Plate"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(15, 138)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(400, 27)
        TextBox1.TabIndex = 0
        ' 
        ' AddVehicle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 597)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "AddVehicle"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents exitButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
End Class
