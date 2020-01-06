Imports System.Data.SqlClient
Namespace dac
    Public Class produc
        Inherits conexion
        Dim mysql As New dac.myhelper2

        Public Function grabo_producto(ByVal dts As producto) As Boolean
            Try
                conectado()
                Dim lista_parametros(4) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@codigo"
                lista_parametros(0).Value = dts.get_codigo

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@descripcion"
                lista_parametros(1).Value = dts.get_descripcion

                lista_parametros(2) = New Data.SqlClient.SqlParameter
                lista_parametros(2).ParameterName = "@precio"
                lista_parametros(2).Value = dts.get_precio

                lista_parametros(3) = New Data.SqlClient.SqlParameter
                lista_parametros(3).ParameterName = "@codigoInt"
                lista_parametros(3).Value = dts.get_codigoInt

                lista_parametros(4) = New Data.SqlClient.SqlParameter
                lista_parametros(4).ParameterName = "@CodigoFamilia"
                lista_parametros(4).Value = dts.get_Familia

                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "grabo_producto", lista_parametros, 60) Then
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

        Public Function actualiza_producto(ByVal dts As producto) As Boolean
            Try

                conectado()
                Dim lista_parametros(4) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@codigo"
                lista_parametros(0).Value = dts.get_codigo

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@descripcion"
                lista_parametros(1).Value = dts.get_descripcion.ToString.Trim

                lista_parametros(2) = New Data.SqlClient.SqlParameter
                lista_parametros(2).ParameterName = "@precio"
                lista_parametros(2).Value = dts.get_precio

                lista_parametros(3) = New Data.SqlClient.SqlParameter
                lista_parametros(3).ParameterName = "@cod_interno"
                lista_parametros(3).Value = dts.get_codigoInt

                lista_parametros(4) = New Data.SqlClient.SqlParameter
                lista_parametros(4).ParameterName = "@CodigoFamilia"
                lista_parametros(4).Value = dts.get_Familia

                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "actualiza_producto", lista_parametros, 60) Then
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

        Public Function elimina_producto(ByVal dts As producto) As Boolean
            Try

                conectado()
                Dim lista_parametros(1) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@codigo"
                lista_parametros(0).Value = dts.get_codigo

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@descripcion"
                lista_parametros(1).Value = dts.get_descripcion

                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "elimina_producto", lista_parametros, 60) Then
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


        Public Function ExisteCodigoProducto(ByVal dts As producto) As String
            Dim respuesta As String = ""
            Try
                conectado()
                Dim lista_parametros(1) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@codigo"
                lista_parametros(0).Value = dts.get_codigo

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@codigoFamilia"
                lista_parametros(1).Value = dts.get_Familia

                respuesta = mysql.ExecuteScalar(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "existe_codigo_producto", lista_parametros, 60)
                Return respuesta

            Catch ex As Exception
                Return respuesta = ex.Message
            Finally
                desconectado()
            End Try
        End Function
    End Class
End Namespace
