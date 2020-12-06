Public Class inicio
    Private Sub NovoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoPedidoToolStripMenuItem.Click
        pedidos_novo.Show()
    End Sub

    Private Sub NovoCadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoCadastroToolStripMenuItem.Click
        cadastro_pessoas.Show()
    End Sub

    Private Sub ConsultarPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPedidosToolStripMenuItem.Click
        pedidos_consultar.Show()
    End Sub
End Class
