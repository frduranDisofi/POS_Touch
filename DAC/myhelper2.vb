Imports System.Data.SqlClient

Namespace dac
    Public Class myhelper2
        Public Function ExecuteDataSet(ByVal connectionString As String, _
                                       ByVal commandType As CommandType, _
                                       ByVal commandText As String, _
                                       ByVal params As SqlParameter(), _
                                       ByVal commandTimeout As Integer) As DataSet
            Dim adapter As New SqlDataAdapter(commandText, connectionString)

            With adapter.SelectCommand
                .CommandType = commandType
                .CommandTimeout = commandTimeout
            End With

            If Not Object.Equals(params, Nothing) Then
                adapter.SelectCommand.Parameters.AddRange(params)
            End If

            Dim data As New DataSet

            adapter.Fill(data)
            Return data
        End Function

        Public Function ExecuteScalar(ByVal connectionString As String, _
                                       ByVal commandType As CommandType, _
                                       ByVal commandText As String, _
                                       ByVal params As SqlParameter(), _
                                       ByVal commandTimeout As Integer) As Object

            Dim conex As New System.Data.SqlClient.SqlConnection(connectionString)
            Dim comando As New System.Data.SqlClient.SqlCommand()

            With comando
                .CommandType = commandType
                .CommandText = commandText
                .CommandTimeout = commandTimeout 'segundos
                .Connection = conex
            End With

            If Not Object.Equals(params, Nothing) Then
                comando.Parameters.AddRange(params)
            End If

            Dim resultado As Object = Nothing

            Try
                conex.Open()
                resultado = comando.ExecuteScalar()
            Catch ex As Exception
            Finally
                conex.Close()
            End Try

            Return resultado

        End Function

        Public Function FireAndForget(ByVal connectionString As String, _
                                       ByVal commandType As CommandType, _
                                       ByVal commandText As String, _
                                       ByVal params As SqlParameter(), _
                                       ByVal commandTimeout As Integer) As String      '  usar para insert

            Dim conex As New System.Data.SqlClient.SqlConnection(connectionString)
            Dim comando As New System.Data.SqlClient.SqlCommand()

            With comando
                .CommandType = commandType
                .CommandText = commandText
                .CommandTimeout = commandTimeout
                .Connection = conex
            End With

            If Not Object.Equals(params, Nothing) Then
                comando.Parameters.AddRange(params)
            End If


            Dim resultado As String = "OK"

            Try
                conex.Open()
                resultado = comando.ExecuteNonQuery()
            Catch ex As Exception
                resultado = ex.Message
            Finally
                conex.Close()
            End Try

            Return resultado
        End Function


        Public Function ExecuteReader(ByVal connectionString As String, _
                                       ByVal commandType As CommandType, _
                                       ByVal commandText As String, _
                                       ByVal params As SqlParameter(), _
                                       ByVal commandTimeout As Integer, _
                                       ByVal comando_behavior As CommandBehavior) As System.Data.SqlClient.SqlDataReader

            Dim conex As New System.Data.SqlClient.SqlConnection(connectionString)
            Dim comando As New System.Data.SqlClient.SqlCommand()

            With comando
                .CommandType = commandType
                .CommandText = commandText
                .CommandTimeout = commandTimeout
                .Connection = conex
            End With

            If Not Object.Equals(params, Nothing) Then
                comando.Parameters.AddRange(params)
            End If

            Return comando.ExecuteReader(comando_behavior)
        End Function


    End Class
End Namespace