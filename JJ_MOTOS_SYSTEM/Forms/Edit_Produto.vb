Imports System.Data
Imports System.Data.OleDb
Public Class Edit_Produto

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Edit_Produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cod_label.Text = My.Forms.Con_Produto.DTGcliente.CurrentRow.Cells(0).Value
        cod_barras.Text = My.Forms.Con_Produto.DTGcliente.CurrentRow.Cells(1).Value
        Desc_txt.Text = My.Forms.Con_Produto.DTGcliente.CurrentRow.Cells(2).Value
        marca_txt.Text = My.Forms.Con_Produto.DTGcliente.CurrentRow.Cells(3).Value
        modelo_txt.Text = My.Forms.Con_Produto.DTGcliente.CurrentRow.Cells(4).Value
        valor_custo.Text = My.Forms.Con_Produto.DTGcliente.CurrentRow.Cells(5).Value
        valor_venda.Text = My.Forms.Con_Produto.DTGcliente.CurrentRow.Cells(6).Value

    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Using con As OleDbConnection = GetConnection()
            Try
                Dim sql As String = "UPDATE produtos set cod_barras=@cod_barras,descrição=@descrição,marca=@marca,modelo=@modelo,custo=@custo,venda=@venda WHERE código = @código"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cod_barras", cod_barras.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@descrição", Desc_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@marca", marca_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@modelo", modelo_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@custo", valor_custo.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@venda", valor_venda.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@código", cod_label.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Cadastrado com sucesso !", MsgBoxStyle.Information, Title:="Cadastro")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
            End Try
        End Using
    End Sub
End Class