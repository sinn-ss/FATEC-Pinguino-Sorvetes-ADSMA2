<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pedidos_novo
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
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.cmb_clientes = New System.Windows.Forms.ComboBox()
        Me.cmb_itens_cardapio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_qtde = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.add_itens = New System.Windows.Forms.Button()
        Me.img_item = New System.Windows.Forms.PictureBox()
        Me.txt_valor_unit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtg_itens = New System.Windows.Forms.DataGridView()
        Me.dtg_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtg_descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtg_qtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtg_valor_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtg_valor_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_vtotal = New System.Windows.Forms.TextBox()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_observacoes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_troco = New System.Windows.Forms.TextBox()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.txt_valorpago = New System.Windows.Forms.TextBox()
        CType(Me.img_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOVO PEDIDO"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(14, 63)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(59, 13)
        Me.lbl_nome.TabIndex = 6
        Me.lbl_nome.Text = "CLIENTE"
        '
        'cmb_clientes
        '
        Me.cmb_clientes.FormattingEnabled = True
        Me.cmb_clientes.Location = New System.Drawing.Point(17, 79)
        Me.cmb_clientes.Name = "cmb_clientes"
        Me.cmb_clientes.Size = New System.Drawing.Size(309, 21)
        Me.cmb_clientes.TabIndex = 7
        '
        'cmb_itens_cardapio
        '
        Me.cmb_itens_cardapio.FormattingEnabled = True
        Me.cmb_itens_cardapio.Location = New System.Drawing.Point(17, 129)
        Me.cmb_itens_cardapio.Name = "cmb_itens_cardapio"
        Me.cmb_itens_cardapio.Size = New System.Drawing.Size(183, 21)
        Me.cmb_itens_cardapio.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ITEM"
        '
        'cmb_qtde
        '
        Me.cmb_qtde.FormattingEnabled = True
        Me.cmb_qtde.Location = New System.Drawing.Point(206, 129)
        Me.cmb_qtde.Name = "cmb_qtde"
        Me.cmb_qtde.Size = New System.Drawing.Size(38, 21)
        Me.cmb_qtde.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "QTDE"
        '
        'add_itens
        '
        Me.add_itens.Location = New System.Drawing.Point(250, 129)
        Me.add_itens.Name = "add_itens"
        Me.add_itens.Size = New System.Drawing.Size(76, 23)
        Me.add_itens.TabIndex = 12
        Me.add_itens.Text = "Adicionar"
        Me.add_itens.UseVisualStyleBackColor = True
        '
        'img_item
        '
        Me.img_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_item.Location = New System.Drawing.Point(332, 79)
        Me.img_item.Name = "img_item"
        Me.img_item.Size = New System.Drawing.Size(130, 130)
        Me.img_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_item.TabIndex = 13
        Me.img_item.TabStop = False
        '
        'txt_valor_unit
        '
        Me.txt_valor_unit.Enabled = False
        Me.txt_valor_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_unit.Location = New System.Drawing.Point(17, 180)
        Me.txt_valor_unit.Name = "txt_valor_unit"
        Me.txt_valor_unit.ReadOnly = True
        Me.txt_valor_unit.Size = New System.Drawing.Size(109, 29)
        Me.txt_valor_unit.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "VALOR UNITÁRIO"
        '
        'dtg_itens
        '
        Me.dtg_itens.AllowUserToAddRows = False
        Me.dtg_itens.AllowUserToDeleteRows = False
        Me.dtg_itens.AllowUserToResizeColumns = False
        Me.dtg_itens.AllowUserToResizeRows = False
        Me.dtg_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_itens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtg_item, Me.dtg_descricao, Me.dtg_qtde, Me.dtg_valor_unit, Me.dtg_valor_total})
        Me.dtg_itens.Location = New System.Drawing.Point(17, 215)
        Me.dtg_itens.Name = "dtg_itens"
        Me.dtg_itens.ReadOnly = True
        Me.dtg_itens.Size = New System.Drawing.Size(445, 150)
        Me.dtg_itens.TabIndex = 16
        '
        'dtg_item
        '
        Me.dtg_item.HeaderText = "ITEM"
        Me.dtg_item.Name = "dtg_item"
        Me.dtg_item.ReadOnly = True
        Me.dtg_item.Width = 50
        '
        'dtg_descricao
        '
        Me.dtg_descricao.HeaderText = "DESCRIÇÃO"
        Me.dtg_descricao.Name = "dtg_descricao"
        Me.dtg_descricao.ReadOnly = True
        Me.dtg_descricao.Width = 200
        '
        'dtg_qtde
        '
        Me.dtg_qtde.HeaderText = "QTDE"
        Me.dtg_qtde.Name = "dtg_qtde"
        Me.dtg_qtde.ReadOnly = True
        Me.dtg_qtde.Width = 50
        '
        'dtg_valor_unit
        '
        Me.dtg_valor_unit.HeaderText = "VALOR UNITÁRIO"
        Me.dtg_valor_unit.Name = "dtg_valor_unit"
        Me.dtg_valor_unit.ReadOnly = True
        Me.dtg_valor_unit.Width = 50
        '
        'dtg_valor_total
        '
        Me.dtg_valor_total.HeaderText = "VALOR TOTAL"
        Me.dtg_valor_total.Name = "dtg_valor_total"
        Me.dtg_valor_total.ReadOnly = True
        Me.dtg_valor_total.Width = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(350, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "VALOR TOTAL"
        '
        'txt_vtotal
        '
        Me.txt_vtotal.Enabled = False
        Me.txt_vtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vtotal.Location = New System.Drawing.Point(353, 386)
        Me.txt_vtotal.Name = "txt_vtotal"
        Me.txt_vtotal.ReadOnly = True
        Me.txt_vtotal.Size = New System.Drawing.Size(109, 29)
        Me.txt_vtotal.TabIndex = 17
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Location = New System.Drawing.Point(17, 448)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(149, 21)
        Me.cmb_pagamento.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "FORMA DE PAGAMENTO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "OBSERVAÇÕES"
        '
        'txt_observacoes
        '
        Me.txt_observacoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observacoes.Location = New System.Drawing.Point(17, 394)
        Me.txt_observacoes.Name = "txt_observacoes"
        Me.txt_observacoes.Size = New System.Drawing.Size(330, 20)
        Me.txt_observacoes.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(169, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "VALOR PAGO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(261, 431)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "TROCO"
        '
        'txt_troco
        '
        Me.txt_troco.Enabled = False
        Me.txt_troco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_troco.Location = New System.Drawing.Point(264, 448)
        Me.txt_troco.Name = "txt_troco"
        Me.txt_troco.ReadOnly = True
        Me.txt_troco.Size = New System.Drawing.Size(83, 20)
        Me.txt_troco.TabIndex = 25
        '
        'btn_finalizar
        '
        Me.btn_finalizar.Location = New System.Drawing.Point(353, 431)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(109, 37)
        Me.btn_finalizar.TabIndex = 27
        Me.btn_finalizar.Text = "FINALIZAR"
        Me.btn_finalizar.UseVisualStyleBackColor = True
        '
        'txt_valorpago
        '
        Me.txt_valorpago.Enabled = False
        Me.txt_valorpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valorpago.Location = New System.Drawing.Point(172, 449)
        Me.txt_valorpago.Name = "txt_valorpago"
        Me.txt_valorpago.ReadOnly = True
        Me.txt_valorpago.Size = New System.Drawing.Size(83, 20)
        Me.txt_valorpago.TabIndex = 23
        '
        'pedidos_novo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 484)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_troco)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_valorpago)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_observacoes)
        Me.Controls.Add(Me.cmb_pagamento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_vtotal)
        Me.Controls.Add(Me.dtg_itens)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_valor_unit)
        Me.Controls.Add(Me.img_item)
        Me.Controls.Add(Me.add_itens)
        Me.Controls.Add(Me.cmb_qtde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_itens_cardapio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_clientes)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pedidos_novo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PINGUINO SORVETES - Novo Pedido"
        CType(Me.img_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents cmb_clientes As ComboBox
    Friend WithEvents cmb_itens_cardapio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_qtde As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents add_itens As Button
    Friend WithEvents img_item As PictureBox
    Friend WithEvents txt_valor_unit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtg_itens As DataGridView
    Friend WithEvents dtg_item As DataGridViewTextBoxColumn
    Friend WithEvents dtg_descricao As DataGridViewTextBoxColumn
    Friend WithEvents dtg_qtde As DataGridViewTextBoxColumn
    Friend WithEvents dtg_valor_unit As DataGridViewTextBoxColumn
    Friend WithEvents dtg_valor_total As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_vtotal As TextBox
    Friend WithEvents cmb_pagamento As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_observacoes As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_troco As TextBox
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents txt_valorpago As TextBox
End Class
