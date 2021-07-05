Imports System.Data
Imports System.Data.OleDb
Public Class Con_Cliente





    Private Sub Con_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * from clientes WHERE nome LIKE '%" + txb_consulta.Text + "%' OR cpf LIKE '%" + txb_consulta.Text + "%' OR rg LIKE '%" + txb_consulta.Text + "%' OR celular LIKE '%" + txb_consulta.Text + "%'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DTGcliente.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * from clientes WHERE nome LIKE '%" + txb_consulta.Text + "%' OR cpf LIKE '%" + txb_consulta.Text + "%' OR rg LIKE '%" + txb_consulta.Text + "%' OR celular LIKE '%" + txb_consulta.Text + "%'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                DTGcliente.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(Me.DTGcliente.CurrentRow.Cells(0).Value.Text())
    End Sub

    Private Sub add_cliente_Click(sender As Object, e As EventArgs) Handles add_cliente.Click
        Cad_Cliente.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Edit_cliente.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("TEM CERTEZA QUE DESEJA EXCLUIR ESSE CADASTRO" + vbCrLf + "NÃO É POSSIVEL REVERTER ESSA AÇÃO", vbYesNo, Title:="ATENÇÃO")
        If resultado = vbYes Then
            Using con As OleDbConnection = GetConnection()
                Try
                    con.Open()
                    Dim sql As String = "DELETE * FROM clientes WHERE Código=@Código"
                    Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@Código", Me.DTGcliente.CurrentRow.Cells(0).Value))
                    cmd.ExecuteNonQuery()
                    MsgBox("CADASTRO EXCLUIDO", MsgBoxStyle.Information, Title:="EXCLUIDO")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            End Using
        Else
            MsgBox("CANCELADO", MsgBoxStyle.Information, Title:="NÃO EXCLUIDO")
        End If
    End Sub
End Class