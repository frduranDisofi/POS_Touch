Imports System.Data.SqlClient
Imports System.Data

Namespace dac
    Public Class myMSSQL

        Public paramQUERY As New Dictionary(Of String, String)

        Private vLastResp As String
        Private vTimeOutSQL As Integer
        Private vConexSQL As String
        Private vError As String
        Private vDioError As Boolean

        Public ReadOnly Property MsgError As String
            Get
                Return vError
            End Get
        End Property

        Public ReadOnly Property DioError As Boolean
            Get
                Return vDioError
            End Get
        End Property

        Public Sub New(ConexDB As String, TimeOutSQL As Integer)
            Me.vConexSQL = ConexDB
            Me.vTimeOutSQL = TimeOutSQL
            Me.vDioError = False
            Me.vError = ""
        End Sub


        Public Function GetTabla(ByVal NameSP As String) As DataTable
            Me.vDioError = False
            Me.vError = ""
            Dim adapter As New SqlDataAdapter(NameSP, Me.vConexSQL)

            With adapter.SelectCommand
                .CommandType = System.Data.CommandType.StoredProcedure
                .CommandTimeout = Me.vTimeOutSQL
            End With

            If Not Object.Equals(paramQUERY, Nothing) Then
                For Each elem In paramQUERY
                    Dim paramSQL As New SqlClient.SqlParameter(elem.Key, elem.Value)
                    adapter.SelectCommand.Parameters.Add(paramSQL)
                Next
            End If

            Dim data As New DataSet
            Try
                adapter.Fill(data)
            Catch ex As Exception
                Me.vDioError = True
                Me.vError = "SP " & NameSP & ": " & ex.Message
            End Try

            Return data.Tables(0)
        End Function


        Public Function GetValor(ByVal NameSP As String) As Object
            Me.vDioError = False
            Me.vError = ""
            Dim conex As New System.Data.SqlClient.SqlConnection(Me.vConexSQL)
            Dim comando As New System.Data.SqlClient.SqlCommand()

            With comando
                .CommandType = Data.CommandType.StoredProcedure
                .CommandText = NameSP
                .CommandTimeout = Me.vTimeOutSQL ' en segundos (default del SQL es 30 Sec)
                .Connection = conex
            End With

            If Not Object.Equals(Me.paramQUERY, Nothing) Then
                For Each elem In Me.paramQUERY
                    Dim paramSQL As New SqlClient.SqlParameter(elem.Key, elem.Value)
                    comando.Parameters.Add(paramSQL)
                Next
            End If

            Dim resultado As Object = Nothing

            Try
                conex.Open()
                resultado = comando.ExecuteScalar()
            Catch ex As Exception
                Me.vDioError = True
                Me.vError = "SP " & NameSP & ": " & ex.Message
            Finally
                conex.Close()
            End Try

            Return resultado
        End Function

        Public Function GetValorNoNull(ByVal NameSP As String) As Object
            Me.vDioError = False
            Me.vError = ""
            Dim resultado As Object = Nothing
            resultado = Me.GetValor(NameSP)
            If IsNothing(resultado) OrElse resultado.ToString = "" Then
                Me.vDioError = True
                Me.vError = "Retorna valor nulo (" & Me.vError & ")"
                resultado = ""
            End If
            Return resultado
        End Function


        Public Sub Ejecuta(ByVal NameSP As String)
            Me.vDioError = False
            Me.vError = ""
            Dim conex As New System.Data.SqlClient.SqlConnection(Me.vConexSQL)
            Dim comando As New System.Data.SqlClient.SqlCommand()

            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = NameSP
                .CommandTimeout = Me.vTimeOutSQL
                .Connection = conex
            End With

            If Not Object.Equals(Me.paramQUERY, Nothing) Then
                For Each elem In Me.paramQUERY
                    Dim paramSQL As New SqlClient.SqlParameter(elem.Key, elem.Value)
                    comando.Parameters.Add(paramSQL)
                Next
            End If

            Try
                conex.Open()
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Me.vDioError = True
                Me.vError = "SP " & NameSP & ": " & ex.Message
            Finally
                conex.Close()
            End Try

        End Sub

    End Class
End Namespace
