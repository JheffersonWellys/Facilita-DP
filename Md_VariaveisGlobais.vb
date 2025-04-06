Module Md_VariaveisGlobais

    Public ReadOnly dbPath As String = Application.StartupPath & "\" & My.Settings.App_Nome & ".db"
    Public ReadOnly connectionString As String = "Data Source=" & dbPath & ";Version=3;"

    Public Const Modo_Cadastro As String = "Cadastro"
    Public Const Modo_Edicao As String = "Edição"
    Public Const Modo_Exclusao As String = "Exclusão"
    Public Const Modo_Visualizacao As String = "Visualização"

    Public emailRegex As New System.Text.RegularExpressions.Regex("^[\w\.-]+@[\w\.-]+\.\w{2,}$")

End Module
