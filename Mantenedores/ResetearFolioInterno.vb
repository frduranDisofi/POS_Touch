Imports ProyectoNegocio

Public Class ResetearFolioInterno

    Private Sub ResetearFolioInterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Neg As New Mantenimiento
        Dim resp As String = ""
        resp = Neg.TreaUltimoFolio
        Me.uic_UltimoFolio.Text = resp
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim neg As New Mantenimiento
        Dim resp As String = ""
        resp = neg.ReseteaFolioInterno
        If resp = "OK" Then
            Telerik.WinControls.RadMessageBox.Show("Resetea folio correctamente", "Folios")
            Me.uic_UltimoFolio.Text = "0"
        Else
            Telerik.WinControls.RadMessageBox.Show("A ocurriod un error" & vbCrLf & resp, "Folios")
        End If

    End Sub

    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Close()
    End Sub
End Class