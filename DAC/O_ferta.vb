Imports System.Data.SqlClient
Namespace dac
    Public Class O_ferta
        Inherits conexion
        Dim mysql As New dac.myhelper2

        Public Function grabo_oferta(ByVal dts As Oferta) As Boolean
            Try
                conectado()
                Dim lista_parametros(2) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@codigooferta"
                lista_parametros(0).Value = dts.get_codigoOferta

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@nombreoferta"
                lista_parametros(1).Value = dts.get_nombreOferta

                lista_parametros(2) = New Data.SqlClient.SqlParameter
                lista_parametros(2).ParameterName = "@preciooferta"
                lista_parametros(2).Value = dts.get_precioOferta

                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "grabo_oferta", lista_parametros, 60) Then
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

        Public Function detalle_oferta(ByVal dts As Oferta) As Boolean
            Try
                conectado()
                Dim parametros(5) As Data.SqlClient.SqlParameter

                parametros(0) = New Data.SqlClient.SqlParameter
                parametros(0).ParameterName = "@idproducto"
                parametros(0).Value = dts.get_idproducto

                parametros(1) = New Data.SqlClient.SqlParameter
                parametros(1).ParameterName = "@descripcion"
                parametros(1).Value = dts.get_descripcion

                parametros(2) = New Data.SqlClient.SqlParameter
                parametros(2).ParameterName = "@codigoInt"
                parametros(2).Value = dts.get_codigoInt

                parametros(3) = New Data.SqlClient.SqlParameter
                parametros(3).ParameterName = "@codigo"
                parametros(3).Value = dts.get_codigo

                parametros(4) = New Data.SqlClient.SqlParameter
                parametros(4).ParameterName = "@CodigoFamilia"
                parametros(4).Value = dts.get_Cod_FamiliaProducto

                parametros(5) = New Data.SqlClient.SqlParameter
                parametros(5).ParameterName = "@familia"
                parametros(5).Value = dts.get_NombreFamilia

                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "graboDetalleOferta", parametros, 60) Then
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

        Public Function buscoOferta(ByVal dts As Oferta) As DataTable
            Dim promocion As DataTable
            If conectado() Then
                Try
                    Dim parametros(0) As Data.SqlClient.SqlParameter

                    parametros(0) = New Data.SqlClient.SqlParameter
                    parametros(0).ParameterName = "@CodigoOferta"
                    parametros(0).Value = dts.get_codigoOferta

                    promocion = mysql.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "BuscoOferta", parametros, 60).Tables(0)
                    Return promocion

                Catch ex As Exception
                    MsgBox(ex.Message)
                    promocion = New DataTable
                End Try
            End If
            'Return promocion
        End Function

    End Class
End Namespace
