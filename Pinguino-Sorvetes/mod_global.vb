Module mod_global
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public database = Application.StartupPath & "\database\pinguino-db.accdb"
    Public folder As String
    Public resposta As String
    Public cpf_unmask, telefone_unmask, photoname As String
    Public last_id, id_pessoa, id_funcionario, id_cliente, id_pedido, id_item As Integer
    Public qtdeitens As Integer
    Public valort_item, valor_unitario, total, vtotal, troco As Decimal
    Public cont, cont_itens As Integer
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & database & ";")
            MsgBox("Conectado ao banco de dados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception
            MsgBox("Falha na conexão ao banco de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_clientes_pedidos()
        Try
            pedidos_novo.cmb_clientes.Items.Add("Selecionar cliente")
            sql = "SELECT id_pessoa, nome FROM clientes INNER JOIN pessoas ON clientes.id_pessoa = pessoas.id"
            rs = db.Execute(sql)
            rs.MoveFirst()
            While rs.EOF = False
                pedidos_novo.cmb_clientes.Items.Add(rs.Fields(1).Value)
                rs.MoveNext()
            End While
            pedidos_novo.cmb_clientes.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Falha ao carregar clientes!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

    Sub carregar_itens_pedidos()
        Try
            pedidos_novo.cmb_itens_cardapio.Items.Add("Selecionar Item")
            sql = "SELECT * FROM itens_cardapio;"
            rs = db.Execute(sql)
            rs.MoveFirst()
            While rs.EOF = False
                pedidos_novo.cmb_itens_cardapio.Items.Add(rs.Fields(1).Value)
                rs.MoveNext()
            End While
            pedidos_novo.cmb_itens_cardapio.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Falha ao carregar itens!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

End Module
