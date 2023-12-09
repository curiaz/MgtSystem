<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentEntry
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(StudentEntry))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        txtsection = New TextBox()
        Label12 = New Label()
        cbyear = New ComboBox()
        cbprogram = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        btnsubmit = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        txtmname = New TextBox()
        cbgender = New ComboBox()
        Label8 = New Label()
        dtbirth = New DateTimePicker()
        txtfname = New TextBox()
        Label5 = New Label()
        txtaddress = New TextBox()
        txtlname = New TextBox()
        Label13 = New Label()
        txtemail = New TextBox()
        GroupBox2 = New GroupBox()
        CheckBox2 = New CheckBox()
        Label14 = New Label()
        Label7 = New Label()
        txtmn = New TextBox()
        txtstudid = New TextBox()
        txtpw = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(468, 39)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(416, 6)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 33)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(84, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 26)
        Label1.TabIndex = 1
        Label1.Text = "Student Registration Form"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(12, 6)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 33)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtsection
        ' 
        txtsection.BorderStyle = BorderStyle.FixedSingle
        txtsection.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtsection.Location = New Point(146, 463)
        txtsection.Margin = New Padding(3, 2, 3, 2)
        txtsection.Name = "txtsection"
        txtsection.Size = New Size(251, 29)
        txtsection.TabIndex = 21
        txtsection.UseWaitCursor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(39, 468)
        Label12.Name = "Label12"
        Label12.Size = New Size(67, 17)
        Label12.TabIndex = 20
        Label12.Text = "Section:"
        ' 
        ' cbyear
        ' 
        cbyear.DropDownStyle = ComboBoxStyle.DropDownList
        cbyear.FlatStyle = FlatStyle.Flat
        cbyear.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cbyear.FormattingEnabled = True
        cbyear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cbyear.Location = New Point(146, 559)
        cbyear.Margin = New Padding(3, 2, 3, 2)
        cbyear.Name = "cbyear"
        cbyear.Size = New Size(251, 28)
        cbyear.TabIndex = 19
        ' 
        ' cbprogram
        ' 
        cbprogram.DropDownStyle = ComboBoxStyle.DropDownList
        cbprogram.FlatStyle = FlatStyle.Flat
        cbprogram.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cbprogram.FormattingEnabled = True
        cbprogram.Items.AddRange(New Object() {"BSCS", "BSIT", "BSIS"})
        cbprogram.Location = New Point(146, 512)
        cbprogram.Margin = New Padding(3, 2, 3, 2)
        cbprogram.Name = "cbprogram"
        cbprogram.Size = New Size(251, 28)
        cbprogram.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(39, 564)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 17)
        Label11.TabIndex = 18
        Label11.Text = "Year Level:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(39, 517)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 17)
        Label10.TabIndex = 17
        Label10.Text = "Course:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(39, 615)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 17)
        Label9.TabIndex = 16
        Label9.Text = "Student ID:"
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackgroundImage = CType(resources.GetObject("btnsubmit.BackgroundImage"), Image)
        btnsubmit.BackgroundImageLayout = ImageLayout.None
        btnsubmit.FlatStyle = FlatStyle.Popup
        btnsubmit.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnsubmit.Image = CType(resources.GetObject("btnsubmit.Image"), Image)
        btnsubmit.Location = New Point(146, 729)
        btnsubmit.Margin = New Padding(3, 2, 3, 2)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(149, 44)
        btnsubmit.TabIndex = 24
        btnsubmit.Text = " Submit"
        btnsubmit.TextAlign = ContentAlignment.MiddleRight
        btnsubmit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnsubmit.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(37, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 17)
        Label3.TabIndex = 6
        Label3.Text = "First Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(39, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 17)
        Label2.TabIndex = 5
        Label2.Text = "Last Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(37, 417)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 17)
        Label6.TabIndex = 11
        Label6.Text = "Gender:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(37, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 17)
        Label4.TabIndex = 7
        Label4.Text = "Middle Name:"
        ' 
        ' txtmname
        ' 
        txtmname.BorderStyle = BorderStyle.FixedSingle
        txtmname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtmname.ForeColor = Color.Silver
        txtmname.Location = New Point(146, 134)
        txtmname.Margin = New Padding(3, 2, 3, 2)
        txtmname.Name = "txtmname"
        txtmname.Size = New Size(251, 29)
        txtmname.TabIndex = 4
        txtmname.Text = "(optional)"
        ' 
        ' cbgender
        ' 
        cbgender.DropDownStyle = ComboBoxStyle.DropDownList
        cbgender.FlatStyle = FlatStyle.Flat
        cbgender.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cbgender.FormattingEnabled = True
        cbgender.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        cbgender.Location = New Point(146, 412)
        cbgender.Margin = New Padding(3, 2, 3, 2)
        cbgender.Name = "cbgender"
        cbgender.Size = New Size(251, 28)
        cbgender.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(39, 190)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 17)
        Label8.TabIndex = 14
        Label8.Text = "Address:"
        ' 
        ' dtbirth
        ' 
        dtbirth.CalendarTitleBackColor = SystemColors.ControlText
        dtbirth.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dtbirth.Format = DateTimePickerFormat.Short
        dtbirth.Location = New Point(146, 363)
        dtbirth.Margin = New Padding(3, 2, 3, 2)
        dtbirth.Name = "dtbirth"
        dtbirth.Size = New Size(251, 26)
        dtbirth.TabIndex = 8
        ' 
        ' txtfname
        ' 
        txtfname.BorderStyle = BorderStyle.FixedSingle
        txtfname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfname.Location = New Point(146, 88)
        txtfname.Margin = New Padding(3, 2, 3, 2)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(251, 29)
        txtfname.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(37, 369)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 17)
        Label5.TabIndex = 9
        Label5.Text = "Birthday:"
        ' 
        ' txtaddress
        ' 
        txtaddress.BorderStyle = BorderStyle.FixedSingle
        txtaddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtaddress.Location = New Point(146, 190)
        txtaddress.Margin = New Padding(3, 2, 3, 2)
        txtaddress.Multiline = True
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(251, 72)
        txtaddress.TabIndex = 15
        ' 
        ' txtlname
        ' 
        txtlname.BorderStyle = BorderStyle.FixedSingle
        txtlname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtlname.Location = New Point(146, 43)
        txtlname.Margin = New Padding(3, 2, 3, 2)
        txtlname.Name = "txtlname"
        txtlname.Size = New Size(251, 29)
        txtlname.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(37, 283)
        Label13.Name = "Label13"
        Label13.Size = New Size(52, 17)
        Label13.TabIndex = 16
        Label13.Text = "Email:"
        ' 
        ' txtemail
        ' 
        txtemail.BorderStyle = BorderStyle.FixedSingle
        txtemail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtemail.Location = New Point(146, 278)
        txtemail.Margin = New Padding(3, 2, 3, 2)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(251, 29)
        txtemail.TabIndex = 17
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(txtpw)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtmn)
        GroupBox2.Controls.Add(txtstudid)
        GroupBox2.Controls.Add(txtemail)
        GroupBox2.Controls.Add(txtsection)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(cbyear)
        GroupBox2.Controls.Add(btnsubmit)
        GroupBox2.Controls.Add(txtlname)
        GroupBox2.Controls.Add(cbprogram)
        GroupBox2.Controls.Add(txtaddress)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(txtfname)
        GroupBox2.Controls.Add(dtbirth)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(cbgender)
        GroupBox2.Controls.Add(txtmname)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(12, 43)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(443, 790)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.Location = New Point(146, 689)
        CheckBox2.Margin = New Padding(3, 2, 3, 2)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(127, 19)
        CheckBox2.TabIndex = 30
        CheckBox2.Text = "Show Password"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(39, 661)
        Label14.Name = "Label14"
        Label14.Size = New Size(82, 17)
        Label14.TabIndex = 29
        Label14.Text = "Password:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(37, 326)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 17)
        Label7.TabIndex = 27
        Label7.Text = "Mobile no.:"
        ' 
        ' txtmn
        ' 
        txtmn.BorderStyle = BorderStyle.FixedSingle
        txtmn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtmn.Location = New Point(146, 321)
        txtmn.Margin = New Padding(3, 2, 3, 2)
        txtmn.MaxLength = 11
        txtmn.Name = "txtmn"
        txtmn.Size = New Size(251, 29)
        txtmn.TabIndex = 26
        ' 
        ' txtstudid
        ' 
        txtstudid.BorderStyle = BorderStyle.FixedSingle
        txtstudid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtstudid.ForeColor = Color.Black
        txtstudid.Location = New Point(146, 610)
        txtstudid.Margin = New Padding(3, 2, 3, 2)
        txtstudid.Name = "txtstudid"
        txtstudid.Size = New Size(251, 29)
        txtstudid.TabIndex = 25
        txtstudid.UseWaitCursor = True
        ' 
        ' txtpw
        ' 
        txtpw.BorderStyle = BorderStyle.FixedSingle
        txtpw.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtpw.Location = New Point(146, 658)
        txtpw.Margin = New Padding(3, 2, 3, 2)
        txtpw.Name = "txtpw"
        txtpw.Size = New Size(251, 26)
        txtpw.TabIndex = 31
        txtpw.UseSystemPasswordChar = True
        txtpw.UseWaitCursor = True
        ' 
        ' StudentEntry
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(467, 844)
        Controls.Add(GroupBox2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "StudentEntry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentEntry"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbyear As ComboBox
    Friend WithEvents cbprogram As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtsection As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmname As TextBox
    Friend WithEvents cbgender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtbirth As DateTimePicker
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtstudid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmn As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents txtpw As TextBox
End Class
