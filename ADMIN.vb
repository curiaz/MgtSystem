Public Class ADMIN

    Private Sub Panel3_paint(sender As Object, e As PaintEventArgs)

    End Sub

    Sub switchpanel(ByVal panel As Form)

        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Log Out?", vbYesNo + vbQuestion) = vbYes Then
            Form1.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchpanel(Home)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchpanel(Professor)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        studrecord.Show()

    End Sub
End Class