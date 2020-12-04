<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro_funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro_funcionarios))
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.cmb_cargo_funcionario = New System.Windows.Forms.ComboBox()
        Me.lbl_nome_funcionario = New System.Windows.Forms.Label()
        Me.txt_nome_funcionario = New System.Windows.Forms.TextBox()
        Me.txt_login_funcionario = New System.Windows.Forms.TextBox()
        Me.lbl_login_funcionario = New System.Windows.Forms.Label()
        Me.lbl_dica_login = New System.Windows.Forms.Label()
        Me.lbl_dica_senha = New System.Windows.Forms.Label()
        Me.txt_senha_funcionario = New System.Windows.Forms.TextBox()
        Me.lbl_senha_funcionario = New System.Windows.Forms.Label()
        Me.btn_salvar_funcionario = New System.Windows.Forms.Button()
        Me.btn_cancelar_funcionario = New System.Windows.Forms.Button()
        Me.txt_confirma_senha = New System.Windows.Forms.TextBox()
        Me.lbl_confirmar_senha = New System.Windows.Forms.Label()
        Me.img_wrong = New System.Windows.Forms.PictureBox()
        Me.img_correct = New System.Windows.Forms.PictureBox()
        CType(Me.img_wrong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_correct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cargo.Font = New System.Drawing.Font("Cocogoose", 12.0!)
        Me.lbl_cargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_cargo.Location = New System.Drawing.Point(315, 111)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(70, 24)
        Me.lbl_cargo.TabIndex = 0
        Me.lbl_cargo.Text = "CARGO"
        '
        'cmb_cargo_funcionario
        '
        Me.cmb_cargo_funcionario.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.cmb_cargo_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_cargo_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.cmb_cargo_funcionario.FormattingEnabled = True
        Me.cmb_cargo_funcionario.Location = New System.Drawing.Point(312, 139)
        Me.cmb_cargo_funcionario.Name = "cmb_cargo_funcionario"
        Me.cmb_cargo_funcionario.Size = New System.Drawing.Size(142, 24)
        Me.cmb_cargo_funcionario.TabIndex = 1
        '
        'lbl_nome_funcionario
        '
        Me.lbl_nome_funcionario.AutoSize = True
        Me.lbl_nome_funcionario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nome_funcionario.Font = New System.Drawing.Font("Cocogoose", 12.0!)
        Me.lbl_nome_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_nome_funcionario.Location = New System.Drawing.Point(46, 112)
        Me.lbl_nome_funcionario.Name = "lbl_nome_funcionario"
        Me.lbl_nome_funcionario.Size = New System.Drawing.Size(218, 24)
        Me.lbl_nome_funcionario.TabIndex = 3
        Me.lbl_nome_funcionario.Text = "NOME DO FUNCIONÁRIO"
        '
        'txt_nome_funcionario
        '
        Me.txt_nome_funcionario.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_nome_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome_funcionario.Enabled = False
        Me.txt_nome_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_nome_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_nome_funcionario.Location = New System.Drawing.Point(49, 139)
        Me.txt_nome_funcionario.Name = "txt_nome_funcionario"
        Me.txt_nome_funcionario.ReadOnly = True
        Me.txt_nome_funcionario.Size = New System.Drawing.Size(250, 23)
        Me.txt_nome_funcionario.TabIndex = 4
        '
        'txt_login_funcionario
        '
        Me.txt_login_funcionario.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_login_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_login_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_login_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_login_funcionario.Location = New System.Drawing.Point(49, 198)
        Me.txt_login_funcionario.MaxLength = 10
        Me.txt_login_funcionario.Name = "txt_login_funcionario"
        Me.txt_login_funcionario.Size = New System.Drawing.Size(147, 23)
        Me.txt_login_funcionario.TabIndex = 6
        '
        'lbl_login_funcionario
        '
        Me.lbl_login_funcionario.AutoSize = True
        Me.lbl_login_funcionario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_login_funcionario.Font = New System.Drawing.Font("Cocogoose", 12.0!)
        Me.lbl_login_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_login_funcionario.Location = New System.Drawing.Point(46, 171)
        Me.lbl_login_funcionario.Name = "lbl_login_funcionario"
        Me.lbl_login_funcionario.Size = New System.Drawing.Size(88, 24)
        Me.lbl_login_funcionario.TabIndex = 5
        Me.lbl_login_funcionario.Text = "USUÁRIO"
        '
        'lbl_dica_login
        '
        Me.lbl_dica_login.AutoSize = True
        Me.lbl_dica_login.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dica_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dica_login.Location = New System.Drawing.Point(46, 221)
        Me.lbl_dica_login.Name = "lbl_dica_login"
        Me.lbl_dica_login.Size = New System.Drawing.Size(128, 16)
        Me.lbl_dica_login.TabIndex = 7
        Me.lbl_dica_login.Text = "(Máx: 10 caracteres)"
        '
        'lbl_dica_senha
        '
        Me.lbl_dica_senha.AutoSize = True
        Me.lbl_dica_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dica_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dica_senha.Location = New System.Drawing.Point(206, 224)
        Me.lbl_dica_senha.Name = "lbl_dica_senha"
        Me.lbl_dica_senha.Size = New System.Drawing.Size(119, 16)
        Me.lbl_dica_senha.TabIndex = 10
        Me.lbl_dica_senha.Text = "(Mín: 6 Caracteres)"
        '
        'txt_senha_funcionario
        '
        Me.txt_senha_funcionario.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_senha_funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_senha_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_senha_funcionario.Location = New System.Drawing.Point(209, 198)
        Me.txt_senha_funcionario.MaxLength = 10
        Me.txt_senha_funcionario.Name = "txt_senha_funcionario"
        Me.txt_senha_funcionario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_funcionario.Size = New System.Drawing.Size(116, 23)
        Me.txt_senha_funcionario.TabIndex = 9
        '
        'lbl_senha_funcionario
        '
        Me.lbl_senha_funcionario.AutoSize = True
        Me.lbl_senha_funcionario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_senha_funcionario.Font = New System.Drawing.Font("Cocogoose", 12.0!)
        Me.lbl_senha_funcionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_senha_funcionario.Location = New System.Drawing.Point(205, 171)
        Me.lbl_senha_funcionario.Name = "lbl_senha_funcionario"
        Me.lbl_senha_funcionario.Size = New System.Drawing.Size(68, 24)
        Me.lbl_senha_funcionario.TabIndex = 8
        Me.lbl_senha_funcionario.Text = "SENHA"
        '
        'btn_salvar_funcionario
        '
        Me.btn_salvar_funcionario.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_salvar_funcionario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_salvar_funcionario.FlatAppearance.BorderSize = 2
        Me.btn_salvar_funcionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_salvar_funcionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_salvar_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_salvar_funcionario.ForeColor = System.Drawing.Color.White
        Me.btn_salvar_funcionario.Location = New System.Drawing.Point(335, 252)
        Me.btn_salvar_funcionario.Name = "btn_salvar_funcionario"
        Me.btn_salvar_funcionario.Size = New System.Drawing.Size(119, 36)
        Me.btn_salvar_funcionario.TabIndex = 11
        Me.btn_salvar_funcionario.Text = "SALVAR"
        Me.btn_salvar_funcionario.UseVisualStyleBackColor = False
        '
        'btn_cancelar_funcionario
        '
        Me.btn_cancelar_funcionario.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancelar_funcionario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cancelar_funcionario.FlatAppearance.BorderSize = 2
        Me.btn_cancelar_funcionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_cancelar_funcionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btn_cancelar_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar_funcionario.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar_funcionario.Location = New System.Drawing.Point(206, 252)
        Me.btn_cancelar_funcionario.Name = "btn_cancelar_funcionario"
        Me.btn_cancelar_funcionario.Size = New System.Drawing.Size(119, 36)
        Me.btn_cancelar_funcionario.TabIndex = 12
        Me.btn_cancelar_funcionario.Text = "CANCELAR"
        Me.btn_cancelar_funcionario.UseVisualStyleBackColor = False
        '
        'txt_confirma_senha
        '
        Me.txt_confirma_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.txt_confirma_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_confirma_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_confirma_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.txt_confirma_senha.Location = New System.Drawing.Point(338, 198)
        Me.txt_confirma_senha.MaxLength = 10
        Me.txt_confirma_senha.Name = "txt_confirma_senha"
        Me.txt_confirma_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirma_senha.Size = New System.Drawing.Size(116, 23)
        Me.txt_confirma_senha.TabIndex = 14
        '
        'lbl_confirmar_senha
        '
        Me.lbl_confirmar_senha.AutoSize = True
        Me.lbl_confirmar_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_confirmar_senha.Font = New System.Drawing.Font("Cocogoose", 12.0!)
        Me.lbl_confirmar_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lbl_confirmar_senha.Location = New System.Drawing.Point(334, 171)
        Me.lbl_confirmar_senha.Name = "lbl_confirmar_senha"
        Me.lbl_confirmar_senha.Size = New System.Drawing.Size(113, 24)
        Me.lbl_confirmar_senha.TabIndex = 13
        Me.lbl_confirmar_senha.Text = "CONFIRMAR"
        '
        'img_wrong
        '
        Me.img_wrong.BackColor = System.Drawing.Color.Transparent
        Me.img_wrong.InitialImage = CType(resources.GetObject("img_wrong.InitialImage"), System.Drawing.Image)
        Me.img_wrong.Location = New System.Drawing.Point(438, 224)
        Me.img_wrong.Name = "img_wrong"
        Me.img_wrong.Size = New System.Drawing.Size(16, 16)
        Me.img_wrong.TabIndex = 15
        Me.img_wrong.TabStop = False
        '
        'img_correct
        '
        Me.img_correct.BackColor = System.Drawing.Color.Transparent
        Me.img_correct.InitialImage = CType(resources.GetObject("img_correct.InitialImage"), System.Drawing.Image)
        Me.img_correct.Location = New System.Drawing.Point(438, 224)
        Me.img_correct.Name = "img_correct"
        Me.img_correct.Size = New System.Drawing.Size(16, 16)
        Me.img_correct.TabIndex = 16
        Me.img_correct.TabStop = False
        '
        'cadastro_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(501, 300)
        Me.Controls.Add(Me.img_correct)
        Me.Controls.Add(Me.img_wrong)
        Me.Controls.Add(Me.txt_confirma_senha)
        Me.Controls.Add(Me.lbl_confirmar_senha)
        Me.Controls.Add(Me.btn_cancelar_funcionario)
        Me.Controls.Add(Me.btn_salvar_funcionario)
        Me.Controls.Add(Me.lbl_dica_senha)
        Me.Controls.Add(Me.txt_senha_funcionario)
        Me.Controls.Add(Me.lbl_senha_funcionario)
        Me.Controls.Add(Me.lbl_dica_login)
        Me.Controls.Add(Me.txt_login_funcionario)
        Me.Controls.Add(Me.lbl_login_funcionario)
        Me.Controls.Add(Me.txt_nome_funcionario)
        Me.Controls.Add(Me.lbl_nome_funcionario)
        Me.Controls.Add(Me.cmb_cargo_funcionario)
        Me.Controls.Add(Me.lbl_cargo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cadastro_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários - PINGUINO SORVETES"
        CType(Me.img_wrong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_correct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_cargo As Label
    Friend WithEvents cmb_cargo_funcionario As ComboBox
    Friend WithEvents lbl_nome_funcionario As Label
    Friend WithEvents txt_nome_funcionario As TextBox
    Friend WithEvents txt_login_funcionario As TextBox
    Friend WithEvents lbl_login_funcionario As Label
    Friend WithEvents lbl_dica_login As Label
    Friend WithEvents lbl_dica_senha As Label
    Friend WithEvents txt_senha_funcionario As TextBox
    Friend WithEvents lbl_senha_funcionario As Label
    Friend WithEvents btn_salvar_funcionario As Button
    Friend WithEvents btn_cancelar_funcionario As Button
    Friend WithEvents txt_confirma_senha As TextBox
    Friend WithEvents lbl_confirmar_senha As Label
    Friend WithEvents img_wrong As PictureBox
    Friend WithEvents img_correct As PictureBox
End Class
