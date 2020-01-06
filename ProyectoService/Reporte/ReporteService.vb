Public Class ReporteService

    Public Function Rpt_StockCritico() As DataTable
        Dim dt As New DataTable
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "Rpt_StockCritico", sql.paramQUERY, 60000)
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
    Public Function ReporteProducto() As DataTable
        Dim dt As New DataTable
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "RPT_Productos", sql.paramQUERY, 60000)
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

    Public Function RptVentasDiarias(ByVal FechaIni As String, ByVal FechaFin As String) As DataTable
        Dim dt As New DataTable
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("Fecha_Ini", FechaIni)
                sql.paramQUERY.Add("Fecha_Fin", FechaFin)
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "Get_VentasDiarias", sql.paramQUERY, 60000)
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

    Public Function Rpt_Ticket(idventa As Integer, ByVal IdUsuario As Integer) As DataSet
        Dim dt As New DataSet
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("idventa", idventa)
                sql.paramQUERY.Add("IdUsuario", IdUsuario)
                dt = sql.ExecuteDataSet(con.con.ConnectionString, CommandType.StoredProcedure, "Rpt_VentasTicket", sql.paramQUERY, 60000)
            Catch ex As Exception
                dt = New DataSet
                con.Desconectar()
            End Try
            Try
                con.Desconectar()
            Catch ex As Exception
            End Try
        End If
        Return dt
    End Function
    Public Function Rpt_Boleta(idventa As Integer, ByVal Tipo As String, ByVal IdUsuario As Integer) As DataSet
        Dim dt As New DataSet
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("idventa", idventa)
                sql.paramQUERY.Add("Tipo", Tipo)
                sql.paramQUERY.Add("IdUsuario", IdUsuario)
                dt = sql.ExecuteDataSet(con.con.ConnectionString, CommandType.StoredProcedure, "Rpt_Boleta", sql.paramQUERY, 60000)
            Catch ex As Exception
                dt = New DataSet
                con.Desconectar()
            End Try
            Try
                con.Desconectar()
            Catch ex As Exception
            End Try
        End If
        Return dt
    End Function
    Public Function Rpt_CierreCaja(ByVal IdUsuario As Integer, ByVal IdCaja As Integer) As DataSet
        Dim dt As New DataSet
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("IdUsuario", IdUsuario)
                sql.paramQUERY.Add("IdCaja", IdCaja)
                dt = sql.ExecuteDataSet(con.con.ConnectionString, CommandType.StoredProcedure, "RptCerrarCaja", sql.paramQUERY, 60000)
            Catch ex As Exception
                dt = New DataSet
                con.Desconectar()
            End Try
            Try
                con.Desconectar()
            Catch ex As Exception
            End Try
        End If
        Return dt
    End Function
    Public Function Rpt_CierreCajaX(ByVal IdUsuario As Integer, ByVal IdCaja As Integer) As DataTable
        Dim dt As New DataTable
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("IdUsuario", IdUsuario)
                sql.paramQUERY.Add("IdCaja", IdCaja)
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "rpt_InformeX", sql.paramQUERY, 60000)
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
    Public Function Rpt_Z(ByVal IdUsuario As Integer, ByVal FEcha As String) As DataTable
        Dim dt As New DataTable
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("IdUsuario", IdUsuario)
                sql.paramQUERY.Add("Fecha", FEcha)
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "rpt_Z", sql.paramQUERY, 60000)
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
    Public Function Rpt_CierreCajaRevision(ByVal IdUsuario As Integer, ByVal IdCaja As Integer, ByVal fecha As String) As DataSet
        Dim dt As New DataSet
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("fecha", fecha)
                sql.paramQUERY.Add("IdUsuario", IdUsuario)
                sql.paramQUERY.Add("IdCaja", IdCaja)
                dt = sql.ExecuteDataSet(con.con.ConnectionString, CommandType.StoredProcedure, "RPT_Cierre", sql.paramQUERY, 60000)
            Catch ex As Exception
                dt = New DataSet
                con.Desconectar()
            End Try
            Try
                con.Desconectar()
            Catch ex As Exception
            End Try
        End If
        Return dt
    End Function
    Public Function GetImpresoraTicket() As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 18000)
            resp = odac.GetValorNoNull("GetImpresora")
        End If
        Return resp
    End Function
    Public Function GetImpresoraBoleta() As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 18000)
            resp = odac.GetValorNoNull("GetImpresoraBoleta")
        End If
        Return resp
    End Function
    Public Function Rpt_TicketFamilia(ByVal idventa As Integer, ByVal idusuario As Integer) As DataSet
        Dim dt As New DataSet
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("idventa", idventa)
                sql.paramQUERY.Add("IdUsuario", idusuario)
                dt = sql.ExecuteDataSet(con.con.ConnectionString, CommandType.StoredProcedure, "Rpt_TicketFamilia", sql.paramQUERY, 60000)
            Catch ex As Exception
                dt = New DataSet
                con.Desconectar()
            End Try
            Try
                con.Desconectar()
            Catch ex As Exception
            End Try
        End If
        Return dt
    End Function
    Public Function RPT_Productos_Revision(ByVal FechaIni As String, ByVal FechaFin As String, ByVal usuario As String, ByVal Familia As Integer, ByVal Producto As Integer) As DataTable
        Dim dt As New DataTable
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("FechaIni", FechaIni)
                sql.paramQUERY.Add("FechaFin", FechaFin)
                sql.paramQUERY.Add("Usuario", usuario)
                sql.paramQUERY.Add("Familia", Familia)
                sql.paramQUERY.Add("Producto", Producto)
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "RPT_Productos_Revision", sql.paramQUERY, 60000)
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
    Public Function RPT_Ventas_X_Usuario(ByVal FechaIni As String, ByVal FechaFin As String, ByVal usuario As String) As DataTable
        Dim dt As New DataTable
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("FechaIni", FechaIni)
                sql.paramQUERY.Add("FechaFin", FechaFin)
                sql.paramQUERY.Add("Usuario", usuario)
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "Get_VentasDiarias_X_Ususario", sql.paramQUERY, 60000)
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
    Public Function RPT_FormaPago(ByVal FechaIni As String, ByVal FechaFin As String, ByVal Tipo As Integer) As DataTable
        Dim dt As New DataTable
        Dim con As New Conexion
        Dim sql As New dac.myhelper3
        If con.Conexion Then
            Try
                sql.paramQUERY.Add("FechaIni", FechaIni)
                sql.paramQUERY.Add("FechaFin", FechaFin)
                sql.paramQUERY.Add("Tipo", Tipo)
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "RPT_FormaPago", sql.paramQUERY, 60000)
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
End Class
