Public Class studdash
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub studdash_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs)
        If MsgBox("Log Out?", vbYesNo + vbQuestion) = vbYes Then
            Form1.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to Log Out?", "Student Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Form1.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub studdash_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class