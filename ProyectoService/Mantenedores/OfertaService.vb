Public Class OfertaService
    Public Function BuscarOfertaCompleta(IdOferta As Integer) As DataTable
        Dim con As New Conexion
        Dim dt As New DataTable
        If con.Conexion Then
            Try
                Dim odac As New dac.myhelper3
                odac.paramQUERY.Add("Id", IdOferta)
                dt = odac.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "Oferta_Buscar", odac.paramQUERY, 180000)
            Catch ex As Exception
                dt = New DataTable
            End Try
        End If
        Return dt
    End Function

    Public Function GrabaOFerta(ByVal Promocion As String, ByVal precio As Integer) As Integer
        Dim resp As Integer = 0
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("Nombre", Promocion)
            odac.paramQUERY.Add("Precio", precio)

            resp = odac.GetValorNoNull("Promocion_Grabar")
        End If
        Return resp
    End Function
    Public Function GrabaDetalleOferta(Idoferta As Integer, Linea As Integer, IdProducto As Integer, Cantidad As Integer, Precio As Integer) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("Idoferta", Idoferta)
            odac.paramQUERY.Add("Linea", Linea)
            odac.paramQUERY.Add("IdProducto", IdProducto)
            odac.paramQUERY.Add("Cantidad", Cantidad)
            odac.paramQUERY.Add("Precio", Precio)

            resp = odac.GetValorNoNull("OfertaDetalle_Grabar")
        End If
        Return resp

    End Function

    Public Function ActualizaOferta(Id As Integer, NombreOferta As String, PrecioOferta As Integer, Activo As Integer) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("Id", Id)
            odac.paramQUERY.Add("NombreOferta", NombreOferta)
            odac.paramQUERY.Add("PrecioOferta", PrecioOferta)
            odac.paramQUERY.Add("Activo", Activo)
            resp = odac.GetValorNoNull("Oferta_Actualizar")
        End If
        Return resp
    End Function

    Public Function BorrarDetalleOferta(ByVal Id As Integer) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("Id", Id)
            resp = odac.GetValorNoNull("OfertaDetalle_Borrar")
        End If
        Return resp
    End Function
    Public Function EliminaOferta(IdOferta As Integer) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("IdOferta", IdOferta)
            resp = odac.GetValorNoNull("Oferta_Eliminar")
        End If
        Return resp
    End Function
End Class
