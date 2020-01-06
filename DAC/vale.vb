Imports System.Data.SqlClient
Namespace dac

    Public Class vale
        Inherits conexion
        Dim mysql As New dac.myhelper2


        Public Function cab_ticket(ByVal dts As ticket) As Boolean
            Try
                conectado()
                Dim lista_parametros(3) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@fecha"
                lista_parametros(0).Value = dts.get_fecha

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@forma_pago"
                lista_parametros(1).Value = dts.get_forma_pago

                lista_parametros(2) = New Data.SqlClient.SqlParameter
                lista_parametros(2).ParameterName = "@total"
                lista_parametros(2).Value = dts.get_total

                lista_parametros(3) = New Data.SqlClient.SqlParameter
                lista_parametros(3).ParameterName = "@efectivo"
                lista_parametros(3).Value = dts.get_efectivo


                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "cab_ticket", lista_parametros, 60) Then
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

        Public Function detalle_ticket(ByVal dts2 As ticket) As Boolean
            Try
                conectado()

                Dim lista_parametros(5) As Data.SqlClient.SqlParameter

                lista_parametros(0) = New Data.SqlClient.SqlParameter
                lista_parametros(0).ParameterName = "@id_doc"
                lista_parametros(0).Value = dts2.get_id_doc

                lista_parametros(1) = New Data.SqlClient.SqlParameter
                lista_parametros(1).ParameterName = "@descripcion"
                lista_parametros(1).Value = dts2.get_descripcion

                lista_parametros(2) = New Data.SqlClient.SqlParameter
                lista_parametros(2).ParameterName = "@cantidad"
                lista_parametros(2).Value = dts2.get_cantidad

                lista_parametros(3) = New Data.SqlClient.SqlParameter
                lista_parametros(3).ParameterName = "@precio"
                lista_parametros(3).Value = dts2.get_precio

                lista_parametros(4) = New Data.SqlClient.SqlParameter
                lista_parametros(4).ParameterName = "@total_item"
                lista_parametros(4).Value = dts2.get_total_item

                lista_parametros(5) = New Data.SqlClient.SqlParameter
                lista_parametros(5).ParameterName = "@codigo"
                lista_parametros(5).Value = dts2.get_codigo

                If mysql.FireAndForget(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "detalle_ticket", lista_parametros, 60) Then
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