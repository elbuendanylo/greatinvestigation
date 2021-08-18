<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_soles = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_modeliminar = New System.Windows.Forms.Button()
        Me.btn_modmodificar = New System.Windows.Forms.Button()
        Me.btn_modagregar = New System.Windows.Forms.Button()
        Me.dgv_mod = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ho_trabajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_mpcantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_mpdescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_mpcosto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_mpnombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_mpeliminar = New System.Windows.Forms.Button()
        Me.btn_mpomodificar = New System.Windows.Forms.Button()
        Me.btn_mpagregar = New System.Windows.Forms.Button()
        Me.dgv_mp = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_gifdescripcion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_gifcosto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_gifnombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_gifeliminar = New System.Windows.Forms.Button()
        Me.btn_gifmodificar = New System.Windows.Forms.Button()
        Me.btn_gifagregar = New System.Windows.Forms.Button()
        Me.dgv_gif = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_mod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_mp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_gif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(423, 332)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_cantidad)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_soles)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_hora)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_nombre)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btn_modeliminar)
        Me.TabPage1.Controls.Add(Me.btn_modmodificar)
        Me.TabPage1.Controls.Add(Me.btn_modagregar)
        Me.TabPage1.Controls.Add(Me.dgv_mod)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(415, 306)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mano de Obra"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(203, 38)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(36, 20)
        Me.txt_cantidad.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Los datos deben ser estimados en meses"
        '
        'txt_soles
        '
        Me.txt_soles.Location = New System.Drawing.Point(124, 90)
        Me.txt_soles.Name = "txt_soles"
        Me.txt_soles.Size = New System.Drawing.Size(115, 20)
        Me.txt_soles.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Horas de Trabajo"
        '
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(124, 64)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(115, 20)
        Me.txt_hora.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "S/. por Hora"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(124, 12)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(115, 20)
        Me.txt_nombre.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre"
        '
        'btn_modeliminar
        '
        Me.btn_modeliminar.Location = New System.Drawing.Point(265, 90)
        Me.btn_modeliminar.Name = "btn_modeliminar"
        Me.btn_modeliminar.Size = New System.Drawing.Size(116, 23)
        Me.btn_modeliminar.TabIndex = 16
        Me.btn_modeliminar.Text = "Eliminar"
        Me.btn_modeliminar.UseVisualStyleBackColor = True
        '
        'btn_modmodificar
        '
        Me.btn_modmodificar.Location = New System.Drawing.Point(265, 54)
        Me.btn_modmodificar.Name = "btn_modmodificar"
        Me.btn_modmodificar.Size = New System.Drawing.Size(116, 23)
        Me.btn_modmodificar.TabIndex = 15
        Me.btn_modmodificar.Text = "Modificar"
        Me.btn_modmodificar.UseVisualStyleBackColor = True
        '
        'btn_modagregar
        '
        Me.btn_modagregar.Location = New System.Drawing.Point(265, 15)
        Me.btn_modagregar.Name = "btn_modagregar"
        Me.btn_modagregar.Size = New System.Drawing.Size(116, 23)
        Me.btn_modagregar.TabIndex = 14
        Me.btn_modagregar.Text = "Agregar"
        Me.btn_modagregar.UseVisualStyleBackColor = True
        '
        'dgv_mod
        '
        Me.dgv_mod.AllowUserToAddRows = False
        Me.dgv_mod.AllowUserToDeleteRows = False
        Me.dgv_mod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.cantidad, Me.ho_trabajo, Me.S_hora})
        Me.dgv_mod.Location = New System.Drawing.Point(25, 128)
        Me.dgv_mod.Name = "dgv_mod"
        Me.dgv_mod.ReadOnly = True
        Me.dgv_mod.Size = New System.Drawing.Size(364, 150)
        Me.dgv_mod.TabIndex = 13
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'ho_trabajo
        '
        Me.ho_trabajo.HeaderText = "Horas de Trabajo"
        Me.ho_trabajo.Name = "ho_trabajo"
        Me.ho_trabajo.ReadOnly = True
        '
        'S_hora
        '
        Me.S_hora.HeaderText = "S/. por Hora"
        Me.S_hora.Name = "S_hora"
        Me.S_hora.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_mpcantidad)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_mpdescripcion)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_mpcosto)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txt_mpnombre)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.btn_mpeliminar)
        Me.TabPage2.Controls.Add(Me.btn_mpomodificar)
        Me.TabPage2.Controls.Add(Me.btn_mpagregar)
        Me.TabPage2.Controls.Add(Me.dgv_mp)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(415, 306)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Costo de Materia Prima"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_mpcantidad
        '
        Me.txt_mpcantidad.Location = New System.Drawing.Point(61, 41)
        Me.txt_mpcantidad.Name = "txt_mpcantidad"
        Me.txt_mpcantidad.Size = New System.Drawing.Size(36, 20)
        Me.txt_mpcantidad.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Los datos deben ser estimados en meses"
        '
        'txt_mpdescripcion
        '
        Me.txt_mpdescripcion.Location = New System.Drawing.Point(77, 75)
        Me.txt_mpdescripcion.Multiline = True
        Me.txt_mpdescripcion.Name = "txt_mpdescripcion"
        Me.txt_mpdescripcion.Size = New System.Drawing.Size(162, 47)
        Me.txt_mpdescripcion.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Costo"
        '
        'txt_mpcosto
        '
        Me.txt_mpcosto.Location = New System.Drawing.Point(143, 41)
        Me.txt_mpcosto.Name = "txt_mpcosto"
        Me.txt_mpcosto.Size = New System.Drawing.Size(96, 20)
        Me.txt_mpcosto.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Descripcion"
        '
        'txt_mpnombre
        '
        Me.txt_mpnombre.Location = New System.Drawing.Point(124, 12)
        Me.txt_mpnombre.Name = "txt_mpnombre"
        Me.txt_mpnombre.Size = New System.Drawing.Size(115, 20)
        Me.txt_mpnombre.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(74, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Nombre"
        '
        'btn_mpeliminar
        '
        Me.btn_mpeliminar.Location = New System.Drawing.Point(265, 90)
        Me.btn_mpeliminar.Name = "btn_mpeliminar"
        Me.btn_mpeliminar.Size = New System.Drawing.Size(116, 23)
        Me.btn_mpeliminar.TabIndex = 29
        Me.btn_mpeliminar.Text = "Eliminar"
        Me.btn_mpeliminar.UseVisualStyleBackColor = True
        '
        'btn_mpomodificar
        '
        Me.btn_mpomodificar.Location = New System.Drawing.Point(265, 54)
        Me.btn_mpomodificar.Name = "btn_mpomodificar"
        Me.btn_mpomodificar.Size = New System.Drawing.Size(116, 23)
        Me.btn_mpomodificar.TabIndex = 28
        Me.btn_mpomodificar.Text = "Modificar"
        Me.btn_mpomodificar.UseVisualStyleBackColor = True
        '
        'btn_mpagregar
        '
        Me.btn_mpagregar.Location = New System.Drawing.Point(265, 15)
        Me.btn_mpagregar.Name = "btn_mpagregar"
        Me.btn_mpagregar.Size = New System.Drawing.Size(116, 23)
        Me.btn_mpagregar.TabIndex = 27
        Me.btn_mpagregar.Text = "Agregar"
        Me.btn_mpagregar.UseVisualStyleBackColor = True
        '
        'dgv_mp
        '
        Me.dgv_mp.AllowUserToAddRows = False
        Me.dgv_mp.AllowUserToDeleteRows = False
        Me.dgv_mp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgv_mp.Location = New System.Drawing.Point(25, 128)
        Me.dgv_mp.Name = "dgv_mp"
        Me.dgv_mp.ReadOnly = True
        Me.dgv_mp.Size = New System.Drawing.Size(364, 150)
        Me.dgv_mp.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txt_gifdescripcion)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.txt_gifcosto)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txt_gifnombre)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.btn_gifeliminar)
        Me.TabPage3.Controls.Add(Me.btn_gifmodificar)
        Me.TabPage3.Controls.Add(Me.btn_gifagregar)
        Me.TabPage3.Controls.Add(Me.dgv_gif)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(415, 306)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gastos Indirectos de Fabricacion"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 281)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(201, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Los datos deben ser estimados en meses"
        '
        'txt_gifdescripcion
        '
        Me.txt_gifdescripcion.Location = New System.Drawing.Point(81, 75)
        Me.txt_gifdescripcion.Multiline = True
        Me.txt_gifdescripcion.Name = "txt_gifdescripcion"
        Me.txt_gifdescripcion.Size = New System.Drawing.Size(162, 47)
        Me.txt_gifdescripcion.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(107, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Costo"
        '
        'txt_gifcosto
        '
        Me.txt_gifcosto.Location = New System.Drawing.Point(147, 41)
        Me.txt_gifcosto.Name = "txt_gifcosto"
        Me.txt_gifcosto.Size = New System.Drawing.Size(96, 20)
        Me.txt_gifcosto.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Descripcion"
        '
        'txt_gifnombre
        '
        Me.txt_gifnombre.Location = New System.Drawing.Point(128, 12)
        Me.txt_gifnombre.Name = "txt_gifnombre"
        Me.txt_gifnombre.Size = New System.Drawing.Size(115, 20)
        Me.txt_gifnombre.TabIndex = 44
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(78, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Nombre"
        '
        'btn_gifeliminar
        '
        Me.btn_gifeliminar.Location = New System.Drawing.Point(269, 90)
        Me.btn_gifeliminar.Name = "btn_gifeliminar"
        Me.btn_gifeliminar.Size = New System.Drawing.Size(116, 23)
        Me.btn_gifeliminar.TabIndex = 42
        Me.btn_gifeliminar.Text = "Eliminar"
        Me.btn_gifeliminar.UseVisualStyleBackColor = True
        '
        'btn_gifmodificar
        '
        Me.btn_gifmodificar.Location = New System.Drawing.Point(269, 54)
        Me.btn_gifmodificar.Name = "btn_gifmodificar"
        Me.btn_gifmodificar.Size = New System.Drawing.Size(116, 23)
        Me.btn_gifmodificar.TabIndex = 41
        Me.btn_gifmodificar.Text = "Modificar"
        Me.btn_gifmodificar.UseVisualStyleBackColor = True
        '
        'btn_gifagregar
        '
        Me.btn_gifagregar.Location = New System.Drawing.Point(269, 15)
        Me.btn_gifagregar.Name = "btn_gifagregar"
        Me.btn_gifagregar.Size = New System.Drawing.Size(116, 23)
        Me.btn_gifagregar.TabIndex = 40
        Me.btn_gifagregar.Text = "Agregar"
        Me.btn_gifagregar.UseVisualStyleBackColor = True
        '
        'dgv_gif
        '
        Me.dgv_gif.AllowUserToAddRows = False
        Me.dgv_gif.AllowUserToDeleteRows = False
        Me.dgv_gif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gif.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgv_gif.Location = New System.Drawing.Point(29, 128)
        Me.dgv_gif.Name = "dgv_gif"
        Me.dgv_gif.ReadOnly = True
        Me.dgv_gif.Size = New System.Drawing.Size(364, 150)
        Me.dgv_gif.TabIndex = 39
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(72, 347)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(142, 23)
        Me.btn_aceptar.TabIndex = 14
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(256, 347)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(142, 23)
        Me.btn_salir.TabIndex = 15
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'frmMO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 382)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMO"
        Me.Text = "Costo de Ventas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_mod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_mp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgv_gif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_soles As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_hora As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_modeliminar As Button
    Friend WithEvents btn_modmodificar As Button
    Friend WithEvents btn_modagregar As Button
    Friend WithEvents dgv_mod As DataGridView
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents ho_trabajo As DataGridViewTextBoxColumn
    Friend WithEvents S_hora As DataGridViewTextBoxColumn
    Friend WithEvents txt_mpcantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_mpdescripcion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_mpcosto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_mpnombre As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_mpeliminar As Button
    Friend WithEvents btn_mpomodificar As Button
    Friend WithEvents btn_mpagregar As Button
    Friend WithEvents dgv_mp As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_gifdescripcion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_gifcosto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_gifnombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_gifeliminar As Button
    Friend WithEvents btn_gifmodificar As Button
    Friend WithEvents btn_gifagregar As Button
    Friend WithEvents dgv_gif As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
