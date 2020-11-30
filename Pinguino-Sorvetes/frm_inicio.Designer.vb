<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_inicio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUDEOPÇÕESFicaráPorÚltimoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUDEOPÇÕESFicaráPorÚltimoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUDEOPÇÕESFicaráPorÚltimoToolStripMenuItem
        '
        Me.MENUDEOPÇÕESFicaráPorÚltimoToolStripMenuItem.Name = "MENUDEOPÇÕESFicaráPorÚltimoToolStripMenuItem"
        Me.MENUDEOPÇÕESFicaráPorÚltimoToolStripMenuItem.Size = New System.Drawing.Size(219, 20)
        Me.MENUDEOPÇÕESFicaráPorÚltimoToolStripMenuItem.Text = "MENU DE OPÇÕES (Ficará por último)"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(158, 107)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(279, 55)
        Me.btn_login.TabIndex = 1
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'frm_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(610, 312)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_inicio"
        Me.Text = "PINGUINO SORVETES - Início"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUDEOPÇÕESFicaráPorÚltimoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_login As Button
End Class
