Module mod_global
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public database = Application.StartupPath & "\database\pinguino-db.accdb"
    Public folder As String
    Public resposta As String
    Public cpf_unmask, telefone_unmask, photoname As String
    Public id_pessoa As Integer
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & database & ";")
            MsgBox("Conectado ao banco de dados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        Catch ex As Exception
            MsgBox("Falha na conexão ao banco de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


End Module
