Public Class Buscar_producto
    Private myhelpher2 As New dac.myhelper2
    Private busca As String = ""

    Private Sub txt_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        lleno_grilla()
    End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        txt_buscar.CharacterCasing = CharacterCasing.Upper
        lleno_grilla()
    End Sub

    Private Sub lleno_grilla()
        Me.DataGridView1.Rows.Clear()
        busca = txt_buscar.Text.Trim
        Dim articulo As New DataTable
        If Me.RadioCodigo.Checked = True Then
            articulo = myhelpher2.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "SELECT productos.codigo,productos.id_producto, productos.descripcion_producto,productos.precio, productos.codigo_interno, FamiliaProducto.Familia FROM productos INNER JOIN FamiliaProducto ON productos.CodigoFamilia = FamiliaProducto.CodigoFamilia where codigo like '%" & busca & "%' order by id_producto", Nothing, 60).Tables(0)
        Else
            articulo = myhelpher2.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "SELECT productos.codigo,productos.id_producto, productos.descripcion_producto,productos.precio, productos.codigo_interno, FamiliaProducto.Familia FROM productos INNER JOIN FamiliaProducto ON productos.CodigoFamilia = FamiliaProducto.CodigoFamilia where descripcion_producto like '%" & busca & "%' order by id_producto", Nothing, 60).Tables(0)
        End If

        If articulo.Rows.Count > 0 Then
            For Each dr As DataRow In articulo.Rows
                Me.DataGridView1.Rows.Add(dr("codigo"), dr("descripcion_producto"), dr("precio"), dr("codigo_interno"), dr("Familia"))
            Next
        End If

    End Sub

    Private Sub btn_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enviar.Click
        Try
            If DataGridView1.Rows.Count > 0 Then
                Productos.txt_codigo.Text = Trim(DataGridView1.SelectedRows(0).Cells(0).Value)
                Productos.txt_descripcion.Text = Trim(DataGridView1.SelectedRows(0).Cells(1).Value)
                Productos.txt_precio.Text = DataGridView1.SelectedRows(0).Cells(2).Value
                Productos.uic_Familia.Text = DataGridView1.SelectedRows(0).Cells(4).Value
                Try
                    Productos.txt_codigoInt.Text = Trim(Me.DataGridView1.Rows(0).Cells(3).Value)
                Catch ex As Exception
                    Productos.txt_codigoInt.Text = " "
                End Try

                Me.DataGridView1.Rows.Clear()
                Me.txt_buscar.Text = ""
                Me.Close()

            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("Seleccione producto", vbInformation, "Info")
        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Dispose()
    End Sub

    Private Sub Buscar_producto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Me.DataGridView1.Rows.Clear()
        busca = txt_buscar.Text.Trim
        Dim articulo As New DataTable
        articulo = myhelpher2.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "SELECT productos.codigo,productos.id_producto, productos.descripcion_producto,productos.precio, productos.codigo_interno, FamiliaProducto.Familia FROM productos INNER JOIN FamiliaProducto ON productos.CodigoFamilia = FamiliaProducto.CodigoFamilia where descripcion_producto like '%" & busca & "%' order by descripcion_producto", Nothing, 60).Tables(0)
        If articulo.Rows.Count > 0 Then
            For Each dr As DataRow In articulo.Rows
                Me.DataGridView1.Rows.Add(dr("codigo"), dr("descripcion_producto"), dr("precio"), dr("codigo_interno"), dr("Familia"))
            Next
        End If
    End Sub

    Private Sub Buscar_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RadioDescripcion.Checked = True
    End Sub

    Private Sub RadioCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioCodigo.CheckedChanged
        Me.txt_buscar.Text = ""
    End Sub

    Private Sub RadioDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDescripcion.CheckedChanged
        Me.txt_buscar.Text = ""
    End Sub
End Class