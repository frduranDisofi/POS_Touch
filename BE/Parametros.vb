Namespace BE
    Public Class Parametros
        Private Parametros As New Dictionary(Of String, String)
        Private myhelpher2 As New dac.myhelper2

        Public Function get_parametros()
            Try
                Parametros.Clear()
                Dim vtabla As New DataTable
                vtabla = myhelpher2.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.StoredProcedure, "get_parametros", Nothing, 60).Tables(0)
                Parametros.Add("RUTEmpresa", vtabla.Rows(0).Item("RUTEmpresa"))
                Parametros.Add("RznSoc", vtabla.Rows(0).Item("RznSoc"))
                Parametros.Add("Giro", vtabla.Rows(0).Item("Giro"))
                Parametros.Add("Impresora", vtabla.Rows(0).Item("Impresora"))
                Parametros.Add("NroCopias", vtabla.Rows(0).Item("NroCopias"))
                Parametros.Add("Licencia", vtabla.Rows(0).Item("Licencia"))

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return "OK"
        End Function

        Public ReadOnly Property RUTEmpresa() As String
            Get
                Return Parametros("RUTEmpresa")
            End Get
        End Property
        Public ReadOnly Property RznSoc() As String
            Get
                Return Parametros("RznSoc")
            End Get
        End Property
        Public ReadOnly Property Giro() As String
            Get
                Return Parametros("Giro")
            End Get
        End Property
        Public ReadOnly Property Impresora() As String
            Get
                Return Parametros("Impresora")
            End Get
        End Property
        Public ReadOnly Property NroCopias() As String
            Get
                Return Parametros("NroCopias")
            End Get
        End Property
        Public ReadOnly Property Licencia() As String
            Get
                Return Parametros("Licencia")
            End Get
        End Property
    End Class
End Namespace

