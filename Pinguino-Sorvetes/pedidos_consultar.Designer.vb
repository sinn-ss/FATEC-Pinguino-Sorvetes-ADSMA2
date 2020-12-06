<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pedidos_consultar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pedidos_consultar))
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.cmb_tipobusca = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_buscar = New System.Windows.Forms.ToolStripButton()
        Me.id_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valort_pedidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.forma_pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ver_dados_pedido = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.apagar_pedido = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pedido, Me.data_pedido, Me.valort_pedidos, Me.forma_pagamento, Me.status_pedido, Me.ver_dados_pedido, Me.apagar_pedido})
        Me.dgv_pedidos.GridColor = System.Drawing.Color.Navy
        Me.dgv_pedidos.Location = New System.Drawing.Point(12, 28)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.Size = New System.Drawing.Size(723, 406)
        Me.dgv_pedidos.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_buscar, Me.cmb_tipobusca, Me.btn_buscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(747, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripLabel1.Text = "Pesquisar"
        '
        'txt_buscar
        '
        Me.txt_buscar.AutoCompleteCustomSource.AddRange(New String() {"Selecione", "Nome", "ID do Pedido", "Data"})
        Me.txt_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(200, 25)
        '
        'cmb_tipobusca
        '
        Me.cmb_tipobusca.Items.AddRange(New Object() {"id", "forma_pagamento", "status"})
        Me.cmb_tipobusca.Name = "cmb_tipobusca"
        Me.cmb_tipobusca.Size = New System.Drawing.Size(130, 25)
        '
        'btn_buscar
        '
        Me.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(23, 22)
        Me.btn_buscar.Text = "Buscar"
        '
        'id_pedido
        '
        Me.id_pedido.HeaderText = "ID"
        Me.id_pedido.Name = "id_pedido"
        Me.id_pedido.Width = 30
        '
        'data_pedido
        '
        Me.data_pedido.HeaderText = "DATA"
        Me.data_pedido.Name = "data_pedido"
        Me.data_pedido.Width = 75
        '
        'valort_pedidos
        '
        Me.valort_pedidos.HeaderText = "VALOR TOTAL"
        Me.valort_pedidos.Name = "valort_pedidos"
        Me.valort_pedidos.Width = 75
        '
        'forma_pagamento
        '
        Me.forma_pagamento.HeaderText = "FORMA DE PGTO"
        Me.forma_pagamento.Name = "forma_pagamento"
        Me.forma_pagamento.Width = 125
        '
        'status_pedido
        '
        Me.status_pedido.HeaderText = "STATUS"
        Me.status_pedido.Name = "status_pedido"
        Me.status_pedido.Width = 75
        '
        'ver_dados_pedido
        '
        Me.ver_dados_pedido.HeaderText = "VER DETALHES"
        Me.ver_dados_pedido.Name = "ver_dados_pedido"
        Me.ver_dados_pedido.Width = 75
        '
        'apagar_pedido
        '
        Me.apagar_pedido.HeaderText = "APAGAR"
        Me.apagar_pedido.Name = "apagar_pedido"
        Me.apagar_pedido.Width = 75
        '
        'pedidos_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 446)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_pedidos)
        Me.Name = "pedidos_consultar"
        Me.Text = "PINGUINO SORVETES - Consultar Pedidos"
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_pedidos As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_buscar As ToolStripTextBox
    Friend WithEvents cmb_tipobusca As ToolStripComboBox
    Friend WithEvents btn_buscar As ToolStripButton
    Friend WithEvents id_pedido As DataGridViewTextBoxColumn
    Friend WithEvents data_pedido As DataGridViewTextBoxColumn
    Friend WithEvents valort_pedidos As DataGridViewTextBoxColumn
    Friend WithEvents forma_pagamento As DataGridViewTextBoxColumn
    Friend WithEvents status_pedido As DataGridViewTextBoxColumn
    Friend WithEvents ver_dados_pedido As DataGridViewButtonColumn
    Friend WithEvents apagar_pedido As DataGridViewButtonColumn
End Class
