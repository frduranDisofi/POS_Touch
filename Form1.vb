Imports System.Drawing
Imports System.ComponentModel
Imports System.IO
Imports System.Drawing.Imaging
Imports proyectoDTO

Public Class Form1
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Dim myhelper As New dac.myhelper2
    'Dim obc_RM As New ReportMan.RMan
    Private IdPago As String = 0
    Private tipoPago As String = ""
    Private _usuario As Integer

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Public Property Usuario As Integer
        Get
            Return _usuario
        End Get
        Set(value As Integer)
            _usuario = value
        End Set
    End Property

    Private Sub lawea2(ByVal sender As Object, ByVal e As EventArgs)
        Me.FlowLayoutPanel1.Controls.Clear()
        Dim famili As System.Windows.Forms.Button = sender
        Dim idfamilia As String = sender.name
        'MsgBox(idfamilia)
        ' If famili.Text <> "PROMOCION" Then
        'If idfamilia <> "23" Then //producci
        If idfamilia <> "23" Then
            Dim productos As DataTable
            Dim sql As String = "SELECT productos.id_producto, productos.descripcion_producto, productos.precio FROM productos INNER JOIN FamiliaProducto ON productos.CodigoFamilia = FamiliaProducto.CodigoFamilia WHERE (productos.CodigoFamilia = '" & idfamilia & "' and productos.Estado = 1)"
            productos = myhelper.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, sql, Nothing, 60).Tables(0)
            For Each dr As DataRow In productos.Rows
                Dim nombre As String = dr("descripcion_producto").ToString.Trim & vbCrLf & " $" & dr("precio")
                Dim id As Integer = dr("id_producto")
                Dim obcontrol As New UserControl1
                obcontrol.Controls(0).Text = nombre.Trim
                obcontrol.Controls(0).Name = id

                AddHandler CType(obcontrol.Controls(0), Button).Click, AddressOf lawea

                Me.FlowLayoutPanel1.Controls.Add(obcontrol)
            Next
        Else
            Dim oferta As DataTable
            Dim sql As String = "select CodigoOferta,NombreOferta,PrecioOferta,idOferta from Oferta WHERE Activo=1"
            oferta = myhelper.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, sql, Nothing, 60).Tables(0)
            For Each dto As DataRow In oferta.Rows
                Dim nombreO As String = dto("NombreOferta").ToString.Trim & vbCrLf & " $" & dto("PrecioOferta")
                Dim idO As String = dto("idOferta")
                Dim ocontrol As New UserControl1
                ocontrol.Controls(0).Text = nombreO.Trim
                ocontrol.Controls(0).Name = idO

                AddHandler CType(ocontrol.Controls(0), Button).Click, AddressOf lawea3
                Me.FlowLayoutPanel1.Controls.Add(ocontrol)
            Next
        End If

    End Sub
    Private Sub lawea(ByVal sender As Object, ByVal e As EventArgs)
        If Me.txt_cantidad.Text = "0" Then
            MsgBox("Cantidad debe ser mayor a 0", vbInformation, "Aviso")
            Exit Sub
        End If
        Dim id As String = sender.name
        Dim articulo As String = sender.text.ToString
        Dim dato() As String = articulo.Split("$")
        para_grilla(id, dato(0))

        calculo_total_venta()

    End Sub
    Private Sub para_grilla(ByVal id As Integer, ByVal articulo As String)
        Dim precio As Integer = 0
        Dim cantidad As Integer = 0
        Dim total_linea As Integer = 0
        Dim codigo_item As String = ""
        Dim db_precio As DataTable
        Dim repetido As Boolean = False
        Dim linea As Integer = 0
        Dim CantidadLinea As Integer = 0

        db_precio = myhelper.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "SELECT id_producto,precio FROM productos where id_producto=" & id, Nothing, 60).Tables(0)
        For Each valor As DataRow In db_precio.Rows
            precio = Val(valor("precio"))
            codigo_item = valor("id_producto")
        Next

        For index = 0 To DataGridView1.Rows.Count - 1
            If (DataGridView1.Rows(index).Cells(0).Value.ToString.Trim = codigo_item.Trim) Then
                repetido = True
                linea = index
                CantidadLinea = DataGridView1.Rows(index).Cells(1).Value.ToString
                precio = DataGridView1.Rows(index).Cells(3).Value.ToString
                Exit For
            End If
        Next


        If Me.txt_cantidad.Text = "" And repetido = False Then
            Me.DataGridView1.Rows.Add(codigo_item.Trim, 1, articulo, precio, precio)
        ElseIf Me.txt_cantidad.Text <> "" And repetido = False Then
            cantidad = Val(Me.txt_cantidad.Text)
            total_linea = Val(Me.txt_cantidad.Text) * precio
            Me.DataGridView1.Rows.Add(codigo_item.Trim, cantidad, articulo, precio, total_linea)
            Me.txt_cantidad.Text = ""
        ElseIf Me.txt_cantidad.Text <> "" And repetido Then
            Me.DataGridView1.Rows(linea).Cells(1).Value = CantidadLinea + Integer.Parse(Me.txt_cantidad.Text)
        Else
            CantidadLinea = CantidadLinea + 1
            Me.DataGridView1.Rows(linea).Cells(1).Value = CantidadLinea
            Me.DataGridView1.Rows(linea).Cells(4).Value = CantidadLinea * precio
        End If

    End Sub
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.RowCount > 0 Then
                If DataGridView1.Columns(e.ColumnIndex).Name = "Eliminar" Then
                    DataGridView1.Rows.RemoveAt(e.RowIndex)
                    calculo_total_venta()
                End If
                If DataGridView1.Columns(e.ColumnIndex).Name = "sumar" Then
                    Dim pos As Integer = Me.DataGridView1.Rows.IndexOf(Me.DataGridView1.CurrentRow)
                    Me.DataGridView1.Rows(pos).Cells(1).Value = CInt(Me.DataGridView1.Rows(pos).Cells(1).Value) + 1
                        Me.DataGridView1.Rows(pos).Cells(4).Value = CInt(Me.DataGridView1.Rows(pos).Cells(1).Value) * CInt(Me.DataGridView1.Rows(pos).Cells(3).Value)
                        calculo_total_venta()
                End If
                If DataGridView1.Columns(e.ColumnIndex).Name = "restar" Then
                    Dim pos As Integer = Me.DataGridView1.Rows.IndexOf(Me.DataGridView1.CurrentRow)
                    If Me.DataGridView1.Rows(pos).Cells(1).Value = 1 Then
                        Telerik.WinControls.RadMessageBox.Show("Debe eliminar el producto")
                    Else
                        Me.DataGridView1.Rows(pos).Cells(1).Value = CInt(Me.DataGridView1.Rows(pos).Cells(1).Value) - 1
                        Me.DataGridView1.Rows(pos).Cells(4).Value = CInt(Me.DataGridView1.Rows(pos).Cells(1).Value) * CInt(Me.DataGridView1.Rows(pos).Cells(3).Value)
                        calculo_total_venta()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub calculo_total_venta()
        Dim total As Integer
        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            total += Me.DataGridView1.Rows(i).Cells(4).Value
        Next
        Me.txt_Total.Text = total
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.F1
                Button2_Click(Nothing, Nothing)
            Case Keys.F2
                btn_Efectivo_Click(Nothing, Nothing)
            Case Keys.F3
                btn_Tarjeta_Click(Nothing, Nothing)
            Case Keys.F4
                uic_admCaja_Click(Nothing, Nothing)
            Case Keys.F6
                btn_aceptar_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Forma_pagoTableAdapter.Fill(Me.FormaPago_dateset.forma_pago)
        Me.cbo_formapago.SelectedIndex = -1

        Me.FlowLayoutFamilia.Controls.Clear()
        Dim familia As DataTable
        familia = myhelper.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "SELECT fp.CodigoFamilia, fp.Familia, Ff.FotoNombre FROM FamiliaProducto AS fp LEFT OUTER JOIN FamiliaFoto AS Ff ON fp.CodigoFamilia = Ff.FamiliaId where fp.Estado = 1", Nothing, 60).Tables(0)
        For Each dr As DataRow In familia.Rows
            'Dim oc As New U_Familia
            Dim obcontrol As New U_Familia
            Try
                Dim NFamilia As String = dr("Familia")
                Dim codigoFamilia As String = dr("CodigoFamilia")
                Dim ruta As String = ""
                Try
                    ruta = "C:\POS\Imagen\" & dr("CodigoFamilia") & ".jpg"
                Catch ex As Exception
                End Try

                obcontrol.Controls(0).Text = NFamilia
                obcontrol.Controls(0).Name = codigoFamilia
                If dr("FotoNombre").ToString.ToUpper = "SINFOTO.JPG" Then
                    obcontrol.Controls(0).BackgroundImage = My.Resources.SinFoto
                Else
                    obcontrol.Controls(0).BackgroundImage = ByteArrayToImage(ImageToByteArray(Image.FromFile(ruta)), True)
                    obcontrol.Controls(0).BackgroundImageLayout = ImageLayout.Stretch
                End If

                AddHandler CType(obcontrol.Controls(0), Button).Click, AddressOf lawea2

                Me.FlowLayoutFamilia.Controls.Add(obcontrol)
            Catch ex As Exception
                AddHandler CType(obcontrol.Controls(0), Button).Click, AddressOf lawea2

                Me.FlowLayoutFamilia.Controls.Add(obcontrol)
            End Try
        Next

    End Sub
    Private Sub llenarCb()
        Try
            Dim dt As DataTable
            Dim fpago As New Fpago
            dt = fpago.traerFpago()
            If (dt.Rows.Count > 0) Then
                For Each DataRow In dt.Rows
                    cbo_formapago.DataSource = dt
                    cbo_formapago.DisplayMember = "formapago".Trim
                    cbo_formapago.ValueMember = "id"
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_efectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_efectivo.KeyPress
        Dim valida As String = "0123456789" & Convert.ToChar(8)
        If (valida.Contains("" + e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            Me.txt_vuelto.Text = Val(Me.txt_efectivo.Text) - Val(Me.txt_Total.Text)
        End If

    End Sub
    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("Debe ingresar detalle", vbCritical)
            Exit Sub
        End If

        If Me.txt_Total.Text = "" Or Me.txt_Total.Text = "0" Then
            MsgBox("Debe Ingresar Monto Pago", vbCritical)
            Exit Sub
        End If

        If Me.txt_efectivo.Text = "" Or Me.txt_Total.Text = "0" Then
            MsgBox("Debe Ingresar Monto a Cancelar", vbCritical)
            Exit Sub
        End If

        If CInt(Me.txt_efectivo.Text) < CInt(Me.txt_Total.Text) Then
            MsgBox("Debe Ingresar Monto a Cancelar", vbCritical)
            Exit Sub

        End If

        Dim dts As New proyectoDTO.ticket
        Dim func As New ProyectoNegocio.Venta
        Dim id_doc_cab As String = ""
        Dim Neg As New ProyectoNegocio.AdminCaja

        dts.get_fecha = Format(Now, "yyyy-MM-dd")
        dts.get_forma_pago = tipoPago
        dts.get_total = Me.txt_Total.Text.Trim
        dts.get_efectivo = Me.txt_efectivo.Text.Trim
        dts.idUsuario = Usuario

        Me.Cursor = Cursors.WaitCursor
        

        Dim vresp As String = Neg.ValidaCaja(Usuario)
        If vresp = "OK" Then
            Try
                id_doc_cab = func.GrabarCab(dts)
            Catch ex As Exception
                Telerik.WinControls.RadMessageBox.Show("A ocurrido un error" & vbCrLf & id_doc_cab, "Aviso")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
        Else
            Telerik.WinControls.RadMessageBox.Show(Me, "Tiene que abrir caja", "Alerta")
            Dim frmApertura As New AperturaCaja
            frmApertura.IdUsuario = Usuario
            frmApertura.ShowDialog()
            'limpiar()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim num_linea As Integer = Me.DataGridView1.Rows.Count - 1

        If DataGridView1.Rows.Count >= 0 Then
            For i = 0 To num_linea
                Dim dts2 As New proyectoDTO.ticket
                dts2.get_id_doc = id_doc_cab
                dts2.get_descripcion = Me.DataGridView1.Rows(i).Cells(2).Value
                dts2.get_precio = Me.DataGridView1.Rows(i).Cells(3).Value
                dts2.get_total_item = Me.DataGridView1.Rows(i).Cells(4).Value
                dts2.get_cantidad = Me.DataGridView1.Rows(i).Cells(1).Value
                dts2.get_codigo = Me.DataGridView1.Rows(i).Cells(0).Value
                If func.ValidaProducto(dts2) = "OK" Then
                    'MsgBox("Producto Pertence a promocion")
                    func.DetallePromo(dts2)
                Else
                    If func.DetalleTicket(dts2) = "OK" Then
                    End If
                End If
            Next
        End If
        Dim neg_ As New ProyectoNegocio.VentaCaja
        neg_.GrabaBoleta(id_doc_cab, Usuario)

        Dim frmT As New Rpt_ticket
        frmT.idventa = id_doc_cab
        frmT.Formulario = "FrmVenta"
        frmT.IdUsuario = Usuario
        frmT.Observacion = Me.uic_Observacion.Text
        frmT.Show()
        frmT.Close()
        Me.Cursor = Cursors.Default
        Try

        Catch ex As Exception
            MsgBox("error" & ex.Message)
        End Try

        limpiar()
    End Sub
    Private Sub limpiar()
        Me.txt_efectivo.Text = ""
        Me.txt_cantidad.Text = ""
        Me.txt_Total.Text = ""
        Me.txt_vuelto.Text = ""
        Me.DataGridView1.Rows.Clear()
        Me.cbo_formapago.SelectedIndex = -1
        Me.txt_efectivo.Enabled = False
        Me.uic_Observacion.Text = ""
    End Sub
    Private Sub cbo_formapago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_formapago.SelectedIndexChanged
        If Me.cbo_formapago.Text.ToUpper <> "CONTADO" Then
            Me.txt_efectivo.Text = Me.txt_Total.Text
            Me.txt_vuelto.Text = "0"
        Else
            Me.txt_efectivo.Text = "0"
            Me.txt_vuelto.Text = Val(Me.txt_efectivo.Text) - Val(Me.txt_Total.Text)
        End If
    End Sub
    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
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
    Private Sub lawea3(ByVal sender As Object, ByVal e As EventArgs)
        Dim id As String = sender.name
        Dim articulo As String = sender.text.trim
        Dim dato() As String = articulo.Split("$")
        para_grilla_oferta(id, dato(0))

        calculo_total_venta()
    End Sub
    Private Sub para_grilla_oferta(ByVal idOferta As Integer, ByVal articulo As String)
        Dim precio As Integer = 0
        Dim cantidad As Integer = 0
        Dim total_linea As Integer = 0
        Dim codigo_item As String = ""
        Dim descripcionProducto As String = ""
        Dim Oferta As DataTable
        Dim repetido As Boolean
        Dim CantidadLinea As Integer
        Dim linea As Integer
        'Dim DetalleOferta As DataTable

        Oferta = myhelper.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "select PrecioOferta,idOferta,NombreOferta from Oferta where idOferta=" & idOferta, Nothing, 60).Tables(0)

        For Each valor As DataRow In Oferta.Rows
            codigo_item = valor("idOferta")
        Next

        For index = 0 To DataGridView1.Rows.Count - 1
            If (DataGridView1.Rows(index).Cells(0).Value.ToString.Trim = codigo_item.Trim) Then
                repetido = True
                linea = index
                CantidadLinea = DataGridView1.Rows(index).Cells(1).Value.ToString
                precio = DataGridView1.Rows(index).Cells(3).Value.ToString
                Exit For
            End If
        Next

        If repetido Then
            If Me.txt_cantidad.Text = "" Then
                Me.txt_cantidad.Text = 1
            End If
            Me.DataGridView1.Rows(linea).Cells(1).Value = CantidadLinea + CInt(Me.txt_cantidad.Text)
            Me.DataGridView1.Rows(linea).Cells(4).Value = (CantidadLinea + CInt(Me.txt_cantidad.Text)) * precio
        Else
            For Each dts2 As DataRow In Oferta.Rows
                precio = dts2("PrecioOferta")
                codigo_item = dts2("idOferta")
                descripcionProducto = dts2("NombreOferta")
                If Me.txt_cantidad.Text = "" Then
                    Me.DataGridView1.Rows.Add(codigo_item.Trim, 1, descripcionProducto, precio, precio)
                Else
                    cantidad = Val(Me.txt_cantidad.Text)
                    total_linea = Val(Me.txt_cantidad.Text) * precio
                    Me.DataGridView1.Rows.Add(codigo_item.Trim, cantidad, articulo, precio, total_linea)
                    Me.txt_cantidad.Text = ""
                End If
            Next

            'DetalleOferta = myhelper.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "select Precio,Codigo,Descripcion_Producto,Cantidad from OfertaDetalle where IdOferta=" & idOferta, Nothing, 60).Tables(0)
            'For Each dts As DataRow In DetalleOferta.Rows
            '    precio = Val(dts("Precio"))
            '    codigo_item = dts("Codigo")
            '    descripcionProducto = dts("Descripcion_Producto")
            '    cantidad = dts("Cantidad")
            '    Me.DataGridView1.Rows.Add(codigo_item.Trim, cantidad, descripcionProducto, precio, precio)
            'Next
        End If
    End Sub
    Private Sub uic_reloj_Tick(sender As Object, e As EventArgs) Handles uic_reloj.Tick
        Dim hora_formulario As String = Date.Now.ToLongTimeString
        Me.uic_FechaHora.Text = Format(Now, "dd-MM-yyyy") & "   " & hora_formulario
    End Sub
    Private Sub txt_efectivo_TextChanged(sender As Object, e As EventArgs) Handles txt_efectivo.TextChanged
        Me.txt_vuelto.Text = Val(Me.txt_efectivo.Text) - Val(Me.txt_Total.Text)
    End Sub
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()
    End Sub
    Private Sub uic_limpiaEfectivo_Click(sender As Object, e As EventArgs)
        Me.txt_efectivo.Text = "0"
    End Sub
    Private Sub btn_Efectivo_Click(sender As Object, e As EventArgs) Handles btn_Efectivo.Click
        Me.IdPago = 1
        Me.tipoPago = "Efectivo"
        txt_efectivo.Enabled = True
        Me.txt_efectivo.Text = ""
        Me.txt_efectivo.Focus()
        Me.txt_vuelto.Text = Val(Me.txt_efectivo.Text) - Val(Me.txt_Total.Text)
    End Sub
    Private Sub btn_Tarjeta_Click(sender As Object, e As EventArgs) Handles btn_Tarjeta.Click
        Me.IdPago = 2
        Me.tipoPago = "Tarjeta"
        Me.txt_efectivo.Enabled = False
        Me.txt_efectivo.Text = Me.txt_Total.Text
        Me.txt_vuelto.Text = "0"
    End Sub
    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte(), ByVal red As Boolean) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return redimensionarImagen(ms, red)
    End Function
    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Private Function redimensionarImagen(ByVal Stream As Stream, ByVal red As Boolean) As Image
        If red Then
            Dim img As Image = Image.FromStream(Stream)
            Dim max As Integer = 70
            Dim h As Integer = img.Height
            Dim w As Integer = img.Width
            Dim newH As Integer
            Dim newW As Integer

            If h > w And h > max Then
                newH = max
                newW = (w * max) / h
            ElseIf (w > h And w > max) Then
                newW = max
                newH = (h * max) / w
            Else
                newH = h
                newW = w
            End If

            If (h <> newH And w <> newW) Then
                Dim newImg As Bitmap = New Bitmap(img, newW, newH)
                Dim g As Graphics = Graphics.FromImage(newImg)
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
                g.DrawImage(img, 0, 0, newImg.Width, newImg.Height)
                Return newImg
            Else
                Return img
            End If
        Else
            Dim img As Image = Image.FromStream(Stream)
            Return img
        End If
    End Function
    Private Sub RetiroCaja_Click(sender As Object, e As EventArgs) Handles RetiroCaja.Click
        Dim frmRetiro As New Retiro
        frmRetiro.Usuario = Usuario
        frmRetiro.ShowDialog()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim resp As String = ""
    '    Dim neg As New ProyectoNegocio.AdminCaja
    '    resp = neg.CerrarCaja(Usuario)
    '    Try
    '        If CInt(resp) > 0 Then
    '            Dim frm As New CierreCaja
    '            frm.IdUsuario = Usuario
    '            frm.IdCaja = resp
    '            frm.ShowDialog()
    '            Telerik.WinControls.RadMessageBox.Show("Caja Cerrada", "Caja")
    '        Else
    '            Telerik.WinControls.RadMessageBox.Show("A ocurrido un error" & vbCrLf & resp, "Aviso")
    '        End If
    '    Catch ex As Exception
    '    End Try
    '    Me.Hide()
    'End Sub

    Private Sub FlowLayoutFamilia_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutFamilia.Paint

    End Sub

    Private Sub uic_admCaja_Click(sender As Object, e As EventArgs) Handles uic_admCaja.Click
        Dim frmAdmCaja As New AdminCaja
        frmAdmCaja.IdUsuario = Usuario
        frmAdmCaja.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.IdPago = 3
        Me.tipoPago = "Delivery"
        txt_efectivo.Enabled = True
        Me.txt_efectivo.Text = ""
        Me.txt_efectivo.Focus()
        Me.txt_vuelto.Text = Val(Me.txt_efectivo.Text) - Val(Me.txt_Total.Text)
    End Sub

End Class
