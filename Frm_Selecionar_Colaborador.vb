Imports Facilita_DP___Módulo_Rescisão.Tabelas

Public Class Frm_Selecionar_Colaborador

    Public ColaboradorSelecionado As Colaborador
    Private DtTbl_Lista_Colaboradores As DataTable

    Private Sub InicializarFormulario()

        Call AlterarnomeFormulario(Me, "Colaborador", "Seleção")
        Call CarregarLista_Colaboradores()
        Call LimparFiltro

    End Sub

    Private Sub AplicarFiltro()

        Dim termoBusca As String = TxtBx_Termo_Pesquisa.Text.Trim()

        If DtTbl_Lista_Colaboradores Is Nothing OrElse DtTbl_Lista_Colaboradores.Rows.Count = 0 Then Exit Sub

        Dim filtro As String = $"nome_completo Like '%{termoBusca.Replace("'", "''")}%' OR chapa LIKE '%{termoBusca.Replace("'", "''")}%'"

        Dim dataView As New DataView(DtTbl_Lista_Colaboradores)
        dataView.RowFilter = filtro

        DtGrdVw_Lista_Colaboradores.DataSource = dataView

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

    Private Sub CarregarLista_Colaboradores()

        DtTbl_Lista_Colaboradores = Colaborador_ListarTodos()
        DtGrdVw_Lista_Colaboradores.DataSource = DtTbl_Lista_Colaboradores

        Call Configurar_Lista_Colaboradores()

    End Sub

    Private Sub Configurar_Lista_Colaboradores()

        DtGrdVw_Lista_Colaboradores.Columns("id").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("nome_completo").Visible = True
        DtGrdVw_Lista_Colaboradores.Columns("chapa").Visible = True
        DtGrdVw_Lista_Colaboradores.Columns("email_pessoal").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("email_corporativo").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("telefone_pessoal").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("cpf").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("rg").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("data_admissao").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("data_nascimento").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("data_demissao").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("funcao").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("setor").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("sexo").Visible = True
        DtGrdVw_Lista_Colaboradores.Columns("demitido").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("status").Visible = False

        DtGrdVw_Lista_Colaboradores.Columns("nome_completo").HeaderText = "Nome Completo"
        DtGrdVw_Lista_Colaboradores.Columns("chapa").HeaderText = "Chapa"
        DtGrdVw_Lista_Colaboradores.Columns("sexo").HeaderText = "Sexo"

        DtGrdVw_Lista_Colaboradores.Columns("nome_completo").Width = 510
        DtGrdVw_Lista_Colaboradores.Columns("chapa").Width = 100
        DtGrdVw_Lista_Colaboradores.Columns("sexo").Width = 110

    End Sub

    Private Sub TxtBx_Termo_Pesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtBx_Termo_Pesquisa.TextChanged

        Call AplicarFiltro()

    End Sub

    Private Sub Bttn_Limpar_Click(sender As Object, e As EventArgs) Handles Bttn_Limpar.Click

        Call LimparFiltro()

    End Sub

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

        ColaboradorSelecionado = Nothing
        Call FinalizarFormalario()

    End Sub
    Private Sub RecuperarDados_Colaborador_Selecionado()

        If DtGrdVw_Lista_Colaboradores.SelectedRows.Count = 0 Then Exit Sub

        Dim row As DataGridViewRow = DtGrdVw_Lista_Colaboradores.SelectedRows(0)

        ColaboradorSelecionado = New Colaborador With {
             .Id = Convert.ToInt32(row.Cells("id").Value),
             .NomeCompleto = ConverterParaTexto(row.Cells("nome_completo").Value),
             .Chapa = ConverterParaTexto(row.Cells("chapa").Value),
             .EmailPessoal = ConverterParaTexto(row.Cells("email_pessoal").Value),
             .EmailCorporativo = ConverterParaTexto(row.Cells("email_corporativo").Value),
             .TelefonePessoal = ConverterParaTexto(row.Cells("telefone_pessoal").Value),
             .CPF = ConverterParaTexto(row.Cells("cpf").Value),
             .RG = ConverterParaTexto(row.Cells("rg").Value),
             .DataAdmissao = ConverterParaData(row.Cells("data_admissao").Value),
             .DataNascimento = ConverterParaData(row.Cells("data_nascimento").Value),
             .DataDemissao = ConverterParaData(row.Cells("data_demissao").Value),
             .Funcao = ConverterParaTexto(row.Cells("funcao").Value),
             .Setor = ConverterParaTexto(row.Cells("setor").Value),
             .Sexo = ConverterParaTexto(row.Cells("sexo").Value),
             .Demitido = ConverterParaBooleano(row.Cells("demitido").Value),
             .Status = ConverterParaTexto(row.Cells("status").Value)
         }


    End Sub


    Private Sub Bttn_Selecionar_Click(sender As Object, e As EventArgs) Handles Bttn_Selecionar.Click

        Call RecuperarDados_Colaborador_Selecionado()

        Call FinalizarFormalario(DialogResult.OK)

    End Sub

    Private Sub Frm_Selecionar_Colaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call InicializarFormulario()

    End Sub
End Class