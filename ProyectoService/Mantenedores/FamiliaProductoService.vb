Public Class FamiliaProductoService
    Public Function GetFamiliaProducto() As DataTable
        Dim con As New Conexion
        Dim dt As New DataTable
        If con.Conexion Then
            Try
                Dim odac As New dac.myhelper3
                dt = odac.ExecuteDatatable(con.con.ConnectionString, CommandType.StoredProcedure, "GetFamiliaProducto", Nothing, 180000)
            Catch ex As Exception
                dt = New DataTable
            End Try
        End If
        Return dt
    End Function
    Public Function ModificarFamilia(ByVal CodigoFamilia As String, ByVal FamiliaProducto As String, ByVal impresoraFamilia As String) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("CodigoFamilia", CodigoFamilia)
            odac.paramQUERY.Add("FamiliaProducto", FamiliaProducto)
            odac.paramQUERY.Add("Impresora", impresoraFamilia)
            resp = odac.GetValorNoNull("FamiliaProducto_Modificar")
        End If
        Return resp
    End Function
    Public Function GrabarFamilia(ByVal Familia As String, ByVal impresoraFamilia As String) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("Familia", Familia)
            odac.paramQUERY.Add("Impresora", impresoraFamilia)
            resp = odac.GetValorNoNull("FamiliaProducto_Grabar")
        End If
        Return resp
    End Function
    Public Function TraerImagenes(ruta As String) As String
        Dim con As New Conexion
        If con.Conexion Then
            Dim ruta_ As String = ruta
            Try
                Dim dt As New DataTable
                Dim odac As New dac.myhelper3
                dt = odac.ExecuteDatatable(con.con.ConnectionString, CommandType.Text, "select * from FamiliaFoto", Nothing, 180000)

                For Each dato As DataRow In dt.Rows
                    Dim archivo() As Byte = CType(dato("Foto"), Byte())
                    ruta_ &= "\" & dato("FamiliaId").ToString & ".jpg"
                    Dim fstram As New System.IO.FileStream(ruta_, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                    fstram.Write(archivo, 0, archivo.Length)
                    fstram.Close()
                    ruta_ = ruta
                Next

            Catch ex As Exception

            End Try
        End If
        Return ruta
    End Function

    Public Function EliminarFamilia(ByVal CodigoFamilia As String) As String
        Dim resp As String = ""
        Dim con As New Conexion
        If con.Conexion Then
            Dim odac As New dac.myMSSQL(con.con.ConnectionString, 180000)
            odac.paramQUERY.Add("CodigoFamilia", CInt(CodigoFamilia))
            resp = odac.GetValorNoNull("EliminarFamilia")
        End If
        Return resp
    End Function
End Class
