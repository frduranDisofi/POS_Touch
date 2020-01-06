Imports ProyectoService
Public Class Reporte
    Public Function Rpt_StockCritico() As DataTable
        Dim dt As New DataTable
        Dim b As New ReporteService
        dt = b.Rpt_StockCritico
        Return dt
    End Function
    Public Function ReporteProducto() As DataTable
        Dim dt As New DataTable
        Dim b As New ReporteService
        dt = b.ReporteProducto
        Return dt
    End Function

    Public Function RptVentasDiarias(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        Dim dt As New DataTable
        Dim b As New ReporteService
        dt = b.RptVentasDiarias(FechaIni, FechaFin)
        Return dt
    End Function
    Public Function Rpt_Ticket(idventa As Integer, ByVal IdUsuario As Integer) As DataSet
        Dim dt As New DataSet
        Dim b As New ReporteService
        dt = b.Rpt_Ticket(idventa, IdUsuario)
        Return dt
    End Function
    Public Function Rpt_Boleta(idventa As Integer, ByVal Tipo As String, ByVal IdUsuario As Integer) As DataSet
        Dim dt As New DataSet
        Dim b As New ReporteService
        dt = b.Rpt_Boleta(idventa, Tipo, IdUsuario)
        Return dt
    End Function
    Public Function Rpt_CierreCaja(ByVal IdUsuario As Integer, ByVal IdCaja As Integer) As DataSet
        Dim dt As New DataSet
        Dim b As New ReporteService
        dt = b.Rpt_CierreCaja(IdUsuario, IdCaja)
        Return dt
    End Function
    Public Function Rpt_CierreCajaX(ByVal IdUsuario As Integer, ByVal IdCaja As Integer) As DataTable
        Dim dt As New DataTable
        Dim b As New ReporteService
        dt = b.Rpt_CierreCajaX(IdUsuario, IdCaja)
        Return dt
    End Function
    Public Function Rpt_Z(ByVal IdUsuario As Integer, ByVal FEcha As String) As DataTable
        Dim dt As New DataTable
        Dim b As New ReporteService
        dt = b.Rpt_Z(IdUsuario, FEcha)
        Return dt
    End Function
    Public Function Rpt_CierreCajaRevision(ByVal IdUsuario As Integer, ByVal IdCaja As Integer, ByVal fecha As String) As DataSet
        Dim dt As New DataSet
        Dim b As New ReporteService
        dt = b.Rpt_CierreCajaRevision(IdUsuario, IdCaja, fecha)
        Return dt
    End Function
    Public Function GetImpresoraTicket() As String
        Dim dt As String = ""
        Dim b As New ReporteService
        dt = b.GetImpresoraTicket
        Return dt
    End Function
    Public Function GetImpresoraBoleta() As String
        Dim dt As String = ""
        Dim b As New ReporteService
        dt = b.GetImpresoraBoleta
        Return dt
    End Function
    Public Function Rpt_TicketFamilia(ByVal idventa As Integer, ByVal idusuario As Integer) As DataSet
        Dim dt As New DataSet
        Dim b As New ReporteService
        dt = b.Rpt_TicketFamilia(idventa, idusuario)
        Return dt
    End Function
    Public Function RPT_Productos_Revision(ByVal FechaIni As String, ByVal FechaFin As String, ByVal usuario As String, ByVal Familia As Integer, ByVal Producto As Integer) As DataTable
        Dim dt As New DataTable
        Dim b As New ReporteService
        dt = b.RPT_Productos_Revision(FechaIni, FechaFin, usuario, Familia, Producto)
        Return dt
    End Function
    Public Function RPT_Ventas_X_Usuario(ByVal FechaIni As String, ByVal FechaFin As String, ByVal usuario As String) As DataTable
        Dim dt As New DataTable
        Dim b As New ReporteService
        dt = b.RPT_Ventas_X_Usuario(FechaIni, FechaFin, usuario)
        Return dt
    End Function
    Public Function RPT_FormaPago(ByVal FechaIni As String, ByVal FechaFin As String, ByVal Tipo As Integer) As DataTable
        Dim dt As New DataTable
        Dim b As New ReporteService
        dt = b.RPT_FormaPago(FechaIni, FechaFin, Tipo)
        Return dt
    End Function
End Class
