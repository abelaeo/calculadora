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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1"
        '
        'txtNumero1
        '
        Me.txtNumero1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumero1.Location = New System.Drawing.Point(118, 23)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(114, 32)
        Me.txtNumero1.TabIndex = 1
        '
        'txtNumero2
        '
        Me.txtNumero2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumero2.Location = New System.Drawing.Point(361, 27)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(114, 32)
        Me.txtNumero2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(255, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Número 2"
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtResultado.Location = New System.Drawing.Point(665, 27)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(114, 32)
        Me.txtResultado.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(525, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RESULTADO"
        '
        'btnSumar
        '
        Me.btnSumar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSumar.Location = New System.Drawing.Point(75, 110)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(179, 139)
        Me.btnSumar.TabIndex = 6
        Me.btnSumar.Text = "Sumar"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRestar.Location = New System.Drawing.Point(296, 110)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(179, 139)
        Me.btnRestar.TabIndex = 7
        Me.btnRestar.Text = "Restar"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiplicar.Location = New System.Drawing.Point(75, 255)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(179, 139)
        Me.btnMultiplicar.TabIndex = 8
        Me.btnMultiplicar.Text = "Multiplicar"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDividir.Location = New System.Drawing.Point(296, 255)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(179, 139)
        Me.btnDividir.TabIndex = 9
        Me.btnDividir.Text = "Dividir"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
End Class
