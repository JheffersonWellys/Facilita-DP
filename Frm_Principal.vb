Public Class Frm_Principal

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call InicializarFormulario()

    End Sub

    Private Sub InicializarFormulario()

        Me.Text = "Facilita DP - Módulo " & My.Settings.App_Módulo & " - v" & My.Settings.App_Versão

    End Sub

End Class