Imports System.Data
Imports System.Data.OleDb
Public Class Con_Moto
    Private Sub Con_Moto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT moto.Código as CÓDIGO,clientes.nome as CLIENTE,moto.modelo as MODELO,moto.ano as ANO,moto.placa as PLACA from moto inner join clientes on clientes.código = moto.cod_cliente WHERE modelo LIKE '%" + txb_consulta.Text + "%' OR ano LIKE '%" + txb_consulta.Text + "%' OR cod_cliente LIKE '%" + txb_consulta.Text + "%'OR moto.Código LIKE '%" + txb_consulta.Text + "%'OR clientes.nome LIKE '%" + txb_consulta.Text + "%'OR placa LIKE '%" + txb_consulta.Text + "%'"
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
                Dim sql As String = "SELECT moto.Código as CÓDIGO,clientes.nome as CLIENTE,moto.modelo as MODELO,moto.ano as ANO,moto.placa as PLACA from moto inner join clientes on clientes.código = moto.cod_cliente WHERE modelo LIKE '%" + txb_consulta.Text + "%' OR ano LIKE '%" + txb_consulta.Text + "%' OR cod_cliente LIKE '%" + txb_consulta.Text + "%'OR moto.Código LIKE '%" + txb_consulta.Text + "%'OR clientes.nome LIKE '%" + txb_consulta.Text + "%'OR placa LIKE '%" + txb_consulta.Text + "%'"
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
    Private Sub add_cliente_Click(sender As Object, e As EventArgs) Handles add_cliente.Click
        Cad_Moto.ShowDialog()
    End Sub
End Class