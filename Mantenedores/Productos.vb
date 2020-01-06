Imports ProyectoNegocio

Public Class Productos
    Private Linea As Integer

    Private Sub txt_descripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_descripcion.TextChanged
        txt_descripcion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txt_codigoInt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigoInt.TextChanged
        txt_codigoInt.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txt_codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        txt_codigo.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DeliveryDataSet.FamiliaProducto' table. You can move, or remove it, as needed.

        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        cargaconbo()
        Me.uic_Familia.SelectedIndex = -1
        CargarGrilla()

        Me.btn_grabar.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
    End Sub
    Private Sub cargaconbo()
        Dim neg As New Combos
        Try
            Me.uic_Familia.DataSource = neg.getFamilia
            Me.uic_Familia.DisplayMember = "nombre"
            Me.uic_Familia.ValueMember = "id"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CargarGrilla()
        Dim Neg As New ProyectoNegocio.Productos
        Dim dt As New DataTable
        dt = Neg.getProductos
        If dt.Rows.Count > 0 Then
            Me.RadGridView1.DataSource = dt
            ConfigurarGrilla()
        Else
            Me.RadGridView1.DataSource = Nothing
        End If
    End Sub
    Private Sub ConfigurarGrilla()
        Me.RadGridView1.Columns("id_producto").IsVisible = False

        Me.RadGridView1.Columns("descripcion_producto").Width = 200
        Me.RadGridView1.Columns("descripcion_producto").IsVisible = True
        Me.RadGridView1.Columns("descripcion_producto").ReadOnly = False
        Me.RadGridView1.Columns("descripcion_producto").HeaderText = "Producto"

        Me.RadGridView1.Columns("precio").Width = 80
        Me.RadGridView1.Columns("precio").IsVisible = True
        Me.RadGridView1.Columns("precio").ReadOnly = False
        Me.RadGridView1.Columns("precio").HeaderText = "Precio"

        Me.RadGridView1.Columns("codigo_interno").IsVisible = False

        Me.RadGridView1.Columns("codigo").Width = 80
        Me.RadGridView1.Columns("codigo").IsVisible = False
        Me.RadGridView1.Columns("codigo").ReadOnly = False
        Me.RadGridView1.Columns("codigo").HeaderText = "Codigo"

        Me.RadGridView1.Columns("CodigoFamilia").IsVisible = False

        Me.RadGridView1.Columns("Familia").Width = 80
        Me.RadGridView1.Columns("Familia").IsVisible = True
        Me.RadGridView1.Columns("Familia").ReadOnly = False
        Me.RadGridView1.Columns("Familia").HeaderText = "Familia"
    End Sub
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Buscar_producto.ShowDialog()
        If Me.txt_codigo.Text = "" Then
            Me.btn_modificar.Enabled = False
            Me.btn_eliminar.Enabled = False
            Me.btn_grabar.Enabled = True
        Else
            Me.btn_modificar.Enabled = True
            Me.btn_eliminar.Enabled = True
            Me.btn_grabar.Enabled = False
        End If
    End Sub

    Private Function validaProducto() As String
        Dim respuesta As String = ""
        'If Me.txt_codigo.Text = "" Then
        '    respuesta &= "Debe ingresar codigo de producto" & Chr(13)
        'End If
        If Me.txt_descripcion.Text = "" Then
            respuesta &= "Debe ingresar descripcion del producto" & Chr(13)
        End If
        If Me.txt_precio.Text = "" Then
            respuesta &= "Debe ingresar precio producto" & Chr(13)
        End If
        If Me.uic_Familia.Text = "" Then
            respuesta &= "Debe selecciona Familia del producto" & Chr(13)
        End If

        If respuesta = "" Then
            Dim dts As New producto
            Dim func As New dac.produc
            dts.get_codigo = Me.txt_descripcion.Text
            dts.get_Familia = Me.uic_Familia.SelectedValue
            respuesta &= func.ExisteCodigoProducto(dts)
        End If

        Return respuesta
    End Function
    Private Sub txt_precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio.KeyPress
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

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Dim respuesta As String = validaProducto()
        If respuesta <> "OK" Then
            MsgBox(respuesta, vbInformation, "Aviso")
            Exit Sub
        End If
        Try
            Dim dts As New producto
            Dim func As New dac.produc

            dts.get_codigo = Me.txt_codigo.Text
            dts.get_descripcion = Me.txt_descripcion.Text
            dts.get_precio = Val(Me.txt_precio.Text)
            dts.get_codigoInt = Me.txt_codigoInt.Text
            dts.get_Familia = Me.uic_Familia.SelectedValue

            If func.grabo_producto(dts) Then
                MsgBox("Producto Agregado")
            End If
            limpiar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If Me.txt_codigo.Text = "" Then
            Exit Sub
        End If
        Try
            Dim dts As New producto
            Dim func As New dac.produc

            dts.get_descripcion = Me.txt_descripcion.Text
            dts.get_precio = Val(Me.txt_precio.Text)
            If Me.txt_codigoInt.Text = "" Then
                dts.get_codigoInt = ""
                dts.get_codigo = ""
            Else
                dts.get_codigoInt = Me.txt_codigoInt.Text
                dts.get_codigo = Me.txt_codigo.Text
            End If

            dts.get_Familia = Me.uic_Familia.SelectedValue
            If func.actualiza_producto(dts) Then
                MsgBox("Producto Actualizado")
            Else

            End If
            limpiar()
        Catch ex As Exception
        End Try
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.btn_grabar.Enabled = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Me.txt_codigo.Text = "" Then
            Exit Sub
        End If
        Dim result As Integer = MessageBox.Show("Esta seguro eliminar producto?", "Producto", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            limpiar()
        ElseIf result = DialogResult.Yes Then
            Dim neg As New ProyectoNegocio.Productos
            Dim codigo As String = Me.txt_codigo.Text
            Dim vresp As String = neg.EliminaProducto(codigo)
            MsgBox("Producto Eliminado", vbInformation, "Aviso")
            limpiar()
        End If
    End Sub

    Private Sub uic_Minimizar_Click(sender As Object, e As EventArgs) Handles uic_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Close()
    End Sub


    Private Sub RadGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles RadGridView1.MouseDoubleClick
        Try
            Linea = Me.RadGridView1.Rows.IndexOf(Me.RadGridView1.CurrentRow)
            Me.txt_codigo.Text = Me.RadGridView1.Rows(Linea).Cells(0).Value
            Me.txt_descripcion.Text = Me.RadGridView1.Rows(Linea).Cells(1).Value
            Me.txt_precio.Text = Me.RadGridView1.Rows(Linea).Cells(2).Value
            Me.txt_codigoInt.Text = Me.RadGridView1.Rows(Linea).Cells(4).Value
            Me.uic_Familia.SelectedValue = Me.RadGridView1.Rows(Linea).Cells(5).Value
            Me.btn_grabar.Enabled = False
            Me.btn_modificar.Enabled = True
            Me.btn_eliminar.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        Me.txt_codigo.Text = ""
        Me.txt_descripcion.Text = ""
        Me.txt_precio.Text = ""
        Me.txt_codigoInt.Text = ""
        Me.uic_Familia.SelectedIndex = -1

        Me.btn_grabar.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        cargaconbo()
        CargarGrilla()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim frm As New InfoProducto
        frm.Show()
    End Sub
End Class