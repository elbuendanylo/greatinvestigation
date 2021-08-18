Public Class frminicio
    Public costoventas As Single
    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Globals.ThisWorkbook.FollowHyperlink("https://www.youtube.com/watch?v=CR8miLg0SIg&t=1s&ab_channel=EBCAcademia")
    End Sub

    Public Sub btn_empezar_Click(sender As Object, e As EventArgs) Handles btn_empezar.Click
        Dim shoja1 As Excel.Worksheet = Globals.ThisWorkbook.Sheets("Hoja1")
        Dim objetivo As Integer
        objetivo = txt_duracion.Value
        shoja1.Range("B2").Value = objetivo
        Dim fechas As Date = DateTimePicker1.Value
        shoja1.Range("B1").Value = txt_nombre.Text
        For i = 0 To objetivo - 1
            shoja1.Range("E4").Offset(0, i).Value = "Año" + Str(i + Year(fechas))
        Next
        frminicio.ActiveForm.Close()
        Call pbi()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        frminicio.ActiveForm.Close()
        Globals.ThisWorkbook.Close()
    End Sub

    Private Sub frminicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_sectores.Items.Add("Agropecuario")
        cb_sectores.Items.Add("Pesca")
        cb_sectores.Items.Add("Mineria")
        cb_sectores.Items.Add("Manufactura")
        cb_sectores.Items.Add("Electricidad y Agua")
        cb_sectores.Items.Add("Construccion")
        cb_sectores.Items.Add("Comercio")
        cb_sectores.Items.Add("Servicios")
    End Sub
    Private Sub pbi()
        Dim shoja1 As Excel.Worksheet = Globals.ThisWorkbook.Sheets("Hoja1")
        Select Case cb_sectores.Text
            Case "Agropecuario"
                shoja1.Range("B4").Value = (30861 - 30471) / 30471
            Case "Pesca"
                shoja1.Range("B4").Value = (2400 - 2351) / 2351
            Case "Mineria"
                shoja1.Range("B4").Value = (61202 - 70715) / 70715
            Case "Manufactura"
                shoja1.Range("B4").Value = (58617 - 67336) / 67336
            Case "Electricidad y Agua"
                shoja1.Range("B4").Value = (9585 - 10212) / 10212
            Case "Construccion"
                shoja1.Range("B4").Value = (27381 - 31788) / 31788
            Case "Comercio"
                shoja1.Range("B4").Value = (49539 - 58960) / 58960
            Case "Servicios"
                shoja1.Range("B4").Value = (246045 - 274328) / 274328
        End Select
    End Sub
End Class