<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Cadastro_ClinicaAutorizada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cadastro_ClinicaAutorizada))
        Me.Pnl_BotoesAcao = New System.Windows.Forms.Panel()
        Me.Bttn_Excluir = New System.Windows.Forms.Button()
        Me.Bttn_Limpar = New System.Windows.Forms.Button()
        Me.Bttn_Cancelar = New System.Windows.Forms.Button()
        Me.Bttn_Executar = New System.Windows.Forms.Button()
        Me.Pnl_Dados_ClinicaAutorizada = New System.Windows.Forms.Panel()
        Me.TbCntrl_Dados_ClinicaAutorizada = New System.Windows.Forms.TabControl()
        Me.TbPg_Informacoes_ClinicaAutorizada = New System.Windows.Forms.TabPage()
        Me.MskdTxtBx_Fixo = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_Fixo = New System.Windows.Forms.Label()
        Me.MskdTxtBx_Telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_Telefone = New System.Windows.Forms.Label()
        Me.TxtBx_EmailAtendimento = New System.Windows.Forms.TextBox()
        Me.Lbl_EmailAtendimento = New System.Windows.Forms.Label()
        Me.TxtBx_NomeAtendente = New System.Windows.Forms.TextBox()
        Me.Lbl_NomeAtendente = New System.Windows.Forms.Label()
        Me.TxtBx_RazaoSocial = New System.Windows.Forms.TextBox()
        Me.Lbl_RazaoSocial = New System.Windows.Forms.Label()
        Me.TbPg_Informacoes_Endereco = New System.Windows.Forms.TabPage()
        Me.TxtBx_Endereco_Estado = New System.Windows.Forms.TextBox()
        Me.Lbl_Estado = New System.Windows.Forms.Label()
        Me.TxtBx_Endereco_Cidade = New System.Windows.Forms.TextBox()
        Me.Lbl_Cidade = New System.Windows.Forms.Label()
        Me.TxtBx_Endereco_Bairro = New System.Windows.Forms.TextBox()
        Me.Lbl_Bairro = New System.Windows.Forms.Label()
        Me.TxtBx_Endereco_Numero = New System.Windows.Forms.TextBox()
        Me.Lbl_Numero = New System.Windows.Forms.Label()
        Me.TxtBx_Endereco_Logradouro = New System.Windows.Forms.TextBox()
        Me.Lbl_Logradouro = New System.Windows.Forms.Label()
        Me.Bttn_Pesquisar = New System.Windows.Forms.Button()
        Me.MskdTxtBx_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_CEP = New System.Windows.Forms.Label()
        Me.Pnl_BotoesAcao.SuspendLayout()
        Me.Pnl_Dados_ClinicaAutorizada.SuspendLayout()
        Me.TbCntrl_Dados_ClinicaAutorizada.SuspendLayout()
        Me.TbPg_Informacoes_ClinicaAutorizada.SuspendLayout()
        Me.TbPg_Informacoes_Endereco.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_BotoesAcao
        '
        Me.Pnl_BotoesAcao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Excluir)
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Limpar)
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Cancelar)
        Me.Pnl_BotoesAcao.Controls.Add(Me.Bttn_Executar)
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
        'Bttn_Executar
        '
        Me.Bttn_Executar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Executar.Location = New System.Drawing.Point(320, 15)
        Me.Bttn_Executar.Name = "Bttn_Executar"
        Me.Bttn_Executar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Executar.TabIndex = 0
        Me.Bttn_Executar.Text = "Executar"
        Me.Bttn_Executar.UseVisualStyleBackColor = True
        '
        'Pnl_Dados_ClinicaAutorizada
        '
        Me.Pnl_Dados_ClinicaAutorizada.Controls.Add(Me.TbCntrl_Dados_ClinicaAutorizada)
        Me.Pnl_Dados_ClinicaAutorizada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Dados_ClinicaAutorizada.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Dados_ClinicaAutorizada.Name = "Pnl_Dados_ClinicaAutorizada"
        Me.Pnl_Dados_ClinicaAutorizada.Padding = New System.Windows.Forms.Padding(15)
        Me.Pnl_Dados_ClinicaAutorizada.Size = New System.Drawing.Size(435, 237)
        Me.Pnl_Dados_ClinicaAutorizada.TabIndex = 1
        '
        'TbCntrl_Dados_ClinicaAutorizada
        '
        Me.TbCntrl_Dados_ClinicaAutorizada.Controls.Add(Me.TbPg_Informacoes_ClinicaAutorizada)
        Me.TbCntrl_Dados_ClinicaAutorizada.Controls.Add(Me.TbPg_Informacoes_Endereco)
        Me.TbCntrl_Dados_ClinicaAutorizada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbCntrl_Dados_ClinicaAutorizada.Location = New System.Drawing.Point(15, 15)
        Me.TbCntrl_Dados_ClinicaAutorizada.Name = "TbCntrl_Dados_ClinicaAutorizada"
        Me.TbCntrl_Dados_ClinicaAutorizada.SelectedIndex = 0
        Me.TbCntrl_Dados_ClinicaAutorizada.Size = New System.Drawing.Size(405, 207)
        Me.TbCntrl_Dados_ClinicaAutorizada.TabIndex = 0
        '
        'TbPg_Informacoes_ClinicaAutorizada
        '
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.MskdTxtBx_Fixo)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.Lbl_Fixo)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.MskdTxtBx_Telefone)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.Lbl_Telefone)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.TxtBx_EmailAtendimento)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.Lbl_EmailAtendimento)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.TxtBx_NomeAtendente)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.Lbl_NomeAtendente)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.TxtBx_RazaoSocial)
        Me.TbPg_Informacoes_ClinicaAutorizada.Controls.Add(Me.Lbl_RazaoSocial)
        Me.TbPg_Informacoes_ClinicaAutorizada.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_Informacoes_ClinicaAutorizada.Name = "TbPg_Informacoes_ClinicaAutorizada"
        Me.TbPg_Informacoes_ClinicaAutorizada.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.TbPg_Informacoes_ClinicaAutorizada.Size = New System.Drawing.Size(397, 181)
        Me.TbPg_Informacoes_ClinicaAutorizada.TabIndex = 0
        Me.TbPg_Informacoes_ClinicaAutorizada.Text = "Informações Clínica Autorizada"
        Me.TbPg_Informacoes_ClinicaAutorizada.UseVisualStyleBackColor = True
        '
        'MskdTxtBx_Fixo
        '
        Me.MskdTxtBx_Fixo.Location = New System.Drawing.Point(138, 143)
        Me.MskdTxtBx_Fixo.Mask = "(##) ####-####"
        Me.MskdTxtBx_Fixo.Name = "MskdTxtBx_Fixo"
        Me.MskdTxtBx_Fixo.Size = New System.Drawing.Size(121, 20)
        Me.MskdTxtBx_Fixo.TabIndex = 14
        Me.MskdTxtBx_Fixo.Tag = "Fixo"
        '
        'Lbl_Fixo
        '
        Me.Lbl_Fixo.AutoSize = True
        Me.Lbl_Fixo.Location = New System.Drawing.Point(135, 127)
        Me.Lbl_Fixo.Name = "Lbl_Fixo"
        Me.Lbl_Fixo.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Fixo.TabIndex = 13
        Me.Lbl_Fixo.Text = "Fixo"
        '
        'MskdTxtBx_Telefone
        '
        Me.MskdTxtBx_Telefone.Location = New System.Drawing.Point(11, 143)
        Me.MskdTxtBx_Telefone.Mask = "(##) # ####-####"
        Me.MskdTxtBx_Telefone.Name = "MskdTxtBx_Telefone"
        Me.MskdTxtBx_Telefone.Size = New System.Drawing.Size(121, 20)
        Me.MskdTxtBx_Telefone.TabIndex = 12
        Me.MskdTxtBx_Telefone.Tag = "Telefone"
        '
        'Lbl_Telefone
        '
        Me.Lbl_Telefone.AutoSize = True
        Me.Lbl_Telefone.Location = New System.Drawing.Point(8, 127)
        Me.Lbl_Telefone.Name = "Lbl_Telefone"
        Me.Lbl_Telefone.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Telefone.TabIndex = 11
        Me.Lbl_Telefone.Text = "Telefone"
        '
        'TxtBx_EmailAtendimento
        '
        Me.TxtBx_EmailAtendimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBx_EmailAtendimento.Location = New System.Drawing.Point(11, 104)
        Me.TxtBx_EmailAtendimento.Name = "TxtBx_EmailAtendimento"
        Me.TxtBx_EmailAtendimento.Size = New System.Drawing.Size(375, 20)
        Me.TxtBx_EmailAtendimento.TabIndex = 5
        Me.TxtBx_EmailAtendimento.Tag = "E-mail Atendimento"
        '
        'Lbl_EmailAtendimento
        '
        Me.Lbl_EmailAtendimento.AutoSize = True
        Me.Lbl_EmailAtendimento.Location = New System.Drawing.Point(8, 88)
        Me.Lbl_EmailAtendimento.Name = "Lbl_EmailAtendimento"
        Me.Lbl_EmailAtendimento.Size = New System.Drawing.Size(97, 13)
        Me.Lbl_EmailAtendimento.TabIndex = 4
        Me.Lbl_EmailAtendimento.Text = "E-mail Atendimento"
        '
        'TxtBx_NomeAtendente
        '
        Me.TxtBx_NomeAtendente.Location = New System.Drawing.Point(11, 65)
        Me.TxtBx_NomeAtendente.Name = "TxtBx_NomeAtendente"
        Me.TxtBx_NomeAtendente.Size = New System.Drawing.Size(375, 20)
        Me.TxtBx_NomeAtendente.TabIndex = 3
        Me.TxtBx_NomeAtendente.Tag = "Nome Atendente"
        '
        'Lbl_NomeAtendente
        '
        Me.Lbl_NomeAtendente.AutoSize = True
        Me.Lbl_NomeAtendente.Location = New System.Drawing.Point(8, 49)
        Me.Lbl_NomeAtendente.Name = "Lbl_NomeAtendente"
        Me.Lbl_NomeAtendente.Size = New System.Drawing.Size(87, 13)
        Me.Lbl_NomeAtendente.TabIndex = 2
        Me.Lbl_NomeAtendente.Text = "Nome Atendente"
        '
        'TxtBx_RazaoSocial
        '
        Me.TxtBx_RazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBx_RazaoSocial.Location = New System.Drawing.Point(11, 26)
        Me.TxtBx_RazaoSocial.Name = "TxtBx_RazaoSocial"
        Me.TxtBx_RazaoSocial.Size = New System.Drawing.Size(375, 20)
        Me.TxtBx_RazaoSocial.TabIndex = 1
        Me.TxtBx_RazaoSocial.Tag = "Razão Social"
        '
        'Lbl_RazaoSocial
        '
        Me.Lbl_RazaoSocial.AutoSize = True
        Me.Lbl_RazaoSocial.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_RazaoSocial.Name = "Lbl_RazaoSocial"
        Me.Lbl_RazaoSocial.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_RazaoSocial.TabIndex = 0
        Me.Lbl_RazaoSocial.Text = "Razão Social"
        '
        'TbPg_Informacoes_Endereco
        '
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.TxtBx_Endereco_Estado)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.Lbl_Estado)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.TxtBx_Endereco_Cidade)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.Lbl_Cidade)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.TxtBx_Endereco_Bairro)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.Lbl_Bairro)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.TxtBx_Endereco_Numero)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.Lbl_Numero)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.TxtBx_Endereco_Logradouro)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.Lbl_Logradouro)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.Bttn_Pesquisar)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.MskdTxtBx_CEP)
        Me.TbPg_Informacoes_Endereco.Controls.Add(Me.Lbl_CEP)
        Me.TbPg_Informacoes_Endereco.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_Informacoes_Endereco.Name = "TbPg_Informacoes_Endereco"
        Me.TbPg_Informacoes_Endereco.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.TbPg_Informacoes_Endereco.Size = New System.Drawing.Size(397, 181)
        Me.TbPg_Informacoes_Endereco.TabIndex = 1
        Me.TbPg_Informacoes_Endereco.Text = "Informações Endereço"
        Me.TbPg_Informacoes_Endereco.UseVisualStyleBackColor = True
        '
        'TxtBx_Endereco_Estado
        '
        Me.TxtBx_Endereco_Estado.Enabled = False
        Me.TxtBx_Endereco_Estado.Location = New System.Drawing.Point(268, 143)
        Me.TxtBx_Endereco_Estado.Name = "TxtBx_Endereco_Estado"
        Me.TxtBx_Endereco_Estado.Size = New System.Drawing.Size(120, 20)
        Me.TxtBx_Endereco_Estado.TabIndex = 25
        Me.TxtBx_Endereco_Estado.Tag = "Estado"
        '
        'Lbl_Estado
        '
        Me.Lbl_Estado.AutoSize = True
        Me.Lbl_Estado.Location = New System.Drawing.Point(266, 127)
        Me.Lbl_Estado.Name = "Lbl_Estado"
        Me.Lbl_Estado.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Estado.TabIndex = 24
        Me.Lbl_Estado.Text = "Estado"
        '
        'TxtBx_Endereco_Cidade
        '
        Me.TxtBx_Endereco_Cidade.Enabled = False
        Me.TxtBx_Endereco_Cidade.Location = New System.Drawing.Point(13, 143)
        Me.TxtBx_Endereco_Cidade.Name = "TxtBx_Endereco_Cidade"
        Me.TxtBx_Endereco_Cidade.Size = New System.Drawing.Size(249, 20)
        Me.TxtBx_Endereco_Cidade.TabIndex = 23
        Me.TxtBx_Endereco_Cidade.Tag = "Cidade"
        '
        'Lbl_Cidade
        '
        Me.Lbl_Cidade.AutoSize = True
        Me.Lbl_Cidade.Location = New System.Drawing.Point(10, 127)
        Me.Lbl_Cidade.Name = "Lbl_Cidade"
        Me.Lbl_Cidade.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Cidade.TabIndex = 22
        Me.Lbl_Cidade.Text = "Cidade"
        '
        'TxtBx_Endereco_Bairro
        '
        Me.TxtBx_Endereco_Bairro.Enabled = False
        Me.TxtBx_Endereco_Bairro.Location = New System.Drawing.Point(13, 104)
        Me.TxtBx_Endereco_Bairro.Name = "TxtBx_Endereco_Bairro"
        Me.TxtBx_Endereco_Bairro.Size = New System.Drawing.Size(375, 20)
        Me.TxtBx_Endereco_Bairro.TabIndex = 21
        Me.TxtBx_Endereco_Bairro.Tag = "Bairro"
        '
        'Lbl_Bairro
        '
        Me.Lbl_Bairro.AutoSize = True
        Me.Lbl_Bairro.Location = New System.Drawing.Point(10, 88)
        Me.Lbl_Bairro.Name = "Lbl_Bairro"
        Me.Lbl_Bairro.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_Bairro.TabIndex = 20
        Me.Lbl_Bairro.Text = "Bairro"
        '
        'TxtBx_Endereco_Numero
        '
        Me.TxtBx_Endereco_Numero.Location = New System.Drawing.Point(268, 65)
        Me.TxtBx_Endereco_Numero.Name = "TxtBx_Endereco_Numero"
        Me.TxtBx_Endereco_Numero.Size = New System.Drawing.Size(120, 20)
        Me.TxtBx_Endereco_Numero.TabIndex = 19
        Me.TxtBx_Endereco_Numero.Tag = "Número"
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.AutoSize = True
        Me.Lbl_Numero.Location = New System.Drawing.Point(262, 49)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Numero.TabIndex = 18
        Me.Lbl_Numero.Text = "Número"
        '
        'TxtBx_Endereco_Logradouro
        '
        Me.TxtBx_Endereco_Logradouro.Enabled = False
        Me.TxtBx_Endereco_Logradouro.Location = New System.Drawing.Point(11, 65)
        Me.TxtBx_Endereco_Logradouro.Name = "TxtBx_Endereco_Logradouro"
        Me.TxtBx_Endereco_Logradouro.Size = New System.Drawing.Size(251, 20)
        Me.TxtBx_Endereco_Logradouro.TabIndex = 17
        Me.TxtBx_Endereco_Logradouro.Tag = "Logradouro"
        '
        'Lbl_Logradouro
        '
        Me.Lbl_Logradouro.AutoSize = True
        Me.Lbl_Logradouro.Location = New System.Drawing.Point(8, 49)
        Me.Lbl_Logradouro.Name = "Lbl_Logradouro"
        Me.Lbl_Logradouro.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_Logradouro.TabIndex = 16
        Me.Lbl_Logradouro.Text = "Logradouro"
        '
        'Bttn_Pesquisar
        '
        Me.Bttn_Pesquisar.Location = New System.Drawing.Point(138, 13)
        Me.Bttn_Pesquisar.Name = "Bttn_Pesquisar"
        Me.Bttn_Pesquisar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Pesquisar.TabIndex = 15
        Me.Bttn_Pesquisar.Text = "Pesquisar"
        Me.Bttn_Pesquisar.UseVisualStyleBackColor = True
        '
        'MskdTxtBx_CEP
        '
        Me.MskdTxtBx_CEP.Location = New System.Drawing.Point(11, 26)
        Me.MskdTxtBx_CEP.Mask = "#####-###"
        Me.MskdTxtBx_CEP.Name = "MskdTxtBx_CEP"
        Me.MskdTxtBx_CEP.Size = New System.Drawing.Size(121, 20)
        Me.MskdTxtBx_CEP.TabIndex = 14
        Me.MskdTxtBx_CEP.Tag = "CEP"
        '
        'Lbl_CEP
        '
        Me.Lbl_CEP.AutoSize = True
        Me.Lbl_CEP.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_CEP.Name = "Lbl_CEP"
        Me.Lbl_CEP.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_CEP.TabIndex = 13
        Me.Lbl_CEP.Text = "CEP"
        '
        'Frm_Cadastro_ClinicaAutorizada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(435, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pnl_Dados_ClinicaAutorizada)
        Me.Controls.Add(Me.Pnl_BotoesAcao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Cadastro_ClinicaAutorizada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clínica Autorizada"
        Me.Pnl_BotoesAcao.ResumeLayout(False)
        Me.Pnl_Dados_ClinicaAutorizada.ResumeLayout(False)
        Me.TbCntrl_Dados_ClinicaAutorizada.ResumeLayout(False)
        Me.TbPg_Informacoes_ClinicaAutorizada.ResumeLayout(False)
        Me.TbPg_Informacoes_ClinicaAutorizada.PerformLayout()
        Me.TbPg_Informacoes_Endereco.ResumeLayout(False)
        Me.TbPg_Informacoes_Endereco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_BotoesAcao As Panel
    Friend WithEvents Bttn_Excluir As Button
    Friend WithEvents Bttn_Limpar As Button
    Friend WithEvents Bttn_Cancelar As Button
    Friend WithEvents Bttn_Executar As Button
    Friend WithEvents Pnl_Dados_ClinicaAutorizada As Panel
    Friend WithEvents TbCntrl_Dados_ClinicaAutorizada As TabControl
    Friend WithEvents TbPg_Informacoes_ClinicaAutorizada As TabPage
    Friend WithEvents Lbl_RazaoSocial As Label
    Friend WithEvents TxtBx_EmailAtendimento As TextBox
    Friend WithEvents Lbl_EmailAtendimento As Label
    Friend WithEvents TxtBx_NomeAtendente As TextBox
    Friend WithEvents Lbl_NomeAtendente As Label
    Friend WithEvents TxtBx_RazaoSocial As TextBox
    Friend WithEvents MskdTxtBx_Fixo As MaskedTextBox
    Friend WithEvents Lbl_Fixo As Label
    Friend WithEvents MskdTxtBx_Telefone As MaskedTextBox
    Friend WithEvents Lbl_Telefone As Label
    Friend WithEvents TbPg_Informacoes_Endereco As TabPage
    Friend WithEvents Bttn_Pesquisar As Button
    Friend WithEvents MskdTxtBx_CEP As MaskedTextBox
    Friend WithEvents Lbl_CEP As Label
    Friend WithEvents TxtBx_Endereco_Logradouro As TextBox
    Friend WithEvents Lbl_Logradouro As Label
    Friend WithEvents Lbl_Estado As Label
    Friend WithEvents TxtBx_Endereco_Cidade As TextBox
    Friend WithEvents Lbl_Cidade As Label
    Friend WithEvents TxtBx_Endereco_Bairro As TextBox
    Friend WithEvents Lbl_Bairro As Label
    Friend WithEvents TxtBx_Endereco_Numero As TextBox
    Friend WithEvents Lbl_Numero As Label
    Friend WithEvents TxtBx_Endereco_Estado As TextBox
End Class
