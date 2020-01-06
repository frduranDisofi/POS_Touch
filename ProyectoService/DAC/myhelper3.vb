Imports System.Data.SqlClient
Imports System.Data

Namespace dac
    Public Class myhelper3

        Public paramQUERY As New Dictionary(Of String, String)
        Private vLastResp As String
        Public ReadOnly Property LastResp As String
            Get
                Return vLastResp
            End Get
        End Property

        Public Function ExecuteDataSet(ByVal connectionString As String, _
                                       ByVal commandType As Data.CommandType, _
                                       ByVal commandText As String, _
                                       ByVal params As Generic.Dictionary(Of String, String), _
                                       ByVal commandTimeout As Integer) As DataSet
            Dim adapter As New SqlDataAdapter(commandText, connectionString)

            With adapter.SelectCommand
                .CommandType = commandType
                .CommandTimeout = commandTimeout
            End With

            If Not Object.Equals(params, Nothing) Then
                For Each elem In params
                    Dim paramSQL As New SqlClient.SqlParameter(elem.Key, elem.Value)
                    adapter.SelectCommand.Parameters.Add(paramSQL)
                Next
            End If

            Dim data As New DataSet

            adapter.Fill(data)
            Return data
        End Function

        Public Function ExecuteDatatable(ByVal connectionString As String, _
                                      ByVal commandType As Data.CommandType, _
                                      ByVal commandText As String, _
                                     ByVal params As Generic.Dictionary(Of String, String), _
                                      ByVal commandTimeout As Integer) As DataTable
            Dim adapter As New SqlDataAdapter(commandText, connectionString)

            With adapter.SelectCommand
                .CommandType = commandType
                .CommandTimeout = commandTimeout
            End With

            If Not Object.Equals(params, Nothing) Then
                For Each elem In params
                    Dim paramSQL As New SqlClient.SqlParameter(elem.Key, elem.Value)
                    adapter.SelectCommand.Parameters.Add(paramSQL)
                Next
            End If

            Dim data As New DataSet

            adapter.Fill(data)
            Return data.Tables(0)

        End Function

        Public Function ExecuteScalar(ByVal connectionString As String, _
                                      ByVal commandType As CommandType, _
                                      ByVal commandText As String, _
                                      ByVal params As Generic.Dictionary(Of String, String), _
                                      ByVal commandTimeout As Integer) As Object

            Dim conex As New System.Data.SqlClient.SqlConnection(connectionString)
            Dim comando As New System.Data.SqlClient.SqlCommand()

            With comando
                .CommandType = commandType
                .CommandText = commandText
                .CommandTimeout = commandTimeout ' en segundos (default del SQL es 30 Sec)
                .Connection = conex
            End With

            If Not Object.Equals(params, Nothing) Then
                For Each elem In params
                    Dim paramSQL As New SqlClient.SqlParameter(elem.Key, elem.Value)
                    comando.Parameters.Add(paramSQL)
                Next
            End If

            Dim resultado As Object = Nothing
            Me.vLastResp = "OK"
            Try
                conex.Open()
                resultado = comando.ExecuteScalar()
            Catch ex As Exception
                vLastResp = ex.Message
            Finally
                conex.Close()
            End Try

            Return resultado

        End Function

        Public Function FireAndForget(ByVal connectionString As String, _
                                       ByVal commandType As CommandType, _
                                       ByVal commandText As String, _
                                       ByVal params As Generic.Dictionary(Of String, String), _
                                       ByVal commandTimeout As Integer) As String

            Dim conex As New System.Data.SqlClient.SqlConnection(connectionString)
            Dim comando As New System.Data.SqlClient.SqlCommand()

            With comando
                .CommandType = commandType
                .CommandText = commandText
                .CommandTimeout = commandTimeout
                .Connection = conex
            End With

            If Not Object.Equals(params, Nothing) Then
                For Each elem In params
                    Dim paramSQL As New SqlClient.SqlParameter(elem.Key, elem.Value)
                    comando.Parameters.Add(paramSQL)
                Next
            End If


            Me.vLastResp = "OK"
            Dim resp As String = ""

            Try
                conex.Open()
                resp = comando.ExecuteNonQuery()
            Catch ex As Exception
                vLastResp = ex.Message
                resp = ex.Message
            Finally
                conex.Close()
            End Try

            Return resp
        End Function

        Private conex As System.Data.SqlClient.SqlConnection

        Public Function ExecuteReader(ByVal connectionString As String, _
                                       ByVal commandType As CommandType, _
                                       ByVal commandText As String, _
                                       ByVal params As Generic.Dictionary(Of String, String), _
                                       ByVal commandTimeout As Integer, _
                                       ByVal comando_behavior As CommandBehavior) As System.Data.SqlClient.SqlDataReader

            conex = New System.Data.SqlClient.SqlConnection(connectionString)
            Dim comando As New System.Data.SqlClient.SqlCommand()

            With comando
                .CommandType = commandType
                .CommandText = commandText
                .CommandTimeout = commandTimeout
                .Connection = conex
            End With

            If Not Object.Equals(params, Nothing) Then
                For Each elem In params
                    Dim paramSQL As New SqlClient.SqlParameter(elem.Key, elem.Value)
                    comando.Parameters.Add(paramSQL)
                Next
            End If

            conex.Open()
            Return comando.ExecuteReader(comando_behavior)
        End Function

        Public Sub cierra_conex()
            conex.Close()
        End Sub

    End Class
End Namespace
