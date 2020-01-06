<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetearFolioInterno
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
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_UltimoFolio = New Telerik.WinControls.UI.RadTextBox()
        Me.btnGrabar = New Telerik.WinControls.UI.RadButton()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.uic_Salir = New Telerik.WinControls.UI.RadMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_UltimoFolio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadLabel8)
        Me.RadGroupBox1.Controls.Add(Me.uic_UltimoFolio)
        Me.RadGroupBox1.Controls.Add(Me.btnGrabar)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(348, 104)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel8.Location = New System.Drawing.Point(50, 42)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(78, 19)
        Me.RadLabel8.TabIndex = 98
        Me.RadLabel8.Text = "Ultimo Folio"
        '
        'uic_UltimoFolio
        '
        Me.uic_UltimoFolio.Location = New System.Drawing.Point(131, 42)
        Me.uic_UltimoFolio.MaxLength = 3
        Me.uic_UltimoFolio.Name = "uic_UltimoFolio"
        Me.uic_UltimoFolio.ReadOnly = True
        Me.uic_UltimoFolio.Size = New System.Drawing.Size(60, 20)
        Me.uic_UltimoFolio.TabIndex = 0
        Me.uic_UltimoFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uic_UltimoFolio.ThemeName = "ControlDefault"
        '
        'btnGrabar
        '
        Me.btnGrabar.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.btnGrabar.Image = Global.delevery.My.Resources.Resources.Save
        Me.btnGrabar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGrabar.Location = New System.Drawing.Point(230, 34)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(40, 35)
        Me.btnGrabar.TabIndex = 1
        Me.btnGrabar.Text = "RadButton1"
        Me.btnGrabar.ThemeName = "Office2010Black"
        Me.ToolTip1.SetToolTip(Me.btnGrabar, "Resetear folio")
        '
        'RadMenu1
        '
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.uic_Salir})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadMenu1.Size = New System.Drawing.Size(387, 29)
        Me.RadMenu1.TabIndex = 196
        Me.RadMenu1.Text = "RadMenu1"
        Me.RadMenu1.ThemeName = "Office2010Black"
        '
        'uic_Salir
        '
        Me.uic_Salir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.uic_Salir.Image = Global.delevery.My.Resources.Resources.Exit1
        Me.uic_Salir.Name = "uic_Salir"
        Me.uic_Salir.Text = "Salir"
        Me.uic_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'ResetearFolioInterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadMenu1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "ResetearFolioInterno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resetear Folio Interno"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_UltimoFolio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents uic_Salir As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents btnGrabar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_UltimoFolio As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
