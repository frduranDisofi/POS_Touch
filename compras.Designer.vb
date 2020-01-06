<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TipodocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_doc_DataSet = New delevery.tipo_doc_DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tipo_docTableAdapter = New delevery.tipo_doc_DataSetTableAdapters.tipo_docTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.uic_codigo = New System.Windows.Forms.TextBox()
        Me.uic_descripcion = New System.Windows.Forms.TextBox()
        Me.uic_cantidad = New System.Windows.Forms.TextBox()
        Me.uic_neto = New System.Windows.Forms.TextBox()
        Me.uic_precio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.uic_total = New System.Windows.Forms.TextBox()
        Me.uic_IVA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.uic_grabar = New System.Windows.Forms.Button()
        Me.uic_salir = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.uic_familia = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.uic_Productos = New System.Windows.Forms.ComboBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        CType(Me.TipodocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo_doc_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(603, 51)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'TipodocBindingSource
        '
        Me.TipodocBindingSource.DataMember = "tipo_doc"
        Me.TipodocBindingSource.DataSource = Me.Tipo_doc_DataSet
        '
        'Tipo_doc_DataSet
        '
        Me.Tipo_doc_DataSet.DataSetName = "tipo_doc_DataSet"
        Me.Tipo_doc_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(484, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Fecha Documento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tipo_docTableAdapter
        '
        Me.Tipo_docTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(528, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Folio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(603, 12)
        Me.txt_folio.MaxLength = 12
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(82, 20)
        Me.txt_folio.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descripcion, Me.cantidad, Me.eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(466, 256)
        Me.DataGridView1.TabIndex = 119
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 222
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 50
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 50
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(57, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 23)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Codigo"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(161, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 23)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Descripcion"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(527, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Cantidad"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(696, 164)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(94, 60)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'uic_codigo
        '
        Me.uic_codigo.Location = New System.Drawing.Point(57, 302)
        Me.uic_codigo.Name = "uic_codigo"
        Me.uic_codigo.Size = New System.Drawing.Size(98, 20)
        Me.uic_codigo.TabIndex = 5
        Me.uic_codigo.Visible = False
        '
        'uic_descripcion
        '
        Me.uic_descripcion.Location = New System.Drawing.Point(161, 302)
        Me.uic_descripcion.Name = "uic_descripcion"
        Me.uic_descripcion.Size = New System.Drawing.Size(210, 20)
        Me.uic_descripcion.TabIndex = 6
        Me.uic_descripcion.Visible = False
        '
        'uic_cantidad
        '
        Me.uic_cantidad.Location = New System.Drawing.Point(603, 164)
        Me.uic_cantidad.Name = "uic_cantidad"
        Me.uic_cantidad.Size = New System.Drawing.Size(82, 20)
        Me.uic_cantidad.TabIndex = 7
        '
        'uic_neto
        '
        Me.uic_neto.Enabled = False
        Me.uic_neto.Location = New System.Drawing.Point(479, 274)
        Me.uic_neto.Name = "uic_neto"
        Me.uic_neto.Size = New System.Drawing.Size(100, 20)
        Me.uic_neto.TabIndex = 16
        Me.uic_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'uic_precio
        '
        Me.uic_precio.Location = New System.Drawing.Point(377, 302)
        Me.uic_precio.Name = "uic_precio"
        Me.uic_precio.Size = New System.Drawing.Size(44, 20)
        Me.uic_precio.TabIndex = 8
        Me.uic_precio.Visible = False
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(377, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 23)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Precio"
        Me.Label8.Visible = False
        '
        'uic_total
        '
        Me.uic_total.Enabled = False
        Me.uic_total.Location = New System.Drawing.Point(479, 336)
        Me.uic_total.Name = "uic_total"
        Me.uic_total.Size = New System.Drawing.Size(100, 20)
        Me.uic_total.TabIndex = 19
        Me.uic_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'uic_IVA
        '
        Me.uic_IVA.Enabled = False
        Me.uic_IVA.Location = New System.Drawing.Point(479, 308)
        Me.uic_IVA.Name = "uic_IVA"
        Me.uic_IVA.Size = New System.Drawing.Size(100, 20)
        Me.uic_IVA.TabIndex = 20
        Me.uic_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(426, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "I.V.A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(426, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Neto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(426, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Total"
        '
        'uic_grabar
        '
        Me.uic_grabar.Image = Global.delevery.My.Resources.Resources.disk_blue
        Me.uic_grabar.Location = New System.Drawing.Point(502, 219)
        Me.uic_grabar.Name = "uic_grabar"
        Me.uic_grabar.Size = New System.Drawing.Size(46, 41)
        Me.uic_grabar.TabIndex = 120
        Me.uic_grabar.UseVisualStyleBackColor = True
        '
        'uic_salir
        '
        Me.uic_salir.Image = Global.delevery.My.Resources.Resources._Exit
        Me.uic_salir.Location = New System.Drawing.Point(639, 219)
        Me.uic_salir.Name = "uic_salir"
        Me.uic_salir.Size = New System.Drawing.Size(46, 41)
        Me.uic_salir.TabIndex = 121
        Me.uic_salir.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(484, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Familia"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uic_familia
        '
        Me.uic_familia.DataSource = Me.TipodocBindingSource
        Me.uic_familia.DisplayMember = "documento"
        Me.uic_familia.FormattingEnabled = True
        Me.uic_familia.Location = New System.Drawing.Point(603, 89)
        Me.uic_familia.Name = "uic_familia"
        Me.uic_familia.Size = New System.Drawing.Size(187, 21)
        Me.uic_familia.TabIndex = 122
        Me.uic_familia.ValueMember = "id_doc"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(482, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Productos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uic_Productos
        '
        Me.uic_Productos.DataSource = Me.TipodocBindingSource
        Me.uic_Productos.DisplayMember = "documento"
        Me.uic_Productos.FormattingEnabled = True
        Me.uic_Productos.Location = New System.Drawing.Point(603, 128)
        Me.uic_Productos.Name = "uic_Productos"
        Me.uic_Productos.Size = New System.Drawing.Size(187, 21)
        Me.uic_Productos.TabIndex = 124
        Me.uic_Productos.ValueMember = "id_doc"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar.Image = Global.delevery.My.Resources.Resources.Refresh1
        Me.btn_limpiar.Location = New System.Drawing.Point(568, 219)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(46, 41)
        Me.btn_limpiar.TabIndex = 126
        Me.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 272)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.uic_Productos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.uic_familia)
        Me.Controls.Add(Me.uic_salir)
        Me.Controls.Add(Me.uic_grabar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.uic_IVA)
        Me.Controls.Add(Me.uic_total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.uic_precio)
        Me.Controls.Add(Me.uic_neto)
        Me.Controls.Add(Me.uic_cantidad)
        Me.Controls.Add(Me.uic_descripcion)
        Me.Controls.Add(Me.uic_codigo)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "compras"
        CType(Me.TipodocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo_doc_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tipo_doc_DataSet As delevery.tipo_doc_DataSet
    Friend WithEvents TipodocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipo_docTableAdapter As delevery.tipo_doc_DataSetTableAdapters.tipo_docTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents uic_codigo As System.Windows.Forms.TextBox
    Friend WithEvents uic_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents uic_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents uic_neto As System.Windows.Forms.TextBox
    Friend WithEvents uic_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents uic_total As System.Windows.Forms.TextBox
    Friend WithEvents uic_IVA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents uic_grabar As System.Windows.Forms.Button
    Friend WithEvents uic_salir As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents uic_familia As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents uic_Productos As System.Windows.Forms.ComboBox
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
End Class
