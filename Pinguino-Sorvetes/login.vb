Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        sql = "SELECT * FROM funcionarios"
        rs = db.Execute(sql)
        rs.MoveFirst()
        While rs.EOF = False
            If txt_usuario.Text = rs.Fields(3).Value And txt_senha.Text = rs.Fields(4).Value Then
                MsgBox("Login efetuado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BEM VINDO!")
                inicio.ShowDialog()
                Me.Close()
                Exit While
            Else
                rs.MoveNext()
                If rs.EOF = True Then
                    MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                End If
            End If
        End While

    End Sub

End Class