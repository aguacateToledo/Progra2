<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.checkAhorros = New System.Windows.Forms.RadioButton()
        Me.checkMonetarioPremier = New System.Windows.Forms.RadioButton()
        Me.checkMonetario = New System.Windows.Forms.RadioButton()
        Me.txtChequesP = New System.Windows.Forms.TextBox()
        Me.txtChequesOtroB = New System.Windows.Forms.TextBox()
        Me.txtEfectivos = New System.Windows.Forms.TextBox()
        Me.txtSaldoAnterior = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInteres3 = New System.Windows.Forms.TextBox()
        Me.txtInteres4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNuevoSaldo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Se puede depositar en:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tipos de depositos"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Cheques Propios", "Cheques en otros Bancos", "Efectivo"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(279, 89)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(215, 70)
        Me.CheckedListBox1.TabIndex = 9
        '
        'checkAhorros
        '
        Me.checkAhorros.AutoSize = True
        Me.checkAhorros.Location = New System.Drawing.Point(34, 149)
        Me.checkAhorros.Name = "checkAhorros"
        Me.checkAhorros.Size = New System.Drawing.Size(82, 24)
        Me.checkAhorros.TabIndex = 8
        Me.checkAhorros.TabStop = True
        Me.checkAhorros.Text = "Ahorros"
        Me.checkAhorros.UseVisualStyleBackColor = True
        '
        'checkMonetarioPremier
        '
        Me.checkMonetarioPremier.AutoSize = True
        Me.checkMonetarioPremier.Location = New System.Drawing.Point(34, 119)
        Me.checkMonetarioPremier.Name = "checkMonetarioPremier"
        Me.checkMonetarioPremier.Size = New System.Drawing.Size(154, 24)
        Me.checkMonetarioPremier.TabIndex = 7
        Me.checkMonetarioPremier.TabStop = True
        Me.checkMonetarioPremier.Text = "Monetario Premier"
        Me.checkMonetarioPremier.UseVisualStyleBackColor = True
        '
        'checkMonetario
        '
        Me.checkMonetario.AutoSize = True
        Me.checkMonetario.Location = New System.Drawing.Point(34, 89)
        Me.checkMonetario.Name = "checkMonetario"
        Me.checkMonetario.Size = New System.Drawing.Size(99, 24)
        Me.checkMonetario.TabIndex = 6
        Me.checkMonetario.TabStop = True
        Me.checkMonetario.Text = "Monetario"
        Me.checkMonetario.UseVisualStyleBackColor = True
        '
        'txtChequesP
        '
        Me.txtChequesP.Location = New System.Drawing.Point(500, 89)
        Me.txtChequesP.Name = "txtChequesP"
        Me.txtChequesP.Size = New System.Drawing.Size(125, 27)
        Me.txtChequesP.TabIndex = 12
        '
        'txtChequesOtroB
        '
        Me.txtChequesOtroB.Location = New System.Drawing.Point(500, 119)
        Me.txtChequesOtroB.Name = "txtChequesOtroB"
        Me.txtChequesOtroB.Size = New System.Drawing.Size(125, 27)
        Me.txtChequesOtroB.TabIndex = 13
        '
        'txtEfectivos
        '
        Me.txtEfectivos.Location = New System.Drawing.Point(500, 149)
        Me.txtEfectivos.Name = "txtEfectivos"
        Me.txtEfectivos.Size = New System.Drawing.Size(125, 27)
        Me.txtEfectivos.TabIndex = 14
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(657, 33)
        Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
        Me.txtSaldoAnterior.Size = New System.Drawing.Size(125, 27)
        Me.txtSaldoAnterior.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(547, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Saldo Anterior"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(279, 270)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(94, 29)
        Me.btnCalcular.TabIndex = 17
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(400, 270)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(94, 29)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Interes3"
        '
        'txtInteres3
        '
        Me.txtInteres3.Location = New System.Drawing.Point(101, 337)
        Me.txtInteres3.Name = "txtInteres3"
        Me.txtInteres3.Size = New System.Drawing.Size(125, 27)
        Me.txtInteres3.TabIndex = 20
        '
        'txtInteres4
        '
        Me.txtInteres4.Location = New System.Drawing.Point(325, 337)
        Me.txtInteres4.Name = "txtInteres4"
        Me.txtInteres4.Size = New System.Drawing.Size(125, 27)
        Me.txtInteres4.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(258, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Interes4"
        '
        'txtNuevoSaldo
        '
        Me.txtNuevoSaldo.Location = New System.Drawing.Point(585, 337)
        Me.txtNuevoSaldo.Name = "txtNuevoSaldo"
        Me.txtNuevoSaldo.Size = New System.Drawing.Size(125, 27)
        Me.txtNuevoSaldo.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(488, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "nuevo Saldo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNuevoSaldo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtInteres4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInteres3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSaldoAnterior)
        Me.Controls.Add(Me.txtEfectivos)
        Me.Controls.Add(Me.txtChequesOtroB)
        Me.Controls.Add(Me.txtChequesP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.checkAhorros)
        Me.Controls.Add(Me.checkMonetarioPremier)
        Me.Controls.Add(Me.checkMonetario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents checkAhorros As RadioButton
    Friend WithEvents checkMonetarioPremier As RadioButton
    Friend WithEvents checkMonetario As RadioButton
    Friend WithEvents txtChequesP As TextBox
    Friend WithEvents txtChequesOtroB As TextBox
    Friend WithEvents txtEfectivos As TextBox
    Friend WithEvents txtSaldoAnterior As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInteres3 As TextBox
    Friend WithEvents txtInteres4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNuevoSaldo As TextBox
    Friend WithEvents Label6 As Label
End Class
