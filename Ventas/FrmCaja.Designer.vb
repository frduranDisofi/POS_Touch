<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCaja
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_BuscaVta = New Telerik.WinControls.UI.RadButton()
        Me.IdTicket = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel_keypad = New Telerik.WinControls.UI.RadPanel()
        Me.uic_botonEnter = New System.Windows.Forms.Button()
        Me.uic_botonC = New System.Windows.Forms.Button()
        Me.uic_botonBack = New System.Windows.Forms.Button()
        Me.uic_boton3 = New System.Windows.Forms.Button()
        Me.uic_boton6 = New System.Windows.Forms.Button()
        Me.uic_boton9 = New System.Windows.Forms.Button()
        Me.uic_boton2 = New System.Windows.Forms.Button()
        Me.uic_boton5 = New System.Windows.Forms.Button()
        Me.uic_boton8 = New System.Windows.Forms.Button()
        Me.uic_boton0 = New System.Windows.Forms.Button()
        Me.uic_boton1 = New System.Windows.Forms.Button()
        Me.uic_boton4 = New System.Windows.Forms.Button()
        Me.uic_boton7 = New System.Windows.Forms.Button()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.uic_Reloj = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_cobro = New Telerik.WinControls.UI.RadPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.txt_efectivo = New System.Windows.Forms.TextBox()
        Me.txt_vuelto = New System.Windows.Forms.TextBox()
        Me.uic_botonF1 = New System.Windows.Forms.Button()
        Me.uic_BotonF4 = New System.Windows.Forms.Button()
        Me.uic_botonF2 = New System.Windows.Forms.Button()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.uic_Nrotransaccion = New Telerik.WinControls.UI.RadLabelElement()
        Me.uic_FechaHora = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.uic_VersionApp = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_BuscaArticulo = New Telerik.WinControls.UI.RadButton()
        Me.uic_BuscarProducto = New Telerik.WinControls.UI.RadTextBox()
        Me.GridProductos = New Telerik.WinControls.UI.RadGridView()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_productoGrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_BuscaVta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_keypad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_keypad.SuspendLayout()
        CType(Me.Panel_cobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_cobro.SuspendLayout()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_BuscaArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_BuscarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridProductos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox3.Controls.Add(Me.uic_BuscaVta)
        Me.RadGroupBox3.Controls.Add(Me.IdTicket)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(7, 4)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(501, 63)
        Me.RadGroupBox3.TabIndex = 6
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(15, 16)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(109, 25)
        Me.RadLabel1.TabIndex = 88
        Me.RadLabel1.Text = "Buscar Venta"
        '
        'uic_BuscaVta
        '
        Me.uic_BuscaVta.Image = Global.delevery.My.Resources.Resources.magnifier
        Me.uic_BuscaVta.Location = New System.Drawing.Point(376, 13)
        Me.uic_BuscaVta.Name = "uic_BuscaVta"
        Me.uic_BuscaVta.Size = New System.Drawing.Size(33, 32)
        Me.uic_BuscaVta.TabIndex = 87
        '
        'IdTicket
        '
        Me.IdTicket.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.IdTicket.Location = New System.Drawing.Point(137, 19)
        Me.IdTicket.Name = "IdTicket"
        Me.IdTicket.Size = New System.Drawing.Size(201, 25)
        Me.IdTicket.TabIndex = 4
        Me.IdTicket.ThemeName = "ControlDefault"
        '
        'Panel_keypad
        '
        Me.Panel_keypad.Controls.Add(Me.uic_botonEnter)
        Me.Panel_keypad.Controls.Add(Me.uic_botonC)
        Me.Panel_keypad.Controls.Add(Me.uic_botonBack)
        Me.Panel_keypad.Controls.Add(Me.uic_boton3)
        Me.Panel_keypad.Controls.Add(Me.uic_boton6)
        Me.Panel_keypad.Controls.Add(Me.uic_boton9)
        Me.Panel_keypad.Controls.Add(Me.uic_boton2)
        Me.Panel_keypad.Controls.Add(Me.uic_boton5)
        Me.Panel_keypad.Controls.Add(Me.uic_boton8)
        Me.Panel_keypad.Controls.Add(Me.uic_boton0)
        Me.Panel_keypad.Controls.Add(Me.uic_boton1)
        Me.Panel_keypad.Controls.Add(Me.uic_boton4)
        Me.Panel_keypad.Controls.Add(Me.uic_boton7)
        Me.Panel_keypad.Location = New System.Drawing.Point(517, 317)
        Me.Panel_keypad.Name = "Panel_keypad"
        Me.Panel_keypad.Size = New System.Drawing.Size(345, 224)
        Me.Panel_keypad.TabIndex = 7
        '
        'uic_botonEnter
        '
        Me.uic_botonEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_botonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_botonEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_botonEnter.Location = New System.Drawing.Point(241, 115)
        Me.uic_botonEnter.Name = "uic_botonEnter"
        Me.uic_botonEnter.Size = New System.Drawing.Size(60, 87)
        Me.uic_botonEnter.TabIndex = 72
        Me.uic_botonEnter.Text = "Enter"
        Me.uic_botonEnter.UseVisualStyleBackColor = False
        '
        'uic_botonC
        '
        Me.uic_botonC.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_botonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_botonC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_botonC.Location = New System.Drawing.Point(241, 69)
        Me.uic_botonC.Name = "uic_botonC"
        Me.uic_botonC.Size = New System.Drawing.Size(60, 40)
        Me.uic_botonC.TabIndex = 71
        Me.uic_botonC.Text = "C"
        Me.uic_botonC.UseVisualStyleBackColor = False
        '
        'uic_botonBack
        '
        Me.uic_botonBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_botonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_botonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_botonBack.Location = New System.Drawing.Point(241, 23)
        Me.uic_botonBack.Name = "uic_botonBack"
        Me.uic_botonBack.Size = New System.Drawing.Size(60, 40)
        Me.uic_botonBack.TabIndex = 70
        Me.uic_botonBack.Text = "<--"
        Me.uic_botonBack.UseVisualStyleBackColor = False
        '
        'uic_boton3
        '
        Me.uic_boton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton3.Location = New System.Drawing.Point(175, 115)
        Me.uic_boton3.Name = "uic_boton3"
        Me.uic_boton3.Size = New System.Drawing.Size(60, 37)
        Me.uic_boton3.TabIndex = 63
        Me.uic_boton3.Text = "3"
        Me.uic_boton3.UseVisualStyleBackColor = False
        '
        'uic_boton6
        '
        Me.uic_boton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton6.Location = New System.Drawing.Point(175, 69)
        Me.uic_boton6.Name = "uic_boton6"
        Me.uic_boton6.Size = New System.Drawing.Size(60, 40)
        Me.uic_boton6.TabIndex = 66
        Me.uic_boton6.Text = "6"
        Me.uic_boton6.UseVisualStyleBackColor = False
        '
        'uic_boton9
        '
        Me.uic_boton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton9.Location = New System.Drawing.Point(175, 23)
        Me.uic_boton9.Name = "uic_boton9"
        Me.uic_boton9.Size = New System.Drawing.Size(60, 40)
        Me.uic_boton9.TabIndex = 69
        Me.uic_boton9.Text = "9"
        Me.uic_boton9.UseVisualStyleBackColor = False
        '
        'uic_boton2
        '
        Me.uic_boton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton2.Location = New System.Drawing.Point(109, 115)
        Me.uic_boton2.Name = "uic_boton2"
        Me.uic_boton2.Size = New System.Drawing.Size(60, 37)
        Me.uic_boton2.TabIndex = 62
        Me.uic_boton2.Text = "2"
        Me.uic_boton2.UseVisualStyleBackColor = False
        '
        'uic_boton5
        '
        Me.uic_boton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton5.Location = New System.Drawing.Point(109, 69)
        Me.uic_boton5.Name = "uic_boton5"
        Me.uic_boton5.Size = New System.Drawing.Size(60, 40)
        Me.uic_boton5.TabIndex = 65
        Me.uic_boton5.Text = "5"
        Me.uic_boton5.UseVisualStyleBackColor = False
        '
        'uic_boton8
        '
        Me.uic_boton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton8.Location = New System.Drawing.Point(109, 23)
        Me.uic_boton8.Name = "uic_boton8"
        Me.uic_boton8.Size = New System.Drawing.Size(60, 40)
        Me.uic_boton8.TabIndex = 68
        Me.uic_boton8.Text = "8"
        Me.uic_boton8.UseVisualStyleBackColor = False
        '
        'uic_boton0
        '
        Me.uic_boton0.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton0.Location = New System.Drawing.Point(109, 158)
        Me.uic_boton0.Name = "uic_boton0"
        Me.uic_boton0.Size = New System.Drawing.Size(60, 42)
        Me.uic_boton0.TabIndex = 58
        Me.uic_boton0.Text = "0"
        Me.uic_boton0.UseVisualStyleBackColor = False
        '
        'uic_boton1
        '
        Me.uic_boton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton1.Location = New System.Drawing.Point(43, 116)
        Me.uic_boton1.Name = "uic_boton1"
        Me.uic_boton1.Size = New System.Drawing.Size(60, 37)
        Me.uic_boton1.TabIndex = 61
        Me.uic_boton1.Text = "1"
        Me.uic_boton1.UseVisualStyleBackColor = False
        '
        'uic_boton4
        '
        Me.uic_boton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton4.Location = New System.Drawing.Point(43, 70)
        Me.uic_boton4.Name = "uic_boton4"
        Me.uic_boton4.Size = New System.Drawing.Size(60, 40)
        Me.uic_boton4.TabIndex = 64
        Me.uic_boton4.Text = "4"
        Me.uic_boton4.UseVisualStyleBackColor = False
        '
        'uic_boton7
        '
        Me.uic_boton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_boton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_boton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_boton7.Location = New System.Drawing.Point(43, 23)
        Me.uic_boton7.Name = "uic_boton7"
        Me.uic_boton7.Size = New System.Drawing.Size(60, 41)
        Me.uic_boton7.TabIndex = 67
        Me.uic_boton7.Text = "7"
        Me.uic_boton7.UseVisualStyleBackColor = False
        '
        'uic_Reloj
        '
        Me.uic_Reloj.Enabled = True
        Me.uic_Reloj.Interval = 1000
        '
        'Panel_cobro
        '
        Me.Panel_cobro.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel_cobro.Controls.Add(Me.Label5)
        Me.Panel_cobro.Controls.Add(Me.Label4)
        Me.Panel_cobro.Controls.Add(Me.Label3)
        Me.Panel_cobro.Controls.Add(Me.txt_Total)
        Me.Panel_cobro.Controls.Add(Me.txt_efectivo)
        Me.Panel_cobro.Controls.Add(Me.txt_vuelto)
        Me.Panel_cobro.Location = New System.Drawing.Point(10, 449)
        Me.Panel_cobro.Name = "Panel_cobro"
        Me.Panel_cobro.Size = New System.Drawing.Size(497, 91)
        Me.Panel_cobro.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 23)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Vuelto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Cancelado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.Enabled = False
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(373, 8)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(100, 21)
        Me.txt_Total.TabIndex = 17
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_efectivo
        '
        Me.txt_efectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_efectivo.Enabled = False
        Me.txt_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_efectivo.Location = New System.Drawing.Point(373, 38)
        Me.txt_efectivo.Name = "txt_efectivo"
        Me.txt_efectivo.Size = New System.Drawing.Size(100, 21)
        Me.txt_efectivo.TabIndex = 16
        Me.txt_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_vuelto
        '
        Me.txt_vuelto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_vuelto.Enabled = False
        Me.txt_vuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vuelto.Location = New System.Drawing.Point(373, 67)
        Me.txt_vuelto.Name = "txt_vuelto"
        Me.txt_vuelto.Size = New System.Drawing.Size(100, 21)
        Me.txt_vuelto.TabIndex = 15
        Me.txt_vuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'uic_botonF1
        '
        Me.uic_botonF1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_botonF1.BackColor = System.Drawing.Color.LightGreen
        Me.uic_botonF1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uic_botonF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_botonF1.Location = New System.Drawing.Point(868, 357)
        Me.uic_botonF1.Name = "uic_botonF1"
        Me.uic_botonF1.Size = New System.Drawing.Size(92, 35)
        Me.uic_botonF1.TabIndex = 80
        Me.uic_botonF1.Text = "F2"
        Me.uic_botonF1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.uic_botonF1.UseVisualStyleBackColor = False
        '
        'uic_BotonF4
        '
        Me.uic_BotonF4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_BotonF4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_BotonF4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uic_BotonF4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_BotonF4.Location = New System.Drawing.Point(868, 398)
        Me.uic_BotonF4.Name = "uic_BotonF4"
        Me.uic_BotonF4.Size = New System.Drawing.Size(92, 35)
        Me.uic_BotonF4.TabIndex = 78
        Me.uic_BotonF4.Text = "F3"
        Me.uic_BotonF4.UseVisualStyleBackColor = False
        '
        'uic_botonF2
        '
        Me.uic_botonF2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_botonF2.BackColor = System.Drawing.Color.Red
        Me.uic_botonF2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uic_botonF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_botonF2.Location = New System.Drawing.Point(868, 318)
        Me.uic_botonF2.Name = "uic_botonF2"
        Me.uic_botonF2.Size = New System.Drawing.Size(92, 35)
        Me.uic_botonF2.TabIndex = 76
        Me.uic_botonF2.Text = "F1"
        Me.uic_botonF2.UseVisualStyleBackColor = False
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.uic_Nrotransaccion, Me.uic_FechaHora, Me.CommandBarSeparator1, Me.uic_VersionApp})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(972, 22)
        Me.RadStatusStrip1.TabIndex = 82
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "Office2010Black"
        '
        'uic_Nrotransaccion
        '
        Me.uic_Nrotransaccion.Name = "uic_Nrotransaccion"
        Me.RadStatusStrip1.SetSpring(Me.uic_Nrotransaccion, False)
        Me.uic_Nrotransaccion.Text = "Nro transaccion"
        Me.uic_Nrotransaccion.TextWrap = True
        '
        'uic_FechaHora
        '
        Me.uic_FechaHora.Name = "uic_FechaHora"
        Me.RadStatusStrip1.SetSpring(Me.uic_FechaHora, False)
        Me.uic_FechaHora.Text = "Fecha/Hora"
        Me.uic_FechaHora.TextWrap = True
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator1, False)
        Me.CommandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'uic_VersionApp
        '
        Me.uic_VersionApp.Name = "uic_VersionApp"
        Me.RadStatusStrip1.SetSpring(Me.uic_VersionApp, False)
        Me.uic_VersionApp.Text = "VersionApp"
        Me.uic_VersionApp.TextWrap = True
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel13)
        Me.RadGroupBox2.Controls.Add(Me.uic_BuscaArticulo)
        Me.RadGroupBox2.Controls.Add(Me.uic_BuscarProducto)
        Me.RadGroupBox2.Controls.Add(Me.GridProductos)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(514, 4)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(450, 308)
        Me.RadGroupBox2.TabIndex = 83
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        '
        'RadLabel13
        '
        Me.RadLabel13.AutoSize = False
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel13.Location = New System.Drawing.Point(171, 5)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(126, 18)
        Me.RadLabel13.TabIndex = 88
        Me.RadLabel13.Text = "Buscar Articulo"
        '
        'uic_BuscaArticulo
        '
        Me.uic_BuscaArticulo.Image = Global.delevery.My.Resources.Resources.magnifier
        Me.uic_BuscaArticulo.Location = New System.Drawing.Point(352, 15)
        Me.uic_BuscaArticulo.Name = "uic_BuscaArticulo"
        Me.uic_BuscaArticulo.Size = New System.Drawing.Size(33, 32)
        Me.uic_BuscaArticulo.TabIndex = 87
        '
        'uic_BuscarProducto
        '
        Me.uic_BuscarProducto.Location = New System.Drawing.Point(65, 27)
        Me.uic_BuscarProducto.Name = "uic_BuscarProducto"
        Me.uic_BuscarProducto.Size = New System.Drawing.Size(274, 20)
        Me.uic_BuscarProducto.TabIndex = 4
        Me.uic_BuscarProducto.ThemeName = "ControlDefault"
        '
        'GridProductos
        '
        Me.GridProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridProductos.Location = New System.Drawing.Point(5, 55)
        '
        '
        '
        Me.GridProductos.MasterTemplate.AllowAddNewRow = False
        Me.GridProductos.MasterTemplate.AllowColumnReorder = False
        Me.GridProductos.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.GridProductos.Name = "GridProductos"
        Me.GridProductos.ReadOnly = True
        Me.GridProductos.Size = New System.Drawing.Size(437, 245)
        Me.GridProductos.TabIndex = 0
        Me.GridProductos.Text = "RadGridView2"
        Me.GridProductos.ThemeName = "Office2010Black"
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Image = Global.delevery.My.Resources.Resources._Exit
        Me.btn_salir.Location = New System.Drawing.Point(866, 498)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(90, 41)
        Me.btn_salir.TabIndex = 84
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Image = Global.delevery.My.Resources.Resources.check
        Me.btn_aceptar.Location = New System.Drawing.Point(866, 442)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(94, 42)
        Me.btn_aceptar.TabIndex = 85
        Me.btn_aceptar.Text = "F4"
        Me.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cantidad, Me.Desc, Me.precio, Me.Column3, Me.id_productoGrid, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(497, 370)
        Me.DataGridView1.TabIndex = 86
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        Me.codigo.Width = 70
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cant."
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 68
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
        Me.precio.Width = 85
        '
        'Column3
        '
        Me.Column3.HeaderText = "Valor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 85
        '
        'id_productoGrid
        '
        Me.id_productoGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_productoGrid.HeaderText = "idprod"
        Me.id_productoGrid.Name = "id_productoGrid"
        Me.id_productoGrid.ReadOnly = True
        Me.id_productoGrid.Visible = False
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        Me.Eliminar.Width = 90
        '
        'FrmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.uic_botonF1)
        Me.Controls.Add(Me.uic_BotonF4)
        Me.Controls.Add(Me.uic_botonF2)
        Me.Controls.Add(Me.Panel_cobro)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.Panel_keypad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCaja"
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_BuscaVta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_keypad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_keypad.ResumeLayout(False)
        CType(Me.Panel_cobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_cobro.ResumeLayout(False)
        Me.Panel_cobro.PerformLayout()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_BuscaArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_BuscarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridProductos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_BuscaVta As Telerik.WinControls.UI.RadButton
    Friend WithEvents IdTicket As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel_keypad As Telerik.WinControls.UI.RadPanel
    Friend WithEvents uic_botonEnter As System.Windows.Forms.Button
    Friend WithEvents uic_botonC As System.Windows.Forms.Button
    Friend WithEvents uic_botonBack As System.Windows.Forms.Button
    Friend WithEvents uic_boton3 As System.Windows.Forms.Button
    Friend WithEvents uic_boton6 As System.Windows.Forms.Button
    Friend WithEvents uic_boton9 As System.Windows.Forms.Button
    Friend WithEvents uic_boton2 As System.Windows.Forms.Button
    Friend WithEvents uic_boton5 As System.Windows.Forms.Button
    Friend WithEvents uic_boton8 As System.Windows.Forms.Button
    Friend WithEvents uic_boton0 As System.Windows.Forms.Button
    Friend WithEvents uic_boton1 As System.Windows.Forms.Button
    Friend WithEvents uic_boton4 As System.Windows.Forms.Button
    Friend WithEvents uic_boton7 As System.Windows.Forms.Button
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents uic_Reloj As System.Windows.Forms.Timer
    Friend WithEvents Panel_cobro As Telerik.WinControls.UI.RadPanel
    Friend WithEvents uic_botonF1 As System.Windows.Forms.Button
    Friend WithEvents uic_BotonF4 As System.Windows.Forms.Button
    Friend WithEvents uic_botonF2 As System.Windows.Forms.Button
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents uic_Nrotransaccion As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents uic_FechaHora As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents uic_VersionApp As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_BuscaArticulo As Telerik.WinControls.UI.RadButton
    Friend WithEvents uic_BuscarProducto As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents GridProductos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents txt_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents txt_vuelto As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_productoGrid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
