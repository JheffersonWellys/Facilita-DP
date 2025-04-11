Imports System.IO
Imports System.Net
Imports Facilita_DP___Módulo_Rescisão.Tabelas
Imports Newtonsoft.Json.Linq

Module Md_Funcoes_Auxiliares

    Public Function CampoObrigatorio(mensagem As String, janela As TabControl, aba As TabPage, controle As Control) As Boolean
        MessageBox.Show(mensagem, "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        janela.SelectedTab = aba
        controle.Focus()
        Return False
    End Function

    Public Function VerificarObrigatorio(controle As Control, abas As TabControl, aba As TabPage) As Boolean
        If TypeOf controle Is TextBox AndAlso String.IsNullOrEmpty(DirectCast(controle, TextBox).Text) Then
            Return CampoObrigatorio($"O campo [{controle.Tag}] é obrigatório.", abas, aba, controle)
        End If
        If TypeOf controle Is MaskedTextBox AndAlso Not DirectCast(controle, MaskedTextBox).MaskFull Then
            Return CampoObrigatorio($"O campo [{controle.Tag}] é obrigatório.", abas, aba, controle)
        End If
        If TypeOf controle Is ComboBox AndAlso DirectCast(controle, ComboBox).SelectedIndex = -1 Then
            Return CampoObrigatorio($"O campo [{controle.Tag}] é obrigatório.", abas, aba, controle)
        End If
        Return True
    End Function

    Public Function EmailValido(campo As TextBox, ControleDeAbas As TabControl, aba As TabPage, nomeCampo As String) As Boolean
        If Not emailRegex.IsMatch(campo.Text) Then
            MessageBox.Show($"O {nomeCampo} informado não é válido. Verifique e tente novamente.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ControleDeAbas.SelectedTab = aba
            campo.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function ConverterParaTexto(valor As Object) As String
        Return If(IsDBNull(valor), String.Empty, valor.ToString())
    End Function

    Public Function ConverterParaData(valor As Object) As Date
        Return If(IsDBNull(valor), Date.MinValue, Convert.ToDateTime(valor))
    End Function

    Public Function ConverterParaBooleano(valor As Object) As Boolean
        Return If(IsDBNull(valor), False, Convert.ToBoolean(valor))
    End Function


    Public Function SelecionarColaborador() As Colaborador
        Using frm As New Frm_Selecionar_Colaborador
            If frm.ShowDialog() = DialogResult.OK Then
                Return frm.ColaboradorSelecionado
            End If
        End Using
        Return Nothing
    End Function

    Public Function SelecionarClinicaAutorizada() As ClinicaAutorizada
        Using frm As New Frm_Selecionar_ClinicaAutorizada
            If frm.ShowDialog() = DialogResult.OK Then
                Return frm.ClinicaAutorizadaSelecionada
            End If
        End Using
        Return Nothing
    End Function

    Public Sub AlterarnomeFormulario(Frm As Form, NomeFormalario As String, ModoStatus As String)
        Frm.Text = NomeFormalario & " | Modo " & ModoStatus
    End Sub

    Public Function ObterEnderecoPorCEP(cep As String) As JObject
        Try
            Dim url As String = $"https://viacep.com.br/ws/{cep}/json/"
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"

            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim json As String = reader.ReadToEnd()
                    Return JObject.Parse(json)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar o endereço: " & ex.Message, "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

End Module
