Imports System.Data
Imports System.Data.OleDb
Public Class Con_Produto

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Código as REGISTRO,cod_barras as COD_BARRA,descrição as DESCRIÇÃO,marca as MARCA,modelo as MODELO,custo as CUSTO,venda as VENDA from produtos WHERE descrição LIKE '%" + txb_consulta.Text + "%' OR marca LIKE '%" + txb_consulta.Text + "%' OR modelo LIKE '%" + txb_consulta.Text + "%' OR venda LIKE '%" + txb_consulta.Text + "%'OR cod_barras LIKE '%" + txb_consulta.Text + "%'"
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

    Private Sub Con_Produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Código as REGISTRO,cod_barras as COD_BARRA,descrição as DESCRIÇÃO,marca as MARCA,modelo as MODELO,custo as CUSTO,venda as VENDA from produtos WHERE descrição LIKE '%" + txb_consulta.Text + "%' OR marca LIKE '%" + txb_consulta.Text + "%' OR modelo LIKE '%" + txb_consulta.Text + "%' OR venda LIKE '%" + txb_consulta.Text + "%'OR cod_barras LIKE '%" + txb_consulta.Text + "%'"
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Edit_Produto.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As MsgBoxResult
        resultado = MsgBox("TEM CERTEZA QUE DESEJA EXCLUIR ESSE CADASTRO" + vbCrLf + "NÃO É POSSIVEL REVERTER ESSA AÇÃO", vbYesNo, Title:="ATENÇÃO")
        If resultado = vbYes Then
            Using con As OleDbConnection = GetConnection()
                Try
                    con.Open()
                    Dim sql As String = "DELETE * FROM produtos WHERE Código=@Código"
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

    Private Sub add_cliente_Click(sender As Object, e As EventArgs) Handles add_cliente.Click
        Cad_produto.ShowDialog()
    End Sub
End Class