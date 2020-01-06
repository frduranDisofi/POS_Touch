Public Class AdminCaja

    Private _IdUsuario As Integer

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Private Sub uic_apertura_Click(sender As Object, e As EventArgs) Handles uic_apertura.Click
        Dim frmApertura As New AperturaCaja
        frmApertura.IdUsuario = IdUsuario
        Dim Neg As New ProyectoNegocio.AdminCaja

        Dim vresp As String = Neg.ValidaCaja(IdUsuario)
        If vresp <> "OK" Then
            Dim frmCajero As New FrmCaja
            frmApertura.IdUsuario = IdUsuario
            frmApertura.ShowDialog()
            frmApertura.Hide()
        Else
            Telerik.WinControls.RadMessageBox.Show(Me, "Tiene caja Abierta", "Alerta")
        End If
        Me.Hide()
    End Sub

    Private Sub uic_retiro_Click(sender As Object, e As EventArgs) Handles uic_retiro.Click
        Dim frmRetiro As New RetiroCaja
        frmRetiro.IdUsuario = IdUsuario
        Dim Neg As New ProyectoNegocio.AdminCaja

        Dim vresp As String = Neg.ValidaCaja(IdUsuario)
        If vresp = "OK" Then
            frmRetiro.ShowDialog()
            frmRetiro.Hide()
        Else
            Telerik.WinControls.RadMessageBox.Show(Me, "Debe abrir caja", "Alerta")
        End If
        'Me.Hide()
    End Sub

    Private Sub uic_cierre_Click(sender As Object, e As EventArgs) Handles uic_cierre.Click
        Dim Neg As New ProyectoNegocio.AdminCaja
        Dim vresp As String = Neg.ValidaCaja(IdUsuario)
        If vresp = "OK" Then
            Dim frmCierre As New Cierre_Caja
            frmCierre.IdUsuario = IdUsuario
            frmCierre.ShowDialog()
            Me.Hide()
        Else
            Telerik.WinControls.RadMessageBox.Show(Me, "Debe abrir caja", "Alerta")
        End If
        'Me.Hide()
    End Sub

    Private Sub uic_Volver_Click(sender As Object, e As EventArgs) Handles uic_Volver.Click
        Me.Hide()
    End Sub
End Class