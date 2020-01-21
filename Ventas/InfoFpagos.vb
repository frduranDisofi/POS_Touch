Public Class InfoFpagos

   
    Private Sub InfoFpagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.uic_FechaIni.Value = Now
        Me.uic_FechaFin.Value = Now
    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs) Handles RadMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub uic_Imprime_Click(sender As Object, e As EventArgs) Handles uic_Imprime.Click
        Dim frm As New info_Fpago
        Dim tipo As Integer
        If Me.uic_delivery.CheckState = CheckState.Checked Then
            tipo = 1
        ElseIf Me.uic_tarjeta.CheckState = CheckState.Checked Then
            tipo = 2
        ElseIf Me.uic_contado.CheckState = CheckState.Checked Then
            tipo = 3
        Else
            tipo = 4
        End If
        frm.tipo = tipo
        frm.FechaIni = Format(Me.uic_FechaIni.Value, "yyyy-dd-MM")
        frm.FechaFin = Format(Me.uic_FechaFin.Value, "yyyy-dd-MM")
        frm.show()
    End Sub

    Private Sub uic_limpiar_Click(sender As Object, e As EventArgs) Handles uic_limpiar.Click
        Me.uic_FechaIni.Value = Now
        Me.uic_FechaIni.Value = Now
        Me.uic_delivery.CheckState = CheckState.Unchecked
        Me.uic_tarjeta.CheckState = CheckState.Unchecked
        Me.uic_contado.CheckState = CheckState.Unchecked
        Me.uic_Todos.CheckState = CheckState.Checked
    End Sub
End Class