Public Class AperturaCaja

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

        Dim MontoEfectivo As String
        MontoEfectivo = Me.uic_MontoEfectivo.Text
        If Me.uic_MontoEfectivo.Text = "" OrElse Me.uic_MontoEfectivo.Text = "0" Then
            Telerik.WinControls.RadMessageBox.Show(Me, "Debe ingresar monto.", "Alerta")
            Me.uic_MontoEfectivo.Text = ""
            Me.uic_MontoEfectivo.Focus()
            Exit Sub
        Else
            Dim vmonto As Long = IIf(Me.uic_MontoEfectivo.Text = "", 0, CInt(Me.uic_MontoEfectivo.Text))
            Dim vglosa As String = Me.uic_Glosa.Text.Trim
            Dim dt As String
            Dim Neg As New ProyectoNegocio.AdminCaja
            dt = Neg.AbrirCaja(IdUsuario, vmonto, vglosa)
            If dt = "OK" Then
                Telerik.WinControls.RadMessageBox.Show(Me, "Apertura registrada exitosamente.", "Alerta")
                limpiar()
                Me.Hide()
                Me.Close()
                Dim frmAdminCaja As New AdminCaja
                frmAdminCaja.Hide()
                'Dim frmCaja As New FrmCaja
                'frmCaja.IdUsuario = IdUsuario
                'frmCaja.ShowDialog()
            End If
        End If
    End Sub

    Private Sub limpiar()
        Me.uic_MontoEfectivo.Text = ""
        Me.uic_Glosa.Text = ""
    End Sub
End Class