Namespace Tabelas

    Public Class Colaborador
        Public Property Id As Integer
        Public Property NomeCompleto As String
        Public Property Chapa As String
        Public Property EmailPessoal As String
        Public Property EmailCorporativo As String
        Public Property TelefonePessoal As String
        Public Property CPF As String
        Public Property RG As String
        Public Property DataAdmissao As Date
        Public Property DataNascimento As Date
        Public Property DataDemissao As Date
        Public Property Funcao As String
        Public Property Setor As String
        Public Property Sexo As String
        Public Property Demitido As Boolean
        Public Property Status As String
    End Class

    Public Class Endereco
        Public Property Id As Integer
        Public Property CEP As String
        Public Property Logradouro As String
        Public Property Numero As String
        Public Property Bairro As String
        Public Property Cidade As String
        Public Property Estado As String
        Public Property Local As String
        Public Property Status As String
    End Class

    Public Class UnidadeSenac
        Public Property Id As Integer
        Public Property NumeroUnidade As String
        Public Property IdEndereco As Integer
        Public Property Status As String
    End Class

    Public Class ClinicaAutorizada
        Public Property Id As Integer
        Public Property RazaoSocial As String
        Public Property NomeAtendente As String
        Public Property IdEndereco As Integer
        Public Property TelefoneAtendimento As String
        Public Property FixoAtendimento As String
        Public Property EmailAtendimento As String
        Public Property Status As String
    End Class

    Public Class ExameMedico
        Public Property Id As Integer
        Public Property IdClinica As Integer
        Public Property IdColaborador As Integer
        Public Property DataRealizacao As Date
        Public Property TipoExame As String
        Public Property HorarioRealizacao As String
        Public Property Status As String
    End Class


End Namespace
