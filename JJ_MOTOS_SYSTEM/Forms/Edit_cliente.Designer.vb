<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_cliente))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cod_txb = New System.Windows.Forms.Label()
        Me.cod_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(528, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 43)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "&Salvar Edição"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(618, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cod_txb
        '
        Me.cod_txb.AutoSize = True
        Me.cod_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_txb.Location = New System.Drawing.Point(257, 61)
        Me.cod_txb.Name = "cod_txb"
        Me.cod_txb.Size = New System.Drawing.Size(129, 18)
        Me.cod_txb.TabIndex = 15
        Me.cod_txb.Text = "Código Cliente :"
        '
        'cod_label
        '
        Me.cod_label.AutoSize = True
        Me.cod_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_label.Location = New System.Drawing.Point(392, 61)
        Me.cod_label.Name = "cod_label"
        Me.cod_label.Size = New System.Drawing.Size(35, 18)
        Me.cod_label.TabIndex = 22
        Me.cod_label.Text = "000"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(719, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(9, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(690, 120)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contato"
        '
        'email_txt
        '
        Me.email_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.email_txt.Location = New System.Drawing.Point(354, 75)
        Me.email_txt.Name = "email_txt"
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 72)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do cliente"
        '
        'nascimento_txt
        '
        Me.nascimento_txt.Location = New System.Drawing.Point(587, 37)
        Me.nascimento_txt.Mask = "00/00/0000"
        Me.nascimento_txt.Name = "nascimento_txt"
        Me.nascimento_txt.Size = New System.Drawing.Size(81, 20)
        Me.nascimento_txt.TabIndex = 4
        Me.nascimento_txt.ValidatingType = GetType(Date)
        '
        'rg_txt
        '
        Me.rg_txt.Location = New System.Drawing.Point(354, 36)
        Me.rg_txt.Mask = "99,999,999-9"
        Me.rg_txt.Name = "rg_txt"
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
        'Edit_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 327)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cod_label)
        Me.Controls.Add(Me.cod_txb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Edit_cliente"
        Me.Text = "EDITAR CADASTRO DE CLIENTE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cod_txb As System.Windows.Forms.Label
    Friend WithEvents cod_label As System.Windows.Forms.Label
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
End Class
