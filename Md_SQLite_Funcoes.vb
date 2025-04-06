Imports Facilita_DP___Módulo_Rescisão.Tabelas
Imports System.Data.SQLite

Module Md_SQLite_Funcoes

    Private ReadOnly dbPath As String = Application.StartupPath & "\" & My.Settings.App_Nome & ".db"
    Private ReadOnly connectionString As String = "Data Source=" & dbPath & ";Version=3;"

    '******************************************************************************************************************
    ' Funções de manipulação de dados para a tabela Colaborador

    Public Sub Colaborador_Adicionar(colaborador As Colaborador)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO colaborador 
                (nome_completo, chapa, email_pessoal, email_corporativo, telefone_pessoal, cpf, rg, data_nascimento, data_demissao, funcao, setor, status) 
                VALUES (@nome, @chp, @emailPes, @emailCorp, @tel, @cpf, @rg, @nasc, @demiss, @funcao, @setor, @status)", conn)

            cmd.Parameters.AddWithValue("@nome", colaborador.NomeCompleto)
            cmd.Parameters.AddWithValue("@chp", colaborador.Chapa)
            cmd.Parameters.AddWithValue("@emailPes", colaborador.EmailPessoal)
            cmd.Parameters.AddWithValue("@emailCorp", colaborador.EmailCorporativo)
            cmd.Parameters.AddWithValue("@tel", colaborador.TelefonePessoal)
            cmd.Parameters.AddWithValue("@cpf", colaborador.CPF)
            cmd.Parameters.AddWithValue("@rg", colaborador.RG)
            cmd.Parameters.AddWithValue("@nasc", colaborador.DataNascimento)
            cmd.Parameters.AddWithValue("@demiss", colaborador.DataDemissao)
            cmd.Parameters.AddWithValue("@funcao", colaborador.Funcao)
            cmd.Parameters.AddWithValue("@setor", colaborador.Setor)
            cmd.Parameters.AddWithValue("@status", colaborador.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Colaborador_Atualizar(colaborador As Colaborador)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("UPDATE colaborador SET 
                nome_completo = @nome, chapa = @chp, email_pessoal = @emailPes, email_corporativo = @emailCorp, telefone_pessoal = @tel, 
                cpf = @cpf, rg = @rg, data_nascimento = @nasc, data_demissao = @demiss, funcao = @funcao, setor = @setor, status = @status 
                WHERE id = @id", conn)

            cmd.Parameters.AddWithValue("@id", colaborador.Id)
            cmd.Parameters.AddWithValue("@nome", colaborador.NomeCompleto)
            cmd.Parameters.AddWithValue("@chp", colaborador.Chapa)
            cmd.Parameters.AddWithValue("@emailPes", colaborador.EmailPessoal)
            cmd.Parameters.AddWithValue("@emailCorp", colaborador.EmailCorporativo)
            cmd.Parameters.AddWithValue("@tel", colaborador.TelefonePessoal)
            cmd.Parameters.AddWithValue("@cpf", colaborador.CPF)
            cmd.Parameters.AddWithValue("@rg", colaborador.RG)
            cmd.Parameters.AddWithValue("@nasc", colaborador.DataNascimento)
            cmd.Parameters.AddWithValue("@demiss", colaborador.DataDemissao)
            cmd.Parameters.AddWithValue("@funcao", colaborador.Funcao)
            cmd.Parameters.AddWithValue("@setor", colaborador.Setor)
            cmd.Parameters.AddWithValue("@status", colaborador.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Colaborador_Excluir(id As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("DELETE FROM colaborador WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function Colaborador_ListarTodos() As DataTable
        Dim dt As New DataTable
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM colaborador", conn)
            Dim da As New SQLiteDataAdapter(cmd)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    '******************************************************************************************************************
    ' Funções de manipulação de dados para a tabela Endereço

    Public Sub Endereco_Adicionar(endereco As Endereco)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO endereco (cep, logradouro, numero, bairro, cidade, estado, local, status) VALUES (@cep, @log, @num, @bairro, @cidade, @estado, @local, @status)", conn)
            cmd.Parameters.AddWithValue("@cep", endereco.CEP)
            cmd.Parameters.AddWithValue("@log", endereco.Logradouro)
            cmd.Parameters.AddWithValue("@num", endereco.Numero)
            cmd.Parameters.AddWithValue("@bairro", endereco.Bairro)
            cmd.Parameters.AddWithValue("@cidade", endereco.Cidade)
            cmd.Parameters.AddWithValue("@estado", endereco.Estado)
            cmd.Parameters.AddWithValue("@local", endereco.Local)
            cmd.Parameters.AddWithValue("@status", endereco.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Endereco_Atualizar(endereco As Endereco)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("UPDATE endereco SET cep = @cep, logradouro = @log, numero = @num, bairro = @bairro, cidade = @cidade, estado = @estado, local = @local, status = @status WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", endereco.Id)
            cmd.Parameters.AddWithValue("@cep", endereco.CEP)
            cmd.Parameters.AddWithValue("@log", endereco.Logradouro)
            cmd.Parameters.AddWithValue("@num", endereco.Numero)
            cmd.Parameters.AddWithValue("@bairro", endereco.Bairro)
            cmd.Parameters.AddWithValue("@cidade", endereco.Cidade)
            cmd.Parameters.AddWithValue("@estado", endereco.Estado)
            cmd.Parameters.AddWithValue("@local", endereco.Local)
            cmd.Parameters.AddWithValue("@status", endereco.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Endereco_Excluir(id As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("DELETE FROM endereco WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function Endereco_ListarTodos() As DataTable
        Dim dt As New DataTable
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM endereco", conn)
            Dim da As New SQLiteDataAdapter(cmd)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    '******************************************************************************************************************
    ' Funções de manipulação de dados para a tabela Unidade Senac

    Public Sub UnidadeSenac_Adicionar(unidadeSenac As UnidadeSenac)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO unidade_senac (numero_unidade, id_endereco, status) VALUES (@numUnid, @idEnd, @status)", conn)
            cmd.Parameters.AddWithValue("@numUnid", unidadeSenac.NumeroUnidade)
            cmd.Parameters.AddWithValue("@idEnd", unidadeSenac.IdEndereco)
            cmd.Parameters.AddWithValue("@status", unidadeSenac.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub UnidadeSenac_Atualizar(unidadeSenac As UnidadeSenac)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("UPDATE unidade_senac SET numero_unidade = @numUnid, id_endereco = @idEnd, status = @status WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", unidadeSenac.Id)
            cmd.Parameters.AddWithValue("@numUnid", unidadeSenac.NumeroUnidade)
            cmd.Parameters.AddWithValue("@idEnd", unidadeSenac.IdEndereco)
            cmd.Parameters.AddWithValue("@status", unidadeSenac.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub UnidadeSenac_Excluir(id As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("DELETE FROM unidade_senac WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function UnidadeSenac_ListarTodos() As DataTable
        Dim dt As New DataTable
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM unidade_senac", conn)
            Dim da As New SQLiteDataAdapter(cmd)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    '******************************************************************************************************************
    ' Funções de manipulação de dados para a tabela Clinica Autorizada

    Public Sub ClinicaAutorizada_Adicionar(clinicaAutorizada As ClinicaAutorizada)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO clinica_autorizada (nome_clinica, id_endereco, telefone_atendimento, fixo_atendimento, email_atendimento, status) VALUES (@nome, @idEnd, @tel, @fixo, @email, @status)", conn)
            cmd.Parameters.AddWithValue("@nome", clinicaAutorizada.NomeClinica)
            cmd.Parameters.AddWithValue("@idEnd", clinicaAutorizada.IdEndereco)
            cmd.Parameters.AddWithValue("@tel", clinicaAutorizada.TelefoneAtendimento)
            cmd.Parameters.AddWithValue("@fixo", clinicaAutorizada.FixoAtendimento)
            cmd.Parameters.AddWithValue("@email", clinicaAutorizada.EmailAtendimento)
            cmd.Parameters.AddWithValue("@status", clinicaAutorizada.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub ClinicaAutorizada_Atualizar(clinicaAutorizada As ClinicaAutorizada)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("UPDATE clinica_autorizada SET nome_clinica = @nome, id_endereco = @idEnd, telefone_atendimento = @tel, fixo_atendimento = @fixo, email_atendimento = @email, status = @status WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", clinicaAutorizada.Id)
            cmd.Parameters.AddWithValue("@nome", clinicaAutorizada.NomeClinica)
            cmd.Parameters.AddWithValue("@idEnd", clinicaAutorizada.IdEndereco)
            cmd.Parameters.AddWithValue("@tel", clinicaAutorizada.TelefoneAtendimento)
            cmd.Parameters.AddWithValue("@fixo", clinicaAutorizada.FixoAtendimento)
            cmd.Parameters.AddWithValue("@email", clinicaAutorizada.EmailAtendimento)
            cmd.Parameters.AddWithValue("@status", clinicaAutorizada.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub ClinicaAutorizada_Excluir(id As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("DELETE FROM clinica_autorizada WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function ClinicaAutorizada_ListarTodos() As DataTable
        Dim dt As New DataTable
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM clinica_autorizada", conn)
            Dim da As New SQLiteDataAdapter(cmd)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    '******************************************************************************************************************
    ' Funções de manipulação de dados para a tabela Exame Médico

    Public Sub ExameMedico_Adicionar(exameMedico As ExameMedico)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO exame_medico (id_clinica, id_colaborador, data_realizacao, tipo_exame, horario_realizacao, status) VALUES (@idClinica, @idColab, @data, @tipo, @hora, @status)", conn)
            cmd.Parameters.AddWithValue("@idClinica", exameMedico.IdClinica)
            cmd.Parameters.AddWithValue("@idColab", exameMedico.IdColaborador)
            cmd.Parameters.AddWithValue("@data", exameMedico.DataRealizacao)
            cmd.Parameters.AddWithValue("@tipo", exameMedico.TipoExame)
            cmd.Parameters.AddWithValue("@hora", exameMedico.HorarioRealizacao)
            cmd.Parameters.AddWithValue("@status", exameMedico.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub ExameMedico_Atualizar(exameMedico As ExameMedico)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("UPDATE exame_medico SET id_clinica = @idClinica, id_colaborador = @idColab, data_realizacao = @data, tipo_exame = @tipo, horario_realizacao = @hora, status = @status WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", exameMedico.Id)
            cmd.Parameters.AddWithValue("@idClinica", exameMedico.IdClinica)
            cmd.Parameters.AddWithValue("@idColab", exameMedico.IdColaborador)
            cmd.Parameters.AddWithValue("@data", exameMedico.DataRealizacao)
            cmd.Parameters.AddWithValue("@tipo", exameMedico.TipoExame)
            cmd.Parameters.AddWithValue("@hora", exameMedico.HorarioRealizacao)
            cmd.Parameters.AddWithValue("@status", exameMedico.Status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub ExameMedico_Excluir(id As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("DELETE FROM exame_medico WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function ExameMedico_ListarTodos() As DataTable
        Dim dt As New DataTable
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM exame_medico", conn)
            Dim da As New SQLiteDataAdapter(cmd)
            da.Fill(dt)
        End Using
        Return dt
    End Function


End Module
