Imports System.Data.SqlClient
Namespace dac

    Public Class compra
        Inherits conexion
        Dim mysql As New dac.myhelper2

        Public Function cab_compras(ByVal dts As comprar) As Boolean
            Try
                conectado()
                Dim lista_parametros(6) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@fecha"
                lista_parametros(0).Value = dts.get_fecha

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@folio"
                lista_parametros(1).Value = dts.get_folio

                lista_parametros(2) = New Data.SqlClient.SqlParameter
                lista_parametros(2).ParameterName = "@tipodoc"
                lista_parametros(2).Value = dts.get_tipodoc

                lista_parametros(3) = New Data.SqlClient.SqlParameter
                lista_parametros(3).ParameterName = "@rut_proveedor"
                lista_parametros(3).Value = dts.get_rut_preveedor

                lista_parametros(4) = New Data.SqlClient.SqlParameter
                lista_parametros(4).ParameterName = "@neto"
                lista_parametros(4).Value = dts.get_neto

                lista_parametros(5) = New Data.SqlClient.SqlParameter
                lista_parametros(5).ParameterName = "@iva"
                lista_parametros(5).Value = dts.get_iva

                lista_parametros(6) = New Data.SqlClient.SqlParameter
                lista_parametros(6).ParameterName = "@total"
                lista_parametros(6).Value = dts.get_total

                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "cab_compras", lista_parametros, 60) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                desconectado()
            End Try
        End Function

        Public Function detalle_compras(ByVal dts2 As comprar) As Boolean
            Try
                conectado()

                Dim lista_parametros(5) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@codigo"
                lista_parametros(0).Value = dts2.get_codigo

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@descripcion"
                lista_parametros(1).Value = dts2.get_descripcion

                lista_parametros(2) = New Data.SqlClient.SqlParameter
                lista_parametros(2).ParameterName = "@precio"
                lista_parametros(2).Value = dts2.get_precio

                lista_parametros(3) = New Data.SqlClient.SqlParameter
                lista_parametros(3).ParameterName = "@cantidad"
                lista_parametros(3).Value = dts2.get_cantidad

                lista_parametros(4) = New Data.SqlClient.SqlParameter
                lista_parametros(4).ParameterName = "@total_item"
                lista_parametros(4).Value = dts2.get_total_detalle

                lista_parametros(5) = New Data.SqlClient.SqlParameter
                lista_parametros(5).ParameterName = "@id_cab"
                lista_parametros(5).Value = dts2.get_id_cab

                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "detalle_compras", lista_parametros, 60) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                desconectado()
            End Try
        End Function
    End Class
End Namespace
