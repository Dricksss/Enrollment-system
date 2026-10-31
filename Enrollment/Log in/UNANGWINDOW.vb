Public Class UNANGWINDOW

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        If Password.Text = "123456" Then
            Me.Hide()
            Menuu.Show()
        End If
    End Sub
End Class