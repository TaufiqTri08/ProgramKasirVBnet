Public Class Menu_KelolaUser
    Private Sub cbobarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobarang.SelectedIndexChanged

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Menu_Kelolapaket.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Menu_KelolaMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Menu_Login.Show()
        Me.Hide()
    End Sub
End Class