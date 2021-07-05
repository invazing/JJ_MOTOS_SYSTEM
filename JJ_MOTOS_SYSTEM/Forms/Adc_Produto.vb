Imports System.Data
Imports System.Data.OleDb
Public Class Adc_Produto
    Dim resultado, lucro, converter As Decimal
    Private Sub Calcular_Tick(sender As Object, e As EventArgs) Handles Calcular.Tick
        Try
            resultado = val_txb.Text * quant_txb.Text
            total_txb.Text = Format(resultado, "n2")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Código as REGISTRO,descrição as DESCRIÇÃO,marca as MARCA,custo as CUSTO from produtos WHERE descrição LIKE '%" + txb_consulta.Text + "%' OR marca LIKE '%" + txb_consulta.Text + "%'"
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
    Private Sub Adc_Produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT Código as REGISTRO,descrição as DESCRIÇÃO,marca as MARCA,custo as CUSTO from produtos WHERE descrição LIKE '%" + txb_consulta.Text + "%' OR marca LIKE '%" + txb_consulta.Text + "%'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Forms.Orçamento.DTGcliente.RowCount.ToString = 20 Then
            MsgBox("Lista cheia de produtos", MsgBoxStyle.Exclamation, Title:="Falha ao adicionar mais produtos")
        Else
            My.Forms.Orçamento.DTGcliente.Rows.Add(cod_txb.Text, desc_txb.Text, marca_txb.Text, val_txb.Text, quant_txb.Text, total_txb.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            cod_txb.Text = Me.DTGcliente.CurrentRow.Cells(0).Value
            desc_txb.Text = Me.DTGcliente.CurrentRow.Cells(1).Value
            marca_txb.Text = Me.DTGcliente.CurrentRow.Cells(2).Value
            custo.Text = Me.DTGcliente.CurrentRow.Cells(3).Value
            custo.Text = Format(Me.DTGcliente.CurrentRow.Cells(3).Value, "n2")

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        converter = custo.Text
        lucro = converter * 1.5
        lucro = Format(lucro, "n2")
        val_txb.Text = lucro
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        converter = custo.Text
        lucro = converter * 1.6
        lucro = Format(lucro, "n2")
       val_txb.Text = lucro
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        converter = custo.Text
        lucro = converter * 1.8
        lucro = Format(lucro, "n2")
       val_txb.Text = lucro
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        converter = custo.Text
        lucro = converter * 2.0
        lucro = Format(lucro, "n2")
       val_txb.Text = lucro
    End Sub

    Private Sub conexão_Tick(sender As Object, e As EventArgs) Handles conexão.Tick
        Try
            cod_txb.Text = Me.DTGcliente.CurrentRow.Cells(0).Value
            desc_txb.Text = Me.DTGcliente.CurrentRow.Cells(1).Value
            marca_txb.Text = Me.DTGcliente.CurrentRow.Cells(2).Value
            custo.Text = Me.DTGcliente.CurrentRow.Cells(3).Value
            custo.Text = Format(Me.DTGcliente.CurrentRow.Cells(3).Value, "n2")

        Catch ex As Exception
        End Try
    End Sub
End Class