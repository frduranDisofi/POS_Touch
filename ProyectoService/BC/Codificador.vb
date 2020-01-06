Imports System
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography

Namespace bc
    Public Class Encryption64
        Private key() As Byte
        Private IV() As Byte = {&H12, &H34, &H66, &H78, &H90, &HAB, &HCD, &HEF}

        Public Function DecryptFromBase64String(ByVal stringToDecrypt As String, ByVal sEncryptionKey As String) As String
            Dim inputByteArray(stringToDecrypt.Length) As Byte
            Try
                key = System.Text.Encoding.UTF8.GetBytes(sEncryptionKey)
                Dim des As New TripleDESCryptoServiceProvider
                inputByteArray = Convert.FromBase64String(stringToDecrypt)
                Dim ms As New MemoryStream
                Dim cs As New CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write)
                cs.Write(inputByteArray, 0, inputByteArray.Length)
                cs.FlushFinalBlock()
                Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
                Return encoding.GetString(ms.ToArray())
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
        Public Function EncrypToBase64String(ByVal stringToEncrypt As String, ByVal SEncryptionKey As String) As String
            Try
                key = System.Text.Encoding.UTF8.GetBytes(SEncryptionKey)
                Dim des As New TripleDESCryptoServiceProvider
                Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(stringToEncrypt)
                Dim ms As New MemoryStream
                Dim cs As New CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write)
                cs.Write(inputByteArray, 0, inputByteArray.Length)
                cs.FlushFinalBlock()
                Return Convert.ToBase64String(ms.ToArray())
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
    End Class

End Namespace
