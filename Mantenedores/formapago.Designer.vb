<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formapago
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
        Me.cbo_formaPago = New System.Windows.Forms.ComboBox()
        Me.FormapagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormaPago_dateset = New delevery.formaPago_dateset()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_formaPago = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.Forma_pagoTableAdapter = New delevery.formaPago_datesetTableAdapters.forma_pagoTableAdapter()
        CType(Me.FormapagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaPago_dateset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_formaPago
        '
        Me.cbo_formaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_formaPago.FormattingEnabled = True
        Me.cbo_formaPago.Location = New System.Drawing.Point(109, 84)
        Me.cbo_formaPago.Name = "cbo_formaPago"
        Me.cbo_formaPago.Size = New System.Drawing.Size(165, 21)
        Me.cbo_formaPago.TabIndex = 16
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
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Forma de Pago"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Forma de Pago"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_formaPago
        '
        Me.txt_formaPago.Location = New System.Drawing.Point(109, 143)
        Me.txt_formaPago.Name = "txt_formaPago"
        Me.txt_formaPago.Size = New System.Drawing.Size(165, 20)
        Me.txt_formaPago.TabIndex = 19
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = Global.delevery.My.Resources.Resources.Delete
        Me.btn_eliminar.Location = New System.Drawing.Point(98, 23)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(37, 37)
        Me.btn_eliminar.TabIndex = 15
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = Global.delevery.My.Resources.Resources.Modify
        Me.btn_modificar.Location = New System.Drawing.Point(55, 23)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(37, 37)
        Me.btn_modificar.TabIndex = 14
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.delevery.My.Resources.Resources._Exit
        Me.btn_salir.Location = New System.Drawing.Point(141, 23)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(37, 37)
        Me.btn_salir.TabIndex = 13
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = Global.delevery.My.Resources.Resources.disk_blue
        Me.btn_grabar.Location = New System.Drawing.Point(12, 23)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(37, 37)
        Me.btn_grabar.TabIndex = 12
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'Forma_pagoTableAdapter
        '
        Me.Forma_pagoTableAdapter.ClearBeforeFill = True
        '
        'formapago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 219)
        Me.Controls.Add(Me.txt_formaPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_formaPago)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_grabar)
        Me.Name = "formapago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forma de Pago"
        CType(Me.FormapagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaPago_dateset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_grabar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents cbo_formaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_formaPago As System.Windows.Forms.TextBox
    Friend WithEvents FormaPago_dateset As delevery.formaPago_dateset
    Friend WithEvents FormapagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Forma_pagoTableAdapter As delevery.formaPago_datesetTableAdapters.forma_pagoTableAdapter
End Class
