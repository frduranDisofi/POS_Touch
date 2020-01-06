Public Class formapago

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        Try
            If (txt_formaPago.Text = "") Then
                MessageBox.Show("Ingrese Dato.")
                txt_formaPago.Focus()
            Else
                Dim fpago As New Fpago
                Dim prueba As Integer = 0
                If (fpago.agregarFpago(txt_formaPago.Text)) Then
                    prueba = 1
                End If

                If prueba = 1 Then
                    MessageBox.Show("Agregado Corectamente.")
                    limpiar()
                Else
                    MessageBox.Show("Error al agregar.")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub formapago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCb()
        Me.cbo_formaPago.SelectedIndex = -1
    End Sub
    Private Sub limpiar()
        llenarCb()
        Me.cbo_formaPago.SelectedIndex = -1
        Me.txt_formaPago.Text = ""
    End Sub

    Private Sub llenarCb()
        Try
            Dim dt As DataTable
            Dim fpago As New Fpago
            dt = fpago.traerFpago()
            If (dt.Rows.Count > 0) Then
                For Each DataRow In dt.Rows
                    cbo_formaPago.DataSource = dt
                    cbo_formaPago.DisplayMember = "formapago"
                    cbo_formaPago.ValueMember = "id"
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_formaPago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_formaPago.TextChanged
        txt_formaPago.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Try
            If (txt_formaPago.Text = "") Then
                MessageBox.Show("Ingrese Cargo.")
                txt_formaPago.Focus()
            Else
                Dim fpago As New Fpago
                Dim prueba As Integer
                Dim dialog As DialogResult = MessageBox.Show("Desea editar el Cargo?", "Editar Cargo", MessageBoxButtons.YesNo)
                If (dialog = Windows.Forms.DialogResult.Yes) Then
                    Dim codigo As Integer = Me.cbo_formaPago.SelectedValue
                    If (fpago.editarFpago(txt_formaPago.Text, codigo)) Then
                        prueba = 1
                    End If
                    If prueba = 1 Then
                        MessageBox.Show("Editado Exitosamente")
                        limpiar()
                    Else
                        MessageBox.Show("Error al Editar")
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbo_formaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_formaPago.SelectedIndexChanged
        traerFpago()
        If Me.cbo_formaPago.Text = "" Then
            Me.btn_grabar.Enabled = True
            Me.btn_modificar.Enabled = False
            Me.btn_eliminar.Enabled = False
        Else
            Me.btn_grabar.Enabled = False
            Me.btn_modificar.Enabled = True
            Me.btn_eliminar.Enabled = True
        End If
    End Sub

    Private Sub traerFpago()
        Dim codigo As Integer = 0
        Try
            Dim fpago As New Fpago
            Dim dt As DataTable
            codigo = Me.cbo_formaPago.SelectedValue
            dt = fpago.traerFpagoId(codigo)
            If (dt.Rows.Count > 0) Then
                For Each DataRow In dt.Rows
                    Me.txt_formaPago.Text = dt.Rows(0)(0)

                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim codigo As Integer = 0
        Try
            Dim dialog As DialogResult = MessageBox.Show("Desea Eliminar?", "Eliminar", MessageBoxButtons.YesNo)
            If (dialog = Windows.Forms.DialogResult.Yes) Then
                Dim fpago As New Fpago
                Dim prueba As Integer = 0
                codigo = Me.cbo_formaPago.SelectedValue
                If (fpago.eliminarFpago(codigo)) Then
                    prueba = 1
                End If
                If prueba = 1 Then
                    MessageBox.Show("Eliminada Correctamente.")
                    limpiar()
                Else
                    MessageBox.Show("Error al eliminar")
                    limpiar()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class