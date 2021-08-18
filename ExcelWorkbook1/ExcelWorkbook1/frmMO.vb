
Public Class frmMO
    Public costototal As Integer
    Public costomo As Single
    Public costomp As Single
    Public costogif As Single
    Public objetivo As Single
    Public i, j, k As Integer
    Private Sub frmMO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objetivo = Globals.ThisWorkbook.Sheets("Hoja1").Range("B2").Value
    End Sub
    Private Sub btn_modagregar_Click_1(sender As Object, e As EventArgs) Handles btn_modagregar.Click
        Dim frm As New frminicio
        dgv_mod.Rows.Add(txt_nombre.Text, txt_cantidad.Text, txt_hora.Text, Val(txt_soles.Text))
        txt_hora.Text = ""
        txt_nombre.Text = ""
        txt_soles.Text = ""
        txt_cantidad.Text = ""
    End Sub
    Private Sub btn_modmodificar_Click_1(sender As Object, e As EventArgs) Handles btn_modmodificar.Click
        dgv_mod.Item(0, i).Value = txt_nombre.Text
        dgv_mod.Item(1, i).Value = txt_cantidad.Text
        dgv_mod.Item(2, i).Value = txt_hora.Text
        dgv_mod.Item(3, i).Value = txt_soles.Text
    End Sub
    Private Sub btn_modeliminar_Click_1(sender As Object, e As EventArgs) Handles btn_modeliminar.Click
        dgv_mod.Rows.RemoveAt(i)
    End Sub
    Private Sub dgv_mod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mod.CellClick
        txt_nombre.Text = dgv_mod.CurrentRow.Cells(0).Value
        txt_cantidad.Text = dgv_mod.CurrentRow.Cells(1).Value
        txt_hora.Text = dgv_mod.CurrentRow.Cells(2).Value
        txt_soles.Text = dgv_mod.CurrentRow.Cells(3).Value
        i = dgv_mod.CurrentRow.Index
    End Sub
    Private Sub btn_mpagregar_Click(sender As Object, e As EventArgs) Handles btn_mpagregar.Click
        dgv_mp.Rows.Add(txt_mpnombre.Text, txt_mpcantidad.Text, txt_mpcosto.Text, txt_mpdescripcion.Text)
        txt_mpnombre.Text = ""
        txt_mpcantidad.Text = ""
        txt_mpcosto.Text = ""
        txt_mpdescripcion.Text = ""
    End Sub

    Private Sub btn_mpomodificar_Click(sender As Object, e As EventArgs) Handles btn_mpomodificar.Click
        dgv_mp.Item(0, j).Value = txt_mpnombre.Text
        dgv_mp.Item(1, j).Value = txt_mpcantidad.Text
        dgv_mp.Item(2, j).Value = txt_mpcosto.Text
        dgv_mp.Item(3, j).Value = txt_mpdescripcion.Text
    End Sub
    Private Sub btn_mpeliminar_Click(sender As Object, e As EventArgs) Handles btn_mpeliminar.Click
        dgv_mp.Rows.RemoveAt(j)
    End Sub

    Private Sub dgv_mp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mp.CellClick
        txt_mpnombre.Text = dgv_mp.CurrentRow.Cells(0).Value
        txt_mpcantidad.Text = dgv_mp.CurrentRow.Cells(1).Value
        txt_mpcosto.Text = dgv_mp.CurrentRow.Cells(2).Value
        txt_mpdescripcion.Text = dgv_mp.CurrentRow.Cells(3).Value
        j = dgv_mp.CurrentRow.Index
    End Sub

    Private Sub btn_gifagregar_Click(sender As Object, e As EventArgs) Handles btn_gifagregar.Click
        dgv_gif.Rows.Add(txt_gifnombre.Text, txt_gifcosto.Text, txt_gifdescripcion.Text)
        txt_gifnombre.Text = ""
        txt_gifcosto.Text = ""
        txt_gifdescripcion.Text = ""
    End Sub

    Private Sub btn_gifmodificar_Click(sender As Object, e As EventArgs) Handles btn_gifmodificar.Click
        dgv_gif.Item(0, k).Value = txt_gifnombre.Text
        dgv_gif.Item(1, k).Value = txt_gifcosto.Text
        dgv_gif.Item(2, k).Value = txt_gifdescripcion.Text
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim a As Integer
        Dim inflacion As Single
        Dim frm As New frminicio
        Dim shoja1 As Excel.Worksheet = Globals.ThisWorkbook.Sheets("Hoja1")
        Call suma_costos()
        inflacion = shoja1.Range("B5").Value
        shoja1.Range("E6").Value = costototal
        For a = 1 To objetivo - 1
            shoja1.Range("E6").Offset(0, a).Value = shoja1.Range("E6").Offset(0, a - 1).Value * (1 + inflacion)
        Next
        For a = 0 To objetivo - 1
            shoja1.Range("E7").Offset(0, a).Value = shoja1.Range("E5").Offset(0, a).Value - shoja1.Range("E6").Offset(0, a).Value
        Next
    End Sub
    Private Sub btn_gifeliminar_Click(sender As Object, e As EventArgs) Handles btn_gifeliminar.Click
        dgv_gif.Rows.RemoveAt(k)
    End Sub
    Private Sub dgv_gif_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_gif.CellClick
        txt_gifnombre.Text = dgv_gif.CurrentRow.Cells(0).Value
        txt_gifcosto.Text = dgv_gif.CurrentRow.Cells(1).Value
        txt_gifdescripcion.Text = dgv_gif.CurrentRow.Cells(2).Value
        k = dgv_gif.CurrentRow.Index
    End Sub
    Private Sub suma_costos()
        Dim a, b, c As Integer
        For a = 0 To dgv_mod.Rows.Count - 1
            costomo = costomo + dgv_mod.Item(1, a).Value * dgv_mod.Item(2, a).Value * dgv_mod.Item(3, a).Value * 12
        Next
        For b = 0 To dgv_mp.Rows.Count - 1
            costomp = costomp + dgv_mp.Item(1, b).Value * dgv_mp.Item(2, b).Value * 12
        Next
        For c = 0 To dgv_gif.Rows.Count - 1
            costogif = costogif + dgv_gif.Item(1, c).Value * 12
        Next
        costototal = costomp + costogif + costomo
    End Sub

End Class