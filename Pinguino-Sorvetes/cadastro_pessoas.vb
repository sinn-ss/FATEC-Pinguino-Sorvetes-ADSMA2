Public Class cadastro_pessoas
    Private Sub cadastro_pessoas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
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

End Class