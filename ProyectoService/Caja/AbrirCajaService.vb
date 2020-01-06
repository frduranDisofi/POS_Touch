Public Class AbrirCajaService

    Public Function AbrirCaja(ByVal IdUsuario As Integer, ByVal Monto As Integer, ByVal Glosa As String) As String
        Dim con As New Conexion
        Dim dt As String = ""
        If con.Conexion Then
            Try
                Dim sql As New dac.myMSSQL(con.con.ConnectionString, 60000)
                Sql.paramQUERY.Add("IdUsuario", IdUsuario)
                Sql.paramQUERY.Add("Monto", Monto)
                Sql.paramQUERY.Add("Glosa", Glosa)
                dt = Sql.GetValorNoNull("Set_AbrirCaja")
            Catch ex As Exception
                con.Desconectar()
            End Try
        End If
        Return dt
    End Function

    Public Function ValidaCaja(ByVal IdUsuario As Integer) As String
        Dim con As New Conexion
        Dim dt As String = ""


        If con.Conexion Then
            Try
                Dim sql As New dac.myMSSQL(con.con.ConnectionString, 60000)
                sql.paramQUERY.Add("IdUsuario", IdUsuario)
                dt = sql.GetValorNoNull("ValidaCaja")
            Catch ex As Exception

            End Try
        End If
        Return dt
    End Function

    Public Function CerrarCaja(ByVal IdUsuario As Integer, ByVal Glosa As String) As String
        Dim con As New Conexion
        Dim dt As String = ""

        If con.Conexion Then
            Try
                Dim sql As New dac.myMSSQL(con.con.ConnectionString, 60000)
                sql.paramQUERY.Add("Glosa", Glosa)
                sql.paramQUERY.Add("IdUsuario", IdUsuario)
                dt = sql.GetValorNoNull("CerrarCaja")
            Catch ex As Exception

            End Try
        End If
        Return dt
    End Function
End Class
