Imports Facilita_DP___Módulo_Rescisão.Tabelas

Public Class Frm_Principal

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call InicializarFormulario()

    End Sub

    '******************************************************************************************************************
    ' Funçãos de clicks para os itens do menu

    Private Sub TlStrpMnItm_Sobre_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Sobre.Click

    End Sub

    Private Sub TlStrpMnItm_Sair_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Sair.Click

        Call FinalizarFormulario()

    End Sub

    Private Sub TlStrpMnItm_Enviar_GuiaEncaminhamento_Demissional_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Enviar_GuiaEncaminhamento_Demissional.Click

    End Sub

    Private Sub TlStrpMnItm_Enviar_AvisoDeMarcacao_Demissional_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Enviar_AvisoDeMarcacao_Demissional.Click

    End Sub

    Private Sub TlStrpMnItm_Enviar_SolicitacaoAso_Demissional_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Enviar_SolicitacaoAso_Demissional.Click

    End Sub

    Private Sub TlStrpMnItm_Emitir_CienciaDeHomologacao_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Emitir_CienciaDeHomologacao.Click

    End Sub

    Private Sub TlStrpMnItm_Emitir_FinsRescisorios_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Emitir_FinsRescisorios.Click

    End Sub

    Private Sub TlStrpMnItm_Colaboradores_Adicionar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Colaboradores_Adicionar.Click

        Dim Frm As New Frm_Cadastro_Colaborador
        Frm.AtivarModoFormulario(Modo_Cadastro)
        Frm.Informar_Colaborador()
        Frm.ShowDialog()

    End Sub

    Private Sub TlStrpMnItm_Colaboradores_Editar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Colaboradores_Editar.Click

        Dim colaborador As Colaborador = SelecionarColaborador()

        If colaborador Is Nothing Then Exit Sub

        Dim Frm_Cadastro As New Frm_Cadastro_Colaborador
        Frm_Cadastro.AtivarModoFormulario(Modo_Edicao)
        Frm_Cadastro.Informar_Colaborador(colaborador)
        Frm_Cadastro.ShowDialog()

    End Sub

    Private Sub TlStrpMnItm_Colaboradores_Excluir_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Colaboradores_Excluir.Click

        Dim colaborador As Colaborador = SelecionarColaborador()

        If colaborador Is Nothing Then Exit Sub

        Dim Frm_Cadastro As New Frm_Cadastro_Colaborador
        Frm_Cadastro.AtivarModoFormulario(Modo_Exclusao)
        Frm_Cadastro.Informar_Colaborador(colaborador)
        Frm_Cadastro.ShowDialog()

    End Sub

    Private Sub TlStrpMnItm_Colaboradores_Visualizar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Colaboradores_Visualizar.Click

        Dim colaborador As Colaborador = SelecionarColaborador()

        If colaborador Is Nothing Then Exit Sub

        Dim Frm_Cadastro As New Frm_Cadastro_Colaborador
        Frm_Cadastro.AtivarModoFormulario(Modo_Visualizacao)
        Frm_Cadastro.Informar_Colaborador(colaborador)
        Frm_Cadastro.ShowDialog()

    End Sub

    Private Sub TlStrpMnItm_UnidadesSenac_Adicionar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_UnidadesSenac_Adicionar.Click

        Dim Frm As New Frm_Cadastro_ClinicaAutorizada
        Frm.AtivarModoFormulario(Modo_Cadastro)
        Frm.Informar_ClinicaAutorizada()
        Frm.ShowDialog()

    End Sub

    Private Sub TlStrpMnItm_UnidadesSenac_Editar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_UnidadesSenac_Editar.Click

    End Sub

    Private Sub TlStrpMnItm_UnidadesSenac_Excluir_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_UnidadesSenac_Excluir.Click

    End Sub

    Private Sub TlStrpMnItm_UnidadesSenac_Visualizar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_UnidadesSenac_Visualizar.Click

    End Sub

    Private Sub TlStrpMnItm_ClinicasAutorizadas_Adicionar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_ClinicasAutorizadas_Adicionar.Click

    End Sub

    Private Sub TlStrpMnItm_ClinicasAutorizadas_Editar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_ClinicasAutorizadas_Editar.Click

    End Sub

    Private Sub TlStrpMnItm_ClinicasAutorizadas_Excluir_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_ClinicasAutorizadas_Excluir.Click

    End Sub

    Private Sub TlStrpMnItm_ClinicasAutorizadas_Visualizar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_ClinicasAutorizadas_Visualizar.Click

    End Sub

    '*******************************************************************************************************************
    ' Função para controlar o formulário

    Private Sub InicializarFormulario()

        Me.Text = "Facilita DP - Módulo " & My.Settings.App_Módulo & " - v" & My.Settings.App_Versão

    End Sub

    Private Sub FinalizarFormulario()

        With Me

            .DialogResult = DialogResult.Cancel
            .Close()

        End With

    End Sub

    Private Sub Frm_Principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Dim Colaborador_TemRegistros As Boolean = Md_SQLite_Funcoes.Colaborador_TemRegistros()

        TlStrpMnItm_Colaboradores_Editar.Enabled = Colaborador_TemRegistros
        TlStrpMnItm_Colaboradores_Excluir.Enabled = Colaborador_TemRegistros
        TlStrpMnItm_Colaboradores_Visualizar.Enabled = Colaborador_TemRegistros

    End Sub

End Class