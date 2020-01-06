<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoFpagos
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
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.uic_FechaFin = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uic_FechaIni = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.uic_delivery = New Telerik.WinControls.UI.RadRadioButton()
        Me.uic_tarjeta = New Telerik.WinControls.UI.RadRadioButton()
        Me.uic_Todos = New Telerik.WinControls.UI.RadRadioButton()
        Me.uic_contado = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.uic_limpiar = New Telerik.WinControls.UI.RadButton()
        Me.uic_Imprime = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.uic_FechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_FechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_delivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_tarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Todos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_contado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_limpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Imprime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.uic_Todos)
        Me.RadGroupBox1.Controls.Add(Me.uic_contado)
        Me.RadGroupBox1.Controls.Add(Me.uic_tarjeta)
        Me.RadGroupBox1.Controls.Add(Me.uic_delivery)
        Me.RadGroupBox1.Controls.Add(Me.uic_limpiar)
        Me.RadGroupBox1.Controls.Add(Me.uic_Imprime)
        Me.RadGroupBox1.Controls.Add(Me.uic_FechaFin)
        Me.RadGroupBox1.Controls.Add(Me.Label2)
        Me.RadGroupBox1.Controls.Add(Me.uic_FechaIni)
        Me.RadGroupBox1.Controls.Add(Me.Label1)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(307, 246)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'uic_FechaFin
        '
        Me.uic_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uic_FechaFin.Location = New System.Drawing.Point(152, 65)
        Me.uic_FechaFin.Name = "uic_FechaFin"
        Me.uic_FechaFin.Size = New System.Drawing.Size(105, 20)
        Me.uic_FechaFin.TabIndex = 1
        Me.uic_FechaFin.TabStop = False
        Me.uic_FechaFin.Text = "23/09/2016"
        Me.uic_FechaFin.ThemeName = "Office2010Black"
        Me.uic_FechaFin.Value = New Date(2016, 9, 23, 16, 59, 57, 947)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Hasta"
        '
        'uic_FechaIni
        '
        Me.uic_FechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uic_FechaIni.Location = New System.Drawing.Point(152, 25)
        Me.uic_FechaIni.Name = "uic_FechaIni"
        Me.uic_FechaIni.Size = New System.Drawing.Size(105, 20)
        Me.uic_FechaIni.TabIndex = 0
        Me.uic_FechaIni.TabStop = False
        Me.uic_FechaIni.Text = "23/09/2016"
        Me.uic_FechaIni.ThemeName = "Office2010Black"
        Me.uic_FechaIni.Value = New Date(2016, 9, 23, 16, 59, 57, 947)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Desde"
        '
        'uic_delivery
        '
        Me.uic_delivery.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_delivery.Location = New System.Drawing.Point(36, 111)
        Me.uic_delivery.Name = "uic_delivery"
        Me.uic_delivery.Size = New System.Drawing.Size(68, 19)
        Me.uic_delivery.TabIndex = 2
        Me.uic_delivery.TabStop = False
        Me.uic_delivery.Text = "Delivery"
        '
        'uic_tarjeta
        '
        Me.uic_tarjeta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_tarjeta.Location = New System.Drawing.Point(152, 111)
        Me.uic_tarjeta.Name = "uic_tarjeta"
        Me.uic_tarjeta.Size = New System.Drawing.Size(61, 19)
        Me.uic_tarjeta.TabIndex = 3
        Me.uic_tarjeta.TabStop = False
        Me.uic_tarjeta.Text = "Tarjeta"
        '
        'uic_Todos
        '
        Me.uic_Todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uic_Todos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_Todos.Location = New System.Drawing.Point(152, 144)
        Me.uic_Todos.Name = "uic_Todos"
        Me.uic_Todos.Size = New System.Drawing.Size(56, 19)
        Me.uic_Todos.TabIndex = 5
        Me.uic_Todos.Text = "Todos"
        Me.uic_Todos.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'uic_contado
        '
        Me.uic_contado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_contado.Location = New System.Drawing.Point(36, 144)
        Me.uic_contado.Name = "uic_contado"
        Me.uic_contado.Size = New System.Drawing.Size(70, 19)
        Me.uic_contado.TabIndex = 4
        Me.uic_contado.TabStop = False
        Me.uic_contado.Text = "Contado"
        '
        'RadMenu1
        '
        Me.RadMenu1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
        Me.RadMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadMenu1.Size = New System.Drawing.Size(332, 33)
        Me.RadMenu1.TabIndex = 180
        Me.RadMenu1.Text = "RadMenu1"
        Me.RadMenu1.ThemeName = "Office2010Black"
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.Image = Global.delevery.My.Resources.Resources._Exit
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "Volver"
        Me.RadMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'uic_limpiar
        '
        Me.uic_limpiar.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.uic_limpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_limpiar.Image = Global.delevery.My.Resources.Resources.Refresh1
        Me.uic_limpiar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.uic_limpiar.Location = New System.Drawing.Point(156, 189)
        Me.uic_limpiar.Name = "uic_limpiar"
        Me.uic_limpiar.Size = New System.Drawing.Size(53, 41)
        Me.uic_limpiar.TabIndex = 7
        Me.uic_limpiar.Text = "Productos"
        Me.uic_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.uic_limpiar.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.uic_limpiar, "Limpia pantalla")
        '
        'uic_Imprime
        '
        Me.uic_Imprime.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.uic_Imprime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_Imprime.Image = Global.delevery.My.Resources.Resources.print
        Me.uic_Imprime.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.uic_Imprime.Location = New System.Drawing.Point(97, 189)
        Me.uic_Imprime.Name = "uic_Imprime"
        Me.uic_Imprime.Size = New System.Drawing.Size(53, 41)
        Me.uic_Imprime.TabIndex = 6
        Me.uic_Imprime.Text = "Productos"
        Me.uic_Imprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.uic_Imprime.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.uic_Imprime, "Imprime reporte")
        '
        'InfoFpagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadMenu1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "InfoFpagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formas pagos"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.uic_FechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_FechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_delivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_tarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Todos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_contado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_limpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Imprime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_limpiar As Telerik.WinControls.UI.RadButton
    Friend WithEvents uic_Imprime As Telerik.WinControls.UI.RadButton
    Friend WithEvents uic_FechaFin As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents uic_FechaIni As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents uic_Todos As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents uic_contado As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents uic_tarjeta As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents uic_delivery As Telerik.WinControls.UI.RadRadioButton
End Class
