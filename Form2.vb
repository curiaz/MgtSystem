Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you sure you want to exit the program?", "Student Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
    End Sub

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT * FROM tbleesecurity WHERE username = @username", cn)
                cm.Parameters.AddWithValue("@username", txtun.Text)
                dr = cm.ExecuteReader()
            End Using

            If dr.Read() Then
                If txtun.Text.Equals(dr("username").ToString()) Then
                    If txtpw.Text.Equals(dr("password").ToString()) Then
                        MsgBox("Access Granted!", vbInformation)

                        ADMIN.Show()
                        Me.Hide()


                    Else
                        MsgBox("Access Denied! Incorrect password", vbInformation)
                    End If
                Else
                    MsgBox("Access Denied! Username not found", vbInformation)
                End If
            Else
                MsgBox("Access Denied! Username not found", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, vbExclamation)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()

            End If
        End Try
        ResetFields()

    End Sub

    Private Sub ResetFields()
        Throw New NotImplementedException()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    End Sub

    Private Sub txtpw_TextChanged(sender As Object, e As EventArgs) Handles txtpw.TextChanged
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub txtun_TextChanged(sender As Object, e As EventArgs) Handles txtun.TextChanged
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub logprof_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub
End Class