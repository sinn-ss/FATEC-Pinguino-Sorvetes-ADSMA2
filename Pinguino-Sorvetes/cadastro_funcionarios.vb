Public Class cadastro_funcionarios
    Private Sub cadastro_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome_funcionario.Text = cadastro_pessoas.txt_nome.Text
        cmb_cargo_funcionario.Items.Add("Selecionar")
        cmb_cargo_funcionario.Items.Add("CAIXA")
        cmb_cargo_funcionario.Items.Add("COZINHA")
        cmb_cargo_funcionario.Items.Add("SUPERVISOR")
        cmb_cargo_funcionario.SelectedIndex = 0
    End Sub

    Private Sub btn_salvar_funcionario_Click(sender As Object, e As EventArgs) Handles btn_salvar_funcionario.Click
        If txt_senha_funcionario.Text = txt_confirma_senha.Text Then
            ' ARMAZENANDO DADOS DE FUNCIONÁRIOS
            ' Tirando as máscaras para armazenar no banco
            cpf_unmask = cadastro_pessoas.txt_cpf.Text.Replace(".", "").Replace("-", "")
            telefone_unmask = cadastro_pessoas.txt_telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
            ' Setando o caminho da foto para a pasta em Bin/Debug para passar o caminho dinâmico para o banco de dados 
            If photoname = "default-photo.jpg" Then
                folder = "/images/photos/" & LCase(photoname)
            Else
                photoname = cadastro_pessoas.txt_nome.Text.Replace(" ", "-")
                folder = "/images/photos/" & LCase(photoname) & ".jpg"
            End If
            sql = "INSERT INTO pessoas (cpf, nome, data_nascimento, telefone, email, foto) " &
                  "VALUES ('" & cpf_unmask & "', " &
                           "'" & cadastro_pessoas.txt_nome.Text & "', " &
                           "'" & cadastro_pessoas.cmb_data_nascimento.Value & "', " &
                           "'" & telefone_unmask & "', " &
                           "'" & cadastro_pessoas.txt_email.Text & "', " &
                           "'" & folder & "');"
            rs = db.Execute(sql)
            sql = "SELECT * FROM pessoas WHERE nome = '" & cadastro_pessoas.txt_nome.Text & "';"
            rs = db.Execute(sql)
            id_pessoa = rs.Fields(0).Value
            sql = "INSERT INTO endereco (id_cep, id_pessoa, numero, complemento) " &
                            "VALUES ('" & cadastro_pessoas.txt_cep.Text & "', " &
                                          id_pessoa & ", " &
                                    "'" & cadastro_pessoas.txt_numero.Text & "', " &
                                    "'" & cadastro_pessoas.txt_complemento.Text & "');"
            rs = db.Execute(sql)
            sql = "INSERT INTO funcionarios (id_pessoa, cargo, usuario, senha) " &
                                "VALUES (" & id_pessoa & ", " &
                                         "'" & cmb_cargo_funcionario.SelectedItem & "', " &
                                         "'" & txt_login_funcionario.Text & "', " &
                                         "'" & txt_senha_funcionario.Text & "');"
            rs = db.Execute(sql)
            ' Copiando a foto para a pasta em Bin/Debug para passar o caminho dinâmico para o banco de dados 
            If Not photoname = "default-photo.jpg" Then
                My.Computer.FileSystem.CopyFile(cadastro_pessoas.selecionar_foto.FileName, Application.StartupPath & "\images\photos\" & LCase(photoname) & ".jpg")
            End If
            resposta = MsgBox("Cadastro realizado com sucesso!" + vbNewLine +
                              "Deseja realizar novo cadastro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO!")
            If resposta = vbYes Then
                With cadastro_pessoas
                    .txt_cpf.Clear()
                    .cmb_data_nascimento.ResetText()
                    .txt_nome.Clear()
                    .txt_telefone.Clear()
                    .txt_email.Clear()
                    .txt_cep.Clear()
                    .txt_logradouro.Clear()
                    .txt_numero.Clear()
                    .txt_complemento.Clear()
                    .txt_bairro.Clear()
                    .txt_cidade.Clear()
                    .txt_uf.Clear()
                    .rd_cliente.Checked = True
                    photoname = "default-photo.jpg"
                    .img_foto.Load(Application.StartupPath & "\images\photos\" & photoname)
                    .txt_cpf.Select()
                End With
                Me.Close()
            Else
                Me.Close()
                cadastro_pessoas.Close()
            End If
        Else
            MsgBox("Campos de senha e confirmação de senha não conferem!")
            txt_confirma_senha.Select()
            Exit Sub
        End If
    End Sub

    Private Sub btn_cancelar_funcionario_Click(sender As Object, e As EventArgs) Handles btn_cancelar_funcionario.Click
        resposta = MsgBox("Deseja realmente fechar a janela de cadastro de Funcionário?" + vbNewLine +
                          "Os dados atuais do funcionário serão perdidos", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
        If resposta = vbYes Then
            With cadastro_pessoas
                .rd_cliente.Checked = True
            End With

            Me.Close()
        Else
            txt_login_funcionario.Select()
        End If
    End Sub

    Private Sub txt_confirma_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_confirma_senha.TextChanged
        If txt_confirma_senha.Text = txt_senha_funcionario.Text Then
            lbl_confirmar_senha.ForeColor = Color.Green
        Else
            lbl_confirmar_senha.ForeColor = Color.Red
        End If
    End Sub
End Class