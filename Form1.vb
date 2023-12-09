Imports System.Diagnostics.Eventing
Imports System.Diagnostics.Eventing.Reader
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
    Private Sub Logprof_Click(sender As Object, e As EventArgs) Handles logprof.Click
        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT * FROM tbleinfo WHERE StudentID = @studentid", cn)
                cm.Parameters.AddWithValue("studentID", txtun.Text)
                dr = cm.ExecuteReader()

                If dr.Read() Then
                    ' Check if the username exists in the database
                    If txtun.Text.Equals(dr("studentID").ToString()) Then
                        ' Now, check if the password matches the one stored in the database
                        If txtpw.Text.Equals(dr("password").ToString()) Then
                            MsgBox("Access Granted!", vbInformation)

                            ' Assuming "studdash" is a form, you can open it like this
                            studdash.Show()

                            ' Assign values to labels on studdash form
                            studdash.Lblfname.Text = dr("firstname").ToString()
                            studdash.Lblmname.Text = dr("middlename").ToString()
                            studdash.Lblsname.Text = dr("lastname").ToString()
                            studdash.Lblemail.Text = dr("email").ToString()
                            studdash.Lblno.Text = dr("num").ToString()
                            studdash.Lblgender.Text = dr("gender").ToString()
                            studdash.Lblbd.Text = dr("birthday").ToString()
                            studdash.Lblcourse.Text = dr("program").ToString()
                            studdash.Lblyear.Text = dr("year").ToString()
                            studdash.Lblsec.Text = dr("section").ToString()
                            studdash.Lblids.Text = dr("studentID").ToString()
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
            End Using
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

    Private Sub Btnadmin_Click(sender As Object, e As EventArgs)
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
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StudentEntry.Show()
        Me.Hide()

    End Sub
End Class
