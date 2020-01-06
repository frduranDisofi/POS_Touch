Imports ProyectoNegocio
Public Class Rpt_ReporteZ
    Private _fecha As String
    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property
    Private _idusuario As String
    Public Property IdUsuario() As String
        Get
            Return _idusuario
        End Get
        Set(ByVal value As String)
            _idusuario = value
        End Set
    End Property

    Private Sub Rpt_ReporteZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Private Sub Cargar()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim rpt As New Rpt_Z
            Dim data As New dts_Caja
            Dim Neg As New Reporte
            Dim dt As New DataTable
            dt = Neg.Rpt_Z(IdUsuario, Fecha)
            If dt.Rows.Count > 0 Then
                For Each Item As DataRow In dt.Rows
                    data.Rpt_Z.Rows.Add(Item(0), Item(1), Item(2), Item(3), Item(4), Item(5), Item(6), Item(7), Item(8))
                Next
            End If
            rpt.SetDataSource(data)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs) Handles RadMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub RadMenuItem2_Click(sender As Object, e As EventArgs) Handles RadMenuItem2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class