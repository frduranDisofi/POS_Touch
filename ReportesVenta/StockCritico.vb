Imports ProyectoNegocio

Public Class StockCritico

    Private Sub StockCritico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Private Sub Cargar()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim rpt As New Rpt_StockCritico
            Dim data As New dts_mantenedor
            Dim Neg As New Reporte
            Dim dt As New DataTable

            dt = Neg.Rpt_StockCritico()
            If (dt.Rows.Count > 0) Then
                For Each Item As DataRow In dt.Rows
                    Try
                        data.StockCritico.Rows.Add(Item(0), Item(1), Item(2))
                    Catch ex As Exception
                    End Try
                Next
                rpt.SetDataSource(data)
                CrystalReportViewer1.ReportSource = rpt

            Else
                ' Telerik.WinControls.RadMessageBox.Show(Me, "No se encontraron datos", "Alerta")
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