Public Class cadastro_pessoas
    Private Sub cadastro_pessoas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        photoname = "default-photo.jpg"
        img_foto.Load(Application.StartupPath & "\images\photos\" & photoname)
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            If Not txt_cep.MaskCompleted Then
                Exit Sub
            Else
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
                img_foto.Load(folder)
                photoname = txt_nome.Text.Replace(" ", "-")
            End With
        Catch ex As Exception
            MsgBox("Falha ao abrir janela de diálogo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If rd_cliente.Checked = True Then
                ' ARMAZENANDO DADOS DE CLIENTE
                ' Tirando as máscaras para armazenar no banco
                cpf_unmask = txt_cpf.Text.Replace(".", "").Replace("-", "")
                telefone_unmask = txt_telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
                ' Setando o caminho da foto para a pasta em Bin/Debug para passar o caminho dinâmico para o banco de dados 
                If photoname = "default-photo.jpg" Then
                    folder = "/images/photos/" & LCase(photoname)
                Else
                    photoname = txt_nome.Text.Replace(" ", "-")
                    folder = "/images/photos/" & LCase(photoname) & ".jpg"
                End If
                sql = "INSERT INTO pessoas (cpf, nome, data_nascimento, telefone, email, foto) " &
                          "VALUES ('" & cpf_unmask & "', " &
                                   "'" & txt_nome.Text & "', " &
                                   "'" & cmb_data_nascimento.Value & "', " &
                                   "'" & telefone_unmask & "', " &
                                   "'" & txt_email.Text & "', " &
                                   "'" & folder & "');"
                rs = db.Execute(sql)
                sql = "SELECT @@IDENTITY;"
                rs = db.Execute(sql)
                id_pessoa = rs.Fields(0).Value
                sql = "INSERT INTO endereco (id_cep, id_pessoa, numero, complemento) " &
                      "VALUES ('" & txt_cep.Text & "', " &
                                    id_pessoa & ", " &
                               "'" & txt_numero.Text & "', " &
                               "'" & txt_complemento.Text & "');"
                rs = db.Execute(sql)
                sql = "INSERT INTO clientes (id_pessoa, ultima_visita) " &
                      "VALUES (" & id_pessoa & ", " &
                               "'" & Date.Today & "');"
                rs = db.Execute(sql)
                ' Copiando a foto para a pasta em Bin/Debug para passar o caminho dinâmico para o banco de dados 
                If Not photoname = "default-photo.jpg" Then
                    My.Computer.FileSystem.CopyFile(selecionar_foto.FileName, Application.StartupPath & "\images\photos\" & LCase(photoname) & ".jpg")
                End If
                resposta = MsgBox("Cadastro realizado com sucesso!" + vbNewLine +
                                      "Deseja realizar novo cadastro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO!")
                If resposta = vbYes Then
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
                    rd_cliente.Checked = True
                    photoname = "default-photo.jpg"
                    img_foto.Load(Application.StartupPath & "\images\photos\" & photoname)
                    txt_cpf.Select()
                Else
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
            Exit Sub
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        resposta = MsgBox("Deseja realmente sair da tela de cadastro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resposta = vbYes Then
            Me.Close()
        Else
            txt_nome.Select()
        End If
        Me.Close()
    End Sub

    Private Sub rd_funcionario_Click(sender As Object, e As EventArgs) Handles rd_funcionario.Click
        cadastro_funcionarios.Show()
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        If Not txt_cpf.MaskCompleted Then
            Exit Sub
        Else
            cpf_unmask = txt_cpf.Text.Replace(".", "").Replace("-", "")
            sql = "SELECT * FROM pessoas WHERE cpf = '" & cpf_unmask & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                txt_cpf.Clear()
                txt_cpf.Select()
            End If
        End If
    End Sub
End Class