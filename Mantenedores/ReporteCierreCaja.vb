Imports ProyectoNegocio

Public Class ReporteCierreCaja
    Private linea As Integer
    Private idusuario As Integer
    Private idcaja As Integer
    Private fecha As String

    Private Sub uic_BuscaVta_Click(sender As Object, e As EventArgs) Handles uic_BuscaVta.Click
        mostrarcierre()
    End Sub
    Private Sub mostrarcierre()
        Dim neg As New Venta
        Dim fechaini As String = Format(Me.uic_FechaIni.Value, "yyyy-MM-dd")
        Dim fechafin As String = Format(Me.uic_FechaFin.Value, "yyyy-MM-dd")
        Dim dt As New DataTable
        dt = neg.grillaCierre(fechaini, fechafin)
        If dt.Rows.Count > 0 Then
            Me.GridVentas.DataSource = dt
            ConfiguraGrilla()
        Else
            Me.GridVentas.DataSource = Nothing
        End If
    End Sub
    Private Sub ConfiguraGrilla()
        Me.GridVentas.Columns("idcaja").IsVisible = False

        Me.GridVentas.Columns("monto").Width = 40
        Me.GridVentas.Columns("monto").IsVisible = True
        Me.GridVentas.Columns("monto").ReadOnly = True
        Me.GridVentas.Columns("monto").HeaderText = "Monto"

        Me.GridVentas.Columns("fecha").Width = 80
        Me.GridVentas.Columns("fecha").IsVisible = True
        Me.GridVentas.Columns("fecha").ReadOnly = True
        Me.GridVentas.Columns("fecha").FormatString = "{0:dd-MM-yyyy}"
        Me.GridVentas.Columns("fecha").HeaderText = "Fecha"

        Me.GridVentas.Columns("usuario").Width = 100
        Me.GridVentas.Columns("usuario").IsVisible = True
        Me.GridVentas.Columns("usuario").ReadOnly = True
        Me.GridVentas.Columns("usuario").HeaderText = "Usuario"

        Me.GridVentas.Columns("id_usuario").IsVisible = False
    End Sub

    Private Sub ReporteCierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.uic_FechaIni.Value = Now
        Me.uic_FechaFin.Value = Now
        mostrarcierre()
    End Sub

    'Private Sub GridVentas_Click(sender As Object, e As EventArgs) Handles GridVentas.Click

    'End Sub

    Private Sub uic_Volver_Click(sender As Object, e As EventArgs) Handles uic_Volver.Click
        Me.Hide()
    End Sub

    Private Sub GridVentas_DoubleClick(sender As Object, e As EventArgs) Handles GridVentas.DoubleClick
        Try
            linea = Me.GridVentas.Rows.IndexOf(Me.GridVentas.CurrentRow)
            Me.idusuario = Me.GridVentas.Rows(linea).Cells(4).Value
            Me.idcaja = Me.GridVentas.Rows(linea).Cells(0).Value
            Dim _fecha As Date = Me.GridVentas.Rows(linea).Cells(2).Value
            Me.fecha = Format(_fecha, "yyyy-MM-dd")


            Dim frm As New CierreCaja
            frm.IdUsuario = Me.idusuario
            frm.IdCaja = Me.idcaja
            frm.Fecha = Me.fecha
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
End Class