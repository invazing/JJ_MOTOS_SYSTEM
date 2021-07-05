Imports System.Data
Imports System.Data.OleDb
Module Modulo

    Public Function GetConnection() As OleDbConnection
        Dim sql As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Database.accdb"
        Return New OleDbConnection(sql)
    End Function
End Module