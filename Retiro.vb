Imports ProyectoNegocio

Public Class Retiro
    Private _usuario As Integer
    Public Property Usuario As Integer
        Get
            Return _usuario
        End Get
        Set(value As Integer)
            _usuario = value
        End Set
    End Property

    Private Sub uic_monto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_monto.KeyPress
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


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Not validador.validoNumero(Me.uic_monto.Text.Trim, 0) Then
            Me.uic_monto.Focus()
            Exit Sub
        End If
        Dim Monto As Integer = CType(uic_monto.Text, Integer)
        Dim Neg As New ProyectoNegocio.RetiroCaja
        Dim vresp As String = Neg.ValidaMontoRetiro(Usuario, Monto)

        If vresp = "OK" Then
            If Me.uic_monto.Text <> "" Then
                Me.DataGridView1.Rows.Add(1, "EFECTIVO", Val(Me.uic_monto.Text))
                Me.uic_monto.Text = ""
                sumar_grilla()
            End If
        Else
            MsgBox("Monto mayor a cantidad apertura")
        End If

       
        
        
    End Sub
    Public Sub sumar_grilla()
        Dim sumas As Long = 0
        For x = 0 To Me.DataGridView1.Rows.Count - 1
            sumas += Val(Me.DataGridView1.Rows(x).Cells(2).Value)
        Next
        Me.uic_monto_total_retiro.Text = FormatNumber(Val(sumas), 0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Eliminar" Then
                Try
                    Me.DataGridView1.Rows.RemoveAt(e.RowIndex)
                Catch ex As Exception
                End Try
            End If
        End If
        sumar_grilla()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        If (txtGlosa.Text = "") Then
            MsgBox("Debe Ingresar Glosa")
            Me.txtGlosa.Focus()
            Exit Sub
        End If

        Dim Monto As Integer = CInt(uic_monto_total_retiro.Text)
        Dim Glosa As String = txtGlosa.Text
        Dim Neg As New ProyectoNegocio.RetiroCaja
        Dim vresp As String = Neg.GuardarRetiro(Usuario, Monto, Glosa)
        If vresp = "OK" Then
            MsgBox("Retiro Realizado con Exito")
            Me.Hide()
        End If

    End Sub
End Class