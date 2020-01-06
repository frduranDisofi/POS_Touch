<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteCierreCaja
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
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.GridVentas = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.uic_FechaIni = New System.Windows.Forms.DateTimePicker()
        Me.uic_BuscaVta = New Telerik.WinControls.UI.RadButton()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.uic_Volver = New Telerik.WinControls.UI.RadButton()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVentas.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_BuscaVta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Volver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridVentas
        '
        Me.GridVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridVentas.BackColor = System.Drawing.SystemColors.Control
        Me.GridVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridVentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GridVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GridVentas.Location = New System.Drawing.Point(12, 95)
        '
        '
        '
        Me.GridVentas.MasterTemplate.AllowAddNewRow = False
        Me.GridVentas.MasterTemplate.AllowColumnReorder = False
        Me.GridVentas.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.GridVentas.Name = "GridVentas"
        Me.GridVentas.ReadOnly = True
        Me.GridVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GridVentas.ShowGroupPanel = False
        Me.GridVentas.Size = New System.Drawing.Size(331, 327)
        Me.GridVentas.TabIndex = 117
        Me.GridVentas.Text = "RadGridView2"
        Me.GridVentas.ThemeName = "Office2010Black"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.uic_Volver)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox3.Controls.Add(Me.uic_FechaFin)
        Me.RadGroupBox3.Controls.Add(Me.uic_FechaIni)
        Me.RadGroupBox3.Controls.Add(Me.uic_BuscaVta)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(12, 7)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(331, 82)
        Me.RadGroupBox3.TabIndex = 146
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(16, 45)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(44, 21)
        Me.RadLabel3.TabIndex = 94
        Me.RadLabel3.Text = "Hasta"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(16, 13)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(46, 21)
        Me.RadLabel2.TabIndex = 93
        Me.RadLabel2.Text = "Desde"
        '
        'uic_FechaFin
        '
        Me.uic_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uic_FechaFin.Location = New System.Drawing.Point(87, 50)
        Me.uic_FechaFin.Name = "uic_FechaFin"
        Me.uic_FechaFin.Size = New System.Drawing.Size(107, 20)
        Me.uic_FechaFin.TabIndex = 90
        '
        'uic_FechaIni
        '
        Me.uic_FechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uic_FechaIni.Location = New System.Drawing.Point(87, 15)
        Me.uic_FechaIni.Name = "uic_FechaIni"
        Me.uic_FechaIni.Size = New System.Drawing.Size(107, 20)
        Me.uic_FechaIni.TabIndex = 89
        '
        'uic_BuscaVta
        '
        Me.uic_BuscaVta.Image = Global.delevery.My.Resources.Resources.magnifier
        Me.uic_BuscaVta.Location = New System.Drawing.Point(219, 27)
        Me.uic_BuscaVta.Name = "uic_BuscaVta"
        Me.uic_BuscaVta.Size = New System.Drawing.Size(33, 32)
        Me.uic_BuscaVta.TabIndex = 87
        '
        'uic_Volver
        '
        Me.uic_Volver.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.uic_Volver.Image = Global.delevery.My.Resources.Resources._Exit
        Me.uic_Volver.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.uic_Volver.Location = New System.Drawing.Point(270, 24)
        Me.uic_Volver.Name = "uic_Volver"
        Me.uic_Volver.Size = New System.Drawing.Size(40, 35)
        Me.uic_Volver.TabIndex = 95
        Me.uic_Volver.Text = "RadButton4"
        Me.uic_Volver.ThemeName = "Office2010Black"
        '
        'ReporteCierreCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.GridVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "ReporteCierreCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Cierre Caja"
        CType(Me.GridVentas.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_BuscaVta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Volver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridVentas As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_FechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents uic_FechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents uic_BuscaVta As Telerik.WinControls.UI.RadButton
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents uic_Volver As Telerik.WinControls.UI.RadButton
End Class
