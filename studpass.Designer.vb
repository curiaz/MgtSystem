<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studpass
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(studpass))
        Panel1 = New Panel()
        Button2 = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        txtsid = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btncreate = New Button()
        CheckBox2 = New CheckBox()
        txtspass = New TextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Bisque
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(363, 42)
        Panel1.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(319, 2)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 36)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(48, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(265, 26)
        Label2.TabIndex = 1
        Label2.Text = "Create Student Account"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 36)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtsid
        ' 
        txtsid.Location = New Point(48, 158)
        txtsid.Name = "txtsid"
        txtsid.Size = New Size(265, 23)
        txtsid.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(48, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 17)
        Label1.TabIndex = 8
        Label1.Text = "Student ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Nueva Std", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(117, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 19)
        Label4.TabIndex = 10
        Label4.Text = "LET'S SET UP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(48, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 17)
        Label5.TabIndex = 11
        Label5.Text = "Your Password:"
        ' 
        ' btncreate
        ' 
        btncreate.FlatStyle = FlatStyle.Popup
        btncreate.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btncreate.Image = CType(resources.GetObject("btncreate.Image"), Image)
        btncreate.Location = New Point(117, 278)
        btncreate.Margin = New Padding(3, 2, 3, 2)
        btncreate.Name = "btncreate"
        btncreate.Size = New Size(115, 44)
        btncreate.TabIndex = 25
        btncreate.Text = "Create"
        btncreate.TextAlign = ContentAlignment.MiddleRight
        btncreate.TextImageRelation = TextImageRelation.ImageBeforeText
        btncreate.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Transparent
        CheckBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.Location = New Point(48, 241)
        CheckBox2.Margin = New Padding(3, 2, 3, 2)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(127, 19)
        CheckBox2.TabIndex = 26
        CheckBox2.Text = "Show Password"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' txtspass
        ' 
        txtspass.BorderStyle = BorderStyle.FixedSingle
        txtspass.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtspass.Location = New Point(48, 212)
        txtspass.Margin = New Padding(3, 2, 3, 2)
        txtspass.Name = "txtspass"
        txtspass.Size = New Size(265, 26)
        txtspass.TabIndex = 27
        txtspass.UseSystemPasswordChar = True
        txtspass.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Nueva Std", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(63, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(228, 19)
        Label3.TabIndex = 28
        Label3.Text = "YOUR STUDENT ACCOUNT!"
        ' 
        ' studpass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(362, 338)
        Controls.Add(Label3)
        Controls.Add(txtspass)
        Controls.Add(CheckBox2)
        Controls.Add(btncreate)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(txtsid)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "studpass"
        Text = "studpass"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtsid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btncreate As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents txtspass As TextBox
    Friend WithEvents Label3 As Label
End Class
