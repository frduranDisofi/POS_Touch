Namespace bc
    Public Class RUTman
        Public Function check_es_valido(ByVal varRut As String) As Boolean
            Dim strTrab1 As String, intNumRutCar As Integer, strComodin As String
            Dim intSuma As Integer, intLooping As Integer
            Dim intMultiplo As Integer, intComodin As Integer

            intNumRutCar = Len(varRut)
            intLooping = 1
            intMultiplo = 3
            If varRut.EndsWith("-") Then
                varRut = varRut.Substring(0, varRut.Length - 1)
            End If

            'para RUTs cortos que le faltan los ceros delante
            Do While Len(varRut) < 10
                varRut = "0" & varRut
            Loop
            intNumRutCar = Len(varRut) ' antes tenia =10

            Try
                If varRut <> "00000000-0" And varRut <> "0000000-0" Then
                    If intNumRutCar >= 8 And intNumRutCar <= 11 Then
                        strComodin = Mid(varRut, (intNumRutCar), 1)
                        If Asc(Mid(varRut, (intNumRutCar - intLooping), 1)) = 45 Then
                            intLooping = intLooping + 1
                            varRut = Mid(varRut, 1, intNumRutCar - intLooping)
                        Else
                            varRut = Mid(varRut, 1, intNumRutCar - intLooping)
                        End If
                        intLooping = 0
                        If Len(varRut) = 8 Then
                            intMultiplo = intMultiplo
                            strTrab1 = Mid(varRut, 1 + intLooping, 1)
                            intSuma = intSuma + (strTrab1 * intMultiplo)
                            intLooping = intLooping + 1
                        End If
                        intMultiplo = intMultiplo - 1
                        strTrab1 = Mid(varRut, 1 + intLooping, 1)
                        intSuma = intSuma + (strTrab1 * intMultiplo)
                        intLooping = intLooping + 1 : intMultiplo = intMultiplo + 5

                        Do While True
                            If intLooping = Len(varRut) Then
                                Exit Do
                            End If
                            strTrab1 = Mid(varRut, 1 + intLooping, 1)
                            intSuma = intSuma + (strTrab1 * intMultiplo)
                            intLooping = intLooping + 1
                            intMultiplo = intMultiplo - 1
                        Loop

                        intSuma = intSuma Mod 11
                        intSuma = 11 - intSuma
                        If strComodin >= "0" Or strComodin <= "9" Or strComodin = "K" Or strComodin = "k" Then
                            If strComodin = "K" Or strComodin = "k" Then
                                intComodin = 10
                            Else
                                If strComodin = "0" Then
                                    intComodin = 11
                                Else
                                    intComodin = strComodin
                                End If
                            End If
                            If intSuma = intComodin Then
                                If Len(varRut) = 7 Then
                                    varRut = "0" & varRut & strComodin
                                Else
                                    varRut = varRut & strComodin
                                End If
                            Else
                                'MsgBox "RUT ERRONEO"
                                Return False
                                Exit Function
                            End If
                        End If
                    Else
                        Return False
                        Exit Function
                    End If
                Else
                    Return False
                    Exit Function
                End If
            Catch ex As Exception
                Return False
                Exit Function
            End Try

            Return True
        End Function

        Public Function genera_dv(ByVal prut As String) As Char
            Dim cant As Integer = Len(prut)
            Dim cad As String = prut

            Dim v1 As Integer = Val(Mid(cad, 1, 1))
            Dim v2 As Integer = Val(Mid(cad, 2, 1))
            Dim v3 As Integer = Val(Mid(cad, 3, 1))
            Dim v4 As Integer = Val(Mid(cad, 4, 1))
            Dim v5 As Integer = Val(Mid(cad, 5, 1))
            Dim v6 As Integer = Val(Mid(cad, 6, 1))
            Dim v7 As Integer = Val(Mid(cad, 7, 1))
            Dim v8 As Integer = Val(Mid(cad, 8, 1))
            Dim v9 As Integer

            If cant = 9 Then
                v9 = Val(Mid(cad, 9, 1))
            Else
                v9 = 0
            End If

            If cant = 7 Then
                v1 = v1 * 2
                v2 = v2 * 7
                v3 = v3 * 6
                v4 = v4 * 5
                v5 = v5 * 4
                v6 = v6 * 3
                v7 = v7 * 2
                v8 = v8 * 1
            Else
                v1 = v1 * 3
                v2 = v2 * 2
                v3 = v3 * 7
                v4 = v4 * 6
                v5 = v5 * 5
                v6 = v6 * 4
                v7 = v7 * 3
                v8 = v8 * 2
            End If

            Dim vt As Integer
            vt = v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9
            Dim vr1 As Integer
            vr1 = vt Mod 11
            Dim vr2 As Integer
            vr2 = 11 - Vr1

            Dim dv As Char
            Select Case vr2
                Case 10
                    dv = "K"
                Case 11
                    dv = "0"
                Case Else
                    dv = CChar(CStr(vr2))
            End Select
            Return dv
        End Function


    End Class
End Namespace

