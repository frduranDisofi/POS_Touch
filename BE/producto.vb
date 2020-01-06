Public Class producto
    Dim codigo As String
    Dim descripcion As String
    Dim precio As String
    Dim codigoInt As String
    Dim Cod_FamiliaProducto As String
    Dim NombreFamilia As String

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
    Public Property get_precio
        Get
            Return precio
        End Get
        Set(ByVal value)
            precio = value
        End Set
    End Property
    Public Property get_codigoInt
        Get
            Return codigoInt
        End Get
        Set(ByVal value)
            codigoInt = value
        End Set
    End Property
    Public Property get_Familia
        Get
            Return Cod_FamiliaProducto
        End Get
        Set(ByVal value)
            Cod_FamiliaProducto = value
        End Set
    End Property
    Public Property get_NombreFamilia
        Get
            Return NombreFamilia
        End Get
        Set(ByVal value)
            NombreFamilia = value
        End Set
    End Property
    Public Sub New(ByVal codigo As String, ByVal descripcion As String, ByVal precio As Integer, ByVal codigoInt As String, ByVal Cod_FamiliaProducto As String, ByVal NombreFamilia As String)
        get_codigo = codigo
        get_descripcion = descripcion
        get_precio = precio
        get_codigoInt = codigoInt
        get_Familia = Cod_FamiliaProducto
        get_NombreFamilia = NombreFamilia
    End Sub
    Public Sub New()

    End Sub
End Class
