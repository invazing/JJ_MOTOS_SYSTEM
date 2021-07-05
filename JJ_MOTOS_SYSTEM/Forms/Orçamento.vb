Public Class Orçamento
    Inherits System.Windows.Forms.Form
    Dim format1 As New StringFormat(StringFormatFlags.NoClip)
    Dim format2 As New StringFormat(format1)
    Dim totalsub, totalparapagar, maodeobra, valor As Decimal
    Dim contador As New Integer

    Dim val1, val2, val3, val4, val5, val6, val7, val8, val9, val10, val11, val12, val13, val14, val15, val16, val17, val18, val19, val20 As Decimal
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
#Region "Private members"
    Private GridPrinter As DataGridPrinter
#End Region

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Cliente.Tick
        Try
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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con_Cliente.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Con_Moto.ShowDialog()
    End Sub
    Private Sub Moto_Tick(sender As Object, e As EventArgs) Handles Moto.Tick
        Try
            cod_txb.Text = My.Forms.Con_Moto.DTGcliente.CurrentRow.Cells(0).Value
            modelo_txb.Text = My.Forms.Con_Moto.DTGcliente.CurrentRow.Cells(2).Value
            ano_txb.Text = My.Forms.Con_Moto.DTGcliente.CurrentRow.Cells(3).Value
            placa_txb.Text = My.Forms.Con_Moto.DTGcliente.CurrentRow.Cells(4).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Adc_Produto.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Logo
        e.Graphics.DrawImage(My.Resources.Logo, 100, 40)
        Dim blackPen As New Pen(Color.Black, 0.5)
        'Titulo
        e.Graphics.DrawString("ORÇAMENTO", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 370, 15)
        'Margem
        e.Graphics.DrawLine(blackPen, 10, 10, 815, 10)
        e.Graphics.DrawLine(blackPen, 10, 30, 815, 30)
        e.Graphics.DrawLine(blackPen, 10, 10, 10, 1150)
        e.Graphics.DrawLine(blackPen, 815, 10, 815, 1150)
        e.Graphics.DrawLine(blackPen, 10, 1150, 815, 1150)
        e.Graphics.DrawLine(blackPen, 10, 120, 815, 120)
        e.Graphics.DrawLine(blackPen, 10, 250, 815, 250)
        e.Graphics.DrawLine(blackPen, 50, 1100, 250, 1100) 'ass cliente
        e.Graphics.DrawLine(blackPen, 570, 1100, 770, 1100) 'ass funcionario
        'dados
        e.Graphics.DrawString("JJ MOTOS " + "Peças e Serviços em Geral" + vbCrLf + "Fone : 15 98170 - 2011" + vbCrLf + "Rua Lauro Sodré, 311 - C3 - Centro" + vbCrLf + "CEP : 18.460-000 Itararé-SP", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 400, 40)
        'dados clientes
        e.Graphics.DrawString("Nome : " + nome_txt.Text + vbCrLf + "CPF : " + cpf_txt.Text + vbCrLf + "RG : " + rg_txt.Text + vbCrLf + "Sexo : " + sexo_txt.Text + vbCrLf + "Nascimento : " + nascimento_txt.Text + vbCrLf + "Moto : " + modelo_txb.Text + " - " + ano_txb.Text + vbCrLf + "Placa : " + placa_txb.Text + "   /   " + "KM : " + KM_TXB.Text, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 20, 130)
        e.Graphics.DrawString("Endereço : " + end_txt.Text + vbCrLf + "Número : " + num_txt.Text + " - Bairro : " + bairro_txt.Text + vbCrLf + "UF : " + uf_txt.Text + vbCrLf + "Cidade : " + cidade_txt.Text + " - CEP : " + cep_txt.Text + vbCrLf + "Telefone : " + telefone_txt.Text + vbCrLf + "Celular : " + celular_txt.Text + vbCrLf + "Email :" + email_txt.Text, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 400, 130)
        e.Graphics.DrawString(nome_txt.Text, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 50, 1105)
        e.Graphics.DrawString("IVAIR JUNIOR", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 1105)

        e.Graphics.DrawLine(blackPen, 20, 310, 800, 310)  ' Tabela3
        e.Graphics.DrawLine(blackPen, 20, 340, 800, 340)  ' Tabela4
        e.Graphics.DrawLine(blackPen, 20, 370, 800, 370)  ' Tabela5
        e.Graphics.DrawLine(blackPen, 20, 400, 800, 400)  ' Tabela6
        e.Graphics.DrawLine(blackPen, 20, 430, 800, 430)  ' Tabela7
        e.Graphics.DrawLine(blackPen, 20, 460, 800, 460)  ' Tabela8
        e.Graphics.DrawLine(blackPen, 20, 490, 800, 490)  ' Tabela9
        e.Graphics.DrawLine(blackPen, 20, 520, 800, 520)  ' Tabela10
        e.Graphics.DrawLine(blackPen, 20, 550, 800, 550)  ' Tabela11
        e.Graphics.DrawLine(blackPen, 20, 580, 800, 580)  ' Tabela12
        e.Graphics.DrawLine(blackPen, 20, 610, 800, 610)  ' Tabela13
        e.Graphics.DrawLine(blackPen, 20, 640, 800, 640)  ' Tabela14
        e.Graphics.DrawLine(blackPen, 20, 670, 800, 670)  ' Tabela15
        e.Graphics.DrawLine(blackPen, 20, 700, 800, 700)  ' Tabela16
        e.Graphics.DrawLine(blackPen, 20, 730, 800, 730)  ' Tabela17
        e.Graphics.DrawLine(blackPen, 20, 760, 800, 760)  ' Tabela18
        e.Graphics.DrawLine(blackPen, 20, 790, 800, 790)  ' Tabela19
        e.Graphics.DrawLine(blackPen, 20, 820, 800, 820)  ' Tabela20
        e.Graphics.DrawLine(blackPen, 20, 850, 800, 850)  ' Tabela20
        e.Graphics.DrawLine(blackPen, 800, 850, 800, 280) ' Tabela CIMA 1
        e.Graphics.DrawLine(blackPen, 20, 280, 20, 850)   ' Tabela CIMA 2
        e.Graphics.DrawLine(blackPen, 20, 280, 800, 280)  ' Tabela2
        e.Graphics.DrawLine(blackPen, 130, 280, 130, 850) ' Tabela CIMA M 1
        e.Graphics.DrawLine(blackPen, 620, 280, 620, 850) ' Tabela CIMA M 2
        e.Graphics.DrawLine(blackPen, 690, 280, 690, 850) ' Tabela CIMA M 3
        e.Graphics.DrawLine(blackPen, 730, 280, 730, 850) ' Tabela CIMA M 2
        e.Graphics.DrawRectangle(blackPen, 20, 890, 780, 80) ' obs
        'tabela de codigo
        ' MsgBox(DTGcliente.RowCount.ToString)
        e.Graphics.DrawString("CÓDIGO", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 20, 255) 'codigo
        e.Graphics.DrawString("DESCRIÇÃO", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 255) 'descrição
        e.Graphics.DrawString("VLR. UNIT", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 255) 'quantidade
        e.Graphics.DrawString("QTD", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 255) 'valor
        e.Graphics.DrawString("VLR. TOTAL", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 255) 'total
        e.Graphics.DrawString("Observações", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 370, 870) 'codigo
        e.Graphics.DrawString(OBS_TXB.Text, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 20, 895) '

    
        format1.LineAlignment = StringAlignment.Near
        format1.Alignment = StringAlignment.Center
        format2.LineAlignment = StringAlignment.Center
        format2.Alignment = StringAlignment.Far
        e.Graphics.DrawString("SUB TOTAL R$ :" + labelsubtotal.Text, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 800, 990, format2)
        e.Graphics.DrawString("MÃO DE OBRA R$ :" + labelmaodeobra.Text, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 800, 1010, format2)
        e.Graphics.DrawString("TOTAL R$ :" + labeltotal.Text, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 800, 1030, format2)
        If DTGcliente.RowCount.ToString >= 1 Then
            e.Graphics.DrawString(DTGcliente.Rows(0).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 285) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(0).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 285) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(0).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 285) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(0).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 285) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(0).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 285) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 2 Then
            e.Graphics.DrawString(DTGcliente.Rows(1).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 315) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(1).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 315) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(1).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 315) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(1).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 315) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(1).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 315) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 3 Then
            e.Graphics.DrawString(DTGcliente.Rows(2).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 345) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(2).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 345) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(2).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 345) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(2).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 345) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(2).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 345) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 4 Then
            e.Graphics.DrawString(DTGcliente.Rows(3).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 375) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(3).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 375) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(3).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 375) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(3).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 375) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(3).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 375) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 5 Then
            e.Graphics.DrawString(DTGcliente.Rows(4).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 405) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(4).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 405) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(4).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 405) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(4).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 405) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(4).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 405) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 6 Then
            e.Graphics.DrawString(DTGcliente.Rows(5).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 435) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(5).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 435) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(5).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 435) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(5).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 435) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(5).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 435) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 7 Then
            e.Graphics.DrawString(DTGcliente.Rows(6).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 465) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(6).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 465) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(6).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 465) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(6).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 465) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(6).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 465) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 8 Then
            e.Graphics.DrawString(DTGcliente.Rows(7).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 495) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(7).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 495) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(7).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 495) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(7).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 495) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(7).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 495) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 9 Then
            e.Graphics.DrawString(DTGcliente.Rows(8).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 525) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(8).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 525) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(8).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 525) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(8).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 525) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(8).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 525) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 10 Then
            e.Graphics.DrawString(DTGcliente.Rows(9).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 555) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(9).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 555) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(9).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 555) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(9).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 555) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(9).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 555) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 11 Then
            e.Graphics.DrawString(DTGcliente.Rows(10).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 585) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(10).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 585) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(10).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 585) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(10).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 585) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(10).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 585) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 12 Then
            e.Graphics.DrawString(DTGcliente.Rows(11).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 615) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(11).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 615) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(11).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 615) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(11).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 615) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(11).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 615) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 13 Then
            e.Graphics.DrawString(DTGcliente.Rows(12).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 645) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(12).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 645) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(12).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 645) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(12).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 645) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(12).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 645) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 14 Then
            e.Graphics.DrawString(DTGcliente.Rows(13).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 675) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(13).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 675) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(13).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 675) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(13).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 675) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(13).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 675) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 15 Then
            e.Graphics.DrawString(DTGcliente.Rows(14).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 705) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(14).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 705) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(14).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 705) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(14).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 705) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(14).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 705) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 16 Then
            e.Graphics.DrawString(DTGcliente.Rows(15).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 735) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(15).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 735) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(15).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 735) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(15).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 735) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(15).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 735) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 17 Then
            e.Graphics.DrawString(DTGcliente.Rows(16).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 765) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(16).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 765) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(16).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 765) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(16).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 765) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(16).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 765) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 18 Then
            e.Graphics.DrawString(DTGcliente.Rows(17).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 795) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(17).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 795) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(17).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 795) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(17).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 795) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(17).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 795) 'total 
        End If
        If DTGcliente.RowCount.ToString >= 19 Then
            e.Graphics.DrawString(DTGcliente.Rows(18).Cells(0).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 25, 825) 'codigo
            e.Graphics.DrawString(DTGcliente.Rows(18).Cells(1).Value.ToString() + " - " + DTGcliente.Rows(0).Cells(2).Value.ToString() + " - ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 130, 825) 'descrição
            e.Graphics.DrawString(DTGcliente.Rows(18).Cells(3).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 620, 825) 'quantidade
            e.Graphics.DrawString(DTGcliente.Rows(18).Cells(4).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 690, 825) 'valor
            e.Graphics.DrawString(DTGcliente.Rows(18).Cells(5).Value.ToString(), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 730, 825) 'total 
        End If

    End Sub
    Private Sub calculo_Tick(sender As Object, e As EventArgs) Handles calculo.Tick
        ' pegando valor 1
        If DTGcliente.RowCount.ToString >= 1 Then
            val1 = DTGcliente.Rows(0).Cells("Total").Value.ToString()
        Else
            val1 = 0
        End If
        ' pegando valor 2
        If DTGcliente.RowCount.ToString >= 2 Then
            DTGcliente.Rows(1).Cells("Total").Value.ToString()
            val2 = DTGcliente.Rows(1).Cells("Total").Value.ToString()
        Else
            val2 = 0
        End If
        ' pegando valor 3
        If DTGcliente.RowCount.ToString >= 3 Then
            DTGcliente.Rows(2).Cells("Total").Value.ToString()
            val3 = DTGcliente.Rows(2).Cells("Total").Value.ToString()
        Else
            val3 = 0
        End If
        ' pegando valor 4
        If DTGcliente.RowCount.ToString >= 4 Then
            DTGcliente.Rows(3).Cells("Total").Value.ToString()
            val4 = DTGcliente.Rows(3).Cells("Total").Value.ToString()
        Else
            val4 = 0
        End If
        ' pegando valor 5
        If DTGcliente.RowCount.ToString >= 5 Then
            DTGcliente.Rows(4).Cells("Total").Value.ToString()
            val5 = DTGcliente.Rows(4).Cells("Total").Value.ToString()
        Else
            val5 = 0
        End If
        ' pegando valor 6
        If DTGcliente.RowCount.ToString >= 6 Then
            DTGcliente.Rows(5).Cells("Total").Value.ToString()
            val6 = DTGcliente.Rows(5).Cells("Total").Value.ToString()
        Else
            val6 = 0
        End If
        ' pegando valor 7
        If DTGcliente.RowCount.ToString >= 7 Then
            DTGcliente.Rows(6).Cells("Total").Value.ToString()
            val7 = DTGcliente.Rows(6).Cells("Total").Value.ToString()
        Else
            val7 = 0
        End If
        ' pegando valor 8
        If DTGcliente.RowCount.ToString >= 8 Then
            DTGcliente.Rows(7).Cells("Total").Value.ToString()
            val8 = DTGcliente.Rows(7).Cells("Total").Value.ToString()
        Else
            val8 = 0
        End If
        ' pegando valor 9
        If DTGcliente.RowCount.ToString >= 9 Then
            DTGcliente.Rows(8).Cells("Total").Value.ToString()
            val9 = DTGcliente.Rows(8).Cells("Total").Value.ToString()
        Else
            val9 = 0
        End If
        ' pegando valor 10
        If DTGcliente.RowCount.ToString >= 10 Then
            DTGcliente.Rows(9).Cells("Total").Value.ToString()
            val10 = DTGcliente.Rows(9).Cells("Total").Value.ToString()
        Else
            val10 = 0
        End If
        ' pegando valor 11
        If DTGcliente.RowCount.ToString >= 11 Then
            DTGcliente.Rows(10).Cells("Total").Value.ToString()
            val11 = DTGcliente.Rows(10).Cells("Total").Value.ToString()
        Else
            val11 = 0
        End If
        ' pegando valor 12
        If DTGcliente.RowCount.ToString >= 12 Then
            DTGcliente.Rows(11).Cells("Total").Value.ToString()
            val12 = DTGcliente.Rows(11).Cells("Total").Value.ToString()
        Else
            val12 = 0
        End If
        ' pegando valor 13
        If DTGcliente.RowCount.ToString >= 13 Then
            DTGcliente.Rows(12).Cells("Total").Value.ToString()
            val13 = DTGcliente.Rows(12).Cells("Total").Value.ToString()
        Else
            val13 = 0
        End If
        ' pegando valor 14
        If DTGcliente.RowCount.ToString >= 14 Then
            DTGcliente.Rows(13).Cells("Total").Value.ToString()
            val14 = DTGcliente.Rows(13).Cells("Total").Value.ToString()
        Else
            val14 = 0
        End If
        ' pegando valor 15
        If DTGcliente.RowCount.ToString >= 15 Then
            DTGcliente.Rows(14).Cells("Total").Value.ToString()
            val15 = DTGcliente.Rows(14).Cells("Total").Value.ToString()
        Else
            val15 = 0
        End If
        ' pegando valor 16
        If DTGcliente.RowCount.ToString >= 16 Then
            DTGcliente.Rows(15).Cells("Total").Value.ToString()
            val16 = DTGcliente.Rows(15).Cells("Total").Value.ToString()
        Else
            val16 = 0
        End If
        ' pegando valor 17
        If DTGcliente.RowCount.ToString >= 17 Then
            DTGcliente.Rows(16).Cells("Total").Value.ToString()
            val17 = DTGcliente.Rows(16).Cells("Total").Value.ToString()
        Else
            val17 = 0
        End If
        ' pegando valor 18
        If DTGcliente.RowCount.ToString >= 18 Then
            DTGcliente.Rows(17).Cells("Total").Value.ToString()
            val18 = DTGcliente.Rows(17).Cells("Total").Value.ToString()
        Else
            val18 = 0
        End If
        ' pegando valor 19
        If DTGcliente.RowCount.ToString >= 19 Then
            DTGcliente.Rows(18).Cells("Total").Value.ToString()
            val19 = DTGcliente.Rows(18).Cells("Total").Value.ToString()
        Else
            val19 = 0
        End If
        ' pegando valor 20
        If DTGcliente.RowCount.ToString >= 20 Then
            DTGcliente.Rows(19).Cells("Total").Value.ToString()
            val20 = DTGcliente.Rows(19).Cells("Total").Value.ToString()
        Else
            val20 = 0
        End If
        totalsub = val1 + val2 + val3 + val4 + val5 + val6 + val7 + val8 + val9 + val10 + val11 + val12 + val13 + val14 + val15 + val16 + val17 + val18 + val19 + val20
        labelsubtotal.Text = totalsub
        maodeobra = maodeobratextbox.Text
        labelmaodeobra.Text = maodeobratextbox.Text
        totalparapagar = totalsub + maodeobra
        labeltotal.Text = totalparapagar

    End Sub
End Class