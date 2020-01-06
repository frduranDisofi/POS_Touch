<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impresoras
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
        Me.uic_listaimpresoras = New System.Windows.Forms.ComboBox()
        Me.uic_cancelar = New System.Windows.Forms.Button()
        Me.uic_aceptar = New System.Windows.Forms.Button()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.uic_listaimpresoras)
        Me.RadGroupBox1.Controls.Add(Me.uic_cancelar)
        Me.RadGroupBox1.Controls.Add(Me.uic_aceptar)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel7)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(399, 160)
        Me.RadGroupBox1.TabIndex = 2
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'uic_listaimpresoras
        '
        Me.uic_listaimpresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uic_listaimpresoras.FormattingEnabled = True
        Me.uic_listaimpresoras.Location = New System.Drawing.Point(37, 46)
        Me.uic_listaimpresoras.Name = "uic_listaimpresoras"
        Me.uic_listaimpresoras.Size = New System.Drawing.Size(325, 21)
        Me.uic_listaimpresoras.TabIndex = 19
        '
        'uic_cancelar
        '
        Me.uic_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.uic_cancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_cancelar.Location = New System.Drawing.Point(221, 92)
        Me.uic_cancelar.Name = "uic_cancelar"
        Me.uic_cancelar.Size = New System.Drawing.Size(75, 32)
        Me.uic_cancelar.TabIndex = 18
        Me.uic_cancelar.Text = "Cancelar"
        Me.uic_cancelar.UseVisualStyleBackColor = True
        '
        'uic_aceptar
        '
        Me.uic_aceptar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.uic_aceptar.Location = New System.Drawing.Point(103, 92)
        Me.uic_aceptar.Name = "uic_aceptar"
        Me.uic_aceptar.Size = New System.Drawing.Size(75, 32)
        Me.uic_aceptar.TabIndex = 17
        Me.uic_aceptar.Text = "Aceptar"
        Me.uic_aceptar.UseVisualStyleBackColor = True
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel7.Location = New System.Drawing.Point(166, 21)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(66, 19)
        Me.RadLabel7.TabIndex = 15
        Me.RadLabel7.Text = "Impresora"
        '
        'Impresoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Impresoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresoras"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_listaimpresoras As System.Windows.Forms.ComboBox
    Friend WithEvents uic_cancelar As System.Windows.Forms.Button
    Friend WithEvents uic_aceptar As System.Windows.Forms.Button
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
End Class
