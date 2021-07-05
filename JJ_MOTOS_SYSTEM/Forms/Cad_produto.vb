Imports System.Data
Imports System.Data.OleDb
Public Class Cad_produto
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using con As OleDbConnection = GetConnection()
            Try
                Dim sql As String = "INSERT INTO produtos (cod_barras,descrição,marca,modelo,custo,venda) VALUES (@cod_barras,@descrição,@marca,@modelo,@custo,@venda)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cod_barras", cod_barras.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@descrição", Desc_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@marca", marca_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@modelo", modelo_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@custo", valor_custo.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@venda", valor_venda.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Cadastrado com sucesso !", MsgBoxStyle.Information, Title:="Cadastro")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
            End Try
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub val_unit_txt_TextChanged(sender As Object, e As EventArgs) Handles valor_venda.TextChanged

    End Sub
End Class