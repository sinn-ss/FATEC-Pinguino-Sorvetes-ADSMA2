<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.menu_inicio = New System.Windows.Forms.MenuStrip()
        Me.menu_pedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CADASTROSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoCadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTOQUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELATÓRIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDeFuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDeEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARDÁPIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCardápioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_inicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_inicio
        '
        Me.menu_inicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.menu_inicio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_inicio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_pedidos, Me.CADASTROSToolStripMenuItem, Me.ESTOQUEToolStripMenuItem, Me.RELATÓRIOSToolStripMenuItem, Me.CARDÁPIOToolStripMenuItem, Me.CONTAToolStripMenuItem})
        Me.menu_inicio.Location = New System.Drawing.Point(0, 0)
        Me.menu_inicio.Name = "menu_inicio"
        Me.menu_inicio.Size = New System.Drawing.Size(704, 29)
        Me.menu_inicio.TabIndex = 0
        Me.menu_inicio.Text = "MENU"
        '
        'menu_pedidos
        '
        Me.menu_pedidos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoPedidoToolStripMenuItem, Me.ConsultarPedidosToolStripMenuItem})
        Me.menu_pedidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.menu_pedidos.Name = "menu_pedidos"
        Me.menu_pedidos.Size = New System.Drawing.Size(91, 25)
        Me.menu_pedidos.Text = "PEDIDOS"
        '
        'NovoPedidoToolStripMenuItem
        '
        Me.NovoPedidoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.NovoPedidoToolStripMenuItem.Name = "NovoPedidoToolStripMenuItem"
        Me.NovoPedidoToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.NovoPedidoToolStripMenuItem.Text = "Novo Pedido"
        '
        'ConsultarPedidosToolStripMenuItem
        '
        Me.ConsultarPedidosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ConsultarPedidosToolStripMenuItem.Name = "ConsultarPedidosToolStripMenuItem"
        Me.ConsultarPedidosToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ConsultarPedidosToolStripMenuItem.Text = "Consultar Pedidos"
        '
        'CADASTROSToolStripMenuItem
        '
        Me.CADASTROSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoCadastroToolStripMenuItem})
        Me.CADASTROSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CADASTROSToolStripMenuItem.Name = "CADASTROSToolStripMenuItem"
        Me.CADASTROSToolStripMenuItem.Size = New System.Drawing.Size(115, 25)
        Me.CADASTROSToolStripMenuItem.Text = "CADASTROS"
        '
        'NovoCadastroToolStripMenuItem
        '
        Me.NovoCadastroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.NovoCadastroToolStripMenuItem.Name = "NovoCadastroToolStripMenuItem"
        Me.NovoCadastroToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.NovoCadastroToolStripMenuItem.Text = "Novo Cadastro"
        '
        'ESTOQUEToolStripMenuItem
        '
        Me.ESTOQUEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarEstoqueToolStripMenuItem, Me.CadastrarProdutoToolStripMenuItem})
        Me.ESTOQUEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ESTOQUEToolStripMenuItem.Name = "ESTOQUEToolStripMenuItem"
        Me.ESTOQUEToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.ESTOQUEToolStripMenuItem.Text = "ESTOQUE"
        '
        'GerenciarEstoqueToolStripMenuItem
        '
        Me.GerenciarEstoqueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GerenciarEstoqueToolStripMenuItem.Name = "GerenciarEstoqueToolStripMenuItem"
        Me.GerenciarEstoqueToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.GerenciarEstoqueToolStripMenuItem.Text = "Gerenciar Estoque"
        '
        'CadastrarProdutoToolStripMenuItem
        '
        Me.CadastrarProdutoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CadastrarProdutoToolStripMenuItem.Name = "CadastrarProdutoToolStripMenuItem"
        Me.CadastrarProdutoToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.CadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto"
        '
        'RELATÓRIOSToolStripMenuItem
        '
        Me.RELATÓRIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioDePedidosToolStripMenuItem, Me.RelatórioDeClientesToolStripMenuItem, Me.RelatórioDeFuncionáriosToolStripMenuItem, Me.RelatórioDeEstoqueToolStripMenuItem})
        Me.RELATÓRIOSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.RELATÓRIOSToolStripMenuItem.Name = "RELATÓRIOSToolStripMenuItem"
        Me.RELATÓRIOSToolStripMenuItem.Size = New System.Drawing.Size(115, 25)
        Me.RELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS"
        '
        'RelatórioDePedidosToolStripMenuItem
        '
        Me.RelatórioDePedidosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.RelatórioDePedidosToolStripMenuItem.Name = "RelatórioDePedidosToolStripMenuItem"
        Me.RelatórioDePedidosToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.RelatórioDePedidosToolStripMenuItem.Text = "Relatório de Pedidos"
        '
        'RelatórioDeClientesToolStripMenuItem
        '
        Me.RelatórioDeClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.RelatórioDeClientesToolStripMenuItem.Name = "RelatórioDeClientesToolStripMenuItem"
        Me.RelatórioDeClientesToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.RelatórioDeClientesToolStripMenuItem.Text = "Relatório de Clientes"
        '
        'RelatórioDeFuncionáriosToolStripMenuItem
        '
        Me.RelatórioDeFuncionáriosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.RelatórioDeFuncionáriosToolStripMenuItem.Name = "RelatórioDeFuncionáriosToolStripMenuItem"
        Me.RelatórioDeFuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.RelatórioDeFuncionáriosToolStripMenuItem.Text = "Relatório de Funcionários"
        '
        'RelatórioDeEstoqueToolStripMenuItem
        '
        Me.RelatórioDeEstoqueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.RelatórioDeEstoqueToolStripMenuItem.Name = "RelatórioDeEstoqueToolStripMenuItem"
        Me.RelatórioDeEstoqueToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.RelatórioDeEstoqueToolStripMenuItem.Text = "Relatório de Estoque"
        '
        'CARDÁPIOToolStripMenuItem
        '
        Me.CARDÁPIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarCardápioToolStripMenuItem, Me.CadastrarItemToolStripMenuItem})
        Me.CARDÁPIOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CARDÁPIOToolStripMenuItem.Name = "CARDÁPIOToolStripMenuItem"
        Me.CARDÁPIOToolStripMenuItem.Size = New System.Drawing.Size(103, 25)
        Me.CARDÁPIOToolStripMenuItem.Text = "CARDÁPIO"
        '
        'ConsultarCardápioToolStripMenuItem
        '
        Me.ConsultarCardápioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ConsultarCardápioToolStripMenuItem.Name = "ConsultarCardápioToolStripMenuItem"
        Me.ConsultarCardápioToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.ConsultarCardápioToolStripMenuItem.Text = "Consultar Cardápio"
        '
        'CadastrarItemToolStripMenuItem
        '
        Me.CadastrarItemToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.CadastrarItemToolStripMenuItem.Name = "CadastrarItemToolStripMenuItem"
        Me.CadastrarItemToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.CadastrarItemToolStripMenuItem.Text = "Cadastrar Item"
        '
        'CONTAToolStripMenuItem
        '
        Me.CONTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarContaToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.CONTAToolStripMenuItem.Name = "CONTAToolStripMenuItem"
        Me.CONTAToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.CONTAToolStripMenuItem.Text = "CONTA"
        '
        'GerenciarContaToolStripMenuItem
        '
        Me.GerenciarContaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GerenciarContaToolStripMenuItem.Name = "GerenciarContaToolStripMenuItem"
        Me.GerenciarContaToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.GerenciarContaToolStripMenuItem.Text = "Gerenciar Conta"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(704, 312)
        Me.Controls.Add(Me.menu_inicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_inicio
        Me.MaximizeBox = False
        Me.Name = "inicio"
        Me.Text = "PINGUINO SORVETES - Início"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menu_inicio.ResumeLayout(False)
        Me.menu_inicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_inicio As MenuStrip
    Friend WithEvents menu_pedidos As ToolStripMenuItem
    Friend WithEvents NovoPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CADASTROSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoCadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ESTOQUEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RELATÓRIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDePedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeFuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARDÁPIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCardápioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciarContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
