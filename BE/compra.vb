Public Class comprar
    Dim fecha As String
    Dim folio As Integer
    Dim tipodoc As Integer
    Dim rut_preveedor As String
    Dim neto As Integer
    Dim iva As Integer
    Dim total As Integer
    Dim codigo As String
    Dim descripcion As String
    Dim cantidad As Integer
    Dim precio As Integer
    Dim total_detalle As Integer
    Dim id_cab As Integer

    Public Property get_fecha
        Get
            Return fecha
        End Get
        Set(ByVal value)
            fecha = value
        End Set
    End Property
    Public Property get_folio
        Get
            Return folio
        End Get
        Set(ByVal value)
            folio = value
        End Set
    End Property
    Public Property get_tipodoc
        Get
            Return tipodoc
        End Get
        Set(ByVal value)
            tipodoc = value
        End Set
    End Property
    Public Property get_rut_preveedor
        Get
            Return rut_preveedor
        End Get
        Set(ByVal value)
            rut_preveedor = value
        End Set
    End Property
    Public Property get_neto
        Get
            Return neto
        End Get
        Set(ByVal value)
            neto = value
        End Set
    End Property
    Public Property get_iva
        Get
            Return iva
        End Get
        Set(ByVal value)
            iva = value
        End Set
    End Property
    Public Property get_total
        Get
            Return total
        End Get
        Set(ByVal value)
            total = value
        End Set
    End Property
    Public Property get_codigo
        Get
            Return codigo
        End Get
        Set(ByVal value)
            codigo = value
        End Set
    End Property
    Public Property get_descripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property
    Public Property get_cantidad
        Get
            Return cantidad
        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property
    Public Property get_precio
        Get
            Return precio
        End Get
        Set(ByVal value)
            precio = value
        End Set
    End Property
    Public Property get_total_detalle
        Get
            Return total_detalle
        End Get
        Set(ByVal value)
            total_detalle = value
        End Set
    End Property
    Public Property get_id_cab
        Get
            Return id_cab
        End Get
        Set(ByVal value)
            id_cab = value
        End Set
    End Property

    Public Sub New(ByVal fecha As String, ByVal folio As Integer, ByVal tipodoc As Integer, ByVal rut_preveedor As String, ByVal neto As Integer, ByVal iva As Integer, ByVal total As Integer, ByVal codigo As String, ByVal descripcion As String, ByVal cantidad As Integer, ByVal precio As Integer, ByVal total_detalle As Integer, ByVal id_cab As Integer)

        get_fecha = fecha
        get_folio = folio
        get_tipodoc = tipodoc
        get_rut_preveedor = rut_preveedor
        get_neto = neto
        get_iva = iva
        get_total = total
        get_codigo = codigo
        get_descripcion = descripcion
        get_cantidad = cantidad
        get_precio = precio
        get_total_detalle = total_detalle
        get_id_cab = id_cab

    End Sub

    Public Sub New()

    End Sub
End Class
