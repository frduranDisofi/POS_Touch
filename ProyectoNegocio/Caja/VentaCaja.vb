Imports ProyectoService
Imports proyectoDTO

Public Class VentaCaja

    Public Function GetVentaTicket(ByVal IdTicket As Integer) As DataTable
        Dim dt As New DataTable
        Dim b As New VentaCajaService
        dt = b.GetVentaTicket(IdTicket)
        Return dt
    End Function

    Public Function GrabaBoleta(ByVal nroticket As Integer, ByVal idUsuario As Integer) As String
        Dim resp As String
        Dim b As New VentaCajaService
        resp = b.GrabaBoleta(nroticket, idUsuario)
        Return resp
    End Function

    Public Function ValidaTicket(ByVal nroticket As Integer) As String
        Dim resp As String
        Dim b As New VentaCajaService
        resp = b.ValidaTicket(nroticket)
        Return resp
    End Function

End Class
