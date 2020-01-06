Imports ProyectoService
Public Class Ofertas
    Public Function BuscarOfertaCompleta(IdOferta As Integer) As DataTable
        Dim dt As New DataTable
        Dim bsp As New OfertaService
        dt = bsp.BuscarOfertaCompleta(IdOferta)
        Return dt
    End Function

    Public Function GrabaOFerta(ByVal Promocion As String, ByVal precio As Integer) As String
        Dim resp As String = ""
        Dim b As New OfertaService
        resp = b.GrabaOferta(Promocion, precio)
        Return resp
    End Function
    Public Function GrabaDetalleOferta(Idoferta As Integer, Linea As Integer, IdProducto As Integer, Cantidad As Integer, Precio As Integer) As String
        Dim resp As String = ""
        Dim bsp As New OfertaService
        resp = bsp.GrabaDetalleOferta(Idoferta, Linea, IdProducto, Cantidad, Precio)
        Return resp
    End Function

    Public Function ActualizaOferta(IdOFerta As Integer, NombreOferta As String, PrecioOferta As Integer, Activo As Integer) As String
        Dim resp As String = ""
        Dim bsp As New OfertaService
        resp = bsp.ActualizaOferta(IdOFerta, NombreOferta, PrecioOferta, Activo)
        Return resp
    End Function

    Public Function BorrarDetalleOferta(IdOferta As Integer) As String
        Dim resp As String = ""
        Dim bsp As New OfertaService
        resp = bsp.BorrarDetalleOferta(IdOferta)
        Return resp
    End Function
    Public Function EliminaOferta(IdOferta As Integer) As String
        Dim resp As String = ""
        Dim bsp As New OfertaService
        resp = bsp.EliminaOferta(IdOferta)
        Return resp
    End Function
End Class
