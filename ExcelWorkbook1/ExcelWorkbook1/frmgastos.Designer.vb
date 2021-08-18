<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgastos
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_addescripcion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_adcosto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_adnombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_adeliminar = New System.Windows.Forms.Button()
        Me.btn_admodificar = New System.Windows.Forms.Button()
        Me.btn_adagregar = New System.Windows.Forms.Button()
        Me.dgv_admin = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_vdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_vcosto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_vnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_veliminar = New System.Windows.Forms.Button()
        Me.btn_vmodificar = New System.Windows.Forms.Button()
        Me.btn_vagregar = New System.Windows.Forms.Button()
        Me.dgv_gventas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_gventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(424, 321)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txt_addescripcion)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txt_adcosto)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txt_adnombre)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.btn_adeliminar)
        Me.TabPage1.Controls.Add(Me.btn_admodificar)
        Me.TabPage1.Controls.Add(Me.btn_adagregar)
        Me.TabPage1.Controls.Add(Me.dgv_admin)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(416, 295)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gastos Administrativos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(201, 13)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Los datos deben ser estimados en meses"
        '
        'txt_addescripcion
        '
        Me.txt_addescripcion.Location = New System.Drawing.Point(78, 71)
        Me.txt_addescripcion.Multiline = True
        Me.txt_addescripcion.Name = "txt_addescripcion"
        Me.txt_addescripcion.Size = New System.Drawing.Size(162, 47)
        Me.txt_addescripcion.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(104, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Costo"
        '
        'txt_adcosto
        '
        Me.txt_adcosto.Location = New System.Drawing.Point(144, 37)
        Me.txt_adcosto.Name = "txt_adcosto"
        Me.txt_adcosto.Size = New System.Drawing.Size(96, 20)
        Me.txt_adcosto.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Descripcion"
        '
        'txt_adnombre
        '
        Me.txt_adnombre.Location = New System.Drawing.Point(125, 8)
        Me.txt_adnombre.Name = "txt_adnombre"
        Me.txt_adnombre.Size = New System.Drawing.Size(115, 20)
        Me.txt_adnombre.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(75, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Nombre"
        '
        'btn_adeliminar
        '
        Me.btn_adeliminar.Location = New System.Drawing.Point(266, 86)
        Me.btn_adeliminar.Name = "btn_adeliminar"
        Me.btn_adeliminar.Size = New System.Drawing.Size(116, 23)
        Me.btn_adeliminar.TabIndex = 53
        Me.btn_adeliminar.Text = "Eliminar"
        Me.btn_adeliminar.UseVisualStyleBackColor = True
        '
        'btn_admodificar
        '
        Me.btn_admodificar.Location = New System.Drawing.Point(266, 50)
        Me.btn_admodificar.Name = "btn_admodificar"
        Me.btn_admodificar.Size = New System.Drawing.Size(116, 23)
        Me.btn_admodificar.TabIndex = 52
        Me.btn_admodificar.Text = "Modificar"
        Me.btn_admodificar.UseVisualStyleBackColor = True
        '
        'btn_adagregar
        '
        Me.btn_adagregar.Location = New System.Drawing.Point(266, 11)
        Me.btn_adagregar.Name = "btn_adagregar"
        Me.btn_adagregar.Size = New System.Drawing.Size(116, 23)
        Me.btn_adagregar.TabIndex = 51
        Me.btn_adagregar.Text = "Agregar"
        Me.btn_adagregar.UseVisualStyleBackColor = True
        '
        'dgv_admin
        '
        Me.dgv_admin.AllowUserToAddRows = False
        Me.dgv_admin.AllowUserToDeleteRows = False
        Me.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_admin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgv_admin.Location = New System.Drawing.Point(36, 122)
        Me.dgv_admin.Name = "dgv_admin"
        Me.dgv_admin.ReadOnly = True
        Me.dgv_admin.Size = New System.Drawing.Size(364, 150)
        Me.dgv_admin.TabIndex = 50
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txt_vdescripcion)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txt_vcosto)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt_vnombre)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btn_veliminar)
        Me.TabPage2.Controls.Add(Me.btn_vmodificar)
        Me.TabPage2.Controls.Add(Me.btn_vagregar)
        Me.TabPage2.Controls.Add(Me.dgv_gventas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(416, 295)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gastos de Ventas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Los datos deben ser estimados en meses"
        '
        'txt_vdescripcion
        '
        Me.txt_vdescripcion.Location = New System.Drawing.Point(83, 70)
        Me.txt_vdescripcion.Multiline = True
        Me.txt_vdescripcion.Name = "txt_vdescripcion"
        Me.txt_vdescripcion.Size = New System.Drawing.Size(162, 47)
        Me.txt_vdescripcion.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Costo"
        '
        'txt_vcosto
        '
        Me.txt_vcosto.Location = New System.Drawing.Point(149, 36)
        Me.txt_vcosto.Name = "txt_vcosto"
        Me.txt_vcosto.Size = New System.Drawing.Size(96, 20)
        Me.txt_vcosto.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Descripcion"
        '
        'txt_vnombre
        '
        Me.txt_vnombre.Location = New System.Drawing.Point(130, 7)
        Me.txt_vnombre.Name = "txt_vnombre"
        Me.txt_vnombre.Size = New System.Drawing.Size(115, 20)
        Me.txt_vnombre.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Nombre"
        '
        'btn_veliminar
        '
        Me.btn_veliminar.Location = New System.Drawing.Point(271, 85)
        Me.btn_veliminar.Name = "btn_veliminar"
        Me.btn_veliminar.Size = New System.Drawing.Size(116, 23)
        Me.btn_veliminar.TabIndex = 64
        Me.btn_veliminar.Text = "Eliminar"
        Me.btn_veliminar.UseVisualStyleBackColor = True
        '
        'btn_vmodificar
        '
        Me.btn_vmodificar.Location = New System.Drawing.Point(271, 49)
        Me.btn_vmodificar.Name = "btn_vmodificar"
        Me.btn_vmodificar.Size = New System.Drawing.Size(116, 23)
        Me.btn_vmodificar.TabIndex = 63
        Me.btn_vmodificar.Text = "Modificar"
        Me.btn_vmodificar.UseVisualStyleBackColor = True
        '
        'btn_vagregar
        '
        Me.btn_vagregar.Location = New System.Drawing.Point(271, 10)
        Me.btn_vagregar.Name = "btn_vagregar"
        Me.btn_vagregar.Size = New System.Drawing.Size(116, 23)
        Me.btn_vagregar.TabIndex = 62
        Me.btn_vagregar.Text = "Agregar"
        Me.btn_vagregar.UseVisualStyleBackColor = True
        '
        'dgv_gventas
        '
        Me.dgv_gventas.AllowUserToAddRows = False
        Me.dgv_gventas.AllowUserToDeleteRows = False
        Me.dgv_gventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgv_gventas.Location = New System.Drawing.Point(41, 121)
        Me.dgv_gventas.Name = "dgv_gventas"
        Me.dgv_gventas.ReadOnly = True
        Me.dgv_gventas.Size = New System.Drawing.Size(364, 150)
        Me.dgv_gventas.TabIndex = 61
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmgastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 368)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmgastos"
        Me.Text = "Gastos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_admin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_gventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_addescripcion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_adcosto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_adnombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_adeliminar As Button
    Friend WithEvents btn_admodificar As Button
    Friend WithEvents btn_adagregar As Button
    Friend WithEvents dgv_admin As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_vdescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_vcosto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_vnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_veliminar As Button
    Friend WithEvents btn_vmodificar As Button
    Friend WithEvents btn_vagregar As Button
    Friend WithEvents dgv_gventas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
