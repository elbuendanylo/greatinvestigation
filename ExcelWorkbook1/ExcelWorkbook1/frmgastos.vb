Public Class frmgastos
    Dim gastoad As Single
    Dim gastoven As Single
    Dim i, j As Integer
    Private Sub btn_adagregar_Click(sender As Object, e As EventArgs) Handles btn_adagregar.Click
        dgv_admin.Rows.Add(txt_adnombre.Text, txt_adcosto.Text, txt_addescripcion.Text)
        txt_adnombre.Text = ""
        txt_adcosto.Text = ""
        txt_addescripcion.Text = ""
    End Sub

    Private Sub btn_admodificar_Click(sender As Object, e As EventArgs) Handles btn_admodificar.Click
        txt_adnombre.Text = dgv_admin.Item(0, i).Value
        txt_adcosto.Text = dgv_admin.Item(1, i).Value
        txt_addescripcion.Text = dgv_admin.Item(2, i).Value
    End Sub

    Private Sub btn_adeliminar_Click(sender As Object, e As EventArgs) Handles btn_adeliminar.Click
        dgv_admin.Rows.RemoveAt(i)
    End Sub

    Private Sub btn_vagregar_Click(sender As Object, e As EventArgs) Handles btn_vagregar.Click
        dgv_gventas.Rows.Add(txt_vnombre.Text, txt_vcosto.Text, txt_vdescripcion.Text)
        txt_vnombre.Text = ""
        txt_vcosto.Text = ""
        txt_vdescripcion.Text = ""
    End Sub

    Private Sub btn_vmodificar_Click(sender As Object, e As EventArgs) Handles btn_vmodificar.Click
        txt_vnombre.Text = dgv_gventas.Item(0, j).Value
        txt_vcosto.Text = dgv_gventas.Item(1, j).Value
        txt_vdescripcion.Text = dgv_gventas.Item(2, j).Value
    End Sub

    Private Sub btn_veliminar_Click(sender As Object, e As EventArgs) Handles btn_veliminar.Click
        dgv_gventas.Rows.RemoveAt(j)
    End Sub

    Private Sub dgv_admin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_admin.CellClick
        txt_adnombre.Text = dgv_admin.CurrentRow.Cells(0).Value
        txt_adcosto.Text = dgv_admin.CurrentRow.Cells(1).Value
        txt_addescripcion.Text = dgv_admin.CurrentRow.Cells(2).Value
        i = dgv_admin.Rows.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim shoja1 As Excel.Worksheet = Globals.ThisWorkbook.Sheets("Hoja1")
        Dim objetivo As Integer = shoja1.Range("B2").Value
        Dim inflacion As Single = shoja1.Range("B5").Value
        Call llenado_gastos(objetivo, inflacion)
        For a = 0 To objetivo - 1
            shoja1.Range("E10").Offset(0, a).Value = shoja1.Range("E7").Offset(0, a).Value - shoja1.Range("E8").Offset(0, a).Value - shoja1.Range("E9").Offset(0, a).Value
        Next
        Me.Close()
    End Sub

    Private Sub dgv_gventas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_gventas.CellClick
        txt_vnombre.Text = dgv_gventas.CurrentRow.Cells(0).Value
        txt_vcosto.Text = dgv_gventas.CurrentRow.Cells(1).Value
        txt_vdescripcion.Text = dgv_gventas.CurrentRow.Cells(2).Value
        j = dgv_gventas.Rows.Count
    End Sub
    Private Sub llenado_gastos(ByVal objetivo As Integer, ByVal inflacion As Single)
        Dim shoja1 As Excel.Worksheet = Globals.ThisWorkbook.Sheets("Hoja1")
        For a = 0 To dgv_admin.Rows.Count - 1
            gastoad = gastoad + dgv_admin.Item(1, a).Value * 12
        Next
        For a = 0 To dgv_gventas.Rows.Count - 1
            gastoven = gastoven + dgv_gventas.Item(1, a).Value * 12
        Next
        shoja1.Range("E8").Value = gastoven
        shoja1.Range("E9").Value = gastoad
        For a = 1 To objetivo - 1
            shoja1.Range("E8").Offset(0, a).Value = shoja1.Range("E8").Offset(0, a - 1).Value * (1 + inflacion)
            shoja1.Range("E9").Offset(0, a).Value = shoja1.Range("E9").Offset(0, a - 1).Value * (1 + inflacion)
        Next
    End Sub
End Class