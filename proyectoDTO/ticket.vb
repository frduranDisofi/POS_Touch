Public Class ticket
    Dim fecha As String
    Dim forma_pago As String
    Dim total As Integer
    Dim efectivo As Integer
    Dim descricpion As String
    Dim cantidad As Integer
    Dim precio As Integer
    Dim total_item As Integer
    Dim id_doc As Integer
    Dim codigo As String

    Public Property get_fecha
        Get
            Return fecha
        End Get
        Set(ByVal value)
            fecha = value
        End Set
    End Property
    Public Property get_forma_pago
        Get
            Return forma_pago
        End Get
        Set(ByVal value)
            forma_pago = value
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
    Public Property get_efectivo
        Get
            Return efectivo
        End Get
        Set(ByVal value)
            efectivo = value
        End Set
    End Property
    Public Property get_descripcion
        Get
            Return descricpion
        End Get
        Set(ByVal value)
            descricpion = value
        End Set
    End Property
    Public Property get_cantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property
    Public Property get_precio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property
    Public Property get_total_item
        Get
            Return total_item
        End Get
        Set(value)
            total_item = value
        End Set
    End Property
    Public Property get_id_doc
        Get
            Return id_doc
        End Get
        Set(value)
            id_doc = value
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
    Private _Idusuario As Integer
    Public Property idUsuario As Integer
        Get
            Return _Idusuario
        End Get
        Set(value As Integer)
            _Idusuario = value
        End Set
    End Property
    Public Sub New(ByVal fecha As String, ByVal forma_pago As String, ByVal total As Integer, ByVal efectivo As Integer, ByVal descripcion As String, ByVal cantidad As Integer, ByVal precio As Integer, ByVal total_item As Integer, ByVal id_doc As Integer, ByVal codigo As Integer)
        get_fecha = fecha
        get_forma_pago = forma_pago
        get_total = total
        get_efectivo = efectivo
        get_descripcion = descripcion
        get_cantidad = cantidad
        get_precio = precio
        get_total_item = total_item
        get_id_doc = id_doc
        get_codigo = codigo
    End Sub

    Public Sub New()

    End Sub

End Class
