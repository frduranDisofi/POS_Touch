Namespace bc
    Public Class cadenaMan
        Private obc_rutman As New bc.RUTman

        Public Function get_email(ByVal cadena As String) As String
            Dim patron_emails As String = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"
            Dim re As New System.Text.RegularExpressions.Regex(patron_emails, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            Dim m As System.Text.RegularExpressions.Match = re.Match(cadena)
            Dim resultado As String = ""
            If m.Success Then
                resultado = m.Value
            End If
            Return resultado
        End Function

        Public Function countchar(ByVal letra As Char, ByVal cadena As String) As Integer
            Dim startIndex As Integer = -1
            Dim hitCount As Integer = 0

            ' Search for all occurrences of the target.
            While True
                startIndex = cadena.IndexOf(letra, startIndex + 1, cadena.Length - startIndex - 1)

                ' Exit the loop if the target is not found.
                If startIndex < 0 Then
                    Exit While
                End If

                hitCount += 1
            End While
            countchar = hitCount
        End Function

        Public Function get_substr(ByVal subcadena As String, ByVal repeticion As Integer, ByVal cadenafull As String) As String
            Dim largo_frase As Integer = subcadena.Length
            Dim primera_letra_frase As Char = subcadena.Chars(0)
            Dim cant_encontrados As Integer = 0
            Dim posicion As Integer = 0
            Dim resultado As String = ""
            For Each letra As Char In cadenafull
                If letra = primera_letra_frase Then
                    If cadenafull.Substring(posicion, largo_frase) = subcadena Then
                        cant_encontrados += 1
                        If cant_encontrados = repeticion Then
                            resultado = cadenafull.Substring(posicion)
                            Exit For
                        End If
                    End If
                End If
                posicion += 1
            Next
            Return resultado
        End Function


        Public Function es_numerico(ByVal cadena_to_check As String) As Boolean
            Dim resultado As Boolean = True
            Dim posic_cadena As Integer = 0
            cadena_to_check = cadena_to_check.Trim
            Dim cantidad_puntos As Integer = 0
            Try
                For Each letra As Char In cadena_to_check
                    posic_cadena += 1
                    If Not Char.IsDigit(letra) Then
                        If letra = "-" AndAlso posic_cadena = 1 Then
                            Continue For
                        End If
                        If letra = "." And cantidad_puntos = 0 Then
                            cantidad_puntos = 1
                            Continue For
                        End If
                        resultado = False
                    End If
                Next
            Catch ex As Exception
                resultado = False
            End Try

            Return resultado
        End Function

        Public Function get_directorio(ByVal full_camino_file As String) As String
            Dim fileData As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(full_camino_file)
            Return fileData.DirectoryName
        End Function

        Public Function get_namefile(ByVal camino_y_namefile As String) As String
            Dim resultado As String = ""
            Dim posicion As Integer = camino_y_namefile.LastIndexOf("\")
            resultado = camino_y_namefile.Substring(posicion + 1)
            Return resultado
        End Function

        Public Function get_extension_file(ByVal namefile As String) As String
            Dim resultado As String = ""
            Dim posicion As Integer = namefile.LastIndexOf(".")
            If posicion > 0 Then
                resultado = namefile.Substring(posicion + 1)
            End If
            Return resultado
        End Function

        Public Function val_posible(ByRef donde_buscar As String, ByRef lista_valores_posibles As String) As Boolean
            Dim vexiste As Boolean = False
            Dim vlista() As String = Split(lista_valores_posibles, "|")
            Dim velem As String

            If String.IsNullOrEmpty(donde_buscar) Then
                donde_buscar = " "
            End If

            For Each velem In vlista
                If velem.Trim = "DD/MM/YYYY" Then
                    If donde_buscar.Substring(2, 1) = "/" AndAlso donde_buscar.Substring(5, 1) = "/" Then
                        vexiste = True
                        Exit For
                    End If
                End If

                If velem.ToUpper.Trim = donde_buscar.ToUpper.Trim OrElse velem = "*" Then
                    vexiste = True
                    Exit For
                End If

                'si lista_valores posibles es ¡ significa cualquier caract menos espacio o vacio
                If velem = "¡" AndAlso Not String.IsNullOrEmpty(donde_buscar.Trim) Then
                    vexiste = True
                    Exit For
                End If

                'si lista_valores posibles es ¿ significa solamente caract espacio o vacio
                If velem = "¿" AndAlso String.IsNullOrEmpty(donde_buscar.Trim) Then
                    vexiste = True
                    Exit For
                End If

                'si lista valores posibles es # significa un valor numerico (0..9)
                If velem = "#" Then
                    vexiste = True
                    Try
                        If Len(donde_buscar) = 0 Then
                            vexiste = False
                            Exit Try
                        End If
                        For i As Integer = 0 To Len(donde_buscar) - 1
                            If Not Char.IsNumber(donde_buscar(i)) Then
                                vexiste = False
                                Exit Try
                            End If
                        Next
                    Catch ex As Exception
                        vexiste = False
                    End Try
                End If

                'si lista valores posibles es @ significa solamente letras (A..Z,a..z)
                If velem = "@" Then
                    vexiste = True
                    Try
                        If Len(donde_buscar) = 0 Then
                            vexiste = False
                            Exit Try
                        End If
                        For i As Integer = 0 To Len(donde_buscar) - 1
                            If Not Char.IsLetter(donde_buscar(i)) Then
                                vexiste = False
                            End If
                        Next
                    Catch ex As Exception
                        vexiste = False
                    End Try
                End If


            Next
            Return vexiste
        End Function

        Public Function digitos_only(ByVal valor As String) As String
            Dim final As String = ""
            Dim numeros As String = "0123456789"
            For Each letra As Char In valor
                If numeros.Contains(letra) Then
                    final = final & letra
                End If
            Next
            digitos_only = final
        End Function

        Public Function mascara_in(ByVal pvalor As String, ByVal pmascarain As String, Optional ByVal mes As String = "", Optional ByVal ano As String = "") As String
            Dim vvalormedio As String
            vvalormedio = ""

            If pvalor = "" Then
                mascara_in = ""
                Exit Function
            End If

            Select Case pmascarain.Chars(0).ToString.ToUpper

                Case "N" 'tipo numerico
                    Dim vchardec As Char = pmascarain.Chars(1)
                    Dim vcadena As String = ""
                    For Each vchar As Char In pvalor
                        If Char.IsNumber(vchar) Then
                            vcadena = vcadena & vchar
                        ElseIf vchar = "-" Then
                            vcadena = "-" & vcadena
                        ElseIf vchar = vchardec Then
                            vcadena = vcadena & "."
                        End If
                    Next
                    vvalormedio = vcadena

                Case "F" 'tipo fecha
                    Dim vcadyear, vcadmes, vcaddia, vcadmesT As String
                    vcadyear = ""
                    vcadmes = ""
                    vcaddia = ""
                    vcadmesT = ""

                    'variante de la function con un limpieza de inicio cadena hasta llegar a un digito
                    If pmascarain.Substring(1, 1) = "X" Then
                        Dim valor_modificado As String = pvalor
                        Dim i As Integer = 0
                        For Each caracter As Char In pvalor
                            If Char.IsDigit(caracter) Then
                                Exit For
                            End If
                            i += 1
                        Next
                        valor_modificado = valor_modificado.Substring(i)
                        pvalor = valor_modificado
                        If Not Char.IsDigit(pvalor.Substring(1, 1)) Then
                            pvalor = "0" & pvalor
                        End If
                        pmascarain = pmascarain.Substring(1)
                    End If



                    Dim vformato As String = pmascarain.Substring(1)
                    Dim vposicion As Integer

                    If vformato.Trim = "DD/MM/YYYY" AndAlso pvalor.Trim.Length = 9 Then
                        pvalor = "0" & pvalor.Trim
                    End If

                    If pvalor.Length <> 0 Then
                        For Each vchar As Char In vformato
                            vposicion = vposicion + 1
                            If pvalor.Length >= vposicion Then
                                Select Case vchar
                                    Case "Y"
                                        If MyClass.val_posible(pvalor.Chars(vposicion - 1), "0|1|2|3|4|5|6|7|8|9") Then
                                            vcadyear = vcadyear & pvalor.Chars(vposicion - 1)
                                        End If
                                    Case "M"
                                        If MyClass.val_posible(pvalor.Chars(vposicion - 1), "0|1|2|3|4|5|6|7|8|9") Then
                                            vcadmes = vcadmes & pvalor.Chars(vposicion - 1)
                                        End If
                                    Case "D"
                                        If MyClass.val_posible(pvalor.Chars(vposicion - 1), "0|1|2|3|4|5|6|7|8|9") Then
                                            vcaddia = vcaddia & pvalor.Chars(vposicion - 1)
                                        End If
                                    Case "T"
                                        vcadmesT = vcadmesT & pvalor.Chars(vposicion - 1)
                                End Select
                            End If
                        Next
                        If vcadmesT <> "" Then
                            Select Case vcadmesT.ToUpper.Trim.Substring(0, 3)
                                Case "ENE"
                                    vcadmes = "01"
                                Case "FEB"
                                    vcadmes = "02"
                                Case "MAR"
                                    vcadmes = "03"
                                Case "ABR"
                                    vcadmes = "04"
                                Case "MAY"
                                    vcadmes = "05"
                                Case "JUN"
                                    vcadmes = "06"
                                Case "JUL"
                                    vcadmes = "07"
                                Case "AGO"
                                    vcadmes = "08"
                                Case "SEP", "SET"
                                    vcadmes = "09"
                                Case "OCT"
                                    vcadmes = "10"
                                Case "NOV"
                                    vcadmes = "11"
                                Case "DIC"
                                    vcadmes = "12"
                            End Select
                        End If
                        If vcaddia.Length = 1 Then
                            vcaddia = "0" & vcaddia
                        End If
                        If vcadmes.Length = 1 Then
                            vcadmes = "0" & vcadmes
                        End If

                        'caso de que no venga alguno de los valores en la cadena
                        'los toma de parametros (mes y año)
                        If vcadmes.Trim.Length = 0 Then
                            vcadmes = mes.Trim
                        End If

                        If vcadyear.Trim.Length = 0 Then
                            vcadyear = ano.Trim
                        End If

                        If vcadyear.Trim.Length = 1 Then
                            vcadyear = "0" & vcadyear.Trim
                        End If

                        vvalormedio = vcaddia & "/" & vcadmes & "/" & vcadyear

                    End If

                Case "K" 'tipo RUT sin digito verificador - se le genera
                    Dim vcadena As String = ""
                    Try
                        For Each vchar As Char In pvalor
                            If Char.IsNumber(vchar) OrElse vchar.ToString.ToUpper = "K" Then
                                vcadena = vcadena & vchar
                            ElseIf vchar = "-" Then
                                vcadena = vcadena & "-"
                            End If
                        Next
                        'generando digito verif
                        If vcadena.Trim.Length = 6 Then
                            vcadena = "00" & vcadena
                        End If
                        vcadena = vcadena & "-" & obc_rutman.genera_dv(vcadena)

                        'para caso que el primer digito sea cero
                        If vcadena.Trim.Length <> 0 AndAlso vcadena(0) = "0" Then
                            vcadena = vcadena.Substring(1)
                        End If
                    Catch ex As Exception
                        vcadena = "0-0"
                    End Try
                    vvalormedio = vcadena

                Case "R" 'tipo RUT
                    Dim vcadena As String = ""
                    Try
                        For Each vchar As Char In pvalor
                            If Char.IsNumber(vchar) OrElse vchar.ToString.ToUpper = "K" Then
                                vcadena = vcadena & vchar.ToString.ToUpper
                            ElseIf vchar = "-" Then
                                vcadena = vcadena & "-"
                            End If
                        Next

                        'para caso de no tener el - agregarlo
                        If Not vcadena.Contains("-") And vcadena.Trim.Length <> 0 Then
                            vcadena = vcadena.Substring(0, vcadena.Length - 1) & "-" & vcadena.Substring(vcadena.Length - 1, 1)
                        End If

                        If vcadena.Trim.Length = 6 Then
                            vcadena = "00" & vcadena
                        End If

                        'para caso que el primer digito sea cero
                        If vcadena.Trim.Length > 7 AndAlso vcadena(0) = "0" Then
                            vcadena = vcadena.Substring(1)
                        End If
                    Catch ex As Exception
                        vcadena = "0-0"
                    End Try

                    vvalormedio = vcadena


                Case "T"
                    'para hacer trim all, left o right
                    Select Case pmascarain.Substring(1, 1)
                        Case "A"
                            'trim ALL
                            vvalormedio = pvalor.Trim
                        Case "L"
                            'trim left
                            vvalormedio = pvalor.TrimStart
                        Case "R"
                            'trim right
                            vvalormedio = pvalor.TrimEnd
                    End Select

                Case "Z"
                    'parecida a la mascara "C" pero limpia la cadena de caracteres raros 
                    Dim vcadena As String = ""
                    For Each vchar As Char In pvalor
                        If vchar >= Chr(32) Then
                            vcadena &= vchar
                        Else
                            vcadena &= " "
                        End If
                    Next
                    vvalormedio = vcadena

                Case Else 'Se asume que es cadena de caracter simple por lo que se queda como esta
                    vvalormedio = pvalor
            End Select

            Return vvalormedio
        End Function

        Public Function mascara_out(ByRef pvalor As String, ByRef pmascaraout As String) As String
            Dim vvalormedio As String
            Dim vvalor_final As String

            vvalor_final = ""
            vvalormedio = pvalor

            'pasar valor medio a formato mask out
            Select Case pmascaraout.Chars(0).ToString.ToUpper

                Case "C" 'tipo cadena de caracteres
                    'limpiar la cadena de caracteres no validos & < > " '
                    vvalormedio = vvalormedio.Replace("&amp;", "&")
                    vvalormedio = vvalormedio.Replace("&lt;", "<")
                    vvalormedio = vvalormedio.Replace("&gt;", ">")
                    vvalormedio = vvalormedio.Replace("&quot;", """")
                    vvalormedio = vvalormedio.Replace("&apos;", "'")
                    vvalormedio = vvalormedio.Replace("&", "&amp;") 'lo hace el XMLTextWriter automaticamente al crear el XML
                    vvalormedio = vvalormedio.Replace("<", "&lt;")  'lo hace el XMLTextWriter automaticamente al crear el XML
                    vvalormedio = vvalormedio.Replace(">", "&gt;")  'lo hace el XMLTextWriter automaticamente al crear el XML
                    vvalormedio = vvalormedio.Replace("""", "&quot;")
                    vvalormedio = vvalormedio.Replace("'", "&apos;")
                    vvalor_final = vvalormedio

                Case "N" 'tipo numerico
                    Dim vsigno As Char = pmascaraout.Chars(1)
                    Dim vdecimales As Char = pmascaraout.Chars(2)
                    Dim vporciento As Char = pmascaraout.Chars(3)
                    Dim vvalor As Decimal

                    vvalor = Val(vvalormedio)
                    'cambiar el signo
                    Select Case vsigno
                        Case "*"
                            vvalor = Val(vvalormedio)
                        Case "-"
                            If Val(vvalormedio) > 0 Then
                                vvalor = Val(vvalormedio) * (-1)
                            End If
                        Case "+"
                            If Val(vvalormedio) < 0 Then
                                vvalor = Val(vvalormedio) * (-1)
                            End If
                        Case "/"
                            vvalor = Val(vvalormedio) * (-1)
                    End Select

                    'cambiar los decimales
                    vvalor = Decimal.Round(vvalor, Val(vdecimales), MidpointRounding.AwayFromZero)

                    'cambiar a estilo a porciento
                    If vporciento = "#" Then
                        vvalor = vvalor * 100
                    ElseIf vporciento = "%" Then
                        vvalor = vvalor / 100
                    End If

                    'Quitar la coma del decimal y poner punto 
                    Dim vcon_coma As String = vvalor.ToString
                    Dim vcon_punto As String = ""

                    For Each letra As Char In vcon_coma
                        If letra = "," Then
                            vcon_punto = vcon_punto & "."
                        Else
                            vcon_punto = vcon_punto & letra
                        End If
                    Next

                    vvalor_final = vcon_punto

                Case "F" 'tipo fecha
                    If pvalor.Length > 6 Then
                        Dim vcaddia As String = vvalormedio.Substring(0, 2)
                        Dim vcadmes As String = vvalormedio.Substring(3, 2)
                        Dim vcadyear As String = vvalormedio.Substring(6)

                        Dim vmascara As String = pmascaraout.Substring(1)
                        vvalor_final = ""
                        Dim vposicion As Integer = -1
                        For Each vchar As Char In vmascara
                            vposicion = vposicion + 1
                            Select Case vchar.ToString.ToUpper
                                Case "D"
                                    vvalor_final = vvalor_final & vcaddia
                                Case "M"
                                    vvalor_final = vvalor_final & vcadmes
                                Case "2"
                                    If vcadyear.Length = 2 Then
                                        vvalor_final = vvalor_final & vcadyear
                                    Else
                                        vvalor_final = vvalor_final & vcadyear.Substring(2)
                                    End If
                                Case "4"
                                    If vcadyear.Length = 4 Then
                                        vvalor_final = vvalor_final & vcadyear
                                    Else
                                        vvalor_final = vvalor_final & "20" & vcadyear
                                    End If
                                Case Else
                                    vvalor_final = vvalor_final & vchar

                            End Select
                        Next
                    End If

                Case "R" 'tipo RUT
                    If MyClass.countchar("-", vvalormedio) = 0 Then
                        Try
                            vvalor_final = vvalormedio.Substring(1, vvalormedio.Length - 1) & "-" & vvalormedio.Chars(vvalormedio.Length).ToString.ToUpper
                        Catch ex As Exception
                            vvalor_final = "0000000-0"
                        End Try
                    Else
                        vvalor_final = vvalormedio.ToUpper
                    End If

            End Select
            Return vvalor_final
        End Function

        Public Function compara(ByVal elemA As Object, ByVal operador As String, ByVal elemB As Object, ByVal vtipo As Char) As Boolean
            Dim va, vb As Object
            If UCase(vtipo) = "N" Then
                Dim vax As String = UCase(Trim(CType(elemA, String)))
                Dim vbx As String = UCase(Trim(CType(elemB, String)))
                va = Val(vax)
                vb = Val(vbx)
            Else
                va = UCase(Trim(CType(elemA, String)))
                vb = UCase(Trim(CType(elemB, String)))
            End If
            Select Case operador
                Case "="
                    If va = vb Then
                        Return True
                    Else
                        Return False
                    End If
                Case "<"
                    If va < vb Then
                        Return True
                    Else
                        Return False
                    End If
                Case "<="
                    If va <= vb Then
                        Return True
                    Else
                        Return False
                    End If
                Case ">"
                    If va > vb Then
                        Return True
                    Else
                        Return False
                    End If
                Case ">="
                    If va >= vb Then
                        Return True
                    Else
                        Return False
                    End If
                Case "<>"
                    If va <> vb Then
                        Return True
                    Else
                        Return False
                    End If
            End Select
            Return False
        End Function

        Public Function newIDunico() As String
            Randomize()
            Dim vnumerico As Integer = CInt(Int((1000 * Rnd()) + 1))
            Dim vnumerico2 As Integer = CInt(Int((1000 * Rnd()) + 1))
            Return Now.Year.ToString & Now.DayOfYear.ToString & Now.Hour.ToString & Now.Minute.ToString & Now.Second.ToString & Now.Millisecond.ToString & vnumerico.ToString & vnumerico2.ToString
        End Function


        Public Function newname_file(ByVal pextension As String) As String
            Dim vnombre As String
            Randomize()
            Dim vnumerico As Integer = CInt(Int((1000 * Rnd()) + 1))
            Dim vnumerico2 As Integer = CInt(Int((1000 * Rnd()) + 1))
            vnombre = "tmp" & Now.Year.ToString & "-" & Now.DayOfYear.ToString & "-" & Now.Hour.ToString & "-" & Now.Minute.ToString & "-" & Now.Second.ToString & "-" & Now.Millisecond.ToString & "-" & vnumerico.ToString & "-" & vnumerico2.ToString & pextension
            newname_file = vnombre
        End Function

        Public Function pon_ceros_delante(ByVal numero As String, ByVal largo As Integer) As String
            Dim respuesta As String = numero.Trim
            Do While Len(respuesta) < largo
                respuesta = "0" & respuesta
            Loop
            Return respuesta
        End Function

        Public Function pon_espacios_detras(ByVal dato As String, ByVal largo As Integer) As String
            Dim respuesta As String = dato.Trim
            Do While Len(respuesta) < largo
                respuesta = respuesta & " "
            Loop
            Return respuesta
        End Function

        Public Function pon_espacios_delante(ByVal dato As String, ByVal largo As Integer) As String
            Dim respuesta As String = dato.Trim
            Do While Len(respuesta) < largo
                respuesta = " " & respuesta
            Loop
            Return respuesta
        End Function

        Public Function cadena_limpia(ByVal cadena As String) As String
            Dim resultado As String = ""
            Dim sb As New System.Text.StringBuilder()
            sb.Append(cadena)
            sb.Replace(Chr(13), "")
            sb.Replace(Chr(10), "")
            sb.Replace(Chr(12), "")
            Return sb.ToString
        End Function

        Public Function bytes2string(ByVal contenido() As Byte) As String
            Dim respuesta As String = ""
            Dim codificador As System.Text.Encoding = System.Text.Encoding.Unicode
            Try
                respuesta = codificador.GetString(contenido)
            Catch ex As Exception
                respuesta = ""
            End Try
            Return respuesta
        End Function

        Public Function bytes2string_ANSI(ByVal contenido() As Byte) As String
            Dim respuesta As String = ""
            Dim codificador As System.Text.Encoding = System.Text.Encoding.Default
            Try
                respuesta = codificador.GetString(contenido)
            Catch ex As Exception
                respuesta = ""
            End Try
            Return respuesta
        End Function

        Public Function string2bytes(ByVal cadena As String) As Byte()
            Dim codificador As System.Text.Encoding = System.Text.Encoding.Unicode
            Dim contenido() As Byte = codificador.GetBytes(cadena)
            Return contenido
        End Function


        Public Shared Function es_vacio_o_cero(ByVal valor As String) As Boolean
            If valor.Trim.Length = 0 Then
                Return True
            ElseIf valor.Trim = "0" Then
                Return True
            Else
                Return False
            End If
        End Function


    End Class
End Namespace

