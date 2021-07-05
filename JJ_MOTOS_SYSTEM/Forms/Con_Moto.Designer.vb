<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Con_Moto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Con_Moto))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txb_consulta = New System.Windows.Forms.TextBox()
        Me.add_cliente = New System.Windows.Forms.Button()
        Me.DTGcliente = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DTGcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(375, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 33)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Editar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(228, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 33)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txb_consulta
        '
        Me.txb_consulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_consulta.Location = New System.Drawing.Point(3, 11)
        Me.txb_consulta.Name = "txb_consulta"
        Me.txb_consulta.Size = New System.Drawing.Size(219, 35)
        Me.txb_consulta.TabIndex = 29
        '
        'add_cliente
        '
        Me.add_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.add_cliente.Location = New System.Drawing.Point(434, 12)
        Me.add_cliente.Name = "add_cliente"
        Me.add_cliente.Size = New System.Drawing.Size(53, 33)
        Me.add_cliente.TabIndex = 27
        Me.add_cliente.Text = "Novo"
        Me.add_cliente.UseVisualStyleBackColor = True
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
        Me.DTGcliente.Location = New System.Drawing.Point(-1, 52)
        Me.DTGcliente.Name = "DTGcliente"
        Me.DTGcliente.ReadOnly = True
        Me.DTGcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGcliente.Size = New System.Drawing.Size(496, 295)
        Me.DTGcliente.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(496, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Con_Moto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 346)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txb_consulta)
        Me.Controls.Add(Me.add_cliente)
        Me.Controls.Add(Me.DTGcliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Con_Moto"
        Me.Text = "CONSULTA DE MOTO"
        CType(Me.DTGcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txb_consulta As System.Windows.Forms.TextBox
    Friend WithEvents add_cliente As System.Windows.Forms.Button
    Friend WithEvents DTGcliente As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
