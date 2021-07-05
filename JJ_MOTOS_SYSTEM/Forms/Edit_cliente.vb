Imports System.Data
Imports System.Data.OleDb

Public Class Edit_cliente

    Private Sub Edit_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cod_label.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(0).Value
        nome_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(1).Value
        cpf_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(2).Value
        rg_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(3).Value
        sexo_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(4).Value
        nascimento_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(5).Value
        end_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(6).Value
        num_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(7).Value
        bairro_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(8).Value
        uf_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(9).Value
        cidade_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(10).Value
        telefone_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(11).Value
        celular_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(12).Value
        cep_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(13).Value
        email_txt.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(14).Value




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using con As OleDbConnection = GetConnection()
            Try
                Dim sql As String = "UPDATE clientes SET nome= @nome,cpf= @cpf,rg= @rg,sexo= @sexo,nascimento= @nascimento,endereço= @endereço,numero= @numero,bairro= @bairro,uf= @uf,cidade= @cidade,telefone= @telefone,celular= @celular,cep= @cep,email= @email WHERE código = @código"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.Add(New OleDb.OleDbParameter("@nome", nome_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cpf", cpf_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@rg", rg_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@sexo", sexo_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@nascimento", nascimento_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@endereço", end_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@numero", num_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@bairro", bairro_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@uf", uf_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cidade", cidade_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@telefone", telefone_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@celular", celular_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cep", cep_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@email", email_txt.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@código", cod_label.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Cadastrado com sucesso !", MsgBoxStyle.Information, Title:="Cadastro")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                nome_txt.Text = ""
                cpf_txt.Text = ""
                rg_txt.Text = ""
                sexo_txt.Text = ""
                nascimento_txt.Text = ""
                end_txt.Text = ""
                num_txt.Text = ""
                bairro_txt.Text = ""
                uf_txt.Text = ""
                cidade_txt.Text = ""
                telefone_txt.Text = ""
                celular_txt.Text = ""
                cep_txt.Text = ""
                email_txt.Text = ""
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class