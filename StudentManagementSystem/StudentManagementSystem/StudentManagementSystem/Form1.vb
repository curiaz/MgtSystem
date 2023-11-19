Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            txtpw.UseSystemPasswordChar = False
        Else
            txtpw.UseSystemPasswordChar = True

        End If
    End Sub
    Private Sub ResetFields()
        txtun.Text = String.Empty
        txtpw.Text = String.Empty
    End Sub
    Private Sub logprof_Click(sender As Object, e As EventArgs) Handles logprof.Click
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM Accounts WHERE Students = @Students", cn)
            cm.Parameters.AddWithValue("@Students", txtun.Text)
            dr = cm.ExecuteReader()

            If dr.Read() Then
                ' Check if the username exists in the database
                If txtun.Text.Equals(dr("Students").ToString()) Then
                    ' Now, check if the password matches the one stored in the database
                    If txtpw.Text.Equals(dr("Password").ToString()) Then
                        MsgBox("Access Granted!", vbInformation)
                        ' Assuming "home" is a form, you can open it like this
                        Dim home As New ADMIN()
                        home.Show()
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

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM tbleesecurity WHERE username = @username", cn)
            cm.Parameters.AddWithValue("@username", txtun.Text)
            dr = cm.ExecuteReader()

            If dr.Read() Then
                If txtun.Text.Equals(dr("username").ToString()) Then
                    If txtpw.Text.Equals(dr("password").ToString()) Then
                        MsgBox("Access Granted!", vbInformation)
                        Dim home As New ADMIN()
                        home.Show()
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




    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you sure you want to exit the program?", "Student Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        StudentEntry.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
