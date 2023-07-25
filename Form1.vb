Imports System.Runtime.Intrinsics
Imports System.Windows.Forms
Public Class Form1

    Private Sub btnMoneda_Click(sender As Object, e As EventArgs) Handles btnMoneda.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub
    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Dim operacion As String
    Dim valor1 As Double
    Dim valor2 As Double
    Dim valor3 As Double
    Dim valor4 As Double
    Dim valor5 As Double
    Dim resultado As Double
    Dim indicador1 As Boolean
    Dim indicador2 As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Double.TryParse(TextBox1.Text, valor1) Then
            indicador1 = True
        Else
            indicador1 = False
        End If
        If Double.TryParse(TextBox2.Text, valor2) Then
            indicador1 = True
        Else
            indicador1 = False
        End If
        If Double.TryParse(TextBox3.Text, valor3) Then
            indicador1 = True
        Else
            indicador1 = False
        End If
        If Double.TryParse(TextBox4.Text, valor4) Then
            indicador1 = True
        Else
            indicador1 = False
        End If
        If Double.TryParse(TextBox5.Text, valor5) Then
            indicador1 = True
        Else
            indicador1 = False
        End If
        If indicador1 = True Then
            Select Case ComboBox1.SelectedIndex
                Case 0
                    resultado = valor1 + valor2 + valor3 + valor4 + valor5
                Case 1
                    resultado = valor1 - valor2 - valor3 - valor4 - valor5
                Case 2
                    resultado = valor1 * valor2 * valor3 * valor4 * valor5
                Case 3
                    If valor2 = 0 Or valor3 = 0 Or valor4 = 0 Or valor5 = 0 Then
                        Label9.Text = "ERROR! Entrada no válida"
                    Else
                        resultado = valor1 / valor2 / valor3 / valor4 / valor5
                    End If
                Case 4
                    resultado = valor1 ^ valor2 ^ valor3 ^ valor4 ^ valor5
                Case 5
                    If valor2 = 0 Or valor3 = 0 Or valor4 = 0 Or valor5 = 0 Then
                        Label9.Text = "ERROR! Entrada no válida"
                    Else
                        resultado = valor1 Mod valor2 Mod valor3 Mod valor4 Mod valor5
                    End If
                Case Else
                    indicador2 = False
            End Select
            If indicador2 = True Then
                Label9.Text = resultado
            Else
                Label9.Text = "ERROR! Operación no seleccionada"
            End If
        Else
            Label9.Text = "ERROR! Entrada no válida"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox2.SendToBack()
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        GroupBox1.SendToBack()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ","c OrElse e.KeyChar = "."c OrElse e.KeyChar = "-"c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        ElseIf (e.KeyChar = ","c OrElse e.KeyChar = "."c) AndAlso (sender.Text.Contains(",") OrElse sender.Text.Contains(".")) Then
            e.Handled = True
        ElseIf e.KeyChar = "-"c AndAlso sender.SelectionStart <> 0 Then
            e.Handled = True
        ElseIf e.KeyChar = "-"c AndAlso sender.SelectionStart = 0 AndAlso sender.Text.Contains("-") Then
            e.Handled = True
        ElseIf sender.Text.Length >= 18 AndAlso Not Char.IsControl(e.KeyChar) AndAlso sender.SelectionLength = 0 Then
            e.Handled = True
        End If
    End Sub
End Class
