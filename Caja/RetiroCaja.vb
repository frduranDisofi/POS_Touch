Public Class RetiroCaja

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
        If Not validador.validoNumero(Me.uic_MontoTotal.Text.Trim, 0) Then
            Telerik.WinControls.RadMessageBox.Show(Me, "Debe ingresar Monto", "Alerta")
            Me.uic_MontoTotal.Focus()
            Exit Sub
        End If

        If Me.uic_Glosa.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show(Me, "Debe ingresar glosa", "Alerta")
            Me.uic_Glosa.Focus()
            Exit Sub
        End If

        Dim usuario As Integer = IdUsuario
        Dim Glosa As String = ""
        Dim Monto As Integer = CType(uic_MontoTotal.Text, Integer)
        Dim Neg As New ProyectoNegocio.RetiroCaja

        Dim vresp As String = Neg.ValidaMontoRetiro(usuario, Monto)
        If vresp <> "OK" Then
            Telerik.WinControls.RadMessageBox.Show(Me, "Monto mayor a cantidad apertura", "Alerta")
        Else
            Dim vrespGraba As String = Neg.GuardarRetiro(usuario, Monto, Glosa)
            If vrespGraba = "OK" Then
                MsgBox("Retiro Realizado con Exito")
                Me.Hide()
            End If
        End If
    End Sub
End Class