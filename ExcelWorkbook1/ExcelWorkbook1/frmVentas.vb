Public Class frmVentas
    Dim i As Integer
    Dim objetivo As Integer
    Dim estado As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frminicio
        Dim shoja1 As Excel.Worksheet = Globals.ThisWorkbook.Sheets("Hoja1")
        Dim i As Integer = shoja1.Range("B2").Value
        Dim pbi As Single = shoja1.Range("B5").Value
        Dim ventas As Single
        If estado = 0 Then
            For a = 0 To dvg_ventas.Rows.Count - 1
                ventas = ventas + dvg_ventas.Item(1, a).Value * dvg_ventas.Item(2, a).Value * 12
            Next
        Else
            For a = 0 To dvg_ventas.Rows.Count - 1
                ventas = ventas + dvg_ventas.Item(1, a).Value * txt_precio.Text * 12
            Next
        End If
        shoja1.Range("E5").Value = ventas
        For a = 1 To i - 1
            shoja1.Range("E5").Offset(0, a).Value = shoja1.Range("E5").Offset(0, a - 1).Value * (1 + pbi)
        Next
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If estado = 0 Then
            dvg_ventas.Rows.Add(txt_nombre.Text, txt_cantidad.Text, txt_precio.Text)
            txt_nombre.Text = ""
            txt_precio.Text = ""
            txt_cantidad.Text = ""
        Else
            dvg_ventas.Rows.Add(txt_nombre.Text, txt_cantidad.Text)
            txt_nombre.Text = ""
            txt_cantidad.Text = ""
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If estado = 0 Then
            dvg_ventas.Item(0, i).Value = txt_nombre.Text
            dvg_ventas.Item(1, i).Value = txt_cantidad.Text
            dvg_ventas.Item(2, i).Value = txt_precio.Text
        Else
            dvg_ventas.Item(0, i).Value = txt_nombre.Text
            dvg_ventas.Item(1, i).Value = txt_cantidad.Text
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        dvg_ventas.Rows.RemoveAt(i)
    End Sub

    Private Sub dvg_ventas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvg_ventas.CellClick
        If estado = 0 Then
            txt_nombre.Text = dvg_ventas.CurrentRow.Cells(0).Value
            txt_cantidad.Text = dvg_ventas.CurrentRow.Cells(1).Value
            txt_precio.Text = dvg_ventas.CurrentRow.Cells(2).Value
        Else
            txt_nombre.Text = dvg_ventas.CurrentRow.Cells(0).Value
            txt_cantidad.Text = dvg_ventas.CurrentRow.Cells(1).Value
        End If
        i = dvg_ventas.CurrentRow.Index
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objetivo = Globals.ThisWorkbook.Sheets("Hoja1").Range("B2").Value
        dvg_ventas.Columns.Add("precio", "Precio de Venta")
    End Sub

    Private Sub chk_precio_CheckedChanged(sender As Object, e As EventArgs) Handles chk_precio.CheckedChanged
        If chk_precio.CheckState = CheckState.Checked Then
            estado = 1
            dvg_ventas.Columns.RemoveAt(2)
        Else
            estado = 0
            dvg_ventas.Columns.Add("precio", "Precio de Venta")
        End If
    End Sub
End Class