Public Class pedidos_consultar
    Private Sub pedidos_consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_tipobusca.SelectedIndex = 0
        sql = "SELECT * FROM pedidos"
        rs = db.Execute(sql)
        cont = 1
        Do While rs.EOF = False
            dgv_pedidos.Rows.Add(rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
            cont = cont + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        With dgv_pedidos
            cont = 1
            sql = "SELECT * FROM pedidos WHERE " & cmb_tipobusca.Text & " like '" & txt_buscar.Text & "%'"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                dgv_pedidos.Rows.Add(rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub
End Class