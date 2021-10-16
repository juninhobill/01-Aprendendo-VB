Public Class Frm_Principal_02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btm_principal_Click(sender As Object, e As EventArgs) Handles Btm_NumerosInteiros.Click

        Dim idade As Integer
        idade = 12
        MsgBox("O valor da idade é: " + idade.ToString, MsgBoxStyle.Critical)

        idade = 12 * 5
        MsgBox("O valor da idade multiplicado por 5 é: " + idade.ToString, MsgBoxStyle.Critical)

        idade = (12 * 5) + 10
        MsgBox("O valor da idade multiplicado por 5 e somado de 10 é: " + idade.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub Btm_PontosFlutuantes_Click(sender As Object, e As EventArgs) Handles Btm_PontosFlutuantes.Click

        Dim valor As Double
        valor = 9.5
        MsgBox("A varíavel valor é : " + valor.ToString, MsgBoxStyle.Critical)

        valor = 5 / 2
        MsgBox("O valor de 5 dividido por 2 é : " + valor.ToString, MsgBoxStyle.Critical)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2
        valor = numerador / denominador
        MsgBox("O valor de 5 dividido por 2 é : " + valor.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles ConversaoNumeros.Click
        Dim Salario As Double
        Salario = 1300.45

        Dim SalarioInteiro As Integer
        SalarioInteiro = Salario
        MsgBox("O valor do Salário é : " + Salario.ToString + " e do Salário inteiro é: " + SalarioInteiro.ToString, MsgBoxStyle.Critical)

        Dim salarioGrande As Long
        salarioGrande = 1300000000000000000
        MsgBox("O valor do Salário Grande é : " + salarioGrande.ToString, MsgBoxStyle.Critical)

        Dim salarioPequeno As Short
        salarioPequeno = 1000
        MsgBox("O valor do Salário Pequeno é : " + salarioPequeno.ToString, MsgBoxStyle.Critical)

        Dim salarioMinusculo As SByte
        salarioMinusculo = 1
        MsgBox("O valor do Salário Minúsculo é : " + salarioMinusculo.ToString, MsgBoxStyle.Critical)

        Dim valorDouble As Double
        valorDouble = 9.123123123123
        MsgBox("O valor da variável Double é : " + valorDouble.ToString, MsgBoxStyle.Critical)

        Dim valorDecimal As Decimal
        valorDecimal = 9.123123123123
        MsgBox("O valor da variável Decimal é : " + valorDecimal.ToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub Btm_Resultado_Click(sender As Object, e As EventArgs) Handles Btm_Resultado.Click

        Dim numerador As Decimal
        numerador = Txt_Numerador.Text
        Dim denominador As Decimal
        denominador = Txt_Denominador.Text

        Dim resultado As Decimal
        resultado = numerador / denominador
        MsgBox("O resultado entre a divisão de : " + numerador.ToString + " por : " _
               + denominador.ToString + " é: " + resultado.ToString, MsgBoxStyle.Critical)

        Dim resultadoDouble As Double
        resultadoDouble = numerador / denominador
        MsgBox("O resultado entre a divisão de : " + numerador.ToString + " por : " _
               + denominador.ToString + " é: " + resultadoDouble.ToString, MsgBoxStyle.Critical)

        Txt_ResultadoDecimal.Text = resultado.ToString
        Txt_ResultadoDouble.Text = resultadoDouble.ToString

    End Sub
End Class
