Public Class cadastro_funcionarios
    Private Sub cadastro_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome_funcionario.Text = cadastro_pessoas.txt_nome.Text
        cmb_cargo_funcionario.Items.Add("CAIXA")
        cmb_cargo_funcionario.Items.Add("COZINHA")
        cmb_cargo_funcionario.Items.Add("SUPERVISOR")
        cmb_cargo_funcionario.SelectedIndex = 0
    End Sub

    Private Sub btn_salvar_funcionario_Click(sender As Object, e As EventArgs) Handles btn_salvar_funcionario.Click
        sql = "INSERT INTO funcionarios (id_pessoa, cargo, usuario, senha) " &
                                "VALUES (" & id_pessoa & ", " &
                                         "'" & cmb_cargo_funcionario.SelectedItem & "', " &
                                         "'" & txt_login_funcionario.Text & "', " &
                                         "'" & txt_senha_funcionario.Text & "');"
        rs = db.Execute(sql)
        MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        Me.Close()
    End Sub
End Class