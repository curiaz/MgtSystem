
Public Class studpass

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        If txtsid.Text.Equals("") OrElse txtspass.Text.Equals("") Then
            MessageBox.Show("Please fill up all fields", "Student Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else


            cn.Open()

            Using cm As New MySqlCommand("INSERT INTO tbleinfo (Students, `Password`) VALUES (@students, @Password)", cn)
                With cm.Parameters
                    .AddWithValue("@students", txtsid.Text)
                    .AddWithValue("@Password", txtspass.Text)
                End With

                cm.ExecuteNonQuery()
            End Using


            MessageBox.Show("Student Account successfully saved! You can now Login to your account", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            txtspass.UseSystemPasswordChar = False
        Else
            txtspass.UseSystemPasswordChar = True

        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub studpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Other initialization code if needed
    End Sub
End Class
