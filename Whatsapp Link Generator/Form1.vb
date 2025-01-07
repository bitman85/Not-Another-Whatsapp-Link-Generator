Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim telefono As String = tb_tel.Text
        If Len(Trim(telefono)) > 0 Then
            Dim enlace As String = "https://wa.me/34" & telefono
            Process.Start("chrome.exe", enlace)
        Else
            MessageBox.Show("Introduce un telefono")
        End If



    End Sub
End Class
