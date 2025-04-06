<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cadastro_Colaborador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cadastro_Colaborador))
        Me.Pnl_BotoesAcao = New System.Windows.Forms.Panel()
        Me.Bttn_Excluir = New System.Windows.Forms.Button()
        Me.Bttn_Limpar = New System.Windows.Forms.Button()
        Me.Bttn_Executar = New System.Windows.Forms.Button()
        Me.Bttn_Cancelar = New System.Windows.Forms.Button()
        Me.Pnl_Dados_Colaborador = New System.Windows.Forms.Panel()
        Me.TbCntrl_Dados_Colaborador = New System.Windows.Forms.TabControl()
        Me.TbPg_Informacoes_Pessoais = New System.Windows.Forms.TabPage()
        Me.Lbl_Sexo = New System.Windows.Forms.Label()
        Me.CmbBx_Sexo = New System.Windows.Forms.ComboBox()
        Me.TxtBx_EmailPessoal = New System.Windows.Forms.TextBox()
        Me.Lbl_EmailPessoal = New System.Windows.Forms.Label()
        Me.TxtBx_NomeCompleto = New System.Windows.Forms.TextBox()
        Me.Lbl_NomeCompleto = New System.Windows.Forms.Label()
        Me.Lbl_DataNascimento = New System.Windows.Forms.Label()
        Me.DtTmPckr_DataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_TelefonePessoal = New System.Windows.Forms.Label()
        Me.MskdTxtBx_TelefonePessoal = New System.Windows.Forms.MaskedTextBox()
        Me.TbPg_Informacoes_Corporativas = New System.Windows.Forms.TabPage()
        Me.MskdTxtBx_Chapa = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_Chapa = New System.Windows.Forms.Label()
        Me.DtTmPckr_DataAdmissao = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DataAdmissao = New System.Windows.Forms.Label()
        Me.TxtBx_Setor = New System.Windows.Forms.TextBox()
        Me.Lbl_Setor = New System.Windows.Forms.Label()
        Me.TxtBx_EmailCorporativo = New System.Windows.Forms.TextBox()
        Me.Lbl_EmailCorporativo = New System.Windows.Forms.Label()
        Me.TxtBx_Funcao = New System.Windows.Forms.TextBox()
        Me.Lbl_Funcao = New System.Windows.Forms.Label()
        Me.DtTmPckr_DataDemissao = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DataDemissao = New System.Windows.Forms.Label()
        Me.Pnl_BotoesAcao.SuspendLayout()
        Me.Pnl_Dados_Colaborador.SuspendLayout()
        Me.TbCntrl_Dados_Colaborador.SuspendLayout()
        Me.TbPg_Informacoes_Pessoais.SuspendLayout()
        Me.TbPg_Informacoes_Corporativas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_BotoesAcao
        '
        Me.Pnl_BotoesAcao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Excluir)
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Limpar)
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Executar)
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Cancelar)
        Me.Pnl_BotoesAcao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_BotoesAcao.Location = New System.Drawing.Point(0, 237)
        Me.Pnl_BotoesAcao.Name = "Pnl_BotoesAcao"
        Me.Pnl_BotoesAcao.Padding = New System.Windows.Forms.Padding(15)
        Me.Pnl_BotoesAcao.Size = New System.Drawing.Size(435, 65)
        Me.Pnl_BotoesAcao.TabIndex = 0
        '
        'Bttn_Excluir
        '
        Me.Bttn_Excluir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Excluir.Location = New System.Drawing.Point(120, 15)
        Me.Bttn_Excluir.Name = "Bttn_Excluir"
        Me.Bttn_Excluir.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Excluir.TabIndex = 3
        Me.Bttn_Excluir.Text = "Excluir"
        Me.Bttn_Excluir.UseVisualStyleBackColor = True
        '
        'Bttn_Limpar
        '
        Me.Bttn_Limpar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Limpar.Location = New System.Drawing.Point(220, 15)
        Me.Bttn_Limpar.Name = "Bttn_Limpar"
        Me.Bttn_Limpar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Limpar.TabIndex = 2
        Me.Bttn_Limpar.Text = "Limpar"
        Me.Bttn_Limpar.UseVisualStyleBackColor = True
        '
        'Bttn_Executar
        '
        Me.Bttn_Executar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Executar.Location = New System.Drawing.Point(320, 15)
        Me.Bttn_Executar.Name = "Bttn_Executar"
        Me.Bttn_Executar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Executar.TabIndex = 1
        Me.Bttn_Executar.Text = "Executar"
        Me.Bttn_Executar.UseVisualStyleBackColor = True
        '
        'Bttn_Cancelar
        '
        Me.Bttn_Cancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bttn_Cancelar.Location = New System.Drawing.Point(15, 15)
        Me.Bttn_Cancelar.Name = "Bttn_Cancelar"
        Me.Bttn_Cancelar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Cancelar.TabIndex = 0
        Me.Bttn_Cancelar.Text = "Cancelar"
        Me.Bttn_Cancelar.UseVisualStyleBackColor = True
        '
        'Pnl_Dados_Colaborador
        '
        Me.Pnl_Dados_Colaborador.Controls.Add(Me.TbCntrl_Dados_Colaborador)
        Me.Pnl_Dados_Colaborador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Dados_Colaborador.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Dados_Colaborador.Name = "Pnl_Dados_Colaborador"
        Me.Pnl_Dados_Colaborador.Padding = New System.Windows.Forms.Padding(15)
        Me.Pnl_Dados_Colaborador.Size = New System.Drawing.Size(435, 237)
        Me.Pnl_Dados_Colaborador.TabIndex = 1
        '
        'TbCntrl_Dados_Colaborador
        '
        Me.TbCntrl_Dados_Colaborador.Controls.Add(Me.TbPg_Informacoes_Pessoais)
        Me.TbCntrl_Dados_Colaborador.Controls.Add(Me.TbPg_Informacoes_Corporativas)
        Me.TbCntrl_Dados_Colaborador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbCntrl_Dados_Colaborador.Location = New System.Drawing.Point(15, 15)
        Me.TbCntrl_Dados_Colaborador.Name = "TbCntrl_Dados_Colaborador"
        Me.TbCntrl_Dados_Colaborador.SelectedIndex = 0
        Me.TbCntrl_Dados_Colaborador.Size = New System.Drawing.Size(405, 207)
        Me.TbCntrl_Dados_Colaborador.TabIndex = 0
        '
        'TbPg_Informacoes_Pessoais
        '
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.MskdTxtBx_TelefonePessoal)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.Lbl_TelefonePessoal)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.DtTmPckr_DataNascimento)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.Lbl_DataNascimento)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.Lbl_Sexo)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.CmbBx_Sexo)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.TxtBx_EmailPessoal)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.Lbl_EmailPessoal)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.TxtBx_NomeCompleto)
        Me.TbPg_Informacoes_Pessoais.Controls.Add(Me.Lbl_NomeCompleto)
        Me.TbPg_Informacoes_Pessoais.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_Informacoes_Pessoais.Name = "TbPg_Informacoes_Pessoais"
        Me.TbPg_Informacoes_Pessoais.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.TbPg_Informacoes_Pessoais.Size = New System.Drawing.Size(397, 181)
        Me.TbPg_Informacoes_Pessoais.TabIndex = 0
        Me.TbPg_Informacoes_Pessoais.Text = "Informações Pessoais"
        Me.TbPg_Informacoes_Pessoais.UseVisualStyleBackColor = True
        '
        'Lbl_Sexo
        '
        Me.Lbl_Sexo.AutoSize = True
        Me.Lbl_Sexo.Location = New System.Drawing.Point(8, 88)
        Me.Lbl_Sexo.Name = "Lbl_Sexo"
        Me.Lbl_Sexo.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_Sexo.TabIndex = 5
        Me.Lbl_Sexo.Text = "Sexo"
        '
        'CmbBx_Sexo
        '
        Me.CmbBx_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBx_Sexo.FormattingEnabled = True
        Me.CmbBx_Sexo.Items.AddRange(New Object() {"Feminino", "Masculino"})
        Me.CmbBx_Sexo.Location = New System.Drawing.Point(11, 104)
        Me.CmbBx_Sexo.Name = "CmbBx_Sexo"
        Me.CmbBx_Sexo.Size = New System.Drawing.Size(120, 21)
        Me.CmbBx_Sexo.TabIndex = 4
        '
        'TxtBx_EmailPessoal
        '
        Me.TxtBx_EmailPessoal.Location = New System.Drawing.Point(11, 65)
        Me.TxtBx_EmailPessoal.Name = "TxtBx_EmailPessoal"
        Me.TxtBx_EmailPessoal.Size = New System.Drawing.Size(375, 20)
        Me.TxtBx_EmailPessoal.TabIndex = 3
        '
        'Lbl_EmailPessoal
        '
        Me.Lbl_EmailPessoal.AutoSize = True
        Me.Lbl_EmailPessoal.Location = New System.Drawing.Point(8, 49)
        Me.Lbl_EmailPessoal.Name = "Lbl_EmailPessoal"
        Me.Lbl_EmailPessoal.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_EmailPessoal.TabIndex = 2
        Me.Lbl_EmailPessoal.Text = "E-mail Pessoal"
        '
        'TxtBx_NomeCompleto
        '
        Me.TxtBx_NomeCompleto.Location = New System.Drawing.Point(11, 26)
        Me.TxtBx_NomeCompleto.Name = "TxtBx_NomeCompleto"
        Me.TxtBx_NomeCompleto.Size = New System.Drawing.Size(375, 20)
        Me.TxtBx_NomeCompleto.TabIndex = 1
        '
        'Lbl_NomeCompleto
        '
        Me.Lbl_NomeCompleto.AutoSize = True
        Me.Lbl_NomeCompleto.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_NomeCompleto.Name = "Lbl_NomeCompleto"
        Me.Lbl_NomeCompleto.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_NomeCompleto.TabIndex = 0
        Me.Lbl_NomeCompleto.Text = "Nome Completo"
        '
        'Lbl_DataNascimento
        '
        Me.Lbl_DataNascimento.AutoSize = True
        Me.Lbl_DataNascimento.Location = New System.Drawing.Point(135, 88)
        Me.Lbl_DataNascimento.Name = "Lbl_DataNascimento"
        Me.Lbl_DataNascimento.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_DataNascimento.TabIndex = 6
        Me.Lbl_DataNascimento.Text = "Data de Nascimento"
        '
        'DtTmPckr_DataNascimento
        '
        Me.DtTmPckr_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTmPckr_DataNascimento.Location = New System.Drawing.Point(138, 104)
        Me.DtTmPckr_DataNascimento.Name = "DtTmPckr_DataNascimento"
        Me.DtTmPckr_DataNascimento.Size = New System.Drawing.Size(120, 20)
        Me.DtTmPckr_DataNascimento.TabIndex = 7
        '
        'Lbl_TelefonePessoal
        '
        Me.Lbl_TelefonePessoal.AutoSize = True
        Me.Lbl_TelefonePessoal.Location = New System.Drawing.Point(262, 88)
        Me.Lbl_TelefonePessoal.Name = "Lbl_TelefonePessoal"
        Me.Lbl_TelefonePessoal.Size = New System.Drawing.Size(89, 13)
        Me.Lbl_TelefonePessoal.TabIndex = 8
        Me.Lbl_TelefonePessoal.Text = "Telefone Pessoal"
        '
        'MskdTxtBx_TelefonePessoal
        '
        Me.MskdTxtBx_TelefonePessoal.Location = New System.Drawing.Point(265, 104)
        Me.MskdTxtBx_TelefonePessoal.Mask = "(##) # ####-####"
        Me.MskdTxtBx_TelefonePessoal.Name = "MskdTxtBx_TelefonePessoal"
        Me.MskdTxtBx_TelefonePessoal.Size = New System.Drawing.Size(121, 20)
        Me.MskdTxtBx_TelefonePessoal.TabIndex = 10
        '
        'TbPg_Informacoes_Corporativas
        '
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.DtTmPckr_DataDemissao)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.Lbl_DataDemissao)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.TxtBx_Funcao)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.Lbl_Funcao)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.MskdTxtBx_Chapa)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.Lbl_Chapa)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.DtTmPckr_DataAdmissao)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.Lbl_DataAdmissao)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.TxtBx_Setor)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.Lbl_Setor)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.TxtBx_EmailCorporativo)
        Me.TbPg_Informacoes_Corporativas.Controls.Add(Me.Lbl_EmailCorporativo)
        Me.TbPg_Informacoes_Corporativas.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_Informacoes_Corporativas.Name = "TbPg_Informacoes_Corporativas"
        Me.TbPg_Informacoes_Corporativas.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.TbPg_Informacoes_Corporativas.Size = New System.Drawing.Size(397, 181)
        Me.TbPg_Informacoes_Corporativas.TabIndex = 1
        Me.TbPg_Informacoes_Corporativas.Text = "Informações Corporativas"
        Me.TbPg_Informacoes_Corporativas.UseVisualStyleBackColor = True
        '
        'MskdTxtBx_Chapa
        '
        Me.MskdTxtBx_Chapa.Location = New System.Drawing.Point(12, 143)
        Me.MskdTxtBx_Chapa.Mask = "??? ######"
        Me.MskdTxtBx_Chapa.Name = "MskdTxtBx_Chapa"
        Me.MskdTxtBx_Chapa.Size = New System.Drawing.Size(120, 20)
        Me.MskdTxtBx_Chapa.TabIndex = 10
        '
        'Lbl_Chapa
        '
        Me.Lbl_Chapa.AutoSize = True
        Me.Lbl_Chapa.Location = New System.Drawing.Point(9, 127)
        Me.Lbl_Chapa.Name = "Lbl_Chapa"
        Me.Lbl_Chapa.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Chapa.TabIndex = 8
        Me.Lbl_Chapa.Text = "Chapa"
        '
        'DtTmPckr_DataAdmissao
        '
        Me.DtTmPckr_DataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTmPckr_DataAdmissao.Location = New System.Drawing.Point(138, 143)
        Me.DtTmPckr_DataAdmissao.Name = "DtTmPckr_DataAdmissao"
        Me.DtTmPckr_DataAdmissao.Size = New System.Drawing.Size(120, 20)
        Me.DtTmPckr_DataAdmissao.TabIndex = 7
        '
        'Lbl_DataAdmissao
        '
        Me.Lbl_DataAdmissao.AutoSize = True
        Me.Lbl_DataAdmissao.Location = New System.Drawing.Point(135, 127)
        Me.Lbl_DataAdmissao.Name = "Lbl_DataAdmissao"
        Me.Lbl_DataAdmissao.Size = New System.Drawing.Size(93, 13)
        Me.Lbl_DataAdmissao.TabIndex = 6
        Me.Lbl_DataAdmissao.Text = "Data de Admissão"
        '
        'TxtBx_Setor
        '
        Me.TxtBx_Setor.Location = New System.Drawing.Point(11, 65)
        Me.TxtBx_Setor.Name = "TxtBx_Setor"
        Me.TxtBx_Setor.Size = New System.Drawing.Size(375, 20)
        Me.TxtBx_Setor.TabIndex = 3
        '
        'Lbl_Setor
        '
        Me.Lbl_Setor.AutoSize = True
        Me.Lbl_Setor.Location = New System.Drawing.Point(8, 49)
        Me.Lbl_Setor.Name = "Lbl_Setor"
        Me.Lbl_Setor.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_Setor.TabIndex = 2
        Me.Lbl_Setor.Text = "Setor"
        '
        'TxtBx_EmailCorporativo
        '
        Me.TxtBx_EmailCorporativo.Location = New System.Drawing.Point(11, 26)
        Me.TxtBx_EmailCorporativo.Name = "TxtBx_EmailCorporativo"
        Me.TxtBx_EmailCorporativo.Size = New System.Drawing.Size(375, 20)
        Me.TxtBx_EmailCorporativo.TabIndex = 1
        '
        'Lbl_EmailCorporativo
        '
        Me.Lbl_EmailCorporativo.AutoSize = True
        Me.Lbl_EmailCorporativo.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_EmailCorporativo.Name = "Lbl_EmailCorporativo"
        Me.Lbl_EmailCorporativo.Size = New System.Drawing.Size(92, 13)
        Me.Lbl_EmailCorporativo.TabIndex = 0
        Me.Lbl_EmailCorporativo.Text = "E-mail Corporativo"
        '
        'TxtBx_Funcao
        '
        Me.TxtBx_Funcao.Location = New System.Drawing.Point(12, 104)
        Me.TxtBx_Funcao.Name = "TxtBx_Funcao"
        Me.TxtBx_Funcao.Size = New System.Drawing.Size(374, 20)
        Me.TxtBx_Funcao.TabIndex = 12
        '
        'Lbl_Funcao
        '
        Me.Lbl_Funcao.AutoSize = True
        Me.Lbl_Funcao.Location = New System.Drawing.Point(9, 88)
        Me.Lbl_Funcao.Name = "Lbl_Funcao"
        Me.Lbl_Funcao.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Funcao.TabIndex = 11
        Me.Lbl_Funcao.Text = "Função"
        '
        'DtTmPckr_DataDemissao
        '
        Me.DtTmPckr_DataDemissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTmPckr_DataDemissao.Location = New System.Drawing.Point(266, 143)
        Me.DtTmPckr_DataDemissao.Name = "DtTmPckr_DataDemissao"
        Me.DtTmPckr_DataDemissao.Size = New System.Drawing.Size(120, 20)
        Me.DtTmPckr_DataDemissao.TabIndex = 14
        '
        'Lbl_DataDemissao
        '
        Me.Lbl_DataDemissao.AutoSize = True
        Me.Lbl_DataDemissao.Location = New System.Drawing.Point(264, 127)
        Me.Lbl_DataDemissao.Name = "Lbl_DataDemissao"
        Me.Lbl_DataDemissao.Size = New System.Drawing.Size(94, 13)
        Me.Lbl_DataDemissao.TabIndex = 13
        Me.Lbl_DataDemissao.Text = "Data de Demissão"
        '
        'Frm_Cadastro_Colaborador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(435, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pnl_Dados_Colaborador)
        Me.Controls.Add(Me.Pnl_BotoesAcao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Cadastro_Colaborador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colaborador"
        Me.Pnl_BotoesAcao.ResumeLayout(False)
        Me.Pnl_Dados_Colaborador.ResumeLayout(False)
        Me.TbCntrl_Dados_Colaborador.ResumeLayout(False)
        Me.TbPg_Informacoes_Pessoais.ResumeLayout(False)
        Me.TbPg_Informacoes_Pessoais.PerformLayout()
        Me.TbPg_Informacoes_Corporativas.ResumeLayout(False)
        Me.TbPg_Informacoes_Corporativas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_BotoesAcao As Panel
    Friend WithEvents Bttn_Cancelar As Button
    Friend WithEvents Bttn_Excluir As Button
    Friend WithEvents Bttn_Limpar As Button
    Friend WithEvents Bttn_Executar As Button
    Friend WithEvents Pnl_Dados_Colaborador As Panel
    Friend WithEvents TbCntrl_Dados_Colaborador As TabControl
    Friend WithEvents TbPg_Informacoes_Pessoais As TabPage
    Friend WithEvents TxtBx_NomeCompleto As TextBox
    Friend WithEvents Lbl_NomeCompleto As Label
    Friend WithEvents TxtBx_EmailPessoal As TextBox
    Friend WithEvents Lbl_EmailPessoal As Label
    Friend WithEvents Lbl_Sexo As Label
    Friend WithEvents CmbBx_Sexo As ComboBox
    Friend WithEvents DtTmPckr_DataNascimento As DateTimePicker
    Friend WithEvents Lbl_DataNascimento As Label
    Friend WithEvents MskdTxtBx_TelefonePessoal As MaskedTextBox
    Friend WithEvents Lbl_TelefonePessoal As Label
    Friend WithEvents TbPg_Informacoes_Corporativas As TabPage
    Friend WithEvents DtTmPckr_DataDemissao As DateTimePicker
    Friend WithEvents Lbl_DataDemissao As Label
    Friend WithEvents TxtBx_Funcao As TextBox
    Friend WithEvents Lbl_Funcao As Label
    Friend WithEvents MskdTxtBx_Chapa As MaskedTextBox
    Friend WithEvents Lbl_Chapa As Label
    Friend WithEvents DtTmPckr_DataAdmissao As DateTimePicker
    Friend WithEvents Lbl_DataAdmissao As Label
    Friend WithEvents TxtBx_Setor As TextBox
    Friend WithEvents Lbl_Setor As Label
    Friend WithEvents TxtBx_EmailCorporativo As TextBox
    Friend WithEvents Lbl_EmailCorporativo As Label
End Class
