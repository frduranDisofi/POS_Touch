Public Class usuario

    Private Sub usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DeliveryDataSet.usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.DeliveryDataSet.usuarios)

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If Me.Validate Then
            Me.UsuariosBindingSource.EndEdit()
            Me.UsuariosTableAdapter.Update(Me.DeliveryDataSet)
        Else
            System.Windows.Forms.MessageBox.Show(Me, "error.", "save", System.Windows.Forms.MessageBoxIcon.Warning)
        End If
    End Sub
End Class