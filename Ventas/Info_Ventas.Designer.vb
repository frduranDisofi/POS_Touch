<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_Ventas
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
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.uic_Usuario = New System.Windows.Forms.ComboBox()
        Me.uic_Ventas = New Telerik.WinControls.UI.RadButton()
        Me.uic_FechaFin = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uic_FechaIni = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.uic_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_FechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_FechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.RadMenu1.TabIndex = 176
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
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.Label3)
        Me.RadGroupBox1.Controls.Add(Me.uic_Usuario)
        Me.RadGroupBox1.Controls.Add(Me.uic_Ventas)
        Me.RadGroupBox1.Controls.Add(Me.uic_FechaFin)
        Me.RadGroupBox1.Controls.Add(Me.Label2)
        Me.RadGroupBox1.Controls.Add(Me.uic_FechaIni)
        Me.RadGroupBox1.Controls.Add(Me.Label1)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(307, 246)
        Me.RadGroupBox1.TabIndex = 175
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Usuario"
        '
        'uic_Usuario
        '
        Me.uic_Usuario.FormattingEnabled = True
        Me.uic_Usuario.Location = New System.Drawing.Point(97, 96)
        Me.uic_Usuario.Name = "uic_Usuario"
        Me.uic_Usuario.Size = New System.Drawing.Size(160, 21)
        Me.uic_Usuario.TabIndex = 115
        '
        'uic_Ventas
        '
        Me.uic_Ventas.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.uic_Ventas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_Ventas.Image = Global.delevery.My.Resources.Resources.print
        Me.uic_Ventas.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.uic_Ventas.Location = New System.Drawing.Point(117, 153)
        Me.uic_Ventas.Name = "uic_Ventas"
        Me.uic_Ventas.Size = New System.Drawing.Size(53, 41)
        Me.uic_Ventas.TabIndex = 113
        Me.uic_Ventas.Text = "Ventas"
        Me.uic_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.uic_Ventas.ThemeName = "Office2010Black"
        '
        'uic_FechaFin
        '
        Me.uic_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uic_FechaFin.Location = New System.Drawing.Point(152, 65)
        Me.uic_FechaFin.Name = "uic_FechaFin"
        Me.uic_FechaFin.Size = New System.Drawing.Size(105, 20)
        Me.uic_FechaFin.TabIndex = 111
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
        Me.uic_FechaIni.TabIndex = 104
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
        'Info_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadMenu1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Info_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info_Ventas"
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.uic_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_FechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_FechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_Ventas As Telerik.WinControls.UI.RadButton
    Friend WithEvents uic_FechaFin As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents uic_FechaIni As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uic_Usuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
