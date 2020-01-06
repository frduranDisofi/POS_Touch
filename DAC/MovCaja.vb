Namespace POS
    Public Class MovCaja

        'Private oConfig As New GLB.config
        'Private oUsuarios As Usuarios
        'Private oEstacion As Estaciones
        'Private oSucursal As Sucursal
        Private vIDUsuario As String
        Private vNumSecApertura As Long


        'Public Sub New(Pconfig As GLB.config, IDUsuario As String)
        'Me.oConfig = Pconfig
        'Me.vIDUsuario = IDUsuario
        ''oSucursal = New Sucursal(oConfig)
        ''oEstacion = New Estaciones(oConfig)
        'Dim vresp As String = ""

        'vresp = Me.oEstacion.getInfo(Me.oConfig.IDEstacion)
        'If vresp <> "OK" Then
        '    Exit Sub
        'End If

        'vresp = oSucursal.getInfo(Me.oConfig.IDSucursal)
        'If vresp <> "OK" Then
        '    Exit Sub
        'End If

        'Me.vNumSecApertura = 0

        ' End Sub

        'Public Function Apertura(Monto As Long, Nota As String) As String
        '    'Dim osql As New dac.myMSSQL(Me.oConfig.conexDB, Me.oConfig.TimeOutSQL)
        '    'osql.paramQUERY.Add("Sucursal", Me.oSucursal.DatoSucursal.IDSucursal)
        '    'osql.paramQUERY.Add("Estacion", Me.oEstacion.DatoEstacion.IDEstacion)
        '    'osql.paramQUERY.Add("Fecha", Now.ToString("yyyy-MM-dd"))
        '    'osql.paramQUERY.Add("Hora", Now.ToString("HH:mm"))
        '    'osql.paramQUERY.Add("Usuario", Me.vIDUsuario)
        '    'osql.paramQUERY.Add("Nota", Nota)
        '    'osql.paramQUERY.Add("Monto", Monto)
        '    'Dim vresp As String = osql.GetValorNoNull("crea_Apertura")
        '    'If osql.DioError Then
        '    '    Return osql.MsgError
        '    'End If
        '    'Return vresp
        'End Function

        'Public Function SaldoEfectivoActual() As Long
        '    'Dim osql As New dac.myMSSQL(Me.oConfig.conexDB, Me.oConfig.TimeOutSQL)
        '    'osql.paramQUERY.Add("Sucursal", Me.oSucursal.DatoSucursal.IDSucursal)
        '    'osql.paramQUERY.Add("Estacion", Me.oEstacion.DatoEstacion.IDEstacion)
        '    'osql.paramQUERY.Add("Usuario", Me.vIDUsuario)
        '    'Dim vresp As Long = osql.GetValorNoNull("pos.get_efectivo_actual")
        '    'If osql.DioError Then
        '    '    Return 0
        '    'End If
        '    'Return vresp
        'End Function


        Public Function Retiro(listaDoc As List(Of ListaDOC_Retiro), Nota As String, Banco As String) As String
            'Dim osql As New dac.myMSSQL(Me.oConfig.conexDB, Me.oConfig.TimeOutSQL)
            'osql.paramQUERY.Add("Sucursal", Me.oSucursal.DatoSucursal.IDSucursal)
            'osql.paramQUERY.Add("Estacion", Me.oEstacion.DatoEstacion.IDEstacion)
            'osql.paramQUERY.Add("Fecha", Now.ToString("yyyy-MM-dd"))
            'osql.paramQUERY.Add("Hora", Now.ToString("HH:mm"))
            'osql.paramQUERY.Add("Usuario", Me.vIDUsuario)
            'osql.paramQUERY.Add("Nota", Nota)
            'osql.paramQUERY.Add("Banco", Banco)
            'Dim vNumSec As Long = osql.GetValorNoNull("pos.crea_Retiro")
            'If osql.DioError Then
            '    Return osql.MsgError
            'End If

            Dim vresp As String = ""
            For Each elem In listaDoc
                'osql.paramQUERY.Clear()
                'osql.paramQUERY.Add("Sucursal", Me.oSucursal.DatoSucursal.IDSucursal)
                'osql.paramQUERY.Add("NumSec", vNumSec)
                'osql.paramQUERY.Add("MetodoPago", elem.MetodoPago)
                'osql.paramQUERY.Add("Monto", elem.Monto)
                'osql.paramQUERY.Add("NumTrans", elem.NumTrans)
                'osql.paramQUERY.Add("elemento", elem.elemento)
                'osql.paramQUERY.Add("NumRec", elem.NumRec)

                'vresp = osql.GetValorNoNull("pos.crea_DetalleRetiro")
                'If osql.DioError Then
                '    vresp = osql.MsgError
                'End If
                'If vresp <> "OK" Then
                '    osql.paramQUERY.Clear()
                '    'osql.paramQUERY.Add("Sucursal", Me.oSucursal.DatoSucursal.IDSucursal)
                '    osql.paramQUERY.Add("NumSec", vNumSec)
                '    osql.Ejecuta("pos.borra_MovCaja")
                '    Return vresp
                'End If
            Next

            'osql.paramQUERY.Clear()
            'osql.paramQUERY.Add("Sucursal", Me.oSucursal.DatoSucursal.IDSucursal)
            'osql.paramQUERY.Add("NumSec", vNumSec)
            'osql.Ejecuta("pos.activarSync_Retiro")


            Return "OK"
        End Function

        Private vError_cierre As String

        Public ReadOnly Property Error_cierre As String
            Get
                Return vError_cierre
            End Get
        End Property

        Public ReadOnly Property NumSecApertura As Long
            Get
                Return vNumSecApertura
            End Get
        End Property

        ''' <summary>
        ''' Retorna el nummero de NumSec en Tabla MovCaja
        ''' </summary>
        ''' <param name="Nota"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Cierre(Nota As String) As Long
            Dim vNumSec As Long = 0
            'Dim osql As New dac.myMSSQL(Me.oConfig.conexDB, Me.oConfig.TimeOutSQL)
            'osql.paramQUERY.Add("Sucursal", Me.oSucursal.DatoSucursal.IDSucursal)
            ' osql.paramQUERY.Add("Estacion", Me.oEstacion.DatoEstacion.IDEstacion)
            ' osql.paramQUERY.Add("Usuario", Me.vIDUsuario)
            'Me.vNumSecApertura = osql.GetValorNoNull("pos.get_ultimaApertura")
            'If osql.DioError Then
            '    Me.vError_cierre = osql.MsgError
            '    Return 0
            'End If

            'osql.paramQUERY.Clear()
            'osql.paramQUERY.Add("Sucursal", Me.oSucursal.DatoSucursal.IDSucursal)
            'osql.paramQUERY.Add("Estacion", Me.oEstacion.DatoEstacion.IDEstacion)
            'osql.paramQUERY.Add("Fecha", Now.ToString("yyyy-MM-dd"))
            'osql.paramQUERY.Add("Hora", Now.ToString("HH:mm"))
            'osql.paramQUERY.Add("Usuario", Me.vIDUsuario)
            'osql.paramQUERY.Add("Nota", Nota)
            'vNumSec = osql.GetValorNoNull("pos.crea_Cierre")
            'If osql.DioError Then
            '    vNumSec = 0
            '    Me.vError_cierre = osql.MsgError
            'End If
            'If IsNothing(vNumSec) Then
            '    Me.vError_cierre = "No se pudo almacenar el cierre en la DB"
            '    vNumSec = 0
            'End If


            Return vNumSec

        End Function
    End Class

    Public Class ListaDOC_Retiro
        Public MetodoPago As Integer
        Public Monto As Long
        Public NumTrans As Long
        Public elemento As Integer
        Public NumRec As Long
    End Class

End Namespace
