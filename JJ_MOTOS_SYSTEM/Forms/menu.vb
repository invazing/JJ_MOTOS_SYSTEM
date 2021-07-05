Public Class menu


    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Cad_Cliente.ShowDialog()
    End Sub

 
    Private Sub CADASTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CADASTROToolStripMenuItem.Click
    End Sub
    Private Sub PRODUTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUTOSToolStripMenuItem.Click
        Cad_produto.ShowDialog()
    End Sub
    Private Sub data_timer_Tick(sender As Object, e As EventArgs) Handles data_timer.Tick
        Label1.Text = Now
    End Sub
    Private Sub CLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTEToolStripMenuItem.Click
        Con_Cliente.ShowDialog()
    End Sub

    Private Sub PRODUTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUTOToolStripMenuItem.Click
        Con_Produto.ShowDialog()
    End Sub

    Private Sub MOTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOTOSToolStripMenuItem.Click
        Cad_Moto.ShowDialog()
    End Sub

    Private Sub MOTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOTOToolStripMenuItem.Click
        Con_Moto.ShowDialog()
    End Sub

    Private Sub SAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Label1.Text = Now
    End Sub
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Now
    End Sub

    Private Sub NOVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOVOToolStripMenuItem.Click
        Orçamento.ShowDialog()
    End Sub
End Class
