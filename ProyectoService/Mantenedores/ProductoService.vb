Imports proyectoDTO

Public Class ProductoService
    Public Function getProductos() As DataTable
        Dim con As New Conexion
        Dim dt As New DataTable
        If con.Conexion Then
            Try
                Dim odac As New dac.myhelper3
                dt = odac.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "getProductos", Nothing, 180000)
            Catch ex As Exception
                dt = New DataTable
            End Try
        End If
        Return dt
    End Function
    Public Function GetProductoOferta(ByVal IdFamilia As Integer) As DataTable
        Dim con As New Conexion
        Dim dt As New DataTable
        If con.Conexion Then
            Try
                Dim odac As New dac.myhelper3
                odac.paramQUERY.Add("IdFamilia", IdFamilia)
                dt = odac.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "Productos_X_Familia", odac.paramQUERY, 180000)
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

    Public Function EliminaProducto(ByVal Codigo As String)
        Dim con As New Conexion
        Dim dt As String = ""

        If con.Conexion Then
            Try
                Dim sql As New dac.myMSSQL(con.con.ConnectionString, 60000)
                sql.paramQUERY.Add("Codigo", Codigo)
                dt = sql.GetValorNoNull("EliminarProducto")
            Catch ex As Exception

            End Try
        End If
        Return dt
    End Function
    Public Function getProductosFamilia(ByVal Id As Integer) As DataTable
        Dim con As New Conexion
        Dim dt As New DataTable
        If con.Conexion Then
            Try
                Dim odac As New dac.myhelper3
                odac.paramQUERY.Add("Id", Id)
                dt = odac.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "getProductosFamilia", odac.paramQUERY, 180000)
            Catch ex As Exception
                dt = New DataTable
            End Try
        End If
        Return dt
    End Function

    Public Function GrabaStock(ByVal dts As Compras) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("Fecha", dts.Fecha_)
            odac.paramQUERY.Add("Folio", dts.get_folio)
            odac.paramQUERY.Add("IdProducto", CInt(dts.get_codigo))
            odac.paramQUERY.Add("Cantidad", dts.get_cantidad)
            odac.paramQUERY.Add("Usuario", dts.Usuario)

            resp = odac.GetValorNoNull("Stock_Grabar")
        End If
        Return resp
    End Function
    Public Function GetProductoFamilia(ByVal IdFamilia As Integer) As DataTable
        Dim con As New Conexion
        Dim dt As New DataTable
        If con.Conexion Then
            Try
                Dim odac As New dac.myhelper3
                odac.paramQUERY.Add("IdFamilia", IdFamilia)
                dt = odac.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "GetProductoFamilia", odac.paramQUERY, 180000)
                Dim row As DataRow = dt.NewRow()
                row("id") = 0
                row("nombre") = "Seleccione..."
                dt.Rows.InsertAt(row, 0)
            Catch ex As Exception
                dt = New DataTable
            End Try
        End If
        Return dt
    End Function
End Class
