Imports ProyectoService

Public Class RetiroCaja
    Public Function ValidaMontoRetiro(ByVal Usuario As Integer, ByVal Monto As Integer) As String
        Dim resp As String = ""
        Dim bsp As New RetiroCajaService
        resp = bsp.ValidaMonto(Usuario, Monto)
        Return resp
    End Function

    Public Function GuardarRetiro(ByVal Usuario As Integer, ByVal Monto As Integer, ByVal Glosa As String) As String
        Dim resp As String = ""
        Dim bsp As New RetiroCajaService
        resp = bsp.GuardaRetiro(Usuario, Monto, Glosa)
        Return resp
    End Function
End Class
