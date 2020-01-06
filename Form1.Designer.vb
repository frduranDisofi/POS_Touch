<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_vuelto = New System.Windows.Forms.TextBox()
        Me.txt_efectivo = New System.Windows.Forms.TextBox()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.cbo_formapago = New System.Windows.Forms.ComboBox()
        Me.FormapagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormaPago_dateset = New delevery.formaPago_dateset()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Forma_pagoTableAdapter = New delevery.formaPago_datesetTableAdapters.forma_pagoTableAdapter()
        Me.FlowLayoutFamilia = New System.Windows.Forms.FlowLayoutPanel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.uicEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.uic_FechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.uic_reloj = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_Efectivo = New System.Windows.Forms.Button()
        Me.btn_Tarjeta = New System.Windows.Forms.Button()
        Me.RetiroCaja = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.uic_admCaja = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uic_Observacion = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_productoGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.sumar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.restar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormapagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaPago_dateset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(541, 285)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(559, 248)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "zoom_out.png")
        Me.ImageList1.Images.SetKeyName(1, "about.png")
        Me.ImageList1.Images.SetKeyName(2, "add.png")
        Me.ImageList1.Images.SetKeyName(3, "add2.png")
        Me.ImageList1.Images.SetKeyName(4, "address_book.png")
        Me.ImageList1.Images.SetKeyName(5, "alarmclock_pause.png")
        Me.ImageList1.Images.SetKeyName(6, "application_certificate.png")
        Me.ImageList1.Images.SetKeyName(7, "application_connection.png")
        Me.ImageList1.Images.SetKeyName(8, "application_enterprise_new.png")
        Me.ImageList1.Images.SetKeyName(9, "application_enterprise_run.png")
        Me.ImageList1.Images.SetKeyName(10, "application_enterprise_stop.png")
        Me.ImageList1.Images.SetKeyName(11, "application_enterprise_view.png")
        Me.ImageList1.Images.SetKeyName(12, "application_error.png")
        Me.ImageList1.Images.SetKeyName(13, "application_server.png")
        Me.ImageList1.Images.SetKeyName(14, "application_stop.png")
        Me.ImageList1.Images.SetKeyName(15, "box_tall.png")
        Me.ImageList1.Images.SetKeyName(16, "box_software.png")
        Me.ImageList1.Images.SetKeyName(17, "branch_element.png")
        Me.ImageList1.Images.SetKeyName(18, "bookmark_delete.png")
        Me.ImageList1.Images.SetKeyName(19, "bullet_ball_glass_red.png")
        Me.ImageList1.Images.SetKeyName(20, "briefcase_document.png")
        Me.ImageList1.Images.SetKeyName(21, "bullet_square_green.png")
        Me.ImageList1.Images.SetKeyName(22, "calculator.png")
        Me.ImageList1.Images.SetKeyName(23, "application.png")
        Me.ImageList1.Images.SetKeyName(24, "application_add.png")
        Me.ImageList1.Images.SetKeyName(25, "application_certificate.png")
        Me.ImageList1.Images.SetKeyName(26, "application_connection.png")
        Me.ImageList1.Images.SetKeyName(27, "application_enterprise.png")
        Me.ImageList1.Images.SetKeyName(28, "application_enterprise_new.png")
        Me.ImageList1.Images.SetKeyName(29, "application_enterprise_run.png")
        Me.ImageList1.Images.SetKeyName(30, "application_enterprise_stop.png")
        Me.ImageList1.Images.SetKeyName(31, "address_book3.png")
        Me.ImageList1.Images.SetKeyName(32, "address_book3.png")
        Me.ImageList1.Images.SetKeyName(33, "address_book3.png")
        Me.ImageList1.Images.SetKeyName(34, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(35, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(36, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(37, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(38, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(39, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(40, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(41, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(42, "angel.png")
        Me.ImageList1.Images.SetKeyName(43, "application_connection.png")
        Me.ImageList1.Images.SetKeyName(44, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(45, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(46, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(47, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(48, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(49, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(50, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(51, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(52, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(53, "alarmclock_stop.png")
        Me.ImageList1.Images.SetKeyName(54, "alarmclock_stop.png")
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cantidad, Me.Desc, Me.precio, Me.Column3, Me.id_productoGrid, Me.Eliminar, Me.sumar, Me.restar})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(528, 107)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_vuelto
        '
        Me.txt_vuelto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_vuelto.Enabled = False
        Me.txt_vuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txt_vuelto.Location = New System.Drawing.Point(393, 503)
        Me.txt_vuelto.Name = "txt_vuelto"
        Me.txt_vuelto.Size = New System.Drawing.Size(122, 24)
        Me.txt_vuelto.TabIndex = 6
        Me.txt_vuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_efectivo
        '
        Me.txt_efectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_efectivo.Enabled = False
        Me.txt_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txt_efectivo.Location = New System.Drawing.Point(393, 464)
        Me.txt_efectivo.Name = "txt_efectivo"
        Me.txt_efectivo.Size = New System.Drawing.Size(122, 24)
        Me.txt_efectivo.TabIndex = 7
        Me.txt_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.Enabled = False
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Total.Location = New System.Drawing.Point(393, 427)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(122, 24)
        Me.txt_Total.TabIndex = 8
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbo_formapago
        '
        Me.cbo_formapago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbo_formapago.DataSource = Me.FormapagoBindingSource
        Me.cbo_formapago.DisplayMember = "formapago"
        Me.cbo_formapago.FormattingEnabled = True
        Me.cbo_formapago.Location = New System.Drawing.Point(401, 393)
        Me.cbo_formapago.Name = "cbo_formapago"
        Me.cbo_formapago.Size = New System.Drawing.Size(21, 21)
        Me.cbo_formapago.TabIndex = 9
        Me.cbo_formapago.ValueMember = "id"
        Me.cbo_formapago.Visible = False
        '
        'FormapagoBindingSource
        '
        Me.FormapagoBindingSource.DataMember = "forma_pago"
        Me.FormapagoBindingSource.DataSource = Me.FormaPago_dateset
        '
        'FormaPago_dateset
        '
        Me.FormaPago_dateset.DataSetName = "formaPago_dateset"
        Me.FormaPago_dateset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(307, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(307, 464)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cancelado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(307, 503)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Vuelto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Image = Global.delevery.My.Resources.Resources.check
        Me.btn_aceptar.Location = New System.Drawing.Point(1106, 427)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(101, 41)
        Me.btn_aceptar.TabIndex = 15
        Me.btn_aceptar.Text = "(F6)"
        Me.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Image = Global.delevery.My.Resources.Resources._Exit
        Me.btn_salir.Location = New System.Drawing.Point(1158, 484)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(46, 41)
        Me.btn_salir.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btn_salir, "Salir")
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CANTIDAD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_cantidad.Location = New System.Drawing.Point(347, 394)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(23, 20)
        Me.txt_cantidad.TabIndex = 17
        Me.txt_cantidad.Visible = False
        '
        'Forma_pagoTableAdapter
        '
        Me.Forma_pagoTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutFamilia
        '
        Me.FlowLayoutFamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutFamilia.AutoScroll = True
        Me.FlowLayoutFamilia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutFamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutFamilia.Location = New System.Drawing.Point(7, 12)
        Me.FlowLayoutFamilia.Name = "FlowLayoutFamilia"
        Me.FlowLayoutFamilia.Size = New System.Drawing.Size(1203, 266)
        Me.FlowLayoutFamilia.TabIndex = 21
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uicEstado, Me.uic_FechaHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 541)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1222, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'uicEstado
        '
        Me.uicEstado.Name = "uicEstado"
        Me.uicEstado.Size = New System.Drawing.Size(69, 17)
        Me.uicEstado.Text = "Fecha/Hora"
        '
        'uic_FechaHora
        '
        Me.uic_FechaHora.Name = "uic_FechaHora"
        Me.uic_FechaHora.Size = New System.Drawing.Size(0, 17)
        '
        'uic_reloj
        '
        Me.uic_reloj.Enabled = True
        Me.uic_reloj.Interval = 1000
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar.Image = Global.delevery.My.Resources.Resources.Refresh1
        Me.btn_limpiar.Location = New System.Drawing.Point(1106, 483)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(46, 41)
        Me.btn_limpiar.TabIndex = 24
        Me.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btn_limpiar, "Limpia pantalla")
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_Efectivo
        '
        Me.btn_Efectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Efectivo.Location = New System.Drawing.Point(1106, 231)
        Me.btn_Efectivo.Name = "btn_Efectivo"
        Me.btn_Efectivo.Size = New System.Drawing.Size(101, 43)
        Me.btn_Efectivo.TabIndex = 25
        Me.btn_Efectivo.Text = "EFECTIVO (F2)"
        Me.ToolTip1.SetToolTip(Me.btn_Efectivo, "Efectivo")
        Me.btn_Efectivo.UseVisualStyleBackColor = True
        '
        'btn_Tarjeta
        '
        Me.btn_Tarjeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Tarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Tarjeta.Location = New System.Drawing.Point(1106, 292)
        Me.btn_Tarjeta.Name = "btn_Tarjeta"
        Me.btn_Tarjeta.Size = New System.Drawing.Size(101, 45)
        Me.btn_Tarjeta.TabIndex = 26
        Me.btn_Tarjeta.Text = "TARJETA (F3)"
        Me.ToolTip1.SetToolTip(Me.btn_Tarjeta, "Tarjeta")
        Me.btn_Tarjeta.UseVisualStyleBackColor = True
        '
        'RetiroCaja
        '
        Me.RetiroCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RetiroCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetiroCaja.Location = New System.Drawing.Point(810, 504)
        Me.RetiroCaja.Name = "RetiroCaja"
        Me.RetiroCaja.Size = New System.Drawing.Size(70, 22)
        Me.RetiroCaja.TabIndex = 27
        Me.RetiroCaja.Text = "RETIRO"
        Me.ToolTip1.SetToolTip(Me.RetiroCaja, "RetiroCaja")
        Me.RetiroCaja.UseVisualStyleBackColor = True
        Me.RetiroCaja.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(886, 504)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 29)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "CIERRE CAJA"
        Me.ToolTip1.SetToolTip(Me.Button1, "RetiroCaja")
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'uic_admCaja
        '
        Me.uic_admCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_admCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_admCaja.Location = New System.Drawing.Point(1106, 356)
        Me.uic_admCaja.Name = "uic_admCaja"
        Me.uic_admCaja.Size = New System.Drawing.Size(101, 45)
        Me.uic_admCaja.TabIndex = 29
        Me.uic_admCaja.Text = "ADMIN CAJA (F4)"
        Me.ToolTip1.SetToolTip(Me.uic_admCaja, "Tarjeta")
        Me.uic_admCaja.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1106, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 43)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "DELIVERY (F1)"
        Me.ToolTip1.SetToolTip(Me.Button2, "Efectivo")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Observacion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uic_Observacion
        '
        Me.uic_Observacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.uic_Observacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_Observacion.Location = New System.Drawing.Point(7, 416)
        Me.uic_Observacion.MaxLength = 200
        Me.uic_Observacion.Multiline = True
        Me.uic_Observacion.Name = "uic_Observacion"
        Me.uic_Observacion.Size = New System.Drawing.Size(294, 117)
        Me.uic_Observacion.TabIndex = 32
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        Me.codigo.Width = 50
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cant."
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 50
        '
        'Desc
        '
        Me.Desc.HeaderText = "Descripcion"
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        Me.Desc.Width = 150
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Valor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'id_productoGrid
        '
        Me.id_productoGrid.HeaderText = "idprod"
        Me.id_productoGrid.Name = "id_productoGrid"
        Me.id_productoGrid.ReadOnly = True
        Me.id_productoGrid.Visible = False
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        Me.Eliminar.Width = 67
        '
        'sumar
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumar.DefaultCellStyle = DataGridViewCellStyle3
        Me.sumar.HeaderText = "+"
        Me.sumar.Name = "sumar"
        Me.sumar.ReadOnly = True
        Me.sumar.Text = "+"
        Me.sumar.UseColumnTextForButtonValue = True
        Me.sumar.Width = 40
        '
        'restar
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restar.DefaultCellStyle = DataGridViewCellStyle4
        Me.restar.HeaderText = "-"
        Me.restar.Name = "restar"
        Me.restar.ReadOnly = True
        Me.restar.Text = "-"
        Me.restar.UseColumnTextForButtonValue = True
        Me.restar.Width = 40
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uic_Observacion)
        Me.Controls.Add(Me.cbo_formapago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.uic_admCaja)
        Me.Controls.Add(Me.btn_Efectivo)
        Me.Controls.Add(Me.btn_Tarjeta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RetiroCaja)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.FlowLayoutFamilia)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.txt_efectivo)
        Me.Controls.Add(Me.txt_vuelto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormapagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaPago_dateset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_vuelto As System.Windows.Forms.TextBox
    Friend WithEvents txt_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents cbo_formapago As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents FormaPago_dateset As delevery.formaPago_dateset
    Friend WithEvents FormapagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Forma_pagoTableAdapter As delevery.formaPago_datesetTableAdapters.forma_pagoTableAdapter
    Friend WithEvents FlowLayoutFamilia As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents uicEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents uic_FechaHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents uic_reloj As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_Efectivo As System.Windows.Forms.Button
    Friend WithEvents btn_Tarjeta As System.Windows.Forms.Button
    Friend WithEvents RetiroCaja As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents uic_admCaja As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents uic_Observacion As System.Windows.Forms.TextBox
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_productoGrid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents sumar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents restar As System.Windows.Forms.DataGridViewButtonColumn

End Class
