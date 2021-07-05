<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORNECEDORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CAIXAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORÇAMENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTOQUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTATISTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.data_timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTROToolStripMenuItem, Me.CONSULTAToolStripMenuItem, Me.FORNECEDORESToolStripMenuItem, Me.CAIXAToolStripMenuItem, Me.ORÇAMENTOToolStripMenuItem, Me.ESTOQUEToolStripMenuItem, Me.ESTATISTToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(667, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.PRODUTOSToolStripMenuItem, Me.MOTOSToolStripMenuItem})
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.CADASTROToolStripMenuItem.Text = "CADASTRO"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ClientesToolStripMenuItem.Text = "CLIENTES"
        '
        'PRODUTOSToolStripMenuItem
        '
        Me.PRODUTOSToolStripMenuItem.Image = CType(resources.GetObject("PRODUTOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PRODUTOSToolStripMenuItem.Name = "PRODUTOSToolStripMenuItem"
        Me.PRODUTOSToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PRODUTOSToolStripMenuItem.Text = "PRODUTOS"
        '
        'MOTOSToolStripMenuItem
        '
        Me.MOTOSToolStripMenuItem.Image = CType(resources.GetObject("MOTOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MOTOSToolStripMenuItem.Name = "MOTOSToolStripMenuItem"
        Me.MOTOSToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MOTOSToolStripMenuItem.Text = "MOTOS"
        '
        'CONSULTAToolStripMenuItem
        '
        Me.CONSULTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTEToolStripMenuItem, Me.PRODUTOToolStripMenuItem, Me.MOTOToolStripMenuItem})
        Me.CONSULTAToolStripMenuItem.Name = "CONSULTAToolStripMenuItem"
        Me.CONSULTAToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.CONSULTAToolStripMenuItem.Text = "CONSULTA"
        '
        'CLIENTEToolStripMenuItem
        '
        Me.CLIENTEToolStripMenuItem.Image = CType(resources.GetObject("CLIENTEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CLIENTEToolStripMenuItem.Name = "CLIENTEToolStripMenuItem"
        Me.CLIENTEToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CLIENTEToolStripMenuItem.Text = "CLIENTE"
        '
        'PRODUTOToolStripMenuItem
        '
        Me.PRODUTOToolStripMenuItem.Image = CType(resources.GetObject("PRODUTOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PRODUTOToolStripMenuItem.Name = "PRODUTOToolStripMenuItem"
        Me.PRODUTOToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PRODUTOToolStripMenuItem.Text = "PRODUTO"
        '
        'MOTOToolStripMenuItem
        '
        Me.MOTOToolStripMenuItem.Image = CType(resources.GetObject("MOTOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MOTOToolStripMenuItem.Name = "MOTOToolStripMenuItem"
        Me.MOTOToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.MOTOToolStripMenuItem.Text = "MOTO"
        '
        'FORNECEDORESToolStripMenuItem
        '
        Me.FORNECEDORESToolStripMenuItem.Name = "FORNECEDORESToolStripMenuItem"
        Me.FORNECEDORESToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.FORNECEDORESToolStripMenuItem.Text = "FORNECEDORES"
        '
        'CAIXAToolStripMenuItem
        '
        Me.CAIXAToolStripMenuItem.Name = "CAIXAToolStripMenuItem"
        Me.CAIXAToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.CAIXAToolStripMenuItem.Text = "CAIXA"
        '
        'ORÇAMENTOToolStripMenuItem
        '
        Me.ORÇAMENTOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NOVOToolStripMenuItem, Me.BUSCARToolStripMenuItem})
        Me.ORÇAMENTOToolStripMenuItem.Name = "ORÇAMENTOToolStripMenuItem"
        Me.ORÇAMENTOToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ORÇAMENTOToolStripMenuItem.Text = "ORÇAMENTO"
        '
        'NOVOToolStripMenuItem
        '
        Me.NOVOToolStripMenuItem.Image = CType(resources.GetObject("NOVOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NOVOToolStripMenuItem.Name = "NOVOToolStripMenuItem"
        Me.NOVOToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.NOVOToolStripMenuItem.Text = "NOVO"
        '
        'BUSCARToolStripMenuItem
        '
        Me.BUSCARToolStripMenuItem.Image = CType(resources.GetObject("BUSCARToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BUSCARToolStripMenuItem.Name = "BUSCARToolStripMenuItem"
        Me.BUSCARToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.BUSCARToolStripMenuItem.Text = "BUSCAR"
        '
        'ESTOQUEToolStripMenuItem
        '
        Me.ESTOQUEToolStripMenuItem.Name = "ESTOQUEToolStripMenuItem"
        Me.ESTOQUEToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ESTOQUEToolStripMenuItem.Text = "ESTOQUE"
        '
        'ESTATISTToolStripMenuItem
        '
        Me.ESTATISTToolStripMenuItem.Name = "ESTATISTToolStripMenuItem"
        Me.ESTATISTToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ESTATISTToolStripMenuItem.Text = "ESTATISTICAS"
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SAIRToolStripMenuItem.Text = "SAIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 24)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desenvolvido - Ivz Copyrigth © 2017 - Versão 0.8.0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'data_timer
        '
        Me.data_timer.Enabled = True
        Me.data_timer.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 269)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(319, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(643, 259)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(667, 317)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JJ MOTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CADASTROToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORNECEDORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAIXAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORÇAMENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTOQUEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents data_timer As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CLIENTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ESTATISTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NOVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BUSCARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
