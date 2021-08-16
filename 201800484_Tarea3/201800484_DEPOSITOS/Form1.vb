Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub

    Sub Calcular()
        Dim chequesPriopios As Double = 0
        Dim chequesOtrosBancos As Double = 0
        Dim efecto As Double = 0
        Dim SaldoAnterior As Double = 0
        Dim saldoAdepositar As Double = 0
        Dim SaldoNuevo As Double = 0
        Dim interes3 As Double = 0
        Dim interes4 As Double = 0
        Try
            If CheckedListBox1.GetItemChecked(0) Then
                chequesPriopios = Convert.ToDouble(txtChequesP.Text)
            End If
            If CheckedListBox1.GetItemChecked(1) Then
                chequesOtrosBancos = Convert.ToDouble(txtChequesOtroB.Text)
            End If
            If CheckedListBox1.GetItemChecked(2) Then
                efecto = Convert.ToDouble(txtEfectivos.Text)
            End If
            SaldoAnterior = Convert.ToDouble(txtSaldoAnterior.Text)
            saldoAdepositar = chequesPriopios + chequesOtrosBancos + efecto
            SaldoNuevo = SaldoAnterior + saldoAdepositar
        Catch ex As Exception
            MsgBox("Valores ingresados no coinciden con un digito, si no ingresara alguno, coloque 0")
            Return
        End Try
        If CheckedListBox1.CheckedItems.Count < 1 Then
            MsgBox("Seleccione un metodo de deposito")
            Return
        End If
        If (checkAhorros.Checked Or checkMonetario.Checked Or checkMonetarioPremier.Checked) Then
            If checkAhorros.Checked Then
                interes3 = Ahorro(SaldoNuevo)
            ElseIf checkMonetarioPremier.Checked Then
                interes4 = Monetario(SaldoAnterior)
            End If

            txtInteres3.Text = interes3
            txtInteres4.Text = interes4
            SaldoNuevo = interes3 + interes4
            txtNuevoSaldo.Text = SaldoNuevo
        Else
            MsgBox("Seleccione algun tipo de deposito")
        End If
    End Sub

    Function Monetario(SaldoAnterior As Double) As Double
        Dim interes As Double = 0
        Select Case SaldoAnterior
            Case 0 To 1000
                interes = SaldoAnterior * 0.025
            Case 1001 To 15000
                interes = SaldoAnterior * 0.03
            Case Is >= 15001
                interes = SaldoAnterior * 0.045
            Case Else

        End Select
        Return interes
    End Function
    Function Ahorro(SaldoNuevo As Double) As Double
        Dim interes As Double = 0
        Dim probar As Boolean = SaldoNuevo >= 1001 And SaldoNuevo < 5001
        Select Case SaldoNuevo
            Case 0 To 1000
                interes = SaldoNuevo * 0.015
            Case 1001 To 5000
                interes = SaldoNuevo * 0.025
            Case 5001 To 15000
                interes = SaldoNuevo * 0.075
            Case Is >= 15001
                interes = SaldoNuevo * 0.1
            Case Else

        End Select
        Return interes
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInteres3.TextChanged

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtChequesOtroB.Text = ""
        txtChequesP.Text = ""
        txtEfectivos.Text = ""
        txtInteres3.Text = ""
        txtInteres4.Text = ""
        txtNuevoSaldo.Text = ""
        txtSaldoAnterior.Text = ""
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Si cierra la aplicacion no se guardaran los cambios, realmente desea salir?", MsgBoxStyle.YesNo, "Salir?") = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class
