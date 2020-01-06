Public Class RetiroCajaService
    Public Function ValidaMonto(ByVal Usuario As Integer, ByVal Monto As Integer)
        Dim con As New Conexion
        Dim dt As String = ""

        If con.Conexion Then
            Try
                Dim sql As New dac.myMSSQL(con.con.ConnectionString, 60000)
                sql.paramQUERY.Add("IdUsuario", Usuario)
                sql.paramQUERY.Add("Monto", Monto)
                dt = sql.GetValorNoNull("ValidaMonto")
            Catch ex As Exception

            End Try
        End If
        Return dt
    End Function

    Public Function GuardaRetiro(ByVal Usuario As Integer, ByVal Monto As Integer, ByVal Glosa As String)
        Dim con As New Conexion
        Dim dt As String = ""

        If con.Conexion Then
            Try
                Dim sql As New dac.myMSSQL(con.con.ConnectionString, 60000)
                sql.paramQUERY.Add("IdUsuario", Usuario)
                sql.paramQUERY.Add("Monto", Monto)
                sql.paramQUERY.Add("Glosa", Glosa)
                dt = sql.GetValorNoNull("GuardarRetiro")
            Catch ex As Exception

            End Try
        End If
        Return dt
    End Function
End Class
