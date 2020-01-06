Public Class ImpresionCopia
    Private vId As Integer = 0

    Private Sub ImpresionCopia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getimpresoras()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New Impresoras
        frm.inicia()
        frm.ShowDialog()
        If frm.Impresora_Select <> "Vacio" Then
            Me.uic_primera.Text = frm.Impresora_Select
        End If
    End Sub

    

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim neg As New ProyectoNegocio.Impresoras
        Dim resp As String = ""
        If Me.uic_primera.Text = "" Then
            MsgBox("Debe ingresar impresora ticket")
            Exit Sub
        End If
        If Me.uic_Segunda.Text = "" Then
            MsgBox("Debe ingresar impresora boleta")
            Exit Sub
        End If
        resp = neg.GrabaImpresoras(Me.uic_primera.Text, vId, Me.uic_Segunda.Text)
        If resp = "OK" Then
            Telerik.WinControls.RadMessageBox.Show("Graba registros correctamente", "Impresoras")
        Else
            Telerik.WinControls.RadMessageBox.Show("A ocurrido un error" & vbCrLf & resp, "Impresoras")
        End If
    End Sub
    Private Sub getimpresoras()
        Dim dt As New DataTable
        Dim neg As New ProyectoNegocio.Impresoras
        dt = neg.GetImpresoras()
        If dt.Rows.Count > 0 Then
            Me.uic_primera.Text = dt.Rows(0)("ImpresoraUno")
            Me.uic_Segunda.Text = dt.Rows(0)("ImpresoraDos")
            Me.vId = dt.Rows(0)("Id")
        End If
    End Sub

    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Impresoras
        frm.inicia()
        frm.ShowDialog()
        If frm.Impresora_Select <> "Vacio" Then
            Me.uic_Segunda.Text = frm.Impresora_Select
        End If
    End Sub
End Class