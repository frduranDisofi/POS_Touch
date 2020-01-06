Imports SYSi = System.IO
Imports syst = System.Text

Namespace bc
    Public Class archivotxt
        Private obe_archivotxt As New be.archivo_txt
        Private num_linea As Integer = 0
        Private name_y_camino_file As String
        Private obc_cadenaMan As New bc.cadenaMan

        Public ReadOnly Property nombreFull_file() As String
            Get
                Return Me.name_y_camino_file
            End Get
        End Property

        Public Sub add_filetxt(contenido_del_file As String)
            Do
                Try
                    Dim ofiletxt As New SYSi.StringReader(contenido_del_file)
                    While ofiletxt.Peek() > -1
                        MyClass.add_linea(ofiletxt.ReadLine())
                    End While
                    ofiletxt.Close()
                    Exit Do
                Catch ex As Exception

                End Try
            Loop
        End Sub

        Public Sub add_filetxt(ByVal archivo As String, ByVal borrar As Boolean)
            Dim vencode As syst.Encoding = syst.Encoding.GetEncoding("ISO-8859-1")
            Do
                Try
                    Dim ofiletxt As New SYSi.StreamReader(archivo, vencode)
                    While ofiletxt.Peek() > -1
                        MyClass.add_linea(ofiletxt.ReadLine())
                    End While
                    ofiletxt.Close()
                    If borrar Then
                        Kill(archivo)
                    End If
                    Exit Do
                Catch ex As Exception
                    'el fichero esta en uso por otro proceso
                End Try
            Loop
        End Sub

        Public Sub save_tofile_ENCODE8859(Optional ByVal archivo As String = " ")
            Dim vencode As syst.Encoding = syst.Encoding.GetEncoding("ISO-8859-1")
            If archivo.Trim.Length = 0 Then
                archivo = MyClass.name_y_camino_file
            End If
            Dim sw As SYSi.StreamWriter = New SYSi.StreamWriter(archivo, False, vencode)
            Dim i As Integer
            For i = 1 To obe_archivotxt.cant_lineas
                sw.WriteLine(MyClass.get_linea(i))
            Next
            sw.Close()
        End Sub


        Public Sub save_tofile(Optional ByVal archivo As String = " ")
            If archivo.Trim.Length = 0 Then
                archivo = MyClass.name_y_camino_file
            End If
            Dim sw As SYSi.StreamWriter = New SYSi.StreamWriter(archivo, False)
            Dim i As Integer
            For i = 1 To obe_archivotxt.cant_lineas
                sw.WriteLine(MyClass.get_linea(i))
            Next
            sw.Close()
        End Sub

        Public Sub add_linea(num_linea As Integer, ByVal linea As String)
            obe_archivotxt.lineas.Add(num_linea, linea)
        End Sub


        Public Sub add_linea(linea As String)
            obe_archivotxt.lineas.Add(obe_archivotxt.lineas.Count + 1, linea)
        End Sub

        Public Function tostring_LFCR() As String
            Dim cadena As String
            Dim inicio As Boolean = True
            Dim i As Integer
            cadena = ""
            For i = 1 To obe_archivotxt.cant_lineas
                If Not inicio Then
                    cadena = cadena & vbCrLf & obe_archivotxt.lineas(i)
                Else
                    cadena = obe_archivotxt.lineas(i)
                    inicio = False
                End If
            Next
            Return cadena
        End Function


        Public Overrides Function tostring() As String
            Dim cadena As String
            Dim inicio As Boolean = True
            Dim i As Integer
            cadena = ""
            For i = 1 To obe_archivotxt.cant_lineas
                If Not inicio Then
                    cadena = cadena & Chr(13) & obe_archivotxt.lineas(i)
                Else
                    cadena = obe_archivotxt.lineas(i)
                    inicio = False
                End If
            Next
            Return cadena
        End Function

        Public Function tostring_fast() As String
            Dim sb As New System.Text.StringBuilder()
            For i As Integer = 1 To obe_archivotxt.cant_lineas
                sb.Append(obe_archivotxt.lineas(i))
            Next
            Return sb.ToString
        End Function


        Public Sub changeALL_Char(ByVal cadenaOLD As Char, ByVal cadenaNEW As Char)
            Dim i As Integer = 1
            Do While (i <= Me.obe_archivotxt.cant_lineas)
                Dim tempo As String = obe_archivotxt.lineas(i)
                Dim tempo2 As String = ""
                For Each letra As Char In tempo
                    If Asc(letra) = Asc(cadenaOLD) Then
                        tempo2 = tempo2 & cadenaNEW
                    Else
                        tempo2 = tempo2 & letra
                    End If
                Next
                Me.obe_archivotxt.lineas.Item(i) = tempo2
                i += 1
            Loop
        End Sub

        Public Sub changeALL(ByVal cadenaOLD As String, ByVal cadenaNEW As String)
            Dim i As Integer = 1
            Do While (i <= Me.obe_archivotxt.cant_lineas)
                Dim linea_final As String = Strings.Replace(obe_archivotxt.lineas(i), cadenaOLD, cadenaNEW, 1, -1, CompareMethod.Text)
                Me.obe_archivotxt.lineas.Item(i) = linea_final
                i += 1
            Loop
        End Sub


        Public Function get_linea(ByVal numlinea As Integer) As String
            Return obe_archivotxt.lineas(numlinea)
        End Function

        Public Function get_cadena(ByVal linea As Integer, ByVal columna As Integer, ByVal largo As Integer) As String
            Dim cadena As String
            Dim respuesta As String = ""
            cadena = obe_archivotxt.lineas(linea)
            If Not String.IsNullOrEmpty(cadena) Then
                If columna + largo <= cadena.Length Then
                    respuesta = Mid(cadena, columna, largo)
                Else
                    If columna <= cadena.Length Then
                        respuesta = Mid(cadena, columna)
                    Else
                        respuesta = ""
                    End If
                End If
            End If

            Return respuesta
        End Function

        Public Property archivotxt() As be.archivo_txt
            Get
                Return obe_archivotxt
            End Get
            Set(ByVal Value As be.archivo_txt)
                obe_archivotxt = Value
            End Set
        End Property

        Public Enum modo_adiciona
            SI
            NO
        End Enum


        Public Sub crea_new(ByVal camino_y_name As String, ByVal adiciona As modo_adiciona)
            MyClass.name_y_camino_file = camino_y_name
            If My.Computer.FileSystem.FileExists(camino_y_name.Trim) AndAlso adiciona = modo_adiciona.NO Then
                Try
                    Kill(camino_y_name)
                Catch ex As Exception
                    MsgBox("Error: no se puede borrar el archivo " & camino_y_name, MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End Try
            End If

            'quiere decir que esta en modo adicionar
            If My.Computer.FileSystem.FileExists(camino_y_name.Trim) Then
                MyClass.add_filetxt(camino_y_name, False)
            Else
                Dim nuevo_file As New SYSi.FileStream(camino_y_name, IO.FileMode.Create)
                nuevo_file.Close()
            End If
        End Sub

        Public Sub ins_linea(ByVal num_linea As Integer, ByVal linea_nueva As String)
            Dim lineas_temp As New Hashtable
            For i As Integer = 1 To num_linea - 1
                lineas_temp.Add(i, obe_archivotxt.lineas(i))
            Next
            lineas_temp.Add(num_linea, linea_nueva)
            For i As Integer = num_linea To obe_archivotxt.cant_lineas
                lineas_temp.Add(i + 1, obe_archivotxt.lineas(i + 1))
            Next
            obe_archivotxt.lineas.Clear()
            obe_archivotxt.lineas = lineas_temp
        End Sub

        Public Sub del_linea(ByVal num_linea As Integer)
            Dim lineas_temp As New Hashtable
            For i As Integer = 1 To num_linea - 1
                lineas_temp.Add(i, obe_archivotxt.lineas(i))
            Next
            For i As Integer = num_linea + 1 To obe_archivotxt.cant_lineas
                lineas_temp.Add(i - 1, obe_archivotxt.lineas(i))
            Next
            obe_archivotxt.lineas.Clear()
            obe_archivotxt.lineas = lineas_temp
        End Sub


    End Class


End Namespace


