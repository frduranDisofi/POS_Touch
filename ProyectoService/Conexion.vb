Imports System.IO
Imports System.Data.SqlClient

Public Class Conexion
    Private _con As SqlConnection
    Public Property con As SqlConnection
        Get
            Return _con
        End Get
        Set(value As SqlConnection)
            _con = value
        End Set
    End Property
    Public Function Conexion(Optional ByVal base As Integer = 0) As Boolean
        Dim RutaTxt As String = "c:\POS\POS.txt"
        Dim fs As FileStream
        If Not File.Exists(RutaTxt) Then
            fs = File.Create(RutaTxt)
            fs.Close()
            Dim conexDB As String = "Data Source=192.168.0.200;Initial Catalog=delivery;Persist Security Info=True;User ID=sa;Password=Alternativa3;"
            'Dim conexDB As String = "Data Source=.;Initial Catalog=delivery;Persist Security Info=True;User ID= sa;Password= 1234;"
            Try
                Dim escribe As New StreamWriter(RutaTxt)
                escribe.WriteLine(conexDB)
                escribe.Close()
            Catch ex As Exception
            End Try
        End If
        Dim ConexReal As String = ""
        ConexReal = Iniciar(RutaTxt)

        Dim Resp As Boolean = False
        Try
            If base = 0 Then
                _con = New SqlConnection(ConexReal)
            Else
                _con = New SqlConnection(ConexReal)
            End If
            _con.Open()
            Resp = True
        Catch ex As Exception
            Resp = False
        End Try
        Return Resp
    End Function
    Public Sub Desconectar()
        Try
            _con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private _da As SqlDataAdapter
    Public Property da As SqlDataAdapter
        Get
            Return _da
        End Get
        Set(value As SqlDataAdapter)
            _da = value
        End Set
    End Property
    Private Function Iniciar(ByVal RutaTxt As String) As String
        Dim obc_Codificador As New bc.Encryption64
        Dim oTxt As New bc.archivotxt
        oTxt.add_filetxt(RutaTxt, False)
        Dim resultado As String = ""
        If oTxt.get_linea(1).ToUpper.IndexOf("SOURCE") > 0 Then
            resultado = oTxt.get_linea(1)
            Dim textoChino As String = obc_Codificador.EncrypToBase64String(resultado.Trim, "MasD1f1c1lP455wD")
            oTxt.del_linea(1)
            oTxt.ins_linea(1, textoChino)
            oTxt.save_tofile(RutaTxt)
        Else
            resultado = obc_Codificador.DecryptFromBase64String(oTxt.get_linea(1), "MasD1f1c1lP455wD")
        End If
        Return resultado
    End Function
End Class
