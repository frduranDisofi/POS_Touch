Namespace dac
    Public Class Licencia
        'Public num_licencia As Long
        'Public rut_empresa As String
        'Public name_empresa As String
        Public key_soft As Integer = 2

        Public Function licencia_valida(ByVal rut_empresa As String, ByVal name_empresa As String, ByVal num_licencia As Long) As Boolean
            Dim empresa As String = name_empresa.ToUpper.Trim
            Dim tempo As String = Asc(empresa.Substring(1, 1)) & Asc(empresa.Substring(Int(empresa.Length / 2) - 1, 1)) & Asc(empresa.Substring(empresa.Length - 2, 1))
            Dim licencia_calc As Long
            Dim letra As Char
            Dim rutempresa As String = ""
            For Each letra In rut_empresa
                If letra <> "-" And letra <> "K" Then
                    rutempresa = rutempresa + letra
                End If
            Next

            licencia_calc = (Val(tempo) + Val(rutempresa) + empresa.Trim.Length) * key_soft
            If licencia_calc = num_licencia Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Function genkey(ByVal name_empresa As String, ByVal rut_empresa As String) As Long
            Dim empresa As String = name_empresa.ToUpper.Trim
            Dim tempo As String = Asc(empresa.Substring(1, 1)) & Asc(empresa.Substring(Int(empresa.Length / 2) - 1, 1)) & Asc(empresa.Substring(empresa.Length - 2, 1))
            Dim licencia_calc As Long
            Dim letra As Char
            'Dim num_licencia As Long
            Dim rutempresa As String = ""
            For Each letra In rut_empresa
                If letra <> "-" And letra <> "K" Then
                    rutempresa = rutempresa + letra
                End If
            Next
            licencia_calc = (Val(tempo) + Val(rutempresa) + empresa.Trim.Length) * Me.key_soft
            'If actualiza_licencia Then
            '    num_licencia = licencia_calc
            'End If
            Return licencia_calc
        End Function

    End Class
End Namespace

