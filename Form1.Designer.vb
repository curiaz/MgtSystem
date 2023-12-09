<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Button2 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        txtun = New TextBox()
        Label3 = New Label()
        txtpw = New TextBox()
        logprof = New Button()
        LinkLabel1 = New LinkLabel()
        CheckBox2 = New CheckBox()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Bisque
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, -6)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(660, 50)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(476, 10)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 36)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(91, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 26)
        Label1.TabIndex = 1
        Label1.Text = "Student Management System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 10)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 36)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(114, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 17)
        Label2.TabIndex = 1
        Label2.Text = "Student ID"
        ' 
        ' txtun
        ' 
        txtun.BorderStyle = BorderStyle.FixedSingle
        txtun.Location = New Point(114, 251)
        txtun.Margin = New Padding(3, 2, 3, 2)
        txtun.Multiline = True
        txtun.Name = "txtun"
        txtun.Size = New Size(278, 23)
        txtun.TabIndex = 2
        txtun.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(114, 286)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 17)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' txtpw
        ' 
        txtpw.BorderStyle = BorderStyle.FixedSingle
        txtpw.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtpw.Location = New Point(114, 305)
        txtpw.Margin = New Padding(3, 2, 3, 2)
        txtpw.Name = "txtpw"
        txtpw.Size = New Size(278, 26)
        txtpw.TabIndex = 6
        txtpw.UseSystemPasswordChar = True
        txtpw.UseWaitCursor = True
        ' 
        ' logprof
        ' 
        logprof.BackgroundImage = CType(resources.GetObject("logprof.BackgroundImage"), Image)
        logprof.BackgroundImageLayout = ImageLayout.Center
        logprof.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        logprof.Image = CType(resources.GetObject("logprof.Image"), Image)
        logprof.Location = New Point(101, 367)
        logprof.Margin = New Padding(3, 2, 3, 2)
        logprof.Name = "logprof"
        logprof.Size = New Size(140, 49)
        logprof.TabIndex = 7
        logprof.Text = "Student Log In"
        logprof.TextAlign = ContentAlignment.MiddleRight
        logprof.TextImageRelation = TextImageRelation.ImageBeforeText
        logprof.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Transparent
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LinkLabel1.ForeColor = SystemColors.ControlText
        LinkLabel1.LinkColor = Color.Firebrick
        LinkLabel1.Location = New Point(188, 418)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(136, 20)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Log In As Professor"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.Location = New Point(114, 335)
        CheckBox2.Margin = New Padding(3, 2, 3, 2)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(127, 19)
        CheckBox2.TabIndex = 10
        CheckBox2.Text = "Show Password"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(56, 461)
        Label4.Name = "Label4"
        Label4.Size = New Size(392, 18)
        Label4.TabIndex = 11
        Label4.Text = "*Note: New Student(s) must Sign Up to create an account,"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(90, 479)
        Label5.Name = "Label5"
        Label5.Size = New Size(316, 18)
        Label5.TabIndex = 12
        Label5.Text = "kindly fill up the form with accurate information*"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(164, 60)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(182, 169)
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(254, 367)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(152, 49)
        Button3.TabIndex = 14
        Button3.Text = " Sign Up"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(519, 504)
        Controls.Add(Button3)
        Controls.Add(PictureBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(CheckBox2)
        Controls.Add(LinkLabel1)
        Controls.Add(txtpw)
        Controls.Add(Label3)
        Controls.Add(txtun)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(logprof)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtun As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpw As TextBox
    Friend WithEvents logprof As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
End Class
