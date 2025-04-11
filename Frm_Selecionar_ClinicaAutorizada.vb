Imports Facilita_DP___Módulo_Rescisão.Tabelas

Public Class Frm_Selecionar_ClinicaAutorizada

    Public ClinicaAutorizadaSelecionada As ClinicaAutorizada
    Private DtTbl_Lista_ClinicasAutorizadas As DataTable

    Private Sub InicializarFormulario()

        Call AlterarnomeFormulario(Me, "Clínica Autorizada", "Seleção")
        Call CarregarLista_ClinicasAutorizadas()
        Call LimparFiltro()

    End Sub

    Private Sub AplicarFiltro()

        Dim termoBusca As String = TxtBx_Termo_Pesquisa.Text.Trim()

        If DtTbl_Lista_ClinicasAutorizadas Is Nothing OrElse DtTbl_Lista_ClinicasAutorizadas.Rows.Count = 0 Then Exit Sub

        Dim filtro As String = $"razao_social Like '%{termoBusca.Replace("'", "''")}%' OR cidade LIKE '%{termoBusca.Replace("'", "''")}%' OR estado LIKE '%{termoBusca.Replace("'", "''")}%' "

        Dim dataView As New DataView(DtTbl_Lista_ClinicasAutorizadas)
        dataView.RowFilter = filtro

        DtGrdVw_Lista_ClinicasAutorizadas.DataSource = dataView

    End Sub


    Private Sub LimparFiltro()

        TxtBx_Termo_Pesquisa.Clear()

    End Sub

    Private Sub FinalizarFormalario(Optional Status As DialogResult = DialogResult.Cancel)
        With Me
            .DialogResult = Status
            .Close()
        End With
    End Sub

    Private Sub CarregarLista_ClinicasAutorizadas()

        DtTbl_Lista_ClinicasAutorizadas = ClinicaAutorizada_ListarDadosComEndereco()
        DtGrdVw_Lista_ClinicasAutorizadas.DataSource = DtTbl_Lista_ClinicasAutorizadas

        Call Configurar_Lista_ClinicasAutorizadas()

    End Sub

    Private Sub Configurar_Lista_ClinicasAutorizadas()

        DtGrdVw_Lista_ClinicasAutorizadas.Columns("id").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("razao_social").Visible = True
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("nome_atendente").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("id_endereco").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("telefone_atendimento").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("fixo_atendimento").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("email_atendimento").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("status").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("cidade").Visible = True
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("estado").Visible = True

        DtGrdVw_Lista_ClinicasAutorizadas.Columns("razao_social").HeaderText = "Razão Social"
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("cidade").HeaderText = "Cidade"
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("estado").HeaderText = "Estado"

        DtGrdVw_Lista_ClinicasAutorizadas.Columns("razao_social").Width = 320
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("cidade").Width = 250
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("estado").Width = 150

    End Sub

    Private Sub TxtBx_Termo_Pesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtBx_Termo_Pesquisa.TextChanged

        Call AplicarFiltro()

    End Sub

    Private Sub Bttn_Limpar_Click(sender As Object, e As EventArgs) Handles Bttn_Limpar.Click

        Call LimparFiltro()

    End Sub

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

        ClinicaAutorizadaSelecionada = Nothing
        Call FinalizarFormalario()

    End Sub
    Private Sub RecuperarDados_ClinicaAutorizada_Selecionada()

        If DtGrdVw_Lista_ClinicasAutorizadas.SelectedRows.Count = 0 Then Exit Sub

        Dim row As DataGridViewRow = DtGrdVw_Lista_ClinicasAutorizadas.SelectedRows(0)

        ClinicaAutorizadaSelecionada = New ClinicaAutorizada With {
             .Id = Convert.ToInt32(row.Cells("id").Value),
             .RazaoSocial = ConverterParaTexto(row.Cells("razao_social").Value),
             .NomeAtendente = ConverterParaTexto(row.Cells("nome_atendente").Value),
             .IdEndereco = ConverterParaTexto(row.Cells("id_endereco").Value),
             .TelefoneAtendimento = ConverterParaTexto(row.Cells("telefone_atendimento").Value),
             .FixoAtendimento = ConverterParaTexto(row.Cells("fixo_atendimento").Value),
             .EmailAtendimento = ConverterParaTexto(row.Cells("email_atendimento").Value),
             .Status = ConverterParaTexto(row.Cells("status").Value)
         }

    End Sub


    Private Sub Bttn_Selecionar_Click(sender As Object, e As EventArgs) Handles Bttn_Selecionar.Click

        Call RecuperarDados_ClinicaAutorizada_Selecionada()

        Call FinalizarFormalario(DialogResult.OK)

    End Sub

    Private Sub Frm_Selecionar_Colaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call InicializarFormulario()

    End Sub

End Class