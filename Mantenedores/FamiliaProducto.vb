Imports System.IO
Imports System.Drawing.Imaging

Public Class FamiliaProducto
    Private Linea As Integer
    Private obc_impresora As New Sel_Impresora
    Private Lista_impresoras As New ArrayList

    Private Sub Impresoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lista_impresoras = obc_impresora.lista_impresoras
        cbxImpresora.Items.Clear()
        cbxImpresora.Items.AddRange(Lista_impresoras.ToArray)
        Me.btn_grabar.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Try
            cbxImpresora.SelectedValue = 0
        Catch ex As Exception
        End Try
        Limpiar()
    End Sub

    Private Sub FamiliaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_grilla()
        btn_modificar.Enabled = False
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Dim impresoraFamilia As String = ""
        Dim dt As String = ""
        Dim res As String = ""
        If Me.uic_FamiliaProducto.Text = "" Then
            MsgBox("Debe agregar Familia")
            Me.uic_FamiliaProducto.Focus()
            Exit Sub
        End If
        If Me.cbxImpresora.SelectedIndex <> -1 Then
            impresoraFamilia = Me.cbxImpresora.SelectedItem.ToString
        Else
            MsgBox("Debe Agregar Impresora", vbInformation, "Aviso")
            Exit Sub
        End If

        Try
            Dim Neg As New ProyectoNegocio.FamiliaProducto
            Dim Familia As String = uic_FamiliaProducto.Text.Trim

            dt = Neg.GrabarFamilia(Familia, impresoraFamilia)
            If CInt(dt) > 0 Then
                GrabarFoto(dt)

                MsgBox("Familia Agregada", vbInformation, "Aviso")
                Limpiar()
                carga_grilla()
            End If
            Catch ex As Exception
            End Try
    End Sub
    Private Sub GrabarFoto(ByVal id As Integer)
        Try
            Dim Archivo() As Byte
            Dim Fstream As New System.IO.FileStream(OpenFileDialog1.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            Dim reader As New BinaryReader(Fstream)
            Archivo = reader.ReadBytes(Fstream.Length)
            Fstream.Close()
            reader.Close()
            Me.Cursor = Cursors.WaitCursor
            Dim oconexion As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(My.Settings.deliveryConnectionString)
            Try
                oconexion.Open()
                Dim ocomando As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand
                ocomando.CommandText = "insert into FamiliaFoto (FamiliaId,Foto,FotoNombre) values (@IdFamilia,@Foto,@FotoNombre)"
                ocomando.Parameters.Clear()
                ocomando.Parameters.Add("@IdFamilia", SqlDbType.Int).Value = id
                ocomando.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = Archivo
                ocomando.Parameters.Add("@FotoNombre", SqlDbType.NVarChar).Value = Me.uic_FamiliaProducto.Text
                ocomando.Connection = oconexion
                ocomando.ExecuteNonQuery()
                oconexion.Close()
                Me.Cursor = Cursors.Default

            Catch ex As Exception
                MsgBox(ex.Message)
                oconexion.Close()
                Me.Cursor = Cursors.Default
            End Try

            Me.PictureBox1.Visible = False
            Dim ruta As String = "C:\POS\Imagen"
            Dim neg As New ProyectoNegocio.FamiliaProducto
            Dim res As String = neg.TraerImagenes(ruta)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub carga_grilla()
        Dim dt As New DataTable
        Dim Neg As New ProyectoNegocio.FamiliaProducto
        dt = Neg.GetFamiliaProducto
        If dt.Rows.Count > 0 Then
            Me.RadGridView1.DataSource = dt
            ConfiguraGrilla()
        Else
            Me.RadGridView1.DataSource = Nothing
        End If
    End Sub
    Private Sub ConfiguraGrilla()
        Me.RadGridView1.Columns("CodigoFamilia").IsVisible = False
        Me.RadGridView1.Columns("Impresora").IsVisible = False
        Me.RadGridView1.Columns("Impresora").ReadOnly = False
        Me.RadGridView1.Columns("Familia").Width = 200
        Me.RadGridView1.Columns("Familia").IsVisible = True
        Me.RadGridView1.Columns("Familia").ReadOnly = False
        Me.RadGridView1.Columns("Familia").HeaderText = "Familia"

        Me.RadGridView1.Columns("FotoNombre").IsVisible = False
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub uic_FamiliaProducto_TextChanged(sender As Object, e As EventArgs) Handles uic_FamiliaProducto.TextChanged
        Me.uic_FamiliaProducto.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_CodigoFamilia_TextChanged(sender As Object, e As EventArgs) Handles uic_CodigoFamilia.TextChanged
        Me.uic_CodigoFamilia.CharacterCasing = CharacterCasing.Upper
    End Sub
   
    Private Sub RadGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles RadGridView1.MouseDoubleClick
        Try
            Linea = Me.RadGridView1.Rows.IndexOf(Me.RadGridView1.CurrentRow)
            'If Me.RadGridView1.Rows(Linea).Cells(1).Value <> "PROMOCION" Then
            Me.uic_CodigoFamilia.Text = Me.RadGridView1.Rows(Linea).Cells(0).Value
            Me.uic_FamiliaProducto.Text = Me.RadGridView1.Rows(Linea).Cells(1).Value
            Me.uic_RutaImagen.Text = Me.RadGridView1.Rows(Linea).Cells(2).Value
            Me.cbxImpresora.Text = Me.RadGridView1.Rows(Linea).Cells(3).Value
            Me.btn_modificar.Enabled = True
            Me.btn_eliminar.Enabled = True
            Me.btn_grabar.Enabled = False
            'Else
            'Telerik.WinControls.RadMessageBox.Show("No se puede modificar familia promocion", "Familia")
            'Me.uic_CodigoFamilia.Text = ""
            'Me.uic_FamiliaProducto.Text = ""
            'Me.uic_RutaImagen.Text = ""
            'Me.cbxImpresora.Text = ""
            'Me.btn_modificar.Enabled = False
            'Me.btn_eliminar.Enabled = False
            'Me.btn_grabar.Enabled = True
            'End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If Me.uic_FamiliaProducto.Text = "" Then
            MsgBox("Debe agregar Familia")
            Me.uic_FamiliaProducto.Focus()
            Exit Sub
        End If
        If Me.uic_RutaImagen.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show(Me, "Debe seleccionar imagen", "Alerta")
            Me.uic_RutaImagen.Focus()
            Exit Sub
        End If
        Dim resp As String = ""
        Dim neg As New ProyectoNegocio.FamiliaProducto
        resp = neg.ModificarFamilia(Me.uic_CodigoFamilia.Text, Me.uic_FamiliaProducto.Text, Me.cbxImpresora.Text)
        If resp = "OK" Then
            'If Not File.Exists("c:\POS\Imagen\" & Me.uic_CodigoFamilia.Text & ".jpg") Then
            If Me.uic_FamiliaProducto.Text <> Me.uic_RutaImagen.Text Then
                GrabarFoto(Me.uic_CodigoFamilia.Text)
            End If

        Telerik.WinControls.RadMessageBox.Show(Me, "Registro modificado exitosamente", "Alerta")
        carga_grilla()
        Limpiar()
        'Else
        '    carga_grilla()
        'End If
        Else
        Telerik.WinControls.RadMessageBox.Show(Me, "A ocurrido un error" & vbCrLf & resp, "Alerta")
        End If
    End Sub
    Private Sub Limpiar()
        Me.uic_CodigoFamilia.Text = ""
        Me.uic_FamiliaProducto.Text = ""
        Me.cbxImpresora.Text = ""
        carga_grilla()
        Me.btn_grabar.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.uic_RutaImagen.Text = ""
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.Dispose()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Me.uic_CodigoFamilia.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show(Me, "Debe Seleccionar Familia", "Alerta")
            Exit Sub
        End If
        Dim resp As String = ""
        Dim neg As New ProyectoNegocio.FamiliaProducto
        resp = neg.EliminarFamilia(Me.uic_CodigoFamilia.Text)
        If resp = "OK" Then
            Telerik.WinControls.RadMessageBox.Show(Me, "Familia Fue Eliminada Con Exito", "Alerta")
            carga_grilla()
            Limpiar()
        Else
            Telerik.WinControls.RadMessageBox.Show(Me, "A ocurrido un error" & vbCrLf & resp, "Alerta")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()

        If Windows.Forms.DialogResult.OK Then
            Me.uic_RutaImagen.Text = OpenFileDialog1.FileName

            Dim ExtensionArchivo As String = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Extension.ToString
            If ExtensionArchivo.ToUpper = ".JPG" Then
                Me.PictureBox1.Visible = True
                Me.PictureBox1.Image = ByteArrayToImage(ImageToByteArray(Image.FromFile(OpenFileDialog1.FileName)), True)

            Else
                Telerik.WinControls.RadMessageBox.Show(Me, "El archivo debe ser con extension JPG", "Aviso")
            End If
        End If
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
            Dim max As Integer = 140
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

    Private Function IsFileOpen(filePath As String) As Boolean
        Dim rtnvalue As Boolean = False
        Try
            Dim fs As System.IO.FileStream = System.IO.File.OpenWrite(filePath)
            fs.Close()
        Catch ex As System.IO.IOException
            rtnvalue = True
        End Try
        Return rtnvalue
    End Function

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub
End Class