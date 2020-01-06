Imports proyectoDTO

Public Class VentaCajaService

    Public Function GetVentaTicket(ByVal IdTicket As Integer) As DataTable
        Dim con As New Conexion
        Dim dt As New DataTable
        If con.Conexion Then
            Try
                Dim odac As New dac.myhelper3
                odac.paramQUERY.Add("IdTicket", IdTicket)
                dt = odac.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "GetVentaTicket", odac.paramQUERY, 90000)
            Catch ex As Exception
                dt = New DataTable
                con.Desconectar()
            End Try
            Try
                con.Desconectar()
            Catch ex As Exception
            End Try
        End If
        Return dt
    End Function

    Public Function GrabaBoleta(ByVal nroticket As Integer, ByVal idUsuario As Integer) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("NroTicket", nroticket)
            odac.paramQUERY.Add("IdUsuario", idUsuario)

            resp = odac.GetValorNoNull("GrabaBoleta")
        End If
        Return resp
    End Function

    Public Function ValidaTicket(ByVal nroticket As Integer) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("NroTicket", nroticket)
            resp = odac.GetValorNoNull("ValidaTicket")
        End If
        Return resp
    End Function

End Class
