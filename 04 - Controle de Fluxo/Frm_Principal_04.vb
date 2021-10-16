Public Class Frm_Principal_04
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Lbl_NomeProjeto.Text = "4 - Controle de Fluxo"
        Btm_principal.Text = "Checagem de permissão de entrada"
        Me.Text = "4 - Controle de Fluxo"

        ' Inicialização dos componentes da aplicação

        Lbl_Idade.Text = "Idade"
        Lbl_Resultado.Text = "Resultado"
        Grp_Pais.Text = "Acompanhado dos Pais?"
        Rdb_Sim.Text = "Sim"
        Rdb_Nao.Text = "Não"

    End Sub

    Private Sub Btm_principal_Click(sender As Object, e As EventArgs) Handles Btm_principal.Click

        Txt_Resultado.Text = ""
        Dim idade As Integer
        idade = Txt_Idade.Text

        Dim acompanhadoPais As String

        If Rdb_Sim.Checked Then
            acompanhadoPais = "S"

        Else
            acompanhadoPais = "N"

        End If

        Dim podeEntrar As Boolean = ((idade >= 18) Or (acompanhadoPais = "S" And idade >= 16))
        Dim naoPodeEntrar As Boolean = ((acompanhadoPais = "N" And idade >= 16) Or (idade < 16))

        Dim mensagemAdicional As String
        If acompanhadoPais = "S" Then
            mensagemAdicional = "Está acompanhado!"
        Else
            mensagemAdicional = "Não está acompanhado!"
        End If

        If podeEntrar Then
            Txt_Resultado.ForeColor = Color.Green
            Txt_Resultado.Text = "Pode entrar." + mensagemAdicional

        Else

            If naoPodeEntrar Then
                Txt_Resultado.ForeColor = Color.Red
                Txt_Resultado.Text = "Não pode entrar." + mensagemAdicional

            End If

        End If

    End Sub
End Class
