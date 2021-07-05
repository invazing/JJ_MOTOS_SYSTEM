Imports System.Data
Imports System.Data.OleDb
Public Class Cad_Moto
    Dim val As Double
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Con_Cliente.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Form_Cliente.Tick
        Try
            cod_txb.Text = My.Forms.Con_Cliente.DTGcliente.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cod_txb.Text = "0" Then
            MsgBox("FAVOR VERIFICAR O CÓDIGO DO CLIENTE !", MsgBoxStyle.Critical, Title:="Cliente Inválido")
        Else
            Using con As OleDbConnection = GetConnection()
                Try
                    Dim sql As String = "INSERT INTO moto (cod_cliente,modelo,ano,placa) VALUES (@cod_cliente,@modelo,@ano,@placa)"
                    Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                    con.Open()
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@cod_cliente", cod_txb.Text))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@modelo", modelo_txb.Text))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@ano", ano_txb.Text))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@placa", placa_txb.Text))
                    cmd.ExecuteNonQuery()
                    MsgBox("Cadastrado com sucesso !", MsgBoxStyle.Information, Title:="Cadastro")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                End Try
            End Using
        End If
    End Sub

    Private Sub Cad_Moto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class