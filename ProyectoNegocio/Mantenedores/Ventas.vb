Imports ProyectoService

Public Class Ventas
    Public Function ReporteDiario(ByVal fecha_ini As String, ByVal fecha_fin As String) As DataTable
        Dim dt As New DataTable
        Dim b As New VentasService
        dt = b.ReporteDiario(fecha_ini, fecha_fin)
        Return dt
    End Function
End Class
