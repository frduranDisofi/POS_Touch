Public Class Impresoras
    Private obc_impresora As New Sel_Impresora
    Private Lista_impresoras As New ArrayList
    Public Impresora_Select As String

    Public Sub inicia()
        Lista_impresoras.Clear()
        Me.Impresora_Select = "Vacio"
    End Sub
    Private Sub Impresoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lista_impresoras = obc_impresora.lista_impresoras
        uic_listaimpresoras.Items.Clear()
        uic_listaimpresoras.Items.AddRange(Lista_impresoras.ToArray)
        Try
            uic_listaimpresoras.SelectedValue = 0
        Catch ex As Exception
        End Try
    End Sub
    Private Sub uic_aceptar_Click(sender As Object, e As EventArgs) Handles uic_aceptar.Click
        If Me.uic_listaimpresoras.SelectedIndex <> -1 Then
            Me.Impresora_Select = Me.uic_listaimpresoras.SelectedItem.ToString.Trim
        Else
            Me.Impresora_Select = "Vacio"
        End If
        Me.Hide()
    End Sub

    Private Sub uic_cancelar_Click(sender As Object, e As EventArgs) Handles uic_cancelar.Click
        Me.Impresora_Select = "Vacio"
    End Sub
End Class