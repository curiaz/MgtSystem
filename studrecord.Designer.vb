<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studrecord
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(studrecord))
        dtstud = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Button2 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        btnRefresh = New Button()
        Button3 = New Button()
        LinkLabel1 = New LinkLabel()
        CType(dtstud, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dtstud
        ' 
        dtstud.AllowUserToAddRows = False
        dtstud.AllowUserToDeleteRows = False
        dtstud.BorderStyle = BorderStyle.Fixed3D
        dtstud.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.LightGoldenrodYellow
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dtstud.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dtstud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtstud.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column12, Column10, Column9, Column7, Column8, Column11, Column6})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.Linen
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dtstud.DefaultCellStyle = DataGridViewCellStyle6
        dtstud.EnableHeadersVisualStyles = False
        dtstud.Location = New Point(-1, 90)
        dtstud.Margin = New Padding(3, 2, 3, 2)
        dtstud.Name = "dtstud"
        dtstud.ReadOnly = True
        dtstud.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        dtstud.RowHeadersVisible = False
        dtstud.RowHeadersWidth = 51
        dtstud.RowTemplate.Height = 29
        dtstud.Size = New Size(1477, 640)
        dtstud.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 40
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Student ID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Lastname"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Firstname"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Middlename"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 150
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Birthday"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 125
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Gender"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Year"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Section"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 150
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Program"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 150
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Email"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 200
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column6.HeaderText = "Address"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Bisque
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, -1)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1477, 58)
        Panel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(1431, 14)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(32, 25)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(65, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 26)
        Label1.TabIndex = 1
        Label1.Text = "Student Information"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(11, 10)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 39)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnRefresh)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Location = New Point(-1, 52)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1474, 40)
        Panel2.TabIndex = 2
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Green
        btnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.ForeColor = SystemColors.ButtonHighlight
        btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), Image)
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(0, 0)
        btnRefresh.Margin = New Padding(3, 2, 3, 2)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(134, 40)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "   Refresh"
        btnRefresh.TextAlign = ContentAlignment.MiddleLeft
        btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Green
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(1226, 0)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(251, 40)
        Button3.TabIndex = 1
        Button3.Text = "    New"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.Location = New Point(1148, 7)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(68, 25)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Import"
        ' 
        ' studrecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1473, 734)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(dtstud)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "studrecord"
        StartPosition = FormStartPosition.CenterScreen
        Text = "studrecord"
        CType(dtstud, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtstud As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As Button
End Class
