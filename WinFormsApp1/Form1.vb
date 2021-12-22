Public Class Form1
    Dim tituloError As String = "Error al introducir datos"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1.Text = "Este es un No. 1"


    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        OPERACIONES("sumar")
    End Sub
    Private Sub OPERACIONES(operacion As String)
        Dim resultado As Integer
        Try
            Select Case operacion
                Case "sumar"
                    resultado = CInt(txtNumero1.Text) + CInt(txtNumero2.Text)
                Case "restar"
                    resultado = CInt(txtNumero1.Text) - CInt(txtNumero2.Text)
                Case "multiplicar"
                    resultado = CInt(txtNumero1.Text) * CInt(txtNumero2.Text)
                Case "dividir"
                    resultado = CInt(txtNumero1.Text) / CInt(txtNumero2.Text)
            End Select
        Catch ex As InvalidCastException
            MessageBox.Show("No se permite introducir letras", tituloError + " [" + operacion + "]")
        Catch ex As System.OverflowException
            MessageBox.Show("No se permite división entre cero", tituloError + " [" + operacion + "]")
        Finally
            txtResultado.Text = resultado.ToString()
        End Try
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        OPERACIONES("restar")
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        OPERACIONES("multiplicar")
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        OPERACIONES("dividir")
    End Sub
End Class
