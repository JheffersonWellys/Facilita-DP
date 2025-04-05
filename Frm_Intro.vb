Public Class Frm_Intro

    Private Sub Frm_Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Tmr_Intro.Start()
        Call CarregarInformacoes()

    End Sub

    Private Sub Tmr_Intro_Tick(sender As Object, e As EventArgs) Handles Tmr_Intro.Tick

        If Tmr_Intro.Interval = 3000 Then

            'Dim Frm As New Frm_Principal
            'Frm.show()

            Tmr_Intro.Stop()

            Me.Close()

        End If

    End Sub

    Private Sub CarregarInformacoes()

        Lbl_Versao.Text = My.Settings.App_Versão
        Lbl_Modulo.Text = My.Settings.App_Módulo

    End Sub

End Class
