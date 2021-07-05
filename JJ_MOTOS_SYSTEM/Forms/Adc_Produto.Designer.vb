<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adc_Produto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adc_Produto))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txb_consulta = New System.Windows.Forms.TextBox()
        Me.DTGcliente = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.desc_txb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.marca_txb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.val_txb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.quant_txb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.total_txb = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Calcular = New System.Windows.Forms.Timer(Me.components)
        Me.conexão = New System.Windows.Forms.Timer(Me.components)
        Me.cod_txb = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.custo = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.DTGcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(491, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 35)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txb_consulta
        '
        Me.txb_consulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_consulta.Location = New System.Drawing.Point(12, 7)
        Me.txb_consulta.Name = "txb_consulta"
        Me.txb_consulta.Size = New System.Drawing.Size(473, 35)
        Me.txb_consulta.TabIndex = 25
        '
        'DTGcliente
        '
        Me.DTGcliente.AllowUserToAddRows = False
        Me.DTGcliente.AllowUserToDeleteRows = False
        Me.DTGcliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTGcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DTGcliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DTGcliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DTGcliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DTGcliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.DTGcliente.GridColor = System.Drawing.Color.Blue
        Me.DTGcliente.Location = New System.Drawing.Point(0, 53)
        Me.DTGcliente.Name = "DTGcliente"
        Me.DTGcliente.ReadOnly = True
        Me.DTGcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGcliente.Size = New System.Drawing.Size(646, 393)
        Me.DTGcliente.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'desc_txb
        '
        Me.desc_txb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.desc_txb.Location = New System.Drawing.Point(655, 112)
        Me.desc_txb.Name = "desc_txb"
        Me.desc_txb.Size = New System.Drawing.Size(128, 20)
        Me.desc_txb.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(652, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Descrição :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(652, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Marca :"
        '
        'marca_txb
        '
        Me.marca_txb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.marca_txb.Location = New System.Drawing.Point(655, 151)
        Me.marca_txb.Name = "marca_txb"
        Me.marca_txb.Size = New System.Drawing.Size(128, 20)
        Me.marca_txb.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(652, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Venda"
        '
        'val_txb
        '
        Me.val_txb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.val_txb.Location = New System.Drawing.Point(655, 190)
        Me.val_txb.Name = "val_txb"
        Me.val_txb.Size = New System.Drawing.Size(128, 20)
        Me.val_txb.TabIndex = 33
        Me.val_txb.Text = "00,00"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(653, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Quantidade :"
        '
        'quant_txb
        '
        Me.quant_txb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.quant_txb.Location = New System.Drawing.Point(720, 230)
        Me.quant_txb.Name = "quant_txb"
        Me.quant_txb.Size = New System.Drawing.Size(64, 20)
        Me.quant_txb.TabIndex = 35
        Me.quant_txb.Text = "1"
        Me.quant_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(652, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Total : "
        '
        'total_txb
        '
        Me.total_txb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.total_txb.AutoSize = True
        Me.total_txb.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_txb.Location = New System.Drawing.Point(715, 246)
        Me.total_txb.Name = "total_txb"
        Me.total_txb.Size = New System.Drawing.Size(75, 24)
        Me.total_txb.TabIndex = 39
        Me.total_txb.Text = "0000,00"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(664, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 33)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Adicionar ao pedido"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Enabled = True
        '
        'conexão
        '
        Me.conexão.Enabled = True
        '
        'cod_txb
        '
        Me.cod_txb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cod_txb.AutoSize = True
        Me.cod_txb.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_txb.Location = New System.Drawing.Point(713, 74)
        Me.cod_txb.Name = "cod_txb"
        Me.cod_txb.Size = New System.Drawing.Size(15, 18)
        Me.cod_txb.TabIndex = 44
        Me.cod_txb.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(672, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Cod. Produto"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(673, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Custo :"
        '
        'custo
        '
        Me.custo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.custo.AutoSize = True
        Me.custo.Location = New System.Drawing.Point(719, 213)
        Me.custo.Name = "custo"
        Me.custo.Size = New System.Drawing.Size(34, 13)
        Me.custo.TabIndex = 47
        Me.custo.Text = "00,00"
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(648, 350)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 33)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "50%"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(683, 350)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 33)
        Me.Button5.TabIndex = 52
        Me.Button5.Text = "60%"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(718, 350)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 33)
        Me.Button6.TabIndex = 53
        Me.Button6.Text = "80%"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(753, 350)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(42, 33)
        Me.Button7.TabIndex = 54
        Me.Button7.Text = "100%"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Adc_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 445)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.custo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cod_txb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total_txb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.quant_txb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.val_txb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.marca_txb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.desc_txb)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txb_consulta)
        Me.Controls.Add(Me.DTGcliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Adc_Produto"
        Me.Text = "ADICIONAR PRODUTO"
        CType(Me.DTGcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txb_consulta As System.Windows.Forms.TextBox
    Friend WithEvents DTGcliente As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents desc_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents marca_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents val_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents quant_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents total_txb As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Calcular As System.Windows.Forms.Timer
    Friend WithEvents conexão As System.Windows.Forms.Timer
    Friend WithEvents cod_txb As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents custo As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
