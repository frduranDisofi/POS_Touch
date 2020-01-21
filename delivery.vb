Imports ProyectoNegocio
Imports ProyectoService
Imports System.Data.SqlClient

Public Class delivery

    Public es_supervisor As Boolean = False
    Public oconfig As New BE.Parametros
    Private _IdUsuario As Integer
    Private _PerfilUsuario As Integer

    Public Property PerfilUsuario As String
        Get
            Return _PerfilUsuario
        End Get
        Set(ByVal value As String)
            _PerfilUsuario = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If PerfilUsuario = 2 Or PerfilUsuario = 1 Then
            Me.Hide()
            Dim frmVenta As New Form1
            frmVenta.Usuario = IdUsuario
            frmVenta.ShowDialog()
            frmVenta.Close()
            Me.Show()
        Else
            MsgBox("Opción disponible solamente para el Vendedor y Administrador", MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoginForm1.ShowDialog()
        Catch ex As Exception
        End Try
        Dim Neg As New Reporte
        Dim dt As New DataTable
        dt = Neg.Rpt_StockCritico()
        If (dt.Rows.Count > 0) Then
            Telerik.WinControls.RadMessageBox.Show("Tiene productos con stock critico", "Stock")
        End If
        'Me.uic_versionApp.Text = "APP: " & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Major & "." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Minor & "." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Build
        Dim resp As String = ""
        resp = oconfig.get_parametros()
        Dim licencia As New dac.Licencia
        If licencia.licencia_valida(oconfig.RUTEmpresa, oconfig.Giro, oconfig.Licencia) = False Then
            MsgBox("Licencia no valida", vbCritical, "Aviso")
            End
        End If
        Me.Text = "  Empresa  " & Me.oconfig.Giro & "   RUT " & Me.oconfig.RUTEmpresa
        Me.WindowState = FormWindowState.Maximized

    End Sub



    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim Neg As New ProyectoNegocio.AdminCaja
        Dim vresp As String = Neg.ValidaCaja(IdUsuario)
        If vresp = "OK" Then
            Telerik.WinControls.RadMessageBox.Show(Me, "Debe Cerrar Caja", "Alerta")
        Else
            Me.Hide()
            Dim frm As New LoginForm1
            frm.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If es_supervisor Then
            usuario.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub XxToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles XxToolStripMenuItem.Click
        If es_supervisor Then
            formapago.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub DIARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIARIOToolStripMenuItem.Click
        If es_supervisor Then
            'diario.ShowDialog()
            Dim frm As New Info_Ventas
            frm.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim frmCaja As New FrmCaja
        frmCaja.IdUsuario = IdUsuario
        frmCaja.ShowDialog()
        frmCaja.Hide()
    End Sub

    Private Sub COMPRASDIARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPRASDIARIOToolStripMenuItem.Click
        If es_supervisor Then
            Compras_diario.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub FamiliaProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliaProductosToolStripMenuItem.Click
        If es_supervisor Then
            FamiliaProducto.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub PromocionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesToolStripMenuItem.Click
        If es_supervisor Then
            Promocion.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub RetiroCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetiroCajaToolStripMenuItem.Click
        If es_supervisor Then
            Retiro.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub InformacionTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionTicketToolStripMenuItem.Click
        If es_supervisor Then
            DatosGral.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub ImpresorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresorasToolStripMenuItem.Click
        If es_supervisor Then
            Dim frm As New ImpresionCopia
            frm.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        If es_supervisor Then
            Productos.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        If es_supervisor Then
            Dim frm As New compras
            frm.IdUsuario = IdUsuario
            frm.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub StockCriticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockCriticoToolStripMenuItem.Click
        If es_supervisor Then
            Dim frm As New StockCritico
            frm.Show()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
        
    End Sub

    Private Sub ListadoVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoVentasToolStripMenuItem.Click
        If es_supervisor Then
            Dim frm As New Anula_Imprime
            frm.Perfil = PerfilUsuario
            frm.usuario = IdUsuario
            frm.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldoToolStripMenuItem.Click
        If es_supervisor Then
            Dim neg As New Mantenimiento
            Dim resp As String = ""
            Dim ruta As String = "C:\POS\RespaldoBD_POS"
            If Not System.IO.Directory.Exists(ruta) Then
                System.IO.Directory.CreateDirectory(ruta)
            End If
            resp = neg.RespaldoBase

            If resp.Contains("OK") Then
                Telerik.WinControls.RadMessageBox.Show(resp.Substring(3, 21), "Respaldo base datos")
            Else
                Telerik.WinControls.RadMessageBox.Show("A ocurrido un error" & vbCrLf & resp, "Respaldo base datos")
            End If
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub INFORMEPRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INFORMEPRODUCTOSToolStripMenuItem.Click
        If es_supervisor Then
            Dim frm As New InfoProductos
            frm.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub InformeFormaDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeFormaDePagoToolStripMenuItem.Click
        If es_supervisor Then
            Dim frm As New InfoFpagos
            frm.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub CierreCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreCajaToolStripMenuItem.Click
        Dim frm As New Rpt_ReporteZ
        frm.Fecha = Format(Now, "yyyy-dd-MM")
        frm.IdUsuario = IdUsuario
        frm.ShowDialog()
    End Sub

    Private Sub FolioInternoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolioInternoToolStripMenuItem.Click
        Dim frm As New ResetearFolioInterno
        frm.ShowDialog()
    End Sub

    Private Sub InformeXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeXToolStripMenuItem.Click
        If PerfilUsuario = 2 Or PerfilUsuario = 1 Then
            Dim frm As New ReporteCierreCaja
            frm.ShowDialog()
        Else
            MsgBox("Opción disponible solamente para el supervisor y vendedor", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
End Class