Imports ProyectoNegocio
Imports CrystalDecisions.Shared

Public Class Rpt_ticket
    Private _idventa As Integer
    Private _Formulario As String
    Public Property idventa As Integer
        Get
            Return _idventa
        End Get
        Set(value As Integer)
            _idventa = value
        End Set
    End Property
    Public Property Formulario As String
        Get
            Return _Formulario
        End Get
        Set(value As String)
            _Formulario = value
        End Set
    End Property
    Private _idusuario As Integer
    Public Property IdUsuario() As Integer
        Get
            Return _idusuario
        End Get
        Set(ByVal value As Integer)
            _idusuario = value
        End Set
    End Property
    Private _Observacion As String
    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property


    Private Sub Rpt_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        If Formulario = "FrmCaja" Or Formulario = "FrmVenta" Then
            TicketFamilia()
        End If
    End Sub
    Private Sub Cargar()
        Me.Cursor = Cursors.WaitCursor
        Dim Tipo As String = ""
       

        If Formulario = "FrmCaja" Or Formulario = "ImprimeBoleta" Then
            Tipo = Formulario
            Try
                Dim rpt As New RptBoleta
                Dim Param As New ParameterValues
                Dim myDiscreteValue As New ParameterDiscreteValue
                Dim data As New dts_Caja
                Dim Neg As New Reporte
                Dim dt As New DataSet
                Dim impresoraBoleta As String = Neg.GetImpresoraBoleta

                dt = Neg.Rpt_Boleta(idventa, Tipo, IdUsuario)
                If (dt.Tables(0).Rows.Count > 0) Then
                    For Each item As DataRow In dt.Tables(0).Rows
                        Try
                            data.Rpt_Boleta.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5), item(6), item(7), item(8), item(9), item(10))
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCr & ex.StackTrace)
                        End Try
                    Next
                    For Each dato As DataRow In dt.Tables(1).Rows
                        data.parametros.Rows.Add(dato(0), dato(1), dato(2), dato(3), dato(4), dato(5))
                    Next
                    Try
                        rpt.SetDataSource(data)
                        Param.Clear()
                        myDiscreteValue.Value = " "
                        Param.Add(myDiscreteValue)
                        rpt.DataDefinition.ParameterFields("Observacion").ApplyCurrentValues(Param)
                        rpt.PrintOptions.PrinterName = impresoraBoleta
                        rpt.PrintToPrinter(1, False, 0, 0)
                    Catch ex As Exception
                    End Try

                Else
                    Telerik.WinControls.RadMessageBox.Show(Me, "No se encontraron datos", "Alerta")
                    Me.Close()
                End If
            Catch ex As Exception
            End Try
        End If
        If Formulario = "FrmVenta" Then
            Tipo = Formulario
            Try
                Dim rpt As New RptBoleta
                Dim Param As New ParameterValues
                Dim myDiscreteValue As New ParameterDiscreteValue
                Dim data As New dts_Caja
                Dim Neg As New Reporte
                Dim dt As New DataSet
                Dim impresoraBoleta As String = Neg.GetImpresoraBoleta

                dt = Neg.Rpt_Boleta(idventa, Tipo, IdUsuario)
                If (dt.Tables(0).Rows.Count > 0) Then
                    For Each item As DataRow In dt.Tables(0).Rows
                        Try
                            data.Rpt_Boleta.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5), item(6), item(7), item(8), item(9), item(10))
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCr & ex.StackTrace)
                        End Try
                    Next
                    For Each dato As DataRow In dt.Tables(1).Rows
                        data.parametros.Rows.Add(dato(0), dato(1), dato(2), dato(3), dato(4), dato(5))
                    Next
                    Try
                        rpt.SetDataSource(data)
                        Param.Clear()
                        myDiscreteValue.Value = Observacion
                        Param.Add(myDiscreteValue)
                        rpt.DataDefinition.ParameterFields("Observacion").ApplyCurrentValues(Param)
                        rpt.PrintOptions.PrinterName = impresoraBoleta
                        rpt.PrintToPrinter(1, False, 0, 0)
                    Catch ex As Exception
                    End Try

                Else
                    Telerik.WinControls.RadMessageBox.Show(Me, "No se encontraron datos", "Alerta")
                    Me.Close()
                End If
            Catch ex As Exception
            End Try
        End If
        If Formulario = "ImprimeTicket" Then
            Try
                Dim rpt As New RptTicket
                Dim data As New deliveryDataSet1
                Dim Neg As New Reporte
                Dim dt As New DataSet

                Dim impresoraTicket As String = Neg.GetImpresoraTicket
                dt = Neg.Rpt_Ticket(idventa, IdUsuario)
                If (dt.Tables(0).Rows.Count > 0) Then
                    For Each item As DataRow In dt.Tables(0).Rows
                        Try
                            data.Rpt_Ventas.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5), item(6), item(7))
                        Catch ex As Exception
                            MsgBox(ex.Message & vbCr & ex.StackTrace)
                        End Try
                    Next
                    For Each dato As DataRow In dt.Tables(1).Rows
                        data.parametros.Rows.Add(dato(0), dato(1), dato(2), dato(3), dato(4), dato(5))
                    Next
                    Try
                        rpt.SetDataSource(data)
                        rpt.PrintOptions.PrinterName = impresoraTicket
                        rpt.PrintToPrinter(1, False, 0, 0)
                    Catch ex As Exception
                    End Try

                Else
                    Telerik.WinControls.RadMessageBox.Show(Me, "No se encontraron datos", "Alerta")
                    Me.Close()
                End If
            Catch ex As Exception
            End Try
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TicketFamilia()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim rpt As New RptTicketFamilia
            Dim Param As New ParameterValues
            Dim myDiscreteValue As New ParameterDiscreteValue
            Dim data As New dts_Caja
            Dim Neg As New Reporte
            Dim dt As New DataSet
            Dim paso As Integer = 0
            Dim impresora1 As String = ""
            Dim impresora2 As String = ""
            dt = Neg.Rpt_TicketFamilia(idventa, IdUsuario)
            If (dt.Tables.Count > 0) Then
                impresora1 = dt.Tables(0).Rows(0)("impresora")
                For Each item As DataRow In dt.Tables(0).Rows
                    If paso = 0 Then
                        If impresora1 = item("Impresora") Then
                            data.RptTicketFamilia.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5))
                        End If
                        paso = 1

                    Else
                        impresora2 = item("Impresora")
                        If impresora1 = impresora2 Then
                            data.RptTicketFamilia.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5))
                        Else
                            Try
                                For Each dato As DataRow In dt.Tables(1).Rows
                                    data.parametros.Rows.Add(dato(0), dato(1), dato(2), dato(3), dato(4), dato(5))
                                Next
                                rpt.SetDataSource(data)
                                Param.Clear()
                                myDiscreteValue.Value = Observacion
                                Param.Add(myDiscreteValue)
                                rpt.DataDefinition.ParameterFields("Observacion").ApplyCurrentValues(Param)
                                rpt.PrintOptions.PrinterName = impresora1
                                rpt.PrintToPrinter(1, False, 0, 0)
                            Catch ex As Exception
                            End Try

                            data.Clear()

                            data.RptTicketFamilia.Rows.Add(item(0), item(1), item(2), item(3), item(4), item(5))
                            impresora1 = item("Impresora")
                        End If
                    End If

                Next
                Try
                    For Each dato As DataRow In dt.Tables(1).Rows
                        data.parametros.Rows.Add(dato(0), dato(1), dato(2), dato(3), dato(4), dato(5))
                    Next

                    rpt.SetDataSource(data)

                    Param.Clear()
                    myDiscreteValue.Value = Observacion
                    Param.Add(myDiscreteValue)
                    rpt.DataDefinition.ParameterFields("Observacion").ApplyCurrentValues(Param)

                    rpt.PrintOptions.PrinterName = impresora1
                    rpt.PrintToPrinter(1, False, 0, 0)
                Catch ex As Exception
                End Try


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