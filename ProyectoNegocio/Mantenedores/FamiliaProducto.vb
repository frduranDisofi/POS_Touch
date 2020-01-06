Imports ProyectoService

Public Class FamiliaProducto
    Public Function GetFamiliaProducto() As DataTable
        Dim dt As New DataTable
        Dim b As New FamiliaProductoService
        dt = b.GetFamiliaProducto
        Return dt
    End Function
    Public Function ModificarFamilia(ByVal CodigoFamilia As String, ByVal FamiliaProducto As String, ByVal impresoraFamilia As String) As String
        Dim resp As String = ""
        Dim bsp As New FamiliaProductoService
        resp = bsp.ModificarFamilia(CodigoFamilia, FamiliaProducto, impresoraFamilia)
        Return resp
    End Function

    Public Function GrabarFamilia(ByVal Familia As String, ByVal impresoraFamilia As String) As String
        Dim resp As String = ""
        Dim bsp As New FamiliaProductoService
        resp = bsp.GrabarFamilia(Familia, impresoraFamilia)
        Return resp
    End Function

    Public Function TraerImagenes(ruta As String) As String
        Dim resp As String = ""
        Dim bsp As New FamiliaProductoService
        resp = bsp.TraerImagenes(ruta)
        Return resp
    End Function

    Public Function EliminarFamilia(ByVal CodigoFamilia As String) As String
        Dim resp As String = ""
        Dim b As New FamiliaProductoService
        resp = b.EliminarFamilia(CodigoFamilia)
        Return resp
    End Function
End Class
