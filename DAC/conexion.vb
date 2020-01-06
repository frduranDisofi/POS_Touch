Imports System.Data.SqlClient

Public Class conexion
    Protected cnn As New SqlConnection
    Private conn As New SqlConnection
    Public _error As String

    Public Function conectado()
        Try
            cnn = New SqlConnection(My.Settings.deliveryConnectionString)
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function EjecutaSQL(ByVal sql As String) As Boolean
        Dim resp As Boolean = False
        Try
            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)
            Dim rows As Integer = cmd.ExecuteNonQuery()
            If (rows = 0) Then
                resp = False
            Else
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            resp = False
        End Try
        Return resp
    End Function

    Public ReadOnly Property getConn() As SqlConnection
        Get
            Return conn
        End Get
    End Property

    Public Sub New()
        Try
            conn.ConnectionString = My.Settings.deliveryConnectionString
            conn.Open()
            conn.Close()
        Catch ex As Exception

            _error = ex.Message
            conn.ConnectionString = My.Settings.deliveryConnectionString
        End Try

    End Sub

    Public Function traerDataTable(ByVal sql As String) As DataTable
        Dim ds As New DataSet
        Try
            conn.Open()
            Dim da As New SqlDataAdapter(sql, conn)
            da.Fill(ds)
            conn.Close()
        Catch ex As SqlException
            Return Nothing
        End Try
        Return ds.Tables(0)
    End Function
End Class
