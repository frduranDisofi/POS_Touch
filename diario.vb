Public Class diario
    Private myhelper2 As New dac.myhelper2

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim fecha_inicio As String = Format(DateTimePicker1.Value, "yyyy-dd-MM").ToString
        Dim fecha_fin As String = Format(DateTimePicker2.Value, "yyyy-dd-MM").ToString
        Dim Neg As New ProyectoNegocio.Ventas
        Dim listado As New DataTable
        'If CDate(fecha_inicio) <= CDate(fecha_fin) Then
        listado = Neg.ReporteDiario(fecha_inicio, fecha_fin)
        DataGridView1.DataSource = listado
        'Else
        'MsgBox("Fecha Inicial mayor a Fecha Final")
        'End If
    End Sub

    Private Sub diario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = Now
        Me.DateTimePicker2.Value = Now
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim fecha_inicio As String = Format(DateTimePicker1.Value, "yyyy-dd-MM").ToString
        Dim fecha_fin As String = Format(DateTimePicker2.Value, "yyyy-dd-MM").ToString
        Dim frm As New InfoVentasDiarias
        frm.FechaIni = fecha_inicio
        frm.fechafin = fecha_fin
        frm.Show()
    End Sub
End Class