<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePageUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePageUserControl))
        Panel1 = New Panel()
        MonthCalendar1 = New MonthCalendar()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Label3 = New Label()
        Panel7 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(MonthCalendar1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(726, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(298, 661)
        Panel1.TabIndex = 0
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        MonthCalendar1.Location = New Point(19, 42)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(152, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 28)
        Panel2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(33, 0)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(358, 27)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 28)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 14F, FontStyle.Bold)
        Label1.Location = New Point(50, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 45)
        Label1.TabIndex = 2
        Label1.Text = "Dashboard"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(22, 59)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(5)
        Panel3.Size = New Size(177, 45)
        Panel3.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Left
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(5, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        Label2.Location = New Point(321, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 37)
        Label2.TabIndex = 4
        Label2.Text = "Activity"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(PictureBox6)
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(Button2)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(434, 48)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(260, 206)
        Panel4.TabIndex = 5
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel5.Controls.Add(Button1)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(15, 48)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(10)
        Panel5.Size = New Size(395, 473)
        Panel5.TabIndex = 6
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel6.Controls.Add(Label14)
        Panel6.Controls.Add(Label20)
        Panel6.Controls.Add(Label15)
        Panel6.Controls.Add(Label16)
        Panel6.Controls.Add(Label17)
        Panel6.Controls.Add(Label18)
        Panel6.Controls.Add(Label19)
        Panel6.Controls.Add(Label21)
        Panel6.Controls.Add(PictureBox7)
        Panel6.Controls.Add(PictureBox8)
        Panel6.Controls.Add(PictureBox9)
        Panel6.Controls.Add(PictureBox10)
        Panel6.Controls.Add(Button3)
        Panel6.Controls.Add(Label5)
        Panel6.Location = New Point(434, 260)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(260, 261)
        Panel6.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        Label3.Location = New Point(63, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 37)
        Label3.TabIndex = 5
        Label3.Text = "Vehicle Status"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label2)
        Panel7.Controls.Add(Panel6)
        Panel7.Controls.Add(Panel5)
        Panel7.Controls.Add(Panel4)
        Panel7.Location = New Point(14, 111)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(704, 531)
        Panel7.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        Label4.Location = New Point(166, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 37)
        Label4.TabIndex = 5
        Label4.Text = "Trips"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        Label5.Location = New Point(104, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 37)
        Label5.TabIndex = 5
        Label5.Text = "Staff"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatAppearance.MouseDownBackColor = Color.Gray
        Button1.FlatAppearance.MouseOverBackColor = Color.Silver
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button1.Location = New Point(345, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(47, 47)
        Button1.TabIndex = 6
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Silver
        Button2.FlatAppearance.MouseDownBackColor = Color.Gray
        Button2.FlatAppearance.MouseOverBackColor = Color.Silver
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button2.Location = New Point(210, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(47, 47)
        Button2.TabIndex = 7
        Button2.Text = "+"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Silver
        Button3.FlatAppearance.MouseDownBackColor = Color.Gray
        Button3.FlatAppearance.MouseOverBackColor = Color.Silver
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Button3.Location = New Point(209, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(47, 47)
        Button3.TabIndex = 8
        Button3.Text = "+"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(24, 91)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(24, 24)
        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(24, 55)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 24)
        PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(24, 163)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(24, 24)
        PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(24, 128)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(24, 24)
        PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(63, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 20)
        Label6.TabIndex = 12
        Label6.Text = "Available"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(63, 91)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 20)
        Label7.TabIndex = 13
        Label7.Text = "On trip"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(63, 128)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 20)
        Label8.TabIndex = 14
        Label8.Text = "Rented out"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(63, 163)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 20)
        Label9.TabIndex = 15
        Label9.Text = "Total"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.DarkSeaGreen
        Label10.Location = New Point(188, 55)
        Label10.Name = "Label10"
        Label10.Size = New Size(15, 20)
        Label10.TabIndex = 16
        Label10.Text = "*"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.DeepSkyBlue
        Label11.Location = New Point(188, 90)
        Label11.Name = "Label11"
        Label11.Size = New Size(15, 20)
        Label11.TabIndex = 17
        Label11.Text = "*"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Orange
        Label12.Location = New Point(188, 128)
        Label12.Name = "Label12"
        Label12.Size = New Size(15, 20)
        Label12.TabIndex = 18
        Label12.Text = "*"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(188, 163)
        Label13.Name = "Label13"
        Label13.Size = New Size(15, 20)
        Label13.TabIndex = 19
        Label13.Text = "*"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(221, 179)
        Label14.Name = "Label14"
        Label14.Size = New Size(15, 20)
        Label14.TabIndex = 31
        Label14.Text = "*"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Orange
        Label15.Location = New Point(219, 144)
        Label15.Name = "Label15"
        Label15.Size = New Size(15, 20)
        Label15.TabIndex = 30
        Label15.Text = "*"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.DeepSkyBlue
        Label16.Location = New Point(219, 107)
        Label16.Name = "Label16"
        Label16.Size = New Size(15, 20)
        Label16.TabIndex = 29
        Label16.Text = "*"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.DarkSeaGreen
        Label17.Location = New Point(219, 71)
        Label17.Name = "Label17"
        Label17.Size = New Size(15, 20)
        Label17.TabIndex = 28
        Label17.Text = "*"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(63, 179)
        Label18.Name = "Label18"
        Label18.Size = New Size(42, 20)
        Label18.TabIndex = 27
        Label18.Text = "Total"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(63, 144)
        Label19.Name = "Label19"
        Label19.Size = New Size(55, 20)
        Label19.TabIndex = 26
        Label19.Text = "On trip"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(63, 107)
        Label20.Name = "Label20"
        Label20.Size = New Size(150, 20)
        Label20.TabIndex = 25
        Label20.Text = "Available Conductors"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(63, 71)
        Label21.Name = "Label21"
        Label21.Size = New Size(121, 20)
        Label21.TabIndex = 24
        Label21.Text = "Available Drivers"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(24, 144)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(24, 24)
        PictureBox7.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox7.TabIndex = 23
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(24, 179)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(24, 24)
        PictureBox8.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox8.TabIndex = 22
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(24, 71)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(24, 24)
        PictureBox9.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox9.TabIndex = 21
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(24, 107)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(24, 24)
        PictureBox10.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox10.TabIndex = 20
        PictureBox10.TabStop = False
        ' 
        ' HomePageUserControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        Controls.Add(Panel7)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(1)
        Name = "HomePageUserControl"
        Size = New Size(1024, 661)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox

End Class
