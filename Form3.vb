Public Class Form3
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ","c OrElse e.KeyChar = "."c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        ElseIf (e.KeyChar = ","c OrElse e.KeyChar = "."c) AndAlso (sender.Text.Contains(",") OrElse sender.Text.Contains(".")) Then
            e.Handled = True
        ElseIf sender.Text.Contains(",") OrElse sender.Text.Contains(".") Then
            Dim decimalSeparator As Char = If(sender.Text.Contains(","), ",", ".")
            Dim decimalIndex As Integer = sender.Text.IndexOf(decimalSeparator)
            If sender.SelectionStart > decimalIndex AndAlso sender.Text.Substring(decimalIndex).Length >= 3 Then
                If e.KeyChar <> ControlChars.Back Then
                    e.Handled = True
                End If
            End If
        ElseIf Char.IsDigit(e.KeyChar) AndAlso sender.Text.Length >= 18 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim moneda_entrada As Double
        Dim moneda_salida As Double
        Dim indicador1 As Boolean = True
        Dim indicador2 As Boolean = True
        Select Case ComboBox1.SelectedIndex
            Case 0
                moneda_entrada = 1
            Case 1
                moneda_entrada = 0.92
            Case 2
                moneda_entrada = 7
            Case 3
                moneda_entrada = 137.64
            Case 4
                moneda_entrada = 0.8
            Case Else
                indicador1 = False
        End Select
        Select Case ComboBox2.SelectedIndex
            Case 0
                moneda_salida = 1
            Case 1
                moneda_salida = 0.92
            Case 2
                moneda_salida = 7
            Case 3
                moneda_salida = 137.64
            Case 4
                moneda_salida = 0.8
            Case Else
                indicador2 = False
        End Select
        Dim numero_entrada As Double
        If indicador1 = True And indicador2 = True Then
            If Double.TryParse(TextBox1.Text, numero_entrada) Then
                Dim numero_salida As Double = numero_entrada * (moneda_salida / moneda_entrada)
                TextBox2.Text = numero_salida.ToString("0.00")
            Else
                TextBox2.Text = "Selección No Válida"
            End If
        Else
            TextBox1.Text = "Selección No Válida"
            TextBox2.Text = "Selección No Válida"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class