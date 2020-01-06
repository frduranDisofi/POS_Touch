Public Class Compras_diario
    Private myhelper2 As New dac.myhelper2

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim fecha_inicio As String = Format(DateTimePicker1.Value, "yyyy-MM-dd").ToString
        Dim fecha_fin As String = Format(DateTimePicker2.Value, "yyyy-MM-dd").ToString
        Dim listado As New DataTable

        If CDate(fecha_inicio) <= CDate(fecha_fin) Then
            listado = myhelper2.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "select tipodoc,folio,fecha,rut_proveedor,neto,iva,total from cebecera_compra where fecha >= '" & fecha_inicio & "'and  fecha <=  '" & fecha_fin & "'", Nothing, 60).Tables(0)
            DataGridView1.DataSource = listado
        Else
            MsgBox("Fecha Inicial mayor a Fecha Final")
        End If
    End Sub

    Private Sub Compras_diario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = Now
        Me.DateTimePicker2.Value = Now
    End Sub
End Class