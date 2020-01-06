Public Class Cierre_Caja

    Private _IdUsuario As Integer

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Private Sub uic_Volver_Click(sender As Object, e As EventArgs) Handles uic_Volver.Click
        Me.Hide()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Me.uic_Glosa.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show("Debe ingresar Glosa" & vbCrLf & "Aviso")
            Exit Sub
        End If

        Dim resp As String = ""
        Dim neg As New ProyectoNegocio.AdminCaja
        Dim Glosa As String = Me.uic_Glosa.Text
        resp = neg.CerrarCaja(IdUsuario, Glosa)
        Try
            If CInt(resp) > 0 Then
                Dim frm As New CierreCaja
                frm.IdUsuario = IdUsuario
                frm.IdCaja = resp
                frm.ShowDialog()
                Telerik.WinControls.RadMessageBox.Show("Caja Cerrada", "Caja")
            Else
                Telerik.WinControls.RadMessageBox.Show("A ocurrido un error" & vbCrLf & resp, "Aviso")
            End If
        Catch ex As Exception
        End Try
        Me.Hide()
    End Sub
End Class