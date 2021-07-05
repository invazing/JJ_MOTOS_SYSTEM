Imports System.Data
Imports System.Data.OleDb
Public Class Cad_Cliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using con As OleDbConnection = GetConnection()
            Try
                Dim sql As String = "INSERT INTO Clientes (nome,cpf,rg,sexo,nascimento,endereço,numero,bairro,uf,cidade,telefone,celular,cep,email) VALUES (@nome,@cpf,@rg,@sexo,@nascimento,@endereço,@numero,@bairro,@uf,@cidade,@telefone,@celular,@cep,@email)"
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
                cmd.ExecuteNonQuery()
                MsgBox("Cadastrado com sucesso !", MsgBoxStyle.Information, Title:="Cadastro")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                nome_txt.Text = ""
                cpf_txt.Text = ""
                rg_txt.Text = ""
                nascimento_txt.Text = ""
                end_txt.Text = ""
                num_txt.Text = ""
                bairro_txt.Text = ""
                cidade_txt.Text = ""
                telefone_txt.Text = ""
                celular_txt.Text = ""
                cep_txt.Text = ""
                email_txt.Text = ""
            End Try
        End Using
    End Sub
End Class