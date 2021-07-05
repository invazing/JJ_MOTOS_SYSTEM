<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orçamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orçamento))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cidade_txt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.celular_txt = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.telefone_txt = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.uf_txt = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cep_txt = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bairro_txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.num_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.end_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nascimento_txt = New System.Windows.Forms.MaskedTextBox()
        Me.rg_txt = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sexo_txt = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cpf_txt = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nome_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.KM_TXB = New System.Windows.Forms.TextBox()
        Me.placa_txb = New System.Windows.Forms.MaskedTextBox()
        Me.cod_txb = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ano_txb = New System.Windows.Forms.TextBox()
        Me.modelo_txb = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DTGcliente = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBS_TXB = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.Timer(Me.components)
        Me.Moto = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.labeltotal = New System.Windows.Forms.Label()
        Me.labelsubtotal = New System.Windows.Forms.Label()
        Me.labelmaodeobra = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label27 = New System.Windows.Forms.Label()
        Me.maodeobratextbox = New System.Windows.Forms.TextBox()
        Me.calculo = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DTGcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.email_txt)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cidade_txt)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.celular_txt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.telefone_txt)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.uf_txt)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cep_txt)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.bairro_txt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.num_txt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.end_txt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(690, 120)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contato"
        '
        'email_txt
        '
        Me.email_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.email_txt.Location = New System.Drawing.Point(354, 75)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.ReadOnly = True
        Me.email_txt.Size = New System.Drawing.Size(330, 20)
        Me.email_txt.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(351, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "E-mail"
        '
        'cidade_txt
        '
        Me.cidade_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cidade_txt.Location = New System.Drawing.Point(544, 36)
        Me.cidade_txt.Name = "cidade_txt"
        Me.cidade_txt.ReadOnly = True
        Me.cidade_txt.Size = New System.Drawing.Size(140, 20)
        Me.cidade_txt.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(541, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Cidade"
        '
        'celular_txt
        '
        Me.celular_txt.Location = New System.Drawing.Point(142, 75)
        Me.celular_txt.Mask = "(99) 99999 - 9999"
        Me.celular_txt.Name = "celular_txt"
        Me.celular_txt.ReadOnly = True
        Me.celular_txt.Size = New System.Drawing.Size(100, 20)
        Me.celular_txt.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(139, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Celular"
        '
        'telefone_txt
        '
        Me.telefone_txt.Location = New System.Drawing.Point(17, 75)
        Me.telefone_txt.Mask = "(99) 9999 - 9999"
        Me.telefone_txt.Name = "telefone_txt"
        Me.telefone_txt.ReadOnly = True
        Me.telefone_txt.Size = New System.Drawing.Size(100, 20)
        Me.telefone_txt.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Telefone"
        '
        'uf_txt
        '
        Me.uf_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.uf_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.uf_txt.FormattingEnabled = True
        Me.uf_txt.Items.AddRange(New Object() {"AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.uf_txt.Location = New System.Drawing.Point(460, 36)
        Me.uf_txt.Name = "uf_txt"
        Me.uf_txt.Size = New System.Drawing.Size(81, 21)
        Me.uf_txt.TabIndex = 8
        Me.uf_txt.Text = "SP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(457, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "UF"
        '
        'cep_txt
        '
        Me.cep_txt.Location = New System.Drawing.Point(248, 75)
        Me.cep_txt.Mask = "99,999-000"
        Me.cep_txt.Name = "cep_txt"
        Me.cep_txt.ReadOnly = True
        Me.cep_txt.Size = New System.Drawing.Size(100, 20)
        Me.cep_txt.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(245, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "CEP"
        '
        'bairro_txt
        '
        Me.bairro_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.bairro_txt.Location = New System.Drawing.Point(354, 36)
        Me.bairro_txt.Name = "bairro_txt"
        Me.bairro_txt.ReadOnly = True
        Me.bairro_txt.Size = New System.Drawing.Size(100, 20)
        Me.bairro_txt.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Bairro"
        '
        'num_txt
        '
        Me.num_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.num_txt.Location = New System.Drawing.Point(248, 36)
        Me.num_txt.Name = "num_txt"
        Me.num_txt.ReadOnly = True
        Me.num_txt.Size = New System.Drawing.Size(100, 20)
        Me.num_txt.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(245, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Número"
        '
        'end_txt
        '
        Me.end_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.end_txt.Location = New System.Drawing.Point(17, 36)
        Me.end_txt.Name = "end_txt"
        Me.end_txt.ReadOnly = True
        Me.end_txt.Size = New System.Drawing.Size(225, 20)
        Me.end_txt.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Endereço"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nascimento_txt)
        Me.GroupBox1.Controls.Add(Me.rg_txt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.sexo_txt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cpf_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nome_txt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 72)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do cliente"
        '
        'nascimento_txt
        '
        Me.nascimento_txt.Location = New System.Drawing.Point(587, 37)
        Me.nascimento_txt.Mask = "00/00/0000"
        Me.nascimento_txt.Name = "nascimento_txt"
        Me.nascimento_txt.ReadOnly = True
        Me.nascimento_txt.Size = New System.Drawing.Size(81, 20)
        Me.nascimento_txt.TabIndex = 4
        Me.nascimento_txt.ValidatingType = GetType(Date)
        '
        'rg_txt
        '
        Me.rg_txt.Location = New System.Drawing.Point(354, 36)
        Me.rg_txt.Mask = "99,999,999-9"
        Me.rg_txt.Name = "rg_txt"
        Me.rg_txt.ReadOnly = True
        Me.rg_txt.Size = New System.Drawing.Size(100, 20)
        Me.rg_txt.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(584, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nascimento"
        '
        'sexo_txt
        '
        Me.sexo_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sexo_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sexo_txt.FormattingEnabled = True
        Me.sexo_txt.Items.AddRange(New Object() {"MASCULINO", "FEMININO"})
        Me.sexo_txt.Location = New System.Drawing.Point(460, 36)
        Me.sexo_txt.Name = "sexo_txt"
        Me.sexo_txt.Size = New System.Drawing.Size(121, 21)
        Me.sexo_txt.TabIndex = 3
        Me.sexo_txt.Text = "MASCULINO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 9
        '
        'cpf_txt
        '
        Me.cpf_txt.Location = New System.Drawing.Point(248, 37)
        Me.cpf_txt.Mask = "999,999,999-99"
        Me.cpf_txt.Name = "cpf_txt"
        Me.cpf_txt.ReadOnly = True
        Me.cpf_txt.Size = New System.Drawing.Size(100, 20)
        Me.cpf_txt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CPF"
        '
        'nome_txt
        '
        Me.nome_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nome_txt.Location = New System.Drawing.Point(17, 37)
        Me.nome_txt.Name = "nome_txt"
        Me.nome_txt.ReadOnly = True
        Me.nome_txt.Size = New System.Drawing.Size(225, 20)
        Me.nome_txt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(718, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(81, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 26)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(6, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 26)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Moto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(291, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 17)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Pedido nº :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(365, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "0000"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.KM_TXB)
        Me.GroupBox3.Controls.Add(Me.placa_txb)
        Me.GroupBox3.Controls.Add(Me.cod_txb)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.ano_txb)
        Me.GroupBox3.Controls.Add(Me.modelo_txb)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 266)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 64)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dados da moto"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(356, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(23, 13)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "KM"
        '
        'KM_TXB
        '
        Me.KM_TXB.Location = New System.Drawing.Point(359, 33)
        Me.KM_TXB.Name = "KM_TXB"
        Me.KM_TXB.Size = New System.Drawing.Size(89, 20)
        Me.KM_TXB.TabIndex = 18
        '
        'placa_txb
        '
        Me.placa_txb.Location = New System.Drawing.Point(282, 33)
        Me.placa_txb.Mask = "AAA-0000"
        Me.placa_txb.Name = "placa_txb"
        Me.placa_txb.ReadOnly = True
        Me.placa_txb.Size = New System.Drawing.Size(71, 20)
        Me.placa_txb.TabIndex = 17
        '
        'cod_txb
        '
        Me.cod_txb.AutoSize = True
        Me.cod_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_txb.Location = New System.Drawing.Point(29, 34)
        Me.cod_txb.Name = "cod_txb"
        Me.cod_txb.Size = New System.Drawing.Size(16, 16)
        Me.cod_txb.TabIndex = 0
        Me.cod_txb.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(279, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Placa"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(173, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Ano"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(76, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Modelo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Cód. Cliente"
        '
        'ano_txb
        '
        Me.ano_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ano_txb.Location = New System.Drawing.Point(176, 33)
        Me.ano_txb.Name = "ano_txb"
        Me.ano_txb.ReadOnly = True
        Me.ano_txb.Size = New System.Drawing.Size(100, 20)
        Me.ano_txb.TabIndex = 2
        '
        'modelo_txb
        '
        Me.modelo_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.modelo_txb.Location = New System.Drawing.Point(76, 33)
        Me.modelo_txb.Name = "modelo_txb"
        Me.modelo_txb.ReadOnly = True
        Me.modelo_txb.Size = New System.Drawing.Size(94, 20)
        Me.modelo_txb.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(157, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 26)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Produto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DTGcliente
        '
        Me.DTGcliente.AllowUserToAddRows = False
        Me.DTGcliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTGcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DTGcliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DTGcliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DTGcliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DTGcliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.Descrição, Me.Marca, Me.Valor_Unit, Me.Quantidade, Me.Total})
        Me.DTGcliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.DTGcliente.GridColor = System.Drawing.Color.Blue
        Me.DTGcliente.Location = New System.Drawing.Point(12, 346)
        Me.DTGcliente.Name = "DTGcliente"
        Me.DTGcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGcliente.Size = New System.Drawing.Size(690, 148)
        Me.DTGcliente.TabIndex = 27
        '
        'Código
        '
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.Width = 65
        '
        'Descrição
        '
        Me.Descrição.HeaderText = "Descrição"
        Me.Descrição.Name = "Descrição"
        Me.Descrição.Width = 80
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.Width = 62
        '
        'Valor_Unit
        '
        Me.Valor_Unit.HeaderText = "Valor_Unit"
        Me.Valor_Unit.Name = "Valor_Unit"
        Me.Valor_Unit.Width = 81
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.Width = 87
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.Width = 56
        '
        'OBS_TXB
        '
        Me.OBS_TXB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OBS_TXB.Location = New System.Drawing.Point(12, 513)
        Me.OBS_TXB.Multiline = True
        Me.OBS_TXB.Name = "OBS_TXB"
        Me.OBS_TXB.Size = New System.Drawing.Size(690, 53)
        Me.OBS_TXB.TabIndex = 28
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 496)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Observações :"
        '
        'Cliente
        '
        Me.Cliente.Enabled = True
        '
        'Moto
        '
        Me.Moto.Enabled = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Location = New System.Drawing.Point(472, 266)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 64)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Adicionar"
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(629, 577)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 35)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Emitir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(550, 577)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(73, 35)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Salvar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 569)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(98, 19)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "SUB TOTAL :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(9, 584)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(123, 19)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "MÃO DE OBRA :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(9, 599)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 19)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "TOTAL :"
        '
        'labeltotal
        '
        Me.labeltotal.AutoSize = True
        Me.labeltotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotal.Location = New System.Drawing.Point(121, 599)
        Me.labeltotal.Name = "labeltotal"
        Me.labeltotal.Size = New System.Drawing.Size(45, 19)
        Me.labeltotal.TabIndex = 38
        Me.labeltotal.Text = "00,00"
        '
        'labelsubtotal
        '
        Me.labelsubtotal.AutoSize = True
        Me.labelsubtotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelsubtotal.Location = New System.Drawing.Point(121, 569)
        Me.labelsubtotal.Name = "labelsubtotal"
        Me.labelsubtotal.Size = New System.Drawing.Size(45, 19)
        Me.labelsubtotal.TabIndex = 39
        Me.labelsubtotal.Text = "00,00"
        '
        'labelmaodeobra
        '
        Me.labelmaodeobra.AutoSize = True
        Me.labelmaodeobra.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelmaodeobra.Location = New System.Drawing.Point(121, 584)
        Me.labelmaodeobra.Name = "labelmaodeobra"
        Me.labelmaodeobra.Size = New System.Drawing.Size(45, 19)
        Me.labelmaodeobra.TabIndex = 37
        Me.labelmaodeobra.Text = "00,00"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(345, 587)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(103, 15)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "MÃO DE OBRA :"
        '
        'maodeobratextbox
        '
        Me.maodeobratextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.maodeobratextbox.Location = New System.Drawing.Point(454, 585)
        Me.maodeobratextbox.Name = "maodeobratextbox"
        Me.maodeobratextbox.Size = New System.Drawing.Size(81, 20)
        Me.maodeobratextbox.TabIndex = 41
        Me.maodeobratextbox.Text = "00,00"
        '
        'calculo
        '
        Me.calculo.Enabled = True
        Me.calculo.Interval = 1000
        '
        'Orçamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 619)
        Me.Controls.Add(Me.maodeobratextbox)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.labelsubtotal)
        Me.Controls.Add(Me.labeltotal)
        Me.Controls.Add(Me.labelmaodeobra)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.OBS_TXB)
        Me.Controls.Add(Me.DTGcliente)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Orçamento"
        Me.Text = "ORÇAMENTO CADASTRO"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DTGcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents email_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cidade_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents celular_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents telefone_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents uf_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cep_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bairro_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents num_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents end_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nascimento_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rg_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sexo_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cpf_txt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nome_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents KM_TXB As System.Windows.Forms.TextBox
    Friend WithEvents placa_txb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cod_txb As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ano_txb As System.Windows.Forms.TextBox
    Friend WithEvents modelo_txb As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DTGcliente As System.Windows.Forms.DataGridView
    Friend WithEvents OBS_TXB As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Cliente As System.Windows.Forms.Timer
    Friend WithEvents Moto As System.Windows.Forms.Timer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents labeltotal As System.Windows.Forms.Label
    Friend WithEvents labelsubtotal As System.Windows.Forms.Label
    Friend WithEvents labelmaodeobra As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents maodeobratextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents calculo As System.Windows.Forms.Timer
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descrição As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
