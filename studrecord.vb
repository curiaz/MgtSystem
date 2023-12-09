Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class studrecord
    Dim connectionString As String = "server=localhost; user id=root; password=; database=dbstudentmng"


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StudentEntry.Show()

    End Sub

    Private Sub studrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        loadrecord()

    End Sub

    Private Sub dtstud_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtstud.CellContentClick

    End Sub

    Sub loadrecord()
        Dim i As Integer = 0
        cn.Open()
        cm = New MySqlCommand("select * from tbleinfo", cn)
        dtstud.Rows.Clear()
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            dtstud.Rows.Add(i, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString, dr.Item(4).ToString, dr.Item(5).ToString, dr.Item(6).ToString, dr.Item(7).ToString, dr.Item(8).ToString, dr.Item(9).ToString, dr.Item(10).ToString, dr.Item(11).ToString)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()

    End Sub

    Private Sub RefreshData()
        dtstud.Rows.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM tbleinfo"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim row As String() = {reader("id").ToString(), reader("studentID").ToString(), reader("lastname").ToString(), reader("firstname").ToString(), reader("middlename").ToString(), reader("birthday").ToString(), reader("gender").ToString(), reader("year").ToString(), reader("section").ToString(), reader("program").ToString(), reader("email").ToString(), reader("address").ToString()}

                        ' Use Rows.Add() to add a new row to the DataTable
                        dtstud.Rows.Add(row)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class