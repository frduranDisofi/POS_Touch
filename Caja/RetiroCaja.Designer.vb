<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetiroCaja
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
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.uic_Volver = New Telerik.WinControls.UI.RadButton()
        Me.btnGrabar = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Glosa = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_MontoTotal = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.uic_Volver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Glosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_MontoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.uic_Volver)
        Me.RadPanel2.Controls.Add(Me.btnGrabar)
        Me.RadPanel2.Location = New System.Drawing.Point(31, 5)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(291, 45)
        Me.RadPanel2.TabIndex = 151
        '
        'uic_Volver
        '
        Me.uic_Volver.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.uic_Volver.Image = Global.delevery.My.Resources.Resources._Exit
        Me.uic_Volver.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.uic_Volver.Location = New System.Drawing.Point(150, 6)
        Me.uic_Volver.Name = "uic_Volver"
        Me.uic_Volver.Size = New System.Drawing.Size(40, 35)
        Me.uic_Volver.TabIndex = 88
        Me.uic_Volver.Text = "RadButton4"
        Me.uic_Volver.ThemeName = "Office2010Black"
        '
        'btnGrabar
        '
        Me.btnGrabar.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.btnGrabar.Image = Global.delevery.My.Resources.Resources.Save
        Me.btnGrabar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGrabar.Location = New System.Drawing.Point(101, 6)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(40, 35)
        Me.btnGrabar.TabIndex = 81
        Me.btnGrabar.Text = "RadButton1"
        Me.btnGrabar.ThemeName = "Office2010Black"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.uic_Glosa)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.Controls.Add(Me.uic_MontoTotal)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(328, 95)
        Me.RadGroupBox2.TabIndex = 150
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(16, 52)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(38, 19)
        Me.RadLabel3.TabIndex = 153
        Me.RadLabel3.Text = "Glosa"
        '
        'uic_Glosa
        '
        Me.uic_Glosa.Location = New System.Drawing.Point(60, 49)
        Me.uic_Glosa.MaxLength = 200
        Me.uic_Glosa.Name = "uic_Glosa"
        Me.uic_Glosa.Size = New System.Drawing.Size(242, 20)
        Me.uic_Glosa.TabIndex = 152
        Me.uic_Glosa.ThemeName = "ControlDefault"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(16, 19)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(85, 19)
        Me.RadLabel1.TabIndex = 149
        Me.RadLabel1.Text = "Monto Retiro"
        '
        'uic_MontoTotal
        '
        Me.uic_MontoTotal.Location = New System.Drawing.Point(103, 17)
        Me.uic_MontoTotal.Name = "uic_MontoTotal"
        Me.uic_MontoTotal.Size = New System.Drawing.Size(92, 20)
        Me.uic_MontoTotal.TabIndex = 148
        Me.uic_MontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uic_MontoTotal.ThemeName = "ControlDefault"
        '
        'RetiroCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 153)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "RetiroCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RetiroCaja"
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.uic_Volver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Glosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_MontoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents uic_Volver As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGrabar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Glosa As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_MontoTotal As Telerik.WinControls.UI.RadTextBox
End Class
