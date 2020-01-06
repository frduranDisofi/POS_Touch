<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpresionCopia
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
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.uic_primera = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uic_copia1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.uic_Salir = New Telerik.WinControls.UI.RadMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.uic_Segunda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Controls.Add(Me.Button3)
        Me.RadGroupBox4.Controls.Add(Me.uic_primera)
        Me.RadGroupBox4.Controls.Add(Me.Label5)
        Me.RadGroupBox4.Controls.Add(Me.uic_copia1)
        Me.RadGroupBox4.Controls.Add(Me.Label6)
        Me.RadGroupBox4.HeaderText = ""
        Me.RadGroupBox4.Location = New System.Drawing.Point(11, 39)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(348, 89)
        Me.RadGroupBox4.TabIndex = 189
        Me.RadGroupBox4.ThemeName = "Office2010Black"
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.Image = Global.delevery.My.Resources.Resources.magnifier
        Me.Button3.Location = New System.Drawing.Point(294, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 37)
        Me.Button3.TabIndex = 105
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = True
        '
        'uic_primera
        '
        Me.uic_primera.Location = New System.Drawing.Point(122, 49)
        Me.uic_primera.MaxLength = 90
        Me.uic_primera.Name = "uic_primera"
        Me.uic_primera.Size = New System.Drawing.Size(166, 20)
        Me.uic_primera.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Impresora Venta"
        '
        'uic_copia1
        '
        Me.uic_copia1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.uic_copia1.Location = New System.Drawing.Point(122, 21)
        Me.uic_copia1.Name = "uic_copia1"
        Me.uic_copia1.ReadOnly = True
        Me.uic_copia1.Size = New System.Drawing.Size(88, 25)
        Me.uic_copia1.TabIndex = 100
        Me.uic_copia1.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Copia"
        '
        'uic_Salir
        '
        Me.uic_Salir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.uic_Salir.Image = Global.delevery.My.Resources.Resources.Exit1
        Me.uic_Salir.Name = "uic_Salir"
        Me.uic_Salir.Text = "Salir"
        Me.uic_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button2
        '
        Me.Button2.Image = Global.delevery.My.Resources.Resources.disk_blue
        Me.Button2.Location = New System.Drawing.Point(168, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 37)
        Me.Button2.TabIndex = 192
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadMenu1
        '
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.uic_Salir})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadMenu1.Size = New System.Drawing.Size(373, 28)
        Me.RadMenu1.TabIndex = 21
        Me.RadMenu1.Text = "RadMenu1"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.Button1)
        Me.RadGroupBox1.Controls.Add(Me.uic_Segunda)
        Me.RadGroupBox1.Controls.Add(Me.Label1)
        Me.RadGroupBox1.Controls.Add(Me.TextBox2)
        Me.RadGroupBox1.Controls.Add(Me.Label2)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(11, 134)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(348, 89)
        Me.RadGroupBox1.TabIndex = 194
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Image = Global.delevery.My.Resources.Resources.magnifier
        Me.Button1.Location = New System.Drawing.Point(270, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 37)
        Me.Button1.TabIndex = 105
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'uic_Segunda
        '
        Me.uic_Segunda.Location = New System.Drawing.Point(92, 49)
        Me.uic_Segunda.MaxLength = 90
        Me.uic_Segunda.Name = "uic_Segunda"
        Me.uic_Segunda.Size = New System.Drawing.Size(166, 20)
        Me.uic_Segunda.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Boleta"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(92, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(88, 25)
        Me.TextBox2.TabIndex = 100
        Me.TextBox2.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Copia"
        '
        'ImpresionCopia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Controls.Add(Me.RadMenu1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "ImpresionCopia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion Copia"
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        Me.RadGroupBox4.PerformLayout()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uic_Salir As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_primera As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents uic_copia1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents uic_Segunda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
