Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) AndAlso sender.Text.Length >= 7 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cantidad_cola As Integer
        Dim cantidad_naranja As Integer
        Dim cantidad_limon As Integer
        Dim total_cola As Double
        Dim total_naranja As Double
        Dim total_limon As Double
        Dim total_final As Double
        Dim indicador_cola As Boolean = True
        Dim indicador_naranja As Boolean = True
        Dim indicador_limon As Boolean = True
        If Integer.TryParse(TextBox1.Text, cantidad_cola) Then
            If cantidad_cola <= 5000000 Then
                total_cola = cantidad_cola * 0.17
                TextBox7.Text = total_cola.ToString("0.00")
            Else
                indicador_cola = False
                TextBox7.Text = "Entrada No Válida"
            End If
        Else
            indicador_cola = False
            TextBox7.Text = "Entrada No Válida"
        End If
        If Integer.TryParse(TextBox2.Text, cantidad_naranja) Then
            If cantidad_naranja <= 5000000 Then
                total_naranja = cantidad_naranja * 0.2
                TextBox6.Text = total_naranja.ToString("0.00")
            Else
                indicador_naranja = False
                TextBox6.Text = "Entrada No Válida"
            End If
        Else
            indicador_naranja = False
            TextBox6.Text = "Entrada No Válida"
        End If
        If Integer.TryParse(TextBox3.Text, cantidad_limon) Then
            If cantidad_limon <= 5000000 Then
                total_limon = cantidad_limon * 0.19
                TextBox5.Text = total_limon.ToString("0.00")
            Else
                indicador_limon = False
                TextBox5.Text = "Entrada No Válida"
            End If
        Else
            indicador_limon = False
            TextBox5.Text = "Entrada No Válida"
        End If
        total_final = total_cola + total_naranja + total_limon
        If indicador_cola = True And indicador_naranja = True And indicador_limon = True Then
            TextBox4.Text = total_final.ToString("0.00")
        Else
            TextBox4.Text = "Entrada No Válida"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty
    End Sub
End Class