Imports ProyectoNegocio

Public Class LoginForm1
    Private _IdUsuario As Integer

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim clave As String
        Dim Perfil As Integer
        Dim IdUsuario As Integer
          Dim Neg As New ProyectoNegocio.AdminCaja
        Try
            IdUsuario = DeliveryDataSet1.Tables("usuarios").Rows(Me.cbo_usuario.SelectedIndex).Item("id")
            Perfil = DeliveryDataSet1.Tables("usuarios").Rows(Me.cbo_usuario.SelectedIndex).Item("Perfil_Id")
            clave = DeliveryDataSet1.Tables("usuarios").Rows(Me.cbo_usuario.SelectedIndex).Item("clave").ToString.Trim
            If clave <> Me.PasswordTextBox.Text Then
                ErrorProvider1.SetError(Me.PasswordTextBox, "Clave no valida")
            Else
                Dim vresp As String = Neg.ValidaCaja(IdUsuario)
                If vresp = "OK" Then
                    Telerik.WinControls.RadMessageBox.Show(Me, "Usuario Tiene caja Abierta", "Alerta")
                    If MessageBox.Show("¿Cerrar Caja?", "Cierre Caja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Neg.CerrarCaja(IdUsuario, "Cierre Caja")
                        Telerik.WinControls.RadMessageBox.Show(Me, "Cierre con Exito", "Alerta")
                    End If
                    Me.ShowDialog()
                Else
                    Select Case (Perfil)
                        Case 1
                            Dim frm As New delivery
                            frm.es_supervisor = True
                            frm.IdUsuario = IdUsuario
                            frm.PerfilUsuario = Perfil
                            Me.Hide()
                            frm.ShowDialog()
                        Case 2
                            delivery.es_supervisor = False
                            Me.Hide()
                            Dim frm As New Form1
                            Dim frmMenu As New delivery
                            frm.Usuario = IdUsuario
                            frm.ShowDialog()
                            frm.Hide()
                            frmMenu.IdUsuario = IdUsuario
                            frmMenu.PerfilUsuario = Perfil
                            frmMenu.ShowDialog()
                        Case 4
                            Me.Hide()
                            Dim frm As New FrmCaja
                            Dim frmMenu As New delivery
                            frm.IdUsuario = IdUsuario
                            frm.ShowDialog()
                            frm.Hide()
                            frmMenu.IdUsuario = IdUsuario
                            frmMenu.PerfilUsuario = Perfil
                            frmMenu.ShowDialog()
                    End Select
                End If
                Me.Hide()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        System.Diagnostics.Process.GetCurrentProcess().Kill()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsuariosTableAdapter.Fill(Me.DeliveryDataSet1.usuarios)
        Me.cbo_usuario.SelectedValue = -1

        Dim ruta As String = "C:\POS"
        If Not System.IO.Directory.Exists(ruta) Then
            System.IO.Directory.CreateDirectory(ruta)
        End If
        ruta &= "\Imagen"
        If Not System.IO.Directory.Exists(ruta) Then
            System.IO.Directory.CreateDirectory(ruta)
        End If
        Dim neg As New ProyectoNegocio.FamiliaProducto
        Dim res As String = neg.TraerImagenes(ruta)
    End Sub

End Class
