Imports ProyectoNegocio
Public Class InfoProductos

    Private Sub InfoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.uic_FechaIni.Value = Now
        Me.uic_FechaFin.Value = Now
        CargaCombo()
    End Sub
    Private Sub CargaCombo()
        Dim Neg As New Combos
        Try
            Me.uic_Usuario.DataSource = Neg.GetUsuario
            Me.uic_Usuario.DisplayMember = "nombre"
            Me.uic_Usuario.ValueMember = "id"

            Me.uic_familia.DataSource = Neg.getFamilia
            Me.uic_familia.DisplayMember = "nombre"
            Me.uic_familia.ValueMember = "id"

            Me.uic_producto.DataSource = Neg.getProductos
            Me.uic_producto.DisplayMember = "nombre"
            Me.uic_producto.ValueMember = "id"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub uic_Imprime_Click(sender As Object, e As EventArgs) Handles uic_Imprime.Click
        Dim frm As New Info_Productos
        frm.FechaIni = Format(Me.uic_FechaIni.Value, "yyyy-dd-MM")
        frm.FechaFin = Format(Me.uic_FechaFin.Value, "yyyy-dd-MM")
        frm.Usuario = Me.uic_Usuario.SelectedValue()
        frm.Familia = Me.uic_familia.SelectedValue
        frm.Producto = Me.uic_producto.SelectedValue
        frm.Show()
    End Sub

    Private Sub uic_familia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uic_familia.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim IdFamilia As Integer = Me.uic_familia.SelectedValue
            If Not (IdFamilia = 0) Then
                BuscarProductoFamilia(IdFamilia)
            Else
                'Limpiar()
            End If
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BuscarProductoFamilia(ByVal IdFamilia As Integer)
        Dim dt As New DataTable
        Dim Neg As New ProyectoNegocio.Productos
        dt = Neg.GetProductoFamilia(IdFamilia)
        If dt.Rows.Count > 0 Then
            Me.uic_producto.DataSource = dt
            Me.uic_producto.DisplayMember = "nombre"
            Me.uic_producto.ValueMember = "id"
        Else
            Dim negP As New Combos
            Me.uic_producto.DataSource = negP.getProductos
            Me.uic_producto.DisplayMember = "nombre"
            Me.uic_producto.ValueMember = "id"
        End If
    End Sub

    Private Sub uic_limpiar_Click(sender As Object, e As EventArgs) Handles uic_limpiar.Click
        Me.uic_FechaIni.Value = Now
        Me.uic_FechaFin.Value = Now
        CargaCombo()
    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs) Handles RadMenuItem1.Click
        Me.Close()
    End Sub
End Class