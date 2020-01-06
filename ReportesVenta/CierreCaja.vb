Imports ProyectoNegocio

Public Class CierreCaja
    Private _idUsuario As Integer
    Private _idcaja As Integer

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property IdCaja As Integer
        Get
            Return _idcaja
        End Get
        Set(value As Integer)
            _idcaja = value
        End Set
    End Property
    Private _fecha As String
    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property
    Private _paso As Integer
    Public Property paso() As Integer
        Get
            Return _paso
        End Get
        Set(ByVal value As Integer)
            _paso = value
        End Set
    End Property


    Private Sub CierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Private Sub Cargar()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim rpt As New Rpt_CierreCajaX
            Dim data As New dts_Caja
            Dim Neg As New Reporte
            'Dim dt As New DataSet
            Dim dt As New DataTable
            If paso = 0 Then
                'dt = Neg.Rpt_CierreCaja(IdUsuario, IdCaja)
                dt = Neg.Rpt_CierreCajaX(IdUsuario, IdCaja)
                If dt.Rows.Count > 0 Then
                    For Each Item As DataRow In dt.Rows
                        data.cajaX.Rows.Add(Item(0), Item(1), Item(2), Item(3), Item(4), Item(5), Item(6), Item(7), Item(8), Item(9))
                    Next
                End If
                rpt.SetDataSource(data)
                CrystalReportViewer1.ReportSource = rpt

                'If (dt.Tables(0).Rows.Count > 0) Then

                '    For Each Item As DataRow In dt.Tables(0).Rows
                '        Try
                '            data.cajaZ.Rows.Add(Item(0), Item(1), Item(2), Item(3), Item(4), Item(5), Item(6), Item(7))
                '        Catch ex As Exception
                '        End Try
                '    Next

                '    If (dt.Tables(1).Rows.Count > 0) Then
                '        For Each item As DataRow In dt.Tables(1).Rows
                '            Try
                '                data.cabecera.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5), item(6))
                '            Catch ex As Exception
                '            End Try
                '        Next

                '    End If

                '    If (dt.Tables(2).Rows.Count > 0) Then
                '        For Each item As DataRow In dt.Tables(2).Rows
                '            Try
                '                data.retirocaja.Rows.Add(item(0), item(1), item(2), item(3), item(4))
                '            Catch ex As Exception
                '            End Try
                '        Next
                '    End If

                '    rpt.SetDataSource(data)
                '    CrystalReportViewer1.ReportSource = rpt

                'Else
                '    Telerik.WinControls.RadMessageBox.Show(Me, "No se encontraron datos", "Alerta")
                '    Me.Close()
                'End If

                'Else

                '    dt = Neg.Rpt_CierreCajaRevision(IdUsuario, IdCaja, Fecha)
                '    If (dt.Tables(0).Rows.Count > 0) Then

                '        For Each Item As DataRow In dt.Tables(0).Rows
                '            Try
                '                data.caja.Rows.Add(Item(0), Item(1), Item(2), Item(3), Item(4), Item(5), Item(6))
                '            Catch ex As Exception
                '            End Try
                '        Next

                '        If (dt.Tables(1).Rows.Count > 0) Then
                '            For Each item As DataRow In dt.Tables(1).Rows
                '                Try
                '                    data.cabecera.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5), item(6))
                '                Catch ex As Exception
                '                End Try
                '            Next

                '        End If

                '        If (dt.Tables(2).Rows.Count > 0) Then
                '            For Each item As DataRow In dt.Tables(2).Rows
                '                Try
                '                    data.retirocaja.Rows.Add(item(0), item(1), item(2), item(3), item(4))
                '                Catch ex As Exception
                '                End Try
                '            Next
                '        End If

                '        rpt.SetDataSource(data)
                '        CrystalReportViewer1.ReportSource = rpt

                '    Else
                '        Telerik.WinControls.RadMessageBox.Show(Me, "No se encontraron datos", "Alerta")
                '        Me.Close()
                '    End If
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