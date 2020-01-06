<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anula_Imprime
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBoleta = New Telerik.WinControls.UI.RadButton()
        Me.btnLimpiar = New Telerik.WinControls.UI.RadButton()
        Me.btnEliminar = New Telerik.WinControls.UI.RadButton()
        Me.btnImprime = New Telerik.WinControls.UI.RadButton()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.GridVentas = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.uic_FechaIni = New System.Windows.Forms.DateTimePicker()
        Me.uic_BuscaVta = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Salir = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.btnBoleta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImprime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVentas.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_BuscaVta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadMenu1.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBoleta
        '
        Me.btnBoleta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBoleta.Image = Global.delevery.My.Resources.Resources.print
        Me.btnBoleta.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBoleta.Location = New System.Drawing.Point(65, 13)
        Me.btnBoleta.Name = "btnBoleta"
        Me.btnBoleta.Size = New System.Drawing.Size(56, 57)
        Me.btnBoleta.TabIndex = 84
        Me.btnBoleta.Text = "Boleta"
        Me.btnBoleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBoleta.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.btnBoleta, "Imprime Boleta")
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.Image = Global.delevery.My.Resources.Resources.Refresh2
        Me.btnLimpiar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(179, 13)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(56, 57)
        Me.btnLimpiar.TabIndex = 83
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.btnLimpiar, "Limpiar pantalla")
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Image = Global.delevery.My.Resources.Resources.Delete1
        Me.btnEliminar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.Location = New System.Drawing.Point(122, 13)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(56, 57)
        Me.btnEliminar.TabIndex = 82
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Elimina venta")
        '
        'btnImprime
        '
        Me.btnImprime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprime.Image = Global.delevery.My.Resources.Resources.print
        Me.btnImprime.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnImprime.Location = New System.Drawing.Point(8, 13)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(56, 57)
        Me.btnImprime.TabIndex = 81
        Me.btnImprime.Text = "Ticket"
        Me.btnImprime.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnImprime.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.btnImprime, "Imprime Ticket")
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.GridVentas)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(17, 128)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(578, 398)
        Me.RadGroupBox2.TabIndex = 146
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        '
        'GridVentas
        '
        Me.GridVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridVentas.Location = New System.Drawing.Point(5, 10)
        '
        '
        '
        Me.GridVentas.MasterTemplate.AllowAddNewRow = False
        Me.GridVentas.MasterTemplate.AllowColumnReorder = False
        Me.GridVentas.MasterTemplate.EnableAlternatingRowColor = True
        Me.GridVentas.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridVentas.Name = "GridVentas"
        Me.GridVentas.ReadOnly = True
        Me.GridVentas.Size = New System.Drawing.Size(565, 380)
        Me.GridVentas.TabIndex = 0
        Me.GridVentas.Text = "RadGridView2"
        Me.GridVentas.ThemeName = "Office2010Black"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox3.Controls.Add(Me.uic_FechaFin)
        Me.RadGroupBox3.Controls.Add(Me.uic_FechaIni)
        Me.RadGroupBox3.Controls.Add(Me.uic_BuscaVta)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(17, 35)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(318, 89)
        Me.RadGroupBox3.TabIndex = 145
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(56, 45)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(44, 21)
        Me.RadLabel3.TabIndex = 94
        Me.RadLabel3.Text = "Hasta"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(56, 13)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(46, 21)
        Me.RadLabel2.TabIndex = 93
        Me.RadLabel2.Text = "Desde"
        '
        'uic_FechaFin
        '
        Me.uic_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uic_FechaFin.Location = New System.Drawing.Point(127, 50)
        Me.uic_FechaFin.Name = "uic_FechaFin"
        Me.uic_FechaFin.Size = New System.Drawing.Size(107, 20)
        Me.uic_FechaFin.TabIndex = 90
        '
        'uic_FechaIni
        '
        Me.uic_FechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uic_FechaIni.Location = New System.Drawing.Point(127, 15)
        Me.uic_FechaIni.Name = "uic_FechaIni"
        Me.uic_FechaIni.Size = New System.Drawing.Size(107, 20)
        Me.uic_FechaIni.TabIndex = 89
        '
        'uic_BuscaVta
        '
        Me.uic_BuscaVta.Image = Global.delevery.My.Resources.Resources.magnifier
        Me.uic_BuscaVta.Location = New System.Drawing.Point(261, 24)
        Me.uic_BuscaVta.Name = "uic_BuscaVta"
        Me.uic_BuscaVta.Size = New System.Drawing.Size(33, 32)
        Me.uic_BuscaVta.TabIndex = 87
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.btnBoleta)
        Me.RadPanel2.Controls.Add(Me.btnLimpiar)
        Me.RadPanel2.Controls.Add(Me.btnEliminar)
        Me.RadPanel2.Controls.Add(Me.btnImprime)
        Me.RadPanel2.Location = New System.Drawing.Point(347, 36)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(248, 86)
        Me.RadPanel2.TabIndex = 144
        Me.RadPanel2.ThemeName = "Office2010Black"
        '
        'RadMenu1
        '
        Me.RadMenu1.Controls.Add(Me.RadLabel1)
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.uic_Salir})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadMenu1.Size = New System.Drawing.Size(613, 29)
        Me.RadMenu1.TabIndex = 147
        Me.RadMenu1.Text = "RadMenu1"
        Me.RadMenu1.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(252, 2)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(108, 25)
        Me.RadLabel1.TabIndex = 89
        Me.RadLabel1.Text = "Buscar Venta"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'uic_Salir
        '
        Me.uic_Salir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.uic_Salir.Image = Global.delevery.My.Resources.Resources.Exit1
        Me.uic_Salir.Name = "uic_Salir"
        Me.uic_Salir.Text = "Salir"
        Me.uic_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Anula_Imprime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadMenu1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Anula_Imprime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.btnBoleta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImprime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.GridVentas.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_BuscaVta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadMenu1.ResumeLayout(False)
        Me.RadMenu1.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents GridVentas As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_FechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents uic_FechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents uic_BuscaVta As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnBoleta As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnLimpiar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnImprime As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Salir As Telerik.WinControls.UI.RadMenuItem
End Class
