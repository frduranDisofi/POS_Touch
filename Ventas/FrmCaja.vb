Imports System.Configuration
Imports ProyectoNegocio

Public Class FrmCaja
    Dim TipoPago As String = ""
    Private _IdUsuario As Integer

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As Integer)
            _IdUsuario = value
        End Set
    End Property



    Private Sub FrmCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.F1
                uic_botonF2_Click(Nothing, Nothing)
            Case Keys.F2
                uic_botonF1_Click(Nothing, Nothing)
            Case Keys.F3
                uic_BotonF4_Click(Nothing, Nothing)
            Case Keys.F4
                btn_aceptar_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub FrmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.uic_botonF1.Text = "F2" & vbCrLf & "Tarjeta"
        Me.uic_botonF2.Text = "F1" & vbCrLf & "Efectivo"
        Me.uic_BotonF4.Text = "F3" & vbCrLf & "Adm Caja"
        Me.uic_VersionApp.Text = "APP: " & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Major & "." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Minor & "." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Build
    End Sub

    Private Sub uic_botonF2_Click(sender As Object, e As EventArgs) Handles uic_botonF2.Click
        Dim IdPago As Integer = 1
        TipoPago = "Efectivo"
        txt_efectivo.Enabled = True
        Me.txt_efectivo.Text = ""
        Me.txt_efectivo.Focus()
        Me.txt_vuelto.Text = Val(Me.txt_efectivo.Text) - Val(Me.txt_Total.Text)
    End Sub

    Private Sub txt_efectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_efectivo.KeyPress
        Dim valida As String = "0123456789" & Convert.ToChar(8)
        If (valida.Contains("" + e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            Me.txt_vuelto.Text = Val(Me.txt_efectivo.Text) - Val(Me.txt_Total.Text)
        End If

    End Sub

    Private Sub IdTicket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IdTicket.KeyPress
        Dim valida As String = "0123456789" & Convert.ToChar(8)
        If (valida.Contains("" + e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub uic_botonF1_Click(sender As Object, e As EventArgs) Handles uic_botonF1.Click
        Dim IdPago As Integer = 2
        TipoPago = "Tarjeta"
        Me.txt_efectivo.Enabled = False
        Me.txt_efectivo.Text = Me.txt_Total.Text
        Me.txt_vuelto.Text = "0"
    End Sub

    Private Sub uic_botonF6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub uic_BotonF4_Click(sender As Object, e As EventArgs) Handles uic_BotonF4.Click
        Dim frmAdmCaja As New AdminCaja
        frmAdmCaja.IdUsuario = IdUsuario
        frmAdmCaja.ShowDialog()
    End Sub

    Private Sub uic_ValeBotella_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Me.txt_Total.Text = "" Or Me.txt_Total.Text = "0" Then
            MsgBox("Debe Ingresar Monto Pago", vbCritical)
            Exit Sub
        End If

        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("Debe ingresar detalle", vbCritical)
            Exit Sub
        End If

        If Me.txt_efectivo.Text = "" Or Me.txt_efectivo.Text = "0" Then
            MsgBox("Debe ingresar Monto", vbCritical)
            Exit Sub
        End If


        Dim dts As New proyectoDTO.ticket
        Dim func As New VentaCaja
        Dim nroticket As String = ""
        Dim usuario As Integer
        nroticket = Me.IdTicket.Text
        usuario = IdUsuario

        Me.Cursor = Cursors.WaitCursor
        Dim id_doc_cab As String = ""
        Dim Neg As New ProyectoNegocio.AdminCaja

        Dim vresp As String = Neg.ValidaCaja(usuario)
        If vresp = "OK" Then
            Try
                id_doc_cab = func.GrabaBoleta(nroticket, usuario)
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Telerik.WinControls.RadMessageBox.Show("A ocurrido un error" & vbCrLf & nroticket, "Aviso")
                Exit Sub
            End Try
        Else
            Telerik.WinControls.RadMessageBox.Show(Me, "Tiene que abrir caja Abierta", "Alerta")
            Dim frmApertura As New AperturaCaja
            frmApertura.IdUsuario = usuario
            frmApertura.ShowDialog()
            'limpiar()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim frmT As New Rpt_ticket
        frmT.idventa = nroticket
        frmT.Formulario = "FrmCaja"
        frmT.Show()
        frmT.Close()

        limpiar()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub limpiar()
        Me.txt_efectivo.Text = ""
        Me.txt_Total.Text = ""
        Me.txt_vuelto.Text = ""
        Me.IdTicket.Text = ""
        Me.DataGridView1.Rows.Clear()
        Me.txt_efectivo.Enabled = False
    End Sub


    Private Sub uic_BuscaVta_Click(sender As Object, e As EventArgs) Handles uic_BuscaVta.Click
        Dim dt As New DataTable
        Dim IdTicket As Integer = 0
        Dim precio As Integer = 0
        Dim codigo_item As String = ""
        Dim cantidad As Integer = 0
        Dim articulo As String = ""
        Dim Total As Integer = 0
        Dim neg As New VentaCaja
        Dim resp As String = ""

        IdTicket = IIf(Me.IdTicket.Text = "", 0, Me.IdTicket.Text)

        resp = neg.ValidaTicket(IdTicket)
        If resp <> "OK" Then
            dt = neg.GetVentaTicket(IdTicket)
            If dt.Rows.Count > 0 Then
                Me.DataGridView1.Rows.Clear()
                For Each valor As DataRow In dt.Rows
                    precio = Val(valor("precio"))
                    codigo_item = valor("id_producto")
                    cantidad = valor("cantidad")
                    articulo = valor("descripcion")
                    Total = valor("total")
                    Me.DataGridView1.Rows.Add(codigo_item.Trim, cantidad, articulo.Trim, precio, Total)
                Next
            Else
                Me.DataGridView1.DataSource = Nothing
            End If
            calculo_total_venta()
        Else
            Telerik.WinControls.RadMessageBox.Show(Me, "Ticket ya fue ingresado.", "Alerta")
            limpiar()
            Exit Sub
        End If

    End Sub

    Private Sub txt_efectivo_TextChanged(sender As Object, e As EventArgs) Handles txt_efectivo.TextChanged
        Me.txt_vuelto.Text = Val(Me.txt_efectivo.Text) - Val(Me.txt_Total.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.RowCount > 0 Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "Eliminar" Then
                    DataGridView1.Rows.RemoveAt(e.RowIndex)
                    calculo_total_venta()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub calculo_total_venta()
        Dim total As Integer = 0
        If Me.DataGridView1.Rows.Count > 0 Then
            For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                total += Me.DataGridView1.Rows(i).Cells(4).Value
            Next
        End If
        Me.txt_Total.Text = total
    End Sub


#Region "Botonera"
    Private Sub uic_boton0_Click(sender As Object, e As EventArgs) Handles uic_boton0.Click
        Me.txt_efectivo.Text &= "0"
        Me.txt_efectivo.Focus()
    End Sub
    Private Sub uic_boton1_Click(sender As Object, e As EventArgs) Handles uic_boton1.Click
        Me.txt_efectivo.Text &= "1"
        Me.txt_efectivo.Focus()
    End Sub

    Private Sub uic_boton2_Click(sender As Object, e As EventArgs) Handles uic_boton2.Click
        Me.txt_efectivo.Text &= "2"
        Me.txt_efectivo.Focus()
    End Sub

    Private Sub uic_boton3_Click(sender As Object, e As EventArgs) Handles uic_boton3.Click
        Me.txt_efectivo.Text &= "3"
        Me.txt_efectivo.Focus()
    End Sub

    Private Sub uic_boton4_Click(sender As Object, e As EventArgs) Handles uic_boton4.Click
        Me.txt_efectivo.Text &= "4"
        Me.txt_efectivo.Focus()
    End Sub

    Private Sub uic_boton5_Click(sender As Object, e As EventArgs) Handles uic_boton5.Click
        Me.txt_efectivo.Text &= "5"
        Me.txt_efectivo.Focus()
    End Sub

    Private Sub uic_boton6_Click(sender As Object, e As EventArgs) Handles uic_boton6.Click
        Me.txt_efectivo.Text &= "6"
        Me.txt_efectivo.Focus()
    End Sub

    Private Sub uic_boton7_Click(sender As Object, e As EventArgs) Handles uic_boton7.Click
        Me.txt_efectivo.Text &= "7"
        Me.txt_efectivo.Focus()
    End Sub

    Private Sub uic_boton8_Click(sender As Object, e As EventArgs) Handles uic_boton8.Click
        Me.txt_efectivo.Text &= "8"
        Me.txt_efectivo.Focus()
    End Sub

    Private Sub uic_boton9_Click(sender As Object, e As EventArgs) Handles uic_boton9.Click
        If Me.txt_efectivo.Enabled = True Then
            Me.txt_efectivo.Text &= "9"
            Me.txt_efectivo.Focus()
        Else
            Me.IdTicket.Text &= "9"
            Me.IdTicket.Focus()
        End If

    End Sub

    Private Sub uic_botonBack_Click(sender As Object, e As EventArgs) Handles uic_botonBack.Click
        If Me.txt_efectivo.Text.Length > 0 Then
            Me.txt_efectivo.Text = txt_efectivo.Text.Substring(0, Me.txt_efectivo.Text.Length - 1)
        End If
    End Sub


#End Region
End Class