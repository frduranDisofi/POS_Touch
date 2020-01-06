Public Class Oferta
    Dim codigoOferta As String
    Dim nombreOferta As String
    Dim precioOferta As Integer
    'producto oferta
    Dim descripcion As String
    Dim codigoInt As String
    Dim codigo As String
    Dim Cod_FamiliaProducto As String
    Dim NombreFamilia As String
    Dim idproducto As Integer

    Public Property get_codigoOferta
        Get
            Return codigoOferta
        End Get
        Set(ByVal value)
            codigoOferta = value
        End Set
    End Property

    Public Property get_nombreOferta
        Get
            Return nombreOferta
        End Get
        Set(ByVal value)
            nombreOferta = value
        End Set
    End Property

    Public Property get_precioOferta
        Get
            Return precioOferta
        End Get
        Set(ByVal value)
            precioOferta = value
        End Set
    End Property

    Public Property get_descripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Property get_codigoInt
        Get
            Return codigoInt
        End Get
        Set(value)
            codigoInt = value
        End Set
    End Property
    Public Property get_codigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property
    Public Property get_Cod_FamiliaProducto
        Get
            Return Cod_FamiliaProducto
        End Get
        Set(value)
            Cod_FamiliaProducto = value
        End Set
    End Property
    Public Property get_NombreFamilia
        Get
            Return NombreFamilia
        End Get
        Set(value)
            NombreFamilia = value
        End Set
    End Property
    Public Property get_idproducto
        Get
            Return idproducto
        End Get
        Set(value)
            idproducto = value
        End Set
    End Property

    Public Sub New(ByVal codigoOferta As String, ByVal nombreOferta As String, ByVal precioOferta As Integer, ByVal descripcion As String, ByVal codigoInt As String, ByVal codigo As String, ByVal Cod_FamiliaProducto As String, ByVal NombreFamilia As String, ByVal idproducto As Integer)
        get_codigoOferta = codigoOferta
        get_nombreOferta = nombreOferta
        get_precioOferta = precioOferta

        get_descripcion = descripcion
        get_codigoInt = codigoInt
        get_codigo = codigo
        get_Cod_FamiliaProducto = Cod_FamiliaProducto
        get_NombreFamilia = NombreFamilia
        get_idproducto = idproducto
    End Sub
    Public Sub New()

    End Sub
End Class
