Public Class DatosGral
    Private myhelpher2 As New dac.myhelper2
    Private lineas As New Hashtable

    Private Sub DatosGral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        traeParametros()
    End Sub
    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        actualizaParametros()
        traeParametros()
    End Sub
    
    Private Sub actualizaParametros()
        Dim comando_SQL As String = ""
        Dim runnerscript As New dac.runnerScript
        Dim file_temp As String = My.Computer.FileSystem.GetTempFileName
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_rutEmp.Text.Trim & "'  where nombre_param='RUTEmpresa' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_razonSocial.Text.Trim & "'  where nombre_param='RznSoc' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_giro.Text.Trim & "'  where nombre_param='Giro' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_direccion.Text.Trim & "'  where nombre_param='DirOrigen' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_ciudad.Text.Trim & "'  where nombre_param='CiudadOrigen' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_comuna.Text.Trim & "'  where nombre_param='ComunaOrigen' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_emailEmpresa.Text.Trim & "'  where nombre_param='Email_empresa' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_telefonos.Text.Trim & "'  where nombre_param='Telefonos' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update parametros set valor_param ='" & Me.uic_licencia.Text.Trim & "'  where nombre_param='Licencia' " & vbCrLf & "GO" & vbCrLf
        My.Computer.FileSystem.WriteAllText(file_temp, comando_SQL, False)
        Dim resp As String = runnerscript.ejecuta_file_script(My.Settings.deliveryConnectionString, file_temp)
        If resp = "OK" Then
            MsgBox("Parametros actualizados")
        End If
        Try
            Kill(file_temp)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub traeParametros()
        Dim paramG As New DataTable
        Dim parametros As New Dictionary(Of String, String)

        paramG = myhelpher2.ExecuteDataSet(My.Settings.deliveryConnectionString, CommandType.Text, "select * from parametros", Nothing, 60).Tables(0)
        For Each elem As DataRow In paramG.Rows
            parametros.Add(elem.Item("nombre_param").ToString.Trim, elem.Item("valor_param").ToString.Trim)
        Next
        Me.uic_rutEmp.Text = parametros("RUTEmpresa")
        Me.uic_razonSocial.Text = parametros("RznSoc")
        Me.uic_giro.Text = parametros("Giro")
        Me.uic_direccion.Text = parametros("DirOrigen")
        Me.uic_ciudad.Text = parametros("CiudadOrigen")
        Me.uic_comuna.Text = parametros("ComunaOrigen")
        Me.uic_emailEmpresa.Text = parametros("Email_empresa")
        Me.uic_telefonos.Text = parametros("Telefonos")
        Me.uic_licencia.Text = parametros("Licencia")
        'Me.uicImpresora.Text = parametros("Impresora")
        'Me.uic_numerocopias.Text = parametros("NroCopias")
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub


    Private Sub uic_rutEmp_TextChanged(sender As Object, e As EventArgs) Handles uic_rutEmp.TextChanged
        Me.uic_rutEmp.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_razonSocial_TextChanged(sender As Object, e As EventArgs) Handles uic_razonSocial.TextChanged
        uic_razonSocial.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_giro_TextChanged(sender As Object, e As EventArgs) Handles uic_giro.TextChanged
        uic_giro.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_direccion_TextChanged(sender As Object, e As EventArgs) Handles uic_direccion.TextChanged
        uic_direccion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_ciudad_TextChanged(sender As Object, e As EventArgs) Handles uic_ciudad.TextChanged
        uic_ciudad.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_comuna_TextChanged(sender As Object, e As EventArgs) Handles uic_comuna.TextChanged
        uic_comuna.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_numerocopias_KeyPress(sender As Object, e As KeyPressEventArgs)
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

End Class