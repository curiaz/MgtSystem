Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Module Module1
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader

    Sub connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server=localhost; user id=root; password=; database=dbstudentmng"
        End With
    End Sub

End Module
