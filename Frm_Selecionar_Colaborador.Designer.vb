<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Selecionar_Colaborador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Selecionar_Colaborador))
        Me.Pnl_BotoesAcao = New System.Windows.Forms.Panel()
        Me.Bttn_Selecionar = New System.Windows.Forms.Button()
        Me.Bttn_Cancelar = New System.Windows.Forms.Button()
        Me.Pnl_Lista_Colaboradores = New System.Windows.Forms.Panel()
        Me.TbCntrl_Lista_Colaboradores = New System.Windows.Forms.TabControl()
        Me.TbPg_Lista_Colaboradores = New System.Windows.Forms.TabPage()
        Me.DtGrdVw_Lista_Colaboradores = New System.Windows.Forms.DataGridView()
        Me.Pnl_Divisor_1 = New System.Windows.Forms.Panel()
        Me.GrpBx_Dados_Filtro = New System.Windows.Forms.GroupBox()
        Me.Bttn_Limpar = New System.Windows.Forms.Button()
        Me.TxtBx_Termo_Pesquisa = New System.Windows.Forms.TextBox()
        Me.Lbl_Termo_Pesquisa = New System.Windows.Forms.Label()
        Me.Pnl_BotoesAcao.SuspendLayout()
        Me.Pnl_Lista_Colaboradores.SuspendLayout()
        Me.TbCntrl_Lista_Colaboradores.SuspendLayout()
        Me.TbPg_Lista_Colaboradores.SuspendLayout()
        CType(Me.DtGrdVw_Lista_Colaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBx_Dados_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_BotoesAcao
        '
        Me.Pnl_BotoesAcao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Selecionar)
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Cancelar)
        Me.Pnl_BotoesAcao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_BotoesAcao.Location = New System.Drawing.Point(0, 385)
        Me.Pnl_BotoesAcao.Name = "Pnl_BotoesAcao"
        Me.Pnl_BotoesAcao.Padding = New System.Windows.Forms.Padding(15)
        Me.Pnl_BotoesAcao.Size = New System.Drawing.Size(802, 65)
        Me.Pnl_BotoesAcao.TabIndex = 1
        '
        'Bttn_Selecionar
        '
        Me.Bttn_Selecionar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Selecionar.Location = New System.Drawing.Point(687, 15)
        Me.Bttn_Selecionar.Name = "Bttn_Selecionar"
        Me.Bttn_Selecionar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Selecionar.TabIndex = 0
        Me.Bttn_Selecionar.Text = "Selecionar"
        Me.Bttn_Selecionar.UseVisualStyleBackColor = True
        '
        'Bttn_Cancelar
        '
        Me.Bttn_Cancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bttn_Cancelar.Location = New System.Drawing.Point(15, 15)
        Me.Bttn_Cancelar.Name = "Bttn_Cancelar"
        Me.Bttn_Cancelar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Cancelar.TabIndex = 1
        Me.Bttn_Cancelar.Text = "Cancelar"
        Me.Bttn_Cancelar.UseVisualStyleBackColor = True
        '
        'Pnl_Lista_Colaboradores
        '
        Me.Pnl_Lista_Colaboradores.Controls.Add(Me.TbCntrl_Lista_Colaboradores)
        Me.Pnl_Lista_Colaboradores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Lista_Colaboradores.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Lista_Colaboradores.Name = "Pnl_Lista_Colaboradores"
        Me.Pnl_Lista_Colaboradores.Padding = New System.Windows.Forms.Padding(15)
        Me.Pnl_Lista_Colaboradores.Size = New System.Drawing.Size(802, 385)
        Me.Pnl_Lista_Colaboradores.TabIndex = 0
        '
        'TbCntrl_Lista_Colaboradores
        '
        Me.TbCntrl_Lista_Colaboradores.Controls.Add(Me.TbPg_Lista_Colaboradores)
        Me.TbCntrl_Lista_Colaboradores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbCntrl_Lista_Colaboradores.Location = New System.Drawing.Point(15, 15)
        Me.TbCntrl_Lista_Colaboradores.Name = "TbCntrl_Lista_Colaboradores"
        Me.TbCntrl_Lista_Colaboradores.SelectedIndex = 0
        Me.TbCntrl_Lista_Colaboradores.Size = New System.Drawing.Size(772, 355)
        Me.TbCntrl_Lista_Colaboradores.TabIndex = 0
        '
        'TbPg_Lista_Colaboradores
        '
        Me.TbPg_Lista_Colaboradores.Controls.Add(Me.DtGrdVw_Lista_Colaboradores)
        Me.TbPg_Lista_Colaboradores.Controls.Add(Me.Pnl_Divisor_1)
        Me.TbPg_Lista_Colaboradores.Controls.Add(Me.GrpBx_Dados_Filtro)
        Me.TbPg_Lista_Colaboradores.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_Lista_Colaboradores.Name = "TbPg_Lista_Colaboradores"
        Me.TbPg_Lista_Colaboradores.Padding = New System.Windows.Forms.Padding(10)
        Me.TbPg_Lista_Colaboradores.Size = New System.Drawing.Size(764, 329)
        Me.TbPg_Lista_Colaboradores.TabIndex = 0
        Me.TbPg_Lista_Colaboradores.Text = "Lista de Colaboradores"
        Me.TbPg_Lista_Colaboradores.UseVisualStyleBackColor = True
        '
        'DtGrdVw_Lista_Colaboradores
        '
        Me.DtGrdVw_Lista_Colaboradores.AllowUserToAddRows = False
        Me.DtGrdVw_Lista_Colaboradores.AllowUserToDeleteRows = False
        Me.DtGrdVw_Lista_Colaboradores.AllowUserToResizeColumns = False
        Me.DtGrdVw_Lista_Colaboradores.AllowUserToResizeRows = False
        Me.DtGrdVw_Lista_Colaboradores.BackgroundColor = System.Drawing.Color.White
        Me.DtGrdVw_Lista_Colaboradores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DtGrdVw_Lista_Colaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGrdVw_Lista_Colaboradores.DefaultCellStyle = DataGridViewCellStyle1
        Me.DtGrdVw_Lista_Colaboradores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtGrdVw_Lista_Colaboradores.Location = New System.Drawing.Point(10, 10)
        Me.DtGrdVw_Lista_Colaboradores.Name = "DtGrdVw_Lista_Colaboradores"
        Me.DtGrdVw_Lista_Colaboradores.ReadOnly = True
        Me.DtGrdVw_Lista_Colaboradores.RowHeadersVisible = False
        Me.DtGrdVw_Lista_Colaboradores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DtGrdVw_Lista_Colaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtGrdVw_Lista_Colaboradores.Size = New System.Drawing.Size(744, 232)
        Me.DtGrdVw_Lista_Colaboradores.TabIndex = 0
        '
        'Pnl_Divisor_1
        '
        Me.Pnl_Divisor_1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_Divisor_1.Location = New System.Drawing.Point(10, 242)
        Me.Pnl_Divisor_1.Name = "Pnl_Divisor_1"
        Me.Pnl_Divisor_1.Size = New System.Drawing.Size(744, 10)
        Me.Pnl_Divisor_1.TabIndex = 1
        '
        'GrpBx_Dados_Filtro
        '
        Me.GrpBx_Dados_Filtro.Controls.Add(Me.Bttn_Limpar)
        Me.GrpBx_Dados_Filtro.Controls.Add(Me.TxtBx_Termo_Pesquisa)
        Me.GrpBx_Dados_Filtro.Controls.Add(Me.Lbl_Termo_Pesquisa)
        Me.GrpBx_Dados_Filtro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrpBx_Dados_Filtro.Location = New System.Drawing.Point(10, 252)
        Me.GrpBx_Dados_Filtro.Name = "GrpBx_Dados_Filtro"
        Me.GrpBx_Dados_Filtro.Padding = New System.Windows.Forms.Padding(5, 5, 10, 10)
        Me.GrpBx_Dados_Filtro.Size = New System.Drawing.Size(744, 67)
        Me.GrpBx_Dados_Filtro.TabIndex = 2
        Me.GrpBx_Dados_Filtro.TabStop = False
        Me.GrpBx_Dados_Filtro.Text = "Dados para Filtro"
        '
        'Bttn_Limpar
        '
        Me.Bttn_Limpar.Location = New System.Drawing.Point(631, 21)
        Me.Bttn_Limpar.Name = "Bttn_Limpar"
        Me.Bttn_Limpar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Limpar.TabIndex = 1
        Me.Bttn_Limpar.Text = "Limpar"
        Me.Bttn_Limpar.UseVisualStyleBackColor = True
        '
        'TxtBx_Termo_Pesquisa
        '
        Me.TxtBx_Termo_Pesquisa.Location = New System.Drawing.Point(11, 34)
        Me.TxtBx_Termo_Pesquisa.Name = "TxtBx_Termo_Pesquisa"
        Me.TxtBx_Termo_Pesquisa.Size = New System.Drawing.Size(614, 20)
        Me.TxtBx_Termo_Pesquisa.TabIndex = 0
        '
        'Lbl_Termo_Pesquisa
        '
        Me.Lbl_Termo_Pesquisa.AutoSize = True
        Me.Lbl_Termo_Pesquisa.Location = New System.Drawing.Point(8, 18)
        Me.Lbl_Termo_Pesquisa.Name = "Lbl_Termo_Pesquisa"
        Me.Lbl_Termo_Pesquisa.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_Termo_Pesquisa.TabIndex = 0
        Me.Lbl_Termo_Pesquisa.Text = "Termo de Pesquisa"
        '
        'Frm_Selecionar_Colaborador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pnl_Lista_Colaboradores)
        Me.Controls.Add(Me.Pnl_BotoesAcao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Selecionar_Colaborador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar Colaborador"
        Me.Pnl_BotoesAcao.ResumeLayout(False)
        Me.Pnl_Lista_Colaboradores.ResumeLayout(False)
        Me.TbCntrl_Lista_Colaboradores.ResumeLayout(False)
        Me.TbPg_Lista_Colaboradores.ResumeLayout(False)
        CType(Me.DtGrdVw_Lista_Colaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBx_Dados_Filtro.ResumeLayout(False)
        Me.GrpBx_Dados_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_BotoesAcao As Panel
    Friend WithEvents Pnl_Lista_Colaboradores As Panel
    Friend WithEvents TbCntrl_Lista_Colaboradores As TabControl
    Friend WithEvents TbPg_Lista_Colaboradores As TabPage
    Friend WithEvents GrpBx_Dados_Filtro As GroupBox
    Friend WithEvents Lbl_Termo_Pesquisa As Label
    Friend WithEvents Bttn_Limpar As Button
    Friend WithEvents TxtBx_Termo_Pesquisa As TextBox
    Friend WithEvents DtGrdVw_Lista_Colaboradores As DataGridView
    Friend WithEvents Pnl_Divisor_1 As Panel
    Friend WithEvents Bttn_Selecionar As Button
    Friend WithEvents Bttn_Cancelar As Button
End Class
