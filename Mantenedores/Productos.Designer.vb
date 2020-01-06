<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_codigoInt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.uic_Familia = New System.Windows.Forms.ComboBox()
        Me.FamiliaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryDataSet = New delevery.deliveryDataSet()
        Me.FamiliaProductoTableAdapter = New delevery.deliveryDataSetTableAdapters.FamiliaProductoTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.btnLimpiar = New Telerik.WinControls.UI.RadButton()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.uic_Salir = New Telerik.WinControls.UI.RadMenuItem()
        Me.uic_Minimizar = New Telerik.WinControls.UI.RadMenuItem()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.FamiliaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Codigo Interno"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(101, 115)
        Me.txt_codigo.MaxLength = 30
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(140, 20)
        Me.txt_codigo.TabIndex = 0
        Me.txt_codigo.Visible = False
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(101, 148)
        Me.txt_descripcion.MaxLength = 90
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(192, 20)
        Me.txt_descripcion.TabIndex = 2
        '
        'txt_codigoInt
        '
        Me.txt_codigoInt.Location = New System.Drawing.Point(89, 315)
        Me.txt_codigoInt.MaxLength = 30
        Me.txt_codigoInt.Name = "txt_codigoInt"
        Me.txt_codigoInt.Size = New System.Drawing.Size(192, 20)
        Me.txt_codigoInt.TabIndex = 4
        Me.txt_codigoInt.Visible = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Precio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(101, 179)
        Me.txt_precio.MaxLength = 9
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 3
        '
        'uic_Familia
        '
        Me.uic_Familia.FormattingEnabled = True
        Me.uic_Familia.Location = New System.Drawing.Point(101, 210)
        Me.uic_Familia.Name = "uic_Familia"
        Me.uic_Familia.Size = New System.Drawing.Size(137, 21)
        Me.uic_Familia.TabIndex = 5
        '
        'FamiliaProductoBindingSource
        '
        Me.FamiliaProductoBindingSource.DataMember = "FamiliaProducto"
        Me.FamiliaProductoBindingSource.DataSource = Me.DeliveryDataSet
        '
        'DeliveryDataSet
        '
        Me.DeliveryDataSet.DataSetName = "deliveryDataSet"
        Me.DeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FamiliaProductoTableAdapter
        '
        Me.FamiliaProductoTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Familia"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadButton1)
        Me.RadGroupBox1.Controls.Add(Me.btnLimpiar)
        Me.RadGroupBox1.Controls.Add(Me.btn_eliminar)
        Me.RadGroupBox1.Controls.Add(Me.btn_modificar)
        Me.RadGroupBox1.Controls.Add(Me.btn_grabar)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(284, 60)
        Me.RadGroupBox1.TabIndex = 19
        '
        'RadButton1
        '
        Me.RadButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.RadButton1.Image = Global.delevery.My.Resources.Resources.print
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton1.Location = New System.Drawing.Point(169, 12)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(45, 37)
        Me.RadButton1.TabIndex = 82
        Me.RadButton1.Text = "RadButton4"
        Me.RadButton1.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.RadButton1, "Reporte productos")
        '
        'btnLimpiar
        '
        Me.btnLimpiar.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.btnLimpiar.Image = Global.delevery.My.Resources.Resources.Refresh1
        Me.btnLimpiar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(225, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(45, 37)
        Me.btnLimpiar.TabIndex = 81
        Me.btnLimpiar.Text = "RadButton4"
        Me.btnLimpiar.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "Limpiar pantalla")
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = Global.delevery.My.Resources.Resources.Delete
        Me.btn_eliminar.Location = New System.Drawing.Point(126, 12)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(37, 37)
        Me.btn_eliminar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btn_eliminar, "Eliminar Registro")
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = Global.delevery.My.Resources.Resources.Modify
        Me.btn_modificar.Location = New System.Drawing.Point(83, 12)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(37, 37)
        Me.btn_modificar.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btn_modificar, "Modificar Registro")
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = Global.delevery.My.Resources.Resources.disk_blue
        Me.btn_grabar.Location = New System.Drawing.Point(40, 12)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(37, 37)
        Me.btn_grabar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btn_grabar, "Grabar Registro")
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'RadMenu1
        '
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.uic_Salir, Me.uic_Minimizar})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadMenu1.Size = New System.Drawing.Size(798, 29)
        Me.RadMenu1.TabIndex = 20
        Me.RadMenu1.Text = "RadMenu1"
        Me.RadMenu1.ThemeName = "Office2010Black"
        '
        'uic_Salir
        '
        Me.uic_Salir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.uic_Salir.Image = Global.delevery.My.Resources.Resources.Exit1
        Me.uic_Salir.Name = "uic_Salir"
        Me.uic_Salir.Text = "Salir"
        '
        'uic_Minimizar
        '
        Me.uic_Minimizar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.uic_Minimizar.Name = "uic_Minimizar"
        Me.uic_Minimizar.Text = "Minimizar"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Controls.Add(Me.RadGridView1)
        Me.RadGroupBox4.HeaderText = ""
        Me.RadGroupBox4.Location = New System.Drawing.Point(302, 35)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(484, 519)
        Me.RadGroupBox4.TabIndex = 188
        Me.RadGroupBox4.ThemeName = "Office2010Black"
        '
        'RadGridView1
        '
        Me.RadGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGridView1.Location = New System.Drawing.Point(10, 14)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(462, 487)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        Me.RadGridView1.ThemeName = "Office2010Black"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(798, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Controls.Add(Me.RadMenu1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.uic_Familia)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_codigoInt)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.FamiliaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigoInt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents uic_Familia As System.Windows.Forms.ComboBox
    Friend WithEvents DeliveryDataSet As delevery.deliveryDataSet
    Friend WithEvents FamiliaProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FamiliaProductoTableAdapter As delevery.deliveryDataSetTableAdapters.FamiliaProductoTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents uic_Minimizar As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents uic_Salir As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btnLimpiar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
