Namespace dac
    Public Class runnerScript

        Private lineas As New Hashtable
        Private vconexDB As String
        Private vLastResp As String

        Public ReadOnly Property LastResp As String
            Get
                Return vLastResp
            End Get
        End Property

        Public Function gen_cadenaConex(Servidor As String, DB As String, usuario As String, clave As String) As String
            Return "Data Source=" & Servidor & ";Database=" & DB & ";User ID=" & usuario & ";Password=" & clave & ";"
        End Function

        Public Function ejecuta_file_script_anyway(conexDB As String, rutaFull_fileScript As String) As String

            Me.vconexDB = conexDB
            lineas.Clear()
            Me.add_filetxt(rutaFull_fileScript)

            Dim comando As String = ""
            Dim linea As Integer = 0

            Dim resp_final As String = ""

            For linea = 1 To lineas.Count
                If lineas(linea).ToString.Trim.ToUpper = "GO" Then
                    Dim resp As String = Ejecuta_SQL(comando)
                    If resp <> "OK" Then
                        resp_final &= vbCrLf & "Query ==> " & comando & vbCrLf & "Error ==> " & resp & vbCrLf & " ----------------------------------------------------------" & vbCrLf
                    End If
                    comando = ""
                Else
                    comando &= vbCrLf & lineas(linea).ToString
                End If
            Next

            If resp_final.Length > 0 Then
                Me.vLastResp = resp_final
                Return resp_final
            End If

            Me.vLastResp = "OK"
            Return "OK"

        End Function


        Public Function ejecuta_file_script(conexDB As String, rutaFull_fileScript As String) As String

            Me.vconexDB = conexDB
            lineas.Clear()
            Me.add_filetxt(rutaFull_fileScript)

            Dim comando As String = ""
            Dim linea As Integer = 0

            For linea = 1 To lineas.Count
                If lineas(linea).ToString.Trim.ToUpper = "GO" Then
                    Dim resp As String = Ejecuta_SQL(comando)
                    If resp <> "OK" Then
                        Me.vLastResp = resp
                        Return resp
                    End If
                    comando = ""
                Else
                    comando &= vbCrLf & lineas(linea).ToString
                End If
            Next
            If comando.Trim.Length > 0 Then
                Dim resp As String = Ejecuta_SQL(comando)
                If resp <> "OK" Then
                    Me.vLastResp = resp
                    Return resp
                End If
            End If



            Me.vLastResp = "OK"
            Return "OK"

        End Function

        Private Function Ejecuta_SQL(comando_sql As String) As String
            Dim resultado As String = "OK"
            Dim oConn As SqlClient.SqlConnection = New SqlClient.SqlConnection(Me.vconexDB)
            Try
                Dim ocomando As SqlClient.SqlCommand = New SqlClient.SqlCommand(comando_sql, oConn)
                oConn.Open()
                ocomando.CommandTimeout = 6000000
                ocomando.ExecuteNonQuery()

            Catch ex As Exception
                resultado = "ERROR: " & ex.Message
            Finally
                oConn.Close()
            End Try
            Return resultado
        End Function


        Private Sub add_filetxt(ByVal archivo As String)
            Dim vencode As System.Text.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
            Do
                Try
                    Dim ofiletxt As New System.IO.StreamReader(archivo, vencode)
                    While ofiletxt.Peek() > -1
                        lineas.Add(lineas.Count + 1, ofiletxt.ReadLine())
                    End While
                    ofiletxt.Close()
                    Exit Do
                Catch ex As Exception
                    'el fichero esta en uso por otro proceso
                End Try
            Loop
        End Sub




    End Class
End Namespace
