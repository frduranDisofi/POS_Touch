Imports ProyectoNegocio
Public Class Info_Ventas

    Private Sub Info_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.uic_FechaIni.Value = Now
        Me.uic_FechaFin.Value = Now
        CargaCombo()
    End Sub
    Private Sub CargaCombo()
        Dim Neg As New Combos
        Try
            Me.uic_Usuario.DataSource = Neg.GetUsuario
            Me.uic_Usuario.DisplayMember = "nombre"
            Me.uic_Usuario.ValueMember = "id"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs) Handles RadMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub uic_Ventas_Click(sender As Object, e As EventArgs) Handles uic_Ventas.Click
        Dim frm As New InfoVentas
        frm.FechaIni = Format(Me.uic_FechaIni.Value, "yyyy-dd-MM")
        frm.FechaFin = Format(Me.uic_FechaFin.Value, "yyyy-dd-MM")
        frm.Usuario = Me.uic_Usuario.SelectedValue()
        frm.Show()
    End Sub

End Class