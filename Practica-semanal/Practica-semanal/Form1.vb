Public Class Form1
    Dim nombre, apellido As String
    Dim cedula, codigo, notaUno, notaDos, notaTres, notaFinal As Decimal
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        nombre = TextBox1.Text
        apellido = TextBox2.Text
        cedula = TextBox3.Text
        codigo = TextBox4.Text
        notaUno = nota1.Text
        notaDos = nota2.Text
        notaTres = nota3.Text
        notaFinal = (notaUno + notaDos + notaTres) / 3

        Label8.Text = ("El alummno " & nombre & " " & apellido & ". " & "Código: " & codigo)
        Label9.Text = ("Tiene como nota definitiva: " & notaFinal)
    End Sub
End Class
