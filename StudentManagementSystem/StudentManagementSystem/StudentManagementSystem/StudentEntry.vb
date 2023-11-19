Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class StudentEntry
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Close()
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim today As String = DateTime.Now.ToShortDateString
        If txtlname.Text.Equals("") OrElse txtfname.Text.Equals("") OrElse txtaddress.Text.Equals("") OrElse txtstudid.Text.Equals("") OrElse cbgender.Text.Equals("") OrElse cbyear.Text.Equals("") OrElse cbprogram.Text.Equals("") OrElse txtemail.Text.Equals("") OrElse txtsection.Text.Equals("") Then
            MessageBox.Show("Please fill up all fields", "Student Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf dtbirth.Text.Equals(today) Then

            MessageBox.Show("Birthday must not be today", "Student Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            cn.Open()
            cm = New MySqlCommand("insert into tbleinfo (studentID, lastname, firstname, middlename,birthday ,gender, year, section, program, email, address, num) values (@studentid,@lname,@nname,@mname,@bday,@gender,@year,@section,@program,@email,@address,@num)", cn)
            With cm.Parameters
                .AddWithValue("@studentID", txtstudid.Text)
                .AddWithValue("@lname", txtlname.Text)
                .AddWithValue("@nname", txtfname.Text)
                .AddWithValue("@mname", txtmname.Text)
                .AddWithValue("@bday", dtbirth.Text.ToString)
                .AddWithValue("@gender", cbgender.Text)
                .AddWithValue("@year", cbyear.Text)
                .AddWithValue("@section", txtsection.Text)
                .AddWithValue("@program", cbprogram.Text)
                .AddWithValue("@email", txtemail.Text)
                .AddWithValue("@address", txtaddress.Text)
                .AddWithValue("@num", txtmn.Text)
            End With
            cm.ExecuteNonQuery()
            MessageBox.Show("Data successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
            studpass.Show()
            Me.Hide()

        End If



    End Sub

    Private Sub txtmname_Enter(sender As Object, e As EventArgs) Handles txtmname.Enter
        If txtmname.Text.Equals("(optional)") Then
            txtmname.Text = ""
            txtmname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtmname_Leave(sender As Object, e As EventArgs) Handles txtmname.Leave
        If txtmname.Text.Equals("") Then
            txtmname.Text = "(optional)"
            txtmname.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtmn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmn.KeyPress
        ' Check if the entered character is a digit and if the total characters are less than 11
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) OrElse txtmn.Text.Length >= 11 Then
            ' If not a digit or already 11 characters, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub txtstudid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstudid.KeyPress
        ' Check if the entered character is a digit
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            ' If not a digit, suppress the key press
            e.Handled = True
        End If
    End Sub
End Class
