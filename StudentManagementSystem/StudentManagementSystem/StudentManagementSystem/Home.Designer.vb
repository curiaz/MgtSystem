<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Home))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblTotalstud = New Label()
        lblCs = New Label()
        lblAcadyear = New Label()
        lblSem = New Label()
        lblIt = New Label()
        lblIs = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(196, 156)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(336, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 33)
        Label1.TabIndex = 1
        Label1.Text = "Student Management System"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(47, 222)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1026, 295)
        Panel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(287, 33)
        Label2.TabIndex = 3
        Label2.Text = "Student Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(84, 160, 255)
        Panel2.Controls.Add(lblTotalstud)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(12, 86)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(287, 164)
        Panel2.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(255, 159, 67)
        Panel4.Controls.Add(lblIs)
        Panel4.Controls.Add(lblIt)
        Panel4.Controls.Add(lblCs)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(362, 86)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(287, 164)
        Panel4.TabIndex = 5
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(254, 202, 87)
        Panel5.Controls.Add(lblSem)
        Panel5.Controls.Add(lblAcadyear)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(710, 86)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(287, 164)
        Panel5.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 18)
        Label3.TabIndex = 0
        Label3.Text = "Total Student"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(3, 2)
        Label4.Name = "Label4"
        Label4.Size = New Size(278, 18)
        Label4.TabIndex = 1
        Label4.Text = "Total Student In Every Courses"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(3, 2)
        Label5.Name = "Label5"
        Label5.Size = New Size(215, 18)
        Label5.TabIndex = 2
        Label5.Text = "Academic Year/ Semester"
        ' 
        ' lblTotalstud
        ' 
        lblTotalstud.AutoSize = True
        lblTotalstud.Font = New Font("Unispace", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalstud.ForeColor = Color.Black
        lblTotalstud.Location = New Point(3, 65)
        lblTotalstud.Name = "lblTotalstud"
        lblTotalstud.Size = New Size(44, 48)
        lblTotalstud.TabIndex = 1
        lblTotalstud.Text = "0"
        ' 
        ' lblCs
        ' 
        lblCs.AutoSize = True
        lblCs.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCs.ForeColor = Color.Black
        lblCs.Location = New Point(16, 54)
        lblCs.Name = "lblCs"
        lblCs.Size = New Size(82, 24)
        lblCs.TabIndex = 2
        lblCs.Text = "BSCS /"
        ' 
        ' lblAcadyear
        ' 
        lblAcadyear.AutoSize = True
        lblAcadyear.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAcadyear.ForeColor = Color.Black
        lblAcadyear.Location = New Point(3, 54)
        lblAcadyear.Name = "lblAcadyear"
        lblAcadyear.Size = New Size(262, 48)
        lblAcadyear.TabIndex = 4
        lblAcadyear.Text = "Academic Year / 2023 " + vbCrLf + "- 2024"
        ' 
        ' lblSem
        ' 
        lblSem.AutoSize = True
        lblSem.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblSem.ForeColor = Color.Black
        lblSem.Location = New Point(3, 117)
        lblSem.Name = "lblSem"
        lblSem.Size = New Size(202, 24)
        lblSem.TabIndex = 5
        lblSem.Text = "Semester / First"
        ' 
        ' lblIt
        ' 
        lblIt.AutoSize = True
        lblIt.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIt.ForeColor = Color.Black
        lblIt.Location = New Point(16, 85)
        lblIt.Name = "lblIt"
        lblIt.Size = New Size(94, 24)
        lblIt.TabIndex = 3
        lblIt.Text = "BSIT / "
        ' 
        ' lblIs
        ' 
        lblIs.AutoSize = True
        lblIs.Font = New Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIs.ForeColor = Color.Black
        lblIs.Location = New Point(16, 117)
        lblIs.Name = "lblIs"
        lblIs.Size = New Size(94, 24)
        lblIs.TabIndex = 4
        lblIs.Text = "BSIS / "
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1151, 750)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Home"
        Text = "Home"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSem As Label
    Friend WithEvents lblAcadyear As Label
    Friend WithEvents lblIs As Label
    Friend WithEvents lblIt As Label
    Friend WithEvents lblCs As Label
    Friend WithEvents lblTotalstud As Label
End Class
