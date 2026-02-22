Public Class DPA
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        DPA_Approved.Show()
        Me.Hide()
    End Sub

    Private Sub btnSubmitNilai_Click(sender As Object, e As EventArgs) Handles btnSubmitNilai.Click
        DPA_SubmitNilai.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub
End Class