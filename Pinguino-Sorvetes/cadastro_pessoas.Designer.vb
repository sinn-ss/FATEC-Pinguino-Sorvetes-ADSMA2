<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro_pessoas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.cmb_data_nascimento = New System.Windows.Forms.DateTimePicker()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_data_nascimento = New System.Windows.Forms.Label()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_cep = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_logradouro = New System.Windows.Forms.Label()
        Me.txt_logradouro = New System.Windows.Forms.TextBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_complemento = New System.Windows.Forms.Label()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.lbl_bairro = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.lbl_uf = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.lbl_cidade = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.lbl_foto = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CADASTRO DE PESSOAS"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(18, 78)
        Me.txt_cpf.Mask = "000\.000\.000\-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(88, 20)
        Me.txt_cpf.TabIndex = 1
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(15, 62)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(30, 13)
        Me.lbl_cpf.TabIndex = 2
        Me.lbl_cpf.Text = "CPF"
        '
        'cmb_data_nascimento
        '
        Me.cmb_data_nascimento.CustomFormat = "00/00/0000"
        Me.cmb_data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nascimento.Location = New System.Drawing.Point(155, 78)
        Me.cmb_data_nascimento.MaxDate = New Date(2020, 11, 29, 20, 50, 10, 0)
        Me.cmb_data_nascimento.Name = "cmb_data_nascimento"
        Me.cmb_data_nascimento.Size = New System.Drawing.Size(89, 20)
        Me.cmb_data_nascimento.TabIndex = 3
        Me.cmb_data_nascimento.Value = New Date(2020, 11, 29, 0, 0, 0, 0)
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(18, 125)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(276, 20)
        Me.txt_nome.TabIndex = 4
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(15, 110)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(114, 13)
        Me.lbl_nome.TabIndex = 5
        Me.lbl_nome.Text = "NOME COMPLETO"
        '
        'lbl_data_nascimento
        '
        Me.lbl_data_nascimento.AutoSize = True
        Me.lbl_data_nascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_nascimento.Location = New System.Drawing.Point(152, 62)
        Me.lbl_data_nascimento.Name = "lbl_data_nascimento"
        Me.lbl_data_nascimento.Size = New System.Drawing.Size(146, 13)
        Me.lbl_data_nascimento.TabIndex = 6
        Me.lbl_data_nascimento.Text = "DATA DE NASCIMENTO"
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(16, 160)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(71, 13)
        Me.lbl_telefone.TabIndex = 8
        Me.lbl_telefone.Text = "TELEFONE"
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(19, 176)
        Me.txt_telefone.Mask = "(99) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(87, 20)
        Me.txt_telefone.TabIndex = 7
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(109, 161)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(48, 13)
        Me.lbl_email.TabIndex = 10
        Me.lbl_email.Text = "E-MAIL"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(112, 176)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(182, 20)
        Me.txt_email.TabIndex = 9
        '
        'lbl_cep
        '
        Me.lbl_cep.AutoSize = True
        Me.lbl_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cep.Location = New System.Drawing.Point(16, 216)
        Me.lbl_cep.Name = "lbl_cep"
        Me.lbl_cep.Size = New System.Drawing.Size(31, 13)
        Me.lbl_cep.TabIndex = 12
        Me.lbl_cep.Text = "CEP"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(19, 232)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(58, 20)
        Me.txt_cep.TabIndex = 11
        '
        'lbl_logradouro
        '
        Me.lbl_logradouro.AutoSize = True
        Me.lbl_logradouro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logradouro.Location = New System.Drawing.Point(80, 217)
        Me.lbl_logradouro.Name = "lbl_logradouro"
        Me.lbl_logradouro.Size = New System.Drawing.Size(94, 13)
        Me.lbl_logradouro.TabIndex = 14
        Me.lbl_logradouro.Text = "LOGRADOURO"
        '
        'txt_logradouro
        '
        Me.txt_logradouro.Enabled = False
        Me.txt_logradouro.Location = New System.Drawing.Point(83, 232)
        Me.txt_logradouro.Name = "txt_logradouro"
        Me.txt_logradouro.ReadOnly = True
        Me.txt_logradouro.Size = New System.Drawing.Size(211, 20)
        Me.txt_logradouro.TabIndex = 13
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.Location = New System.Drawing.Point(16, 269)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(21, 13)
        Me.lbl_numero.TabIndex = 16
        Me.lbl_numero.Text = "Nº"
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(19, 284)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(51, 20)
        Me.txt_numero.TabIndex = 15
        '
        'lbl_complemento
        '
        Me.lbl_complemento.AutoSize = True
        Me.lbl_complemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_complemento.Location = New System.Drawing.Point(73, 269)
        Me.lbl_complemento.Name = "lbl_complemento"
        Me.lbl_complemento.Size = New System.Drawing.Size(101, 13)
        Me.lbl_complemento.TabIndex = 18
        Me.lbl_complemento.Text = "COMPLEMENTO"
        '
        'txt_complemento
        '
        Me.txt_complemento.Location = New System.Drawing.Point(76, 284)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(218, 20)
        Me.txt_complemento.TabIndex = 17
        '
        'lbl_bairro
        '
        Me.lbl_bairro.AutoSize = True
        Me.lbl_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bairro.Location = New System.Drawing.Point(16, 315)
        Me.lbl_bairro.Name = "lbl_bairro"
        Me.lbl_bairro.Size = New System.Drawing.Size(54, 13)
        Me.lbl_bairro.TabIndex = 20
        Me.lbl_bairro.Text = "BAIRRO"
        '
        'txt_bairro
        '
        Me.txt_bairro.Enabled = False
        Me.txt_bairro.Location = New System.Drawing.Point(19, 330)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.ReadOnly = True
        Me.txt_bairro.Size = New System.Drawing.Size(110, 20)
        Me.txt_bairro.TabIndex = 19
        '
        'lbl_uf
        '
        Me.lbl_uf.AutoSize = True
        Me.lbl_uf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uf.Location = New System.Drawing.Point(268, 315)
        Me.lbl_uf.Name = "lbl_uf"
        Me.lbl_uf.Size = New System.Drawing.Size(23, 13)
        Me.lbl_uf.TabIndex = 22
        Me.lbl_uf.Text = "UF"
        '
        'txt_uf
        '
        Me.txt_uf.Enabled = False
        Me.txt_uf.Location = New System.Drawing.Point(271, 330)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.ReadOnly = True
        Me.txt_uf.Size = New System.Drawing.Size(23, 20)
        Me.txt_uf.TabIndex = 21
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cidade.Location = New System.Drawing.Point(132, 315)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(53, 13)
        Me.lbl_cidade.TabIndex = 24
        Me.lbl_cidade.Text = "CIDADE"
        '
        'txt_cidade
        '
        Me.txt_cidade.Enabled = False
        Me.txt_cidade.Location = New System.Drawing.Point(135, 330)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.ReadOnly = True
        Me.txt_cidade.Size = New System.Drawing.Size(130, 20)
        Me.txt_cidade.TabIndex = 23
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Location = New System.Drawing.Point(330, 62)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(125, 134)
        Me.img_foto.TabIndex = 25
        Me.img_foto.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(330, 269)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(125, 35)
        Me.btn_cancelar.TabIndex = 26
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_salvar
        '
        Me.btn_salvar.Location = New System.Drawing.Point(330, 315)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(125, 35)
        Me.btn_salvar.TabIndex = 27
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Location = New System.Drawing.Point(330, 203)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(90, 13)
        Me.lbl_foto.TabIndex = 28
        Me.lbl_foto.TabStop = True
        Me.lbl_foto.Text = "Selecionar Foto..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Steh é um amorzinho <3"
        '
        'cadastro_pessoas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 367)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_foto)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.lbl_cidade)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.lbl_uf)
        Me.Controls.Add(Me.txt_uf)
        Me.Controls.Add(Me.lbl_bairro)
        Me.Controls.Add(Me.txt_bairro)
        Me.Controls.Add(Me.lbl_complemento)
        Me.Controls.Add(Me.txt_complemento)
        Me.Controls.Add(Me.lbl_numero)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.lbl_logradouro)
        Me.Controls.Add(Me.txt_logradouro)
        Me.Controls.Add(Me.lbl_cep)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.lbl_data_nascimento)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.cmb_data_nascimento)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cadastro_pessoas"
        Me.Text = "CADASTRO DE PESSOAS - Pinguino Sorvetes"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents cmb_data_nascimento As DateTimePicker
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_data_nascimento As Label
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_cep As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents lbl_logradouro As Label
    Friend WithEvents txt_logradouro As TextBox
    Friend WithEvents lbl_numero As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_complemento As Label
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents lbl_bairro As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents lbl_uf As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents lbl_cidade As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_salvar As Button
    Friend WithEvents lbl_foto As LinkLabel
    Friend WithEvents Label2 As Label
End Class
