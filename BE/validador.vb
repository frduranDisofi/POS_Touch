Public Class validador
    Public Shared Function validoNumero(numero As String, CantDecimales As Integer) As Boolean
        numero = numero.Trim
        If numero.Length = 0 Then
            Return False
        End If
        If Not IsNumeric(numero) Then
            Return False
        End If
        If Not numero.Contains(".") And numero.Length > 11 Then
            Return False
        End If
        If numero.Contains(".") AndAlso numero.Substring(0, numero.IndexOf(".")).Length > 11 Then
            Return False
        End If
        If numero.Contains(".") AndAlso numero.Substring(numero.IndexOf(".")).Length > CantDecimales Then
            Return False
        End If
        Return True
    End Function
End Class
