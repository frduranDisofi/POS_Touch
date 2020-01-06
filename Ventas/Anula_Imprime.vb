Imports ProyectoNegocio
Public Class Anula_Imprime
    Private Linea As Integer
    Private NroTicket As Integer
    Private NroBoleta As Integer
    Private _Perfil As Integer

    Public Property Perfil As Integer
        Get
            Return _Perfil
        End Get
        Set(value As Integer)
            _Perfil = value
        End Set
    End Property
    Private _usuario As Integer
    Public Property usuario() As Integer
        Get
            Return _usuario
        End Get
        Set(ByVal value As Integer)
            _usuario = value
        End Set
    End Property

    Private Sub Anula_Imprime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Perfil <> 1 Then
            Me.btnBoleta.Visible = False
            Me.btnEliminar.Visible = False
        End If
        iniciar()
    End Sub
    Private Sub uic_BuscaVta_Click(sender As Object, e As EventArgs) Handles uic_BuscaVta.Click
        Dim neg As New Venta
        Dim fechaini As String = Format(Me.uic_FechaIni.Value, "yyyy-MM-dd")
        Dim fechafin As String = Format(Me.uic_FechaFin.Value, "yyyy-MM-dd")
        Dim dt As New DataTable
        dt = neg.BuscarVentas(fechaini, fechafin)
        If dt.Rows.Count > 0 Then
            Me.GridVentas.DataSource = dt
            ConfiguraGrilla()
        Else
            Me.GridVentas.DataSource = Nothing
        End If
    End Sub
    Private Sub ConfiguraGrilla()
        Me.GridVentas.Columns("id_doc").Width = 60
        Me.GridVentas.Columns("id_doc").IsVisible = True
        Me.GridVentas.Columns("id_doc").ReadOnly = True
        Me.GridVentas.Columns("id_doc").HeaderText = "Nro Ticket"

        Me.GridVentas.Columns("fecha_emision").Width = 80
        Me.GridVentas.Columns("fecha_emision").IsVisible = True
        Me.GridVentas.Columns("fecha_emision").ReadOnly = True
        Me.GridVentas.Columns("fecha_emision").FormatString = "{0:dd-MM-yyyy}"
        Me.GridVentas.Columns("fecha_emision").HeaderText = "Fecha"

        Me.GridVentas.Columns("total").Width = 70
        Me.GridVentas.Columns("total").IsVisible = True
        Me.GridVentas.Columns("total").ReadOnly = True
        Me.GridVentas.Columns("total").HeaderText = "Total"

        Me.GridVentas.Columns("NroBoleta").Width = 70
        Me.GridVentas.Columns("NroBoleta").IsVisible = True
        Me.GridVentas.Columns("NroBoleta").ReadOnly = True
        Me.GridVentas.Columns("NroBoleta").HeaderText = "Nro Boleta"

        Me.GridVentas.Columns("usuario").Width = 100
        Me.GridVentas.Columns("usuario").IsVisible = True
        Me.GridVentas.Columns("usuario").ReadOnly = True
        Me.GridVentas.Columns("usuario").HeaderText = "Usuario"
    End Sub

    Private Sub btnImprime_Click(sender As Object, e As EventArgs) Handles btnImprime.Click
        Dim Neg As New Venta
        Dim resp As String = ""
        resp = Neg.LogImpresion(Me.NroTicket, Me.NroBoleta, 1)

        Dim frmT As New Rpt_ticket
        frmT.idventa = NroTicket
        frmT.Formulario = "ImprimeTicket"
        frmT.IdUsuario = usuario
        frmT.Show()
        frmT.Close()
    End Sub
    Private Sub btnBoleta_Click(sender As Object, e As EventArgs) Handles btnBoleta.Click
        Dim Neg As New Venta
        Dim resp As String = ""
        resp = Neg.LogImpresion(Me.NroTicket, Me.NroBoleta, 2)
        Dim frmT As New Rpt_ticket
        frmT.idventa = NroBoleta
        frmT.Formulario = "ImprimeBoleta"
        frmT.IdUsuario = usuario
        frmT.Show()
        frmT.Close()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Neg As New Venta
        Dim resp As String = ""
        resp = Neg.EliminaTicket(Me.NroTicket)
        If resp = "OK" Then
            Telerik.WinControls.RadMessageBox.Show("Elimina registro correctamente", "Elimina")
            iniciar()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        iniciar()
    End Sub

    Private Sub iniciar()
        Me.uic_FechaIni.Value = Now
        Me.uic_FechaFin.Value = Now
        Dim neg As New Venta
        Dim fechaini As String = Format(Me.uic_FechaIni.Value, "yyyy-MM-dd")
        Dim fechafin As String = Format(Me.uic_FechaIni.Value, "yyyy-MM-dd")
        Dim dt As New DataTable
        dt = neg.BuscarVentas(fechaini, fechafin)
        If dt.Rows.Count > 0 Then
            Me.GridVentas.DataSource = dt
            ConfiguraGrilla()
        Else
            Me.GridVentas.DataSource = Nothing
        End If
    End Sub

    Private Sub GridVentas_Click(sender As Object, e As EventArgs) Handles GridVentas.Click
        Try
            If Me.GridVentas.Rows.Count > 0 Then
                Linea = Me.GridVentas.Rows.IndexOf(Me.GridVentas.CurrentRow)
                Me.NroTicket = Me.GridVentas.Rows(Linea).Cells(0).Value
                Me.NroBoleta = Me.GridVentas.Rows(Linea).Cells(3).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Hide()
    End Sub
End Class