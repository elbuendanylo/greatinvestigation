Public Class frminicio
    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Globals.ThisWorkbook.FollowHyperlink("https://www.youtube.com/watch?v=CR8miLg0SIg&t=1s&ab_channel=EBCAcademia")
    End Sub

    Private Sub btn_empezar_Click(sender As Object, e As EventArgs) Handles btn_empezar.Click
        Dim shoja1 As Excel.Worksheet = Globals.ThisWorkbook.Sheets("Hoja1")
        Dim objetivo As Integer = txt_duracion.Value
        Dim fechas As Date = DateTimePicker1.Value
        shoja1.Range("A1").Value = "Nombre de la Empresa"
        shoja1.Range("B1").Value = txt_nombre.Text
        For i = 1 To objetivo
            shoja1.Range("B5").Offset(0, i).Value = "Año" + Str(i + Year(fechas))
        Next
        frminicio.ActiveForm.Close()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        frminicio.ActiveForm.Close()
        Globals.ThisWorkbook.Close()
    End Sub
End Class