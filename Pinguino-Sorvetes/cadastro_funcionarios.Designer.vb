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
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.cmb_cargo_funcionario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cargo.Location = New System.Drawing.Point(240, 68)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(50, 13)
        Me.lbl_cargo.TabIndex = 0
        Me.lbl_cargo.Text = "CARGO"
        '
        'cmb_cargo_funcionario
        '
        Me.cmb_cargo_funcionario.FormattingEnabled = True
        Me.cmb_cargo_funcionario.Location = New System.Drawing.Point(243, 84)
        Me.cmb_cargo_funcionario.Name = "cmb_cargo_funcionario"
        Me.cmb_cargo_funcionario.Size = New System.Drawing.Size(113, 21)
        Me.cmb_cargo_funcionario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CADASTRO DE FUNCIONÁRIOS"
        '
        'lbl_nome_funcionario
        '
        Me.lbl_nome_funcionario.AutoSize = True
        Me.lbl_nome_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_funcionario.Location = New System.Drawing.Point(14, 69)
        Me.lbl_nome_funcionario.Name = "lbl_nome_funcionario"
        Me.lbl_nome_funcionario.Size = New System.Drawing.Size(154, 13)
        Me.lbl_nome_funcionario.TabIndex = 3
        Me.lbl_nome_funcionario.Text = "NOME DO FUNCIONÁRIO"
        '
        'txt_nome_funcionario
        '
        Me.txt_nome_funcionario.Enabled = False
        Me.txt_nome_funcionario.Location = New System.Drawing.Point(17, 85)
        Me.txt_nome_funcionario.Name = "txt_nome_funcionario"
        Me.txt_nome_funcionario.ReadOnly = True
        Me.txt_nome_funcionario.Size = New System.Drawing.Size(220, 20)
        Me.txt_nome_funcionario.TabIndex = 4
        '
        'txt_login_funcionario
        '
        Me.txt_login_funcionario.Location = New System.Drawing.Point(17, 144)
        Me.txt_login_funcionario.MaxLength = 10
        Me.txt_login_funcionario.Name = "txt_login_funcionario"
        Me.txt_login_funcionario.Size = New System.Drawing.Size(101, 20)
        Me.txt_login_funcionario.TabIndex = 6
        '
        'lbl_login_funcionario
        '
        Me.lbl_login_funcionario.AutoSize = True
        Me.lbl_login_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_funcionario.Location = New System.Drawing.Point(14, 128)
        Me.lbl_login_funcionario.Name = "lbl_login_funcionario"
        Me.lbl_login_funcionario.Size = New System.Drawing.Size(45, 13)
        Me.lbl_login_funcionario.TabIndex = 5
        Me.lbl_login_funcionario.Text = "LOGIN"
        '
        'lbl_dica_login
        '
        Me.lbl_dica_login.AutoSize = True
        Me.lbl_dica_login.Location = New System.Drawing.Point(14, 167)
        Me.lbl_dica_login.Name = "lbl_dica_login"
        Me.lbl_dica_login.Size = New System.Drawing.Size(104, 13)
        Me.lbl_dica_login.TabIndex = 7
        Me.lbl_dica_login.Text = "(Máx: 10 caracteres)"
        '
        'lbl_dica_senha
        '
        Me.lbl_dica_senha.AutoSize = True
        Me.lbl_dica_senha.Location = New System.Drawing.Point(124, 167)
        Me.lbl_dica_senha.Name = "lbl_dica_senha"
        Me.lbl_dica_senha.Size = New System.Drawing.Size(98, 13)
        Me.lbl_dica_senha.TabIndex = 10
        Me.lbl_dica_senha.Text = "(Mín: 6 Caracteres)"
        '
        'txt_senha_funcionario
        '
        Me.txt_senha_funcionario.Location = New System.Drawing.Point(124, 144)
        Me.txt_senha_funcionario.MaxLength = 10
        Me.txt_senha_funcionario.Name = "txt_senha_funcionario"
        Me.txt_senha_funcionario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_funcionario.Size = New System.Drawing.Size(113, 20)
        Me.txt_senha_funcionario.TabIndex = 9
        '
        'lbl_senha_funcionario
        '
        Me.lbl_senha_funcionario.AutoSize = True
        Me.lbl_senha_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha_funcionario.Location = New System.Drawing.Point(121, 128)
        Me.lbl_senha_funcionario.Name = "lbl_senha_funcionario"
        Me.lbl_senha_funcionario.Size = New System.Drawing.Size(49, 13)
        Me.lbl_senha_funcionario.TabIndex = 8
        Me.lbl_senha_funcionario.Text = "SENHA"
        '
        'btn_salvar_funcionario
        '
        Me.btn_salvar_funcionario.Location = New System.Drawing.Point(281, 185)
        Me.btn_salvar_funcionario.Name = "btn_salvar_funcionario"
        Me.btn_salvar_funcionario.Size = New System.Drawing.Size(75, 23)
        Me.btn_salvar_funcionario.TabIndex = 11
        Me.btn_salvar_funcionario.Text = "SALVAR"
        Me.btn_salvar_funcionario.UseVisualStyleBackColor = True
        '
        'btn_cancelar_funcionario
        '
        Me.btn_cancelar_funcionario.Location = New System.Drawing.Point(200, 185)
        Me.btn_cancelar_funcionario.Name = "btn_cancelar_funcionario"
        Me.btn_cancelar_funcionario.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar_funcionario.TabIndex = 12
        Me.btn_cancelar_funcionario.Text = "CANCELAR"
        Me.btn_cancelar_funcionario.UseVisualStyleBackColor = True
        '
        'txt_confirma_senha
        '
        Me.txt_confirma_senha.Location = New System.Drawing.Point(243, 144)
        Me.txt_confirma_senha.MaxLength = 10
        Me.txt_confirma_senha.Name = "txt_confirma_senha"
        Me.txt_confirma_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirma_senha.Size = New System.Drawing.Size(113, 20)
        Me.txt_confirma_senha.TabIndex = 14
        '
        'lbl_confirmar_senha
        '
        Me.lbl_confirmar_senha.AutoSize = True
        Me.lbl_confirmar_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmar_senha.Location = New System.Drawing.Point(240, 128)
        Me.lbl_confirmar_senha.Name = "lbl_confirmar_senha"
        Me.lbl_confirmar_senha.Size = New System.Drawing.Size(126, 13)
        Me.lbl_confirmar_senha.TabIndex = 13
        Me.lbl_confirmar_senha.Text = "CONFIRMAR SENHA"
        '
        'cadastro_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 220)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_cargo_funcionario)
        Me.Controls.Add(Me.lbl_cargo)
        Me.Name = "cadastro_funcionarios"
        Me.Text = "Cadastro de Funcionários - PINGUINO SORVETES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_cargo As Label
    Friend WithEvents cmb_cargo_funcionario As ComboBox
    Friend WithEvents Label1 As Label
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
End Class
