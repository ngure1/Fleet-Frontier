<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        ControlBarPanel = New Panel()
        TitleLabel = New Label()
        FaviconPictureBox = New PictureBox()
        MinimizeButton = New Button()
        ExitButton = New Button()
        BusIconPictureBox = New PictureBox()
        Panel1 = New Panel()
        UsernameTextBox = New TextBox()
        UsernamePictureBox = New PictureBox()
        LoginLabel = New Label()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        PictureBox3 = New PictureBox()
        LoginButton = New Button()
        ControlBarPanel.SuspendLayout()
        CType(FaviconPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(BusIconPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(UsernamePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ControlBarPanel
        ' 
        ControlBarPanel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ControlBarPanel.Controls.Add(TitleLabel)
        ControlBarPanel.Controls.Add(FaviconPictureBox)
        ControlBarPanel.Controls.Add(MinimizeButton)
        ControlBarPanel.Controls.Add(ExitButton)
        ControlBarPanel.Dock = DockStyle.Top
        ControlBarPanel.Location = New Point(0, 0)
        ControlBarPanel.Name = "ControlBarPanel"
        ControlBarPanel.Size = New Size(453, 39)
        ControlBarPanel.TabIndex = 0
        ' 
        ' TitleLabel
        ' 
        TitleLabel.AutoSize = True
        TitleLabel.FlatStyle = FlatStyle.Flat
        TitleLabel.Font = New Font("MV Boli", 12F, FontStyle.Bold)
        TitleLabel.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        TitleLabel.Location = New Point(50, 7)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New Size(186, 31)
        TitleLabel.TabIndex = 4
        TitleLabel.Text = "Fleet Frontier"
        ' 
        ' FaviconPictureBox
        ' 
        FaviconPictureBox.Dock = DockStyle.Left
        FaviconPictureBox.Image = CType(resources.GetObject("FaviconPictureBox.Image"), Image)
        FaviconPictureBox.Location = New Point(0, 0)
        FaviconPictureBox.Name = "FaviconPictureBox"
        FaviconPictureBox.Size = New Size(44, 39)
        FaviconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        FaviconPictureBox.TabIndex = 3
        FaviconPictureBox.TabStop = False
        ' 
        ' MinimizeButton
        ' 
        MinimizeButton.Dock = DockStyle.Right
        MinimizeButton.FlatAppearance.BorderSize = 0
        MinimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        MinimizeButton.FlatStyle = FlatStyle.Flat
        MinimizeButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MinimizeButton.Location = New Point(395, 0)
        MinimizeButton.Name = "MinimizeButton"
        MinimizeButton.Size = New Size(29, 39)
        MinimizeButton.TabIndex = 2
        MinimizeButton.Text = "-"
        MinimizeButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Dock = DockStyle.Right
        ExitButton.FlatAppearance.BorderSize = 0
        ExitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ExitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ExitButton.FlatStyle = FlatStyle.Flat
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitButton.Location = New Point(424, 0)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(29, 39)
        ExitButton.TabIndex = 1
        ExitButton.Text = "X"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' BusIconPictureBox
        ' 
        BusIconPictureBox.Image = CType(resources.GetObject("BusIconPictureBox.Image"), Image)
        BusIconPictureBox.Location = New Point(98, 67)
        BusIconPictureBox.Name = "BusIconPictureBox"
        BusIconPictureBox.Size = New Size(221, 200)
        BusIconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        BusIconPictureBox.TabIndex = 1
        BusIconPictureBox.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(UsernameTextBox)
        Panel1.Controls.Add(UsernamePictureBox)
        Panel1.Location = New Point(50, 301)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(301, 44)
        Panel1.TabIndex = 2
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(59, 6)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(230, 37)
        UsernameTextBox.TabIndex = 1
        ' 
        ' UsernamePictureBox
        ' 
        UsernamePictureBox.Dock = DockStyle.Left
        UsernamePictureBox.Image = CType(resources.GetObject("UsernamePictureBox.Image"), Image)
        UsernamePictureBox.Location = New Point(0, 0)
        UsernamePictureBox.Name = "UsernamePictureBox"
        UsernamePictureBox.Size = New Size(49, 44)
        UsernamePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        UsernamePictureBox.TabIndex = 0
        UsernamePictureBox.TabStop = False
        ' 
        ' LoginLabel
        ' 
        LoginLabel.AutoSize = True
        LoginLabel.Font = New Font("Gabriola", 15F, FontStyle.Bold)
        LoginLabel.Location = New Point(152, 240)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New Size(177, 55)
        LoginLabel.TabIndex = 3
        LoginLabel.Text = "Welcome Back!"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(50, 388)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(301, 44)
        Panel2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(59, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(230, 37)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Dock = DockStyle.Left
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Padding = New Padding(4)
        PictureBox3.Size = New Size(49, 44)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LoginButton.FlatAppearance.BorderSize = 0
        LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        LoginButton.Location = New Point(109, 460)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(230, 36)
        LoginButton.TabIndex = 5
        LoginButton.Text = "Log In"
        LoginButton.TextAlign = ContentAlignment.TopCenter
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(453, 579)
        ControlBox = False
        Controls.Add(LoginButton)
        Controls.Add(Panel2)
        Controls.Add(LoginLabel)
        Controls.Add(Panel1)
        Controls.Add(BusIconPictureBox)
        Controls.Add(ControlBarPanel)
        Font = New Font("MV Boli", 9F)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        ControlBarPanel.ResumeLayout(False)
        ControlBarPanel.PerformLayout()
        CType(FaviconPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(BusIconPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UsernamePictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ControlBarPanel As Panel
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents FaviconPictureBox As PictureBox
    Friend WithEvents BusIconPictureBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoginLabel As Label
    Friend WithEvents UsernamePictureBox As PictureBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LoginButton As Button
End Class
