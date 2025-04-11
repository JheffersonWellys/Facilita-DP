Imports Facilita_DP___Módulo_Rescisão.Tabelas
Imports Newtonsoft.Json.Linq

Public Class Frm_Cadastro_ClinicaAutorizada

    Public ClinicaAutorizadaAtual As ClinicaAutorizada
    Private EnderecoAtual As Endereco
    Private ModoAtual As String

    Public Sub AtivarModoFormulario(Optional modo As String = Modo_Cadastro)
        ModoAtual = modo
    End Sub

    Public Sub Informar_ClinicaAutorizada()
        ClinicaAutorizadaAtual = New ClinicaAutorizada
    End Sub

    Public Sub Informar_ClinicaAutorizada(clinicaAutorizadaSelecionado As ClinicaAutorizada)
        ClinicaAutorizadaAtual = clinicaAutorizadaSelecionado
    End Sub

    Private Sub InicializarFormulario()

        Call RecuperarDados_ClinicaAutorizada()
        Call Configurar_VisualizacaoBotoesAcao()
        Call Configurar_BotaoExecutacao()
        Call Configurar_NomeFormulario()

    End Sub

    Private Sub Configurar_NomeFormulario()

        Select Case ModoAtual
            Case Modo_Cadastro
                Call AlterarnomeFormulario(Me, "Clínica Autorizada", "Cadastro")
            Case Modo_Edicao
                Call AlterarnomeFormulario(Me, "Clínica Autorizada", "Edição")
            Case Modo_Exclusao
                Call AlterarnomeFormulario(Me, "Clínica Autorizada", "Exclusão")
            Case Modo_Visualizacao
                Call AlterarnomeFormulario(Me, "Clínica Autorizada", "Visualização")
        End Select

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

            .TxtBx_RazaoSocial.Clear()
            .TxtBx_NomeAtendente.Clear()
            .TxtBx_EmailAtendimento.Clear()
            .MskdTxtBx_Telefone.Clear()
            .MskdTxtBx_Fixo.Clear()

        End With

        Call LimparEndereco()

    End Sub

    Private Sub LimparEndereco()

        With Me

            .MskdTxtBx_CEP.Clear()
            .TxtBx_Endereco_Logradouro.Clear()
            .TxtBx_Endereco_Numero.Clear()
            .TxtBx_Endereco_Bairro.Clear()
            .TxtBx_Endereco_Cidade.Clear()
            .TxtBx_Endereco_Estado.Clear()

        End With

    End Sub

    Private Sub Configurar_StatusCampos(Status As Boolean)

        With Me

            .TxtBx_RazaoSocial.Enabled = Status
            .TxtBx_NomeAtendente.Enabled = Status
            .TxtBx_EmailAtendimento.Enabled = Status
            .MskdTxtBx_Telefone.Enabled = Status
            .MskdTxtBx_Fixo.Enabled = Status
            .MskdTxtBx_CEP.Enabled = Status
            .TxtBx_Endereco_Numero.Enabled = Status
            .Bttn_Pesquisar.Enabled = Status

        End With

    End Sub

    Private Sub RecuperarDados_ClinicaAutorizada()

        With Me

            .TxtBx_RazaoSocial.Text = ClinicaAutorizadaAtual.RazaoSocial
            .TxtBx_NomeAtendente.Text = ClinicaAutorizadaAtual.NomeAtendente
            .TxtBx_EmailAtendimento.Text = ClinicaAutorizadaAtual.EmailAtendimento
            .MskdTxtBx_Telefone.Text = ClinicaAutorizadaAtual.TelefoneAtendimento
            .MskdTxtBx_Fixo.Text = ClinicaAutorizadaAtual.FixoAtendimento

        End With

        If ModoAtual <> Modo_Cadastro Then

            Call RecuperarDados_Endereco()

        End If

    End Sub

    Private Sub RecuperarDados_Endereco()

        EnderecoAtual = New Endereco

        EnderecoAtual = Endereco_ObterPorId(ClinicaAutorizadaAtual.IdEndereco)

        With Me

            .MskdTxtBx_CEP.Text = EnderecoAtual.CEP
            .TxtBx_Endereco_Logradouro.Text = EnderecoAtual.Logradouro
            .TxtBx_Endereco_Numero.Text = EnderecoAtual.Numero
            .TxtBx_Endereco_Bairro.Text = EnderecoAtual.Bairro
            .TxtBx_Endereco_Cidade.Text = EnderecoAtual.Cidade
            .TxtBx_Endereco_Estado.Text = EnderecoAtual.Estado

        End With

    End Sub

    Private Sub RegistrarDados_ClinicaAutorizada()

        If EnderecoAtual Is Nothing Then EnderecoAtual = New Endereco

        With EnderecoAtual
            .CEP = MskdTxtBx_CEP.Text
            .Logradouro = TxtBx_Endereco_Logradouro.Text
            .Numero = TxtBx_Endereco_Numero.Text
            .Bairro = TxtBx_Endereco_Bairro.Text
            .Cidade = TxtBx_Endereco_Cidade.Text
            .Estado = TxtBx_Endereco_Estado.Text
            .Local = $"{ .Logradouro}, nº { .Numero}, bairro { .Bairro} - { .Cidade}/{ .Estado}"

            If ModoAtual = Modo_Cadastro Then .Status = "Ativo"

        End With

        If ModoAtual = Modo_Cadastro Then
            Call Endereco_Adicionar(EnderecoAtual)
        Else
            Call Endereco_Atualizar(EnderecoAtual)
        End If

        With ClinicaAutorizadaAtual
            .RazaoSocial = TxtBx_RazaoSocial.Text
            .NomeAtendente = TxtBx_NomeAtendente.Text
            .EmailAtendimento = TxtBx_EmailAtendimento.Text
            .TelefoneAtendimento = MskdTxtBx_Telefone.Text
            .FixoAtendimento = MskdTxtBx_Fixo.Text
            .IdEndereco = Endereco_ObterIdPorLocal(EnderecoAtual.Local)

            If .IdEndereco <= 0 Then
                MsgBox("Erro ao obter ID do endereço.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If ModoAtual = Modo_Cadastro Then .Status = "Ativo"

        End With

    End Sub


    Private Function CamposPreenchidos() As Boolean

        ' Informações Clínica
        If Not VerificarObrigatorio(TxtBx_RazaoSocial, TbCntrl_Dados_ClinicaAutorizada, TbPg_Informacoes_ClinicaAutorizada) Then Return False
        If Not VerificarObrigatorio(TxtBx_NomeAtendente, TbCntrl_Dados_ClinicaAutorizada, TbPg_Informacoes_ClinicaAutorizada) Then Return False
        If Not EmailValido(TxtBx_EmailAtendimento, TbCntrl_Dados_ClinicaAutorizada, TbPg_Informacoes_ClinicaAutorizada, TxtBx_EmailAtendimento.Tag) Then Return False
        If Not VerificarObrigatorio(MskdTxtBx_Telefone, TbCntrl_Dados_ClinicaAutorizada, TbPg_Informacoes_ClinicaAutorizada) Then Return False
        If Not VerificarObrigatorio(MskdTxtBx_Fixo, TbCntrl_Dados_ClinicaAutorizada, TbPg_Informacoes_ClinicaAutorizada) Then Return False

        ' Informações Endereço
        If Not VerificarObrigatorio(MskdTxtBx_CEP, TbCntrl_Dados_ClinicaAutorizada, TbPg_Informacoes_Endereco) Then Return False
        If Not VerificarObrigatorio(TxtBx_Endereco_Numero, TbCntrl_Dados_ClinicaAutorizada, TbPg_Informacoes_Endereco) Then Return False

        Return True

    End Function

    Private Sub Executar()

        If CamposPreenchidos() = False Then Exit Sub

        Call RegistrarDados_ClinicaAutorizada()

        Select Case ModoAtual
            Case Modo_Cadastro
                If ClinicaAutorizada_Adicionar(ClinicaAutorizadaAtual) Then
                    MessageBox.Show("Clínica Autorizada cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call FinalizarFormulario(DialogResult.OK)
                End If
            Case Modo_Edicao
                If ClinicaAutorizada_Atualizar(ClinicaAutorizadaAtual) Then
                    MessageBox.Show("Clínica Autorizada atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        If ClinicaAutorizada_Excluir(ClinicaAutorizadaAtual.Id) And Endereco_Excluir(EnderecoAtual.Id) Then

            MessageBox.Show("Clínica Autorizada excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FinalizarFormulario(DialogResult.OK)

        End If

    End Sub

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

        Call FinalizarFormulario()

    End Sub

    Private Sub Frm_Cadastro_Colaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call InicializarFormulario()

    End Sub

    Private Sub Bttn_Pesquisar_Click(sender As Object, e As EventArgs) Handles Bttn_Pesquisar.Click

        Call PesquisarCEP

    End Sub

    Private Sub PesquisarCEP()

        Dim cep As String = MskdTxtBx_CEP.Text.Replace("-", "").Trim()

        If cep.Length <> 8 Then
            MessageBox.Show("CEP inválido. Digite um CEP com 8 dígitos.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim endereco As JObject = ObterEnderecoPorCEP(cep)

        If endereco IsNot Nothing AndAlso endereco("erro") Is Nothing Then
            TxtBx_Endereco_Logradouro.Text = endereco("logradouro")?.ToString()
            TxtBx_Endereco_Bairro.Text = endereco("bairro")?.ToString()
            TxtBx_Endereco_Cidade.Text = endereco("localidade")?.ToString()
            TxtBx_Endereco_Estado.Text = endereco("estado")?.ToString()
            TxtBx_Endereco_Numero.Focus() ' Número geralmente não vem da API
        Else
            MessageBox.Show("CEP não encontrado ou inválido.", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Call LimparEndereco()
            MskdTxtBx_CEP.Focus()
        End If

    End Sub


End Class