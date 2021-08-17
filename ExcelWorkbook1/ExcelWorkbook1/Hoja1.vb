
Public Class Hoja1
    Dim frm As New frmMO
    Private Sub Hoja1_Startup() Handles Me.Startup

    End Sub

    Private Sub Hoja1_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm.ShowDialog()
    End Sub
End Class
