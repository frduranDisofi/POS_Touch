<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FamiliaProducto
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
        Me.uic_CodigoFamilia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uic_FamiliaProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FamiliaProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryDataSet = New delevery.deliveryDataSet()
        Me.FamiliaProductoTableAdapter = New delevery.deliveryDataSetTableAdapters.FamiliaProductoTableAdapter()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.uic_RutaImagen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxImpresora = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.FamiliaProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uic_CodigoFamilia
        '
        Me.uic_CodigoFamilia.Location = New System.Drawing.Point(59, 5)
        Me.uic_CodigoFamilia.Name = "uic_CodigoFamilia"
        Me.uic_CodigoFamilia.Size = New System.Drawing.Size(30, 20)
        Me.uic_CodigoFamilia.TabIndex = 0
        Me.uic_CodigoFamilia.Visible = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Codigo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'uic_FamiliaProducto
        '
        Me.uic_FamiliaProducto.Location = New System.Drawing.Point(81, 68)
        Me.uic_FamiliaProducto.Name = "uic_FamiliaProducto"
        Me.uic_FamiliaProducto.Size = New System.Drawing.Size(165, 20)
        Me.uic_FamiliaProducto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(25, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Familia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'RadGridView1
        '
        Me.RadGridView1.BackColor = System.Drawing.SystemColors.Control
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(25, 166)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        Me.RadGridView1.MasterTemplate.EnableAlternatingRowColor = True
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadGridView1.ShowGroupPanel = False
        Me.RadGridView1.Size = New System.Drawing.Size(320, 312)
        Me.RadGridView1.TabIndex = 25
        Me.RadGridView1.Text = "RadGridView1"
        Me.RadGridView1.ThemeName = "Office2010Black"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Image = Global.delevery.My.Resources.Resources.magnifier
        Me.Button1.Location = New System.Drawing.Point(361, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.Button1, "Buscar imagen")
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_modificar.Image = Global.delevery.My.Resources.Resources.Modify
        Me.btn_modificar.Location = New System.Drawing.Point(158, 11)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(37, 37)
        Me.btn_modificar.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.btn_modificar, "Modificar registro")
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_salir.Image = Global.delevery.My.Resources.Resources._Exit
        Me.btn_salir.Location = New System.Drawing.Point(290, 12)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(37, 37)
        Me.btn_salir.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btn_salir, "Salir")
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_grabar.Image = Global.delevery.My.Resources.Resources.disk_blue
        Me.btn_grabar.Location = New System.Drawing.Point(114, 11)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(37, 37)
        Me.btn_grabar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btn_grabar, "Grabar registro")
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'uic_RutaImagen
        '
        Me.uic_RutaImagen.Location = New System.Drawing.Point(81, 99)
        Me.uic_RutaImagen.Name = "uic_RutaImagen"
        Me.uic_RutaImagen.Size = New System.Drawing.Size(264, 20)
        Me.uic_RutaImagen.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(25, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Imagen"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(453, 307)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_eliminar.Image = Global.delevery.My.Resources.Resources.Delete
        Me.btn_eliminar.Location = New System.Drawing.Point(202, 12)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(37, 37)
        Me.btn_eliminar.TabIndex = 19
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(25, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Impresora"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxImpresora
        '
        Me.cbxImpresora.FormattingEnabled = True
        Me.cbxImpresora.Location = New System.Drawing.Point(81, 125)
        Me.cbxImpresora.Name = "cbxImpresora"
        Me.cbxImpresora.Size = New System.Drawing.Size(241, 21)
        Me.cbxImpresora.TabIndex = 31
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Image = Global.delevery.My.Resources.Resources.Refresh1
        Me.Button2.Location = New System.Drawing.Point(246, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 37)
        Me.Button2.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.Button2, "Limpiar")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FamiliaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbxImpresora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.uic_RutaImagen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.uic_FamiliaProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.uic_CodigoFamilia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_grabar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FamiliaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Familia Producto"
        CType(Me.FamiliaProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents uic_CodigoFamilia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uic_FamiliaProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeliveryDataSet As delevery.deliveryDataSet
    Friend WithEvents FamiliaProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FamiliaProductoTableAdapter As delevery.deliveryDataSetTableAdapters.FamiliaProductoTableAdapter
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents uic_RutaImagen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxImpresora As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
