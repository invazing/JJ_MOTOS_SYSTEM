<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cad_Moto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cad_Moto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.placa_txb = New System.Windows.Forms.MaskedTextBox()
        Me.cod_txb = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ano_txb = New System.Windows.Forms.TextBox()
        Me.modelo_txb = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Form_Cliente = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.placa_txb)
        Me.GroupBox1.Controls.Add(Me.cod_txb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ano_txb)
        Me.GroupBox1.Controls.Add(Me.modelo_txb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'placa_txb
        '
        Me.placa_txb.Location = New System.Drawing.Point(282, 33)
        Me.placa_txb.Mask = "AAA-0000"
        Me.placa_txb.Name = "placa_txb"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Placa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ano"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Modelo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cód. Cliente"
        '
        'ano_txb
        '
        Me.ano_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ano_txb.Location = New System.Drawing.Point(176, 33)
        Me.ano_txb.Name = "ano_txb"
        Me.ano_txb.Size = New System.Drawing.Size(100, 20)
        Me.ano_txb.TabIndex = 2
        '
        'modelo_txb
        '
        Me.modelo_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.modelo_txb.Location = New System.Drawing.Point(76, 33)
        Me.modelo_txb.Name = "modelo_txb"
        Me.modelo_txb.Size = New System.Drawing.Size(94, 20)
        Me.modelo_txb.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(259, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(331, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Location = New System.Drawing.Point(12, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Buscar Cliente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form_Cliente
        '
        Me.Form_Cliente.Enabled = True
        Me.Form_Cliente.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Cad_Moto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 144)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cad_Moto"
        Me.Text = "CADASTRO DE MOTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ano_txb As System.Windows.Forms.TextBox
    Friend WithEvents modelo_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Form_Cliente As System.Windows.Forms.Timer
    Friend WithEvents cod_txb As System.Windows.Forms.Label
    Friend WithEvents placa_txb As System.Windows.Forms.MaskedTextBox
End Class
