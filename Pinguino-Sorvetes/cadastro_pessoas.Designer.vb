<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro_pessoas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro_pessoas))
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
        Me.selecionar_foto = New System.Windows.Forms.OpenFileDialog()
        Me.rd_cliente = New System.Windows.Forms.RadioButton()
        Me.rd_funcionario = New System.Windows.Forms.RadioButton()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(46, 157)
        Me.txt_cpf.Mask = "000\.000\.000\-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(111, 23)
        Me.txt_cpf.TabIndex = 1
        '
        'lbl_cpf
        '
        Me.lbl_cpf.AutoSize = True
        Me.lbl_cpf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpf.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_cpf.Location = New System.Drawing.Point(43, 130)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(42, 24)
        Me.lbl_cpf.TabIndex = 2
        Me.lbl_cpf.Text = "CPF"
        '
        'cmb_data_nascimento
        '
        Me.cmb_data_nascimento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_nascimento.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.cmb_data_nascimento.CustomFormat = "00/00/0000"
        Me.cmb_data_nascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nascimento.Location = New System.Drawing.Point(170, 157)
        Me.cmb_data_nascimento.MaxDate = New Date(2020, 11, 29, 20, 50, 10, 0)
        Me.cmb_data_nascimento.Name = "cmb_data_nascimento"
        Me.cmb_data_nascimento.Size = New System.Drawing.Size(89, 23)
        Me.cmb_data_nascimento.TabIndex = 3
        Me.cmb_data_nascimento.Value = New Date(2020, 11, 29, 0, 0, 0, 0)
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_nome.Location = New System.Drawing.Point(47, 213)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(325, 23)
        Me.txt_nome.TabIndex = 4
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nome.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_nome.Location = New System.Drawing.Point(43, 186)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(163, 24)
        Me.lbl_nome.TabIndex = 5
        Me.lbl_nome.Text = "NOME COMPLETO"
        '
        'lbl_data_nascimento
        '
        Me.lbl_data_nascimento.AutoSize = True
        Me.lbl_data_nascimento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data_nascimento.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_nascimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_data_nascimento.Location = New System.Drawing.Point(166, 130)
        Me.lbl_data_nascimento.Name = "lbl_data_nascimento"
        Me.lbl_data_nascimento.Size = New System.Drawing.Size(206, 24)
        Me.lbl_data_nascimento.TabIndex = 6
        Me.lbl_data_nascimento.Text = "DATA DE NASCIMENTO"
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_telefone.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_telefone.Location = New System.Drawing.Point(41, 243)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(99, 24)
        Me.lbl_telefone.TabIndex = 8
        Me.lbl_telefone.Text = "TELEFONE"
        '
        'txt_telefone
        '
        Me.txt_telefone.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_telefone.Location = New System.Drawing.Point(47, 270)
        Me.txt_telefone.Mask = "(99) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(119, 23)
        Me.txt_telefone.TabIndex = 7
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_email.Location = New System.Drawing.Point(177, 243)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(71, 24)
        Me.lbl_email.TabIndex = 10
        Me.lbl_email.Text = "E-MAIL"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_email.Location = New System.Drawing.Point(179, 270)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(193, 23)
        Me.txt_email.TabIndex = 9
        '
        'lbl_cep
        '
        Me.lbl_cep.AutoSize = True
        Me.lbl_cep.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cep.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_cep.Location = New System.Drawing.Point(43, 299)
        Me.lbl_cep.Name = "lbl_cep"
        Me.lbl_cep.Size = New System.Drawing.Size(43, 24)
        Me.lbl_cep.TabIndex = 12
        Me.lbl_cep.Text = "CEP"
        '
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_cep.Location = New System.Drawing.Point(46, 326)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(80, 23)
        Me.txt_cep.TabIndex = 11
        '
        'lbl_logradouro
        '
        Me.lbl_logradouro.AutoSize = True
        Me.lbl_logradouro.BackColor = System.Drawing.Color.Transparent
        Me.lbl_logradouro.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logradouro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_logradouro.Location = New System.Drawing.Point(135, 299)
        Me.lbl_logradouro.Name = "lbl_logradouro"
        Me.lbl_logradouro.Size = New System.Drawing.Size(133, 24)
        Me.lbl_logradouro.TabIndex = 14
        Me.lbl_logradouro.Text = "LOGRADOURO"
        '
        'txt_logradouro
        '
        Me.txt_logradouro.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_logradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_logradouro.Enabled = False
        Me.txt_logradouro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_logradouro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_logradouro.Location = New System.Drawing.Point(139, 326)
        Me.txt_logradouro.Name = "txt_logradouro"
        Me.txt_logradouro.ReadOnly = True
        Me.txt_logradouro.Size = New System.Drawing.Size(233, 23)
        Me.txt_logradouro.TabIndex = 13
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.BackColor = System.Drawing.Color.Transparent
        Me.lbl_numero.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_numero.Location = New System.Drawing.Point(43, 355)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(30, 24)
        Me.lbl_numero.TabIndex = 16
        Me.lbl_numero.Text = "Nº"
        '
        'txt_numero
        '
        Me.txt_numero.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_numero.Location = New System.Drawing.Point(46, 382)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(51, 23)
        Me.txt_numero.TabIndex = 15
        '
        'lbl_complemento
        '
        Me.lbl_complemento.AutoSize = True
        Me.lbl_complemento.BackColor = System.Drawing.Color.Transparent
        Me.lbl_complemento.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_complemento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_complemento.Location = New System.Drawing.Point(107, 355)
        Me.lbl_complemento.Name = "lbl_complemento"
        Me.lbl_complemento.Size = New System.Drawing.Size(144, 24)
        Me.lbl_complemento.TabIndex = 18
        Me.lbl_complemento.Text = "COMPLEMENTO"
        '
        'txt_complemento
        '
        Me.txt_complemento.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_complemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_complemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_complemento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_complemento.Location = New System.Drawing.Point(111, 382)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(261, 23)
        Me.txt_complemento.TabIndex = 17
        '
        'lbl_bairro
        '
        Me.lbl_bairro.AutoSize = True
        Me.lbl_bairro.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bairro.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bairro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_bairro.Location = New System.Drawing.Point(43, 412)
        Me.lbl_bairro.Name = "lbl_bairro"
        Me.lbl_bairro.Size = New System.Drawing.Size(76, 24)
        Me.lbl_bairro.TabIndex = 20
        Me.lbl_bairro.Text = "BAIRRO"
        '
        'txt_bairro
        '
        Me.txt_bairro.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bairro.Enabled = False
        Me.txt_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_bairro.Location = New System.Drawing.Point(47, 439)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.ReadOnly = True
        Me.txt_bairro.Size = New System.Drawing.Size(110, 23)
        Me.txt_bairro.TabIndex = 19
        '
        'lbl_uf
        '
        Me.lbl_uf.AutoSize = True
        Me.lbl_uf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_uf.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_uf.Location = New System.Drawing.Point(334, 412)
        Me.lbl_uf.Name = "lbl_uf"
        Me.lbl_uf.Size = New System.Drawing.Size(32, 24)
        Me.lbl_uf.TabIndex = 22
        Me.lbl_uf.Text = "UF"
        '
        'txt_uf
        '
        Me.txt_uf.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_uf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uf.Enabled = False
        Me.txt_uf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_uf.Location = New System.Drawing.Point(334, 439)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.ReadOnly = True
        Me.txt_uf.Size = New System.Drawing.Size(38, 23)
        Me.txt_uf.TabIndex = 21
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cidade.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_cidade.Location = New System.Drawing.Point(166, 412)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(75, 24)
        Me.lbl_cidade.TabIndex = 24
        Me.lbl_cidade.Text = "CIDADE"
        '
        'txt_cidade
        '
        Me.txt_cidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cidade.Enabled = False
        Me.txt_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_cidade.Location = New System.Drawing.Point(170, 439)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.ReadOnly = True
        Me.txt_cidade.Size = New System.Drawing.Size(151, 23)
        Me.txt_cidade.TabIndex = 23
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Location = New System.Drawing.Point(403, 133)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(150, 170)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 25
        Me.img_foto.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cancelar.FlatAppearance.BorderSize = 2
        Me.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(403, 399)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(150, 37)
        Me.btn_cancelar.TabIndex = 26
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_salvar.FlatAppearance.BorderSize = 2
        Me.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(403, 441)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(149, 37)
        Me.btn_salvar.TabIndex = 27
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'lbl_foto
        '
        Me.lbl_foto.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.BackColor = System.Drawing.Color.Transparent
        Me.lbl_foto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_foto.LinkColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_foto.Location = New System.Drawing.Point(403, 307)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(130, 16)
        Me.lbl_foto.TabIndex = 28
        Me.lbl_foto.TabStop = True
        Me.lbl_foto.Text = "Selecionar Foto..."
        '
        'rd_cliente
        '
        Me.rd_cliente.AutoSize = True
        Me.rd_cliente.BackColor = System.Drawing.Color.Transparent
        Me.rd_cliente.Checked = True
        Me.rd_cliente.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.rd_cliente.FlatAppearance.BorderSize = 3
        Me.rd_cliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.rd_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.rd_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.rd_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rd_cliente.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.rd_cliente.Location = New System.Drawing.Point(406, 331)
        Me.rd_cliente.Name = "rd_cliente"
        Me.rd_cliente.Size = New System.Drawing.Size(97, 28)
        Me.rd_cliente.TabIndex = 29
        Me.rd_cliente.TabStop = True
        Me.rd_cliente.Text = "CLIENTE"
        Me.rd_cliente.UseVisualStyleBackColor = False
        '
        'rd_funcionario
        '
        Me.rd_funcionario.AutoSize = True
        Me.rd_funcionario.BackColor = System.Drawing.Color.Transparent
        Me.rd_funcionario.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.rd_funcionario.FlatAppearance.BorderSize = 3
        Me.rd_funcionario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.rd_funcionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.rd_funcionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.rd_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rd_funcionario.Font = New System.Drawing.Font("Cocogoose", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.rd_funcionario.Location = New System.Drawing.Point(406, 365)
        Me.rd_funcionario.Name = "rd_funcionario"
        Me.rd_funcionario.Size = New System.Drawing.Size(146, 28)
        Me.rd_funcionario.TabIndex = 30
        Me.rd_funcionario.Text = "FUNCIONÁRIO"
        Me.rd_funcionario.UseVisualStyleBackColor = False
        '
        'cadastro_pessoas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.rd_funcionario)
        Me.Controls.Add(Me.rd_cliente)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cadastro_pessoas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PINGUINO SORVETES - Cadastro de Pessoas"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents selecionar_foto As OpenFileDialog
    Friend WithEvents rd_cliente As RadioButton
    Friend WithEvents rd_funcionario As RadioButton
End Class
