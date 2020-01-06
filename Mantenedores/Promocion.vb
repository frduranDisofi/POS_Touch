Imports ProyectoNegocio
Public Class Promocion
    Private Linea As Integer
    Private vIdProducto As Integer
    Private Sub Promocion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargacombo()
    End Sub
    Private Sub cargacombo()
        Dim neg As New combos
        Try
            Me.uic_Oferta.DataSource = neg.getOfertas
            Me.uic_Oferta.DisplayMember = "nombre"
            Me.uic_Oferta.ValueMember = "id"

            Me.uic_Familia.DataSource = neg.getFamilia
            Me.uic_Familia.DisplayMember = "nombre"
            Me.uic_Familia.ValueMember = "id"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub uic_Promocion_TextChanged(sender As Object, e As EventArgs) Handles uic_Promocion.TextChanged
        Me.uic_Promocion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_CodigoPromocion_TextChanged(sender As Object, e As EventArgs)
        ' Me.uic_CodigoPromocion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_precio.KeyPress
        Dim valida As String = "0123456789" & Convert.ToChar(8)
        If (valida.Contains("" + e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub uic_Volver_Click(sender As Object, e As EventArgs) Handles uic_Volver.Click
        Me.Close()
    End Sub

    Private Sub uic_Familia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uic_Familia.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim IdFamilia As Integer = Me.uic_Familia.SelectedValue
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
        dt = Neg.GetProductoOferta(IdFamilia)
        If dt.Rows.Count > 0 Then
            Me.GridProductos.DataSource = dt
            If dt.Rows(0)("id_producto") <> 0 Then
                ConfiguraGrillaProducto()
            Else
                Me.GridProductos.DataSource = Nothing
            End If
        Else
            Me.GridProductos.DataSource = Nothing
        End If
    End Sub
    Private Sub ConfiguraGrillaProducto()
        Me.GridProductos.Columns("id_producto").IsVisible = False

        Me.GridProductos.Columns("descripcion_producto").Width = 230
        Me.GridProductos.Columns("descripcion_producto").IsVisible = True
        Me.GridProductos.Columns("descripcion_producto").ReadOnly = True
        Me.GridProductos.Columns("descripcion_producto").HeaderText = "Producto"

        Me.GridProductos.Columns("precio").IsVisible = False
        Me.GridProductos.Columns("codigo_interno").IsVisible = False
        Me.GridProductos.Columns("codigo").IsVisible = False
        Me.GridProductos.Columns("IdFamilia").IsVisible = False
        Me.GridProductos.Columns("Familia").IsVisible = False
    End Sub

    Private Sub GridProductos_Click(sender As Object, e As EventArgs) Handles GridProductos.Click

    End Sub
    
    Private Sub GridProductos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GridProductos.MouseDoubleClick
        Dim Nombre As String = ""
        Try
            If Me.GridProductos.Rows.Count > 0 Then
                Linea = Me.GridProductos.Rows.IndexOf(Me.GridProductos.CurrentRow)
                Me.vIdProducto = Me.GridProductos.Rows(Linea).Cells(0).Value
                Nombre = Me.GridProductos.Rows(Linea).Cells(1).Value
                If Me.uic_Cantidad.Text = "" Or Me.uic_Cantidad.Text = "0" Then
                    Me.GridOferta.Rows.Add(Me.vIdProducto, Nombre, CInt(1), 0, 0, "Eliminar")
                Else
                    Me.GridOferta.Rows.Add(Me.vIdProducto, Nombre, CInt(Me.uic_Cantidad.Text), 0, 0, "Eliminar")
                End If
                Me.uic_Cantidad.Text = ""
                Me.uic_Producto.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MasterTemplate_Click(sender As Object, e As EventArgs) Handles GridOferta.Click

    End Sub

    Private Sub GridOferta_CommandCellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles GridOferta.CommandCellClick
        Try
            If Me.GridOferta.Columns.Contains("Eliminar") Then
                Dim pos As Integer = Me.GridOferta.Rows.IndexOf(Me.GridOferta.CurrentRow)
                Me.GridOferta.Rows.RemoveAt(pos)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub uic_Buscar_Click(sender As Object, e As EventArgs)
        BuscarProductos()
    End Sub
    Private Sub BuscarProductos()
        Dim categoria As Integer = 0
        If Me.uic_Familia.SelectedValue = 0 Then
            categoria = 0
        Else
            categoria = Me.uic_Familia.SelectedValue
        End If
        Dim buscar As String = Me.uic_Producto.Text

        Dim dt As New DataTable
        Dim Neg As New ProyectoNegocio.Productos
        If dt.Rows.Count > 0 Then
            Me.GridProductos.DataSource = dt
            ConfiguraGrillaProducto()
        Else
            Me.GridProductos.DataSource = Nothing
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Me.uic_Promocion.Text = "" Then
            Me.uic_Promocion.Focus()
            Exit Sub
        End If
        If Me.uic_precio.Text = "" Then
            Me.uic_precio.Focus()
            Exit Sub
        End If
        If Me.GridOferta.Rows.Count = 0 Then
            MsgBox("Debe ingresar productos a oferta")
            Exit Sub
        End If
        Dim Neg As New ProyectoNegocio.Ofertas
        Dim resp As Integer = 0
        resp = Neg.GrabaOFerta(Me.uic_Promocion.Text, CInt(Me.uic_precio.Text))
        Dim resp2 As String = ""
        If resp > 0 Then
            Dim numlineas As Integer = Me.GridOferta.Rows.Count - 1
            For i = 0 To numlineas
                Dim IdOferta As Integer = resp
                Dim linea As Integer = i + 1
                Dim IdProducto As Integer = Me.GridOferta.Rows(i).Cells(0).Value
                Dim cantidad As Integer = Me.GridOferta.Rows(i).Cells(2).Value
                Dim precio As Integer = Me.GridOferta.Rows(i).Cells(3).Value

                resp2 = Neg.GrabaDetalleOferta(IdOferta, linea, IdProducto, cantidad, precio)
            Next
            Telerik.WinControls.RadMessageBox.Show("Registro grabado correctamente", "Ofertas")
            cargacombo()
            limpiar()
        Else
            Telerik.WinControls.RadMessageBox.Show("A ocurrido un error " & resp, "Aviso")
        End If
    End Sub
    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        Dim Neg As New ProyectoNegocio.Ofertas
        Dim Activo As Integer = 0
        Dim resp As String = ""
        If Me.uic_Activo.CheckState = CheckState.Checked Then
            Activo = 1
        Else
            Activo = 0
        End If
        Dim IdOFerta As Integer = Me.uic_Oferta.SelectedValue
        resp = Neg.ActualizaOferta(IdOFerta, Me.uic_Promocion.Text, CInt(Me.uic_precio.Text), Activo)
        Dim resp2 As String = ""
        If resp = "OK" Then
            Dim numlineas As Integer = Me.GridOferta.Rows.Count - 1
            For i = 0 To numlineas
                If i = 0 Then
                    resp2 = Neg.BorrarDetalleOferta(IdOFerta)
                End If
                Dim linea As Integer = i + 1
                Dim IdProducto As Integer = Me.GridOferta.Rows(i).Cells(0).Value
                Dim cantidad As Integer = Me.GridOferta.Rows(i).Cells(2).Value
                Dim precio As Integer = Me.GridOferta.Rows(i).Cells(3).Value
                resp2 = Neg.GrabaDetalleOferta(IdOFerta, linea, IdProducto, cantidad, precio)
            Next
            Telerik.WinControls.RadMessageBox.Show("Registro modificado correctamente", "Ofertas")
            Limpiar()
        Else
            Telerik.WinControls.RadMessageBox.Show("A ocurrido un error " & resp, "Aviso")
        End If
    End Sub
    Private Sub uic_Oferta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uic_Oferta.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim IdOferta As String = CStr(Me.uic_Oferta.SelectedValue)
            If Not (IdOferta = 0) Then
                BuscarOferta(IdOferta)
            Else
                limpiar()
            End If
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BuscarOferta(ByVal IdOferta As Integer)
        Dim dt As New DataTable
        Dim Neg As New Ofertas
        dt = Neg.BuscarOfertaCompleta(IdOferta)
        If dt.Rows.Count > 0 Then
            Me.GridOferta.Rows.Clear()
            Me.uic_Promocion.Text = dt.Rows(0)("NombreOferta")
            Me.uic_precio.Text = dt.Rows(0)("PrecioOferta")
            If dt.Rows(0)("Activo") = 1 Then
                Me.uic_Activo.CheckState = CheckState.Checked
            Else
                Me.uic_Activo.CheckState = CheckState.Unchecked
            End If
            If Not IsDBNull(dt.Rows(0)("Cantidad")) = True Then
                For Each d As DataRow In dt.Rows
                    Me.GridOferta.Rows.Add(d("IdProducto"), d("Descripcion_Producto"), d("Cantidad"), d("Precio"), d("Linea"), ("Eliminar"))
                Next
            End If
            

            Me.btnGrabar.Enabled = False
            Me.Btn_Modificar.Enabled = True
            Me.btnEliminar.Enabled = True

        Else

            Me.btnGrabar.Enabled = True
            Me.Btn_Modificar.Enabled = False
            Me.btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Sub Limpiar()
        Me.uic_Promocion.Text = ""
        Me.uic_precio.Text = ""
        Me.GridOferta.Rows.Clear()
        Me.btnGrabar.Enabled = True
        Me.Btn_Modificar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.uic_Activo.CheckState = CheckState.Unchecked
        Me.uic_Oferta.SelectedValue = 0
        Me.GridProductos.DataSource = Nothing
        Try
            Me.uic_Familia.SelectedValue = 0
        Catch ex As Exception
        End Try
        Me.uic_Producto.Text = ""
        Me.uic_Cantidad.Text = ""
    End Sub

    
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Neg As New ProyectoNegocio.Ofertas
        Dim IdOFerta As Integer = Me.uic_Oferta.SelectedValue
        Dim resp As String = ""
        resp = Neg.EliminaOferta(IdOFerta)
        If resp = "OK" Then
            Telerik.WinControls.RadMessageBox.Show("Eliminara registro correctamente", "Elimina oferta")
            Limpiar()
            cargacombo()
        Else
            Telerik.WinControls.RadMessageBox.Show("A ocurrido un error " & vbCrLf & resp, "Alerta")
        End If
    End Sub
End Class