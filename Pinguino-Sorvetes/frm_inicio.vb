Public Class frm_inicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & database & ";")
            MsgBox("Conectado ao banco de dados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception
            MsgBox("Falha na conexão ao banco de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

        sql = "SELECT * FROM tb_cardapio WHERE id = 20;"
        rs = db.Execute(sql)
        imagem = Application.StartupPath & rs.Fields(3).Value
        'MsgBox(imagem)
        'imgbox1.Load(imagem)

    End Sub
End Class
