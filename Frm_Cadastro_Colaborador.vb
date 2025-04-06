Imports Facilita_DP___Módulo_Rescisão.Tabelas

Public Class Frm_Cadastro_Colaborador

    Public ColaboradorAtual As Colaborador
    Private ModoAtual As String

    Public Sub AtivarModoFormulario(Optional modo As String = Modo_Cadastro)
        ModoAtual = modo
    End Sub

    Public Sub Informar_Colaborador()
        ColaboradorAtual = New Colaborador
    End Sub

    Public Sub Informar_Colaborador(colaboradorSelecionado As Colaborador)
        ColaboradorAtual = colaboradorSelecionado
    End Sub

    Private Sub InicializarFormulario()

        Call Configurar_Datas()
        Call RecuperarDados_Colaborador()
        Call Configurar_VisualizacaoBotoesAcao()
        Call Configurar_BotaoExecutacao()
        Call Configurar_NomeFormulario

    End Sub

    Private Sub Configurar_NomeFormulario()

        Select Case ModoAtual
            Case Modo_Cadastro
                Call AlterarnomeFormulario(Me, "Colaborador", "Cadastro")
            Case Modo_Edicao
                Call AlterarnomeFormulario(Me, "Colaborador", "Edição")
            Case Modo_Exclusao
                Call AlterarnomeFormulario(Me, "Colaborador", "Exclusão")
            Case Modo_Visualizacao
                Call AlterarnomeFormulario(Me, "Colaborador", "Visualização")
        End Select

    End Sub

    Private Sub Configurar_Datas()

        With Me

            .DtTmPckr_DataNascimento.MaxDate = DateAdd(DateInterval.Day, -6570, Date.Today)
            .DtTmPckr_DataNascimento.Value = DateAdd(DateInterval.Day, -6570, Date.Today)

            .DtTmPckr_DataAdmissao.MaxDate = Date.Today
            .DtTmPckr_DataAdmissao.Value = Date.Today

        End With

    End Sub

    Private Sub Configurar_VisualizacaoBotoesAcao()

        Select Case ModoAtual

            Case Modo_Cadastro
                Bttn_Executar.Visible = True
                Bttn_Excluir.Visible = False
                Bttn_Limpar.Visible = True
                Call Configurar_StatusCampos(True)

            Case Modo_Edicao
                Bttn_Executar.Visible = True
                Bttn_Excluir.Visible = False
                Bttn_Limpar.Visible = True
                Call Configurar_StatusCampos(True)

            Case Modo_Exclusao
                Bttn_Executar.Visible = False
                Bttn_Excluir.Visible = True
                Bttn_Limpar.Visible = False
                Call Configurar_StatusCampos(False)

            Case Modo_Visualizacao
                Bttn_Executar.Visible = False
                Bttn_Excluir.Visible = False
                Bttn_Limpar.Visible = False
                Call Configurar_StatusCampos(False)

        End Select

    End Sub

    Private Sub Configurar_BotaoExecutacao()

        Select Case ModoAtual

            Case Modo_Cadastro
                Bttn_Executar.Text = "Adicionar"

            Case Modo_Edicao
                Bttn_Executar.Text = "Atualizar"

        End Select

    End Sub

    Private Sub FinalizarFormulario(Optional Status As DialogResult = DialogResult.Cancel)

        With Me

            .DialogResult = Status
            .Close()

        End With

    End Sub

    Private Sub LimparFormulario()

        With Me

            .TxtBx_NomeCompleto.Clear()
            .TxtBx_EmailPessoal.Clear()
            .CmbBx_Sexo.SelectedIndex = -1
            .DtTmPckr_DataNascimento.Value = DateAdd(DateInterval.Day, -6570, Date.Today)
            .MskdTxtBx_TelefonePessoal.Clear()
            .MskdTxtBx_CPF.Clear()
            .MskdTxtBx_RG.Clear()
            .TxtBx_EmailCorporativo.Clear()
            .TxtBx_Setor.Clear()
            .TxtBx_Funcao.Clear()
            .MskdTxtBx_Chapa.Clear()
            .DtTmPckr_DataAdmissao.Value = Date.Today
            .ChckBx_Demitido.Checked = False
            .ChckBx_Demitido.Visible = False
            .DtTmPckr_DataDemissao.Visible = False
            .Lbl_DataDemissao.Visible = False
            .DtTmPckr_DataDemissao.Value = Date.Today

        End With

    End Sub

    Private Sub Configurar_StatusCampos(Status As Boolean)

        With Me

            .TxtBx_NomeCompleto.Enabled = Status
            .TxtBx_EmailPessoal.Enabled = Status
            .CmbBx_Sexo.Enabled = Status
            .DtTmPckr_DataNascimento.Enabled = Status
            .MskdTxtBx_TelefonePessoal.Enabled = Status
            .MskdTxtBx_CPF.Enabled = Status
            .MskdTxtBx_RG.Enabled = Status
            .TxtBx_EmailCorporativo.Enabled = Status
            .TxtBx_Setor.Enabled = Status
            .TxtBx_Funcao.Enabled = Status
            .MskdTxtBx_Chapa.Enabled = Status
            .DtTmPckr_DataAdmissao.Enabled = Status
            .ChckBx_Demitido.Enabled = Status
            .ChckBx_Demitido.Enabled = Status
            .DtTmPckr_DataDemissao.Enabled = Status
            .Lbl_DataDemissao.Enabled = Status
            .DtTmPckr_DataDemissao.Enabled = Status
            .ChckBx_Demitido.Enabled = Status
            .DtTmPckr_DataDemissao.Enabled = Status

        End With

    End Sub

    Private Sub RecuperarDados_Colaborador()

        With Me

            .TxtBx_NomeCompleto.Text = ColaboradorAtual.NomeCompleto
            .TxtBx_EmailPessoal.Text = ColaboradorAtual.EmailPessoal
            .CmbBx_Sexo.SelectedItem = ColaboradorAtual.Sexo

            If Not String.IsNullOrEmpty(ColaboradorAtual.DataNascimento) Then

                If ModoAtual = Modo_Cadastro Then
                    .DtTmPckr_DataNascimento.Value = DateAdd(DateInterval.Day, -6570, Date.Today)
                Else
                    .DtTmPckr_DataNascimento.Value = ColaboradorAtual.DataNascimento
                End If

            End If

            .MskdTxtBx_TelefonePessoal.Text = ColaboradorAtual.TelefonePessoal
            .MskdTxtBx_CPF.Text = ColaboradorAtual.CPF
            .MskdTxtBx_RG.Text = ColaboradorAtual.RG
            .TxtBx_EmailCorporativo.Text = ColaboradorAtual.EmailCorporativo
            .TxtBx_Setor.Text = ColaboradorAtual.Setor
            .TxtBx_Funcao.Text = ColaboradorAtual.Funcao
            .MskdTxtBx_Chapa.Text = ColaboradorAtual.Chapa

            If Not String.IsNullOrEmpty(ColaboradorAtual.DataAdmissao) Then

                If ModoAtual = Modo_Cadastro Then
                    .DtTmPckr_DataAdmissao.Value = Date.Today
                Else
                    .DtTmPckr_DataAdmissao.Value = ColaboradorAtual.DataAdmissao
                End If


            End If

            If ColaboradorAtual.Demitido = True Then

                .DtTmPckr_DataDemissao.Value = ColaboradorAtual.DataDemissao
                .ChckBx_Demitido.Checked = True

                .ChckBx_Demitido.Visible = True
                .DtTmPckr_DataDemissao.Visible = True
                .Lbl_DataDemissao.Visible = True

            End If

        End With

    End Sub

    Private Sub RegistrarDados_Colaborador()

        With ColaboradorAtual

            .NomeCompleto = Me.TxtBx_NomeCompleto.Text
            .EmailPessoal = Me.TxtBx_EmailPessoal.Text
            .Sexo = Me.CmbBx_Sexo.Text

            If Not String.IsNullOrEmpty(Me.DtTmPckr_DataNascimento.Value.ToString) Then
                .DataNascimento = Me.DtTmPckr_DataNascimento.Value
            End If

            .TelefonePessoal = Me.MskdTxtBx_TelefonePessoal.Text
            .CPF = Me.MskdTxtBx_CPF.Text
            .RG = Me.MskdTxtBx_RG.Text
            .EmailCorporativo = Me.TxtBx_EmailCorporativo.Text
            .Setor = Me.TxtBx_Setor.Text
            .Funcao = Me.TxtBx_Funcao.Text
            .Chapa = Me.MskdTxtBx_Chapa.Text

            If Not String.IsNullOrEmpty(Me.DtTmPckr_DataAdmissao.Value.ToString) Then
                .DataAdmissao = Me.DtTmPckr_DataAdmissao.Value
            End If

            .Demitido = ChckBx_Demitido.Checked

            If ChckBx_Demitido.Checked Then
                .DataDemissao = DtTmPckr_DataDemissao.Value
            Else
                .DataDemissao = Nothing
            End If

            If ModoAtual = Modo_Cadastro Then
                .Status = "Ativo"
            End If

        End With

    End Sub

    Private Function CamposPreenchidos() As Boolean

        ' Informações Pessoais
        If Not VerificarObrigatorio(TxtBx_NomeCompleto, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Pessoais) Then Return False
        If Not VerificarObrigatorio(TxtBx_EmailPessoal, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Pessoais) Then Return False
        If Not EmailValido(TxtBx_EmailPessoal, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Pessoais, TxtBx_EmailPessoal.Tag) Then Return False
        If Not VerificarObrigatorio(CmbBx_Sexo, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Pessoais) Then Return False
        If Not VerificarObrigatorio(MskdTxtBx_TelefonePessoal, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Pessoais) Then Return False
        If Not VerificarObrigatorio(MskdTxtBx_CPF, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Pessoais) Then Return False
        If Not VerificarObrigatorio(MskdTxtBx_RG, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Pessoais) Then Return False

        ' Validação de data de nascimento
        If DtTmPckr_DataNascimento.Value = DateAdd(DateInterval.Day, -6570, Date.Today) Then
            If MessageBox.Show("A Data de Nascimento está correta?", "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MessageBox.Show("Corrija o valor da Data de Nascimento, por gentileza.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TbCntrl_Dados_Colaborador.SelectedTab = TbPg_Informacoes_Pessoais
                DtTmPckr_DataNascimento.Focus()
                Return False
            End If
        End If

        ' Informações Corporativas
        If Not VerificarObrigatorio(TxtBx_EmailCorporativo, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Corporativas) Then Return False
        If Not EmailValido(TxtBx_EmailCorporativo, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Corporativas, TxtBx_EmailCorporativo.Tag) Then Return False
        If Not VerificarObrigatorio(TxtBx_Setor, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Corporativas) Then Return False
        If Not VerificarObrigatorio(TxtBx_Funcao, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Corporativas) Then Return False
        If Not VerificarObrigatorio(MskdTxtBx_Chapa, TbCntrl_Dados_Colaborador, TbPg_Informacoes_Corporativas) Then Return False

        ' Validação de data de admissão
        If DtTmPckr_DataAdmissao.Value = DateAdd(DateInterval.Day, -6570, Date.Today) Then
            If MessageBox.Show("A Data de Admissão está correta?", "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MessageBox.Show("Corrija o valor da Data de Admissão, por gentileza.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TbCntrl_Dados_Colaborador.SelectedTab = TbPg_Informacoes_Corporativas
                DtTmPckr_DataAdmissao.Focus()
                Return False
            End If
        End If

        ' Validação de demissão (caso marcado como demitido)
        If ChckBx_Demitido.Checked AndAlso DtTmPckr_DataDemissao.Value = Date.Today Then
            If MessageBox.Show("A Data de Demissão está correta?", "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                MessageBox.Show("Corrija o valor da Data de Demissão, por gentileza.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TbCntrl_Dados_Colaborador.SelectedTab = TbPg_Informacoes_Corporativas
                DtTmPckr_DataDemissao.Focus()
                Return False
            End If
        End If

        Return True
    End Function


    Private Sub Executar()

        If CamposPreenchidos() = False Then Exit Sub

        Call RegistrarDados_Colaborador()

        Select Case ModoAtual
            Case Modo_Cadastro
                If Colaborador_Adicionar(ColaboradorAtual) Then
                    MessageBox.Show("Colaborador cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call FinalizarFormulario(DialogResult.OK)
                End If
            Case Modo_Edicao
                If Colaborador_Atualizar(ColaboradorAtual) Then
                    MessageBox.Show("Colaborador atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call FinalizarFormulario(DialogResult.OK)
                End If
        End Select

    End Sub

    Private Sub Bttn_Executar_Click(sender As Object, e As EventArgs) Handles Bttn_Executar.Click

        Call Executar()

    End Sub

    Private Sub Bttn_Limpar_Click(sender As Object, e As EventArgs) Handles Bttn_Limpar.Click

        Call LimparFormulario()

    End Sub

    Private Sub Bttn_Excluir_Click(sender As Object, e As EventArgs) Handles Bttn_Excluir.Click

        If Colaborador_Excluir(ColaboradorAtual.Id) Then

            MessageBox.Show("Colaborador excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FinalizarFormulario(DialogResult.OK)

        End If

    End Sub

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

        Call FinalizarFormulario()

    End Sub

    Private Sub Frm_Cadastro_Colaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call InicializarFormulario()

    End Sub

    Private Sub MskdTxtBx_Chapa_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskdTxtBx_Chapa.MaskInputRejected

        MskdTxtBx_Chapa.Text = MskdTxtBx_Chapa.Text.ToUpper

    End Sub

End Class