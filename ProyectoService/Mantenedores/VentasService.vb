Public Class VentasService
    Public Function ReporteDiario(ByVal fecha_ini As String, ByVal fecha_fin As String) As DataTable
        Dim con As New Conexion
        Dim dt As New DataTable
        If con.Conexion Then
            Try
                Dim sql As New dac.myhelper3
                sql.paramQUERY.Add("fecha_ini", fecha_ini)
                sql.paramQUERY.Add("fecha_fin", fecha_fin)
                dt = sql.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "Get_VentasDiarias", sql.paramQUERY, 60000)
            Catch ex As Exception
                dt = New DataTable
            End Try
        End If
        Return dt
    End Function
End Class
