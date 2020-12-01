Public Class cadastro_pessoas
    Private Sub cadastro_pessoas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        cmb_tipo.Items.Add("CLIENTE")
        cmb_tipo.Items.Add("FUNCIONÁRIO")
        cmb_tipo.SelectedIndex = 0
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "SELECT * FROM cep WHERE CEP = '" & txt_cep.Text & "';"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_logradouro.Text = rs.Fields(1).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_uf.Text = rs.Fields(4).Value
            Else
                MsgBox("CEP não encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                If txt_logradouro.Text.Length <> 0 Then
                    txt_logradouro.Text = ""
                    txt_bairro.Text = ""
                    txt_cidade.Text = ""
                    txt_uf.Text = ""
                End If
                txt_numero.Select()
            End If
        Catch ex As Exception
            MsgBox("Falha ao executar a consulta no banco de dados de CEP!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

    Private Sub lbl_foto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_foto.LinkClicked
        Try
            With selecionar_foto
                .Title = "Selecionar Foto"
                .InitialDirectory = Application.StartupPath & "\images\photos"
                .ShowDialog()
                folder = .FileName
                ' COMANDOS PARA COPIAR A FOTO PARA A PASTA NO STARTUP PATH
                ' FICOU AQUI PORQUE FOI USADO EM TESTE E DEU CERTO, IREI APLICAR
                ' NA FUNÇÃO GRAVAR DADOS
                'sql = "SELECT * FROM pessoas;"
                'rs = db.Execute(sql)
                'photoname = rs.Fields(0).Value + 1
                'My.Computer.FileSystem.CopyFile(folder, Application.StartupPath & "\images\photos\" & photoname & ".jpg")
                'folder = Application.StartupPath & "\images\photos\" & photoname & ".jpg"
                img_foto.Load(folder)
            End With
        Catch ex As Exception
            MsgBox("Falha ao abrir janela de diálogo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            ' Tirando as máscaras para armazenar no banco
            cpf_unmask = txt_cpf.Text.Replace(".", "").Replace("-", "")
            telefone_unmask = txt_telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
            photoname = txt_nome.Text.Replace(" ", "-")
            ' Copiando a foto para a pasta em Bin/Debug para passar o caminho dinâmico para o banco de dados 
            My.Computer.FileSystem.CopyFile(folder, Application.StartupPath & "\images\photos\" & LCase(photoname) & ".jpg")
            folder = "/images/photos/" & LCase(photoname) & ".jpg"
            sql = "INSERT INTO pessoas (cpf, nome, data_nascimento, telefone, email, foto) " &
                  "VALUES ('" & cpf_unmask & "', " &
                           "'" & txt_nome.Text & "', " &
                           "'" & cmb_data_nascimento.Value & "', " &
                           "'" & telefone_unmask & "', " &
                           "'" & txt_email.Text & "', " &
                           "'" & folder & "');"
            rs = db.Execute(sql)
            sql = "SELECT * FROM pessoas WHERE nome = '" & txt_nome.Text & "';"
            rs = db.Execute(sql)
            id_pessoa = rs.Fields(0).Value
            sql = "INSERT INTO endereco (id_cep, id_pessoa, numero, complemento) " &
                  "VALUES ('" & txt_cep.Text & "', " &
                                id_pessoa & ", " &
                           "'" & txt_numero.Text & "', " &
                           "'" & txt_complemento.Text & "');"
            rs = db.Execute(sql)
            If cmb_tipo.SelectedItem = "CLIENTE" Then
                sql = "INSERT INTO clientes (id_pessoa, ultima_visita) " &
                      "VALUES (" & id_pessoa & ", " &
                               "'" & Date.Today & "');"
                rs = db.Execute(sql)
            ElseIf cmb_tipo.SelectedItem = "FUNCIONÁRIO" Then
                ' Chamar o formulário com seleção de cargo, usuário e senha
            End If
            MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
            ' Limpar os campos
            txt_cpf.Clear()
            cmb_data_nascimento.ResetText()
            txt_nome.Clear()
            txt_telefone.Clear()
            txt_email.Clear()
            txt_cep.Clear()
            txt_logradouro.Clear()
            txt_numero.Clear()
            txt_complemento.Clear()
            txt_bairro.Clear()
            txt_cidade.Clear()
            txt_uf.Clear()
            img_foto.Image = Nothing
            txt_cpf.Select()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
            Exit Sub
        End Try
    End Sub
End Class