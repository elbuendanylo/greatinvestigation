
Public Class Hoja1
    Dim frmmo As New frmMO
    Dim frmven As New frmVentas
    Dim frmgas As New frmgastos
    Private Sub Hoja1_Startup() Handles Me.Startup

    End Sub

    Private Sub Hoja1_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmmo.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmven.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmgas.ShowDialog()
    End Sub
End Class
