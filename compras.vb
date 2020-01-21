Imports ProyectoNegocio

Public Class compras
    Dim rut As New bc.RUTman
    Dim myhelper As New dac.myhelper2

    Private _IdUsuario As Integer

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    

    Private Sub compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = Now
        CargarCombos()
    End Sub
    Private Sub CargarCombos()
        Dim neg As New Combos
        Try
            Me.uic_familia.DataSource = neg.getFamilia
            Me.uic_familia.DisplayMember = "nombre"
            Me.uic_familia.ValueMember = "id"
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Dim Linea As Integer
        Dim Repetido As Boolean
        Dim Codigo_Item As String = Me.uic_Productos.SelectedValue
        Dim CantidadLinea As Integer
        If Me.uic_Productos.SelectedValue = 0 Then
            MsgBox("Debe Ingresar producto", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        'calculo_detalle()

        Try
            If Me.DataGridView1.Rows.Count > 0 Then
                For index = 0 To DataGridView1.Rows.Count - 1
                    If (DataGridView1.Rows(index).Cells(0).Value.ToString.Trim = Codigo_Item.Trim) Then
                        Repetido = True
                        Linea = index
                        CantidadLinea = DataGridView1.Rows(index).Cells(2).Value.ToString
                        Exit For
                    End If
                Next
            End If
            
            If Repetido Then
                Me.DataGridView1.Rows(Linea).Cells(2).Value = CantidadLinea + CInt(Me.uic_cantidad.Text)
            Else
                'If Me.DataGridView1.Rows.Count > 0 Then
                Me.DataGridView1.Rows.Add(Me.uic_Productos.SelectedValue, Me.uic_Productos.Text, Me.uic_cantidad.Text)
                Me.uic_codigo.Text = ""
                Me.uic_descripcion.Text = ""
                Me.uic_cantidad.Text = ""
                Me.uic_precio.Text = ""
                'End If
            End If


        Catch ex As Exception

        End Try
        
        limpiarStock()
    End Sub
    Private Sub calculo_detalle()
        Dim neto As Integer = 0
        Dim cantidad As Integer = 0
        Dim precio As Integer = 0
        Dim total As Integer = 0

        If Me.uic_cantidad.Text = "" Then
            cantidad = 0
        ElseIf IsNumeric(Me.uic_cantidad.Text) Then
            cantidad = Val(Me.uic_cantidad.Text)
        End If
        If Me.uic_precio.Text = "" Then
            precio = 0
        ElseIf IsNumeric(Me.uic_precio.Text) Then
            precio = Val(Me.uic_precio.Text)
        End If

        total = precio * cantidad

        Me.DataGridView1.Rows.Add(Me.uic_codigo.Text.Trim, Me.uic_descripcion.Text.Trim, cantidad, precio, total)

        'poner valor neto
        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            neto += Me.DataGridView1.Rows(i).Cells(4).Value
            Me.uic_neto.Text = neto
        Next
    End Sub

    Private Sub uic_neto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uic_neto.TextChanged
        Dim iva As Integer = 0
        iva = Val(Me.uic_neto.Text) * 19 / 100
        Me.uic_IVA.Text = iva
    End Sub

    Private Sub uic_IVA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uic_IVA.TextChanged
        Dim total As Long = 0
        total = Val(Me.uic_neto.Text) + Val(Me.uic_IVA.Text)
        Me.uic_total.Text = total
    End Sub

    Private Sub uic_descripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles uic_descripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub uic_cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles uic_cantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub uic_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles uic_precio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub uic_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles uic_codigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_folio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_folio.KeyPress
        Dim valida As String = "0123456789" & Convert.ToChar(8)
        If (valida.Contains("" + e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub uic_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uic_salir.Click
        Me.Close()
    End Sub

    Private Sub uic_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uic_grabar.Click

        If Me.txt_folio.Text = "" Then
            MsgBox("Debe ingresar folio", MsgBoxStyle.Critical, "Error")
            Me.txt_folio.Focus()
            Exit Sub
        End If

        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("Debe ingresar Detalle", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'Dim cabecera As DataTable
        Dim dts As New proyectoDTO.Compras
        Dim func As New ProyectoNegocio.Productos

        dts.Fecha_ = Format(DateTimePicker1.Value, "yyyy-dd-MM").ToString
        dts.get_folio = Val(Me.txt_folio.Text)
        dts.get_neto = Val(Me.uic_neto.Text)
        dts.get_iva = Val(Me.uic_IVA.Text)
        dts.get_total = Val(Me.uic_total.Text)
        dts.Usuario = IdUsuario

        Dim num_linea As Integer = Me.DataGridView1.Rows.Count - 1

        If DataGridView1.Rows.Count >= 0 Then
            Try
                For i = 0 To num_linea
                    'Dim dts2 As New comprar

                    dts.get_codigo = Me.DataGridView1.Rows(i).Cells(0).Value
                    dts.get_descripcion = Me.DataGridView1.Rows(i).Cells(1).Value
                    'dts.get_precio = Me.DataGridView1.Rows(i).Cells(2).Value
                    dts.get_cantidad = Me.DataGridView1.Rows(i).Cells(2).Value
                    'dts2.get_total_detalle = Me.DataGridView1.Rows(i).Cells(4).Value
                    'dts2.get_id_cab = id_doc_cab

                    Dim res As String = ""
                    res = func.GrabaStock(dts)
                    If res = "OK" Then
                        Telerik.WinControls.RadMessageBox.Show(Me, "Productos agregados a stock", "Alerta")
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
           
        End If

        limpiar()
    End Sub
    Private Sub limpiar()
        Me.txt_folio.Text = ""
        Me.uic_codigo.Text = ""
        Me.uic_descripcion.Text = ""
        CargarCombos()
        Me.DataGridView1.Rows.Clear()
    End Sub

    Private Sub limpiarStock()
        Me.txt_folio.Text = ""
        Me.uic_familia.Text = ""
        Me.uic_Productos.Text = ""
        'uic_cantidad =
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.RowCount > 0 Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "eliminar" Then
                'elimina linea
                DataGridView1.Rows.RemoveAt(e.RowIndex)
                calculo_neto2()
            End If
        End If
    End Sub

    Private Sub calculo_neto2()
        Dim total As Integer
        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            total += Me.DataGridView1.Rows(i).Cells(4).Value
        Next
        Me.uic_neto.Text = total
    End Sub

    Private Sub uic_familia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uic_familia.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Id As Integer = Me.uic_familia.SelectedValue
            If Not Id = 0 Then
                BuscarProductosFamilia(Id)
            End If
        Catch ex As Exception

        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BuscarProductosFamilia(ByVal Id As Integer)
        Dim dt As New DataTable
        Dim neg As New ProyectoNegocio.Productos
        dt = neg.getProductosFamilia(Id)
        If dt.Rows.Count > 0 Then
            Me.uic_Productos.DataSource = dt
            Me.uic_Productos.DisplayMember = "nombre"
            Me.uic_Productos.ValueMember = "id"
        Else
            Me.uic_Productos.DataSource = neg.getProductos
            Me.uic_Productos.DisplayMember = "nombre"
            Me.uic_Productos.ValueMember = "id"
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiarStock()
    End Sub
End Class
