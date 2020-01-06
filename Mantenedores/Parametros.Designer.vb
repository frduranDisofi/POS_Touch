<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosGral
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
        Me.GrpEmpresa = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uic_telefonos = New System.Windows.Forms.TextBox()
        Me.uic_emailEmpresa = New System.Windows.Forms.TextBox()
        Me.uic_direccion = New System.Windows.Forms.TextBox()
        Me.uic_comuna = New System.Windows.Forms.TextBox()
        Me.uic_ciudad = New System.Windows.Forms.TextBox()
        Me.uic_giro = New System.Windows.Forms.TextBox()
        Me.uic_razonSocial = New System.Windows.Forms.TextBox()
        Me.uic_rutEmp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.uic_licencia = New System.Windows.Forms.TextBox()
        Me.GrpEmpresa.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpEmpresa
        '
        Me.GrpEmpresa.Controls.Add(Me.Label3)
        Me.GrpEmpresa.Controls.Add(Me.uic_licencia)
        Me.GrpEmpresa.Controls.Add(Me.btn_salir)
        Me.GrpEmpresa.Controls.Add(Me.btn_modificar)
        Me.GrpEmpresa.Controls.Add(Me.Label35)
        Me.GrpEmpresa.Controls.Add(Me.Label30)
        Me.GrpEmpresa.Controls.Add(Me.Label12)
        Me.GrpEmpresa.Controls.Add(Me.Label11)
        Me.GrpEmpresa.Controls.Add(Me.Label10)
        Me.GrpEmpresa.Controls.Add(Me.Label9)
        Me.GrpEmpresa.Controls.Add(Me.Label8)
        Me.GrpEmpresa.Controls.Add(Me.Label7)
        Me.GrpEmpresa.Controls.Add(Me.uic_telefonos)
        Me.GrpEmpresa.Controls.Add(Me.uic_emailEmpresa)
        Me.GrpEmpresa.Controls.Add(Me.uic_direccion)
        Me.GrpEmpresa.Controls.Add(Me.uic_comuna)
        Me.GrpEmpresa.Controls.Add(Me.uic_ciudad)
        Me.GrpEmpresa.Controls.Add(Me.uic_giro)
        Me.GrpEmpresa.Controls.Add(Me.uic_razonSocial)
        Me.GrpEmpresa.Controls.Add(Me.uic_rutEmp)
        Me.GrpEmpresa.Controls.Add(Me.Label1)
        Me.GrpEmpresa.Location = New System.Drawing.Point(12, 12)
        Me.GrpEmpresa.Name = "GrpEmpresa"
        Me.GrpEmpresa.Size = New System.Drawing.Size(465, 242)
        Me.GrpEmpresa.TabIndex = 0
        Me.GrpEmpresa.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_salir.Image = Global.delevery.My.Resources.Resources._Exit
        Me.btn_salir.Location = New System.Drawing.Point(385, 184)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(41, 37)
        Me.btn_salir.TabIndex = 38
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = Global.delevery.My.Resources.Resources.Modify
        Me.btn_modificar.Location = New System.Drawing.Point(338, 184)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(32, 37)
        Me.btn_modificar.TabIndex = 39
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(284, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(108, 13)
        Me.Label35.TabIndex = 35
        Me.Label35.Text = "formato (12345678-9)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 184)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(57, 13)
        Me.Label30.TabIndex = 34
        Me.Label30.Text = "Telefonos:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Email Empresa:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Comuna:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Razon Social:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Giro:"
        '
        'uic_telefonos
        '
        Me.uic_telefonos.Location = New System.Drawing.Point(96, 180)
        Me.uic_telefonos.MaxLength = 20
        Me.uic_telefonos.Name = "uic_telefonos"
        Me.uic_telefonos.Size = New System.Drawing.Size(136, 20)
        Me.uic_telefonos.TabIndex = 7
        '
        'uic_emailEmpresa
        '
        Me.uic_emailEmpresa.Location = New System.Drawing.Point(96, 151)
        Me.uic_emailEmpresa.MaxLength = 80
        Me.uic_emailEmpresa.Name = "uic_emailEmpresa"
        Me.uic_emailEmpresa.Size = New System.Drawing.Size(362, 20)
        Me.uic_emailEmpresa.TabIndex = 6
        '
        'uic_direccion
        '
        Me.uic_direccion.Location = New System.Drawing.Point(96, 94)
        Me.uic_direccion.MaxLength = 60
        Me.uic_direccion.Name = "uic_direccion"
        Me.uic_direccion.Size = New System.Drawing.Size(362, 20)
        Me.uic_direccion.TabIndex = 3
        '
        'uic_comuna
        '
        Me.uic_comuna.Location = New System.Drawing.Point(322, 122)
        Me.uic_comuna.MaxLength = 20
        Me.uic_comuna.Name = "uic_comuna"
        Me.uic_comuna.Size = New System.Drawing.Size(136, 20)
        Me.uic_comuna.TabIndex = 5
        '
        'uic_ciudad
        '
        Me.uic_ciudad.Location = New System.Drawing.Point(96, 121)
        Me.uic_ciudad.MaxLength = 20
        Me.uic_ciudad.Name = "uic_ciudad"
        Me.uic_ciudad.Size = New System.Drawing.Size(136, 20)
        Me.uic_ciudad.TabIndex = 4
        '
        'uic_giro
        '
        Me.uic_giro.Location = New System.Drawing.Point(96, 67)
        Me.uic_giro.MaxLength = 80
        Me.uic_giro.Name = "uic_giro"
        Me.uic_giro.Size = New System.Drawing.Size(362, 20)
        Me.uic_giro.TabIndex = 2
        '
        'uic_razonSocial
        '
        Me.uic_razonSocial.Location = New System.Drawing.Point(96, 40)
        Me.uic_razonSocial.MaxLength = 100
        Me.uic_razonSocial.Name = "uic_razonSocial"
        Me.uic_razonSocial.Size = New System.Drawing.Size(362, 20)
        Me.uic_razonSocial.TabIndex = 1
        '
        'uic_rutEmp
        '
        Me.uic_rutEmp.Location = New System.Drawing.Point(96, 13)
        Me.uic_rutEmp.Name = "uic_rutEmp"
        Me.uic_rutEmp.Size = New System.Drawing.Size(136, 20)
        Me.uic_rutEmp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT Empresa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Licencia"
        '
        'uic_licencia
        '
        Me.uic_licencia.Location = New System.Drawing.Point(96, 208)
        Me.uic_licencia.Name = "uic_licencia"
        Me.uic_licencia.Size = New System.Drawing.Size(136, 20)
        Me.uic_licencia.TabIndex = 41
        '
        'DatosGral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.GrpEmpresa)
        Me.Name = "DatosGral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatosGral"
        Me.GrpEmpresa.ResumeLayout(False)
        Me.GrpEmpresa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents uic_telefonos As System.Windows.Forms.TextBox
    Friend WithEvents uic_emailEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents uic_direccion As System.Windows.Forms.TextBox
    Friend WithEvents uic_comuna As System.Windows.Forms.TextBox
    Friend WithEvents uic_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents uic_giro As System.Windows.Forms.TextBox
    Friend WithEvents uic_razonSocial As System.Windows.Forms.TextBox
    Friend WithEvents uic_rutEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents uic_licencia As System.Windows.Forms.TextBox
End Class
