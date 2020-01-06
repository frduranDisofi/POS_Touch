Imports ProyectoNegocio

Public Class InfoVentasDiarias
    Private _fechaini As String
    Private _fechfain As String
    Public Property FechaIni As String
        Get
            Return _fechaini
        End Get
        Set(value As String)
            _fechaini = value
        End Set
    End Property
    Public Property FechaFin As String
        Get
            Return _fechfain
        End Get
        Set(value As String)
            _fechfain = value
        End Set
    End Property
    Private Sub InfoVentasDiarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Private Sub Cargar()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim rpt As New RPT_VentasDiarias
            Dim data As New dts_mantenedor
            Dim Neg As New Reporte
            Dim dt As New DataTable

            dt = Neg.RptVentasDiarias(FechaIni, FechaFin)
            If (dt.Rows.Count > 0) Then
                For Each item As DataRow In dt.Rows
                    Try
                        data.VentasDiarias.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5))
                    Catch ex As Exception
                        MsgBox(ex.Message & vbCr & ex.StackTrace)
                    End Try
                Next

                rpt.SetDataSource(data)
                CrystalReportViewer1.ReportSource = rpt
            Else
                Telerik.WinControls.RadMessageBox.Show(Me, "No se encontraron datos", "Alerta")
                Me.Close()
            End If
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