<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Produto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Produto))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cod_label = New System.Windows.Forms.Label()
        Me.cod_txb = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cod_barras = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.valor_custo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.modelo_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Desc_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.valor_venda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.marca_txt = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(456, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'cod_label
        '
        Me.cod_label.AutoSize = True
        Me.cod_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_label.Location = New System.Drawing.Point(266, 56)
        Me.cod_label.Name = "cod_label"
        Me.cod_label.Size = New System.Drawing.Size(35, 18)
        Me.cod_label.TabIndex = 24
        Me.cod_label.Text = "000"
        '
        'cod_txb
        '
        Me.cod_txb.AutoSize = True
        Me.cod_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_txb.Location = New System.Drawing.Point(123, 56)
        Me.cod_txb.Name = "cod_txb"
        Me.cod_txb.Size = New System.Drawing.Size(137, 18)
        Me.cod_txb.TabIndex = 23
        Me.cod_txb.Text = "Código Produto :"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(264, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 43)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "&Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(354, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 43)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cod_barras)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.valor_custo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.modelo_txt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Desc_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.valor_venda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.marca_txt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 111)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cod. Barras"
        '
        'cod_barras
        '
        Me.cod_barras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cod_barras.Location = New System.Drawing.Point(270, 32)
        Me.cod_barras.Name = "cod_barras"
        Me.cod_barras.Size = New System.Drawing.Size(137, 20)
        Me.cod_barras.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Valor Custo"
        '
        'valor_custo
        '
        Me.valor_custo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.valor_custo.Location = New System.Drawing.Point(270, 71)
        Me.valor_custo.Name = "valor_custo"
        Me.valor_custo.Size = New System.Drawing.Size(58, 20)
        Me.valor_custo.TabIndex = 5
        Me.valor_custo.Text = "00,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Modelo"
        '
        'modelo_txt
        '
        Me.modelo_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.modelo_txt.Location = New System.Drawing.Point(137, 71)
        Me.modelo_txt.Name = "modelo_txt"
        Me.modelo_txt.Size = New System.Drawing.Size(127, 20)
        Me.modelo_txt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descrição"
        '
        'Desc_txt
        '
        Me.Desc_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Desc_txt.Location = New System.Drawing.Point(9, 32)
        Me.Desc_txt.Name = "Desc_txt"
        Me.Desc_txt.Size = New System.Drawing.Size(255, 20)
        Me.Desc_txt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Valor Venda"
        '
        'valor_venda
        '
        Me.valor_venda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.valor_venda.Location = New System.Drawing.Point(345, 71)
        Me.valor_venda.Name = "valor_venda"
        Me.valor_venda.Size = New System.Drawing.Size(62, 20)
        Me.valor_venda.TabIndex = 6
        Me.valor_venda.Text = "00,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Marca"
        '
        'marca_txt
        '
        Me.marca_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.marca_txt.Location = New System.Drawing.Point(9, 71)
        Me.marca_txt.Name = "marca_txt"
        Me.marca_txt.Size = New System.Drawing.Size(122, 20)
        Me.marca_txt.TabIndex = 3
        '
        'Edit_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 236)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cod_label)
        Me.Controls.Add(Me.cod_txb)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Edit_Produto"
        Me.Text = "EDITAR PRODUTO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cod_label As System.Windows.Forms.Label
    Friend WithEvents cod_txb As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cod_barras As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents valor_custo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents modelo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Desc_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents valor_venda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents marca_txt As System.Windows.Forms.TextBox
End Class
