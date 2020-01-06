Imports ProyectoService
Imports proyectoDTO

Public Class Venta
    Public Function GrabarCab(ByVal dto As ticket) As String
        Dim dt As String
        Dim b As New VentaService
        dt = b.GrabarCab(dto)
        Return dt
    End Function

    Public Function DetalleTicket(ByVal dto As ticket) As String
        Dim dt As String
        Dim b As New VentaService
        dt = b.DetalleTicket(dto)
        Return dt
    End Function

    Public Function DetallePromo(ByVal dto As ticket) As String
        Dim dt As String
        Dim b As New VentaService
        dt = b.DetallePromo(dto)
        Return dt
    End Function

    Public Function BuscarVentas(ByVal fechaini As String, ByVal fechafin As String) As DataTable
        Dim dt As New DataTable
        Dim b As New VentaService
        dt = b.BuscarVentas(fechaini, fechafin)
        Return dt
    End Function

    Public Function grillaCierre(ByVal fechaini As String, ByVal fechafin As String) As DataTable
        Dim dt As New DataTable
        Dim b As New VentaService
        dt = b.grillaCierre(fechaini, fechafin)
        Return dt
    End Function

    Public Function LogImpresion(ByVal NroTicket As Integer, ByVal NroBoleta As Integer, ByVal Tipo As Integer) As String
        Dim dt As String = ""
        Dim b As New VentaService
        dt = b.LogImpresion(NroTicket, NroBoleta, Tipo)
        Return dt
    End Function
    Public Function EliminaTicket(ByVal NroTicket As Integer) As String
        Dim dt As String = ""
        Dim b As New VentaService
        dt = b.EliminaTicket(NroTicket)
        Return dt
    End Function

    Public Function ValidaProducto(ByVal dts As ticket) As String
        Dim dt As String = ""
        Dim b As New VentaService
        dt = b.ValidaProducto(dts)
        Return dt
    End Function

End Class
