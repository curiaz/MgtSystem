<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ADMIN))
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Linen
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1398, 75)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(1348, 20)
        Button5.Name = "Button5"
        Button5.Size = New Size(37, 33)
        Button5.TabIndex = 3
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(1305, 20)
        Button4.Name = "Button4"
        Button4.Size = New Size(37, 33)
        Button4.TabIndex = 2
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Unispace", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(79, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 33)
        Label1.TabIndex = 1
        Label1.Text = "Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 72)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.BurlyWood
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(-10, 336)
        Button2.Name = "Button2"
        Button2.Size = New Size(270, 60)
        Button2.TabIndex = 3
        Button2.Text = "Student Record"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.BurlyWood
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(-10, 239)
        Button1.Name = "Button1"
        Button1.Size = New Size(270, 60)
        Button1.TabIndex = 2
        Button1.Text = "Professor"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.BurlyWood
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(-10, 140)
        Button3.Name = "Button3"
        Button3.Size = New Size(270, 60)
        Button3.TabIndex = 4
        Button3.Text = " Home"
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.PeachPuff
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button2)
        Panel2.Location = New Point(0, 74)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 813)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Linen
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(247, 74)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1151, 750)
        Panel3.TabIndex = 2
        ' 
        ' ADMIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1397, 824)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ADMIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMIN"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
