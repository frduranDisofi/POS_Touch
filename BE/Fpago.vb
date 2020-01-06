Public Class Fpago
    Public Function agregarFpago(ByVal fpago As String) As Boolean
        Dim resp As Boolean
        Dim sql As String
        Dim conn As New conexion
        sql = "insert into forma_pago(formapago)values('" & fpago & "')"
        resp = conn.EjecutaSQL(sql)
        Return resp
    End Function
    Public Function traerFpago() As DataTable
        Dim dt As DataTable
        Dim sql As String
        Dim conn As New conexion
        sql = "select id,formapago from forma_pago order by formapago asc"
        dt = conn.traerDataTable(sql)
        Return dt
    End Function
    Public Function editarFpago(ByVal fpago As String, ByVal id As Integer) As Boolean
        Dim resp As Boolean
        Dim sql As String
        Dim conn As New conexion
        sql = "update forma_pago set formapago = '" & fpago & "' where id=" & id & ""
        resp = conn.EjecutaSQL(sql)
        Return resp
    End Function
    Public Function traerFpagoId(ByVal id As Integer) As DataTable
        Dim dt As DataTable
        Dim sql As String
        Dim conn As New conexion
        sql = "select formapago from forma_pago where id=" & id & ""
        dt = conn.traerDataTable(sql)
        Return dt
    End Function
    Public Function eliminarFpago(ByVal id As String) As Boolean
        Dim resp As Boolean
        Dim sql As String
        Dim conn As New conexion
        sql = "delete from forma_pago where id=" & id & ""
        resp = conn.EjecutaSQL(sql)
        Return resp
    End Function
End Class
