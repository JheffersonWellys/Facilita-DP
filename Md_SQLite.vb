Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms

Module Md_SQLite

    Private ReadOnly dbPath As String = Application.StartupPath & "\" & My.Settings.App_Nome & ".db"

    Public Sub InicializarBandoDeDados()

        Call VerificarOuCriarBanco()
        Call CriarTabelas()
        Call CriarIndices()
        Call CriarGatilhos()
        Call CriarVistas()

    End Sub

    Private Sub VerificarOuCriarBanco()
        Try
            If Not File.Exists(dbPath) Then
                SQLiteConnection.CreateFile(dbPath)
                Console.WriteLine("Banco de dados criado com sucesso.")
            Else
                Console.WriteLine("Banco de dados já existe.")
            End If
        Catch ex As Exception
            Console.WriteLine("Erro ao verificar/criar banco de dados: " & ex.Message)
        End Try
    End Sub

    Private Sub CriarTabelas()
        Try
            Using conn As New SQLiteConnection($"Data Source={dbPath};Version=3;")
                conn.Open()

                Dim comandos As String = "
                    CREATE TABLE IF NOT EXISTS colaborador (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome_completo TEXT,
                        email_pessoal TEXT,
                        email_corporativo TEXT,
                        telefone_pessoal TEXT,
                        cpf TEXT,
                        rg TEXT,
                        data_nascimento TEXT,
                        data_demissao TEXT,
                        funcao TEXT,
                        setor TEXT,
                        status TEXT
                    );

                    CREATE TABLE IF NOT EXISTS endereco (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        cep TEXT,
                        logradouro TEXT,
                        numero TEXT,
                        bairro TEXT,
                        cidade TEXT,
                        estado TEXT,
                        local TEXT,
                        status TEXT
                    );

                    CREATE TABLE IF NOT EXISTS unidade_senac (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        numero_unidade TEXT,
                        id_endereco INTEGER,
                        status TEXT,
                        FOREIGN KEY (id_endereco) REFERENCES endereco(id)
                    );

                    CREATE TABLE IF NOT EXISTS clinica_autorizada (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome_clinica TEXT,
                        id_endereco INTEGER,
                        telefone_atendimento TEXT,
                        fixo_atendimento TEXT,
                        email_atendimento TEXT,
                        status TEXT,
                        FOREIGN KEY (id_endereco) REFERENCES endereco(id)
                    );

                    CREATE TABLE IF NOT EXISTS exame_medico (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_clinica INTEGER,
                        id_colaborador INTEGER,
                        data_realizacao TEXT,
                        tipo_exame TEXT,
                        horario_realizacao TEXT,
                        status TEXT,
                        FOREIGN KEY (id_clinica) REFERENCES clinica_autorizada(id),
                        FOREIGN KEY (id_colaborador) REFERENCES colaborador(id)
                    );
                "

                Dim cmd As New SQLiteCommand(comandos, conn)
                cmd.ExecuteNonQuery()

                Console.WriteLine("Tabelas criadas com sucesso.")
            End Using
        Catch ex As Exception
            Console.WriteLine("Erro ao criar tabelas: " & ex.Message)
        End Try
    End Sub

    Private Sub CriarIndices()
        Try
            Using conn As New SQLiteConnection($"Data Source={dbPath};Version=3;")
                conn.Open()

                Dim indices As String = "
                    CREATE INDEX IF NOT EXISTS idx_colaborador_nome ON colaborador(nome_completo);
                    CREATE INDEX IF NOT EXISTS idx_endereco_cep ON endereco(cep);
                    CREATE INDEX IF NOT EXISTS idx_clinica_nome ON clinica_autorizada(nome_clinica);
                    CREATE INDEX IF NOT EXISTS idx_exame_colaborador ON exame_medico(id_colaborador);
                "

                Dim cmd As New SQLiteCommand(indices, conn)
                cmd.ExecuteNonQuery()

                Console.WriteLine("Índices criados com sucesso.")
            End Using
        Catch ex As Exception
            Console.WriteLine("Erro ao criar índices: " & ex.Message)
        End Try
    End Sub

    Private Sub CriarGatilhos()
        Try
            Using conn As New SQLiteConnection($"Data Source={dbPath};Version=3;")
                conn.Open()

                Dim gatilhos As String = "
                    CREATE TRIGGER IF NOT EXISTS trg_data_demissao
                    AFTER UPDATE ON colaborador
                    FOR EACH ROW
                    WHEN NEW.status = 'Inativo' AND OLD.status != 'Inativo'
                    BEGIN
                        UPDATE colaborador SET data_demissao = DATE('now') WHERE id = NEW.id;
                    END;
                "

                Dim cmd As New SQLiteCommand(gatilhos, conn)
                cmd.ExecuteNonQuery()

                Console.WriteLine("Gatilho criado com sucesso.")
            End Using
        Catch ex As Exception
            Console.WriteLine("Erro ao criar gatilhos: " & ex.Message)
        End Try
    End Sub

    Private Sub CriarVistas()
        Try
            Using conn As New SQLiteConnection($"Data Source={dbPath};Version=3;")
                conn.Open()

                Dim views As String = "
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_ativos AS
                    SELECT * FROM colaborador WHERE status = 'Ativo';

                    CREATE VIEW IF NOT EXISTS vw_exames_futuros AS
                    SELECT em.*, c.nome_clinica 
                    FROM exame_medico em
                    JOIN clinica_autorizada c ON em.id_clinica = c.id
                    WHERE DATE(em.data_realizacao) >= DATE('now');
                "

                Dim cmd As New SQLiteCommand(views, conn)
                cmd.ExecuteNonQuery()

                Console.WriteLine("Views criadas com sucesso.")
            End Using
        Catch ex As Exception
            Console.WriteLine("Erro ao criar views: " & ex.Message)
        End Try
    End Sub

End Module
