﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cierre_Caja
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
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.btnGrabar = New Telerik.WinControls.UI.RadButton()
        Me.uic_Volver = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Glosa = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Volver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Glosa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.btnGrabar)
        Me.RadPanel2.Controls.Add(Me.uic_Volver)
        Me.RadPanel2.Location = New System.Drawing.Point(15, 17)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(407, 45)
        Me.RadPanel2.TabIndex = 147
        '
        'btnGrabar
        '
        Me.btnGrabar.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.btnGrabar.Image = Global.delevery.My.Resources.Resources.Save
        Me.btnGrabar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGrabar.Location = New System.Drawing.Point(160, 7)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(40, 35)
        Me.btnGrabar.TabIndex = 0
        Me.btnGrabar.Text = "RadButton1"
        Me.btnGrabar.ThemeName = "Office2010Black"
        '
        'uic_Volver
        '
        Me.uic_Volver.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.uic_Volver.Image = Global.delevery.My.Resources.Resources._Exit
        Me.uic_Volver.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.uic_Volver.Location = New System.Drawing.Point(206, 7)
        Me.uic_Volver.Name = "uic_Volver"
        Me.uic_Volver.Size = New System.Drawing.Size(40, 35)
        Me.uic_Volver.TabIndex = 1
        Me.uic_Volver.Text = "RadButton4"
        Me.uic_Volver.ThemeName = "Office2010Black"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.uic_Glosa)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(15, 68)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(407, 76)
        Me.RadGroupBox1.TabIndex = 146
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(29, 28)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(38, 19)
        Me.RadLabel1.TabIndex = 12
        Me.RadLabel1.Text = "Glosa"
        '
        'uic_Glosa
        '
        Me.uic_Glosa.Location = New System.Drawing.Point(74, 26)
        Me.uic_Glosa.Name = "uic_Glosa"
        Me.uic_Glosa.Size = New System.Drawing.Size(290, 20)
        Me.uic_Glosa.TabIndex = 1
        Me.uic_Glosa.ThemeName = "ControlDefault"
        '
        'Cierre_Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Cierre_Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre_Caja"
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.btnGrabar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Volver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Glosa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnGrabar As Telerik.WinControls.UI.RadButton
    Friend WithEvents uic_Volver As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Glosa As Telerik.WinControls.UI.RadTextBox
End Class
