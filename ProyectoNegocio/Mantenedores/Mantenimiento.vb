Imports ProyectoService

Public Class Mantenimiento
    Public Function RespaldoBase() As String
        Dim resp As String
        Dim b As New ServiceMantenimiento
        resp = b.RespaldoBase
        Return resp
    End Function
    Public Function TreaUltimoFolio() As String
        Dim resp As String
        Dim b As New ServiceMantenimiento
        resp = b.TreaUltimoFolio
        Return resp
    End Function
    Public Function ReseteaFolioInterno() As String
        Dim resp As String
        Dim b As New ServiceMantenimiento
        resp = b.ReseteaFolioInterno
        Return resp
    End Function
End Class
