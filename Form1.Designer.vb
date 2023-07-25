<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSuma = New Button()
        btnMoneda = New Button()
        btnVenta = New Button()
        btnCerrar = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Button4 = New Button()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSuma
        ' 
        btnSuma.Location = New Point(73, 60)
        btnSuma.Name = "btnSuma"
        btnSuma.Size = New Size(158, 23)
        btnSuma.TabIndex = 1
        btnSuma.Text = "Operaciones Matemáticas"
        btnSuma.UseVisualStyleBackColor = True
        ' 
        ' btnMoneda
        ' 
        btnMoneda.Location = New Point(369, 60)
        btnMoneda.Name = "btnMoneda"
        btnMoneda.Size = New Size(148, 23)
        btnMoneda.TabIndex = 2
        btnMoneda.Text = "Conversor de Moneda"
        btnMoneda.UseVisualStyleBackColor = True
        ' 
        ' btnVenta
        ' 
        btnVenta.Location = New Point(699, 60)
        btnVenta.Name = "btnVenta"
        btnVenta.Size = New Size(152, 23)
        btnVenta.TabIndex = 3
        btnVenta.Text = "Calculadora de Ventas"
        btnVenta.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(73, 443)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(75, 23)
        btnCerrar.TabIndex = 4
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnVenta)
        GroupBox1.Controls.Add(btnMoneda)
        GroupBox1.Controls.Add(btnCerrar)
        GroupBox1.Controls.Add(btnSuma)
        GroupBox1.Location = New Point(34, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(930, 515)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Menu Principal"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Location = New Point(34, 29)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(930, 514)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Suma"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.Window
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Location = New Point(169, 375)
        Label9.MinimumSize = New Size(121, 15)
        Label9.Name = "Label9"
        Label9.Size = New Size(121, 17)
        Label9.TabIndex = 37
        Label9.Text = " "
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(169, 375)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 36
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(73, 442)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 35
        Button3.Text = "Volver"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicación", "División", "Exponente", "Mod"})
        ComboBox1.Location = New Point(169, 36)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 33
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(53, 375)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 15)
        Label8.TabIndex = 32
        Label8.Text = "Resultado"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 314)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 31
        Label7.Text = "Número 5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(53, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 30
        Label6.Text = "Número 4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 29
        Label5.Text = "Número 3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 28
        Label4.Text = "Número 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 27
        Label3.Text = "Número 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 15)
        Label2.TabIndex = 26
        Label2.Text = "Seleccione Operación"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(567, 174)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 24
        Button2.Text = "Calcular"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(567, 106)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 23
        Button4.Text = "Limpiar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(169, 306)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(121, 23)
        TextBox5.TabIndex = 22
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(169, 256)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(121, 23)
        TextBox4.TabIndex = 21
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(169, 204)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(121, 23)
        TextBox3.TabIndex = 20
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(169, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(121, 23)
        TextBox2.TabIndex = 19
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(169, 104)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(121, 23)
        TextBox1.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 561)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnMoneda As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
End Class
