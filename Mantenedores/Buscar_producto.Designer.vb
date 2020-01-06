<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar_producto
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoFamilia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.RadioCodigo = New System.Windows.Forms.RadioButton()
        Me.RadioDescripcion = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.precio, Me.codigo_int, Me.CodigoFamilia})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(463, 373)
        Me.DataGridView1.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 220
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'codigo_int
        '
        Me.codigo_int.HeaderText = "codigo_int"
        Me.codigo_int.Name = "codigo_int"
        Me.codigo_int.ReadOnly = True
        Me.codigo_int.Visible = False
        '
        'CodigoFamilia
        '
        Me.CodigoFamilia.HeaderText = "CodigoFamilia"
        Me.CodigoFamilia.Name = "CodigoFamilia"
        Me.CodigoFamilia.ReadOnly = True
        Me.CodigoFamilia.Visible = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(31, 43)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(230, 20)
        Me.txt_buscar.TabIndex = 0
        '
        'btn_enviar
        '
        Me.btn_enviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_enviar.Image = Global.delevery.My.Resources.Resources.check
        Me.btn_enviar.Location = New System.Drawing.Point(350, 448)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(39, 42)
        Me.btn_enviar.TabIndex = 3
        Me.btn_enviar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_salir.Image = Global.delevery.My.Resources.Resources._Exit
        Me.btn_salir.Location = New System.Drawing.Point(455, 452)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(39, 42)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.delevery.My.Resources.Resources.find
        Me.btn_buscar.Location = New System.Drawing.Point(441, 17)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(37, 37)
        Me.btn_buscar.TabIndex = 8
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'RadioCodigo
        '
        Me.RadioCodigo.AutoSize = True
        Me.RadioCodigo.Location = New System.Drawing.Point(31, 12)
        Me.RadioCodigo.Name = "RadioCodigo"
        Me.RadioCodigo.Size = New System.Drawing.Size(58, 17)
        Me.RadioCodigo.TabIndex = 11
        Me.RadioCodigo.TabStop = True
        Me.RadioCodigo.Text = "Codigo"
        Me.RadioCodigo.UseVisualStyleBackColor = True
        '
        'RadioDescripcion
        '
        Me.RadioDescripcion.AutoSize = True
        Me.RadioDescripcion.Location = New System.Drawing.Point(95, 12)
        Me.RadioDescripcion.Name = "RadioDescripcion"
        Me.RadioDescripcion.Size = New System.Drawing.Size(81, 17)
        Me.RadioDescripcion.TabIndex = 12
        Me.RadioDescripcion.TabStop = True
        Me.RadioDescripcion.Text = "Descripcion"
        Me.RadioDescripcion.UseVisualStyleBackColor = True
        '
        'Buscar_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(517, 506)
        Me.Controls.Add(Me.RadioDescripcion)
        Me.Controls.Add(Me.RadioCodigo)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Buscar_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar producto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_enviar As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo_int As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFamilia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents RadioCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioDescripcion As System.Windows.Forms.RadioButton
End Class
