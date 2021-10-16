Public Class Frm_Principal_05
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Lbl_NomeProjeto.Text = "5 - Laços de Repetição"
        Me.Text = "5 - Laços de Repetição"
        Lbl_Principal.Text = "Valor Investido"
        Lbl_Rendimento.Text = "Juros (%)"
        Btm_While.Text = "Calcular Valor usando While"
        Btm_For.Text = "Calcular Valor usando For"
        Lbl_Periodos.Text = "Periodos"
        Grp_Grupo1.Text = "Cálculo do Investimento por While e por For"
        Grp_Grupo2.Text = "Cálculo do Investimento Anual"

        Lbl_Principal2.Text = "Valor Investido"
        Lbl_Redimentos2.Text = "Juros Mensais (%)"
        Lbl_Anos.Text = "Anos Aplicados"
        Lbl_Acrescimo_Rendimento.Text = "Acrescimo Juros (%)"
        Btm_Calcula.Text = "Efetua Cálculo"
        Lbl_Limite.Text = "Limite"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Principal.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txt_Rendimento.TextChanged

    End Sub

    Private Sub Btm_principal_Click(sender As Object, e As EventArgs) Handles Btm_While.Click

        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim contador As Integer = 1
        Dim extrato As String = ""

        While contador <= periodos
            investimento = (investimento + (investimento * (rendimento / 100)))
            extrato += "O saldo do investimento no mês " + contador.ToString + " é: " + investimento.ToString + vbCrLf
            contador += 1
        End While

        Txt_Extrato_While.Text = extrato

    End Sub

    Private Sub Frm_Principal_05_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btm_For_Click(sender As Object, e As EventArgs) Handles Btm_For.Click

        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim extrato As String = ""

        For i As Integer = 1 To periodos
            investimento = (investimento + (investimento * (rendimento / 100)))
            extrato += "O saldo do investimento no mês " + i.ToString + " é: " + investimento.ToString + vbCrLf
        Next

        Txt_Extrato_For.Text = extrato

    End Sub

    Private Sub Btm_Calcula_Click(sender As Object, e As EventArgs) Handles Btm_Calcula.Click

        Dim investimento As Double = Val(Txt_Principal2.Text)
        Dim rendimento As Double = Val(Txt_Rendimento2.Text)
        Dim anos As Integer = Val(Txt_Anos.Text)
        Dim acrescimoJuros As Double = Val(Txt_Acrescimo_Rendimento.Text)
        Dim limite As Double = Val(Txt_Limite.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1
        Dim executouExitFor As Boolean = False


        For i As Integer = 1 To anos

            For j As Integer = 1 To 12
                investimento = (investimento + (investimento * (rendimento / 100)))
                extrato += "O saldo do investimento no mês " + contador.ToString + " é: " + investimento.ToString + " usando a taxa " _
                + rendimento.ToString + " % mes" + vbCrLf

                If investimento >= limite Then
                    executouExitFor = True
                    extrato += "O investimento atingiu o limite" + vbCrLf
                    Exit For
                End If

                If executouExitFor = True Then
                    Exit For
                End If

                contador += 1
            Next

            rendimento = rendimento + (rendimento * acrescimoJuros / 100)
        Next

        Txt_Resultado.Text = extrato

    End Sub
End Class
