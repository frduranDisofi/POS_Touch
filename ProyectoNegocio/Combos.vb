Imports ProyectoService
Public Class Combos
    Public Function GetOfertas() As DataTable
        Dim dt As New DataTable
        Dim bsp As New CombosServices
        dt = bsp.GetOfertas()
        Return dt
    End Function
    Public Function getFamilia() As DataTable
        Dim dt As New DataTable
        Dim bsp As New CombosServices
        dt = bsp.getFamilia()
        Return dt
    End Function
    Public Function getProductos() As DataTable
        Dim dt As New DataTable
        Dim bsp As New CombosServices
        dt = bsp.getProductos()
        Return dt
    End Function
    Public Function GetUsuario() As DataTable
        Dim dt As New DataTable
        Dim bsp As New CombosServices
        dt = bsp.GetUsuario()
        Return dt
    End Function
End Class
