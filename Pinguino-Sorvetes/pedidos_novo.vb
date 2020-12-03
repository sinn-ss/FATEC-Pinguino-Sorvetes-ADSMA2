Public Class pedidos_novo
    Private Sub novo_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_clientes_pedidos()
        carregar_itens_pedidos()
        For cont = 1 To 20
            cmb_qtde.Items.Add(cont)
        Next
        cmb_qtde.SelectedIndex = 0
        cont_itens = 1
        vtotal = 0
        With cmb_pagamento
            .Items.Add("Selecionar")
            .Items.Add("Dinheiro")
            .Items.Add("Cartão de Débito")
            .Items.Add("Cartão de Crédito")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub add_itens_Click(sender As Object, e As EventArgs) Handles add_itens.Click
        qtdeitens = Convert.ToInt32(cmb_qtde.Text)
        total = qtdeitens * valor_unitario
        dtg_itens.Rows.Add(cont_itens, cmb_itens_cardapio.Text, cmb_qtde.Text, valor_unitario, total)
        cont_itens += 1
        vtotal = 0
        For Each colunas As DataGridViewRow In dtg_itens.Rows
            vtotal = vtotal + colunas.Cells(4).Value
        Next
        txt_vtotal.Text = vtotal.ToString("R$ ##,###.00")
        cmb_qtde.SelectedIndex = 0
    End Sub

    Private Sub cmb_itens_cardapio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_itens_cardapio.SelectedValueChanged
        If cmb_itens_cardapio.Text = "Selecionar Item" Then
            Exit Sub
        Else
            sql = "SELECT * FROM itens_cardapio WHERE nome_item = '" & cmb_itens_cardapio.Text & "'"
            rs = db.Execute(sql)
            valor_unitario = rs.Fields(2).Value
            If cmb_itens_cardapio.Text = "Selecionar Item" Then
                img_item.Image = Nothing
                txt_valor_unit.Clear()
            Else
                img_item.Load(Application.StartupPath & rs.Fields(3).Value)
                txt_valor_unit.Text = "R$ " & rs.Fields(2).Value
            End If
        End If
    End Sub

    Private Sub cmb_pagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pagamento.SelectedIndexChanged
        If cmb_pagamento.Text = "Dinheiro" Then
            txt_valorpago.Enabled = True
            txt_valorpago.ReadOnly = False
        Else
            txt_valorpago.Enabled = False
            txt_valorpago.ReadOnly = True
            txt_valorpago.Text = vtotal
        End If
    End Sub

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function

    Private Sub txt_valorpago_TextChanged(sender As Object, e As EventArgs) Handles txt_valorpago.TextChanged
        If txt_valorpago.TextLength > 0 Then
            troco = Convert.ToInt32(txt_valorpago.Text) - vtotal
            txt_troco.Text = troco.ToString("R$ ##,###.00")
        Else
            txt_troco.Text = "R$ 0,00"
        End If
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        ' Setando o parâmetro id_cliente
        sql = "SELECT clientes.id, clientes.id_pessoa, pessoas.nome FROM clientes INNER JOIN pessoas ON clientes.id_pessoa = pessoas.id"
        rs = db.Execute(sql)
        rs.MoveFirst()
        While rs.Fields(2).Value <> cmb_clientes.Text
            rs.MoveNext()
        End While
        id_cliente = rs.Fields(0).Value
        ' Setando o parâmetro id_funcionário
        sql = "SELECT funcionarios.id, funcionarios.id_pessoa, pessoas.nome FROM funcionarios INNER JOIN pessoas ON funcionarios.id_pessoa = pessoas.id"
        rs = db.Execute(sql)
        rs.MoveFirst()
        ' Não esquecer de setar o funcionario aqui depois
        While rs.Fields(2).Value <> "Sindel Santos"
            rs.MoveNext()
        End While
        id_funcionario = rs.Fields(0).Value
        ' Passando os dados para o banco
        sql = "INSERT INTO pedidos (id_cliente, id_funcionario, data, valor_total, observacoes, forma_pagamento, pedido_pronto) " &
                           "VALUES (" & id_cliente & ", " &
                                    "" & id_funcionario & ", " &
                                    "'" & Date.Today & "', " &
                                    "" & vtotal & ", " &
                                    "'" & txt_observacoes.Text & "', " &
                                    "'" & cmb_pagamento.Text & "', " &
                                    "0);"
        rs = db.Execute(sql)
        ' Recuperando o id do pedido para armazenar os itens
        sql = "SELECT @@IDENTITY;"
        rs = db.Execute(sql)
        id_pedido = rs.Fields(0).Value
        cont = 0
        For Each item In dtg_itens.Rows
            MsgBox(dtg_itens.Rows(cont).Cells(1).Value.ToString)
            sql = "SELECT * FROM itens_cardapio WHERE nome_item = '" & dtg_itens.Rows(cont).Cells(1).Value & "';"
            rs = db.Execute(sql)
            id_item = rs.Fields(0).Value
            valor_unitario = rs.Fields(2).Value
            qtdeitens = dtg_itens.Rows(cont).Cells(2).Value.ToString
            valort_item = qtdeitens * valor_unitario
            sql = "INSERT INTO itens_pedido (id_item, id_pedido, quantidade, valor_final_item) " &
                                     "VALUES(" & id_item & ", " &
                                            "" & id_pedido & ", " &
                                            "" & qtdeitens & ", " &
                                            "" & valort_item & ");"
            rs = db.Execute(sql)
            cont += 1
        Next
        MsgBox("Dados salvos com sucesso!")
        ' Limpando os campos
        cmb_clientes.SelectedIndex = 0
        cmb_itens_cardapio.SelectedIndex = 0
        cmb_qtde.SelectedIndex = 0
        txt_valor_unit.Clear()
        dtg_itens.Rows.Clear()
        txt_observacoes.Clear()
        txt_vtotal.Clear()
        cmb_pagamento.SelectedIndex = 0
        txt_valorpago.Clear()
        txt_troco.Clear()
        img_item.Image = Nothing

    End Sub

    Private Sub txt_valorpago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valorpago.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class