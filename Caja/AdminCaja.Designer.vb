<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminCaja
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
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.uic_cierre = New System.Windows.Forms.Button()
        Me.uic_retiro = New System.Windows.Forms.Button()
        Me.uic_apertura = New System.Windows.Forms.Button()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.uic_Volver = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.uic_Volver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.uic_Volver)
        Me.RadGroupBox1.Controls.Add(Me.uic_cierre)
        Me.RadGroupBox1.Controls.Add(Me.uic_retiro)
        Me.RadGroupBox1.Controls.Add(Me.uic_apertura)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(7, 9)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(476, 124)
        Me.RadGroupBox1.TabIndex = 143
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'uic_cierre
        '
        Me.uic_cierre.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_cierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_cierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_cierre.Location = New System.Drawing.Point(282, 34)
        Me.uic_cierre.Name = "uic_cierre"
        Me.uic_cierre.Size = New System.Drawing.Size(96, 57)
        Me.uic_cierre.TabIndex = 6
        Me.uic_cierre.Text = "Cierre"
        Me.uic_cierre.UseVisualStyleBackColor = False
        '
        'uic_retiro
        '
        Me.uic_retiro.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_retiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_retiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_retiro.Location = New System.Drawing.Point(161, 34)
        Me.uic_retiro.Name = "uic_retiro"
        Me.uic_retiro.Size = New System.Drawing.Size(96, 57)
        Me.uic_retiro.TabIndex = 5
        Me.uic_retiro.Text = "Retiro"
        Me.uic_retiro.UseVisualStyleBackColor = False
        '
        'uic_apertura
        '
        Me.uic_apertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uic_apertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uic_apertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_apertura.Location = New System.Drawing.Point(40, 34)
        Me.uic_apertura.Name = "uic_apertura"
        Me.uic_apertura.Size = New System.Drawing.Size(96, 57)
        Me.uic_apertura.TabIndex = 4
        Me.uic_apertura.Text = "Apertura"
        Me.uic_apertura.UseVisualStyleBackColor = False
        '
        'uic_Volver
        '
        Me.uic_Volver.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.uic_Volver.Image = Global.delevery.My.Resources.Resources._Exit
        Me.uic_Volver.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.uic_Volver.Location = New System.Drawing.Point(406, 34)
        Me.uic_Volver.Name = "uic_Volver"
        Me.uic_Volver.Size = New System.Drawing.Size(56, 57)
        Me.uic_Volver.TabIndex = 7
        Me.uic_Volver.Text = "RadButton4"
        Me.uic_Volver.ThemeName = "Office2010Black"
        '
        'AdminCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "AdminCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminCaja"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.uic_Volver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_cierre As System.Windows.Forms.Button
    Friend WithEvents uic_retiro As System.Windows.Forms.Button
    Friend WithEvents uic_apertura As System.Windows.Forms.Button
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents uic_Volver As Telerik.WinControls.UI.RadButton
End Class
