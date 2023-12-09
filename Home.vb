Imports MySql.Data.MySqlClient

Public Class Home



    Private Sub Home_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub
End Class